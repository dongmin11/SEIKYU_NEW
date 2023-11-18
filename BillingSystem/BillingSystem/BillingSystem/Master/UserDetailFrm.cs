using BillingSystem.BLL;
using BillingSystem.Common;
using BillingSystem.Models;
using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace BillingSystem.Master
{
    public partial class UserDetailFrm : Form
    {
        /// <summary>
        /// ログ
        /// </summary>
        protected ILogUtil log;
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;

        #region プロパティ
        private UserModel _userData = new UserModel();
        /// <summary>
        /// ユーザー情報
        /// </summary>
        public UserModel userData
        {
            set
            {
                _userData = value;
            }
            get
            {
                return _userData;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserDetailFrm()
        {
            InitializeComponent();
            log = new LogUtil();
            myMsgIni = new MyMessageIniFile();
        }
        #endregion

        #region ページロード        
        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDetailFrm_Load(object sender, EventArgs e)
        {
            // データ初期化
            IniLoad();
            // 画面初期化
            Syokika();
        }
        #endregion

        #region ファイル選択ダイアログ        
        /// <summary>
        /// ファイル選択ダイアログ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            // デフォルトのフォルダを指定する
            ofDialog.InitialDirectory = @"C:";

            //ダイアログのタイトルを指定する
            ofDialog.Title = "ダイアログのタイトル";

            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtSealFilePath.Text = ofDialog.FileName;
            }
            else
            {
                this.txtSealFilePath.Text = string.Empty;
            }

            // オブジェクトを破棄する
            ofDialog.Dispose();
        }
        #endregion        

        #region 保存ボタン処理
        /// <summary>
        /// 保存ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 必須チェック
                string msg = DataCheck();
                if (!string.IsNullOrEmpty(msg))
                {
                    MessageBox.Show(msg);
                    return;
                }
                // 登録情報取得
                UserModel inputData = GetUserInfoData();

                UserBLL bll = new UserBLL();
                // 新規の場合、ログインIDが存在するチェック
                if (string.IsNullOrEmpty(userData.LoginID))
                {
                    if (bll.IsLoginIdExist(inputData.LoginID))
                    {
                        // メッセージで表示
                        msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0005);
                        MessageBox.Show(msg);
                        return;
                    }
                }
                // 登録実行
                int result = bll.SaveUserInfo(inputData);
                if (result == 1)
                {
                    // 子フォームを閉じる
                    this.Close();
                    // 親フォームでメソッドを呼び出す（再検索）
                    ((UserFrm)this.Owner).SearchExecution();
                }
                else
                {
                    msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0006);
                    MessageBox.Show(msg);
                }

            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion

        #region 閉じる
        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region データ初期化
        /// <summary>
        /// データ初期化
        /// </summary>
        private void IniLoad()
        {
            // 権限コンボボックス初期化
            MyCommonBLL bll = new MyCommonBLL();
            CodeListModel codeList = new CodeListModel();
            codeList.KindID = ConstCommon.KINDID_1000;
            List<CodeListModel> list = bll.GetCodeList(codeList);
            cbAuthorityFlag.DataSource = list;
        }
        #endregion

        #region 画面表示項目初期化
        /// <summary>
        /// 画面表示項目初期化
        /// </summary>
        private void Syokika()
        {
            // 編集モード
            if (userData != null && !string.IsNullOrEmpty(userData.LoginID))
            {
                // ログインID
                this.txtLoginID.Text = userData.LoginID;
                // 変更場合、ログインID変更できません
                this.txtLoginID.ReadOnly = true;
                // 氏名
                this.txtUserName.Text = userData.UserName;
                // カナ氏名
                this.txtUserNameKana.Text = userData.UserNameKana;
                // 略称
                this.txtUserShortName.Text = userData.UserShortName;
                // 部署
                this.txtDepartment.Text = userData.Department;
                // 権限フラグ
                this.cbAuthorityFlag.SelectedValue = userData.AuthorityFlag;
                // 備考
                this.txtNote.Text = userData.Note;
                // ボタン「更新」で表示する
                this.btnSave.Text = "更新";

            }
            else
            {
                // 新規の場合、パスワード初期化のデフォルトは選択する
                this.ckReset.Checked = true;
                this.ckReset.Enabled = false;
            }

        }
        #endregion

        #region 必須項目チェック
        /// <summary>
        /// 必須項目チェック
        /// </summary>
        /// <returns></returns>
        private string DataCheck()
        {
            string msg = string.Empty;
            // ログインID
            if (string.IsNullOrEmpty(txtLoginID.Text))
            {
                string strMsg = string.Format(myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0002), "ログインID");
                if (string.IsNullOrEmpty(msg))
                {
                    msg += strMsg;
                }
                else
                {
                    msg += Environment.NewLine;
                    msg += strMsg;
                }
            }
            // 氏名
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                string strMsg = string.Format(myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0002), "氏名");
                if (string.IsNullOrEmpty(msg))
                {
                    msg += strMsg;
                }
                else
                {
                    msg += Environment.NewLine;
                    msg += strMsg;
                }
            }
            // 新規の場合、パスワード初期化チェックボックス自動的に選択状態にする
            if (string.IsNullOrEmpty(userData.LoginID))
            {
                this.ckReset.Checked = true;
            }
            // パスワードが一致
            if (this.ckReset.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtPassword.Text) && !string.IsNullOrEmpty(this.txtPassword1.Text))
                {
                    if (!this.txtPassword.Text.Equals(this.txtPassword1.Text))
                    {
                        string strMsg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0004);
                        if (string.IsNullOrEmpty(msg))
                        {
                            msg += strMsg;
                        }
                        else
                        {
                            msg += Environment.NewLine;
                            msg += strMsg;
                        }
                    }
                }
                else
                {
                    string strMsg = string.Format(myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0002), "パスワード");
                    if (string.IsNullOrEmpty(msg))
                    {
                        msg += strMsg;
                    }
                    else
                    {
                        msg += Environment.NewLine;
                        msg += strMsg;
                    }
                }
            }

            return msg;
        }
        #endregion

        #region 登録情報取得
        /// <summary>
        /// 登録情報取得
        /// </summary>
        /// <returns></returns>
        private UserModel GetUserInfoData()
        {
            CommonUtil commonUtil = new CommonUtil();
            UserModel inputData = new UserModel();
            // ID
            inputData.ID = userData.ID;
            // ログインID
            inputData.LoginID = this.txtLoginID.Text;
            // 氏名
            inputData.UserName = this.txtUserName.Text;
            // カナ氏名
            inputData.UserNameKana = this.txtUserNameKana.Text;
            // 略称
            inputData.UserShortName = this.txtUserShortName.Text;
            // 部署
            inputData.Department = this.txtDepartment.Text;
            // 権限
            inputData.AuthorityFlag = cbAuthorityFlag.SelectedValue.ToString();
            // 捺印ファイル
            if (commonUtil.IsFileExist(this.txtSealFilePath.Text))
            {
                inputData.SealFile = commonUtil.ReadBinary(txtSealFilePath.Text);
                inputData.SealName = Path.GetFileName(txtSealFilePath.Text);
            }
            if (this.ckReset.Checked)
            {
                // パスワード（暗号化にする）
                inputData.Password = PWDCodingUtil.Encrypt(this.txtPassword.Text);
            }
            // 備考
            inputData.Note = this.txtNote.Text;
            // ロックID
            inputData.LockVer = userData.LockVer;
            // 作成者ID
            inputData.CreatUserID = LoginInfo.ID;
            // 更新者ID
            inputData.UpdateUserID = LoginInfo.ID;


            return inputData;
        }
        #endregion
    }
}
