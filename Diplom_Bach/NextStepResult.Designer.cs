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
            this.dgvOther = new System.Windows.Forms.DataGridView();
            this.btnNextStepResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).BeginInit();
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
            // dgvOther
            // 
            this.dgvOther.AllowUserToAddRows = false;
            this.dgvOther.AllowUserToDeleteRows = false;
            this.dgvOther.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOther.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOther.Location = new System.Drawing.Point(548, 43);
            this.dgvOther.Name = "dgvOther";
            this.dgvOther.RowHeadersWidth = 51;
            this.dgvOther.RowTemplate.Height = 24;
            this.dgvOther.Size = new System.Drawing.Size(227, 377);
            this.dgvOther.TabIndex = 1;
            // 
            // btnNextStepResult
            // 
            this.btnNextStepResult.Location = new System.Drawing.Point(313, 14);
            this.btnNextStepResult.Name = "btnNextStepResult";
            this.btnNextStepResult.Size = new System.Drawing.Size(146, 23);
            this.btnNextStepResult.TabIndex = 2;
            this.btnNextStepResult.Text = "Розрахувати етапи";
            this.btnNextStepResult.UseVisualStyleBackColor = true;
            this.btnNextStepResult.Click += new System.EventHandler(this.btnNextStepResult_Click);
            // 
            // NextStepResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextStepResult);
            this.Controls.Add(this.dgvOther);
            this.Controls.Add(this.dGVMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NextStepResult";
            this.Text = "Наступні етапи";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMain;
        private System.Windows.Forms.DataGridView dgvOther;
        private System.Windows.Forms.Button btnNextStepResult;
    }
}