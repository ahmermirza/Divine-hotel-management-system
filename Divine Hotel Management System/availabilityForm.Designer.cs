namespace Divine_Hotel_Management_System
{
    partial class availabilityForm
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
            this.availCheckoutDTP = new System.Windows.Forms.DateTimePicker();
            this.availCheckinDTP = new System.Windows.Forms.DateTimePicker();
            this.availCheckoutL = new System.Windows.Forms.Label();
            this.availCheckinL = new System.Windows.Forms.Label();
            this.availRoomTypeL = new System.Windows.Forms.Label();
            this.availRoomTypeCB = new System.Windows.Forms.ComboBox();
            this.dateValidityMessageL = new System.Windows.Forms.Label();
            this.availCheckB = new System.Windows.Forms.Button();
            this.availabilityL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availCheckoutDTP
            // 
            this.availCheckoutDTP.Location = new System.Drawing.Point(290, 201);
            this.availCheckoutDTP.Name = "availCheckoutDTP";
            this.availCheckoutDTP.Size = new System.Drawing.Size(190, 20);
            this.availCheckoutDTP.TabIndex = 2;
            this.availCheckoutDTP.CloseUp += new System.EventHandler(this.availCheckoutDT_CloseUp);
            // 
            // availCheckinDTP
            // 
            this.availCheckinDTP.Checked = false;
            this.availCheckinDTP.Location = new System.Drawing.Point(290, 164);
            this.availCheckinDTP.Name = "availCheckinDTP";
            this.availCheckinDTP.Size = new System.Drawing.Size(190, 20);
            this.availCheckinDTP.TabIndex = 1;
            // 
            // availCheckoutL
            // 
            this.availCheckoutL.AutoSize = true;
            this.availCheckoutL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availCheckoutL.Location = new System.Drawing.Point(195, 199);
            this.availCheckoutL.Name = "availCheckoutL";
            this.availCheckoutL.Size = new System.Drawing.Size(88, 21);
            this.availCheckoutL.TabIndex = 12;
            this.availCheckoutL.Text = "Check-out";
            // 
            // availCheckinL
            // 
            this.availCheckinL.AutoSize = true;
            this.availCheckinL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availCheckinL.Location = new System.Drawing.Point(206, 163);
            this.availCheckinL.Name = "availCheckinL";
            this.availCheckinL.Size = new System.Drawing.Size(77, 21);
            this.availCheckinL.TabIndex = 11;
            this.availCheckinL.Text = "Check-in";
            // 
            // availRoomTypeL
            // 
            this.availRoomTypeL.AutoSize = true;
            this.availRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availRoomTypeL.Location = new System.Drawing.Point(183, 125);
            this.availRoomTypeL.Name = "availRoomTypeL";
            this.availRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.availRoomTypeL.TabIndex = 10;
            this.availRoomTypeL.Text = "Room Type";
            // 
            // availRoomTypeCB
            // 
            this.availRoomTypeCB.ForeColor = System.Drawing.Color.Gray;
            this.availRoomTypeCB.FormattingEnabled = true;
            this.availRoomTypeCB.Items.AddRange(new object[] {
            "Single Room",
            "Master Room",
            "Suite Room"});
            this.availRoomTypeCB.Location = new System.Drawing.Point(290, 126);
            this.availRoomTypeCB.Name = "availRoomTypeCB";
            this.availRoomTypeCB.Size = new System.Drawing.Size(190, 21);
            this.availRoomTypeCB.TabIndex = 0;
            this.availRoomTypeCB.Text = "Select Room Type";
            this.availRoomTypeCB.TextChanged += new System.EventHandler(this.availRoomTypeCB_TextChanged);
            // 
            // dateValidityMessageL
            // 
            this.dateValidityMessageL.AutoSize = true;
            this.dateValidityMessageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValidityMessageL.Location = new System.Drawing.Point(499, 201);
            this.dateValidityMessageL.Name = "dateValidityMessageL";
            this.dateValidityMessageL.Size = new System.Drawing.Size(0, 20);
            this.dateValidityMessageL.TabIndex = 16;
            // 
            // availCheckB
            // 
            this.availCheckB.Location = new System.Drawing.Point(333, 238);
            this.availCheckB.Name = "availCheckB";
            this.availCheckB.Size = new System.Drawing.Size(108, 26);
            this.availCheckB.TabIndex = 3;
            this.availCheckB.Text = "Check Availability";
            this.availCheckB.UseVisualStyleBackColor = true;
            this.availCheckB.Click += new System.EventHandler(this.availCheckB_Click);
            // 
            // availabilityL
            // 
            this.availabilityL.AutoSize = true;
            this.availabilityL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.availabilityL.Location = new System.Drawing.Point(23, 56);
            this.availabilityL.Name = "availabilityL";
            this.availabilityL.Size = new System.Drawing.Size(650, 40);
            this.availabilityL.TabIndex = 17;
            this.availabilityL.Text = "Select Options Below to Check Room Availability";
            // 
            // availabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(702, 355);
            this.Controls.Add(this.availabilityL);
            this.Controls.Add(this.availCheckB);
            this.Controls.Add(this.dateValidityMessageL);
            this.Controls.Add(this.availRoomTypeCB);
            this.Controls.Add(this.availCheckoutDTP);
            this.Controls.Add(this.availCheckinDTP);
            this.Controls.Add(this.availCheckoutL);
            this.Controls.Add(this.availCheckinL);
            this.Controls.Add(this.availRoomTypeL);
            this.Name = "availabilityForm";
            this.Text = "Room Availability";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker availCheckoutDTP;
        private System.Windows.Forms.DateTimePicker availCheckinDTP;
        private System.Windows.Forms.Label availCheckoutL;
        private System.Windows.Forms.Label availCheckinL;
        private System.Windows.Forms.Label availRoomTypeL;
        private System.Windows.Forms.ComboBox availRoomTypeCB;
        private System.Windows.Forms.Label dateValidityMessageL;
        private System.Windows.Forms.Button availCheckB;
        private System.Windows.Forms.Label availabilityL;
    }
}