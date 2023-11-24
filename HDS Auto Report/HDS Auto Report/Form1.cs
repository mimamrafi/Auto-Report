using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MySqlX.XDevAPI.Relational;

namespace HDS_Auto_Report
{
    public partial class Form1 : Form
    {
        ConfigGenerator ConfigInstance = new ConfigGenerator();
        int uniqueIdTemplate = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;

            // Set the column names
            dataGridView1.Columns[0].Name = "No";
            dataGridView1.Columns[1].Name = "Column";
            dataGridView1.Columns[2].Name = "Start Row";
            dataGridView1.Columns[3].Name = "Stop Row";
            dataGridView1.Columns[4].Name = "MySql Column Name";
        }

        private void TB_PlottingTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers (0-9) and certain control keys (e.g., backspace, delete, arrow keys)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block input if it's not a number or control key
            }
        }

        private void CB_TemplateFile_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_TemplateFile.Checked)
            {
                MessageBox.Show("Please fill the form in the configuration tab");
            }
            else
            {
                MessageBox.Show("It will fill the form in the configuration tab automatically");
            }
        }

        private void PB_BrowseTemplate_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog class.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Excel Template File";
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(selectedFilePath);

                // Check if the first character of the file name is a numeric digit.
                if (fileName.Length > 0 && char.IsDigit(fileName[0]))
                {
                    uniqueIdTemplate = int.Parse(fileName[0].ToString());
                }
                else
                {
                    // Handle the case where the first character is not a digit (optional).
                    // You can set a default value for uniqueIdFile or display an error message.
                    uniqueIdTemplate = -1; // For example, set to -1 or another default value.
                }

                ConfigInstance.SendTemplateId(uniqueIdTemplate);
                TB_TemplateFile.Text = selectedFilePath;
                generateDataGrid();
                // Now you can use the selected file path in your code.
            }
            ConfigInstance.SendTemplateId(2);
            int[] valColumn = ConfigInstance.getColumn;
            int[] valStarRow = ConfigInstance.getStartRow;
            int[] valStopRow = ConfigInstance.getStopRow;
            Debug.WriteLine("valColumn[] = " + string.Join(", ", valColumn));
            Debug.WriteLine("valStartRow[] = " + string.Join(", ", valStarRow));
            Debug.WriteLine("valStopRow[] = " + string.Join(", ", valStopRow));
        }

        private void generateDataGrid()
        {
            for (int i = 0; i < ConfigInstance.getLooping(); i++)
            {
                dataGridView1.Rows.Add(i + 1,
                    ConfigInstance.getColumn[i],
                    ConfigInstance.getStartRow[i],
                    ConfigInstance.getStopRow[i],
                    ConfigInstance.getMySqlColumnName[i]);
            }
        }

        private void PB_BrowseExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook template = excel.Workbooks.Open(TB_TemplateFile.Text);
            Excel.Worksheet worksheet = template.Worksheets[1];
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Excel File As";
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = saveFileDialog.FileName;
                TB_ExcelFile.Text = saveFilePath;
                worksheet.SaveAs(saveFilePath);
                excel.Quit();
            }
        }

        private void PB_Apply_Click(object sender, EventArgs e)
        {
            string connstring = "server=" + TB_Server.Text + ";uid=" + TB_Username.Text + ";pwd=" + TB_DBPassword.Text + ";database=" + TB_DBName.Text;
            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message);
                }
            }
            if (string.IsNullOrEmpty(TB_PlottingTime.Text))
            {
                MessageBox.Show("Plotting time can not empty");
            }
        }


        private int GetTotalRecordsCount(MySqlConnection connection)
        {
            string table_name = TB_TableName.Text;
            string countQuery = $"SELECT COUNT(*) FROM {table_name}";
            MySqlCommand countCommand = new MySqlCommand(countQuery, connection);
            int totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
            return totalRecords;
        }

        private void CB_Record_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Record.Checked)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("on");
            BackgroundWorker worker = sender as BackgroundWorker;

            while (!worker.CancellationPending)
            {
                try
                {
                    // Your code to update the Excel file
                    string connstring = "server=" + TB_Server.Text + ";uid=" + TB_Username.Text + ";pwd=" + TB_DBPassword.Text + ";database=" + TB_DBName.Text;
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();

                    // Calculate the starting point dynamically based on the total number of records
                    int retrieve_data = Convert.ToInt32(TB_RetrieveData.Text);
                    int totalRecords = GetTotalRecordsCount(con); // Implement this function to retrieve the total record count
                    int startingId = Math.Max(1, totalRecords - retrieve_data); // Ensure the starting point is at least 1
                    string table_name = TB_TableName.Text;

                    string sql = $"SELECT * FROM {table_name} WHERE id > {startingId} ORDER BY id ASC LIMIT {retrieve_data}";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //generate excel
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Open(TB_ExcelFile.Text); // Open the existing Excel file
                    Excel.Worksheet worksheet = workbook.Sheets[1];

                    int row = 0;
                    int columnCount = dataGridView1.Rows.Count - 1;
                    Debug.WriteLine("column count : " + columnCount);
                    while (reader.Read())
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            object ExcelColumn = dataGridView1.Rows[i].Cells[1].Value;
                            object MySqlColumn = dataGridView1.Rows[i].Cells[4].Value;
                            object StartRowColumn = dataGridView1.Rows[i].Cells[2].Value;
                            /*Debug.WriteLine("no : " + i + " , startrowcolumn : " + (int)StartRowColumn + " , row : " + row);
                            addedRow = row + addedRow;
                            if (row < (int)StartRowColumn)
                            {
                                row = (int)StartRowColumn;
                            }*/

                            //worksheet.Cells[(int)ExcelRow, (int)ExcelColumn].Value = reader[MySqlColumn.ToString()];
                            worksheet.Cells[row+(int)StartRowColumn, (int)ExcelColumn].Value = reader[MySqlColumn.ToString()];
                        }
                        row++;
                    }
                    /*
                    int[] startRows = ConfigInstance.getStartRow; // Assuming startRows contains [11, 39, 84]
                    int columnCount = ConfigInstance.getLooping();

                    while (reader.Read())
                    {
                        int currentStartRowIndex = 0; // Start with the first start row

                        for (int i = 0; i < columnCount; i++)
                        {
                            int startRow = startRows[currentStartRowIndex];
                            object ExcelColumn = dataGridView1.Rows[i].Cells[1].Value;
                            object MySqlColumn = dataGridView1.Rows[i].Cells[4].Value;
                            Debug.WriteLine("MESSAGE : " + startRow + "," + currentStartRowIndex);
                            worksheet.Cells[startRows[i] + currentStartRowIndex, (int)ExcelColumn].Value = reader[MySqlColumn.ToString()];

                            currentStartRowIndex = (currentStartRowIndex + 1) % startRows.Length; // Cycle through start rows
                        }
                    }
                    */

                    workbook.Save(); // Save the changes to the existing Excel file
                    workbook.Close();
                    excelApp.Quit();

                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                // Sleep for a short time before the next update
                Thread.Sleep(Convert.ToInt32(TB_PlottingTime.Text) * 1000); // Sleep for 1 second
            }
        }
    }
}