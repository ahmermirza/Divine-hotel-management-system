namespace Divine_Hotel_Management_System
{
    partial class AmenityControl
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
            this.amenityDGV = new System.Windows.Forms.DataGridView();
            this.amenityPriceTB = new System.Windows.Forms.TextBox();
            this.amenityPriceL = new System.Windows.Forms.Label();
            this.amenityNameL = new System.Windows.Forms.Label();
            this.amenityL = new System.Windows.Forms.Label();
            this.addAmenityB = new System.Windows.Forms.Button();
            this.reservationB = new System.Windows.Forms.Button();
            this.amenityDeleteB = new System.Windows.Forms.Button();
            this.amenityUpdateB = new System.Windows.Forms.Button();
            this.amenityNameTB = new System.Windows.Forms.TextBox();
            this.amenityDescriptionTB = new System.Windows.Forms.TextBox();
            this.amenityDescriptionL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amenityDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // amenityDGV
            // 
            this.amenityDGV.AllowUserToAddRows = false;
            this.amenityDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amenityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amenityDGV.Location = new System.Drawing.Point(58, 163);
            this.amenityDGV.Name = "amenityDGV";
            this.amenityDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.amenityDGV.Size = new System.Drawing.Size(680, 200);
            this.amenityDGV.TabIndex = 11;
            this.amenityDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.amenityDGV_MouseDoubleClick);
            // 
            // amenityPriceTB
            // 
            this.amenityPriceTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amenityPriceTB.Location = new System.Drawing.Point(548, 402);
            this.amenityPriceTB.Name = "amenityPriceTB";
            this.amenityPriceTB.Size = new System.Drawing.Size(190, 20);
            this.amenityPriceTB.TabIndex = 14;
            // 
            // amenityPriceL
            // 
            this.amenityPriceL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amenityPriceL.AutoSize = true;
            this.amenityPriceL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenityPriceL.Location = new System.Drawing.Point(486, 401);
            this.amenityPriceL.Name = "amenityPriceL";
            this.amenityPriceL.Size = new System.Drawing.Size(48, 21);
            this.amenityPriceL.TabIndex = 56;
            this.amenityPriceL.Text = "Price";
            // 
            // amenityNameL
            // 
            this.amenityNameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amenityNameL.AutoSize = true;
            this.amenityNameL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenityNameL.Location = new System.Drawing.Point(54, 402);
            this.amenityNameL.Name = "amenityNameL";
            this.amenityNameL.Size = new System.Drawing.Size(53, 21);
            this.amenityNameL.TabIndex = 55;
            this.amenityNameL.Text = "Name";
            // 
            // amenityL
            // 
            this.amenityL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amenityL.AutoSize = true;
            this.amenityL.BackColor = System.Drawing.Color.MediumTurquoise;
            this.amenityL.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenityL.Location = new System.Drawing.Point(234, 30);
            this.amenityL.Name = "amenityL";
            this.amenityL.Size = new System.Drawing.Size(329, 40);
            this.amenityL.TabIndex = 53;
            this.amenityL.Text = "Amenity Management";
            // 
            // addAmenityB
            // 
            this.addAmenityB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addAmenityB.Location = new System.Drawing.Point(496, 440);
            this.addAmenityB.Name = "addAmenityB";
            this.addAmenityB.Size = new System.Drawing.Size(90, 25);
            this.addAmenityB.TabIndex = 15;
            this.addAmenityB.Text = "Add Amenity";
            this.addAmenityB.UseVisualStyleBackColor = true;
            this.addAmenityB.Click += new System.EventHandler(this.addAmenityB_Click);
            // 
            // reservationB
            // 
            this.reservationB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reservationB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationB.Location = new System.Drawing.Point(605, 30);
            this.reservationB.Name = "reservationB";
            this.reservationB.Size = new System.Drawing.Size(133, 33);
            this.reservationB.TabIndex = 10;
            this.reservationB.Text = "Go to Reservation";
            this.reservationB.UseVisualStyleBackColor = false;
            this.reservationB.Click += new System.EventHandler(this.reservationB_Click);
            // 
            // amenityDeleteB
            // 
            this.amenityDeleteB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amenityDeleteB.Location = new System.Drawing.Point(592, 440);
            this.amenityDeleteB.Name = "amenityDeleteB";
            this.amenityDeleteB.Size = new System.Drawing.Size(70, 25);
            this.amenityDeleteB.TabIndex = 16;
            this.amenityDeleteB.Text = "Delete";
            this.amenityDeleteB.UseVisualStyleBackColor = true;
            this.amenityDeleteB.Click += new System.EventHandler(this.amenityDeleteB_Click);
            // 
            // amenityUpdateB
            // 
            this.amenityUpdateB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amenityUpdateB.Location = new System.Drawing.Point(668, 440);
            this.amenityUpdateB.Name = "amenityUpdateB";
            this.amenityUpdateB.Size = new System.Drawing.Size(70, 25);
            this.amenityUpdateB.TabIndex = 17;
            this.amenityUpdateB.Text = "Update";
            this.amenityUpdateB.UseVisualStyleBackColor = true;
            this.amenityUpdateB.Click += new System.EventHandler(this.amenityUpdateB_Click);
            // 
            // amenityNameTB
            // 
            this.amenityNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amenityNameTB.Location = new System.Drawing.Point(158, 403);
            this.amenityNameTB.Name = "amenityNameTB";
            this.amenityNameTB.Size = new System.Drawing.Size(190, 20);
            this.amenityNameTB.TabIndex = 12;
            // 
            // amenityDescriptionTB
            // 
            this.amenityDescriptionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amenityDescriptionTB.Location = new System.Drawing.Point(158, 445);
            this.amenityDescriptionTB.Name = "amenityDescriptionTB";
            this.amenityDescriptionTB.Size = new System.Drawing.Size(190, 20);
            this.amenityDescriptionTB.TabIndex = 13;
            // 
            // amenityDescriptionL
            // 
            this.amenityDescriptionL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amenityDescriptionL.AutoSize = true;
            this.amenityDescriptionL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenityDescriptionL.Location = new System.Drawing.Point(54, 444);
            this.amenityDescriptionL.Name = "amenityDescriptionL";
            this.amenityDescriptionL.Size = new System.Drawing.Size(96, 21);
            this.amenityDescriptionL.TabIndex = 67;
            this.amenityDescriptionL.Text = "Description";
            // 
            // AmenityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amenityDescriptionTB);
            this.Controls.Add(this.amenityDescriptionL);
            this.Controls.Add(this.amenityNameTB);
            this.Controls.Add(this.amenityUpdateB);
            this.Controls.Add(this.amenityDeleteB);
            this.Controls.Add(this.reservationB);
            this.Controls.Add(this.amenityDGV);
            this.Controls.Add(this.amenityPriceTB);
            this.Controls.Add(this.amenityPriceL);
            this.Controls.Add(this.amenityNameL);
            this.Controls.Add(this.amenityL);
            this.Controls.Add(this.addAmenityB);
            this.Name = "AmenityControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.AmenityControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amenityDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView amenityDGV;
        private System.Windows.Forms.TextBox amenityPriceTB;
        private System.Windows.Forms.Label amenityPriceL;
        private System.Windows.Forms.Label amenityNameL;
        private System.Windows.Forms.Label amenityL;
        private System.Windows.Forms.Button addAmenityB;
        private System.Windows.Forms.Button reservationB;
        private System.Windows.Forms.Button amenityDeleteB;
        private System.Windows.Forms.Button amenityUpdateB;
        private System.Windows.Forms.TextBox amenityNameTB;
        private System.Windows.Forms.TextBox amenityDescriptionTB;
        private System.Windows.Forms.Label amenityDescriptionL;
    }
}
