using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Bach
{
    public partial class FinalTable : Form
    {

        List<int> xfc;
        List<int> ffc;
        List<int> c;
        int iterator;

        public FinalTable()
        {
            InitializeComponent();
        }

        public FinalTable(List<int> xfc,List<int> ffc, List<int> c, int iterator)
        {
            InitializeComponent();
            this.xfc = xfc;
            this.ffc = ffc;
            this.c = c;
            this.iterator = iterator;
        }

        public void AddColumnRowstoFinal(DataGridView gridInput, int columns, int rows)
        {
            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[columns];
            column[0] = new DataGridViewTextBoxColumn();
            column[0].HeaderText = "C";
            column[0].Name = " ";
         
            for (int i = 1; i < columns; i++)
            {
                column[i] = new DataGridViewTextBoxColumn();

                if (i % 2 != 0)
                {
                   
                    column[i].HeaderText = "xc";
                }
                else
                {
                    
                    column[i].HeaderText = "fc";
                }  
                
                column[i].Name = " " + i;
                
            }
            gridInput.Columns.AddRange(column);

            for (int i = 0; i < rows; i++)
            {
                gridInput.Rows.Add();
            }
        }

        private void AddDatatoFinalTable(DataGridView dgV,List<int> c,int iterator,List<int> xfc,List<int> ffc)
        {
            for (int i = 0; i < c.Count; i++)
            {
                dGVFinal.Rows[i].Cells[0].Value = c[i];

            }

            int k = 0;
            int h = 0;
            for (int j = 1; j < (iterator * 2) + 1; j++)
            {
                for (int i = 0; i < c.Count; i++)
                {
                    if (j % 2 != 0)
                    {
                        dGVFinal.Rows[i].Cells[j].Value = xfc[k];
                        k++;
                    }
                    else
                    {
                        dGVFinal.Rows[i].Cells[j].Value = ffc[h];
                        h++;
                    }

                }

            }
        }

        private void btnFinalResult_Click(object sender, EventArgs e)
        {
            //string str= "";
            //for(int i = 0; i < c.Count; i++)
            //{
            //    str += c[i].ToString();
            //}

            //textBox1.Text = str;

            dGVFinal.Rows.Clear();
            dGVFinal.Columns.Clear();

            AddColumnRowstoFinal(dGVFinal, (iterator * 2)+1, c.Count);

            AddDatatoFinalTable(dGVFinal, c, iterator, xfc, ffc);



        }
    }
}
