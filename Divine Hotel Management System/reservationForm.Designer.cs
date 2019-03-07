namespace Divine_Hotel_Management_System
{
    partial class reservationForm
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
            this.resFirstNameL = new System.Windows.Forms.Label();
            this.resLastNameL = new System.Windows.Forms.Label();
            this.resCheckinL = new System.Windows.Forms.Label();
            this.resCheckoutL = new System.Windows.Forms.Label();
            this.resPhoneL = new System.Windows.Forms.Label();
            this.resFirstNameTB = new System.Windows.Forms.TextBox();
            this.resLastNameTB = new System.Windows.Forms.TextBox();
            this.resPhoneTB = new System.Windows.Forms.TextBox();
            this.resCheckinDTP = new System.Windows.Forms.DateTimePicker();
            this.resCheckoutDTP = new System.Windows.Forms.DateTimePicker();
            this.resB = new System.Windows.Forms.Button();
            this.resRoomTypeL = new System.Windows.Forms.Label();
            this.resRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.resetResB = new System.Windows.Forms.Button();
            this.reservationL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resFirstNameL
            // 
            this.resFirstNameL.AutoSize = true;
            this.resFirstNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFirstNameL.Location = new System.Drawing.Point(154, 107);
            this.resFirstNameL.Name = "resFirstNameL";
            this.resFirstNameL.Size = new System.Drawing.Size(92, 21);
            this.resFirstNameL.TabIndex = 0;
            this.resFirstNameL.Text = "First Name";
            // 
            // resLastNameL
            // 
            this.resLastNameL.AutoSize = true;
            this.resLastNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLastNameL.Location = new System.Drawing.Point(156, 149);
            this.resLastNameL.Name = "resLastNameL";
            this.resLastNameL.Size = new System.Drawing.Size(90, 21);
            this.resLastNameL.TabIndex = 1;
            this.resLastNameL.Text = "Last Name";
            // 
            // resCheckinL
            // 
            this.resCheckinL.AutoSize = true;
            this.resCheckinL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckinL.Location = new System.Drawing.Point(169, 233);
            this.resCheckinL.Name = "resCheckinL";
            this.resCheckinL.Size = new System.Drawing.Size(77, 21);
            this.resCheckinL.TabIndex = 2;
            this.resCheckinL.Text = "Check-in";
            // 
            // resCheckoutL
            // 
            this.resCheckoutL.AutoSize = true;
            this.resCheckoutL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckoutL.Location = new System.Drawing.Point(158, 275);
            this.resCheckoutL.Name = "resCheckoutL";
            this.resCheckoutL.Size = new System.Drawing.Size(88, 21);
            this.resCheckoutL.TabIndex = 3;
            this.resCheckoutL.Text = "Check-out";
            // 
            // resPhoneL
            // 
            this.resPhoneL.AutoSize = true;
            this.resPhoneL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPhoneL.Location = new System.Drawing.Point(124, 317);
            this.resPhoneL.Name = "resPhoneL";
            this.resPhoneL.Size = new System.Drawing.Size(122, 21);
            this.resPhoneL.TabIndex = 4;
            this.resPhoneL.Text = "Phone Number";
            // 
            // resFirstNameTB
            // 
            this.resFirstNameTB.ForeColor = System.Drawing.Color.Gray;
            this.resFirstNameTB.Location = new System.Drawing.Point(251, 108);
            this.resFirstNameTB.Name = "resFirstNameTB";
            this.resFirstNameTB.Size = new System.Drawing.Size(190, 20);
            this.resFirstNameTB.TabIndex = 0;
            this.resFirstNameTB.Text = "Enter First Name Here";
            this.resFirstNameTB.Enter += new System.EventHandler(this.resFirstNameTB_Enter);
            this.resFirstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resFirstNameTB_KeyPress);
            this.resFirstNameTB.Leave += new System.EventHandler(this.resFirstNameTB_Leave);
            // 
            // resLastNameTB
            // 
            this.resLastNameTB.ForeColor = System.Drawing.Color.Gray;
            this.resLastNameTB.Location = new System.Drawing.Point(251, 150);
            this.resLastNameTB.Name = "resLastNameTB";
            this.resLastNameTB.Size = new System.Drawing.Size(190, 20);
            this.resLastNameTB.TabIndex = 1;
            this.resLastNameTB.Text = "Enter Last Name Here";
            this.resLastNameTB.Enter += new System.EventHandler(this.resLastNameTB_Enter);
            this.resLastNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resLastNameTB_KeyPress);
            this.resLastNameTB.Leave += new System.EventHandler(this.resLastNameTB_Leave);
            // 
            // resPhoneTB
            // 
            this.resPhoneTB.ForeColor = System.Drawing.Color.Gray;
            this.resPhoneTB.Location = new System.Drawing.Point(251, 319);
            this.resPhoneTB.Name = "resPhoneTB";
            this.resPhoneTB.Size = new System.Drawing.Size(190, 20);
            this.resPhoneTB.TabIndex = 5;
            this.resPhoneTB.Text = "Enter Phone Number Here";
            this.resPhoneTB.Enter += new System.EventHandler(this.resPhoneTB_Enter);
            this.resPhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resPhoneTB_KeyPress);
            this.resPhoneTB.Leave += new System.EventHandler(this.resPhoneTB_Leave);
            // 
            // resCheckinDTP
            // 
            this.resCheckinDTP.CustomFormat = "";
            this.resCheckinDTP.Location = new System.Drawing.Point(251, 235);
            this.resCheckinDTP.Name = "resCheckinDTP";
            this.resCheckinDTP.Size = new System.Drawing.Size(190, 20);
            this.resCheckinDTP.TabIndex = 3;
            this.resCheckinDTP.ValueChanged += new System.EventHandler(this.resCheckinDTP_ValueChanged);
            // 
            // resCheckoutDTP
            // 
            this.resCheckoutDTP.CustomFormat = "";
            this.resCheckoutDTP.Location = new System.Drawing.Point(251, 277);
            this.resCheckoutDTP.Name = "resCheckoutDTP";
            this.resCheckoutDTP.Size = new System.Drawing.Size(190, 20);
            this.resCheckoutDTP.TabIndex = 4;
            this.resCheckoutDTP.ValueChanged += new System.EventHandler(this.resCheckoutDTP_ValueChanged);
            // 
            // resB
            // 
            this.resB.Location = new System.Drawing.Point(251, 361);
            this.resB.Name = "resB";
            this.resB.Size = new System.Drawing.Size(117, 26);
            this.resB.TabIndex = 6;
            this.resB.Text = "Confirm Reservation";
            this.resB.UseVisualStyleBackColor = true;
            this.resB.Click += new System.EventHandler(this.resB_Click);
            // 
            // resRoomTypeL
            // 
            this.resRoomTypeL.AutoSize = true;
            this.resRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRoomTypeL.Location = new System.Drawing.Point(146, 191);
            this.resRoomTypeL.Name = "resRoomTypeL";
            this.resRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.resRoomTypeL.TabIndex = 10;
            this.resRoomTypeL.Text = "Room Type";
            // 
            // resRoomTypeCB
            // 
            this.resRoomTypeCB.ForeColor = System.Drawing.Color.Gray;
            this.resRoomTypeCB.FormattingEnabled = true;
            this.resRoomTypeCB.Location = new System.Drawing.Point(251, 192);
            this.resRoomTypeCB.Name = "resRoomTypeCB";
            this.resRoomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.resRoomTypeCB.TabIndex = 2;
            this.resRoomTypeCB.Text = "Select Room Type";
            this.resRoomTypeCB.TextChanged += new System.EventHandler(this.resRoomTypeCB_TextChanged);
            // 
            // resetResB
            // 
            this.resetResB.Location = new System.Drawing.Point(386, 361);
            this.resetResB.Name = "resetResB";
            this.resetResB.Size = new System.Drawing.Size(55, 26);
            this.resetResB.TabIndex = 7;
            this.resetResB.Text = "Reset";
            this.resetResB.UseVisualStyleBackColor = true;
            this.resetResB.Click += new System.EventHandler(this.resetResB_Click);
            // 
            // reservationL
            // 
            this.reservationL.AutoSize = true;
            this.reservationL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reservationL.Location = new System.Drawing.Point(83, 41);
            this.reservationL.Name = "reservationL";
            this.reservationL.Size = new System.Drawing.Size(436, 40);
            this.reservationL.TabIndex = 18;
            this.reservationL.Text = "Enter Reservation Details Below";
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(613, 444);
            this.Controls.Add(this.reservationL);
            this.Controls.Add(this.resetResB);
            this.Controls.Add(this.resRoomTypeCB);
            this.Controls.Add(this.resRoomTypeL);
            this.Controls.Add(this.resB);
            this.Controls.Add(this.resCheckoutDTP);
            this.Controls.Add(this.resCheckinDTP);
            this.Controls.Add(this.resPhoneTB);
            this.Controls.Add(this.resLastNameTB);
            this.Controls.Add(this.resFirstNameTB);
            this.Controls.Add(this.resPhoneL);
            this.Controls.Add(this.resCheckoutL);
            this.Controls.Add(this.resCheckinL);
            this.Controls.Add(this.resLastNameL);
            this.Controls.Add(this.resFirstNameL);
            this.Name = "reservationForm";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resFirstNameL;
        private System.Windows.Forms.Label resLastNameL;
        private System.Windows.Forms.Label resCheckinL;
        private System.Windows.Forms.Label resCheckoutL;
        private System.Windows.Forms.Label resPhoneL;
        private System.Windows.Forms.TextBox resFirstNameTB;
        private System.Windows.Forms.TextBox resLastNameTB;
        private System.Windows.Forms.TextBox resPhoneTB;
        private System.Windows.Forms.DateTimePicker resCheckinDTP;
        private System.Windows.Forms.DateTimePicker resCheckoutDTP;
        private System.Windows.Forms.Button resB;
        private System.Windows.Forms.Label resRoomTypeL;
        private System.Windows.Forms.ComboBox resRoomTypeCB;
        private System.Windows.Forms.Button resetResB;
        private System.Windows.Forms.Label reservationL;
    }
}