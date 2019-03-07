namespace Divine_Hotel_Management_System
{
    partial class checkoutForm
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
            this.checkoutRoomNumL = new System.Windows.Forms.Label();
            this.checkoutDTPL = new System.Windows.Forms.Label();
            this.checkoutDTP = new System.Windows.Forms.DateTimePicker();
            this.checkoutB = new System.Windows.Forms.Button();
            this.checkoutRoomNumCB = new System.Windows.Forms.ComboBox();
            this.checkoutL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkoutRoomNumL
            // 
            this.checkoutRoomNumL.AutoSize = true;
            this.checkoutRoomNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutRoomNumL.Location = new System.Drawing.Point(78, 144);
            this.checkoutRoomNumL.Name = "checkoutRoomNumL";
            this.checkoutRoomNumL.Size = new System.Drawing.Size(122, 21);
            this.checkoutRoomNumL.TabIndex = 0;
            this.checkoutRoomNumL.Text = "Room Number";
            // 
            // checkoutDTPL
            // 
            this.checkoutDTPL.AutoSize = true;
            this.checkoutDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDTPL.Location = new System.Drawing.Point(112, 182);
            this.checkoutDTPL.Name = "checkoutDTPL";
            this.checkoutDTPL.Size = new System.Drawing.Size(88, 21);
            this.checkoutDTPL.TabIndex = 2;
            this.checkoutDTPL.Text = "Check-out";
            // 
            // checkoutDTP
            // 
            this.checkoutDTP.Location = new System.Drawing.Point(206, 184);
            this.checkoutDTP.Name = "checkoutDTP";
            this.checkoutDTP.Size = new System.Drawing.Size(190, 20);
            this.checkoutDTP.TabIndex = 1;
            // 
            // checkoutB
            // 
            this.checkoutB.Location = new System.Drawing.Point(264, 222);
            this.checkoutB.Name = "checkoutB";
            this.checkoutB.Size = new System.Drawing.Size(75, 26);
            this.checkoutB.TabIndex = 2;
            this.checkoutB.Text = "Check-out";
            this.checkoutB.UseVisualStyleBackColor = true;
            this.checkoutB.Click += new System.EventHandler(this.checkoutB_Click);
            // 
            // checkoutRoomNumCB
            // 
            this.checkoutRoomNumCB.ForeColor = System.Drawing.Color.Gray;
            this.checkoutRoomNumCB.FormattingEnabled = true;
            this.checkoutRoomNumCB.Location = new System.Drawing.Point(206, 145);
            this.checkoutRoomNumCB.Name = "checkoutRoomNumCB";
            this.checkoutRoomNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkoutRoomNumCB.TabIndex = 0;
            this.checkoutRoomNumCB.Text = "Select Room Number";
            this.checkoutRoomNumCB.TextChanged += new System.EventHandler(this.checkoutRoomNumCB_TextChanged);
            // 
            // checkoutL
            // 
            this.checkoutL.AutoSize = true;
            this.checkoutL.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkoutL.Location = new System.Drawing.Point(53, 81);
            this.checkoutL.Name = "checkoutL";
            this.checkoutL.Size = new System.Drawing.Size(415, 40);
            this.checkoutL.TabIndex = 20;
            this.checkoutL.Text = "Enter Check-out Details Below";
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(528, 343);
            this.Controls.Add(this.checkoutL);
            this.Controls.Add(this.checkoutRoomNumCB);
            this.Controls.Add(this.checkoutB);
            this.Controls.Add(this.checkoutDTP);
            this.Controls.Add(this.checkoutDTPL);
            this.Controls.Add(this.checkoutRoomNumL);
            this.Name = "checkoutForm";
            this.Text = "Check-out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkoutRoomNumL;
        private System.Windows.Forms.Label checkoutDTPL;
        private System.Windows.Forms.DateTimePicker checkoutDTP;
        private System.Windows.Forms.Button checkoutB;
        private System.Windows.Forms.ComboBox checkoutRoomNumCB;
        private System.Windows.Forms.Label checkoutL;
    }
}