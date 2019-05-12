namespace Divine_Hotel_Management_System
{
    partial class RoomControl
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
            this.roomDGV = new System.Windows.Forms.DataGridView();
            this.roomL = new System.Windows.Forms.Label();
            this.roomFloorNumCB = new System.Windows.Forms.ComboBox();
            this.addRoomB = new System.Windows.Forms.Button();
            this.roomNumberTB = new System.Windows.Forms.TextBox();
            this.roomNumberL = new System.Windows.Forms.Label();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.roomFloorNumL = new System.Windows.Forms.Label();
            this.roomTypeL = new System.Windows.Forms.Label();
            this.roomTypeB = new System.Windows.Forms.Button();
            this.roomDeleteB = new System.Windows.Forms.Button();
            this.roomUpdateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDGV
            // 
            this.roomDGV.AllowUserToAddRows = false;
            this.roomDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDGV.Location = new System.Drawing.Point(58, 163);
            this.roomDGV.Name = "roomDGV";
            this.roomDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDGV.Size = new System.Drawing.Size(680, 200);
            this.roomDGV.TabIndex = 1;
            this.roomDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.roomDGV_MouseDoubleClick);
            // 
            // roomL
            // 
            this.roomL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomL.AutoSize = true;
            this.roomL.BackColor = System.Drawing.Color.DarkTurquoise;
            this.roomL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomL.Location = new System.Drawing.Point(236, 30);
            this.roomL.Name = "roomL";
            this.roomL.Size = new System.Drawing.Size(293, 40);
            this.roomL.TabIndex = 32;
            this.roomL.Text = "Room Management";
            // 
            // roomFloorNumCB
            // 
            this.roomFloorNumCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomFloorNumCB.FormattingEnabled = true;
            this.roomFloorNumCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.roomFloorNumCB.Location = new System.Drawing.Point(548, 404);
            this.roomFloorNumCB.Name = "roomFloorNumCB";
            this.roomFloorNumCB.Size = new System.Drawing.Size(190, 21);
            this.roomFloorNumCB.TabIndex = 23;
            this.roomFloorNumCB.Text = "Select Floor Number";
            // 
            // addRoomB
            // 
            this.addRoomB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addRoomB.Location = new System.Drawing.Point(506, 441);
            this.addRoomB.Name = "addRoomB";
            this.addRoomB.Size = new System.Drawing.Size(80, 25);
            this.addRoomB.TabIndex = 28;
            this.addRoomB.Text = "Add Room";
            this.addRoomB.UseVisualStyleBackColor = true;
            this.addRoomB.Click += new System.EventHandler(this.addRoomB_Click);
            // 
            // roomNumberTB
            // 
            this.roomNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomNumberTB.Location = new System.Drawing.Point(184, 402);
            this.roomNumberTB.Name = "roomNumberTB";
            this.roomNumberTB.Size = new System.Drawing.Size(190, 20);
            this.roomNumberTB.TabIndex = 26;
            // 
            // roomNumberL
            // 
            this.roomNumberL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomNumberL.AutoSize = true;
            this.roomNumberL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberL.Location = new System.Drawing.Point(54, 402);
            this.roomNumberL.Name = "roomNumberL";
            this.roomNumberL.Size = new System.Drawing.Size(122, 21);
            this.roomNumberL.TabIndex = 31;
            this.roomNumberL.Text = "Room Number";
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Master Room",
            "Suite Room"});
            this.roomTypeCB.Location = new System.Drawing.Point(176, 441);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.roomTypeCB.TabIndex = 22;
            this.roomTypeCB.Text = "Select Room Type";
            // 
            // roomFloorNumL
            // 
            this.roomFloorNumL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomFloorNumL.AutoSize = true;
            this.roomFloorNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomFloorNumL.Location = new System.Drawing.Point(425, 404);
            this.roomFloorNumL.Name = "roomFloorNumL";
            this.roomFloorNumL.Size = new System.Drawing.Size(116, 21);
            this.roomFloorNumL.TabIndex = 27;
            this.roomFloorNumL.Text = "Floor Number";
            // 
            // roomTypeL
            // 
            this.roomTypeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeL.AutoSize = true;
            this.roomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeL.Location = new System.Drawing.Point(54, 441);
            this.roomTypeL.Name = "roomTypeL";
            this.roomTypeL.Size = new System.Drawing.Size(100, 21);
            this.roomTypeL.TabIndex = 24;
            this.roomTypeL.Text = "Room Type";
            // 
            // roomTypeB
            // 
            this.roomTypeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomTypeB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomTypeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomTypeB.Location = new System.Drawing.Point(605, 30);
            this.roomTypeB.Name = "roomTypeB";
            this.roomTypeB.Size = new System.Drawing.Size(133, 33);
            this.roomTypeB.TabIndex = 48;
            this.roomTypeB.Text = "Go to Room Type";
            this.roomTypeB.UseVisualStyleBackColor = false;
            this.roomTypeB.Click += new System.EventHandler(this.RoomTypeB_Click);
            // 
            // roomDeleteB
            // 
            this.roomDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomDeleteB.Location = new System.Drawing.Point(592, 441);
            this.roomDeleteB.Name = "roomDeleteB";
            this.roomDeleteB.Size = new System.Drawing.Size(70, 25);
            this.roomDeleteB.TabIndex = 49;
            this.roomDeleteB.Text = "Delete";
            this.roomDeleteB.UseVisualStyleBackColor = true;
            this.roomDeleteB.Click += new System.EventHandler(this.roomDeleteB_Click);
            // 
            // roomUpdateB
            // 
            this.roomUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roomUpdateB.Location = new System.Drawing.Point(668, 441);
            this.roomUpdateB.Name = "roomUpdateB";
            this.roomUpdateB.Size = new System.Drawing.Size(70, 25);
            this.roomUpdateB.TabIndex = 50;
            this.roomUpdateB.Text = "Update";
            this.roomUpdateB.UseVisualStyleBackColor = true;
            this.roomUpdateB.Click += new System.EventHandler(this.roomUpdateB_Click);
            // 
            // RoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomUpdateB);
            this.Controls.Add(this.roomDeleteB);
            this.Controls.Add(this.roomTypeB);
            this.Controls.Add(this.roomL);
            this.Controls.Add(this.roomFloorNumCB);
            this.Controls.Add(this.addRoomB);
            this.Controls.Add(this.roomNumberTB);
            this.Controls.Add(this.roomNumberL);
            this.Controls.Add(this.roomTypeCB);
            this.Controls.Add(this.roomFloorNumL);
            this.Controls.Add(this.roomTypeL);
            this.Controls.Add(this.roomDGV);
            this.Name = "RoomControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.RoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomDGV;
        private System.Windows.Forms.Label roomL;
        private System.Windows.Forms.ComboBox roomFloorNumCB;
        private System.Windows.Forms.Button addRoomB;
        private System.Windows.Forms.TextBox roomNumberTB;
        private System.Windows.Forms.Label roomNumberL;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.Label roomFloorNumL;
        private System.Windows.Forms.Label roomTypeL;
        private System.Windows.Forms.Button roomTypeB;
        private System.Windows.Forms.Button roomDeleteB;
        private System.Windows.Forms.Button roomUpdateB;
    }
}
