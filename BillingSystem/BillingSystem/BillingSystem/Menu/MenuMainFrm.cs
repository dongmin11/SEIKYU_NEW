using BillingSystem.BaseFrom;
using BillingSystem.Models;
using Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillingSystem.Menu
{
    public partial class MenuMainFrm : BaseFrm
    {
        #region 変数
        /// <summary>
        /// 請求書メニュー画面
        /// </summary>
        SeikyuMenuFrm seikyu;
        /// <summary>
        /// マスタメニュー画面
        /// </summary>
        MasterMenuFrm master;
        /// <summary>
        /// ボタン選択中色
        /// </summary>
        private Color _activeColor = Color.Aquamarine;
        /// <summary>
        /// ボタンデフォルト色
        /// </summary>
        private Color _defaultColor = Color.CadetBlue;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MenuMainFrm()
        {
            InitializeComponent();
            //base.btnToMenu.Visible = false;
            base.LblProcessName.Text = "メニュー";
        }
        #endregion

        #region ページロード
        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuMain_Load(object sender, System.EventArgs e)
        {
            try
            {
                MenuControl();
                seikyu = new SeikyuMenuFrm(this);
                seikyu.TopLevel = false;
                seikyu.Dock = DockStyle.None;
                plSubMenu.Controls.Add(seikyu);

                master = new MasterMenuFrm(this);
                master.TopLevel = false;
                master.Dock = DockStyle.None;
                plSubMenu.Controls.Add(master);
                btSeikyu.BackColor = _activeColor;
                seikyu.Show();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG9999);
                MessageBox.Show(msg);
            }


        }
        #endregion

        #region 請求書クリック処理
        /// <summary>
        /// 請求書クリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSeikyu_Click(object sender, System.EventArgs e)
        {
            HideAllForm();
            seikyu.Show();
            btSeikyu.BackColor = _activeColor;
        }
        #endregion

        #region マスタ設定クリック処理
        /// <summary>
        /// マスタ設定クリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaster_Click(object sender, System.EventArgs e)
        {
            HideAllForm();
            master.Show();
            btnMaster.BackColor = _activeColor;
        }
        #endregion

        #region 初期化処理
        /// <summary>
        /// 初期化処理
        /// </summary>
        private void HideAllForm()
        {
            // 請求メニュー非表示
            seikyu.Hide();
            // マスタ設定メニュー非表示
            master.Hide();
            // ボタン背景色設定
            btSeikyu.BackColor = _defaultColor;
            btnMaster.BackColor = _defaultColor;
        }
        #endregion

        #region ボタン制御        
        /// <summary>
        /// ボタン制御
        /// </summary>
        private void MenuControl()
        {
            if (ConstCommon.AUTHORITYFLAG_9 != LoginInfo.AuthorityFlag)
            {
                // マスタ設定ボタンが非表示する
                this.btnMaster.Visible = false;
            }
            // 新規作成ボタンが非表示する
            //this.btnCreateNew.Visible = false;
        }
        #endregion
    }
}
