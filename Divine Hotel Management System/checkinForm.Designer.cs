namespace Divine_Hotel_Management_System
{
    partial class checkinForm
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
            this.checkinDTP = new System.Windows.Forms.DateTimePicker();
            this.checkinResNumCB = new System.Windows.Forms.ComboBox();
            this.checkinResNumL = new System.Windows.Forms.Label();
            this.checkinFirstNameL = new System.Windows.Forms.Label();
            this.checkinFirstNameTB = new System.Windows.Forms.TextBox();
            this.checkinLastNameTB = new System.Windows.Forms.TextBox();
            this.checkinLastNameL = new System.Windows.Forms.Label();
            this.checkinPhoneL = new System.Windows.Forms.Label();
            this.checkinPhoneTB = new System.Windows.Forms.TextBox();
            this.checkinDTPL = new System.Windows.Forms.Label();
            this.checkinIDNumL = new System.Windows.Forms.Label();
            this.checkinIDNumTB = new System.Windows.Forms.TextBox();
            this.checkinRoomTypeL = new System.Windows.Forms.Label();
            this.checkinRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.checkinB = new System.Windows.Forms.Button();
            this.checkinRoomNumL = new System.Windows.Forms.Label();
            this.checkinRoomNumCB = new System.Windows.Forms.ComboBox();
            this.resetCheckinB = new System.Windows.Forms.Button();
            this.checkinL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkinDTP
            // 
            this.checkinDTP.Location = new System.Drawing.Point(267, 380);
            this.checkinDTP.Name = "checkinDTP";
            this.checkinDTP.Size = new System.Drawing.Size(190, 20);
            this.checkinDTP.TabIndex = 7;
            // 
            // checkinResNumCB
            // 
            this.checkinResNumCB.ForeColor = System.Drawing.Color.Gray;
            this.checkinResNumCB.FormattingEnabled = true;
            this.checkinResNumCB.Location = new System.Drawing.Point(267, 97);
            this.checkinResNumCB.Name = "checkinResNumCB";
            this.checkinResNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkinResNumCB.TabIndex = 0;
            this.checkinResNumCB.Text = "Select Reservation Number";
            this.checkinResNumCB.TextChanged += new System.EventHandler(this.checkinResNumCB_TextChanged);
            // 
            // checkinResNumL
            // 
            this.checkinResNumL.AutoSize = true;
            this.checkinResNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinResNumL.Location = new System.Drawing.Point(96, 96);
            this.checkinResNumL.Name = "checkinResNumL";
            this.checkinResNumL.Size = new System.Drawing.Size(163, 21);
            this.checkinResNumL.TabIndex = 2;
            this.checkinResNumL.Text = "Reservation Number";
            // 
            // checkinFirstNameL
            // 
            this.checkinFirstNameL.AutoSize = true;
            this.checkinFirstNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinFirstNameL.Location = new System.Drawing.Point(167, 136);
            this.checkinFirstNameL.Name = "checkinFirstNameL";
            this.checkinFirstNameL.Size = new System.Drawing.Size(92, 21);
            this.checkinFirstNameL.TabIndex = 3;
            this.checkinFirstNameL.Text = "First Name";
            // 
            // checkinFirstNameTB
            // 
            this.checkinFirstNameTB.ForeColor = System.Drawing.Color.Gray;
            this.checkinFirstNameTB.Location = new System.Drawing.Point(267, 138);
            this.checkinFirstNameTB.Name = "checkinFirstNameTB";
            this.checkinFirstNameTB.Size = new System.Drawing.Size(190, 20);
            this.checkinFirstNameTB.TabIndex = 1;
            this.checkinFirstNameTB.Text = "Enter First Name Here";
            this.checkinFirstNameTB.Enter += new System.EventHandler(this.checkinFirstNameTB_Enter);
            this.checkinFirstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkinFirstNameTB_KeyPress);
            this.checkinFirstNameTB.Leave += new System.EventHandler(this.checkinFirstNameTB_Leave);
            // 
            // checkinLastNameTB
            // 
            this.checkinLastNameTB.ForeColor = System.Drawing.Color.Gray;
            this.checkinLastNameTB.Location = new System.Drawing.Point(267, 178);
            this.checkinLastNameTB.Name = "checkinLastNameTB";
            this.checkinLastNameTB.Size = new System.Drawing.Size(190, 20);
            this.checkinLastNameTB.TabIndex = 2;
            this.checkinLastNameTB.Text = "Enter Last Name Here";
            this.checkinLastNameTB.Enter += new System.EventHandler(this.checkinLastNameTB_Enter);
            this.checkinLastNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkinLastNameTB_KeyPress);
            this.checkinLastNameTB.Leave += new System.EventHandler(this.checkinLastNameTB_Leave);
            // 
            // checkinLastNameL
            // 
            this.checkinLastNameL.AutoSize = true;
            this.checkinLastNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinLastNameL.Location = new System.Drawing.Point(169, 176);
            this.checkinLastNameL.Name = "checkinLastNameL";
            this.checkinLastNameL.Size = new System.Drawing.Size(90, 21);
            this.checkinLastNameL.TabIndex = 6;
            this.checkinLastNameL.Text = "Last Name";
            // 
            // checkinPhoneL
            // 
            this.checkinPhoneL.AutoSize = true;
            this.checkinPhoneL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinPhoneL.Location = new System.Drawing.Point(137, 338);
            this.checkinPhoneL.Name = "checkinPhoneL";
            this.checkinPhoneL.Size = new System.Drawing.Size(122, 21);
            this.checkinPhoneL.TabIndex = 8;
            this.checkinPhoneL.Text = "Phone Number";
            // 
            // checkinPhoneTB
            // 
            this.checkinPhoneTB.ForeColor = System.Drawing.Color.Gray;
            this.checkinPhoneTB.Location = new System.Drawing.Point(267, 340);
            this.checkinPhoneTB.Name = "checkinPhoneTB";
            this.checkinPhoneTB.Size = new System.Drawing.Size(190, 20);
            this.checkinPhoneTB.TabIndex = 6;
            this.checkinPhoneTB.Text = "Enter Phone Number Here";
            this.checkinPhoneTB.Enter += new System.EventHandler(this.checkinPhoneTB_Enter);
            this.checkinPhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkinPhoneTB_KeyPress);
            this.checkinPhoneTB.Leave += new System.EventHandler(this.checkinPhoneTB_Leave);
            // 
            // checkinDTPL
            // 
            this.checkinDTPL.AutoSize = true;
            this.checkinDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinDTPL.Location = new System.Drawing.Point(182, 379);
            this.checkinDTPL.Name = "checkinDTPL";
            this.checkinDTPL.Size = new System.Drawing.Size(77, 21);
            this.checkinDTPL.TabIndex = 9;
            this.checkinDTPL.Text = "Check-in";
            // 
            // checkinIDNumL
            // 
            this.checkinIDNumL.AutoSize = true;
            this.checkinIDNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinIDNumL.Location = new System.Drawing.Point(165, 299);
            this.checkinIDNumL.Name = "checkinIDNumL";
            this.checkinIDNumL.Size = new System.Drawing.Size(94, 21);
            this.checkinIDNumL.TabIndex = 11;
            this.checkinIDNumL.Text = "ID Number";
            // 
            // checkinIDNumTB
            // 
            this.checkinIDNumTB.ForeColor = System.Drawing.Color.Gray;
            this.checkinIDNumTB.Location = new System.Drawing.Point(267, 300);
            this.checkinIDNumTB.Name = "checkinIDNumTB";
            this.checkinIDNumTB.Size = new System.Drawing.Size(190, 20);
            this.checkinIDNumTB.TabIndex = 5;
            this.checkinIDNumTB.Text = "Enter ID Number Here";
            this.checkinIDNumTB.Enter += new System.EventHandler(this.checkinIDNumTB_Enter);
            this.checkinIDNumTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkinIDNumTB_KeyPress);
            this.checkinIDNumTB.Leave += new System.EventHandler(this.checkinIDNumTB_Leave);
            // 
            // checkinRoomTypeL
            // 
            this.checkinRoomTypeL.AutoSize = true;
            this.checkinRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinRoomTypeL.Location = new System.Drawing.Point(159, 217);
            this.checkinRoomTypeL.Name = "checkinRoomTypeL";
            this.checkinRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.checkinRoomTypeL.TabIndex = 13;
            this.checkinRoomTypeL.Text = "Room Type";
            // 
            // checkinRoomTypeCB
            // 
            this.checkinRoomTypeCB.ForeColor = System.Drawing.Color.Gray;
            this.checkinRoomTypeCB.FormattingEnabled = true;
            this.checkinRoomTypeCB.Location = new System.Drawing.Point(267, 218);
            this.checkinRoomTypeCB.Name = "checkinRoomTypeCB";
            this.checkinRoomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.checkinRoomTypeCB.TabIndex = 3;
            this.checkinRoomTypeCB.Text = "Select Room Type";
            this.checkinRoomTypeCB.TextChanged += new System.EventHandler(this.checkinRoomTypeCB_TextChanged);
            // 
            // checkinB
            // 
            this.checkinB.Location = new System.Drawing.Point(267, 420);
            this.checkinB.Name = "checkinB";
            this.checkinB.Size = new System.Drawing.Size(72, 26);
            this.checkinB.TabIndex = 8;
            this.checkinB.Text = "Check-in";
            this.checkinB.UseVisualStyleBackColor = true;
            this.checkinB.Click += new System.EventHandler(this.checkinB_Click);
            // 
            // checkinRoomNumL
            // 
            this.checkinRoomNumL.AutoSize = true;
            this.checkinRoomNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinRoomNumL.Location = new System.Drawing.Point(137, 258);
            this.checkinRoomNumL.Name = "checkinRoomNumL";
            this.checkinRoomNumL.Size = new System.Drawing.Size(122, 21);
            this.checkinRoomNumL.TabIndex = 16;
            this.checkinRoomNumL.Text = "Room Number";
            // 
            // checkinRoomNumCB
            // 
            this.checkinRoomNumCB.ForeColor = System.Drawing.Color.Gray;
            this.checkinRoomNumCB.FormattingEnabled = true;
            this.checkinRoomNumCB.Location = new System.Drawing.Point(267, 259);
            this.checkinRoomNumCB.Name = "checkinRoomNumCB";
            this.checkinRoomNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkinRoomNumCB.TabIndex = 4;
            this.checkinRoomNumCB.Text = "Select Room Number";
            this.checkinRoomNumCB.TextChanged += new System.EventHandler(this.checkinRoomNumCB_TextChanged);
            // 
            // resetCheckinB
            // 
            this.resetCheckinB.Location = new System.Drawing.Point(395, 420);
            this.resetCheckinB.Name = "resetCheckinB";
            this.resetCheckinB.Size = new System.Drawing.Size(62, 26);
            this.resetCheckinB.TabIndex = 9;
            this.resetCheckinB.Text = "Reset";
            this.resetCheckinB.UseVisualStyleBackColor = true;
            this.resetCheckinB.Click += new System.EventHandler(this.resetCheckinB_Click);
            // 
            // checkinL
            // 
            this.checkinL.AutoSize = true;
            this.checkinL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkinL.Location = new System.Drawing.Point(93, 32);
            this.checkinL.Name = "checkinL";
            this.checkinL.Size = new System.Drawing.Size(401, 40);
            this.checkinL.TabIndex = 19;
            this.checkinL.Text = "Enter Check-in Details Below";
            // 
            // checkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(600, 487);
            this.Controls.Add(this.checkinL);
            this.Controls.Add(this.resetCheckinB);
            this.Controls.Add(this.checkinRoomNumL);
            this.Controls.Add(this.checkinRoomNumCB);
            this.Controls.Add(this.checkinB);
            this.Controls.Add(this.checkinRoomTypeL);
            this.Controls.Add(this.checkinRoomTypeCB);
            this.Controls.Add(this.checkinIDNumL);
            this.Controls.Add(this.checkinIDNumTB);
            this.Controls.Add(this.checkinDTPL);
            this.Controls.Add(this.checkinPhoneL);
            this.Controls.Add(this.checkinPhoneTB);
            this.Controls.Add(this.checkinLastNameL);
            this.Controls.Add(this.checkinLastNameTB);
            this.Controls.Add(this.checkinFirstNameTB);
            this.Controls.Add(this.checkinFirstNameL);
            this.Controls.Add(this.checkinResNumL);
            this.Controls.Add(this.checkinResNumCB);
            this.Controls.Add(this.checkinDTP);
            this.Name = "checkinForm";
            this.Text = "Check-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkinDTP;
        private System.Windows.Forms.ComboBox checkinResNumCB;
        private System.Windows.Forms.Label checkinResNumL;
        private System.Windows.Forms.Label checkinFirstNameL;
        private System.Windows.Forms.TextBox checkinFirstNameTB;
        private System.Windows.Forms.TextBox checkinLastNameTB;
        private System.Windows.Forms.Label checkinLastNameL;
        private System.Windows.Forms.Label checkinPhoneL;
        private System.Windows.Forms.TextBox checkinPhoneTB;
        private System.Windows.Forms.Label checkinDTPL;
        private System.Windows.Forms.Label checkinIDNumL;
        private System.Windows.Forms.TextBox checkinIDNumTB;
        private System.Windows.Forms.Label checkinRoomTypeL;
        private System.Windows.Forms.ComboBox checkinRoomTypeCB;
        private System.Windows.Forms.Button checkinB;
        private System.Windows.Forms.Label checkinRoomNumL;
        private System.Windows.Forms.ComboBox checkinRoomNumCB;
        private System.Windows.Forms.Button resetCheckinB;
        private System.Windows.Forms.Label checkinL;
    }
}