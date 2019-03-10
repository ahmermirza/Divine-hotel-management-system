namespace Divine_Hotel_Management_System
{
    partial class addRoomForm
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
            this.addRoomNumL = new System.Windows.Forms.Label();
            this.addRoomTypeL = new System.Windows.Forms.Label();
            this.addFloorNumL = new System.Windows.Forms.Label();
            this.addBedsNumL = new System.Windows.Forms.Label();
            this.addRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.addRoomChargesL = new System.Windows.Forms.Label();
            this.addRoomChargesTB = new System.Windows.Forms.TextBox();
            this.addRoomB = new System.Windows.Forms.Button();
            this.addRoomNumCB = new System.Windows.Forms.ComboBox();
            this.addFloorNumCB = new System.Windows.Forms.ComboBox();
            this.addBedsNumCB = new System.Windows.Forms.ComboBox();
            this.resetAddRoomB = new System.Windows.Forms.Button();
            this.addRoomL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRoomNumL
            // 
            this.addRoomNumL.AutoSize = true;
            this.addRoomNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomNumL.Location = new System.Drawing.Point(121, 112);
            this.addRoomNumL.Name = "addRoomNumL";
            this.addRoomNumL.Size = new System.Drawing.Size(122, 21);
            this.addRoomNumL.TabIndex = 0;
            this.addRoomNumL.Text = "Room Number";
            // 
            // addRoomTypeL
            // 
            this.addRoomTypeL.AutoSize = true;
            this.addRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomTypeL.Location = new System.Drawing.Point(143, 150);
            this.addRoomTypeL.Name = "addRoomTypeL";
            this.addRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.addRoomTypeL.TabIndex = 2;
            this.addRoomTypeL.Text = "Room Type";
            // 
            // addFloorNumL
            // 
            this.addFloorNumL.AutoSize = true;
            this.addFloorNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFloorNumL.Location = new System.Drawing.Point(127, 188);
            this.addFloorNumL.Name = "addFloorNumL";
            this.addFloorNumL.Size = new System.Drawing.Size(116, 21);
            this.addFloorNumL.TabIndex = 4;
            this.addFloorNumL.Text = "Floor Number";
            // 
            // addBedsNumL
            // 
            this.addBedsNumL.AutoSize = true;
            this.addBedsNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBedsNumL.Location = new System.Drawing.Point(109, 226);
            this.addBedsNumL.Name = "addBedsNumL";
            this.addBedsNumL.Size = new System.Drawing.Size(134, 21);
            this.addBedsNumL.TabIndex = 6;
            this.addBedsNumL.Text = "Number of Beds";
            // 
            // addRoomTypeCB
            // 
            this.addRoomTypeCB.ForeColor = System.Drawing.Color.Gray;
            this.addRoomTypeCB.FormattingEnabled = true;
            this.addRoomTypeCB.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Master Room",
            "Suite Room"});
            this.addRoomTypeCB.Location = new System.Drawing.Point(248, 151);
            this.addRoomTypeCB.Name = "addRoomTypeCB";
            this.addRoomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.addRoomTypeCB.TabIndex = 1;
            this.addRoomTypeCB.Text = "Select Room Type";
            this.addRoomTypeCB.TextChanged += new System.EventHandler(this.addRoomTypeCB_TextChanged);
            // 
            // addRoomChargesL
            // 
            this.addRoomChargesL.AutoSize = true;
            this.addRoomChargesL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomChargesL.Location = new System.Drawing.Point(120, 263);
            this.addRoomChargesL.Name = "addRoomChargesL";
            this.addRoomChargesL.Size = new System.Drawing.Size(123, 21);
            this.addRoomChargesL.TabIndex = 9;
            this.addRoomChargesL.Text = "Room Charges";
            // 
            // addRoomChargesTB
            // 
            this.addRoomChargesTB.ForeColor = System.Drawing.Color.Gray;
            this.addRoomChargesTB.Location = new System.Drawing.Point(248, 265);
            this.addRoomChargesTB.Name = "addRoomChargesTB";
            this.addRoomChargesTB.Size = new System.Drawing.Size(190, 20);
            this.addRoomChargesTB.TabIndex = 4;
            this.addRoomChargesTB.Text = "Enter Room Charges Here";
            this.addRoomChargesTB.Enter += new System.EventHandler(this.addRoomPriceTB_Enter);
            this.addRoomChargesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addRoomPriceTB_KeyPress);
            this.addRoomChargesTB.Leave += new System.EventHandler(this.addRoomPriceTB_Leave);
            // 
            // addRoomB
            // 
            this.addRoomB.Location = new System.Drawing.Point(248, 302);
            this.addRoomB.Name = "addRoomB";
            this.addRoomB.Size = new System.Drawing.Size(100, 25);
            this.addRoomB.TabIndex = 5;
            this.addRoomB.Text = "Add Room";
            this.addRoomB.UseVisualStyleBackColor = true;
            this.addRoomB.Click += new System.EventHandler(this.button1_Click);
            // 
            // addRoomNumCB
            // 
            this.addRoomNumCB.ForeColor = System.Drawing.Color.Gray;
            this.addRoomNumCB.FormattingEnabled = true;
            this.addRoomNumCB.Location = new System.Drawing.Point(248, 113);
            this.addRoomNumCB.Name = "addRoomNumCB";
            this.addRoomNumCB.Size = new System.Drawing.Size(190, 21);
            this.addRoomNumCB.TabIndex = 0;
            this.addRoomNumCB.Text = "Select Room Number";
            this.addRoomNumCB.TextChanged += new System.EventHandler(this.AddRoomNumCB_TextChanged);
            // 
            // addFloorNumCB
            // 
            this.addFloorNumCB.ForeColor = System.Drawing.Color.Gray;
            this.addFloorNumCB.FormattingEnabled = true;
            this.addFloorNumCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.addFloorNumCB.Location = new System.Drawing.Point(248, 189);
            this.addFloorNumCB.Name = "addFloorNumCB";
            this.addFloorNumCB.Size = new System.Drawing.Size(190, 21);
            this.addFloorNumCB.TabIndex = 2;
            this.addFloorNumCB.Text = "Select Floor Number";
            this.addFloorNumCB.TextChanged += new System.EventHandler(this.addFloorNumCB_TextChanged);
            // 
            // addBedsNumCB
            // 
            this.addBedsNumCB.ForeColor = System.Drawing.Color.Gray;
            this.addBedsNumCB.FormattingEnabled = true;
            this.addBedsNumCB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.addBedsNumCB.Location = new System.Drawing.Point(248, 227);
            this.addBedsNumCB.Name = "addBedsNumCB";
            this.addBedsNumCB.Size = new System.Drawing.Size(190, 21);
            this.addBedsNumCB.TabIndex = 3;
            this.addBedsNumCB.Text = "Select Number of Beds";
            this.addBedsNumCB.TextChanged += new System.EventHandler(this.addBedsNumCB_TextChanged);
            // 
            // resetAddRoomB
            // 
            this.resetAddRoomB.Location = new System.Drawing.Point(363, 302);
            this.resetAddRoomB.Name = "resetAddRoomB";
            this.resetAddRoomB.Size = new System.Drawing.Size(75, 25);
            this.resetAddRoomB.TabIndex = 6;
            this.resetAddRoomB.Text = "Reset";
            this.resetAddRoomB.UseVisualStyleBackColor = true;
            this.resetAddRoomB.Click += new System.EventHandler(this.resetAddRoomB_Click);
            // 
            // addRoomL
            // 
            this.addRoomL.AutoSize = true;
            this.addRoomL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addRoomL.Location = new System.Drawing.Point(78, 41);
            this.addRoomL.Name = "addRoomL";
            this.addRoomL.Size = new System.Drawing.Size(422, 40);
            this.addRoomL.TabIndex = 21;
            this.addRoomL.Text = "Enter New Room Details Below";
            // 
            // addRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(564, 399);
            this.Controls.Add(this.addRoomL);
            this.Controls.Add(this.resetAddRoomB);
            this.Controls.Add(this.addBedsNumCB);
            this.Controls.Add(this.addFloorNumCB);
            this.Controls.Add(this.addRoomNumCB);
            this.Controls.Add(this.addRoomB);
            this.Controls.Add(this.addRoomChargesTB);
            this.Controls.Add(this.addRoomChargesL);
            this.Controls.Add(this.addRoomTypeCB);
            this.Controls.Add(this.addBedsNumL);
            this.Controls.Add(this.addFloorNumL);
            this.Controls.Add(this.addRoomTypeL);
            this.Controls.Add(this.addRoomNumL);
            this.Name = "addRoomForm";
            this.Text = "Add New Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addRoomNumL;
        private System.Windows.Forms.Label addRoomTypeL;
        private System.Windows.Forms.Label addFloorNumL;
        private System.Windows.Forms.Label addBedsNumL;
        private System.Windows.Forms.ComboBox addRoomTypeCB;
        private System.Windows.Forms.Label addRoomChargesL;
        private System.Windows.Forms.TextBox addRoomChargesTB;
        private System.Windows.Forms.Button addRoomB;
        private System.Windows.Forms.ComboBox addRoomNumCB;
        private System.Windows.Forms.ComboBox addFloorNumCB;
        private System.Windows.Forms.ComboBox addBedsNumCB;
        private System.Windows.Forms.Button resetAddRoomB;
        private System.Windows.Forms.Label addRoomL;
    }
}