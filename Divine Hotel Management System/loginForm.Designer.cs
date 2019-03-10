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
            this.loginNameL = new System.Windows.Forms.Label();
            this.loginPasswordL = new System.Windows.Forms.Label();
            this.loginNameTB = new System.Windows.Forms.TextBox();
            this.loginPasswordTB = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginNameL
            // 
            this.loginNameL.AutoSize = true;
            this.loginNameL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameL.Location = new System.Drawing.Point(300, 319);
            this.loginNameL.Name = "loginNameL";
            this.loginNameL.Size = new System.Drawing.Size(84, 21);
            this.loginNameL.TabIndex = 1;
            this.loginNameL.Text = "Username";
            // 
            // loginPasswordL
            // 
            this.loginPasswordL.AutoSize = true;
            this.loginPasswordL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginPasswordL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordL.Location = new System.Drawing.Point(300, 351);
            this.loginPasswordL.Name = "loginPasswordL";
            this.loginPasswordL.Size = new System.Drawing.Size(84, 21);
            this.loginPasswordL.TabIndex = 2;
            this.loginPasswordL.Text = "Password";
            // 
            // loginNameTB
            // 
            this.loginNameTB.ForeColor = System.Drawing.Color.Gray;
            this.loginNameTB.Location = new System.Drawing.Point(389, 320);
            this.loginNameTB.Name = "loginNameTB";
            this.loginNameTB.Size = new System.Drawing.Size(155, 20);
            this.loginNameTB.TabIndex = 0;
            this.loginNameTB.Text = "Enter username here";
            this.loginNameTB.Enter += new System.EventHandler(this.loginNameTB_Enter);
            this.loginNameTB.Leave += new System.EventHandler(this.loginNameTB_Leave);
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.loginPasswordTB.Location = new System.Drawing.Point(389, 353);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.PasswordChar = '*';
            this.loginPasswordTB.Size = new System.Drawing.Size(155, 20);
            this.loginPasswordTB.TabIndex = 1;
            this.loginPasswordTB.Text = "Enter password";
            this.loginPasswordTB.Enter += new System.EventHandler(this.loginPasswordTB_Enter);
            this.loginPasswordTB.Leave += new System.EventHandler(this.loginPasswordTB_Leave);
            // 
            // loginB
            // 
            this.loginB.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.loginB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.loginB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.loginB.Location = new System.Drawing.Point(427, 386);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 26);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(229, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 208);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(242, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "   login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.loginPasswordTB);
            this.Controls.Add(this.loginNameTB);
            this.Controls.Add(this.loginPasswordL);
            this.Controls.Add(this.loginNameL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginNameL;
        private System.Windows.Forms.Label loginPasswordL;
        private System.Windows.Forms.TextBox loginNameTB;
        private System.Windows.Forms.TextBox loginPasswordTB;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

