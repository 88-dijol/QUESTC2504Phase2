namespace Example1Project
{
    partial class ContactList
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
            this.lblConatcts = new System.Windows.Forms.Label();
            this.lstContactList = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConatcts
            // 
            this.lblConatcts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblConatcts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConatcts.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConatcts.Location = new System.Drawing.Point(0, 0);
            this.lblConatcts.Name = "lblConatcts";
            this.lblConatcts.Size = new System.Drawing.Size(800, 82);
            this.lblConatcts.TabIndex = 0;
            this.lblConatcts.Text = "Contacts";
            this.lblConatcts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstContactList
            // 
            this.lstContactList.FormattingEnabled = true;
            this.lstContactList.ItemHeight = 16;
            this.lstContactList.Location = new System.Drawing.Point(199, 95);
            this.lstContactList.Name = "lstContactList";
            this.lstContactList.Size = new System.Drawing.Size(346, 180);
            this.lstContactList.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(199, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(441, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstContactList);
            this.Controls.Add(this.lblConatcts);
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConatcts;
        private System.Windows.Forms.ListBox lstContactList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}