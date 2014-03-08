namespace Vecc.FiddlerCertInformation
{
    partial class CertInfoInspectorTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProperties = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenCertificateDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProperties
            // 
            this.dgProperties.AllowUserToAddRows = false;
            this.dgProperties.AllowUserToDeleteRows = false;
            this.dgProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProperties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnValue});
            this.dgProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProperties.Location = new System.Drawing.Point(3, 32);
            this.dgProperties.Name = "dgProperties";
            this.dgProperties.ReadOnly = true;
            this.dgProperties.Size = new System.Drawing.Size(850, 486);
            this.dgProperties.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.Frozen = true;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 60;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnValue.DataPropertyName = "Value";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnValue.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.MinimumWidth = 250;
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnValue.Width = 250;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgProperties, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenCertificateDialog, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 521);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnOpenCertificateDialog
            // 
            this.btnOpenCertificateDialog.Enabled = false;
            this.btnOpenCertificateDialog.Location = new System.Drawing.Point(3, 3);
            this.btnOpenCertificateDialog.Name = "btnOpenCertificateDialog";
            this.btnOpenCertificateDialog.Size = new System.Drawing.Size(143, 23);
            this.btnOpenCertificateDialog.TabIndex = 1;
            this.btnOpenCertificateDialog.Text = "Open Information Dialog";
            this.btnOpenCertificateDialog.UseVisualStyleBackColor = true;
            this.btnOpenCertificateDialog.Click += new System.EventHandler(this.btnOpenCertificateDialog_Click);
            // 
            // CertInfoInspectorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CertInfoInspectorTab";
            this.Size = new System.Drawing.Size(856, 521);
            ((System.ComponentModel.ISupportInitialize)(this.dgProperties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOpenCertificateDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;

    }
}
