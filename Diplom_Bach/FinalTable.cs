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
        List<int> rowForMax;
        WorkWithExcelandWord workWithDoc;
        Calculate calc;

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
            rowForMax = new List<int>();
            workWithDoc= new WorkWithExcelandWord();
            calc = new Calculate();
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

        private void AddDatatoFinalTable(DataGridView dgV,List<int> c,List<int> xfc,List<int> ffc)
        {
            for (int i = 0; i < c.Count; i++)
            {
                dgV.Rows[i].Cells[0].Value = c[i];

            }

            int k = 0;
            int h = 0;
            for (int j = 1; j < dgV.Columns.Count; j++)
            {
                for (int i = 0; i < dgV.Rows.Count; i++)
                {
                    if (j % 2 != 0)
                    {
                        dgV.Rows[i].Cells[j].Value = xfc[k];
                        k++;
                    }
                    else
                    {
                       dgV.Rows[i].Cells[j].Value = ffc[h];
                        h++;
                    }

                }

            }
        }


        

        private void btnFinalResult_Click(object sender, EventArgs e)
        {
            
            

            dGVFinal.Rows.Clear();
            dGVFinal.Columns.Clear();

            AddColumnRowstoFinal(dGVFinal, (iterator * 2)+1, c.Count);

            AddDatatoFinalTable(dGVFinal, c, xfc, ffc);

            
           List<int> fxfcMax = calc.findOptimalInFinal(dGVFinal, rowForMax,  c);
                      

            //textBox1.Text ="Предприятие = " + (fxfcMax[2]).ToString()  + "xc = " + fxfcMax[0].ToString() + "fc = " + fxfcMax[1].ToString() + ", " + fxfcMax[5].ToString() + "," + fxfcMax[3].ToString() + "," + fxfcMax[4].ToString();

            workWithDoc.DownloadTheResultToWordFile(fxfcMax);
            

        }



    }
}
