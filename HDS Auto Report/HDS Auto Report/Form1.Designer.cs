namespace HDS_Auto_Report
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            TW_DBConnection = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            LBL_Server = new Label();
            LBL_Username = new Label();
            LBL_DBName = new Label();
            LBL_DBPassword = new Label();
            LBL_TableName = new Label();
            LBL_RetrieveData = new Label();
            TB_Server = new TextBox();
            TB_Username = new TextBox();
            TB_DBName = new TextBox();
            TB_DBPassword = new TextBox();
            TB_TableName = new TextBox();
            TB_RetrieveData = new TextBox();
            TW_DirPath = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            PB_BrowseTemplate = new Button();
            PB_BrowseExcel = new Button();
            LBL_ExcelFile = new Label();
            TB_TemplateFile = new TextBox();
            TB_ExcelFile = new TextBox();
            CB_TemplateFile = new CheckBox();
            TW_Config = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CB_Record = new CheckBox();
            PB_Apply = new Button();
            TB_PlottingTime = new TextBox();
            LBL_PlottingTime = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            TW_DBConnection.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TW_DirPath.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TW_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TW_DBConnection);
            tabControl1.Controls.Add(TW_DirPath);
            tabControl1.Controls.Add(TW_Config);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 261);
            tabControl1.TabIndex = 0;
            // 
            // TW_DBConnection
            // 
            TW_DBConnection.Controls.Add(tableLayoutPanel2);
            TW_DBConnection.Location = new Point(4, 24);
            TW_DBConnection.Name = "TW_DBConnection";
            TW_DBConnection.Padding = new Padding(3);
            TW_DBConnection.Size = new Size(546, 233);
            TW_DBConnection.TabIndex = 0;
            TW_DBConnection.Text = "Database Connection";
            TW_DBConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LBL_Server, 0, 0);
            tableLayoutPanel2.Controls.Add(LBL_Username, 1, 0);
            tableLayoutPanel2.Controls.Add(LBL_DBName, 0, 2);
            tableLayoutPanel2.Controls.Add(LBL_DBPassword, 1, 2);
            tableLayoutPanel2.Controls.Add(LBL_TableName, 0, 4);
            tableLayoutPanel2.Controls.Add(LBL_RetrieveData, 1, 4);
            tableLayoutPanel2.Controls.Add(TB_Server, 0, 1);
            tableLayoutPanel2.Controls.Add(TB_Username, 1, 1);
            tableLayoutPanel2.Controls.Add(TB_DBName, 0, 3);
            tableLayoutPanel2.Controls.Add(TB_DBPassword, 1, 3);
            tableLayoutPanel2.Controls.Add(TB_TableName, 0, 5);
            tableLayoutPanel2.Controls.Add(TB_RetrieveData, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(540, 227);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LBL_Server
            // 
            LBL_Server.AutoSize = true;
            LBL_Server.Location = new Point(3, 0);
            LBL_Server.Name = "LBL_Server";
            LBL_Server.Size = new Size(62, 15);
            LBL_Server.TabIndex = 0;
            LBL_Server.Text = "IP Address";
            // 
            // LBL_Username
            // 
            LBL_Username.AutoSize = true;
            LBL_Username.Location = new Point(273, 0);
            LBL_Username.Name = "LBL_Username";
            LBL_Username.Size = new Size(60, 15);
            LBL_Username.TabIndex = 0;
            LBL_Username.Text = "Username";
            // 
            // LBL_DBName
            // 
            LBL_DBName.AutoSize = true;
            LBL_DBName.Location = new Point(3, 74);
            LBL_DBName.Name = "LBL_DBName";
            LBL_DBName.Size = new Size(90, 15);
            LBL_DBName.TabIndex = 0;
            LBL_DBName.Text = "Database Name";
            // 
            // LBL_DBPassword
            // 
            LBL_DBPassword.AutoSize = true;
            LBL_DBPassword.Location = new Point(273, 74);
            LBL_DBPassword.Name = "LBL_DBPassword";
            LBL_DBPassword.Size = new Size(108, 15);
            LBL_DBPassword.TabIndex = 0;
            LBL_DBPassword.Text = "Database Password";
            // 
            // LBL_TableName
            // 
            LBL_TableName.AutoSize = true;
            LBL_TableName.Location = new Point(3, 148);
            LBL_TableName.Name = "LBL_TableName";
            LBL_TableName.Size = new Size(69, 15);
            LBL_TableName.TabIndex = 0;
            LBL_TableName.Text = "Table Name";
            // 
            // LBL_RetrieveData
            // 
            LBL_RetrieveData.AutoSize = true;
            LBL_RetrieveData.Location = new Point(273, 148);
            LBL_RetrieveData.Name = "LBL_RetrieveData";
            LBL_RetrieveData.Size = new Size(67, 15);
            LBL_RetrieveData.TabIndex = 0;
            LBL_RetrieveData.Text = "Retrieve for";
            // 
            // TB_Server
            // 
            TB_Server.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Server.Location = new Point(3, 21);
            TB_Server.Name = "TB_Server";
            TB_Server.Size = new Size(264, 23);
            TB_Server.TabIndex = 1;
            TB_Server.Text = "127.0.0.1";
            // 
            // TB_Username
            // 
            TB_Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Username.Location = new Point(273, 21);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(264, 23);
            TB_Username.TabIndex = 1;
            TB_Username.Text = "root";
            // 
            // TB_DBName
            // 
            TB_DBName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_DBName.Location = new Point(3, 95);
            TB_DBName.Name = "TB_DBName";
            TB_DBName.Size = new Size(264, 23);
            TB_DBName.TabIndex = 1;
            // 
            // TB_DBPassword
            // 
            TB_DBPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_DBPassword.Location = new Point(273, 95);
            TB_DBPassword.Name = "TB_DBPassword";
            TB_DBPassword.Size = new Size(264, 23);
            TB_DBPassword.TabIndex = 1;
            // 
            // TB_TableName
            // 
            TB_TableName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_TableName.Location = new Point(3, 169);
            TB_TableName.Name = "TB_TableName";
            TB_TableName.Size = new Size(264, 23);
            TB_TableName.TabIndex = 1;
            // 
            // TB_RetrieveData
            // 
            TB_RetrieveData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_RetrieveData.Location = new Point(273, 169);
            TB_RetrieveData.Name = "TB_RetrieveData";
            TB_RetrieveData.Size = new Size(264, 23);
            TB_RetrieveData.TabIndex = 1;
            // 
            // TW_DirPath
            // 
            TW_DirPath.Controls.Add(tableLayoutPanel1);
            TW_DirPath.Location = new Point(4, 24);
            TW_DirPath.Name = "TW_DirPath";
            TW_DirPath.Padding = new Padding(3);
            TW_DirPath.Size = new Size(546, 233);
            TW_DirPath.TabIndex = 1;
            TW_DirPath.Text = "Directory Path File";
            TW_DirPath.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.Controls.Add(PB_BrowseTemplate, 1, 1);
            tableLayoutPanel1.Controls.Add(PB_BrowseExcel, 1, 3);
            tableLayoutPanel1.Controls.Add(LBL_ExcelFile, 0, 2);
            tableLayoutPanel1.Controls.Add(TB_TemplateFile, 0, 1);
            tableLayoutPanel1.Controls.Add(TB_ExcelFile, 0, 3);
            tableLayoutPanel1.Controls.Add(CB_TemplateFile, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.363636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.36364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(540, 227);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PB_BrowseTemplate
            // 
            PB_BrowseTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PB_BrowseTemplate.Cursor = Cursors.Hand;
            PB_BrowseTemplate.Location = new Point(423, 40);
            PB_BrowseTemplate.Name = "PB_BrowseTemplate";
            PB_BrowseTemplate.Size = new Size(114, 23);
            PB_BrowseTemplate.TabIndex = 3;
            PB_BrowseTemplate.Text = "Browse";
            PB_BrowseTemplate.UseVisualStyleBackColor = true;
            PB_BrowseTemplate.Click += PB_BrowseTemplate_Click;
            // 
            // PB_BrowseExcel
            // 
            PB_BrowseExcel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PB_BrowseExcel.Cursor = Cursors.Hand;
            PB_BrowseExcel.Location = new Point(423, 133);
            PB_BrowseExcel.Name = "PB_BrowseExcel";
            PB_BrowseExcel.Size = new Size(114, 23);
            PB_BrowseExcel.TabIndex = 3;
            PB_BrowseExcel.Text = "Browse";
            PB_BrowseExcel.UseVisualStyleBackColor = true;
            PB_BrowseExcel.Click += PB_BrowseExcel_Click;
            // 
            // LBL_ExcelFile
            // 
            LBL_ExcelFile.AutoSize = true;
            LBL_ExcelFile.Location = new Point(3, 112);
            LBL_ExcelFile.Name = "LBL_ExcelFile";
            LBL_ExcelFile.Size = new Size(55, 15);
            LBL_ExcelFile.TabIndex = 1;
            LBL_ExcelFile.Text = "Excel File";
            // 
            // TB_TemplateFile
            // 
            TB_TemplateFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_TemplateFile.Cursor = Cursors.IBeam;
            TB_TemplateFile.Location = new Point(3, 40);
            TB_TemplateFile.Name = "TB_TemplateFile";
            TB_TemplateFile.Size = new Size(414, 23);
            TB_TemplateFile.TabIndex = 2;
            // 
            // TB_ExcelFile
            // 
            TB_ExcelFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_ExcelFile.Cursor = Cursors.IBeam;
            TB_ExcelFile.Location = new Point(3, 133);
            TB_ExcelFile.Name = "TB_ExcelFile";
            TB_ExcelFile.Size = new Size(414, 23);
            TB_ExcelFile.TabIndex = 2;
            // 
            // CB_TemplateFile
            // 
            CB_TemplateFile.AutoSize = true;
            CB_TemplateFile.Checked = true;
            CB_TemplateFile.CheckState = CheckState.Checked;
            CB_TemplateFile.Cursor = Cursors.Hand;
            CB_TemplateFile.Location = new Point(3, 3);
            CB_TemplateFile.Name = "CB_TemplateFile";
            CB_TemplateFile.Size = new Size(95, 19);
            CB_TemplateFile.TabIndex = 4;
            CB_TemplateFile.Text = "Template File";
            CB_TemplateFile.UseVisualStyleBackColor = true;
            CB_TemplateFile.CheckedChanged += CB_TemplateFile_CheckedChanged;
            // 
            // TW_Config
            // 
            TW_Config.Controls.Add(dataGridView1);
            TW_Config.Location = new Point(4, 24);
            TW_Config.Name = "TW_Config";
            TW_Config.Padding = new Padding(3);
            TW_Config.Size = new Size(546, 233);
            TW_Config.TabIndex = 2;
            TW_Config.Text = "Configuration";
            TW_Config.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 227);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CB_Record);
            flowLayoutPanel1.Controls.Add(PB_Apply);
            flowLayoutPanel1.Controls.Add(TB_PlottingTime);
            flowLayoutPanel1.Controls.Add(LBL_PlottingTime);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 225);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(554, 36);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // CB_Record
            // 
            CB_Record.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CB_Record.Appearance = Appearance.Button;
            CB_Record.AutoSize = true;
            CB_Record.Cursor = Cursors.Hand;
            CB_Record.Location = new Point(497, 3);
            CB_Record.Name = "CB_Record";
            CB_Record.Size = new Size(54, 25);
            CB_Record.TabIndex = 2;
            CB_Record.Text = "Record";
            CB_Record.UseVisualStyleBackColor = true;
            CB_Record.CheckedChanged += CB_Record_CheckedChanged;
            // 
            // PB_Apply
            // 
            PB_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PB_Apply.Cursor = Cursors.Hand;
            PB_Apply.Location = new Point(416, 3);
            PB_Apply.Name = "PB_Apply";
            PB_Apply.Size = new Size(75, 25);
            PB_Apply.TabIndex = 1;
            PB_Apply.Text = "Apply";
            PB_Apply.UseVisualStyleBackColor = true;
            PB_Apply.Click += PB_Apply_Click;
            // 
            // TB_PlottingTime
            // 
            TB_PlottingTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TB_PlottingTime.Cursor = Cursors.IBeam;
            TB_PlottingTime.Location = new Point(310, 3);
            TB_PlottingTime.Name = "TB_PlottingTime";
            TB_PlottingTime.PlaceholderText = "Only Number";
            TB_PlottingTime.Size = new Size(100, 23);
            TB_PlottingTime.TabIndex = 3;
            TB_PlottingTime.KeyPress += TB_PlottingTime_KeyPress;
            // 
            // LBL_PlottingTime
            // 
            LBL_PlottingTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LBL_PlottingTime.AutoSize = true;
            LBL_PlottingTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PlottingTime.Location = new Point(182, 0);
            LBL_PlottingTime.Name = "LBL_PlottingTime";
            LBL_PlottingTime.Size = new Size(122, 31);
            LBL_PlottingTime.TabIndex = 4;
            LBL_PlottingTime.Text = "Plotting for each (s)";
            LBL_PlottingTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 261);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(570, 300);
            Name = "Form1";
            Text = "Auto Report";
            tabControl1.ResumeLayout(false);
            TW_DBConnection.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            TW_DirPath.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TW_Config.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TW_DBConnection;
        private TabPage TW_DirPath;
        private TabPage TW_Config;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TB_TemplateFile;
        private TextBox TB_ExcelFile;
        private Label LBL_ExcelFile;
        private Button PB_BrowseTemplate;
        private Button PB_BrowseExcel;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button PB_Apply;
        private CheckBox CB_Record;
        private CheckBox CB_TemplateFile;
        private DataGridView dataGridView1;
        private TextBox TB_PlottingTime;
        private Label LBL_PlottingTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LBL_Server;
        private Label LBL_Username;
        private Label LBL_DBName;
        private Label LBL_DBPassword;
        private Label LBL_TableName;
        private Label LBL_RetrieveData;
        private TextBox TB_Server;
        private TextBox TB_Username;
        private TextBox TB_DBName;
        private TextBox TB_DBPassword;
        private TextBox TB_TableName;
        private TextBox TB_RetrieveData;
    }
}