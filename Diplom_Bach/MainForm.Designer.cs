namespace Diplom_Bach
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxDep = new System.Windows.Forms.TextBox();
            this.btnGenGrid = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridInput = new System.Windows.Forms.DataGridView();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDatafromdgV = new System.Windows.Forms.Button();
            this.btnShowCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).BeginInit();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxDep
            // 
            this.txtBoxDep.Location = new System.Drawing.Point(138, 27);
            this.txtBoxDep.Name = "txtBoxDep";
            this.txtBoxDep.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDep.TabIndex = 0;
            // 
            // btnGenGrid
            // 
            this.btnGenGrid.Location = new System.Drawing.Point(103, 113);
            this.btnGenGrid.Name = "btnGenGrid";
            this.btnGenGrid.Size = new System.Drawing.Size(121, 23);
            this.btnGenGrid.TabIndex = 1;
            this.btnGenGrid.Text = "Сгенерувати";
            this.btnGenGrid.UseVisualStyleBackColor = true;
            this.btnGenGrid.Click += new System.EventHandler(this.btnGenGrid_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(16, 30);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(116, 16);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "Кількість відділів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кількість 2";
            // 
            // gridInput
            // 
            this.gridInput.AllowUserToAddRows = false;
            this.gridInput.AllowUserToDeleteRows = false;
            this.gridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInput.Location = new System.Drawing.Point(329, 27);
            this.gridInput.Name = "gridInput";
            this.gridInput.RowHeadersWidth = 51;
            this.gridInput.RowTemplate.Height = 24;
            this.gridInput.Size = new System.Drawing.Size(650, 407);
            this.gridInput.TabIndex = 5;
            this.gridInput.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridInput_EditingControlShowing);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.btnGenGrid);
            this.InputGroupBox.Controls.Add(this.textBox2);
            this.InputGroupBox.Controls.Add(this.label2);
            this.InputGroupBox.Controls.Add(this.txtBoxDep);
            this.InputGroupBox.Controls.Add(this.lblDep);
            this.InputGroupBox.Location = new System.Drawing.Point(24, 27);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(258, 152);
            this.InputGroupBox.TabIndex = 6;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Вхідні дані";
            // 
            // btnDatafromdgV
            // 
            this.btnDatafromdgV.Location = new System.Drawing.Point(105, 216);
            this.btnDatafromdgV.Name = "btnDatafromdgV";
            this.btnDatafromdgV.Size = new System.Drawing.Size(143, 23);
            this.btnDatafromdgV.TabIndex = 8;
            this.btnDatafromdgV.Text = "Прийняти дані";
            this.btnDatafromdgV.UseVisualStyleBackColor = true;
            this.btnDatafromdgV.Click += new System.EventHandler(this.btnDatafromdgV_Click);
            // 
            // btnShowCalculate
            // 
            this.btnShowCalculate.Location = new System.Drawing.Point(71, 397);
            this.btnShowCalculate.Name = "btnShowCalculate";
            this.btnShowCalculate.Size = new System.Drawing.Size(177, 23);
            this.btnShowCalculate.TabIndex = 9;
            this.btnShowCalculate.Text = "Вивести розрахунки";
            this.btnShowCalculate.UseVisualStyleBackColor = true;
            this.btnShowCalculate.Click += new System.EventHandler(this.btnShowCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.btnShowCalculate);
            this.Controls.Add(this.btnDatafromdgV);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.gridInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Оптимізація динамічним методом";
            ((System.ComponentModel.ISupportInitialize)(this.gridInput)).EndInit();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDep;
        private System.Windows.Forms.Button btnGenGrid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridInput;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Button btnDatafromdgV;
        private System.Windows.Forms.Button btnShowCalculate;
    }
}

