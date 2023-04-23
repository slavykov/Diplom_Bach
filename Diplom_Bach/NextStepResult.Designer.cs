namespace Diplom_Bach
{
    partial class NextStepResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVMain = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNextStepResult = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMain
            // 
            this.dGVMain.AllowUserToAddRows = false;
            this.dGVMain.AllowUserToDeleteRows = false;
            this.dGVMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMain.Location = new System.Drawing.Point(43, 43);
            this.dGVMain.Name = "dGVMain";
            this.dGVMain.ReadOnly = true;
            this.dGVMain.RowHeadersWidth = 51;
            this.dGVMain.RowTemplate.Height = 24;
            this.dGVMain.Size = new System.Drawing.Size(474, 377);
            this.dGVMain.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(227, 377);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNextStepResult
            // 
            this.btnNextStepResult.Location = new System.Drawing.Point(310, 12);
            this.btnNextStepResult.Name = "btnNextStepResult";
            this.btnNextStepResult.Size = new System.Drawing.Size(146, 23);
            this.btnNextStepResult.TabIndex = 2;
            this.btnNextStepResult.Text = "NextStepResult";
            this.btnNextStepResult.UseVisualStyleBackColor = true;
            this.btnNextStepResult.Click += new System.EventHandler(this.btnNextStepResult_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 3;
            // 
            // NextStepResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNextStepResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dGVMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NextStepResult";
            this.Text = "NextStepResult";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNextStepResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}