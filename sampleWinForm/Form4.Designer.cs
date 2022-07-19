
namespace sampleWinForm
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSaveUsingSP = new System.Windows.Forms.Button();
            this.btnDeleteUsingSP = new System.Windows.Forms.Button();
            this.btnUpdateUsingSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp Salary";
            // 
            // txtEmpid
            // 
            this.txtEmpid.Location = new System.Drawing.Point(113, 29);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(100, 22);
            this.txtEmpid.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(113, 163);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(100, 22);
            this.txtEmpSalary.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(41, 224);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(259, 29);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(138, 23);
            this.btnSearchById.TabIndex = 9;
            this.btnSearchById.Text = "Search By Id";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // EmpGridView
            // 
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Location = new System.Drawing.Point(259, 68);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.RowHeadersWidth = 51;
            this.EmpGridView.RowTemplate.Height = 24;
            this.EmpGridView.Size = new System.Drawing.Size(316, 150);
            this.EmpGridView.TabIndex = 10;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(403, 236);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(160, 23);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Show All Emps";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSaveUsingSP
            // 
            this.btnSaveUsingSP.Location = new System.Drawing.Point(55, 305);
            this.btnSaveUsingSP.Name = "btnSaveUsingSP";
            this.btnSaveUsingSP.Size = new System.Drawing.Size(196, 36);
            this.btnSaveUsingSP.TabIndex = 12;
            this.btnSaveUsingSP.Text = "save using Sp";
            this.btnSaveUsingSP.UseVisualStyleBackColor = true;
            this.btnSaveUsingSP.Click += new System.EventHandler(this.btnSaveUsingSP_Click);
            // 
            // btnDeleteUsingSP
            // 
            this.btnDeleteUsingSP.Location = new System.Drawing.Point(55, 363);
            this.btnDeleteUsingSP.Name = "btnDeleteUsingSP";
            this.btnDeleteUsingSP.Size = new System.Drawing.Size(196, 43);
            this.btnDeleteUsingSP.TabIndex = 13;
            this.btnDeleteUsingSP.Text = "Delete Using SP";
            this.btnDeleteUsingSP.UseVisualStyleBackColor = true;
            this.btnDeleteUsingSP.Click += new System.EventHandler(this.btnDeleteUsingSP_Click);
            // 
            // btnUpdateUsingSP
            // 
            this.btnUpdateUsingSP.Location = new System.Drawing.Point(310, 305);
            this.btnUpdateUsingSP.Name = "btnUpdateUsingSP";
            this.btnUpdateUsingSP.Size = new System.Drawing.Size(232, 36);
            this.btnUpdateUsingSP.TabIndex = 14;
            this.btnUpdateUsingSP.Text = "Update Using SP";
            this.btnUpdateUsingSP.UseVisualStyleBackColor = true;
            this.btnUpdateUsingSP.Click += new System.EventHandler(this.btnUpdateUsingSP_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateUsingSP);
            this.Controls.Add(this.btnDeleteUsingSP);
            this.Controls.Add(this.btnSaveUsingSP);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSaveUsingSP;
        private System.Windows.Forms.Button btnDeleteUsingSP;
        private System.Windows.Forms.Button btnUpdateUsingSP;
    }
}