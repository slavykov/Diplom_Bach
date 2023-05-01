using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom_Bach
{
    public partial class MainForm : Form
    {

        private int rows;
        private int columns;
        private List<int> c;
        private List<int> gx;
        FirstStepResult stForm;

        public MainForm()
        {
            InitializeComponent();
            c = new List<int>();
            gx = new List<int>();
            
        }

        private void btnGenGrid_Click(object sender, EventArgs e)
        {
           ClearGridView(gridInput);
            if (Int32.Parse(txtBoxDep.Text) > 2 && Int32.Parse(textBox2.Text) > 1) {
                columns = Int32.Parse(txtBoxDep.Text);
                rows = Int32.Parse(textBox2.Text);
                columns = columns + 1;
                AddColumnRows(gridInput, columns, rows);
            }
            else { 
                MessageBox.Show("Введіть коректну кількість стовпців та строк!(стовпців>2)");
            }
           
        }

        // добавление к большому datagridView колонок и строк
        public void AddColumnRows(DataGridView gridInput, int columns, int rows)
        {
            DataGridViewTextBoxColumn[] column = new DataGridViewTextBoxColumn[columns];
            column[0] = new DataGridViewTextBoxColumn();
            column[0].HeaderText = "К-сть препаратів (заг.) " ;
            column[0].Name = " " ;
            for (int i = 1; i < columns; i++)
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

        // очистка dataGridView
        public void ClearGridView(DataGridView dgV)
        {
           dgV.Columns.Clear();
            dgV.Rows.Clear();
        }

        // событие для отслеживания ввода в dGV, вводяться только числа
        private void gridInput_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
        }

        // запрет на клавиатуре для ввода только чисел
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // чтение данных из dgV
        private void ReadData()
        {
           for (int i = 0; i < rows; i++)
           {
               c.Add(Convert.ToInt32(gridInput[0, i].Value));
           }
            
           for (int j = 1; j < columns; j++)
            {
                for(int i = 0; i < rows; i++)
                {
                    gx.Add(Convert.ToInt32(gridInput[j, i].Value));
                }
            }

           
        }


        private void btnShowCalculate_Click(object sender, EventArgs e)
        {

                stForm = new FirstStepResult(c, gx, rows, columns);
                stForm.Show();
            
        }

        private void btnDatafromdgV_Click(object sender, EventArgs e)
        {
            c.Clear();
            gx.Clear();
            ReadData();
        }
    }
}
