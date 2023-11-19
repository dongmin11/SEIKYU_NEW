using BillingSystem.BLL;
using BillingSystem.Common;
using BillingSystem.Menu;
using BillingSystem.Models;
using Common;
using System;
using System.Windows.Forms;
using Utils;
using System.Linq;
using System.Collections.Generic;

namespace BillingSystem
{
    public partial class LoginFrm : Form
    {
        /// <summary>
        /// ログ
        /// </summary>
        protected ILogUtil log;
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;
        public LoginFrm()
        {
            InitializeComponent();
            myMsgIni = new MyMessageIniFile();
            log = new LogUtil();
        }

        /// <summary>
        /// ログインボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.LoginID = string.Empty;
                LoginInfo.UserName = string.Empty;
                LoginInfo.Password = string.Empty;
                CompanyInfo.CompanyInfoClear();
                // DBアクセスサンプル
                //MyCommonBLL bll = new MyCommonBLL();
                //UserModel inputData = new UserModel();
                //inputData.LoginID = this.TxtUserID.Text;
                //inputData.Password = PWDCodingUtil.Encrypt(this.TxtPassword.Text);
                //UserModel AccountData = bll.GetAccoutInfo(inputData);

                //if (AccountData != null)
                //{
                //    // ログイン正常の場合、アカウント情報設定する
                //    LoginInfo.ID = AccountData.ID;
                //    LoginInfo.LoginID = AccountData.LoginID;
                //    LoginInfo.UserName = AccountData.UserName;
                //    LoginInfo.Password = AccountData.Password;
                //    LoginInfo.UserNameKana = AccountData.UserNameKana;
                //    LoginInfo.UserShortName = AccountData.UserShortName;
                //    LoginInfo.Department = AccountData.Department;
                //    LoginInfo.AuthorityFlag = AccountData.AuthorityFlag;
                //    LoginInfo.Note = AccountData.Note;
                //    LoginInfo.DeleteFlag = AccountData.DeleteFlag;
                //    LoginInfo.LockVer = AccountData.LockVer;
                //    LoginInfo.SealName = AccountData.SealName;

                //    //会社情報取得
                //    CompanyBLL companyBll = new CompanyBLL();
                //    var companyData = companyBll.GetCompanyInfo(new CompanyModel());
                //    if (companyData != null)
                //    {
                //        CompanyInfo.ID = companyData.ID;
                //        CompanyInfo.CompanyName = companyData.CompanyName;
                //        CompanyInfo.PostNo = companyData.PostNo;
                //        CompanyInfo.Address = companyData.Address;
                //        CompanyInfo.Tel = companyData.Tel;
                //        CompanyInfo.Tax = companyData.Tax;
                //        CompanyInfo.Fraction = companyData.Fraction;
                //        CompanyInfo.InvoiceNo = companyData.InvoiceNo;
                //        CompanyInfo.CompanySealID = companyData.CompanySealID.NullToString();
                //        CompanyInfo.CompanySealName = companyData.CompanySealName;
                //    }
                //    //画像ダウンロード
                //    this.DownloadSealFile();

                    this.Hide();
                    MenuMainFrm menuFrm = new MenuMainFrm();
                    //MenuFrm menuFrm = new MenuFrm();
                    menuFrm.Show(this);
                //}
                //else
                //{
                //    string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0001);
                //    MessageBox.Show(msg); ;
                //}


            }
            catch (Exception ex)
            {
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                log.Error(ex.Message);
                MessageBox.Show(msg);
            }

        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DownloadSealFile()
        {
            List<string> fileIDList = new List<string>();
            if(LoginInfo.SealFileID.NullToString() != string.Empty)
            {
                fileIDList.Add(LoginInfo.SealFileID);
            }
            if (CompanyInfo.CompanySealID.NullToString() != string.Empty)
            {
                fileIDList.Add(CompanyInfo.CompanySealID);
            }
            if (fileIDList.Any())
            {
                FileBLL bll = new FileBLL();
                var FileList = bll.GetFileInfoList(fileIDList);

                if(FileList != null && FileList.Any())
                {
                    //TODO ファイル保存
                    System.IO.File.WriteAllBytes(@"c:\work\test_copy.csv", (byte[])( FileList[0]["File"]));
                }
            }
        }
    }
}
