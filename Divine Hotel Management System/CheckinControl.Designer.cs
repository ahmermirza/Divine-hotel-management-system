namespace Divine_Hotel_Management_System
{
    partial class CheckinControl
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
            this.checkinL = new System.Windows.Forms.Label();
            this.checkinRoomNumL = new System.Windows.Forms.Label();
            this.checkinRoomNumCB = new System.Windows.Forms.ComboBox();
            this.checkinB = new System.Windows.Forms.Button();
            this.checkinDTPL = new System.Windows.Forms.Label();
            this.checkinAmountPaidL = new System.Windows.Forms.Label();
            this.checkinAmountPaidTB = new System.Windows.Forms.TextBox();
            this.checkinResNumL = new System.Windows.Forms.Label();
            this.checkinResNumCB = new System.Windows.Forms.ComboBox();
            this.checkinDTP = new System.Windows.Forms.DateTimePicker();
            this.checkinDGV = new System.Windows.Forms.DataGridView();
            this.checkinTotalAmountL = new System.Windows.Forms.Label();
            this.checkinTotalAmountTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkinDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkinL
            // 
            this.checkinL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkinL.AutoSize = true;
            this.checkinL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.checkinL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinL.Location = new System.Drawing.Point(236, 30);
            this.checkinL.Name = "checkinL";
            this.checkinL.Size = new System.Drawing.Size(325, 40);
            this.checkinL.TabIndex = 38;
            this.checkinL.Text = "Checkin Management";
            // 
            // checkinRoomNumL
            // 
            this.checkinRoomNumL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinRoomNumL.AutoSize = true;
            this.checkinRoomNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinRoomNumL.Location = new System.Drawing.Point(54, 444);
            this.checkinRoomNumL.Name = "checkinRoomNumL";
            this.checkinRoomNumL.Size = new System.Drawing.Size(122, 21);
            this.checkinRoomNumL.TabIndex = 37;
            this.checkinRoomNumL.Text = "Room Number";
            // 
            // checkinRoomNumCB
            // 
            this.checkinRoomNumCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinRoomNumCB.FormattingEnabled = true;
            this.checkinRoomNumCB.Location = new System.Drawing.Point(219, 444);
            this.checkinRoomNumCB.Name = "checkinRoomNumCB";
            this.checkinRoomNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkinRoomNumCB.TabIndex = 3;
            this.checkinRoomNumCB.Text = "Select Room Number";
            // 
            // checkinB
            // 
            this.checkinB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkinB.Location = new System.Drawing.Point(568, 480);
            this.checkinB.Name = "checkinB";
            this.checkinB.Size = new System.Drawing.Size(75, 25);
            this.checkinB.TabIndex = 7;
            this.checkinB.Text = "Check-in";
            this.checkinB.UseVisualStyleBackColor = true;
            this.checkinB.Click += new System.EventHandler(this.checkinB_Click);
            // 
            // checkinDTPL
            // 
            this.checkinDTPL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinDTPL.AutoSize = true;
            this.checkinDTPL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinDTPL.Location = new System.Drawing.Point(54, 484);
            this.checkinDTPL.Name = "checkinDTPL";
            this.checkinDTPL.Size = new System.Drawing.Size(77, 21);
            this.checkinDTPL.TabIndex = 33;
            this.checkinDTPL.Text = "Check-in";
            // 
            // checkinAmountPaidL
            // 
            this.checkinAmountPaidL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkinAmountPaidL.AutoSize = true;
            this.checkinAmountPaidL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinAmountPaidL.Location = new System.Drawing.Point(448, 443);
            this.checkinAmountPaidL.Name = "checkinAmountPaidL";
            this.checkinAmountPaidL.Size = new System.Drawing.Size(108, 21);
            this.checkinAmountPaidL.TabIndex = 32;
            this.checkinAmountPaidL.Text = "Amount Paid";
            // 
            // checkinAmountPaidTB
            // 
            this.checkinAmountPaidTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkinAmountPaidTB.BackColor = System.Drawing.Color.LightGreen;
            this.checkinAmountPaidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinAmountPaidTB.Location = new System.Drawing.Point(568, 444);
            this.checkinAmountPaidTB.Name = "checkinAmountPaidTB";
            this.checkinAmountPaidTB.Size = new System.Drawing.Size(170, 21);
            this.checkinAmountPaidTB.TabIndex = 6;
            this.checkinAmountPaidTB.Text = "0";
            this.checkinAmountPaidTB.Enter += new System.EventHandler(this.checkinAmountPaidTB_Enter);
            this.checkinAmountPaidTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkinAmountPaidTB_KeyPress);
            this.checkinAmountPaidTB.Leave += new System.EventHandler(this.checkinAmountPaidTB_Leave);
            // 
            // checkinResNumL
            // 
            this.checkinResNumL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinResNumL.AutoSize = true;
            this.checkinResNumL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinResNumL.Location = new System.Drawing.Point(54, 404);
            this.checkinResNumL.Name = "checkinResNumL";
            this.checkinResNumL.Size = new System.Drawing.Size(163, 21);
            this.checkinResNumL.TabIndex = 22;
            this.checkinResNumL.Text = "Reservation Number";
            // 
            // checkinResNumCB
            // 
            this.checkinResNumCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinResNumCB.FormattingEnabled = true;
            this.checkinResNumCB.Location = new System.Drawing.Point(219, 404);
            this.checkinResNumCB.Name = "checkinResNumCB";
            this.checkinResNumCB.Size = new System.Drawing.Size(190, 21);
            this.checkinResNumCB.TabIndex = 2;
            this.checkinResNumCB.SelectedIndexChanged += new System.EventHandler(this.checkinResNumCB_SelectedIndexChanged);
            // 
            // checkinDTP
            // 
            this.checkinDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkinDTP.Location = new System.Drawing.Point(219, 484);
            this.checkinDTP.Name = "checkinDTP";
            this.checkinDTP.Size = new System.Drawing.Size(190, 20);
            this.checkinDTP.TabIndex = 4;
            // 
            // checkinDGV
            // 
            this.checkinDGV.AllowUserToAddRows = false;
            this.checkinDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkinDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkinDGV.Location = new System.Drawing.Point(58, 163);
            this.checkinDGV.Name = "checkinDGV";
            this.checkinDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkinDGV.Size = new System.Drawing.Size(680, 200);
            this.checkinDGV.TabIndex = 1;
            // 
            // checkinTotalAmountL
            // 
            this.checkinTotalAmountL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkinTotalAmountL.AutoSize = true;
            this.checkinTotalAmountL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinTotalAmountL.Location = new System.Drawing.Point(448, 403);
            this.checkinTotalAmountL.Name = "checkinTotalAmountL";
            this.checkinTotalAmountL.Size = new System.Drawing.Size(112, 21);
            this.checkinTotalAmountL.TabIndex = 46;
            this.checkinTotalAmountL.Text = "Total Amount";
            // 
            // checkinTotalAmountTB
            // 
            this.checkinTotalAmountTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkinTotalAmountTB.BackColor = System.Drawing.Color.PowderBlue;
            this.checkinTotalAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinTotalAmountTB.Location = new System.Drawing.Point(568, 404);
            this.checkinTotalAmountTB.Name = "checkinTotalAmountTB";
            this.checkinTotalAmountTB.ReadOnly = true;
            this.checkinTotalAmountTB.Size = new System.Drawing.Size(170, 21);
            this.checkinTotalAmountTB.TabIndex = 5;
            this.checkinTotalAmountTB.Text = "0";
            // 
            // CheckinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkinTotalAmountL);
            this.Controls.Add(this.checkinTotalAmountTB);
            this.Controls.Add(this.checkinDGV);
            this.Controls.Add(this.checkinL);
            this.Controls.Add(this.checkinRoomNumL);
            this.Controls.Add(this.checkinRoomNumCB);
            this.Controls.Add(this.checkinB);
            this.Controls.Add(this.checkinDTPL);
            this.Controls.Add(this.checkinAmountPaidL);
            this.Controls.Add(this.checkinAmountPaidTB);
            this.Controls.Add(this.checkinResNumL);
            this.Controls.Add(this.checkinResNumCB);
            this.Controls.Add(this.checkinDTP);
            this.Name = "CheckinControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.CheckinControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkinDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkinL;
        private System.Windows.Forms.Label checkinRoomNumL;
        private System.Windows.Forms.ComboBox checkinRoomNumCB;
        private System.Windows.Forms.Button checkinB;
        private System.Windows.Forms.Label checkinDTPL;
        private System.Windows.Forms.Label checkinAmountPaidL;
        private System.Windows.Forms.TextBox checkinAmountPaidTB;
        private System.Windows.Forms.Label checkinResNumL;
        private System.Windows.Forms.ComboBox checkinResNumCB;
        private System.Windows.Forms.DateTimePicker checkinDTP;
        private System.Windows.Forms.DataGridView checkinDGV;
        private System.Windows.Forms.Label checkinTotalAmountL;
        private System.Windows.Forms.TextBox checkinTotalAmountTB;
    }
}
