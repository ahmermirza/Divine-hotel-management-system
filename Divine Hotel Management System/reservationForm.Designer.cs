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
            this.SuspendLayout();
            // 
            // resFirstNameL
            // 
            this.resFirstNameL.AutoSize = true;
            this.resFirstNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFirstNameL.Location = new System.Drawing.Point(259, 83);
            this.resFirstNameL.Name = "resFirstNameL";
            this.resFirstNameL.Size = new System.Drawing.Size(92, 21);
            this.resFirstNameL.TabIndex = 0;
            this.resFirstNameL.Text = "First Name";
            // 
            // resLastNameL
            // 
            this.resLastNameL.AutoSize = true;
            this.resLastNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLastNameL.Location = new System.Drawing.Point(261, 126);
            this.resLastNameL.Name = "resLastNameL";
            this.resLastNameL.Size = new System.Drawing.Size(90, 21);
            this.resLastNameL.TabIndex = 1;
            this.resLastNameL.Text = "Last Name";
            // 
            // resCheckinL
            // 
            this.resCheckinL.AutoSize = true;
            this.resCheckinL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckinL.Location = new System.Drawing.Point(274, 212);
            this.resCheckinL.Name = "resCheckinL";
            this.resCheckinL.Size = new System.Drawing.Size(77, 21);
            this.resCheckinL.TabIndex = 2;
            this.resCheckinL.Text = "Check-in";
            // 
            // resCheckoutL
            // 
            this.resCheckoutL.AutoSize = true;
            this.resCheckoutL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCheckoutL.Location = new System.Drawing.Point(263, 255);
            this.resCheckoutL.Name = "resCheckoutL";
            this.resCheckoutL.Size = new System.Drawing.Size(88, 21);
            this.resCheckoutL.TabIndex = 3;
            this.resCheckoutL.Text = "Check-out";
            // 
            // resPhoneL
            // 
            this.resPhoneL.AutoSize = true;
            this.resPhoneL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPhoneL.Location = new System.Drawing.Point(229, 298);
            this.resPhoneL.Name = "resPhoneL";
            this.resPhoneL.Size = new System.Drawing.Size(122, 21);
            this.resPhoneL.TabIndex = 4;
            this.resPhoneL.Text = "Phone Number";
            // 
            // resFirstNameTB
            // 
            this.resFirstNameTB.Location = new System.Drawing.Point(356, 83);
            this.resFirstNameTB.Name = "resFirstNameTB";
            this.resFirstNameTB.Size = new System.Drawing.Size(180, 20);
            this.resFirstNameTB.TabIndex = 5;
            this.resFirstNameTB.Text = "Enter First Name Here";
            // 
            // resLastNameTB
            // 
            this.resLastNameTB.Location = new System.Drawing.Point(357, 126);
            this.resLastNameTB.Name = "resLastNameTB";
            this.resLastNameTB.Size = new System.Drawing.Size(180, 20);
            this.resLastNameTB.TabIndex = 6;
            this.resLastNameTB.Text = "Enter Last Name Here";
            // 
            // resPhoneTB
            // 
            this.resPhoneTB.Location = new System.Drawing.Point(357, 299);
            this.resPhoneTB.Name = "resPhoneTB";
            this.resPhoneTB.Size = new System.Drawing.Size(180, 20);
            this.resPhoneTB.TabIndex = 7;
            this.resPhoneTB.Text = "Enter Phone Number Here";
            // 
            // resCheckinDTP
            // 
            this.resCheckinDTP.CustomFormat = "";
            this.resCheckinDTP.Location = new System.Drawing.Point(357, 213);
            this.resCheckinDTP.Name = "resCheckinDTP";
            this.resCheckinDTP.Size = new System.Drawing.Size(180, 20);
            this.resCheckinDTP.TabIndex = 0;
            // 
            // resCheckoutDTP
            // 
            this.resCheckoutDTP.CustomFormat = "";
            this.resCheckoutDTP.Location = new System.Drawing.Point(357, 256);
            this.resCheckoutDTP.Name = "resCheckoutDTP";
            this.resCheckoutDTP.Size = new System.Drawing.Size(180, 20);
            this.resCheckoutDTP.TabIndex = 8;
            // 
            // resB
            // 
            this.resB.Location = new System.Drawing.Point(378, 339);
            this.resB.Name = "resB";
            this.resB.Size = new System.Drawing.Size(133, 28);
            this.resB.TabIndex = 9;
            this.resB.Text = "Confirm Reservation";
            this.resB.UseVisualStyleBackColor = true;
            this.resB.Click += new System.EventHandler(this.resB_Click);
            // 
            // resRoomTypeL
            // 
            this.resRoomTypeL.AutoSize = true;
            this.resRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resRoomTypeL.Location = new System.Drawing.Point(251, 169);
            this.resRoomTypeL.Name = "resRoomTypeL";
            this.resRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.resRoomTypeL.TabIndex = 10;
            this.resRoomTypeL.Text = "Room Type";
            // 
            // resRoomTypeCB
            // 
            this.resRoomTypeCB.FormattingEnabled = true;
            this.resRoomTypeCB.Location = new System.Drawing.Point(356, 169);
            this.resRoomTypeCB.Name = "resRoomTypeCB";
            this.resRoomTypeCB.Size = new System.Drawing.Size(180, 21);
            this.resRoomTypeCB.TabIndex = 11;
            this.resRoomTypeCB.Text = "Select Room Type";
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Make Reservation";
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
    }
}