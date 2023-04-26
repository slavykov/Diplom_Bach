using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
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
        List<int> x;
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
            x = new List<int>();
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

        private void SetFxFcTodGV(DataGridView dgV, List<int> fc, List<int> xc, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                dgV.Rows[i].Cells[0].Value = fc[i];
                dgV.Rows[i].Cells[1].Value = xc[i];
            }
        }

        private void AddXtoDgV(DataGridView dgV,List<int> x,int rows, int columns)
        {
            int k = 0;
            for (int j = 1; j < columns + 1; j++)
            {
                for (int i = 1; i < rows + 1; i++)
                {
                    {
                        dgV.Rows[i].Cells[j].Value = x[k];
                        k++;
                    }

                }
            }
        }


        private void btnNextStepResult_Click(object sender, EventArgs e)
        {
            mainForm.AddColumnRows(dGVMain, c.Count + 2, c.Count + 1);
            fstepResult.SetCtoDGV(dGVMain, rows, c, 0, 1, true);
            AddtoC(c, cLeft);
            fstepResult.SetCtoDGV(dGVMain, rows + 1, c, 1, 0, false);
            AddtoC(c, cUp);
            fstepResult.AddColumnRows(dgvOther, rows);

            List<int> x2c = new List<int>();
            List<int> f2c = new List<int>();
         
            int col = columns;

            int indexOfgx = rows;

            int iterator = 1;
            while (iterator < col-1)
            { 
                InitFccount(fc, fccount);
                calc.SecondStepCalculate(fc, x, cUp, cLeft, fccount, gx, rows, indexOfgx);
                AddXtoDgV(dGVMain, x, rows, columns);
                calc.findMaxinRows(dGVMain, x2c, f2c, cUp, rows, columns);
                SetFxFcTodGV(dgvOther, f2c, x2c, rows);
                fc.Clear();
                fc = f2c.GetRange(0, f2c.Count);
                f2c.Clear();
                x2c.Clear();
                x.Clear();
                fccount.Clear();
                indexOfgx = indexOfgx + rows;
                iterator++;
        }
            
            //x.Clear();
            //fccount.Clear();
            //InitFccount(f2c, fccount);
            //calc.SecondStepCalculate(f2c, x, cUp, cLeft, fccount, gx, rows, rows + rows);
            //AddXtoDgV(dGVMain, x, rows, columns);
            //calc.findMaxinRows(dGVMain, x3c, f3c, cUp, rows, columns);
            //SetFxFcTodGV(dgvOther, f3c, x3c, rows);

            //string str = "";
            //for(int i=0;i<x1.Count;i++)
            //{
            //     str += x1[i].ToString();
            // }

            // textBox1.Text = str.ToString();


        }
    }
}
