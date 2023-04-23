namespace Diplom_Bach
{
    partial class FirstStepResult
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
            this.dgVresMain = new System.Windows.Forms.DataGridView();
            this.btnStepResult = new System.Windows.Forms.Button();
            this.dgVresOth = new System.Windows.Forms.DataGridView();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVresMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVresOth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVresMain
            // 
            this.dgVresMain.AllowUserToAddRows = false;
            this.dgVresMain.AllowUserToDeleteRows = false;
            this.dgVresMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgVresMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgVresMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVresMain.Location = new System.Drawing.Point(27, 54);
            this.dgVresMain.Name = "dgVresMain";
            this.dgVresMain.ReadOnly = true;
            this.dgVresMain.RowHeadersWidth = 51;
            this.dgVresMain.RowTemplate.Height = 24;
            this.dgVresMain.Size = new System.Drawing.Size(558, 384);
            this.dgVresMain.TabIndex = 0;
            // 
            // btnStepResult
            // 
            this.btnStepResult.Location = new System.Drawing.Point(247, 25);
            this.btnStepResult.Name = "btnStepResult";
            this.btnStepResult.Size = new System.Drawing.Size(159, 23);
            this.btnStepResult.TabIndex = 1;
            this.btnStepResult.Text = " FirstStepResult";
            this.btnStepResult.UseVisualStyleBackColor = true;
            this.btnStepResult.Click += new System.EventHandler(this.btnStepResult_Click);
            // 
            // dgVresOth
            // 
            this.dgVresOth.AllowUserToAddRows = false;
            this.dgVresOth.AllowUserToDeleteRows = false;
            this.dgVresOth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgVresOth.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgVresOth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVresOth.Location = new System.Drawing.Point(606, 54);
            this.dgVresOth.Name = "dgVresOth";
            this.dgVresOth.ReadOnly = true;
            this.dgVresOth.RowHeadersWidth = 51;
            this.dgVresOth.RowTemplate.Height = 24;
            this.dgVresOth.Size = new System.Drawing.Size(238, 384);
            this.dgVresOth.TabIndex = 3;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(437, 25);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(148, 23);
            this.btnNextStep.TabIndex = 4;
            this.btnNextStep.Text = "NextStepResult->";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(84, 25);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(114, 23);
            this.btnBackToMain.TabIndex = 5;
            this.btnBackToMain.Text = "<-backToMain";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // FirstStepResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.dgVresOth);
            this.Controls.Add(this.btnStepResult);
            this.Controls.Add(this.dgVresMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstStepResult";
            this.Text = "FirstStepResult";
            ((System.ComponentModel.ISupportInitialize)(this.dgVresMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVresOth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVresMain;
        private System.Windows.Forms.Button btnStepResult;
        private System.Windows.Forms.DataGridView dgVresOth;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnBackToMain;
    }
}