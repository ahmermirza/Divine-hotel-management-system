namespace Divine_Hotel_Management_System
{
    partial class ReservationControl
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
            this.resTotalAmountTB = new System.Windows.Forms.TextBox();
            this.resTotalAmountL = new System.Windows.Forms.Label();
            this.resGuestsIDCB = new System.Windows.Forms.ComboBox();
            this.resGuestsIDL = new System.Windows.Forms.Label();
            this.reservationL = new System.Windows.Forms.Label();
            this.resDeleteB = new System.Windows.Forms.Button();
            this.resRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.resRoomTypeL = new System.Windows.Forms.Label();
            this.addResB = new System.Windows.Forms.Button();
            this.resCheckoutDTP = new System.Windows.Forms.DateTimePicker();
            this.resCheckinDTP = new System.Windows.Forms.DateTimePicker();
            this.resPeopleNumL = new System.Windows.Forms.Label();
            this.resCheckoutL = new System.Windows.Forms.Label();
            this.resCheckinL = new System.Windows.Forms.Label();
            this.resPeopleNumCB = new System.Windows.Forms.ComboBox();
            this.amenityB = new System.Windows.Forms.Button();
            this.resUpdateB = new System.Windows.Forms.Button();
            this.reservationDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // resTotalAmountTB
            // 
            this.resTotalAmountTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resTotalAmountTB.BackColor = System.Drawing.Color.White;
            this.resTotalAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resTotalAmountTB.Location = new System.Drawing.Point(548, 446);
            this.resTotalAmountTB.Name = "resTotalAmountTB";
            this.resTotalAmountTB.ReadOnly = true;
            this.resTotalAmountTB.Size = new System.Drawing.Size(190, 20);
            this.resTotalAmountTB.TabIndex = 6;
            this.resTotalAmountTB.Text = "0.00";
            // 
            // resTotalAmountL
            // 
            this.resTotalAmountL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resTotalAmountL.AutoSize = true;
            this.resTotalAmountL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resTotalAmountL.Location = new System.Drawing.Point(394, 446);
            this.resTotalAmountL.Name = "resTotalAmountL";
            this.resTotalAmountL.Size = new System.Drawing.Size(112, 21);
            this.resTotalAmountL.TabIndex = 40;
            this.resTotalAmountL.Text = "Total Amount";
            // 
            // resGuestsIDCB
            // 
            this.resGuestsIDCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resGuestsIDCB.FormattingEnabled = true;
            this.resGuestsIDCB.Location = new System.Drawing.Point(166, 403);
            this.resGuestsIDCB.Name = "resGuestsIDCB";
            this.resGuestsIDCB.Size = new System.Drawing.Size(190, 21);
            this.resGuestsIDCB.TabIndex = 1;
            this.resGuestsIDCB.Text = "Select Guest ID";
            // 
            // resGuestsIDL
            // 
            this.resGuestsIDL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resGuestsIDL.AutoSize = true;
            this.resGuestsIDL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resGuestsIDL.Location = new System.Drawing.Point(54, 402);
            this.resGuestsIDL.Name = "resGuestsIDL";
            this.resGuestsIDL.Size = new System.Drawing.Size(78, 21);
            this.resGuestsIDL.TabIndex = 39;
            this.resGuestsIDL.Text = "Guest ID";
            // 
            // reservationL
            // 
            this.reservationL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reservationL.AutoSize = true;
            this.reservationL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.reservationL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationL.Location = new System.Drawing.Point(211, 30);
            this.reservationL.Name = "reservationL";
            this.reservationL.Size = new System.Drawing.Size(374, 40);
            this.reservationL.TabIndex = 37;
            this.reservationL.Text = "Reservation Management";
            // 
            // resDeleteB
            // 
            this.resDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resDeleteB.Location = new System.Drawing.Point(592, 480);
            this.resDeleteB.Name = "resDeleteB";
            this.resDeleteB.Size = new System.Drawing.Size(70, 25);
            this.resDeleteB.TabIndex = 8;
            this.resDeleteB.Text = "Delete";
            this.resDeleteB.UseVisualStyleBackColor = true;
            this.resDeleteB.Click += new System.EventHandler(this.resDeleteB_Click);
            // 
            // resRoomTypeCB
            // 
            this.resRoomTypeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resRoomTypeCB.FormattingEnabled = true;
            this.resRoomTypeCB.Location = new System.Drawing.Point(166, 444);
            this.resRoomTypeCB.Name = "resRoomTypeCB";
            this.resRoomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.resRoomTypeCB.TabIndex = 2;
            this.resRoomTypeCB.Text = "Select Room Type";
            this.resRoomTypeCB.SelectedIndexChanged += new System.EventHandler(this.resRoomTypeCB_SelectedIndexChanged);
            // 
            // resRoomTypeL
            // 
            this.resRoomTypeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resRoomTypeL.AutoSize = true;
            this.resRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRoomTypeL.Location = new System.Drawing.Point(54, 443);
            this.resRoomTypeL.Name = "resRoomTypeL";
            this.resRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.resRoomTypeL.TabIndex = 36;
            this.resRoomTypeL.Text = "Room Type";
            // 
            // addResB
            // 
            this.addResB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addResB.Location = new System.Drawing.Point(476, 480);
            this.addResB.Name = "addResB";
            this.addResB.Size = new System.Drawing.Size(110, 25);
            this.addResB.TabIndex = 7;
            this.addResB.Text = "Add Reservation";
            this.addResB.UseVisualStyleBackColor = true;
            this.addResB.Click += new System.EventHandler(this.addResB_Click);
            // 
            // resCheckoutDTP
            // 
            this.resCheckoutDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resCheckoutDTP.CustomFormat = "";
            this.resCheckoutDTP.Location = new System.Drawing.Point(166, 525);
            this.resCheckoutDTP.Name = "resCheckoutDTP";
            this.resCheckoutDTP.Size = new System.Drawing.Size(190, 20);
            this.resCheckoutDTP.TabIndex = 4;
            this.resCheckoutDTP.ValueChanged += new System.EventHandler(this.resCheckoutDTP_ValueChanged);
            // 
            // resCheckinDTP
            // 
            this.resCheckinDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resCheckinDTP.CustomFormat = "";
            this.resCheckinDTP.Location = new System.Drawing.Point(166, 485);
            this.resCheckinDTP.Name = "resCheckinDTP";
            this.resCheckinDTP.Size = new System.Drawing.Size(190, 20);
            this.resCheckinDTP.TabIndex = 3;
            this.resCheckinDTP.ValueChanged += new System.EventHandler(this.resCheckinDTP_ValueChanged);
            // 
            // resPeopleNumL
            // 
            this.resPeopleNumL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resPeopleNumL.AutoSize = true;
            this.resPeopleNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPeopleNumL.Location = new System.Drawing.Point(394, 409);
            this.resPeopleNumL.Name = "resPeopleNumL";
            this.resPeopleNumL.Size = new System.Drawing.Size(147, 21);
            this.resPeopleNumL.TabIndex = 31;
            this.resPeopleNumL.Text = "Number of People";
            // 
            // resCheckoutL
            // 
            this.resCheckoutL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resCheckoutL.AutoSize = true;
            this.resCheckoutL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckoutL.Location = new System.Drawing.Point(54, 525);
            this.resCheckoutL.Name = "resCheckoutL";
            this.resCheckoutL.Size = new System.Drawing.Size(88, 21);
            this.resCheckoutL.TabIndex = 29;
            this.resCheckoutL.Text = "Check-out";
            // 
            // resCheckinL
            // 
            this.resCheckinL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resCheckinL.AutoSize = true;
            this.resCheckinL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckinL.Location = new System.Drawing.Point(54, 484);
            this.resCheckinL.Name = "resCheckinL";
            this.resCheckinL.Size = new System.Drawing.Size(77, 21);
            this.resCheckinL.TabIndex = 27;
            this.resCheckinL.Text = "Check-in";
            // 
            // resPeopleNumCB
            // 
            this.resPeopleNumCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resPeopleNumCB.FormattingEnabled = true;
            this.resPeopleNumCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.resPeopleNumCB.Location = new System.Drawing.Point(548, 411);
            this.resPeopleNumCB.Name = "resPeopleNumCB";
            this.resPeopleNumCB.Size = new System.Drawing.Size(190, 21);
            this.resPeopleNumCB.TabIndex = 5;
            this.resPeopleNumCB.Text = "Select Number of People";
            // 
            // amenityB
            // 
            this.amenityB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amenityB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.amenityB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amenityB.Location = new System.Drawing.Point(605, 30);
            this.amenityB.Name = "amenityB";
            this.amenityB.Size = new System.Drawing.Size(133, 33);
            this.amenityB.TabIndex = 49;
            this.amenityB.Text = "Go to Amenity";
            this.amenityB.UseVisualStyleBackColor = false;
            this.amenityB.Click += new System.EventHandler(this.amenityB_Click);
            // 
            // resUpdateB
            // 
            this.resUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resUpdateB.Location = new System.Drawing.Point(668, 480);
            this.resUpdateB.Name = "resUpdateB";
            this.resUpdateB.Size = new System.Drawing.Size(70, 25);
            this.resUpdateB.TabIndex = 9;
            this.resUpdateB.Text = "Update";
            this.resUpdateB.UseVisualStyleBackColor = true;
            this.resUpdateB.Click += new System.EventHandler(this.resUpdateB_Click);
            // 
            // reservationDGV
            // 
            this.reservationDGV.AllowUserToAddRows = false;
            this.reservationDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDGV.Location = new System.Drawing.Point(58, 163);
            this.reservationDGV.Name = "reservationDGV";
            this.reservationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDGV.Size = new System.Drawing.Size(680, 200);
            this.reservationDGV.TabIndex = 43;
            this.reservationDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reservationDGV_MouseDoubleClick);
            // 
            // ReservationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resUpdateB);
            this.Controls.Add(this.amenityB);
            this.Controls.Add(this.reservationDGV);
            this.Controls.Add(this.resPeopleNumCB);
            this.Controls.Add(this.resTotalAmountTB);
            this.Controls.Add(this.resTotalAmountL);
            this.Controls.Add(this.resGuestsIDCB);
            this.Controls.Add(this.resGuestsIDL);
            this.Controls.Add(this.reservationL);
            this.Controls.Add(this.resDeleteB);
            this.Controls.Add(this.resRoomTypeCB);
            this.Controls.Add(this.resRoomTypeL);
            this.Controls.Add(this.addResB);
            this.Controls.Add(this.resCheckoutDTP);
            this.Controls.Add(this.resCheckinDTP);
            this.Controls.Add(this.resPeopleNumL);
            this.Controls.Add(this.resCheckoutL);
            this.Controls.Add(this.resCheckinL);
            this.Name = "ReservationControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ReservationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resTotalAmountTB;
        private System.Windows.Forms.Label resTotalAmountL;
        private System.Windows.Forms.ComboBox resGuestsIDCB;
        private System.Windows.Forms.Label resGuestsIDL;
        private System.Windows.Forms.Label reservationL;
        private System.Windows.Forms.Button resDeleteB;
        private System.Windows.Forms.ComboBox resRoomTypeCB;
        private System.Windows.Forms.Label resRoomTypeL;
        private System.Windows.Forms.Button addResB;
        private System.Windows.Forms.DateTimePicker resCheckoutDTP;
        private System.Windows.Forms.DateTimePicker resCheckinDTP;
        private System.Windows.Forms.Label resPeopleNumL;
        private System.Windows.Forms.Label resCheckoutL;
        private System.Windows.Forms.Label resCheckinL;
        private System.Windows.Forms.ComboBox resPeopleNumCB;
        private System.Windows.Forms.Button amenityB;
        private System.Windows.Forms.Button resUpdateB;
        private System.Windows.Forms.DataGridView reservationDGV;
    }
}
