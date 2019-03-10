namespace Divine_Hotel_Management_System
{
    partial class inventoryInfoForm
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
            this.inventoryDGV = new System.Windows.Forms.DataGridView();
            this.inventoryInfoL = new System.Windows.Forms.Label();
            this.addNewInventoryB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDGV
            // 
            this.inventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDGV.Location = new System.Drawing.Point(98, 177);
            this.inventoryDGV.Name = "inventoryDGV";
            this.inventoryDGV.Size = new System.Drawing.Size(600, 200);
            this.inventoryDGV.TabIndex = 0;
            // 
            // inventoryInfoL
            // 
            this.inventoryInfoL.AutoSize = true;
            this.inventoryInfoL.Font = new System.Drawing.Font("Segoe Script", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryInfoL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inventoryInfoL.Location = new System.Drawing.Point(185, 40);
            this.inventoryInfoL.Name = "inventoryInfoL";
            this.inventoryInfoL.Size = new System.Drawing.Size(441, 71);
            this.inventoryInfoL.TabIndex = 23;
            this.inventoryInfoL.Text = "Manage Inventory";
            // 
            // addNewInventoryB
            // 
            this.addNewInventoryB.Location = new System.Drawing.Point(126, 122);
            this.addNewInventoryB.Name = "addNewInventoryB";
            this.addNewInventoryB.Size = new System.Drawing.Size(120, 30);
            this.addNewInventoryB.TabIndex = 24;
            this.addNewInventoryB.Text = "Add New Inventory";
            this.addNewInventoryB.UseVisualStyleBackColor = true;
            this.addNewInventoryB.Click += new System.EventHandler(this.addNewInventoryB_Click);
            // 
            // inventoryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.addNewInventoryB);
            this.Controls.Add(this.inventoryInfoL);
            this.Controls.Add(this.inventoryDGV);
            this.Name = "inventoryInfoForm";
            this.Text = "Inventory Info";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryDGV;
        private System.Windows.Forms.Label inventoryInfoL;
        private System.Windows.Forms.Button addNewInventoryB;
    }
}