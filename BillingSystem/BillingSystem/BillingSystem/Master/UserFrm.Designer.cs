
namespace BillingSystem.Master
{
    partial class UserFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.lbLoginID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameKana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            //this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchClear);
            this.panel3.Controls.Add(this.txtLoginID);
            this.panel3.Controls.Add(this.lbLoginID);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(14, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1226, 101);
            this.panel3.TabIndex = 9;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Location = new System.Drawing.Point(603, 62);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(70, 31);
            this.btnSearchClear.TabIndex = 5;
            this.btnSearchClear.Text = "クリア";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // txtLoginID
            // 
            this.txtLoginID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginID.Location = new System.Drawing.Point(123, 18);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(339, 28);
            this.txtLoginID.TabIndex = 4;
            // 
            // lbLoginID
            // 
            this.lbLoginID.AutoSize = true;
            this.lbLoginID.Location = new System.Drawing.Point(33, 17);
            this.lbLoginID.Name = "lbLoginID";
            this.lbLoginID.Size = new System.Drawing.Size(75, 20);
            this.lbLoginID.TabIndex = 3;
            this.lbLoginID.Text = "ログインID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(123, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(339, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ユーザー名";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvUserList);
            this.panel4.Location = new System.Drawing.Point(15, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1224, 397);
            this.panel4.TabIndex = 10;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.LoginID,
            this.UserName,
            this.UserNameKana,
            this.UserShortName,
            this.Department,
            this.AuthorityName,
            this.Note});
            this.dgvUserList.Location = new System.Drawing.Point(4, 46);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowTemplate.Height = 21;
            this.dgvUserList.Size = new System.Drawing.Size(1217, 342);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellContentClick);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "詳細";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "詳細";
            this.Detail.Width = 50;
            // 
            // LoginID
            // 
            this.LoginID.DataPropertyName = "LoginID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LoginID.DefaultCellStyle = dataGridViewCellStyle2;
            this.LoginID.HeaderText = "ログインID";
            this.LoginID.Name = "LoginID";
            this.LoginID.ReadOnly = true;
            this.LoginID.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "氏名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // UserNameKana
            // 
            this.UserNameKana.DataPropertyName = "UserNameKana";
            this.UserNameKana.HeaderText = "カナ氏名";
            this.UserNameKana.Name = "UserNameKana";
            this.UserNameKana.ReadOnly = true;
            this.UserNameKana.Width = 150;
            // 
            // UserShortName
            // 
            this.UserShortName.DataPropertyName = "UserShortName";
            this.UserShortName.HeaderText = "略称";
            this.UserShortName.Name = "UserShortName";
            this.UserShortName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "部署";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 200;
            // 
            // AuthorityName
            // 
            this.AuthorityName.DataPropertyName = "AuthorityName";
            this.AuthorityName.HeaderText = "権限";
            this.AuthorityName.Name = "AuthorityName";
            this.AuthorityName.ReadOnly = true;
            this.AuthorityName.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "備考";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "結果一覧";
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザーマスタ";
            this.Load += new System.EventHandler(this.UserFrm_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Label lbLoginID;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameKana;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}