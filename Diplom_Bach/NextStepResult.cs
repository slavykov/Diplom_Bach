using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        int columns;
        int rows;

        public NextStepResult(List<int> c,List<int> fc, int columns,int rows)
        {
            InitializeComponent();
            this.c = c;
            this.fc = fc;
            this.columns= columns;
            this.rows= rows;
            cLeft= new List<int>();
            cUp = new List<int>();
            x1 = new List<int>();
        }

        private void AddtoC(List<int> c, List<int> cDif)
        {
            for (int i = 0; i < c.Count; i++)
                cDif.Add(c[i]);
        }

        private void btnNextStepResult_Click(object sender, EventArgs e)
        {
            mainForm.AddColumnRows(dGVMain,c.Count+2, c.Count+1);
            fstepResult.SetCtoDGV(dGVMain, rows,c,0,1,true);

            string str = "";

            AddtoC(c, cLeft);
            fstepResult.SetCtoDGV(dGVMain, rows+1, c, 1, 0, false);
            AddtoC(c, cUp);
            calc.SecondStepCalculate(fc, rows, x1);

            for(int i=0; i < fc.Count; i++)
            {
                str+= x1[i].ToString();
            }


                int k = 0;
                for (int i = 1; i < rows+1; i++)
                {
                    {
                        dGVMain.Rows[i].Cells[1].Value = x1[k];
                        k++;
                    }

                }
            

            textBox1.Text = str;


        }
    }
}
