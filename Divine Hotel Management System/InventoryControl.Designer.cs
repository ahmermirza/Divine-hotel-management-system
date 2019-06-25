namespace Divine_Hotel_Management_System
{
    partial class InventoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryQuantityL = new System.Windows.Forms.Label();
            this.inventoryDescriptionTB = new System.Windows.Forms.TextBox();
            this.inventoryDescriptionL = new System.Windows.Forms.Label();
            this.inventoryDeleteB = new System.Windows.Forms.Button();
            this.addInventoryB = new System.Windows.Forms.Button();
            this.inventoryCostTB = new System.Windows.Forms.TextBox();
            this.addInventoryCostL = new System.Windows.Forms.Label();
            this.inventoryL = new System.Windows.Forms.Label();
            this.inventoryPurchaseDTP = new System.Windows.Forms.DateTimePicker();
            this.addInventoryDTPL = new System.Windows.Forms.Label();
            this.inventoryItemTB = new System.Windows.Forms.TextBox();
            this.inventoryItemL = new System.Windows.Forms.Label();
            this.inventoryDGV = new System.Windows.Forms.DataGridView();
            this.inventoryQuantityTB = new System.Windows.Forms.TextBox();
            this.inventoryUpdateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryQuantityL
            // 
            this.inventoryQuantityL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryQuantityL.AutoSize = true;
            this.inventoryQuantityL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryQuantityL.Location = new System.Drawing.Point(54, 482);
            this.inventoryQuantityL.Name = "inventoryQuantityL";
            this.inventoryQuantityL.Size = new System.Drawing.Size(73, 21);
            this.inventoryQuantityL.TabIndex = 43;
            this.inventoryQuantityL.Text = "Quantity";
            // 
            // inventoryDescriptionTB
            // 
            this.inventoryDescriptionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryDescriptionTB.Location = new System.Drawing.Point(161, 445);
            this.inventoryDescriptionTB.Name = "inventoryDescriptionTB";
            this.inventoryDescriptionTB.Size = new System.Drawing.Size(190, 20);
            this.inventoryDescriptionTB.TabIndex = 3;
            // 
            // inventoryDescriptionL
            // 
            this.inventoryDescriptionL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryDescriptionL.AutoSize = true;
            this.inventoryDescriptionL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDescriptionL.Location = new System.Drawing.Point(54, 444);
            this.inventoryDescriptionL.Name = "inventoryDescriptionL";
            this.inventoryDescriptionL.Size = new System.Drawing.Size(96, 21);
            this.inventoryDescriptionL.TabIndex = 41;
            this.inventoryDescriptionL.Text = "Description";
            // 
            // inventoryDeleteB
            // 
            this.inventoryDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryDeleteB.Location = new System.Drawing.Point(592, 478);
            this.inventoryDeleteB.Name = "inventoryDeleteB";
            this.inventoryDeleteB.Size = new System.Drawing.Size(70, 25);
            this.inventoryDeleteB.TabIndex = 8;
            this.inventoryDeleteB.Text = "Delete";
            this.inventoryDeleteB.UseVisualStyleBackColor = true;
            this.inventoryDeleteB.Click += new System.EventHandler(this.inventoryDeleteB_Click);
            // 
            // addInventoryB
            // 
            this.addInventoryB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addInventoryB.Location = new System.Drawing.Point(486, 478);
            this.addInventoryB.Name = "addInventoryB";
            this.addInventoryB.Size = new System.Drawing.Size(100, 25);
            this.addInventoryB.TabIndex = 7;
            this.addInventoryB.Text = "Add Inventory";
            this.addInventoryB.UseVisualStyleBackColor = true;
            this.addInventoryB.Click += new System.EventHandler(this.addInventoryB_Click);
            // 
            // inventoryCostTB
            // 
            this.inventoryCostTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryCostTB.Location = new System.Drawing.Point(548, 403);
            this.inventoryCostTB.Name = "inventoryCostTB";
            this.inventoryCostTB.Size = new System.Drawing.Size(190, 20);
            this.inventoryCostTB.TabIndex = 5;
            this.inventoryCostTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inventoryCostTB_KeyPress);
            // 
            // addInventoryCostL
            // 
            this.addInventoryCostL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addInventoryCostL.AutoSize = true;
            this.addInventoryCostL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryCostL.Location = new System.Drawing.Point(424, 405);
            this.addInventoryCostL.Name = "addInventoryCostL";
            this.addInventoryCostL.Size = new System.Drawing.Size(46, 21);
            this.addInventoryCostL.TabIndex = 37;
            this.addInventoryCostL.Text = "Cost";
            // 
            // inventoryL
            // 
            this.inventoryL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryL.AutoSize = true;
            this.inventoryL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.inventoryL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryL.Location = new System.Drawing.Point(227, 30);
            this.inventoryL.Name = "inventoryL";
            this.inventoryL.Size = new System.Drawing.Size(343, 40);
            this.inventoryL.TabIndex = 50;
            this.inventoryL.Text = "Inventory Management";
            // 
            // inventoryPurchaseDTP
            // 
            this.inventoryPurchaseDTP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryPurchaseDTP.Location = new System.Drawing.Point(548, 441);
            this.inventoryPurchaseDTP.Name = "inventoryPurchaseDTP";
            this.inventoryPurchaseDTP.Size = new System.Drawing.Size(190, 20);
            this.inventoryPurchaseDTP.TabIndex = 6;
            // 
            // addInventoryDTPL
            // 
            this.addInventoryDTPL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addInventoryDTPL.AutoSize = true;
            this.addInventoryDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryDTPL.Location = new System.Drawing.Point(424, 443);
            this.addInventoryDTPL.Name = "addInventoryDTPL";
            this.addInventoryDTPL.Size = new System.Drawing.Size(117, 21);
            this.addInventoryDTPL.TabIndex = 34;
            this.addInventoryDTPL.Text = "Purchase Date";
            // 
            // inventoryItemTB
            // 
            this.inventoryItemTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryItemTB.Location = new System.Drawing.Point(161, 406);
            this.inventoryItemTB.Name = "inventoryItemTB";
            this.inventoryItemTB.Size = new System.Drawing.Size(190, 20);
            this.inventoryItemTB.TabIndex = 2;
            // 
            // inventoryItemL
            // 
            this.inventoryItemL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryItemL.AutoSize = true;
            this.inventoryItemL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryItemL.Location = new System.Drawing.Point(54, 404);
            this.inventoryItemL.Name = "inventoryItemL";
            this.inventoryItemL.Size = new System.Drawing.Size(91, 21);
            this.inventoryItemL.TabIndex = 32;
            this.inventoryItemL.Text = "Item Name";
            // 
            // inventoryDGV
            // 
            this.inventoryDGV.AllowUserToAddRows = false;
            this.inventoryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDGV.Location = new System.Drawing.Point(58, 163);
            this.inventoryDGV.Name = "inventoryDGV";
            this.inventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDGV.Size = new System.Drawing.Size(680, 200);
            this.inventoryDGV.TabIndex = 1;
            this.inventoryDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.inventoryDGV_MouseDoubleClick);
            // 
            // inventoryQuantityTB
            // 
            this.inventoryQuantityTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inventoryQuantityTB.Location = new System.Drawing.Point(161, 483);
            this.inventoryQuantityTB.Name = "inventoryQuantityTB";
            this.inventoryQuantityTB.Size = new System.Drawing.Size(190, 20);
            this.inventoryQuantityTB.TabIndex = 4;
            this.inventoryQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inventoryQuantityTB_KeyPress);
            // 
            // inventoryUpdateB
            // 
            this.inventoryUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryUpdateB.Location = new System.Drawing.Point(668, 478);
            this.inventoryUpdateB.Name = "inventoryUpdateB";
            this.inventoryUpdateB.Size = new System.Drawing.Size(70, 25);
            this.inventoryUpdateB.TabIndex = 9;
            this.inventoryUpdateB.Text = "Update";
            this.inventoryUpdateB.UseVisualStyleBackColor = true;
            this.inventoryUpdateB.Click += new System.EventHandler(this.inventoryUpdateB_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inventoryUpdateB);
            this.Controls.Add(this.inventoryQuantityTB);
            this.Controls.Add(this.inventoryDGV);
            this.Controls.Add(this.inventoryQuantityL);
            this.Controls.Add(this.inventoryDescriptionTB);
            this.Controls.Add(this.inventoryDescriptionL);
            this.Controls.Add(this.inventoryDeleteB);
            this.Controls.Add(this.addInventoryB);
            this.Controls.Add(this.inventoryCostTB);
            this.Controls.Add(this.addInventoryCostL);
            this.Controls.Add(this.inventoryL);
            this.Controls.Add(this.inventoryPurchaseDTP);
            this.Controls.Add(this.addInventoryDTPL);
            this.Controls.Add(this.inventoryItemTB);
            this.Controls.Add(this.inventoryItemL);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inventoryQuantityL;
        private System.Windows.Forms.TextBox inventoryDescriptionTB;
        private System.Windows.Forms.Label inventoryDescriptionL;
        private System.Windows.Forms.Button inventoryDeleteB;
        private System.Windows.Forms.Button addInventoryB;
        private System.Windows.Forms.TextBox inventoryCostTB;
        private System.Windows.Forms.Label addInventoryCostL;
        private System.Windows.Forms.Label inventoryL;
        private System.Windows.Forms.DateTimePicker inventoryPurchaseDTP;
        private System.Windows.Forms.Label addInventoryDTPL;
        private System.Windows.Forms.TextBox inventoryItemTB;
        private System.Windows.Forms.Label inventoryItemL;
        private System.Windows.Forms.DataGridView inventoryDGV;
        private System.Windows.Forms.TextBox inventoryQuantityTB;
        private System.Windows.Forms.Button inventoryUpdateB;
    }
}
