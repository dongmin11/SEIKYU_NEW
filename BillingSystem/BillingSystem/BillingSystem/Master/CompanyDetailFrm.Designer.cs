
namespace BillingSystem.Master
{
    partial class CompanyDetailFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.TxtPostNo = new System.Windows.Forms.TextBox();
            this.lbPostNo = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbSealFile = new System.Windows.Forms.Label();
            this.TxtCompanySealFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.ofdSealFile = new System.Windows.Forms.OpenFileDialog();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFraction = new System.Windows.Forms.ComboBox();
            this.TxtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.NumTax = new System.Windows.Forms.NumericUpDown();
            this.LblSealName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTax)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(561, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "登録";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(669, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbCompanyName.Location = new System.Drawing.Point(27, 22);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(56, 16);
            this.lbCompanyName.TabIndex = 1;
            this.lbCompanyName.Text = "会社名";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtCompanyName.Location = new System.Drawing.Point(139, 20);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCompanyName.MaxLength = 100;
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(599, 23);
            this.TxtCompanyName.TabIndex = 1;
            // 
            // TxtPostNo
            // 
            this.TxtPostNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPostNo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtPostNo.Location = new System.Drawing.Point(139, 55);
            this.TxtPostNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPostNo.MaxLength = 10;
            this.TxtPostNo.Name = "TxtPostNo";
            this.TxtPostNo.Size = new System.Drawing.Size(131, 23);
            this.TxtPostNo.TabIndex = 2;
            // 
            // lbPostNo
            // 
            this.lbPostNo.AutoSize = true;
            this.lbPostNo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPostNo.Location = new System.Drawing.Point(27, 62);
            this.lbPostNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPostNo.Name = "lbPostNo";
            this.lbPostNo.Size = new System.Drawing.Size(72, 16);
            this.lbPostNo.TabIndex = 3;
            this.lbPostNo.Text = "郵便番号";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbAddress.Location = new System.Drawing.Point(27, 102);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(40, 16);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "住所";
            // 
            // TxtTel
            // 
            this.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtTel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtTel.Location = new System.Drawing.Point(139, 140);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTel.MaxLength = 15;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(153, 23);
            this.TxtTel.TabIndex = 4;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbTel.Location = new System.Drawing.Point(27, 142);
            this.lbTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(72, 16);
            this.lbTel.TabIndex = 7;
            this.lbTel.Text = "電話番号";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbTax.Location = new System.Drawing.Point(27, 182);
            this.lbTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(72, 16);
            this.lbTax.TabIndex = 9;
            this.lbTax.Text = "消費税率";
            // 
            // lbSealFile
            // 
            this.lbSealFile.AutoSize = true;
            this.lbSealFile.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbSealFile.Location = new System.Drawing.Point(27, 302);
            this.lbSealFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSealFile.Name = "lbSealFile";
            this.lbSealFile.Size = new System.Drawing.Size(104, 16);
            this.lbSealFile.TabIndex = 13;
            this.lbSealFile.Text = "捺印ファイル";
            // 
            // TxtCompanySealFile
            // 
            this.TxtCompanySealFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanySealFile.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtCompanySealFile.Location = new System.Drawing.Point(139, 300);
            this.TxtCompanySealFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCompanySealFile.Name = "TxtCompanySealFile";
            this.TxtCompanySealFile.ReadOnly = true;
            this.TxtCompanySealFile.Size = new System.Drawing.Size(522, 23);
            this.TxtCompanySealFile.TabIndex = 20;
            this.TxtCompanySealFile.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(669, 300);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 30);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "参照";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ofdSealFile
            // 
            this.ofdSealFile.FileName = "ofdSealFile";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtAddress.Location = new System.Drawing.Point(139, 100);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAddress.MaxLength = 125;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(599, 23);
            this.TxtAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.label1.Location = new System.Drawing.Point(27, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "端数";
            // 
            // CmbFraction
            // 
            this.CmbFraction.DisplayMember = "Name";
            this.CmbFraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFraction.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.CmbFraction.FormattingEnabled = true;
            this.CmbFraction.Location = new System.Drawing.Point(139, 219);
            this.CmbFraction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbFraction.Name = "CmbFraction";
            this.CmbFraction.Size = new System.Drawing.Size(145, 24);
            this.CmbFraction.TabIndex = 6;
            this.CmbFraction.ValueMember = "Code";
            // 
            // TxtInvoiceNo
            // 
            this.TxtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInvoiceNo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.TxtInvoiceNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtInvoiceNo.Location = new System.Drawing.Point(139, 260);
            this.TxtInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtInvoiceNo.MaxLength = 12;
            this.TxtInvoiceNo.Name = "TxtInvoiceNo";
            this.TxtInvoiceNo.Size = new System.Drawing.Size(165, 23);
            this.TxtInvoiceNo.TabIndex = 7;
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.AutoSize = true;
            this.lbInvoiceNo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.lbInvoiceNo.Location = new System.Drawing.Point(27, 262);
            this.lbInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(104, 16);
            this.lbInvoiceNo.TabIndex = 32;
            this.lbInvoiceNo.Text = "インボイスNo";
            // 
            // NumTax
            // 
            this.NumTax.DecimalPlaces = 2;
            this.NumTax.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumTax.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumTax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumTax.InterceptArrowKeys = false;
            this.NumTax.Location = new System.Drawing.Point(139, 180);
            this.NumTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumTax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTax.Name = "NumTax";
            this.NumTax.Size = new System.Drawing.Size(92, 23);
            this.NumTax.TabIndex = 5;
            this.NumTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblSealName
            // 
            this.LblSealName.AutoSize = true;
            this.LblSealName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            this.LblSealName.Location = new System.Drawing.Point(136, 328);
            this.LblSealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSealName.Name = "LblSealName";
            this.LblSealName.Size = new System.Drawing.Size(104, 16);
            this.LblSealName.TabIndex = 13;
            this.LblSealName.Text = "捺印ファイル";
            // 
            // CompanyDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 405);
            this.Controls.Add(this.NumTax);
            this.Controls.Add(this.TxtInvoiceNo);
            this.Controls.Add(this.lbInvoiceNo);
            this.Controls.Add(this.CmbFraction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lbPostNo);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.TxtCompanySealFile);
            this.Controls.Add(this.LblSealName);
            this.Controls.Add(this.lbSealFile);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.TxtPostNo);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会社詳細";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyDetailFrm_FormClosed);
            this.Load += new System.EventHandler(this.CompanyDetailFrmDetailFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.TextBox TxtPostNo;
        private System.Windows.Forms.Label lbPostNo;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbSealFile;
        private System.Windows.Forms.TextBox TxtCompanySealFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog ofdSealFile;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFraction;
        private System.Windows.Forms.TextBox TxtInvoiceNo;
        private System.Windows.Forms.Label lbInvoiceNo;
        private System.Windows.Forms.NumericUpDown NumTax;
        private System.Windows.Forms.Label LblSealName;
    }
}