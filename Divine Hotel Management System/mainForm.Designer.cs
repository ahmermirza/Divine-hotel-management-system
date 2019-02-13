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
            this.reservationB = new System.Windows.Forms.Button();
            this.checkAvailabilityB = new System.Windows.Forms.Button();
            this.checkinB = new System.Windows.Forms.Button();
            this.checkoutB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservationB
            // 
            this.reservationB.Location = new System.Drawing.Point(86, 127);
            this.reservationB.Name = "reservationB";
            this.reservationB.Size = new System.Drawing.Size(117, 28);
            this.reservationB.TabIndex = 0;
            this.reservationB.Text = "Make Reservation";
            this.reservationB.UseVisualStyleBackColor = true;
            this.reservationB.Click += new System.EventHandler(this.reservationB_Click);
            // 
            // checkAvailabilityB
            // 
            this.checkAvailabilityB.Location = new System.Drawing.Point(86, 83);
            this.checkAvailabilityB.Name = "checkAvailabilityB";
            this.checkAvailabilityB.Size = new System.Drawing.Size(117, 28);
            this.checkAvailabilityB.TabIndex = 1;
            this.checkAvailabilityB.Text = "Check Availability";
            this.checkAvailabilityB.UseVisualStyleBackColor = true;
            // 
            // checkinB
            // 
            this.checkinB.Location = new System.Drawing.Point(86, 171);
            this.checkinB.Name = "checkinB";
            this.checkinB.Size = new System.Drawing.Size(117, 28);
            this.checkinB.TabIndex = 2;
            this.checkinB.Text = "Check-in";
            this.checkinB.UseVisualStyleBackColor = true;
            this.checkinB.Click += new System.EventHandler(this.checkinB_Click);
            // 
            // checkoutB
            // 
            this.checkoutB.Location = new System.Drawing.Point(86, 215);
            this.checkoutB.Name = "checkoutB";
            this.checkoutB.Size = new System.Drawing.Size(117, 28);
            this.checkoutB.TabIndex = 3;
            this.checkoutB.Text = "Check-out";
            this.checkoutB.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutB);
            this.Controls.Add(this.checkinB);
            this.Controls.Add(this.checkAvailabilityB);
            this.Controls.Add(this.reservationB);
            this.Name = "mainForm";
            this.Text = "Divine Hotel Management System (DHMS)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservationB;
        private System.Windows.Forms.Button checkAvailabilityB;
        private System.Windows.Forms.Button checkinB;
        private System.Windows.Forms.Button checkoutB;
    }
}