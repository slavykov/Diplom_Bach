﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Bach
{
    // класс для промежуточных вычислений
    internal class Calculate
    {
        // функция для первого этапа вычислений
        public void FirstStepCalculate(List<int> c, List<int> gx, List<int> fc, List<int> xc, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                xc[i] = c[i];
            }

            for(int i = 0; i < rows; i++)
            {
                fc[i] = gx[i];
            }
        }

        public void SecondStepCalculate(List<int> fc, List<int> x,List<int> cUp, List<int> cLeft, List<int> fccount,List<int> gx, int rows,int indexOfgx)
        {
            
            for (int i = 0; i < rows; i++)
            {
                x.Add(fc[i] + 0);
            }

            int b = 0;
            for (int i = 1; i < cUp.Count; i++)
            {
                for (int j = 0; j < cLeft.Count; j++)
                {
                    if (cUp[i] <= cLeft[j])
                    {
                        x.Add(gx[indexOfgx] + fccount[b]);
                        b++;
                    }
                    else
                    {
                        x.Add(0);
                        b = 0;
                    }
                
                }
                indexOfgx++;
            }
        }

        public void findMaxinRows(DataGridView dgV,List<int> xc, List<int> fc,List<int> cUp,int rows, int columns)
        {
            int maxinRows = (int)dgV.Rows[1].Cells[1].Value;
            int indexofMax = 0;
          
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    if ((int)dgV.Rows[i].Cells[j].Value > maxinRows)
                    {
                        
                        maxinRows = (int)dgV.Rows[i].Cells[j].Value;
                        indexofMax = j-1;
                        
                    }
                    

                }
                
                xc.Add(cUp[indexofMax]);
                fc.Add(maxinRows);
            }
        }

        public List<int> findOptimalInFinal(DataGridView dGVFinal, List<int> rowForMax, List<int> c)
        {
            bool accept = false;
            List<int> xcfcOpt = new List<int>();

            List<int> xcOdd = new List<int>();
            List<int> fcNotOdd = new List<int>();

            int MaxXc = 0;
            int MaxFC = 0;

            int numRow = c.IndexOf(c.Max());
            int dep = 0;


            while (!accept)
            {
                dep = 0;
                MaxXc= 0;
                MaxFC= 0;
                xcOdd.Clear();
                fcNotOdd.Clear();
                rowForMax.Clear();

                for (int j = 1; j < dGVFinal.Columns.Count; j++)
                {
                    rowForMax.Add((int)dGVFinal.Rows[numRow].Cells[j].Value);
                }

                for (int i = 0; i < rowForMax.Count; i++)
                {
                    if (i % 2 == 0)
                        xcOdd.Add(rowForMax[i]);
                    else
                        fcNotOdd.Add(rowForMax[i]);

                }

                for (int i = 0; i < fcNotOdd.Count; i++)
                {
                    if (fcNotOdd[i] > MaxFC)
                    {
                        MaxFC = fcNotOdd[i];
                        MaxXc = xcOdd[i];
                        dep = i;
                    }
                }

                xcfcOpt.Add(dep + 1);
                xcfcOpt.Add(MaxXc);
                xcfcOpt.Add(MaxFC);
                

                if (MaxXc == c[numRow])
                {
                    
                    MessageBox.Show("Задача порахована");
                    accept = true;
                }
                else
                {
                    numRow = rowForMax.IndexOf(c[numRow] - MaxXc)+1;
                    accept = false;
                }
            }
               
                

                return xcfcOpt;
        }


    }
}
