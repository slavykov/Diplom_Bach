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
    public partial class NextStepResult : Form
    {
        public NextStepResult()
        {
            InitializeComponent();
        }


        MainForm mainForm = new MainForm();
        FirstStepResult fstepResult = new FirstStepResult();
        Calculate calc = new Calculate();

        List<int> c;
        List<int> cLeft;
        List<int> cUp;
        List<int> fc;
        List<int> x1;
        List<int> fccount;
        List<int> gx;
        int columns;
        int rows;

        public NextStepResult(List<int> c,List<int> fc,List<int> gx, int columns,int rows)
        {
            InitializeComponent();
            this.c = c;
            this.fc = fc;
            this.columns= columns;
            this.rows= rows;
            cLeft= new List<int>();
            cUp = new List<int>();
            x1 = new List<int>();
            fccount = new List<int>();
            this.gx = gx;
        }

        private void AddtoC(List<int> c, List<int> cDif)
        {
            for (int i = 0; i < c.Count; i++)
                cDif.Add(c[i]);
        }

        private void InitFccount(List<int> fc, List<int> fccount)
        {
            for (int i = 0; i < fc.Count; i++)
            {
                fccount.Add(0);
            }

            for (int i = 0; i < fccount.Count; i++)
            {
                fccount[i] = fc[i];
            }
            fccount.Insert(0, 0);
        }


        private void btnNextStepResult_Click(object sender, EventArgs e)
        {
            mainForm.AddColumnRows(dGVMain,c.Count+2, c.Count+1);
            fstepResult.SetCtoDGV(dGVMain, rows,c,0,1,true);
             
            string str = "";

            AddtoC(c, cLeft);
            fstepResult.SetCtoDGV(dGVMain, rows+1, c, 1, 0, false);
            AddtoC(c, cUp);
            //calc.SecondStepCalculate(fc, rows, x1);

            

            InitFccount(fc, fccount);

            // 1 сравнить сUp с сLeft
            // 2 если условие подтверждается значит добавляем к 1 столбцу 0,(находим индекс gx) ко 2 столбцу fccount-1,к 3 столбцу fccount-2 и т.д.
            // 3 если нет, добавляем в список 0, 


            calc.SecondStepCalculate(fc, x1, cUp, cLeft, fccount, gx, rows);


           int k = 0;
            for (int j = 1; j < columns+1; j++)
              {
                  for (int i = 1; i < rows+1; i++)
                 {
                      {
                          dGVMain.Rows[i].Cells[j].Value = x1[k];
                        k++;
                    }

                }
              }

           

            textBox1.Text = str.ToString();


        }
    }
}
