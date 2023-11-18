using BillingSystem.Common;
using BillingSystem.Menu;
using BillingSystem.Models;
using Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;

namespace BillingSystem.BaseFrom
{
    public partial class BaseFrm : Form
    {
        /// <summary>
        /// ログ
        /// </summary>
        protected ILogUtil log;
        /// <summary>
        /// INIファイル
        /// </summary>
        protected MyIniFile ini;
        /// <summary>
        /// メッセージINIファイル
        /// </summary>
        protected MyMessageIniFile myMsgIni;
        #region 改ページ変数
        /// <summary>
        /// 一頁表示数（デフォルト100行で表示する）
        /// </summary>
        protected int currentPageCount = 100;
        /// <summary>
        /// 総ページ数
        /// </summary>
        protected int pageCount;
        /// <summary>
        /// ページ番号
        /// </summary>
        protected int currentCount;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseFrm()
        {
            InitializeComponent();
            log = new LogUtil();
            ini = new MyIniFile();
            myMsgIni = new MyMessageIniFile();
            this.LblLoginUserName.Text = LoginInfo.UserName;
        }
        #endregion

        #region ページロード
        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BaseFrom_Load(object sender, System.EventArgs e)
        {
            /// ログインIDがなかったら、ログイン画面へ遷移する
            if (string.IsNullOrEmpty(LoginInfo.LoginID))
            {
                //LoginFrm login = new LoginFrm();
                //login.Show();
                //this.Hide();
            }
        }
        #endregion

