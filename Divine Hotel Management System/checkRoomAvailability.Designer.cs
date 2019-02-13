namespace Divine_Hotel_Management_System
{
    partial class checkRoomAvailability
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
            this.availCheckoutDT = new System.Windows.Forms.DateTimePicker();
            this.availCheckinDT = new System.Windows.Forms.DateTimePicker();
            this.availCheckoutL = new System.Windows.Forms.Label();
            this.availCheckinL = new System.Windows.Forms.Label();
            this.availRoomTypeL = new System.Windows.Forms.Label();
            this.availRoomCB = new System.Windows.Forms.ComboBox();
            this.availabilityMessageL = new System.Windows.Forms.Label();
            this.availCheckB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availCheckoutDT
            // 
            this.availCheckoutDT.Location = new System.Drawing.Point(372, 250);
            this.availCheckoutDT.Name = "availCheckoutDT";
            this.availCheckoutDT.Size = new System.Drawing.Size(179, 20);
            this.availCheckoutDT.TabIndex = 14;
            // 
            // availCheckinDT
            // 
            this.availCheckinDT.Location = new System.Drawing.Point(372, 215);
            this.availCheckinDT.Name = "availCheckinDT";
            this.availCheckinDT.Size = new System.Drawing.Size(179, 20);
            this.availCheckinDT.TabIndex = 9;
            // 
            // availCheckoutL
            // 
            this.availCheckoutL.AutoSize = true;
            this.availCheckoutL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availCheckoutL.Location = new System.Drawing.Point(249, 250);
            this.availCheckoutL.Name = "availCheckoutL";
            this.availCheckoutL.Size = new System.Drawing.Size(127, 21);
            this.availCheckoutL.TabIndex = 12;
            this.availCheckoutL.Text = "Check-out Date";
            // 
            // availCheckinL
            // 
            this.availCheckinL.AutoSize = true;
            this.availCheckinL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availCheckinL.Location = new System.Drawing.Point(260, 215);
            this.availCheckinL.Name = "availCheckinL";
            this.availCheckinL.Size = new System.Drawing.Size(116, 21);
            this.availCheckinL.TabIndex = 11;
            this.availCheckinL.Text = "Check-in Date";
            // 
            // availRoomTypeL
            // 
            this.availRoomTypeL.AutoSize = true;
            this.availRoomTypeL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availRoomTypeL.Location = new System.Drawing.Point(273, 180);
            this.availRoomTypeL.Name = "availRoomTypeL";
            this.availRoomTypeL.Size = new System.Drawing.Size(100, 21);
            this.availRoomTypeL.TabIndex = 10;
            this.availRoomTypeL.Text = "Room Type";
            // 
            // availRoomCB
            // 
            this.availRoomCB.FormattingEnabled = true;
            this.availRoomCB.Location = new System.Drawing.Point(372, 180);
            this.availRoomCB.Name = "availRoomCB";
            this.availRoomCB.Size = new System.Drawing.Size(179, 21);
            this.availRoomCB.TabIndex = 15;
            this.availRoomCB.Text = "Select Room Type";
            // 
            // availabilityMessageL
            // 
            this.availabilityMessageL.AutoSize = true;
            this.availabilityMessageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityMessageL.Location = new System.Drawing.Point(294, 125);
            this.availabilityMessageL.Name = "availabilityMessageL";
            this.availabilityMessageL.Size = new System.Drawing.Size(243, 20);
            this.availabilityMessageL.TabIndex = 16;
            this.availabilityMessageL.Text = "Rooms are Available for Booking!";
            // 
            // availCheckB
            // 
            this.availCheckB.Location = new System.Drawing.Point(372, 294);
            this.availCheckB.Name = "availCheckB";
            this.availCheckB.Size = new System.Drawing.Size(121, 28);
            this.availCheckB.TabIndex = 17;
            this.availCheckB.Text = "Check Availability";
            this.availCheckB.UseVisualStyleBackColor = true;
            // 
            // checkRoomAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.availCheckB);
            this.Controls.Add(this.availabilityMessageL);
            this.Controls.Add(this.availRoomCB);
            this.Controls.Add(this.availCheckoutDT);
            this.Controls.Add(this.availCheckinDT);
            this.Controls.Add(this.availCheckoutL);
            this.Controls.Add(this.availCheckinL);
            this.Controls.Add(this.availRoomTypeL);
            this.Name = "checkRoomAvailability";
            this.Text = "Check Room Availability";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker availCheckoutDT;
        private System.Windows.Forms.DateTimePicker availCheckinDT;
        private System.Windows.Forms.Label availCheckoutL;
        private System.Windows.Forms.Label availCheckinL;
        private System.Windows.Forms.Label availRoomTypeL;
        private System.Windows.Forms.ComboBox availRoomCB;
        private System.Windows.Forms.Label availabilityMessageL;
        private System.Windows.Forms.Button availCheckB;
    }
}