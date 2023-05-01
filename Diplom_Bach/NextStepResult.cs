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
        FinalTable ftable;

        List<int> c;
        List<int> cLeft;
        List<int> cUp;
        List<int> f1c;
        List<int> x;
        List<int> fccount;
        List<int> gx;
        List<int> xnc;
        List<int> fnc;
        List<int> x1c;
        
        List<int> xfc;
        List<int> ffc;

        int columns;
        int rows;

        

        public NextStepResult(List<int> c,List<int> fc, List<int> gx, int columns, int rows, List<int> x1c)
        {
            InitializeComponent();
            this.c = c;
            f1c = fc;
            this.columns = columns;
            this.rows = rows;
            cLeft = new List<int>();
            cUp = new List<int>();
            x = new List<int>();
            this.x1c = x1c;
            xfc = new List<int>();
            ffc = new List<int>();
            xnc = new List<int>();
            fnc = new List<int>();
            fccount = new List<int>();
            this.gx = gx;
            this.x1c = x1c;
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
            for (int j = 1; j < columns; j++)
            {
                for (int i = 1; i < rows; i++)
                {
                    {
                        dgV.Rows[i].Cells[j].Value = x[k];
                        k++;
                    }

                }
            }
        }

        private void AddListtoFinalResult(List<int> xfc, List<int> ffc, List<int> xc, List<int> fc)
        {
            xfc.AddRange(xc);
            ffc.AddRange(fc);
        }

        private void btnNextStepResult_Click(object sender, EventArgs e)
        {
            mainForm.AddColumnRows(dGVMain, c.Count+2, rows+1);
            fstepResult.SetCtoDGV(dGVMain, rows, c, 0, 1, true);
            AddtoC(c, cLeft);
            fstepResult.SetCtoDGV(dGVMain, rows + 1, c, 1, 0, false);
            AddtoC(c, cUp);
            fstepResult.AddColumnRows(dgvOther, rows);



            AddListtoFinalResult(xfc, ffc, x1c, f1c);



            int col = columns;

            int indexOfgx = rows;

                //InitFccount(f1c, fccount);
                //calc.SecondStepCalculate(f1c, x, cUp, cLeft, fccount, gx, rows, indexOfgx);
                //AddXtoDgV(dGVMain, x, dGVMain.Rows.Count, dGVMain.Columns.Count);
                //calc.findMaxinRows(dGVMain, xnc, fnc, cUp, dGVMain.Rows.Count, dGVMain.Columns.Count);
                //SetFxFcTodGV(dgvOther, fnc, xnc, rows);

            int iterator = 1;
            while (iterator < col-1)
            { 
                InitFccount(f1c, fccount);
                calc.SecondStepCalculate(f1c, x, cUp, cLeft, fccount, gx, rows, indexOfgx);
                AddXtoDgV(dGVMain, x, dGVMain.Rows.Count, dGVMain.Columns.Count);
                calc.findMaxinRows(dGVMain, xnc, fnc, cUp, dGVMain.Rows.Count, dGVMain.Columns.Count);
                SetFxFcTodGV(dgvOther, fnc, xnc, rows);
                f1c.Clear();
                f1c = fnc.GetRange(0, fnc.Count);

                AddListtoFinalResult(xfc, ffc, xnc, fnc);

                fnc.Clear();
                xnc.Clear();
                x.Clear();
                fccount.Clear();
                indexOfgx = indexOfgx + rows;
                iterator++;

            }


            (sender as Button).Enabled = false;

            MessageBox.Show("Пораховано за " + iterator + " ітерацій(-ію)");
            ftable = new FinalTable(xfc, ffc, cLeft, iterator);
            ftable.Show();




        }
    }
}
