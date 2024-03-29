﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Bach
{
    public partial class FirstStepResult : Form
    {
        MainForm mForm = new MainForm();
        Calculate calc = new Calculate();
        NextStepResult nsR;
        List<int> c;
        List<int> gx;
        List<int> f1c;
        List<int> x1c;
        int rows;
        int columns;

        public FirstStepResult()
        {
            InitializeComponent();
            
        }

        public FirstStepResult(List<int> c, List<int> gx,int rows,int columns)
        {
            InitializeComponent();
            this.c = c;
            this.gx = gx;
            this.rows = rows; 
            this.columns = columns;
            f1c = new List<int>();
            x1c = new List<int>();
        }

        // Функция для добавления данных в меньший dgV
        public void AddColumnRows(DataGridView gridInput, int rows)
        {
            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[2];
            for (int i = 0; i < 2; i++)
            {
                column[i] = new DataGridViewTextBoxColumn();
                column[i].HeaderText = " " + i;
                column[i].Name = " " + i;
            }
            gridInput.Columns.AddRange(column);

            for (int i = 0; i < rows; i++)
            {
                gridInput.Rows.Add();
            }
        }

        // функция для взятия листа С из dgVmain
        public void SetCtoDGV(DataGridView dGV, int rows,List<int> scmas,int cellPos,int rowPos,bool rowCounted=true)
        {
            if (rowCounted == false)
            {
                scmas.Insert(0,0);
            }
            for (int i = 0; i < rows; i++)
            {
                dGV.Rows[rowPos].Cells[cellPos].Value = scmas[i];
                if(rowCounted==true)
                {
                    rowPos++;
                }else
                {
                    
                    cellPos++;
                }
            }
        }

        // функция для взятия листа Gx из dgVmain
        public void SetGx(DataGridView dGV,List<int> gx, int rows, int columns)
        {
            int k = 0;
            for (int j = 1; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    {
                        dgVresMain.Rows[i].Cells[j].Value = gx[k];
                        k++;
                    }

                }
            }
        }

        // Инициализация листов fc и xc данными
        public void AddFcXc(List<int> fc, List<int> xc, int rows,int data)
        {
            for (int i = 0; i < rows; i++)
            {
                fc.Add(data);
                xc.Add(data);
            }
        }

        // заполнение dgVother с помощью листов fc и xc
        public void SetFcXctoDGV(DataGridView dGV, int rows, List<int> fc, List<int> xc)
        {
            for (int i = 0; i < rows; i++)
            {
                dGV.Rows[i].Cells[0].Value = fc[i];
                dGV.Rows[i].Cells[1].Value = xc[i];
            }
        }

        private void btnStepResult_Click(object sender, EventArgs e)
        {
            mForm.ClearGridView(dgVresMain);
            mForm.ClearGridView(dgVresOth);
            mForm.AddColumnRows(dgVresMain, columns, rows);
            AddColumnRows(dgVresOth, rows);
            
            SetCtoDGV(dgVresMain, rows,c,0,0,true);
            SetGx(dgVresMain,gx, rows, columns);

            AddFcXc(f1c, x1c, rows,0);
            calc.FirstStepCalculate(c, gx, f1c, x1c, rows);

            SetFcXctoDGV(dgVresOth, rows, f1c, x1c);
            (sender as Button).Enabled = false;

        }

        


        private void btnNextStep_Click(object sender, EventArgs e)
        {
           
                nsR = new NextStepResult(c, f1c, gx, columns, rows,x1c);

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "NextStepResult")
                {
                    MessageBox.Show("Форма вже відкрита!");
                    return;
                }
            }

            

            nsR.Show();
            (sender as Button).Enabled = false;

        }

        

        
    }
}
