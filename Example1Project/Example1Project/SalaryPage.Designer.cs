namespace Example1Project
{
    partial class SalaryPage
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTitleNewSalary = new System.Windows.Forms.Label();
            this.lblTitleEditSalary = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEditSalary = new System.Windows.Forms.TextBox();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdSalaries = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSalaries = new System.Windows.Forms.ComboBox();
            this.lstSalaries = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.BackColor = System.Drawing.Color.LightGray;
            this.lbtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbtitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(0, 0);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(1076, 65);
            this.lbtitle.TabIndex = 1;
            this.lbtitle.Text = "Salary";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(73, 88);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTitleNewSalary
            // 
            this.lblTitleNewSalary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTitleNewSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNewSalary.Location = new System.Drawing.Point(65, 148);
            this.lblTitleNewSalary.Name = "lblTitleNewSalary";
            this.lblTitleNewSalary.Size = new System.Drawing.Size(285, 29);
            this.lblTitleNewSalary.TabIndex = 3;
            this.lblTitleNewSalary.Text = "NewSalary";
            this.lblTitleNewSalary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitleEditSalary
            // 
            this.lblTitleEditSalary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTitleEditSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEditSalary.Location = new System.Drawing.Point(421, 148);
            this.lblTitleEditSalary.Name = "lblTitleEditSalary";
            this.lblTitleEditSalary.Size = new System.Drawing.Size(329, 29);
            this.lblTitleEditSalary.TabIndex = 4;
            this.lblTitleEditSalary.Text = "EditSalary";
            this.lblTitleEditSalary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(77, 232);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(96, 25);
            this.lblJobTitle.TabIndex = 5;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(77, 282);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(77, 25);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(184, 233);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(166, 22);
            this.txtJobTitle.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(184, 283);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(166, 22);
            this.txtSalary.TabIndex = 8;
            // 
            // txtEditSalary
            // 
            this.txtEditSalary.Location = new System.Drawing.Point(548, 282);
            this.txtEditSalary.Name = "txtEditSalary";
            this.txtEditSalary.Size = new System.Drawing.Size(166, 22);
            this.txtEditSalary.TabIndex = 12;
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(548, 232);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(166, 22);
            this.txtEditJobTitle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Title";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(136, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(445, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(82, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdSalaries
            // 
            this.grdSalaries.AllowUserToAddRows = false;
            this.grdSalaries.AllowUserToDeleteRows = false;
            this.grdSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdSalaries.Location = new System.Drawing.Point(65, 429);
            this.grdSalaries.MultiSelect = false;
            this.grdSalaries.Name = "grdSalaries";
            this.grdSalaries.ReadOnly = true;
            this.grdSalaries.RowHeadersWidth = 51;
            this.grdSalaries.RowTemplate.Height = 24;
            this.grdSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalaries.Size = new System.Drawing.Size(382, 191);
            this.grdSalaries.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(65, 639);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 32);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(206, 639);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 32);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Salary";
            this.Column2.HeaderText = "Salary";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Display";
            this.Column3.HeaderText = "Display";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // cmbSalaries
            // 
            this.cmbSalaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalaries.FormattingEnabled = true;
            this.cmbSalaries.Location = new System.Drawing.Point(816, 144);
            this.cmbSalaries.Name = "cmbSalaries";
            this.cmbSalaries.Size = new System.Drawing.Size(198, 24);
            this.cmbSalaries.TabIndex = 19;
            // 
            // lstSalaries
            // 
            this.lstSalaries.FormattingEnabled = true;
            this.lstSalaries.ItemHeight = 16;
            this.lstSalaries.Location = new System.Drawing.Point(816, 229);
            this.lstSalaries.Name = "lstSalaries";
            this.lstSalaries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSalaries.Size = new System.Drawing.Size(214, 132);
            this.lstSalaries.TabIndex = 20;
            // 
            // SalaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 683);
            this.Controls.Add(this.lstSalaries);
            this.Controls.Add(this.cmbSalaries);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grdSalaries);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEditSalary);
            this.Controls.Add(this.txtEditJobTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblTitleEditSalary);
            this.Controls.Add(this.lblTitleNewSalary);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbtitle);
            this.Name = "SalaryPage";
            this.Text = "SalaryPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitleNewSalary;
        private System.Windows.Forms.Label lblTitleEditSalary;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEditSalary;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdSalaries;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbSalaries;
        private System.Windows.Forms.ListBox lstSalaries;
    }
}