        /// <summary>
        /// BaseForm初期化(画面名、ログイン者名、ボタン設定)
        /// </summary>
        /// <param name="frmName"></param>
        /// <param name="buttonlist"></param>
        protected void BaseFromInitialize(string frmName, List<ButtonInfo> buttonlist)
        {
            try
            {
                // 画面名とログインユーザー名表示
                this.Text = frmName;
                this.LblProcessName.Text = frmName;
                //ボタン設定
                this.TblPanelButton.ColumnCount = buttonlist.Count + 1;
                this.TblPanelButton.ColumnStyles.Clear();
                for (int i = 0; i < buttonlist.Count; i++)
                {
                    this.TblPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                }
                this.TblPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                // 閉じるボタン作成
                Button button_ = new Button();
                button_.Text = "閉じる";
                button_.Name = "btnClose";
                button_.Height = 30;
                button_.Width = 100;
                button_.BackColor = System.Drawing.Color.White;
                button_.PerformClick();
                button_.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                button_.Click += AddEvent;
                button_.PerformClick();
                this.TblPanelButton.Controls.Add(button_, this.TblPanelButton.ColumnCount - 1, 0);

                for (int cnt = buttonlist.Count - 1; cnt >= 0; cnt--)
                {
                    if (buttonlist[cnt].ButtonName.NullToString().TrimEnd() != "")
                    {
                        button_ = new Button();
                        button_.Text = buttonlist[cnt].ButtonText;
                        button_.Name = buttonlist[cnt].ButtonName;
                        button_.Tag = buttonlist[cnt].ButtonTag;
                        button_.Height = 30;
                        button_.Width = ((this.TblPanelButton.Width - 100) / buttonlist.Count) - 10;
                        button_.BackColor = System.Drawing.Color.White;
                        button_.Enabled = buttonlist[cnt].ButtonEnabled;
                        button_.PerformClick();
                        button_.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                        button_.Click += AddEvent;
                        button_.PerformClick();
                        this.TblPanelButton.Controls.Add(button_, cnt, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddEvent(object sender, EventArgs e)
        {
            Button button_ = sender as Button;
            //
            // イベントを動的に追加する。
            //
            Type handlerType = typeof(EventHandler);

            Action<Control, string> registEvent = (ctl, methodName) => {
                //
                // 該当するイベントのイベントハンドラを構築し、追加する。
                // (今回はサンプルなのでmethodNameに指定したメソッドはスコープをpublicにしています。
                //  実際は、フォーム内に定義されているメソッドはprivateなどで定義するべきです。)
                //
                Delegate eventMethod =
                    Delegate.CreateDelegate(handlerType, this, this.GetType().GetMethod(methodName));

                ctl.GetType().GetEvent("Click").AddEventHandler(ctl, eventMethod);
            };
            registEvent(button_, button_.Name + "_Click");
        }


        #region INIファイルの値を取得
        /// <summary>
        /// INIファイルの値を取得
        /// </summary>
        /// <param name="section">セクション</param>
        /// <param name="key">キー</param>
        /// <returns></returns>
        protected string GetIniFileValue(string section, string key)
        {
            return ini.GetString(section, key);
        }
        #endregion

        #region メッセージINIファイルの値を取得
        /// <summary>
        /// メッセージINIファイルの値を取得
        /// </summary>
        /// <param name="section">セクション</param>
        /// <param name="key">キー</param>
        /// <returns></returns>
        protected string GetMessageIniFileValue(string section, string key)
        {
            return myMsgIni.GetString(section, key);
        }
        #endregion

        #region 閉じる
        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region メニュー画面へ遷移
        /// <summary>
        /// メニュー画面へ遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betToMenu_Click(object sender, System.EventArgs e)
        {
            MenuMainFrm menu = new MenuMainFrm();
            menu.Show();
            this.Hide();
        }
        #endregion

        #region ログアウト
        /// <summary>
        /// ログアウト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            if( Application.OpenForms != null)
            {
                this.Owner = null;
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "LoginFrm")
                    {
                        this.Close();
                        LoginInfo.LoginInfoClear();
                        Application.OpenForms[i].Show();
                    }
                    else
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }
        #endregion

        #region 改ページ
        /// <summary>
        /// 改ページ
        /// 0:最初ページ
        /// 1:前頁
        /// 2:次頁
        /// 3:最後ページ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iBtnonType">
        /// </param>
        /// <param name="list">データリスト（行番号付き カラム名：RowNo）</param>
        /// <returns></returns>
        protected List<T> Paging<T>(int iBtnonType, List<T> list)
        {
            switch (iBtnonType)
            {
                case 0:
                    this.currentCount = 1;
                    break;
                case 1:
                    this.currentCount -= 1;
                    break;
                case 2:
                    this.currentCount += 1;
                    break;
                case 3:
                    this.currentCount = this.pageCount;
                    break;
            }
            return Binds(list);
        }

        /// <summary>
        /// 指定ページのデータ取得
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<T> Binds<T>(List<T> list)
        {
            List<T> result = new List<T>();
            // 総ページ数設定
            int count = list.Count;
            pageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(count) / currentPageCount));
            // ページ番号設定
            if (this.currentCount.Equals(0))
            {
                // 最初ページ
                this.currentCount = 1;
            }
            else if (this.currentCount.Equals(this.pageCount + 1))
            {
                // 最後ページ
                this.currentCount = this.pageCount;
            }
            else if (this.currentCount > 0 && this.currentCount < pageCount + 1)
            {
                int iRowNo = 0;
                // リストから行番号で検索
                foreach (var lt in list)
                {
                    var prop = lt.GetType().GetProperty(ConstCommon.ROW_NO);
                    int.TryParse(prop.GetValue(lt).ToString(), out iRowNo);
                    if (iRowNo > (this.currentCount - 1) * currentPageCount && iRowNo <= this.currentCount * currentPageCount)
                    {
                        result.Add(lt);
                    }
                }
            }

            return result;
        }
        #endregion

        #region 画面閉じる
        /// <summary>
        /// ベース画面閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        #region フォーム起動中チェック CheckDisplayingFrm
        /// <summary>
        /// フォーム起動中チェック
        /// </summary>
        /// <param name="frmName"></param>
        /// <returns></returns>
        protected Form CheckDisplayingFrm(string frmName)
        {
            Form frm = null;
            if (Application.OpenForms != null)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == frmName)
                    {
                        frm = f;
                        break;
                    }
                }
            }
            return frm;
        }
        #endregion
    }
}
