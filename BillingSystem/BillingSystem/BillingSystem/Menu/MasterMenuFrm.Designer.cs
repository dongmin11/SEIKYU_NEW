
namespace BillingSystem.Menu
{
    partial class MasterMenuFrm
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
            this.btnProject = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployeeProject = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(297, 129);
            this.btnProject.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(252, 60);
            this.btnProject.TabIndex = 14;
            this.btnProject.Text = "プロジェクトマスタ";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(297, 38);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(252, 60);
            this.btnDepartment.TabIndex = 13;
            this.btnDepartment.Text = "部署マスタ";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(8, 223);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(252, 60);
            this.btnCustomer.TabIndex = 12;
            this.btnCustomer.Text = "請求先マスタ";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployeeProject
            // 
            this.btnEmployeeProject.Location = new System.Drawing.Point(8, 129);
            this.btnEmployeeProject.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEmployeeProject.Name = "btnEmployeeProject";
            this.btnEmployeeProject.Size = new System.Drawing.Size(252, 60);
            this.btnEmployeeProject.TabIndex = 11;
            this.btnEmployeeProject.Text = "社員プロジェクトマスタ";
            this.btnEmployeeProject.UseVisualStyleBackColor = true;
            this.btnEmployeeProject.Click += new System.EventHandler(this.btnEmployeeProject_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(585, 38);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(252, 60);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.Text = "社員マスタ";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(8, 38);
            this.btnUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(252, 60);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "ユーザーマスタ";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(585, 129);
            this.btnCompany.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(252, 60);
            this.btnCompany.TabIndex = 8;
            this.btnCompany.Text = "会社マスタ";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // MasterMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnEmployeeProject);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnCompany);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterMenuFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "マスタ設定";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployeeProject;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCompany;
    }
}