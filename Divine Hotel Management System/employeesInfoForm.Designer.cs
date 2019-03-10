namespace Divine_Hotel_Management_System
{
    partial class employeesInfoForm
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
            this.employeesDGV = new System.Windows.Forms.DataGridView();
            this.addNewEmployeesB = new System.Windows.Forms.Button();
            this.employeesInfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDGV
            // 
            this.employeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDGV.Location = new System.Drawing.Point(84, 194);
            this.employeesDGV.Name = "employeesDGV";
            this.employeesDGV.Size = new System.Drawing.Size(630, 200);
            this.employeesDGV.TabIndex = 0;
            // 
            // addNewEmployeesB
            // 
            this.addNewEmployeesB.Location = new System.Drawing.Point(143, 134);
            this.addNewEmployeesB.Name = "addNewEmployeesB";
            this.addNewEmployeesB.Size = new System.Drawing.Size(120, 30);
            this.addNewEmployeesB.TabIndex = 1;
            this.addNewEmployeesB.Text = "Add New Employee";
            this.addNewEmployeesB.UseVisualStyleBackColor = true;
            this.addNewEmployeesB.Click += new System.EventHandler(this.addEmployeesB_Click);
            // 
            // employeesInfoL
            // 
            this.employeesInfoL.AutoSize = true;
            this.employeesInfoL.Font = new System.Drawing.Font("Segoe Script", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesInfoL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeesInfoL.Location = new System.Drawing.Point(185, 40);
            this.employeesInfoL.Name = "employeesInfoL";
            this.employeesInfoL.Size = new System.Drawing.Size(456, 71);
            this.employeesInfoL.TabIndex = 23;
            this.employeesInfoL.Text = "Manage Employees";
            // 
            // employeesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.employeesInfoL);
            this.Controls.Add(this.addNewEmployeesB);
            this.Controls.Add(this.employeesDGV);
            this.Name = "employeesInfoForm";
            this.Text = "Employees Info";
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDGV;
        private System.Windows.Forms.Button addNewEmployeesB;
        private System.Windows.Forms.Label employeesInfoL;
    }
}