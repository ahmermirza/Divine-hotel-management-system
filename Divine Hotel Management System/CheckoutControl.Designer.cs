namespace Divine_Hotel_Management_System
{
    partial class CheckoutControl
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
            this.checkoutAmountPaidL = new System.Windows.Forms.Label();
            this.checkoutAmountPaidTB = new System.Windows.Forms.TextBox();
            this.checkoutCheckinNumL = new System.Windows.Forms.Label();
            this.checkoutL = new System.Windows.Forms.Label();
            this.checkoutRoomNumCB = new System.Windows.Forms.ComboBox();
            this.checkoutB = new System.Windows.Forms.Button();
            this.checkoutDTP = new System.Windows.Forms.DateTimePicker();
            this.checkoutDTPL = new System.Windows.Forms.Label();
            this.checkoutRoomNumL = new System.Windows.Forms.Label();
            this.checkoutDGV = new System.Windows.Forms.DataGridView();
            this.checkoutCheckinNumTB = new System.Windows.Forms.TextBox();
            this.checkoutTotalAmountL = new System.Windows.Forms.Label();
            this.checkoutTotalAmountTB = new System.Windows.Forms.TextBox();
            this.checkoutRemainingL = new System.Windows.Forms.Label();
            this.checkoutRemainingTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutAmountPaidL
            // 
            this.checkoutAmountPaidL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutAmountPaidL.AutoSize = true;
            this.checkoutAmountPaidL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutAmountPaidL.Location = new System.Drawing.Point(449, 443);
            this.checkoutAmountPaidL.Name = "checkoutAmountPaidL";
            this.checkoutAmountPaidL.Size = new System.Drawing.Size(108, 21);
            this.checkoutAmountPaidL.TabIndex = 44;
            this.checkoutAmountPaidL.Text = "Amount Paid";
            // 
            // checkoutAmountPaidTB
            // 
            this.checkoutAmountPaidTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutAmountPaidTB.BackColor = System.Drawing.Color.LightGreen;
            this.checkoutAmountPaidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutAmountPaidTB.Location = new System.Drawing.Point(568, 444);
            this.checkoutAmountPaidTB.Name = "checkoutAmountPaidTB";
            this.checkoutAmountPaidTB.ReadOnly = true;
            this.checkoutAmountPaidTB.Size = new System.Drawing.Size(170, 21);
            this.checkoutAmountPaidTB.TabIndex = 6;
            this.checkoutAmountPaidTB.Text = "0";
            // 
            // checkoutCheckinNumL
            // 
            this.checkoutCheckinNumL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutCheckinNumL.AutoSize = true;
            this.checkoutCheckinNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutCheckinNumL.Location = new System.Drawing.Point(54, 443);
            this.checkoutCheckinNumL.Name = "checkoutCheckinNumL";
            this.checkoutCheckinNumL.Size = new System.Drawing.Size(136, 21);
            this.checkoutCheckinNumL.TabIndex = 42;
            this.checkoutCheckinNumL.Text = "Checkin Number";
            // 
            // checkoutL
            // 
            this.checkoutL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkoutL.AutoSize = true;
            this.checkoutL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.checkoutL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutL.Location = new System.Drawing.Point(227, 30);
            this.checkoutL.Name = "checkoutL";
            this.checkoutL.Size = new System.Drawing.Size(343, 40);
            this.checkoutL.TabIndex = 40;
            this.checkoutL.Text = "Checkout Management";
            // 
            // checkoutRoomNumCB
            // 
            this.checkoutRoomNumCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutRoomNumCB.FormattingEnabled = true;
            this.checkoutRoomNumCB.Location = new System.Drawing.Point(196, 405);
            this.checkoutRoomNumCB.Name = "checkoutRoomNumCB";
            this.checkoutRoomNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkoutRoomNumCB.TabIndex = 2;
            this.checkoutRoomNumCB.Text = "Select Room Number";
            this.checkoutRoomNumCB.SelectedIndexChanged += new System.EventHandler(this.checkoutRoomNumCB_SelectedIndexChanged);
            // 
            // checkoutB
            // 
            this.checkoutB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutB.Location = new System.Drawing.Point(568, 526);
            this.checkoutB.Name = "checkoutB";
            this.checkoutB.Size = new System.Drawing.Size(75, 25);
            this.checkoutB.TabIndex = 8;
            this.checkoutB.Text = "Check-out";
            this.checkoutB.UseVisualStyleBackColor = true;
            this.checkoutB.Click += new System.EventHandler(this.checkoutB_Click);
            // 
            // checkoutDTP
            // 
            this.checkoutDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutDTP.Location = new System.Drawing.Point(196, 487);
            this.checkoutDTP.Name = "checkoutDTP";
            this.checkoutDTP.Size = new System.Drawing.Size(190, 20);
            this.checkoutDTP.TabIndex = 4;
            // 
            // checkoutDTPL
            // 
            this.checkoutDTPL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutDTPL.AutoSize = true;
            this.checkoutDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDTPL.Location = new System.Drawing.Point(54, 483);
            this.checkoutDTPL.Name = "checkoutDTPL";
            this.checkoutDTPL.Size = new System.Drawing.Size(88, 21);
            this.checkoutDTPL.TabIndex = 39;
            this.checkoutDTPL.Text = "Check-out";
            // 
            // checkoutRoomNumL
            // 
            this.checkoutRoomNumL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutRoomNumL.AutoSize = true;
            this.checkoutRoomNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutRoomNumL.Location = new System.Drawing.Point(54, 403);
            this.checkoutRoomNumL.Name = "checkoutRoomNumL";
            this.checkoutRoomNumL.Size = new System.Drawing.Size(122, 21);
            this.checkoutRoomNumL.TabIndex = 36;
            this.checkoutRoomNumL.Text = "Room Number";
            // 
            // checkoutDGV
            // 
            this.checkoutDGV.AllowUserToAddRows = false;
            this.checkoutDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutDGV.Location = new System.Drawing.Point(58, 163);
            this.checkoutDGV.Name = "checkoutDGV";
            this.checkoutDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkoutDGV.Size = new System.Drawing.Size(680, 200);
            this.checkoutDGV.TabIndex = 1;
            // 
            // checkoutCheckinNumTB
            // 
            this.checkoutCheckinNumTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkoutCheckinNumTB.BackColor = System.Drawing.Color.White;
            this.checkoutCheckinNumTB.Location = new System.Drawing.Point(196, 445);
            this.checkoutCheckinNumTB.Name = "checkoutCheckinNumTB";
            this.checkoutCheckinNumTB.ReadOnly = true;
            this.checkoutCheckinNumTB.Size = new System.Drawing.Size(190, 20);
            this.checkoutCheckinNumTB.TabIndex = 3;
            // 
            // checkoutTotalAmountL
            // 
            this.checkoutTotalAmountL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutTotalAmountL.AutoSize = true;
            this.checkoutTotalAmountL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutTotalAmountL.Location = new System.Drawing.Point(449, 402);
            this.checkoutTotalAmountL.Name = "checkoutTotalAmountL";
            this.checkoutTotalAmountL.Size = new System.Drawing.Size(112, 21);
            this.checkoutTotalAmountL.TabIndex = 48;
            this.checkoutTotalAmountL.Text = "Total Amount";
            // 
            // checkoutTotalAmountTB
            // 
            this.checkoutTotalAmountTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutTotalAmountTB.BackColor = System.Drawing.Color.PowderBlue;
            this.checkoutTotalAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutTotalAmountTB.Location = new System.Drawing.Point(568, 404);
            this.checkoutTotalAmountTB.Name = "checkoutTotalAmountTB";
            this.checkoutTotalAmountTB.ReadOnly = true;
            this.checkoutTotalAmountTB.Size = new System.Drawing.Size(170, 21);
            this.checkoutTotalAmountTB.TabIndex = 5;
            this.checkoutTotalAmountTB.Text = "0";
            // 
            // checkoutRemainingL
            // 
            this.checkoutRemainingL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutRemainingL.AutoSize = true;
            this.checkoutRemainingL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutRemainingL.Location = new System.Drawing.Point(449, 484);
            this.checkoutRemainingL.Name = "checkoutRemainingL";
            this.checkoutRemainingL.Size = new System.Drawing.Size(88, 21);
            this.checkoutRemainingL.TabIndex = 50;
            this.checkoutRemainingL.Text = "Remaining";
            // 
            // checkoutRemainingTB
            // 
            this.checkoutRemainingTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkoutRemainingTB.BackColor = System.Drawing.Color.Bisque;
            this.checkoutRemainingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutRemainingTB.Location = new System.Drawing.Point(568, 485);
            this.checkoutRemainingTB.Name = "checkoutRemainingTB";
            this.checkoutRemainingTB.ReadOnly = true;
            this.checkoutRemainingTB.Size = new System.Drawing.Size(170, 21);
            this.checkoutRemainingTB.TabIndex = 7;
            this.checkoutRemainingTB.Text = "0";
            // 
            // CheckoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkoutRemainingL);
            this.Controls.Add(this.checkoutRemainingTB);
            this.Controls.Add(this.checkoutTotalAmountL);
            this.Controls.Add(this.checkoutTotalAmountTB);
            this.Controls.Add(this.checkoutCheckinNumTB);
            this.Controls.Add(this.checkoutDGV);
            this.Controls.Add(this.checkoutAmountPaidL);
            this.Controls.Add(this.checkoutAmountPaidTB);
            this.Controls.Add(this.checkoutCheckinNumL);
            this.Controls.Add(this.checkoutL);
            this.Controls.Add(this.checkoutRoomNumCB);
            this.Controls.Add(this.checkoutB);
            this.Controls.Add(this.checkoutDTP);
            this.Controls.Add(this.checkoutDTPL);
            this.Controls.Add(this.checkoutRoomNumL);
            this.Name = "CheckoutControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.CheckoutControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkoutAmountPaidL;
        private System.Windows.Forms.TextBox checkoutAmountPaidTB;
        private System.Windows.Forms.Label checkoutCheckinNumL;
        private System.Windows.Forms.Label checkoutL;
        private System.Windows.Forms.ComboBox checkoutRoomNumCB;
        private System.Windows.Forms.Button checkoutB;
        private System.Windows.Forms.DateTimePicker checkoutDTP;
        private System.Windows.Forms.Label checkoutDTPL;
        private System.Windows.Forms.Label checkoutRoomNumL;
        private System.Windows.Forms.DataGridView checkoutDGV;
        private System.Windows.Forms.TextBox checkoutCheckinNumTB;
        private System.Windows.Forms.Label checkoutTotalAmountL;
        private System.Windows.Forms.TextBox checkoutTotalAmountTB;
        private System.Windows.Forms.Label checkoutRemainingL;
        private System.Windows.Forms.TextBox checkoutRemainingTB;
    }
}
