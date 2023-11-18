using BillingSystem.BaseFrom;
using BillingSystem.BLL;
using BillingSystem.Models;
using Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BillingSystem.Master
{
    public partial class UserFrm : BaseFrm
    {
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserFrm()
        {
            InitializeComponent();
        }
        #endregion

        #region ページロード        
        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserFrm_Load(object sender, System.EventArgs e)
        {
            dgvUserList.AutoGenerateColumns = false;
            BaseFromInitialize("ユーザーマスタ", ButtonData.GetUserFrm());
            //btnCreateNew.Visible = true;
        }
        #endregion

        #region 検索ボタン処理        
        /// <summary>
        /// 検索ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                // 検索実行
                SearchExecution();
            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示する
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion        

        #region 新規作成ボタン処理
        /// <summary>
        /// 新規作成ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected  void btnCreateNew_Click(object sender, System.EventArgs e)
        {
            try
            {
                UserDetailFrm detailFrm = new UserDetailFrm();
                // ダイアログで開く
                detailFrm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示する
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion

        #region 編集ボタン処理
        /// <summary>
        /// 編集ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                UserDetailFrm detailFrm = new UserDetailFrm();
                // ダイアログで開く
                detailFrm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示する
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion

        #region 閉じる処理
        /// <summary>
        /// 閉じる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnClose_Click(object sender, System.EventArgs e)
        {
           // 閉じる処理
        }
        #endregion

        #region 検索条件クリア
        /// <summary>
        /// 検索条件クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtLoginID.Text = string.Empty;
                this.txtUserName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示する
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion

        #region 行選択イベント処理
        /// <summary>
        /// 行選択イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //列ヘッダーをクリックした場合などにキャンセルする。
                if (e.RowIndex < 0)
                {
                    return;
                }

                //クリックした列が対象列かチェックする。
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex].Name == "Detail")
                {
                    UserDetailFrm detailFrm = new UserDetailFrm();
                    UserModel model = new UserModel();
                    var datarow = dgv.CurrentRow;
                    // 行情報取得
                    model = datarow.DataBoundItem as UserModel;
                    // 詳細画面へ渡す
                    detailFrm.userData = model;
                    // 親フォームを指定
                    detailFrm.Owner = this;
                    // ダイアログで開く
                    detailFrm.ShowDialog(this);

                }
            }
            catch (Exception ex)
            {
                // エラーログ出力
                log.Error(ex.Message);
                // メッセージで表示すｒ
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }
        #endregion

        #region 検索実行
        /// <summary>
        /// 検索実行
        /// </summary>
        public void SearchExecution()
        {
            UserBLL bll = new UserBLL();
            UserModel inputData = new UserModel();
            List<UserModel> outputData = new List<UserModel>();
            // ログインID
            inputData.LoginID = this.txtLoginID.Text;
            // 氏名
            inputData.UserName = this.txtUserName.Text;
            // データ取得
            outputData = bll.GetAccoutInfo(inputData);
            if (outputData != null && outputData.Count > 0)
            {
                dgvUserList.DataSource = outputData;
            }
            else
            {
                // データが存在しなかったら、メッセージで表示する
                dgvUserList.DataSource = null;
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0003);
                MessageBox.Show(msg);
            }
        }
        #endregion
    }
}
