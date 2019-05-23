namespace Divine_Hotel_Management_System
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginB = new System.Windows.Forms.Button();
            this.loginPasswordTB = new System.Windows.Forms.TextBox();
            this.loginNameTB = new System.Windows.Forms.TextBox();
            this.loginPasswordL = new System.Windows.Forms.Label();
            this.loginNameL = new System.Windows.Forms.Label();
            this.loginL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginB
            // 
            this.loginB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginB.BackColor = System.Drawing.SystemColors.Control;
            this.loginB.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.loginB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.loginB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginB.Location = new System.Drawing.Point(213, 158);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 26);
            this.loginB.TabIndex = 9;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginPasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.loginPasswordTB.Location = new System.Drawing.Point(173, 125);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.PasswordChar = '*';
            this.loginPasswordTB.Size = new System.Drawing.Size(155, 20);
            this.loginPasswordTB.TabIndex = 7;
            this.loginPasswordTB.Text = "Enter password";
            this.loginPasswordTB.Enter += new System.EventHandler(this.loginPasswordTB_Enter);
            this.loginPasswordTB.Leave += new System.EventHandler(this.loginPasswordTB_Leave_1);
            // 
            // loginNameTB
            // 
            this.loginNameTB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginNameTB.ForeColor = System.Drawing.Color.Gray;
            this.loginNameTB.Location = new System.Drawing.Point(173, 92);
            this.loginNameTB.Name = "loginNameTB";
            this.loginNameTB.Size = new System.Drawing.Size(155, 20);
            this.loginNameTB.TabIndex = 6;
            this.loginNameTB.Text = "Enter username here";
            this.loginNameTB.Enter += new System.EventHandler(this.loginNameTB_Enter);
            this.loginNameTB.Leave += new System.EventHandler(this.loginNameTB_Leave_1);
            // 
            // loginPasswordL
            // 
            this.loginPasswordL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginPasswordL.AutoSize = true;
            this.loginPasswordL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordL.ForeColor = System.Drawing.SystemColors.Control;
            this.loginPasswordL.Location = new System.Drawing.Point(71, 122);
            this.loginPasswordL.Name = "loginPasswordL";
            this.loginPasswordL.Size = new System.Drawing.Size(92, 24);
            this.loginPasswordL.TabIndex = 10;
            this.loginPasswordL.Text = "Password";
            // 
            // loginNameL
            // 
            this.loginNameL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginNameL.AutoSize = true;
            this.loginNameL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameL.ForeColor = System.Drawing.SystemColors.Control;
            this.loginNameL.Location = new System.Drawing.Point(71, 90);
            this.loginNameL.Name = "loginNameL";
            this.loginNameL.Size = new System.Drawing.Size(97, 24);
            this.loginNameL.TabIndex = 8;
            this.loginNameL.Text = "Username";
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginL.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginL.ForeColor = System.Drawing.SystemColors.Control;
            this.loginL.Image = ((System.Drawing.Image)(resources.GetObject("loginL.Image")));
            this.loginL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginL.Location = new System.Drawing.Point(23, 15);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(123, 42);
            this.loginL.TabIndex = 11;
            this.loginL.Text = "   login";
            this.loginL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.loginPasswordL);
            this.panel1.Controls.Add(this.loginB);
            this.panel1.Controls.Add(this.loginL);
            this.panel1.Controls.Add(this.loginPasswordTB);
            this.panel1.Controls.Add(this.loginNameL);
            this.panel1.Controls.Add(this.loginNameTB);
            this.panel1.Location = new System.Drawing.Point(233, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 208);
            this.panel1.TabIndex = 12;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.panel1);
            this.Name = "loginForm";
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.TextBox loginPasswordTB;
        private System.Windows.Forms.TextBox loginNameTB;
        private System.Windows.Forms.Label loginPasswordL;
        private System.Windows.Forms.Label loginNameL;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Panel panel1;
    }
}

