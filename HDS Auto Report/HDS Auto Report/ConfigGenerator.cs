using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDS_Auto_Report
{
    public class ConfigGenerator
    {
        private int[] Column = new int[1];
        private int[] StartRow = new int[1];
        private int[] StopRow = new int[1];
        private string[] MySqlColumnName = new string[1];
        private int looping = 0;

        public void SendTemplateId(int value)
        {
            if (value == 1)
            {
                // Excel Column 
                Column = new int[12];
                Column[0] = 2;
                Column[1] = 5;
                Column[2] = 8;
                Column[3] = 11;
                Column[4] = 12;
                Column[5] = 13;
                Column[6] = 14;
                Column[7] = 15;
                Column[8] = 16;
                Column[9] = 17;
                Column[10] = 18;
                Column[11] = 19;

                StartRow = new int[12];
                StopRow = new int[12];
                for (int i = 0; i < 12; i++)
                {
                    StartRow[i] = 11;
                    StopRow[i] = 34;
                }

                //MySql Column
                MySqlColumnName = new string[12];
                MySqlColumnName[0] = "run1";
                MySqlColumnName[1] = "run2";
                MySqlColumnName[2] = " run3";
                MySqlColumnName[3] = "cold_water";
                MySqlColumnName[4] = "chilled_water";
                MySqlColumnName[5] = "cooling_water";
                MySqlColumnName[6] = "hot_water";
                MySqlColumnName[7] = "heater1";
                MySqlColumnName[8] = "heater2";
                MySqlColumnName[9] = "stearin1";
                MySqlColumnName[10] = "stearin2";
                MySqlColumnName[11] = "pressure";

                looping = 12;
            }
            else if (value == 2)
            {
                // Excel Column 
                Column = new int[91];
                for (int i = 0; i < 35; i++)
                {
                    Column[i] = i + 2;
                }
                for (int i = 35; i < 69; i++)
                {
                    Column[i] = i + 2 - 35;
                }
                for (int i = 69; i < 91; i++)
                {
                    Column[i] = i + 2 - 69;
                }

                StartRow = new int[91];
                StopRow = new int[91];
                for (int i = 0; i < 35; i++)
                {
                    StartRow[i] = 11;
                    StopRow[i] = 34;
                }
                for (int i = 35; i < 69; i++)
                {
                    StartRow[i] = 39;
                    StopRow[i] = 62;
                }
                for (int i = 69; i < 91; i++)
                {
                    StartRow[i] = 84;
                    StopRow[i] = 107;
                }

                //MySql Column
                MySqlColumnName = new string[91];
                MySqlColumnName[0] = "a";
                MySqlColumnName[1] = "b";
                MySqlColumnName[2] = "c";
                MySqlColumnName[3] = "d";
                MySqlColumnName[4] = "e";
                MySqlColumnName[5] = "f";
                MySqlColumnName[6] = "g";
                MySqlColumnName[7] = "h";
                MySqlColumnName[8] = "i";
                MySqlColumnName[9] = "j";
                MySqlColumnName[10] = "k";
                MySqlColumnName[11] = "l";
                MySqlColumnName[12] = "m";
                MySqlColumnName[13] = "n";
                MySqlColumnName[14] = "o";
                MySqlColumnName[15] = "p";
                MySqlColumnName[16] = "q";
                MySqlColumnName[17] = "r";
                MySqlColumnName[18] = "s";
                MySqlColumnName[19] = "t";
                MySqlColumnName[20] = "u";
                MySqlColumnName[21] = "v";
                MySqlColumnName[22] = "w";
                MySqlColumnName[23] = "x";
                MySqlColumnName[24] = "y";
                MySqlColumnName[25] = "z";
                MySqlColumnName[26] = "aa";
                MySqlColumnName[27] = "ab";
                MySqlColumnName[28] = "ac";
                MySqlColumnName[29] = "ad";
                MySqlColumnName[30] = "ae";
                MySqlColumnName[31] = "af";
                MySqlColumnName[32] = "ag";
                MySqlColumnName[33] = "ah";
                MySqlColumnName[34] = "ai";
                MySqlColumnName[35] = "aj";
                MySqlColumnName[36] = "ak";
                MySqlColumnName[37] = "al";
                MySqlColumnName[38] = "am";
                MySqlColumnName[39] = "an";
                MySqlColumnName[40] = "ao";
                MySqlColumnName[41] = "ap";
                MySqlColumnName[42] = "aq";
                MySqlColumnName[43] = "ar";
                MySqlColumnName[44] = "as";
                MySqlColumnName[45] = "at";
                MySqlColumnName[46] = "au";
                MySqlColumnName[47] = "av";
                MySqlColumnName[48] = "aw";
                MySqlColumnName[49] = "ax";
                MySqlColumnName[50] = "ay";
                MySqlColumnName[51] = "az";
                MySqlColumnName[52] = "ba";
                MySqlColumnName[53] = "bb";
                MySqlColumnName[54] = "bc";
                MySqlColumnName[55] = "bd";
                MySqlColumnName[56] = "be";
                MySqlColumnName[57] = "bf";
                MySqlColumnName[58] = "bg";
                MySqlColumnName[59] = "bh";
                MySqlColumnName[60] = "bi";
                MySqlColumnName[61] = "bj";
                MySqlColumnName[62] = "bk";
                MySqlColumnName[63] = "bl";
                MySqlColumnName[64] = "bm";
                MySqlColumnName[65] = "bn";
                MySqlColumnName[66] = "bo";
                MySqlColumnName[67] = "bp";
                MySqlColumnName[68] = "bq";
                MySqlColumnName[69] = "br";
                MySqlColumnName[70] = "bs";
                MySqlColumnName[71] = "bt";
                MySqlColumnName[72] = "bu";
                MySqlColumnName[73] = "bv";
                MySqlColumnName[74] = "bw";
                MySqlColumnName[75] = "bx";
                MySqlColumnName[76] = "by";
                MySqlColumnName[77] = "bz";
                MySqlColumnName[78] = "ca";
                MySqlColumnName[79] = "cb";
                MySqlColumnName[80] = "cc";
                MySqlColumnName[81] = "cd";
                MySqlColumnName[82] = "ce";
                MySqlColumnName[83] = "cf";
                MySqlColumnName[84] = "cg";
                MySqlColumnName[85] = "ch";
                MySqlColumnName[86] = "ci";
                MySqlColumnName[87] = "cj";
                MySqlColumnName[88] = "ck";
                MySqlColumnName[89] = "cl";
                MySqlColumnName[90] = "cm";

                looping = 91;
            }
            else if (value == 3)
            {

            }
            else if (value == 4)
            {

            }
            else
            {

            }
        }

        public int getLooping()
        {
            return looping;
        }
        public int[] getStartRow
        {
            get { return StartRow; }
        }
        public int[] getStopRow
        {
            get { return StopRow; }
        }
        public int[] getColumn
        {
            get { return Column; }
        }
        public string[] getMySqlColumnName
        {
            get { return MySqlColumnName; }
        }
    }
}
