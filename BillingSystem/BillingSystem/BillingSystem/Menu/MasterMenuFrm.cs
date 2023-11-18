using BillingSystem.Common;
using BillingSystem.Master;
using Common;
using System;
using System.Windows.Forms;
using Utils;

namespace BillingSystem.Menu
{
    public partial class MasterMenuFrm : Form
    {
        #region 変数
        /// <summary>
        /// ログ
        /// </summary>
        protected ILogUtil log;
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;
        /// <summary>
        /// メニューメイン情報
        /// </summary>
        private MenuMainFrm mainFrm;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="f"></param>             
        public MasterMenuFrm(MenuMainFrm f)
        {
            InitializeComponent();
            log = new LogUtil();
            myMsgIni = new MyMessageIniFile();
            mainFrm = f;
        }
        #endregion

        #region マスタメンテナンス        
        /// <summary>
        /// 会社マスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompany_Click(object sender, EventArgs e)
        {
            try
            {               
                CompanyDetailFrm companyFrm = new CompanyDetailFrm();
                companyFrm.Show(this);
                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// ユーザーマスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                UserFrm userFrm = new UserFrm();                
                userFrm.Show(this);
                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 社員プロジェクトマスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployeeProject_Click(object sender, EventArgs e)
        {
            try
            {
                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 部署マスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            try
            {

                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 請求先マスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 社員マスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        /// <summary>
        /// プロジェクトマスタ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProject_Click(object sender, EventArgs e)
        {
            try
            {

                mainFrm.Hide();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }
        }

        #endregion
        
    }
}
