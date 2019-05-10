namespace Divine_Hotel_Management_System
{
    partial class GuestControl
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
            this.guestDGV = new System.Windows.Forms.DataGridView();
            this.guestCNICTB = new System.Windows.Forms.TextBox();
            this.guestCNICL = new System.Windows.Forms.Label();
            this.guestDeleteB = new System.Windows.Forms.Button();
            this.guestL = new System.Windows.Forms.Label();
            this.addGuestB = new System.Windows.Forms.Button();
            this.guestPhoneTB = new System.Windows.Forms.TextBox();
            this.guestPhoneL = new System.Windows.Forms.Label();
            this.guestLastNameTB = new System.Windows.Forms.TextBox();
            this.guestLastNameL = new System.Windows.Forms.Label();
            this.guestFirstNameTB = new System.Windows.Forms.TextBox();
            this.guestFirstNameL = new System.Windows.Forms.Label();
            this.guestUpdateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // guestDGV
            // 
            this.guestDGV.AllowUserToAddRows = false;
            this.guestDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDGV.Location = new System.Drawing.Point(58, 163);
            this.guestDGV.Name = "guestDGV";
            this.guestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guestDGV.Size = new System.Drawing.Size(680, 200);
            this.guestDGV.TabIndex = 62;
            this.guestDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.guestDGV_MouseDoubleClick);
            // 
            // guestCNICTB
            // 
            this.guestCNICTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guestCNICTB.Location = new System.Drawing.Point(548, 406);
            this.guestCNICTB.Name = "guestCNICTB";
            this.guestCNICTB.Size = new System.Drawing.Size(190, 20);
            this.guestCNICTB.TabIndex = 4;
            // 
            // guestCNICL
            // 
            this.guestCNICL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guestCNICL.AutoSize = true;
            this.guestCNICL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCNICL.Location = new System.Drawing.Point(423, 404);
            this.guestCNICL.Name = "guestCNICL";
            this.guestCNICL.Size = new System.Drawing.Size(120, 21);
            this.guestCNICL.TabIndex = 60;
            this.guestCNICL.Text = "CNIC Number";
            // 
            // guestDeleteB
            // 
            this.guestDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guestDeleteB.Location = new System.Drawing.Point(582, 439);
            this.guestDeleteB.Name = "guestDeleteB";
            this.guestDeleteB.Size = new System.Drawing.Size(75, 25);
            this.guestDeleteB.TabIndex = 59;
            this.guestDeleteB.Text = "Delete";
            this.guestDeleteB.UseVisualStyleBackColor = true;
            this.guestDeleteB.Click += new System.EventHandler(this.guestDeleteB_Click);
            // 
            // guestL
            // 
            this.guestL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guestL.AutoSize = true;
            this.guestL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guestL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestL.Location = new System.Drawing.Point(253, 30);
            this.guestL.Name = "guestL";
            this.guestL.Size = new System.Drawing.Size(291, 40);
            this.guestL.TabIndex = 58;
            this.guestL.Text = "Guest Management";
            // 
            // addGuestB
            // 
            this.addGuestB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addGuestB.Location = new System.Drawing.Point(476, 439);
            this.addGuestB.Name = "addGuestB";
            this.addGuestB.Size = new System.Drawing.Size(100, 25);
            this.addGuestB.TabIndex = 57;
            this.addGuestB.Text = "Add Guest";
            this.addGuestB.UseVisualStyleBackColor = true;
            this.addGuestB.Click += new System.EventHandler(this.addGuestB_Click);
            // 
            // guestPhoneTB
            // 
            this.guestPhoneTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestPhoneTB.Location = new System.Drawing.Point(179, 484);
            this.guestPhoneTB.Name = "guestPhoneTB";
            this.guestPhoneTB.Size = new System.Drawing.Size(190, 20);
            this.guestPhoneTB.TabIndex = 3;
            // 
            // guestPhoneL
            // 
            this.guestPhoneL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestPhoneL.AutoSize = true;
            this.guestPhoneL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestPhoneL.Location = new System.Drawing.Point(54, 482);
            this.guestPhoneL.Name = "guestPhoneL";
            this.guestPhoneL.Size = new System.Drawing.Size(122, 21);
            this.guestPhoneL.TabIndex = 51;
            this.guestPhoneL.Text = "Phone Number";
            // 
            // guestLastNameTB
            // 
            this.guestLastNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestLastNameTB.Location = new System.Drawing.Point(179, 445);
            this.guestLastNameTB.Name = "guestLastNameTB";
            this.guestLastNameTB.Size = new System.Drawing.Size(190, 20);
            this.guestLastNameTB.TabIndex = 2;
            // 
            // guestLastNameL
            // 
            this.guestLastNameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestLastNameL.AutoSize = true;
            this.guestLastNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLastNameL.Location = new System.Drawing.Point(54, 443);
            this.guestLastNameL.Name = "guestLastNameL";
            this.guestLastNameL.Size = new System.Drawing.Size(90, 21);
            this.guestLastNameL.TabIndex = 49;
            this.guestLastNameL.Text = "Last Name";
            // 
            // guestFirstNameTB
            // 
            this.guestFirstNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestFirstNameTB.Location = new System.Drawing.Point(179, 406);
            this.guestFirstNameTB.Name = "guestFirstNameTB";
            this.guestFirstNameTB.Size = new System.Drawing.Size(190, 20);
            this.guestFirstNameTB.TabIndex = 1;
            // 
            // guestFirstNameL
            // 
            this.guestFirstNameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestFirstNameL.AutoSize = true;
            this.guestFirstNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestFirstNameL.Location = new System.Drawing.Point(54, 404);
            this.guestFirstNameL.Name = "guestFirstNameL";
            this.guestFirstNameL.Size = new System.Drawing.Size(92, 21);
            this.guestFirstNameL.TabIndex = 47;
            this.guestFirstNameL.Text = "First Name";
            // 
            // guestUpdateB
            // 
            this.guestUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guestUpdateB.Location = new System.Drawing.Point(663, 439);
            this.guestUpdateB.Name = "guestUpdateB";
            this.guestUpdateB.Size = new System.Drawing.Size(75, 25);
            this.guestUpdateB.TabIndex = 63;
            this.guestUpdateB.Text = "Update";
            this.guestUpdateB.UseVisualStyleBackColor = true;
            this.guestUpdateB.Click += new System.EventHandler(this.guestUpdateB_Click);
            // 
            // GuestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guestUpdateB);
            this.Controls.Add(this.guestDGV);
            this.Controls.Add(this.guestCNICTB);
            this.Controls.Add(this.guestCNICL);
            this.Controls.Add(this.guestDeleteB);
            this.Controls.Add(this.guestL);
            this.Controls.Add(this.addGuestB);
            this.Controls.Add(this.guestPhoneTB);
            this.Controls.Add(this.guestPhoneL);
            this.Controls.Add(this.guestLastNameTB);
            this.Controls.Add(this.guestLastNameL);
            this.Controls.Add(this.guestFirstNameTB);
            this.Controls.Add(this.guestFirstNameL);
            this.Name = "GuestControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.GuestControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView guestDGV;
        private System.Windows.Forms.TextBox guestCNICTB;
        private System.Windows.Forms.Label guestCNICL;
        private System.Windows.Forms.Button guestDeleteB;
        private System.Windows.Forms.Label guestL;
        private System.Windows.Forms.Button addGuestB;
        private System.Windows.Forms.TextBox guestPhoneTB;
        private System.Windows.Forms.Label guestPhoneL;
        private System.Windows.Forms.TextBox guestLastNameTB;
        private System.Windows.Forms.Label guestLastNameL;
        private System.Windows.Forms.TextBox guestFirstNameTB;
        private System.Windows.Forms.Label guestFirstNameL;
        private System.Windows.Forms.Button guestUpdateB;
    }
}
