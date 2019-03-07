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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainResB = new System.Windows.Forms.Button();
            this.mainCheckinB = new System.Windows.Forms.Button();
            this.mainCheckoutB = new System.Windows.Forms.Button();
            this.mainAddRoomB = new System.Windows.Forms.Button();
            this.mainWelcomeL = new System.Windows.Forms.Label();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.mainAvailCheckB = new System.Windows.Forms.Button();
            this.mainLogoutB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainResB
            // 
            this.mainResB.Location = new System.Drawing.Point(169, 293);
            this.mainResB.Name = "mainResB";
            this.mainResB.Size = new System.Drawing.Size(120, 30);
            this.mainResB.TabIndex = 1;
            this.mainResB.Text = "Make Reservation";
            this.mainResB.UseVisualStyleBackColor = true;
            this.mainResB.Click += new System.EventHandler(this.mainResB_Click);
            // 
            // mainCheckinB
            // 
            this.mainCheckinB.Location = new System.Drawing.Point(169, 337);
            this.mainCheckinB.Name = "mainCheckinB";
            this.mainCheckinB.Size = new System.Drawing.Size(120, 30);
            this.mainCheckinB.TabIndex = 2;
            this.mainCheckinB.Text = "Check-in";
            this.mainCheckinB.UseVisualStyleBackColor = true;
            this.mainCheckinB.Click += new System.EventHandler(this.mainCheckinB_Click);
            // 
            // mainCheckoutB
            // 
            this.mainCheckoutB.Location = new System.Drawing.Point(169, 381);
            this.mainCheckoutB.Name = "mainCheckoutB";
            this.mainCheckoutB.Size = new System.Drawing.Size(120, 30);
            this.mainCheckoutB.TabIndex = 3;
            this.mainCheckoutB.Text = "Check-out";
            this.mainCheckoutB.UseVisualStyleBackColor = true;
            this.mainCheckoutB.Click += new System.EventHandler(this.mainCheckoutB_Click);
            // 
            // mainAddRoomB
            // 
            this.mainAddRoomB.Location = new System.Drawing.Point(169, 425);
            this.mainAddRoomB.Name = "mainAddRoomB";
            this.mainAddRoomB.Size = new System.Drawing.Size(120, 30);
            this.mainAddRoomB.TabIndex = 4;
            this.mainAddRoomB.Text = "Add New Room";
            this.mainAddRoomB.UseVisualStyleBackColor = true;
            this.mainAddRoomB.Click += new System.EventHandler(this.mainAddRoomB_Click);
            // 
            // mainWelcomeL
            // 
            this.mainWelcomeL.AutoSize = true;
            this.mainWelcomeL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWelcomeL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainWelcomeL.Location = new System.Drawing.Point(154, 193);
            this.mainWelcomeL.Name = "mainWelcomeL";
            this.mainWelcomeL.Size = new System.Drawing.Size(723, 40);
            this.mainWelcomeL.TabIndex = 7;
            this.mainWelcomeL.Text = "WELCOME TO DIVINE HOTEL MANAGEMENT SYSTEM";
            // 
            // logoPB
            // 
            this.logoPB.Image = ((System.Drawing.Image)(resources.GetObject("logoPB.Image")));
            this.logoPB.Location = new System.Drawing.Point(122, 28);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(812, 150);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 8;
            this.logoPB.TabStop = false;
            // 
            // mainAvailCheckB
            // 
            this.mainAvailCheckB.Location = new System.Drawing.Point(169, 249);
            this.mainAvailCheckB.Name = "mainAvailCheckB";
            this.mainAvailCheckB.Size = new System.Drawing.Size(120, 30);
            this.mainAvailCheckB.TabIndex = 0;
            this.mainAvailCheckB.Text = "Check Availability";
            this.mainAvailCheckB.UseVisualStyleBackColor = true;
            this.mainAvailCheckB.Click += new System.EventHandler(this.mainAvailCheckB_Click);
            // 
            // mainLogoutB
            // 
            this.mainLogoutB.Location = new System.Drawing.Point(808, 249);
            this.mainLogoutB.Name = "mainLogoutB";
            this.mainLogoutB.Size = new System.Drawing.Size(69, 30);
            this.mainLogoutB.TabIndex = 9;
            this.mainLogoutB.Text = "Log out";
            this.mainLogoutB.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1070, 606);
            this.Controls.Add(this.mainLogoutB);
            this.Controls.Add(this.mainAvailCheckB);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.mainWelcomeL);
            this.Controls.Add(this.mainAddRoomB);
            this.Controls.Add(this.mainCheckoutB);
            this.Controls.Add(this.mainCheckinB);
            this.Controls.Add(this.mainResB);
            this.Name = "mainForm";
            this.Text = "Divine Hotel Management System (DHMS)";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Label mainWelcomeL;
        private System.Windows.Forms.Button mainAvailCheckB;
        private System.Windows.Forms.Button mainResB;
        private System.Windows.Forms.Button mainCheckinB;
        private System.Windows.Forms.Button mainCheckoutB;
        private System.Windows.Forms.Button mainAddRoomB;
        private System.Windows.Forms.Button mainLogoutB;
    }
}