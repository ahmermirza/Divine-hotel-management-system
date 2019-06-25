namespace Divine_Hotel_Management_System
{
    partial class RoomTypeControl
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
            this.addRoomTypeB = new System.Windows.Forms.Button();
            this.roomTypeNameTB = new System.Windows.Forms.TextBox();
            this.roomTypeNameL = new System.Windows.Forms.Label();
            this.roomDescriptionL = new System.Windows.Forms.Label();
            this.roomTypeDGV = new System.Windows.Forms.DataGridView();
            this.roomBedsL = new System.Windows.Forms.Label();
            this.roomBedsCB = new System.Windows.Forms.ComboBox();
            this.roomDescriptionTB = new System.Windows.Forms.TextBox();
            this.roomBasePriceTB = new System.Windows.Forms.TextBox();
            this.roomBasePriceL = new System.Windows.Forms.Label();
            this.roomB = new System.Windows.Forms.Button();
            this.roomTypeL = new System.Windows.Forms.Label();
            this.roomTypeDeleteB = new System.Windows.Forms.Button();
            this.roomTypeUpdateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addRoomTypeB
            // 
            this.addRoomTypeB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addRoomTypeB.Location = new System.Drawing.Point(486, 437);
            this.addRoomTypeB.Name = "addRoomTypeB";
            this.addRoomTypeB.Size = new System.Drawing.Size(100, 25);
            this.addRoomTypeB.TabIndex = 7;
            this.addRoomTypeB.Text = "Add Room Type";
            this.addRoomTypeB.UseVisualStyleBackColor = true;
            this.addRoomTypeB.Click += new System.EventHandler(this.addRoomTypeB_Click);
            // 
            // roomTypeNameTB
            // 
            this.roomTypeNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeNameTB.Location = new System.Drawing.Point(208, 404);
            this.roomTypeNameTB.Name = "roomTypeNameTB";
            this.roomTypeNameTB.Size = new System.Drawing.Size(190, 20);
            this.roomTypeNameTB.TabIndex = 3;
            // 
            // roomTypeNameL
            // 
            this.roomTypeNameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeNameL.AutoSize = true;
            this.roomTypeNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeNameL.Location = new System.Drawing.Point(54, 404);
            this.roomTypeNameL.Name = "roomTypeNameL";
            this.roomTypeNameL.Size = new System.Drawing.Size(100, 21);
            this.roomTypeNameL.TabIndex = 43;
            this.roomTypeNameL.Text = "Room Type";
            // 
            // roomDescriptionL
            // 
            this.roomDescriptionL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomDescriptionL.AutoSize = true;
            this.roomDescriptionL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescriptionL.Location = new System.Drawing.Point(54, 440);
            this.roomDescriptionL.Name = "roomDescriptionL";
            this.roomDescriptionL.Size = new System.Drawing.Size(96, 21);
            this.roomDescriptionL.TabIndex = 36;
            this.roomDescriptionL.Text = "Description";
            // 
            // roomTypeDGV
            // 
            this.roomTypeDGV.AllowUserToAddRows = false;
            this.roomTypeDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roomTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTypeDGV.Location = new System.Drawing.Point(58, 163);
            this.roomTypeDGV.Name = "roomTypeDGV";
            this.roomTypeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomTypeDGV.Size = new System.Drawing.Size(680, 200);
            this.roomTypeDGV.TabIndex = 2;
            this.roomTypeDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.roomTypeDGV_MouseDoubleClick);
            // 
            // roomBedsL
            // 
            this.roomBedsL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomBedsL.AutoSize = true;
            this.roomBedsL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBedsL.Location = new System.Drawing.Point(54, 476);
            this.roomBedsL.Name = "roomBedsL";
            this.roomBedsL.Size = new System.Drawing.Size(134, 21);
            this.roomBedsL.TabIndex = 42;
            this.roomBedsL.Text = "Number of Beds";
            // 
            // roomBedsCB
            // 
            this.roomBedsCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomBedsCB.FormattingEnabled = true;
            this.roomBedsCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.roomBedsCB.Location = new System.Drawing.Point(208, 476);
            this.roomBedsCB.Name = "roomBedsCB";
            this.roomBedsCB.Size = new System.Drawing.Size(190, 21);
            this.roomBedsCB.TabIndex = 5;
            this.roomBedsCB.Text = "Select Number of Beds";
            // 
            // roomDescriptionTB
            // 
            this.roomDescriptionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomDescriptionTB.Location = new System.Drawing.Point(208, 440);
            this.roomDescriptionTB.Name = "roomDescriptionTB";
            this.roomDescriptionTB.Size = new System.Drawing.Size(190, 20);
            this.roomDescriptionTB.TabIndex = 4;
            // 
            // roomBasePriceTB
            // 
            this.roomBasePriceTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomBasePriceTB.Location = new System.Drawing.Point(548, 404);
            this.roomBasePriceTB.Name = "roomBasePriceTB";
            this.roomBasePriceTB.Size = new System.Drawing.Size(190, 20);
            this.roomBasePriceTB.TabIndex = 6;
            this.roomBasePriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomBasePriceTB_KeyPress);
            // 
            // roomBasePriceL
            // 
            this.roomBasePriceL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomBasePriceL.AutoSize = true;
            this.roomBasePriceL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBasePriceL.Location = new System.Drawing.Point(453, 403);
            this.roomBasePriceL.Name = "roomBasePriceL";
            this.roomBasePriceL.Size = new System.Drawing.Size(89, 21);
            this.roomBasePriceL.TabIndex = 46;
            this.roomBasePriceL.Text = "Base Price";
            // 
            // roomB
            // 
            this.roomB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomB.Location = new System.Drawing.Point(605, 30);
            this.roomB.Name = "roomB";
            this.roomB.Size = new System.Drawing.Size(133, 33);
            this.roomB.TabIndex = 1;
            this.roomB.Text = "Go to Rooms";
            this.roomB.UseVisualStyleBackColor = false;
            this.roomB.Click += new System.EventHandler(this.BackToRoomsB_Click);
            // 
            // roomTypeL
            // 
            this.roomTypeL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomTypeL.AutoSize = true;
            this.roomTypeL.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roomTypeL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeL.Location = new System.Drawing.Point(213, 30);
            this.roomTypeL.Name = "roomTypeL";
            this.roomTypeL.Size = new System.Drawing.Size(370, 40);
            this.roomTypeL.TabIndex = 48;
            this.roomTypeL.Text = "Room Type Management";
            // 
            // roomTypeDeleteB
            // 
            this.roomTypeDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomTypeDeleteB.Location = new System.Drawing.Point(592, 437);
            this.roomTypeDeleteB.Name = "roomTypeDeleteB";
            this.roomTypeDeleteB.Size = new System.Drawing.Size(70, 25);
            this.roomTypeDeleteB.TabIndex = 8;
            this.roomTypeDeleteB.Text = "Delete";
            this.roomTypeDeleteB.UseVisualStyleBackColor = true;
            this.roomTypeDeleteB.Click += new System.EventHandler(this.roomTypeDeleteB_Click);
            // 
            // roomTypeUpdateB
            // 
            this.roomTypeUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomTypeUpdateB.Location = new System.Drawing.Point(668, 437);
            this.roomTypeUpdateB.Name = "roomTypeUpdateB";
            this.roomTypeUpdateB.Size = new System.Drawing.Size(70, 25);
            this.roomTypeUpdateB.TabIndex = 9;
            this.roomTypeUpdateB.Text = "Update";
            this.roomTypeUpdateB.UseVisualStyleBackColor = true;
            this.roomTypeUpdateB.Click += new System.EventHandler(this.roomTypeUpdateB_Click);
            // 
            // RoomTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomTypeUpdateB);
            this.Controls.Add(this.roomTypeDeleteB);
            this.Controls.Add(this.roomTypeL);
            this.Controls.Add(this.roomB);
            this.Controls.Add(this.roomBasePriceTB);
            this.Controls.Add(this.roomBasePriceL);
            this.Controls.Add(this.roomDescriptionTB);
            this.Controls.Add(this.roomBedsCB);
            this.Controls.Add(this.addRoomTypeB);
            this.Controls.Add(this.roomTypeNameTB);
            this.Controls.Add(this.roomTypeNameL);
            this.Controls.Add(this.roomBedsL);
            this.Controls.Add(this.roomDescriptionL);
            this.Controls.Add(this.roomTypeDGV);
            this.Name = "RoomTypeControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.RoomTypeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addRoomTypeB;
        private System.Windows.Forms.TextBox roomTypeNameTB;
        private System.Windows.Forms.Label roomTypeNameL;
        private System.Windows.Forms.Label roomDescriptionL;
        private System.Windows.Forms.DataGridView roomTypeDGV;
        private System.Windows.Forms.Label roomBedsL;
        private System.Windows.Forms.ComboBox roomBedsCB;
        private System.Windows.Forms.TextBox roomDescriptionTB;
        private System.Windows.Forms.TextBox roomBasePriceTB;
        private System.Windows.Forms.Label roomBasePriceL;
        private System.Windows.Forms.Button roomB;
        private System.Windows.Forms.Label roomTypeL;
        private System.Windows.Forms.Button roomTypeDeleteB;
        private System.Windows.Forms.Button roomTypeUpdateB;
    }
}
