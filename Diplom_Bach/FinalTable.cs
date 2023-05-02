﻿using System;
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
        List<int> fxfcMax;

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
            fxfcMax = new List<int>();
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

            //1.Запускаем цикл
            // 2.Запись строки в лист
            // 3.Сравнить элемент xc со следующим xc, сравнить элемент fc со следующим fc пока не найдем наибольшую пару
            // 4. Находим результирующее в зависимости от условия, если да заканчиваем цикл, если нет то ищем в другой строке, которую находим по формуле
      
            
            bool accept = false;

            int numRow = c.IndexOf(c.Max());
            int dep = 0;

            while (!accept)
            {
                dep = 0;
                int b = 0;

                for (int j = 1; j < dGVFinal.Columns.Count; j++)
                {
                    rowForMax.Add((int)dGVFinal.Rows[numRow].Cells[j].Value);
                }


                fxfcMax.Add(rowForMax[0]);
                fxfcMax.Add(rowForMax[1]);


                for (int i = 2; i < rowForMax.Count; i++)
                {

                    if (rowForMax[i] >= fxfcMax[b])
                    {
                        if (rowForMax[i + 1] > fxfcMax[b + 1])
                        {
                            fxfcMax[b] = rowForMax[i];
                            fxfcMax[b + 1] = rowForMax[i + 1];
                            dep++;
                        }
                    }

                }

                if (fxfcMax[0] == c.Max())
                {
                    accept = true;
                    MessageBox.Show("Задача порахована");
                }
                else
                {
                    numRow = c.Max() - fxfcMax[0];
                    accept= false;
                    MessageBox.Show("Задача не порахована" + numRow.ToString());
                }

            }
            //if (rowForMax[2] >= fxfcMax[0])
            //{
            //    if (rowForMax[3] > fxfcMax[1])
            //    {
            //        fxfcMax[0] = rowForMax[2];
            //        fxfcMax[1] = rowForMax[3];
            //    }
            //}


            //if (rowForMax[4] >= fxfcMax[0])
            //{
            //    if (rowForMax[5] > fxfcMax[1])

            //    {
            //        fxfcMax[0] = rowForMax[4];
            //        fxfcMax[1] = rowForMax[5];
            //    }
            //}





           

            textBox1.Text ="Предприятие = " + (dep+1).ToString()  + "xc = " + fxfcMax[0].ToString() + "fc = " + fxfcMax[1].ToString();




        }



    }
}
