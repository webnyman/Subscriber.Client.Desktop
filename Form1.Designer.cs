namespace Subscriber.Client.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoad = new Button();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnExportXml = new Button();
            dgvSubscribers = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtSubscriptionNumber = new TextBox();
            label2 = new Label();
            txtPersonalNumber = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            txtDeliveryAddress = new TextBox();
            label7 = new Label();
            txtPostalCode = new TextBox();
            label8 = new Label();
            txtCity = new TextBox();
            statusLabel = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            btnImportXml = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            statusLabel.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(20, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Ladda";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(20, 51);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 1;
            btnNew.Text = "Ny";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 80);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(20, 109);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExportXml
            // 
            btnExportXml.Location = new Point(20, 138);
            btnExportXml.Name = "btnExportXml";
            btnExportXml.Size = new Size(75, 23);
            btnExportXml.TabIndex = 4;
            btnExportXml.Text = "Exportera XML";
            btnExportXml.UseVisualStyleBackColor = true;
            // 
            // dgvSubscribers
            // 
            dgvSubscribers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscribers.Location = new Point(220, 0);
            dgvSubscribers.Name = "dgvSubscribers";
            dgvSubscribers.Size = new Size(970, 183);
            dgvSubscribers.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6976738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3023262F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSubscriptionNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPersonalNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPhoneNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtDeliveryAddress, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtPostalCode, 1, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(txtCity, 1, 7);
            tableLayoutPanel1.Location = new Point(220, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(215, 275);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Prenr";
            // 
            // txtSubscriptionNumber
            // 
            txtSubscriptionNumber.Location = new Point(112, 3);
            txtSubscriptionNumber.Name = "txtSubscriptionNumber";
            txtSubscriptionNumber.Size = new Size(100, 23);
            txtSubscriptionNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Personnummer";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(112, 35);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(100, 23);
            txtPersonalNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Förnamn";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(112, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 98);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Efternamn";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 101);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 131);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefon";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(112, 134);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 164);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 10;
            label6.Text = "Utdelningsadress";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Location = new Point(112, 167);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(100, 23);
            txtDeliveryAddress.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 197);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 12;
            label7.Text = "Postnummer";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(112, 200);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 23);
            txtPostalCode.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 230);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 14;
            label8.Text = "Ort";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(112, 233);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 15;
            // 
            // statusLabel
            // 
            statusLabel.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusLabel.Location = new Point(0, 480);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(1202, 22);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // btnImportXml
            // 
            btnImportXml.Location = new Point(20, 167);
            btnImportXml.Name = "btnImportXml";
            btnImportXml.Size = new Size(75, 23);
            btnImportXml.TabIndex = 8;
            btnImportXml.Text = "Importera";
            btnImportXml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 502);
            Controls.Add(btnImportXml);
            Controls.Add(statusLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExportXml);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvSubscribers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusLabel.ResumeLayout(false);
            statusLabel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnExportXml;
        private DataGridView dgvSubscribers;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtSubscriptionNumber;
        private Label label2;
        private TextBox txtPersonalNumber;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private TextBox txtPhoneNumber;
        private Label label6;
        private TextBox txtDeliveryAddress;
        private Label label7;
        private TextBox txtPostalCode;
        private Label label8;
        private TextBox txtCity;
        private StatusStrip statusLabel;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Button btnImportXml;
    }
}
