namespace Example1Project
{
    partial class SquareCalcForm
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
            this.lbtitle = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.btnFindSquare = new System.Windows.Forms.Button();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.lblSquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbtitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(0, 0);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(800, 65);
            this.lbtitle.TabIndex = 1;
            this.lbtitle.Text = "Square Calculator";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(301, 161);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(163, 22);
            this.txtNumber1.TabIndex = 6;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(178, 160);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(112, 25);
            this.lblNumber1.TabIndex = 5;
            this.lblNumber1.Text = "Number 1";
            // 
            // btnFindSquare
            // 
            this.btnFindSquare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSquare.Location = new System.Drawing.Point(301, 298);
            this.btnFindSquare.Name = "btnFindSquare";
            this.btnFindSquare.Size = new System.Drawing.Size(177, 43);
            this.btnFindSquare.TabIndex = 10;
            this.btnFindSquare.Text = "Find Square";
            this.btnFindSquare.UseVisualStyleBackColor = true;
            this.btnFindSquare.Click += new System.EventHandler(this.btnFindSquare_Click);
            // 
            // txtSquare
            // 
            this.txtSquare.Location = new System.Drawing.Point(301, 220);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.ReadOnly = true;
            this.txtSquare.Size = new System.Drawing.Size(163, 22);
            this.txtSquare.TabIndex = 9;
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare.Location = new System.Drawing.Point(178, 219);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(84, 25);
            this.lblSquare.TabIndex = 8;
            this.lblSquare.Text = "Square";
            // 
            // SquareCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindSquare);
            this.Controls.Add(this.txtSquare);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lbtitle);
            this.Name = "SquareCalcForm";
            this.Text = "SquareCalcForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SquareCalcForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Button btnFindSquare;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.Label lblSquare;
    }
}