namespace Diplom_Bach
{
    partial class FinalTable
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
            this.dGVFinal = new System.Windows.Forms.DataGridView();
            this.btnFinalResult = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVFinal
            // 
            this.dGVFinal.AllowUserToAddRows = false;
            this.dGVFinal.AllowUserToDeleteRows = false;
            this.dGVFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVFinal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFinal.Location = new System.Drawing.Point(52, 41);
            this.dGVFinal.Name = "dGVFinal";
            this.dGVFinal.RowHeadersWidth = 51;
            this.dGVFinal.RowTemplate.Height = 24;
            this.dGVFinal.Size = new System.Drawing.Size(696, 267);
            this.dGVFinal.TabIndex = 0;
            // 
            // btnFinalResult
            // 
            this.btnFinalResult.Location = new System.Drawing.Point(301, 359);
            this.btnFinalResult.Name = "btnFinalResult";
            this.btnFinalResult.Size = new System.Drawing.Size(165, 23);
            this.btnFinalResult.TabIndex = 1;
            this.btnFinalResult.Text = "Показати результат";
            this.btnFinalResult.UseVisualStyleBackColor = true;
            this.btnFinalResult.Click += new System.EventHandler(this.btnFinalResult_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 2;
            // 
            // FinalTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFinalResult);
            this.Controls.Add(this.dGVFinal);
            this.Name = "FinalTable";
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVFinal;
        private System.Windows.Forms.Button btnFinalResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}