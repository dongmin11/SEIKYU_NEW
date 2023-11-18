﻿namespace BillingSystem.BaseFrom
{
    partial class BaseFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLoginUserName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LblProcessName = new System.Windows.Forms.Label();
            this.LblSystemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TblPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.LblLoginUserName);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.LblProcessName);
            this.panel2.Controls.Add(this.LblSystemName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 52);
            this.panel2.TabIndex = 8;
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoginUserName.Location = new System.Drawing.Point(1058, 16);
            this.LblLoginUserName.Name = "LblLoginUserName";
            this.LblLoginUserName.Size = new System.Drawing.Size(128, 20);
            this.LblLoginUserName.TabIndex = 6;
            this.LblLoginUserName.Text = "ユーザー名";
            this.LblLoginUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1192, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "ログアウト";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LblProcessName
            // 
            this.LblProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProcessName.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblProcessName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblProcessName.Location = new System.Drawing.Point(216, 6);
            this.LblProcessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProcessName.Name = "LblProcessName";
            this.LblProcessName.Size = new System.Drawing.Size(852, 40);
            this.LblProcessName.TabIndex = 4;
            this.LblProcessName.Text = "aa";
            this.LblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSystemName
            // 
            this.LblSystemName.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.LblSystemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSystemName.Location = new System.Drawing.Point(5, 11);
            this.LblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSystemName.Name = "LblSystemName";
            this.LblSystemName.Size = new System.Drawing.Size(167, 24);
            this.LblSystemName.TabIndex = 4;
            this.LblSystemName.Text = "請求書発行システム";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.TblPanelButton);
            this.panel1.Location = new System.Drawing.Point(0, 644);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 41);
            this.panel1.TabIndex = 7;
            // 
            // TblPanelButton
            // 
            this.TblPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TblPanelButton.AutoSize = true;
            this.TblPanelButton.ColumnCount = 2;
            this.TblPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPanelButton.Location = new System.Drawing.Point(1, 1);
            this.TblPanelButton.Name = "TblPanelButton";
            this.TblPanelButton.RowCount = 1;
            this.TblPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanelButton.Size = new System.Drawing.Size(1289, 40);
            this.TblPanelButton.TabIndex = 1;
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1292, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BaseFrm";
            this.Text = "BaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseFrm_FormClosed);
            this.Load += new System.EventHandler(this.BaseFrom_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LblProcessName;
        private System.Windows.Forms.Label LblSystemName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label LblLoginUserName;
        private System.Windows.Forms.TableLayoutPanel TblPanelButton;
    }
}