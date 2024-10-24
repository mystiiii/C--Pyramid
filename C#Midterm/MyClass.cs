using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_Midterm
{
    internal class MyClass
    {
        private int rows;

        public int NumberOfRow
        {
            get { return rows; }
            set { rows = value; }
        }

        public string PrintPyramid(int userRows)
        {
            string Pyramid = string.Empty;
            rows = 0;
            for (NumberOfRow = 0; NumberOfRow <= userRows; NumberOfRow++)
            {
                for (int asterisk = 1; asterisk <= userRows - NumberOfRow; asterisk++)
                {
                    Pyramid += " ";
                }
                for (int asterisk = 1; asterisk <= 2 * NumberOfRow - 1; asterisk++)
                {
                    Pyramid += "*";
                }
                Pyramid += "\n";
            }
            return Pyramid;
        }

        public string PrintRightTriangle(int userRows)
        {
            string Pyramid = string.Empty;
            rows = 0;
            for (NumberOfRow = 0; NumberOfRow <= userRows; NumberOfRow++)
            {
                for (int asterisk = 1; asterisk <= 2 * NumberOfRow - 1; asterisk++)
                {
                    Pyramid += "*";
                }
                Pyramid += "\n";
            }
            return Pyramid;
        }

    }

}
