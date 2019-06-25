namespace Divine_Hotel_Management_System
{
    partial class MenuControl
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
            this.addMenuB = new System.Windows.Forms.Button();
            this.menuDeleteB = new System.Windows.Forms.Button();
            this.menuL = new System.Windows.Forms.Label();
            this.menuDGV = new System.Windows.Forms.DataGridView();
            this.menuPriceL = new System.Windows.Forms.Label();
            this.MenuItemL = new System.Windows.Forms.Label();
            this.menuItemTB = new System.Windows.Forms.TextBox();
            this.menuPriceTB = new System.Windows.Forms.TextBox();
            this.menuUpdateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addMenuB
            // 
            this.addMenuB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addMenuB.Location = new System.Drawing.Point(110, 473);
            this.addMenuB.Name = "addMenuB";
            this.addMenuB.Size = new System.Drawing.Size(85, 26);
            this.addMenuB.TabIndex = 3;
            this.addMenuB.Text = "Add Menu";
            this.addMenuB.UseVisualStyleBackColor = true;
            this.addMenuB.Click += new System.EventHandler(this.addMenuB_Click);
            // 
            // menuDeleteB
            // 
            this.menuDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuDeleteB.Location = new System.Drawing.Point(201, 473);
            this.menuDeleteB.Name = "menuDeleteB";
            this.menuDeleteB.Size = new System.Drawing.Size(67, 26);
            this.menuDeleteB.TabIndex = 4;
            this.menuDeleteB.Text = "Delete";
            this.menuDeleteB.UseVisualStyleBackColor = true;
            this.menuDeleteB.Click += new System.EventHandler(this.deleteMenuB_Click);
            // 
            // menuL
            // 
            this.menuL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuL.AutoSize = true;
            this.menuL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuL.Location = new System.Drawing.Point(234, 30);
            this.menuL.Name = "menuL";
            this.menuL.Size = new System.Drawing.Size(291, 40);
            this.menuL.TabIndex = 68;
            this.menuL.Text = "Menu Management";
            // 
            // menuDGV
            // 
            this.menuDGV.AllowUserToAddRows = false;
            this.menuDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDGV.Location = new System.Drawing.Point(58, 163);
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuDGV.Size = new System.Drawing.Size(680, 200);
            this.menuDGV.TabIndex = 0;
            this.menuDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.menuDGV_MouseDoubleClick);
            // 
            // menuPriceL
            // 
            this.menuPriceL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuPriceL.AutoSize = true;
            this.menuPriceL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPriceL.Location = new System.Drawing.Point(54, 440);
            this.menuPriceL.Name = "menuPriceL";
            this.menuPriceL.Size = new System.Drawing.Size(48, 21);
            this.menuPriceL.TabIndex = 82;
            this.menuPriceL.Text = "Price";
            // 
            // MenuItemL
            // 
            this.MenuItemL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuItemL.AutoSize = true;
            this.MenuItemL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemL.Location = new System.Drawing.Point(54, 402);
            this.MenuItemL.Name = "MenuItemL";
            this.MenuItemL.Size = new System.Drawing.Size(90, 21);
            this.MenuItemL.TabIndex = 79;
            this.MenuItemL.Text = "Menu Item";
            // 
            // menuItemTB
            // 
            this.menuItemTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuItemTB.Location = new System.Drawing.Point(151, 403);
            this.menuItemTB.Name = "menuItemTB";
            this.menuItemTB.Size = new System.Drawing.Size(190, 20);
            this.menuItemTB.TabIndex = 1;
            // 
            // menuPriceTB
            // 
            this.menuPriceTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuPriceTB.Location = new System.Drawing.Point(151, 438);
            this.menuPriceTB.Name = "menuPriceTB";
            this.menuPriceTB.Size = new System.Drawing.Size(190, 20);
            this.menuPriceTB.TabIndex = 2;
            this.menuPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menuPriceTB_KeyPress);
            // 
            // menuUpdateB
            // 
            this.menuUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuUpdateB.Location = new System.Drawing.Point(274, 473);
            this.menuUpdateB.Name = "menuUpdateB";
            this.menuUpdateB.Size = new System.Drawing.Size(67, 26);
            this.menuUpdateB.TabIndex = 5;
            this.menuUpdateB.Text = "Update";
            this.menuUpdateB.UseVisualStyleBackColor = true;
            this.menuUpdateB.Click += new System.EventHandler(this.updateMenuB_Click);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuUpdateB);
            this.Controls.Add(this.menuPriceTB);
            this.Controls.Add(this.menuItemTB);
            this.Controls.Add(this.menuPriceL);
            this.Controls.Add(this.MenuItemL);
            this.Controls.Add(this.menuDGV);
            this.Controls.Add(this.menuL);
            this.Controls.Add(this.menuDeleteB);
            this.Controls.Add(this.addMenuB);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addMenuB;
        private System.Windows.Forms.Button menuDeleteB;
        private System.Windows.Forms.Label menuL;
        private System.Windows.Forms.DataGridView menuDGV;
        private System.Windows.Forms.Label menuPriceL;
        private System.Windows.Forms.Label MenuItemL;
        private System.Windows.Forms.TextBox menuItemTB;
        private System.Windows.Forms.TextBox menuPriceTB;
        private System.Windows.Forms.Button menuUpdateB;
    }
}
