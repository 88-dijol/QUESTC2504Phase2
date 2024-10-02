namespace Example2Project
{
    partial class frmExtendedCounter
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
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblZero = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.NumericUpDown();
            this.lblStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(687, 405);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(99, 69);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(453, 405);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(99, 69);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblZero
            // 
            this.lblZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblZero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZero.Location = new System.Drawing.Point(428, 222);
            this.lblZero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(349, 133);
            this.lblZero.TabIndex = 3;
            this.lblZero.Text = "0";
            this.lblZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(557, 425);
            this.txtStep.Margin = new System.Windows.Forms.Padding(5);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(126, 32);
            this.txtStep.TabIndex = 6;
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(580, 395);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(58, 25);
            this.lblStep.TabIndex = 7;
            this.lblStep.Text = "Step";
            // 
            // frmExtendedCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblZero);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExtendedCounter";
            this.Text = "ExtendedCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExtendedCounter_FormClosing);
            this.Enter += new System.EventHandler(this.frmExtendedCounter_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.txtStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.NumericUpDown txtStep;
        private System.Windows.Forms.Label lblStep;
    }
}