﻿using BillingSystem.BaseFrom;
using BillingSystem.BLL;
using BillingSystem.Master;
using BillingSystem.Models;
using Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class SeikyuFrm : BaseFrm
    {
        SeikyuBLL BLL = new SeikyuBLL();

        //改ページ判定用
        private int StartRow = 0;

        public SeikyuFrm()
        {
            InitializeComponent();

            DgbBillingInfoGridView.AutoGenerateColumns = false;

            //フッターのボタン表示
            BaseFromInitialize("請求書検索", ButtonData.GetSeikyuFrm());
            
            //画面初期表示設定
            PageInitialSetting();
        }

        #region イベント
        /// <summary>
        /// 検索機能ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchButton_Click(object sender, EventArgs e)
        {
            StartRow = 0;

            SearchLoadRecords();

            LblDisplayCount.Text = currentCount.ToString();
            LblTotalCount.Text = pageCount.ToString();
            if (currentCount != pageCount)
            {
                BtnNextButton.Enabled = true;
            }
            else
            {
                BtnNextButton.Enabled = false;
            }
            BtnPreviousButton.Enabled = false;
        }

        /// <summary>
        /// 次頁押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNextButton_Click_1(object sender, EventArgs e)
        {
            StartRow = 2;

            SearchLoadRecords();

            BtnPreviousButton.Enabled = true;

            if (currentCount != pageCount)
            {
                BtnNextButton.Enabled = true;
            }
            else
            {
                BtnNextButton.Enabled = false;
            }

            LblDisplayCount.Text = currentCount.ToString();
            LblTotalCount.Text = pageCount.ToString();
        }

        /// <summary>
        /// 前頁押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreviousButton_Click_1(object sender, EventArgs e)
        {
            StartRow = 1;

            BtnNextButton.Enabled = true;

            SearchLoadRecords();

            if (currentCount != 1)
            {
                BtnPreviousButton.Enabled = true;
            }
            else
            {
                BtnPreviousButton.Enabled = false;
            }

            LblDisplayCount.Text = currentCount.ToString();
            LblTotalCount.Text = pageCount.ToString();
        }

        /// <summary>
        /// 請求開始日変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtbBillingStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = DtbBillingStartDate.Value;
            DtbBillingEndDate.MinDate = startDate;
        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 詳細ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnDetail_Click(object sender, EventArgs e)
        {
            var selectedRow = DgbBillingInfoGridView.SelectedRows[0];
            string billingID = selectedRow.Cells["ID"].Value.ToString();
            SeikyuEditFrm SeikyuEditFrm = new SeikyuEditFrm(Common.UpdateModeConst.Edit, billingID);
            SeikyuEditFrm.Show(this);
        }

        /// <summary>
        /// 新規登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnInsert_Click(object sender, EventArgs e)
        {
            SeikyuEditFrm SeikyuEditFrm = new SeikyuEditFrm(Common.UpdateModeConst.New);
            SeikyuEditFrm.Show(this);
        }

        public void BtnCopy_Click(object sender, EventArgs e)
        {
            var selectedRow = DgbBillingInfoGridView.SelectedRows[0];
            var billingID = selectedRow.Cells["ID"].Value.ToString();
            SeikyuEditFrm SeikyuEditFrm = new SeikyuEditFrm(Common.UpdateModeConst.Copy, billingID);
            SeikyuEditFrm.Show(this);
        }

        /// <summary>
        /// 印刷ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnPrint_Click(object sender, EventArgs e)
        {
            //印刷処理

            //TODO
        }

        private void SeikyuFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //呼出元表示
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.TopMost = true;
            }
        }
        #endregion

        #region privateメソッド
        #region 画面初期処理 PageInitialSetting
        /// <summary>
        /// 画面初期処理
        /// </summary>
        private void PageInitialSetting()
        {
            try
            {
                // 請求先名称一覧取得
                SeikyuCustomerModel customerInputData = new SeikyuCustomerModel();
                List<SeikyuCustomerModel> CustomerData = BLL.GetCustomerInfo(customerInputData);

                //請求先一覧に全選択項目追加
                SeikyuCustomerModel addData = new SeikyuCustomerModel { CustomerName = "全て", ID = "0" };
                CustomerData.Insert(0, addData);
                CbbxBillingRecipient.DataSource = CustomerData;

                // 請求先名称一覧取得
                SeikyuUserModel UserInputData = new SeikyuUserModel();
                List<SeikyuUserModel> UserData = BLL.GetUserName(UserInputData);

                SeikyuUserModel addData2 = new SeikyuUserModel { UserName = "全て", ID = "0" };
                UserData.Insert(0, addData2);
                cmbAssignee.DataSource = UserData;

                //開始日時の初期値を今月の1日
                DtbBillingStartDate.Format = DateTimePickerFormat.Custom;
                DtbBillingStartDate.CustomFormat = "yyyy年MM月dd日";
                DtbBillingStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DtbBillingEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DtbBillingStartDate.Text = DtbBillingStartDate.Value.ToString("yyyy年MM月dd日");

                //終了日時の初期値を今月の最終日に
                DtbBillingEndDate.Format = DateTimePickerFormat.Custom;
                DtbBillingEndDate.CustomFormat = "yyyy年MM月dd日";
                DateTime today = DateTime.Today;
                DtbBillingEndDate.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
                DtbBillingEndDate.Text = DtbBillingEndDate.Value.ToString("yyyy年MM月dd日");

                LblDisplayCount.Text = "0";
                LblTotalCount.Text = "0";
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0001);
                MessageBox.Show(msg); ;
            }
        }
        #endregion

        #region  請求一覧表示 SearchLoadRecords
        /// <summary>
        /// 請求一覧表示
        /// </summary>
        private void SearchLoadRecords()
        {
            try
            {
                //請求開始日時取得
                string billingStartDateText = DtbBillingStartDate.Text;
                DateTime billingStartDate = DateTime.Parse(billingStartDateText);
                billingStartDateText = billingStartDate.ToString("yyyy-MM-dd");

                //請求終了日時取得
                string billingEndDateText = DtbBillingEndDate.Text;
                DateTime billingEndDate = DateTime.Parse(billingEndDateText);
                billingEndDateText = billingEndDate.ToString("yyyy-MM-dd");

                //選択された請求先取得
                string selectedBillingRecipient = CbbxBillingRecipient.SelectedValue.ToString();

                string UserID = cmbAssignee.SelectedValue.ToString();

                int StatusProgress = 10;
                int StatusPendingApproval = 10;
                int StatusApproved = 10;
                int StatusCompleted = 10;
                int StatusSent = 10;

                SeikyuSearchBillingModel inputData = new SeikyuSearchBillingModel();

                //状態判定
                if (chkInProgress.Checked == true)
                {
                    StatusProgress = 0;
                    inputData.StatusFlg2 = true;
                }

                if (chkPendingApproval.Checked == true)
                {
                    StatusPendingApproval = 1;
                    inputData.StatusFlg2 = true;
                }

                if (chkApproved.Checked == true)
                {
                    StatusApproved = 2;
                    inputData.StatusFlg2 = true;
                }

                if (chkCompleted.Checked == true)
                {
                    StatusCompleted = 3;
                    inputData.StatusFlg2 = true;
                }

                if (chkSent.Checked == true)
                {
                    StatusSent = 9;
                    inputData.StatusFlg2 = true;
                }

                //請求一覧取得
                inputData.DeleteFlag = CkbxShowDeleted.Checked;
                inputData.StartDate = billingStartDateText;
                inputData.EndDate = billingEndDateText;
                inputData.CustomerID = selectedBillingRecipient;
                inputData.StartRow = StartRow;
                inputData.chkInProgress = StatusProgress;
                inputData.chkPendingApproval = StatusPendingApproval;
                inputData.chkApproved = StatusApproved;
                inputData.chkCompleted = StatusCompleted;
                inputData.chkSent = StatusSent;
                inputData.UserID = UserID;

                List<SeikyuSearchBillingModel> BillingData = BLL.SearchGetBillingInfo(inputData);

                int rowNumber = 1;

                //データテーブルに行番号を設定
                foreach (var item in BillingData)
                {
                    item.RowNo = rowNumber;
                    rowNumber++;
                }

                //改ページ
                BillingData = Paging(StartRow, BillingData);

                DgbBillingInfoGridView.DataSource = BillingData;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                string msg = myMsgIni.GetString(ConstCommon.MESSAGE, ConstCommon.IMG0001);
                MessageBox.Show(msg); ;
            }
        }
        #endregion
        #endregion

    }
}
