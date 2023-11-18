﻿namespace BillingSystem
{
    partial class SeikyuFrm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkApproved = new System.Windows.Forms.CheckBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.chkSent = new System.Windows.Forms.CheckBox();
            this.cmbAssignee = new System.Windows.Forms.ComboBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.BtnSearchButton = new System.Windows.Forms.Button();
            this.chkPendingApproval = new System.Windows.Forms.CheckBox();
            this.chkInProgress = new System.Windows.Forms.CheckBox();
            this.CkbxShowDeleted = new System.Windows.Forms.CheckBox();
            this.DtbBillingEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtbBillingStartDate = new System.Windows.Forms.DateTimePicker();
            this.CbbxBillingRecipient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnPreviousButton = new System.Windows.Forms.Button();
            this.BtnNextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTotalCount = new System.Windows.Forms.Label();
            this.LblDisplayCount = new System.Windows.Forms.Label();
            this.DgbBillingInfoGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbBillingInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProcessName
            // 
            this.LblProcessName.Size = new System.Drawing.Size(836, 40);
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.Location = new System.Drawing.Point(1042, 16);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkApproved);
            this.panel3.Controls.Add(this.chkCompleted);
            this.panel3.Controls.Add(this.chkSent);
            this.panel3.Controls.Add(this.cmbAssignee);
            this.panel3.Controls.Add(this.Lbl);
            this.panel3.Controls.Add(this.BtnSearchButton);
            this.panel3.Controls.Add(this.chkPendingApproval);
            this.panel3.Controls.Add(this.chkInProgress);
            this.panel3.Controls.Add(this.CkbxShowDeleted);
            this.panel3.Controls.Add(this.DtbBillingEndDate);
            this.panel3.Controls.Add(this.DtbBillingStartDate);
            this.panel3.Controls.Add(this.CbbxBillingRecipient);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1276, 108);
            this.panel3.TabIndex = 9;
            // 
            // chkApproved
            // 
            this.chkApproved.AutoSize = true;
            this.chkApproved.Location = new System.Drawing.Point(736, 12);
            this.chkApproved.Name = "chkApproved";
            this.chkApproved.Size = new System.Drawing.Size(90, 24);
            this.chkApproved.TabIndex = 5;
            this.chkApproved.Text = "承認済み";
            this.chkApproved.UseVisualStyleBackColor = true;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(836, 12);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(60, 24);
            this.chkCompleted.TabIndex = 6;
            this.chkCompleted.Text = "完了";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // chkSent
            // 
            this.chkSent.AutoSize = true;
            this.chkSent.Location = new System.Drawing.Point(913, 12);
            this.chkSent.Name = "chkSent";
            this.chkSent.Size = new System.Drawing.Size(76, 24);
            this.chkSent.TabIndex = 7;
            this.chkSent.Text = "送付済";
            this.chkSent.UseVisualStyleBackColor = true;
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.DisplayMember = "UserName";
            this.cmbAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Location = new System.Drawing.Point(573, 41);
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(275, 28);
            this.cmbAssignee.TabIndex = 9;
            this.cmbAssignee.ValueMember = "ID";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(511, 44);
            this.Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(57, 20);
            this.Lbl.TabIndex = 5;
            this.Lbl.Text = "担当者";
            // 
            // BtnSearchButton
            // 
            this.BtnSearchButton.Location = new System.Drawing.Point(433, 75);
            this.BtnSearchButton.Name = "BtnSearchButton";
            this.BtnSearchButton.Size = new System.Drawing.Size(100, 30);
            this.BtnSearchButton.TabIndex = 11;
            this.BtnSearchButton.Text = "検索";
            this.BtnSearchButton.UseVisualStyleBackColor = true;
            this.BtnSearchButton.Click += new System.EventHandler(this.BtnSearchButton_Click);
            // 
            // chkPendingApproval
            // 
            this.chkPendingApproval.AutoSize = true;
            this.chkPendingApproval.Location = new System.Drawing.Point(638, 12);
            this.chkPendingApproval.Name = "chkPendingApproval";
            this.chkPendingApproval.Size = new System.Drawing.Size(88, 24);
            this.chkPendingApproval.TabIndex = 4;
            this.chkPendingApproval.Text = "承認待ち";
            this.chkPendingApproval.UseVisualStyleBackColor = true;
            // 
            // chkInProgress
            // 
            this.chkInProgress.AutoSize = true;
            this.chkInProgress.Location = new System.Drawing.Point(555, 12);
            this.chkInProgress.Name = "chkInProgress";
            this.chkInProgress.Size = new System.Drawing.Size(76, 24);
            this.chkInProgress.TabIndex = 3;
            this.chkInProgress.Text = "作成中";
            this.chkInProgress.UseVisualStyleBackColor = true;
            // 
            // CkbxShowDeleted
            // 
            this.CkbxShowDeleted.AutoSize = true;
            this.CkbxShowDeleted.Location = new System.Drawing.Point(12, 79);
            this.CkbxShowDeleted.Name = "CkbxShowDeleted";
            this.CkbxShowDeleted.Size = new System.Drawing.Size(119, 24);
            this.CkbxShowDeleted.TabIndex = 10;
            this.CkbxShowDeleted.Text = "削除のみ表示";
            this.CkbxShowDeleted.UseVisualStyleBackColor = true;
            // 
            // DtbBillingEndDate
            // 
            this.DtbBillingEndDate.Location = new System.Drawing.Point(296, 7);
            this.DtbBillingEndDate.Name = "DtbBillingEndDate";
            this.DtbBillingEndDate.Size = new System.Drawing.Size(172, 28);
            this.DtbBillingEndDate.TabIndex = 2;
            // 
            // DtbBillingStartDate
            // 
            this.DtbBillingStartDate.Location = new System.Drawing.Point(88, 7);
            this.DtbBillingStartDate.Name = "DtbBillingStartDate";
            this.DtbBillingStartDate.Size = new System.Drawing.Size(168, 28);
            this.DtbBillingStartDate.TabIndex = 1;
            this.DtbBillingStartDate.ValueChanged += new System.EventHandler(this.DtbBillingStartDate_ValueChanged);
            // 
            // CbbxBillingRecipient
            // 
            this.CbbxBillingRecipient.DisplayMember = "CustomerName";
            this.CbbxBillingRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbxBillingRecipient.FormattingEnabled = true;
            this.CbbxBillingRecipient.Location = new System.Drawing.Point(88, 41);
            this.CbbxBillingRecipient.Name = "CbbxBillingRecipient";
            this.CbbxBillingRecipient.Size = new System.Drawing.Size(380, 28);
            this.CbbxBillingRecipient.TabIndex = 8;
            this.CbbxBillingRecipient.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "請求先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "～";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請求期間";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.BtnPreviousButton);
            this.panel4.Controls.Add(this.BtnNextButton);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.LblTotalCount);
            this.panel4.Controls.Add(this.LblDisplayCount);
            this.panel4.Controls.Add(this.DgbBillingInfoGridView);
            this.panel4.Location = new System.Drawing.Point(4, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1272, 469);
            this.panel4.TabIndex = 10;
            // 
            // BtnPreviousButton
            // 
            this.BtnPreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPreviousButton.Enabled = false;
            this.BtnPreviousButton.Location = new System.Drawing.Point(1158, 3);
            this.BtnPreviousButton.Name = "BtnPreviousButton";
            this.BtnPreviousButton.Size = new System.Drawing.Size(50, 30);
            this.BtnPreviousButton.TabIndex = 14;
            this.BtnPreviousButton.Text = "前頁";
            this.BtnPreviousButton.UseVisualStyleBackColor = true;
            this.BtnPreviousButton.Click += new System.EventHandler(this.BtnPreviousButton_Click_1);
            // 
            // BtnNextButton
            // 
            this.BtnNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextButton.Enabled = false;
            this.BtnNextButton.Location = new System.Drawing.Point(1214, 3);
            this.BtnNextButton.Name = "BtnNextButton";
            this.BtnNextButton.Size = new System.Drawing.Size(50, 30);
            this.BtnNextButton.TabIndex = 15;
            this.BtnNextButton.Text = "次頁";
            this.BtnNextButton.UseVisualStyleBackColor = true;
            this.BtnNextButton.Click += new System.EventHandler(this.BtnNextButton_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1082, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "/";
            // 
            // LblTotalCount
            // 
            this.LblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalCount.AutoSize = true;
            this.LblTotalCount.Location = new System.Drawing.Point(1094, 9);
            this.LblTotalCount.Name = "LblTotalCount";
            this.LblTotalCount.Size = new System.Drawing.Size(55, 20);
            this.LblTotalCount.TabIndex = 13;
            this.LblTotalCount.Text = "520件";
            // 
            // LblDisplayCount
            // 
            this.LblDisplayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDisplayCount.AutoSize = true;
            this.LblDisplayCount.Location = new System.Drawing.Point(1047, 9);
            this.LblDisplayCount.Name = "LblDisplayCount";
            this.LblDisplayCount.Size = new System.Drawing.Size(39, 20);
            this.LblDisplayCount.TabIndex = 12;
            this.LblDisplayCount.Text = "100";
            // 
            // DgbBillingInfoGridView
            // 
            this.DgbBillingInfoGridView.AllowUserToAddRows = false;
            this.DgbBillingInfoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgbBillingInfoGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgbBillingInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbBillingInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.ID,
            this.RowNo,
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgbBillingInfoGridView.Location = new System.Drawing.Point(0, 39);
            this.DgbBillingInfoGridView.MultiSelect = false;
            this.DgbBillingInfoGridView.Name = "DgbBillingInfoGridView";
            this.DgbBillingInfoGridView.ReadOnly = true;
            this.DgbBillingInfoGridView.RowHeadersWidth = 51;
            this.DgbBillingInfoGridView.RowTemplate.Height = 21;
            this.DgbBillingInfoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgbBillingInfoGridView.Size = new System.Drawing.Size(1268, 427);
            this.DgbBillingInfoGridView.TabIndex = 16;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BillingDate";
            this.Column2.HeaderText = "請求日";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // RowNo
            // 
            this.RowNo.DataPropertyName = "RowNo";
            this.RowNo.HeaderText = "RowNo";
            this.RowNo.MinimumWidth = 6;
            this.RowNo.Name = "RowNo";
            this.RowNo.ReadOnly = true;
            this.RowNo.Visible = false;
            this.RowNo.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CodeName";
            this.Column8.HeaderText = "状態";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "UserName";
            this.Column9.HeaderText = "担当者";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerName";
            this.Column1.HeaderText = "請求先";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BillingNo";
            this.Column3.HeaderText = "請求No";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BillingAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "請求金額(税抜き)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BillingTax";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "消費税";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TransportationAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "交通費";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BillingTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "合計金額";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // SeikyuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(1284, 685);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "SeikyuFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeikyuFrm_FormClosed);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbBillingInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSearchButton;
        private System.Windows.Forms.CheckBox chkPendingApproval;
        private System.Windows.Forms.CheckBox chkInProgress;
        private System.Windows.Forms.CheckBox CkbxShowDeleted;
        private System.Windows.Forms.DateTimePicker DtbBillingEndDate;
        private System.Windows.Forms.DateTimePicker DtbBillingStartDate;
        private System.Windows.Forms.ComboBox CbbxBillingRecipient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DgbBillingInfoGridView;
        private System.Windows.Forms.Button BtnPreviousButton;
        private System.Windows.Forms.Button BtnNextButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTotalCount;
        private System.Windows.Forms.Label LblDisplayCount;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.CheckBox chkApproved;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.CheckBox chkSent;
        private System.Windows.Forms.ComboBox cmbAssignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
