namespace Divine_Hotel_Management_System
{
    partial class roomsInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.roomsDGV = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dHMSdatabaseDataSet = new Divine_Hotel_Management_System.DHMSdatabaseDataSet();
            this.roomTableTableAdapter = new Divine_Hotel_Management_System.DHMSdatabaseDataSetTableAdapters.roomTableTableAdapter();
            this.tableAdapterManager = new Divine_Hotel_Management_System.DHMSdatabaseDataSetTableAdapters.TableAdapterManager();
            this.addNewRoomB = new System.Windows.Forms.Button();
            this.roomsInfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMSdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsDGV
            // 
            this.roomsDGV.AllowUserToAddRows = false;
            this.roomsDGV.AutoGenerateColumns = false;
            this.roomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.floorNumberDataGridViewTextBoxColumn,
            this.roomChargesDataGridViewTextBoxColumn,
            this.reservationStatusDataGridViewCheckBoxColumn});
            this.roomsDGV.DataSource = this.roomTableBindingSource;
            this.roomsDGV.Location = new System.Drawing.Point(70, 175);
            this.roomsDGV.Name = "roomsDGV";
            this.roomsDGV.Size = new System.Drawing.Size(560, 200);
            this.roomsDGV.TabIndex = 0;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // floorNumberDataGridViewTextBoxColumn
            // 
            this.floorNumberDataGridViewTextBoxColumn.DataPropertyName = "Floor Number";
            this.floorNumberDataGridViewTextBoxColumn.HeaderText = "Floor Number";
            this.floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
            // 
            // roomChargesDataGridViewTextBoxColumn
            // 
            this.roomChargesDataGridViewTextBoxColumn.DataPropertyName = "Room Charges";
            this.roomChargesDataGridViewTextBoxColumn.HeaderText = "Room Charges";
            this.roomChargesDataGridViewTextBoxColumn.Name = "roomChargesDataGridViewTextBoxColumn";
            // 
            // reservationStatusDataGridViewCheckBoxColumn
            // 
            this.reservationStatusDataGridViewCheckBoxColumn.DataPropertyName = "Reservation Status";
            this.reservationStatusDataGridViewCheckBoxColumn.HeaderText = "Reservation Status";
            this.reservationStatusDataGridViewCheckBoxColumn.Name = "reservationStatusDataGridViewCheckBoxColumn";
            // 
            // roomTableBindingSource
            // 
            this.roomTableBindingSource.DataMember = "roomTable";
            this.roomTableBindingSource.DataSource = this.dHMSdatabaseDataSet;
            // 
            // dHMSdatabaseDataSet
            // 
            this.dHMSdatabaseDataSet.DataSetName = "DHMSdatabaseDataSet";
            this.dHMSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableTableAdapter
            // 
            this.roomTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.resTableTableAdapter = null;
            this.tableAdapterManager.roomTableTableAdapter = this.roomTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Divine_Hotel_Management_System.DHMSdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addNewRoomB
            // 
            this.addNewRoomB.Location = new System.Drawing.Point(118, 120);
            this.addNewRoomB.Name = "addNewRoomB";
            this.addNewRoomB.Size = new System.Drawing.Size(100, 30);
            this.addNewRoomB.TabIndex = 1;
            this.addNewRoomB.Text = "Add New Room";
            this.addNewRoomB.UseVisualStyleBackColor = true;
            this.addNewRoomB.Click += new System.EventHandler(this.addNewRoomB_Click);
            // 
            // roomsInfoL
            // 
            this.roomsInfoL.AutoSize = true;
            this.roomsInfoL.Font = new System.Drawing.Font("Segoe Script", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsInfoL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomsInfoL.Location = new System.Drawing.Point(178, 35);
            this.roomsInfoL.Name = "roomsInfoL";
            this.roomsInfoL.Size = new System.Drawing.Size(370, 71);
            this.roomsInfoL.TabIndex = 22;
            this.roomsInfoL.Text = "Manage Rooms";
            // 
            // roomsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(701, 443);
            this.Controls.Add(this.roomsInfoL);
            this.Controls.Add(this.addNewRoomB);
            this.Controls.Add(this.roomsDGV);
            this.Name = "roomsInfoForm";
            this.Text = "Rooms Info";
            this.Load += new System.EventHandler(this.roomsInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMSdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomsDGV;
        private DHMSdatabaseDataSet dHMSdatabaseDataSet;
        private System.Windows.Forms.BindingSource roomTableBindingSource;
        private DHMSdatabaseDataSetTableAdapters.roomTableTableAdapter roomTableTableAdapter;
        private DHMSdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reservationStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button addNewRoomB;
        private System.Windows.Forms.Label roomsInfoL;
    }
}