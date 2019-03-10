namespace Divine_Hotel_Management_System
{
    partial class addInventoryForm
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
            this.addInventoryItemsTB = new System.Windows.Forms.TextBox();
            this.addInventoryItemsL = new System.Windows.Forms.Label();
            this.addInventoryDTPL = new System.Windows.Forms.Label();
            this.addInventoryDTP = new System.Windows.Forms.DateTimePicker();
            this.addInventoryL = new System.Windows.Forms.Label();
            this.addInventoryCostTB = new System.Windows.Forms.TextBox();
            this.addInventoryCostL = new System.Windows.Forms.Label();
            this.addInventoryB = new System.Windows.Forms.Button();
            this.resetAddInventoryB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addInventoryItemsTB
            // 
            this.addInventoryItemsTB.ForeColor = System.Drawing.Color.Gray;
            this.addInventoryItemsTB.Location = new System.Drawing.Point(251, 105);
            this.addInventoryItemsTB.Name = "addInventoryItemsTB";
            this.addInventoryItemsTB.Size = new System.Drawing.Size(190, 20);
            this.addInventoryItemsTB.TabIndex = 7;
            this.addInventoryItemsTB.Text = "Enter Inventory Items Here";
            // 
            // addInventoryItemsL
            // 
            this.addInventoryItemsL.AutoSize = true;
            this.addInventoryItemsL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryItemsL.Location = new System.Drawing.Point(119, 103);
            this.addInventoryItemsL.Name = "addInventoryItemsL";
            this.addInventoryItemsL.Size = new System.Drawing.Size(127, 21);
            this.addInventoryItemsL.TabIndex = 6;
            this.addInventoryItemsL.Text = "Inventory Items";
            // 
            // addInventoryDTPL
            // 
            this.addInventoryDTPL.AutoSize = true;
            this.addInventoryDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryDTPL.Location = new System.Drawing.Point(126, 184);
            this.addInventoryDTPL.Name = "addInventoryDTPL";
            this.addInventoryDTPL.Size = new System.Drawing.Size(120, 21);
            this.addInventoryDTPL.TabIndex = 8;
            this.addInventoryDTPL.Text = "Inventory Date";
            // 
            // addInventoryDTP
            // 
            this.addInventoryDTP.Location = new System.Drawing.Point(251, 185);
            this.addInventoryDTP.Name = "addInventoryDTP";
            this.addInventoryDTP.Size = new System.Drawing.Size(190, 20);
            this.addInventoryDTP.TabIndex = 9;
            // 
            // addInventoryL
            // 
            this.addInventoryL.AutoSize = true;
            this.addInventoryL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addInventoryL.Location = new System.Drawing.Point(50, 36);
            this.addInventoryL.Name = "addInventoryL";
            this.addInventoryL.Size = new System.Drawing.Size(469, 40);
            this.addInventoryL.TabIndex = 23;
            this.addInventoryL.Text = "Enter New Inventory Details Below";
            // 
            // addInventoryCostTB
            // 
            this.addInventoryCostTB.ForeColor = System.Drawing.Color.Gray;
            this.addInventoryCostTB.Location = new System.Drawing.Point(251, 145);
            this.addInventoryCostTB.Name = "addInventoryCostTB";
            this.addInventoryCostTB.Size = new System.Drawing.Size(190, 20);
            this.addInventoryCostTB.TabIndex = 25;
            this.addInventoryCostTB.Text = "Enter Inventory Cost Here";
            // 
            // addInventoryCostL
            // 
            this.addInventoryCostL.AutoSize = true;
            this.addInventoryCostL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryCostL.Location = new System.Drawing.Point(124, 144);
            this.addInventoryCostL.Name = "addInventoryCostL";
            this.addInventoryCostL.Size = new System.Drawing.Size(122, 21);
            this.addInventoryCostL.TabIndex = 24;
            this.addInventoryCostL.Text = "Inventory Cost";
            // 
            // addInventoryB
            // 
            this.addInventoryB.Location = new System.Drawing.Point(251, 228);
            this.addInventoryB.Name = "addInventoryB";
            this.addInventoryB.Size = new System.Drawing.Size(100, 25);
            this.addInventoryB.TabIndex = 26;
            this.addInventoryB.Text = "Add Inventory";
            this.addInventoryB.UseVisualStyleBackColor = true;
            // 
            // resetAddInventoryB
            // 
            this.resetAddInventoryB.Location = new System.Drawing.Point(371, 228);
            this.resetAddInventoryB.Name = "resetAddInventoryB";
            this.resetAddInventoryB.Size = new System.Drawing.Size(70, 25);
            this.resetAddInventoryB.TabIndex = 27;
            this.resetAddInventoryB.Text = "Reset";
            this.resetAddInventoryB.UseVisualStyleBackColor = true;
            // 
            // addInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(564, 321);
            this.Controls.Add(this.resetAddInventoryB);
            this.Controls.Add(this.addInventoryB);
            this.Controls.Add(this.addInventoryCostTB);
            this.Controls.Add(this.addInventoryCostL);
            this.Controls.Add(this.addInventoryL);
            this.Controls.Add(this.addInventoryDTP);
            this.Controls.Add(this.addInventoryDTPL);
            this.Controls.Add(this.addInventoryItemsTB);
            this.Controls.Add(this.addInventoryItemsL);
            this.Name = "addInventoryForm";
            this.Text = "Add New Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addInventoryItemsTB;
        private System.Windows.Forms.Label addInventoryItemsL;
        private System.Windows.Forms.Label addInventoryDTPL;
        private System.Windows.Forms.DateTimePicker addInventoryDTP;
        private System.Windows.Forms.Label addInventoryL;
        private System.Windows.Forms.TextBox addInventoryCostTB;
        private System.Windows.Forms.Label addInventoryCostL;
        private System.Windows.Forms.Button addInventoryB;
        private System.Windows.Forms.Button resetAddInventoryB;
    }
}