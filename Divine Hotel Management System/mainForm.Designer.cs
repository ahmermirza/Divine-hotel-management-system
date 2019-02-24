namespace Divine_Hotel_Management_System
{
    partial class mainForm
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
            this.makeReservationB = new System.Windows.Forms.Button();
            this.checkAvailabilityB = new System.Windows.Forms.Button();
            this.checkinB = new System.Windows.Forms.Button();
            this.checkoutB = new System.Windows.Forms.Button();
            this.addRoomB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeReservationB
            // 
            this.makeReservationB.Location = new System.Drawing.Point(86, 128);
            this.makeReservationB.Name = "makeReservationB";
            this.makeReservationB.Size = new System.Drawing.Size(117, 28);
            this.makeReservationB.TabIndex = 0;
            this.makeReservationB.Text = "Make Reservation";
            this.makeReservationB.UseVisualStyleBackColor = true;
            this.makeReservationB.Click += new System.EventHandler(this.reservationB_Click);
            // 
            // checkAvailabilityB
            // 
            this.checkAvailabilityB.Location = new System.Drawing.Point(86, 83);
            this.checkAvailabilityB.Name = "checkAvailabilityB";
            this.checkAvailabilityB.Size = new System.Drawing.Size(117, 28);
            this.checkAvailabilityB.TabIndex = 1;
            this.checkAvailabilityB.Text = "Check Availability";
            this.checkAvailabilityB.UseVisualStyleBackColor = true;
            this.checkAvailabilityB.Click += new System.EventHandler(this.checkAvailabilityB_Click);
            // 
            // checkinB
            // 
            this.checkinB.Location = new System.Drawing.Point(86, 173);
            this.checkinB.Name = "checkinB";
            this.checkinB.Size = new System.Drawing.Size(117, 28);
            this.checkinB.TabIndex = 2;
            this.checkinB.Text = "Check-in";
            this.checkinB.UseVisualStyleBackColor = true;
            this.checkinB.Click += new System.EventHandler(this.checkinB_Click);
            // 
            // checkoutB
            // 
            this.checkoutB.Location = new System.Drawing.Point(86, 218);
            this.checkoutB.Name = "checkoutB";
            this.checkoutB.Size = new System.Drawing.Size(117, 28);
            this.checkoutB.TabIndex = 3;
            this.checkoutB.Text = "Check-out";
            this.checkoutB.UseVisualStyleBackColor = true;
            this.checkoutB.Click += new System.EventHandler(this.checkoutB_Click);
            // 
            // addRoomB
            // 
            this.addRoomB.Location = new System.Drawing.Point(86, 264);
            this.addRoomB.Name = "addRoomB";
            this.addRoomB.Size = new System.Drawing.Size(117, 28);
            this.addRoomB.TabIndex = 6;
            this.addRoomB.Text = "Add New Room";
            this.addRoomB.UseVisualStyleBackColor = true;
            this.addRoomB.Click += new System.EventHandler(this.addRoomB_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRoomB);
            this.Controls.Add(this.checkoutB);
            this.Controls.Add(this.checkinB);
            this.Controls.Add(this.checkAvailabilityB);
            this.Controls.Add(this.makeReservationB);
            this.Name = "mainForm";
            this.Text = "Divine Hotel Management System (DHMS)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeReservationB;
        private System.Windows.Forms.Button checkAvailabilityB;
        private System.Windows.Forms.Button checkinB;
        private System.Windows.Forms.Button checkoutB;
        private System.Windows.Forms.Button addRoomB;
    }
}