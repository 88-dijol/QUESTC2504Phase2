namespace Bird
{
    partial class PeacockForm
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
            this.pbPeacock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeacock)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPeacock
            // 
            this.pbPeacock.Image = global::Bird.Properties.Resources.Peacock;
            this.pbPeacock.Location = new System.Drawing.Point(26, 30);
            this.pbPeacock.Name = "pbPeacock";
            this.pbPeacock.Size = new System.Drawing.Size(729, 393);
            this.pbPeacock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeacock.TabIndex = 0;
            this.pbPeacock.TabStop = false;
            // 
            // PeacockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPeacock);
            this.Name = "PeacockForm";
            this.Text = "PeacockForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeacockForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeacock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPeacock;
    }
}