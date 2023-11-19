using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BillingSystem.BLL;
using BillingSystem.Models;
using BillingSystem.Models.TableModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BillingSystem
{
    public partial class SeikyuEditFrm : BillingSystem.BaseFrom.BaseFrm
    {
        SeikyuEditBLL BLL = new SeikyuEditBLL();
        /// <summary>
        /// SeikyuFrmからのID受け取り用
        /// </summary>
        public string ID { get; set; }
        public int LockVer;
        public bool errorFlg = false;

        /// <summary>
        /// 0:詳細ボタン
        /// 1:新規作成ボタン
        /// 2:新規複写ボタン
        /// </summary>
        public string Mode {  get; set; }
        public SeikyuEditFrm(string mode, string id = null)
        {
            InitializeComponent();
            this.ID = id;

            DgbBillingDetail.AutoGenerateColumns = false;

            // 口座一覧コンボックス値取得
            BankAccountModel BankAccountInputData = new BankAccountModel();
            List<BankAccountModel> BankAccountData = BLL.GetBankAccountName(BankAccountInputData);
            BankAccountModel addData = new BankAccountModel { BankName = "--------------------選択してください--------------------" };
            BankAccountData.Insert(0,addData);
            CmbBankAccount.DataSource = BankAccountData;

            // 支払い条件名コンボックス値取得
            PaymentTypeModel PaymentTypeInputData = new PaymentTypeModel();
            List<PaymentTypeModel> PaymentTypeData = BLL.GetPaymentInfo(PaymentTypeInputData);
            PaymentTypeModel addData2 = new PaymentTypeModel { PaymentTypeName = "--------------------選択してください--------------------" };
            PaymentTypeData.Insert(0, addData2);
            CmbPaymentType.DataSource = PaymentTypeData;

            // プロジェクト名一覧コンボックス値取得
            ProjectModel ProjectInputData = new ProjectModel();
            List<ProjectModel> ProjectData = BLL.GetProjectInfo (ProjectInputData);
            ProjectModel addData3 = new ProjectModel { ProjectName = "--------------------選択してください--------------------" };
            ProjectData.Insert(0, addData3);
            CmbProjectName.DataSource = ProjectData;

            // 部署一覧コンボックス値取得
            DepartmentModel DepartmentInputData = new DepartmentModel();
            List<DepartmentModel> DepartmentData = BLL.GetDepartmentInfo(DepartmentInputData);
            DepartmentModel addData4 = new DepartmentModel { DepartmentName = "--------------------選択してください-------------------" };
            DepartmentData.Insert(0, addData4);
            CmbDepartment.DataSource = DepartmentData;

            // 請求先名称一覧コンボックス値取得
            CustomerModel CustomerInputData = new CustomerModel();
            List<CustomerModel> CustomerData = BLL.GetCustomerInfo(CustomerInputData);
            CustomerModel addData5 = new CustomerModel { CustomerName = "--------------------選択してください--------------------" };
            CustomerData.Insert(0, addData5);
            CmbCustomerName.DataSource = CustomerData;
            
            // 担当者名一覧コンボックス値取得
            UserModel ManagerInputData = new UserModel();
            List<UserModel> ManagerData = BLL.GetUserInfo(ManagerInputData);
            UserModel addData6 = new UserModel { UserName = "--------------------選択してください--------------------" };
            ManagerData.Insert(0, addData6);
            CmbManagerName.DataSource = ManagerData;



            if (mode == Common.UpdateModeConst.Edit)//詳細ボタン処理
            {

                //詳細を表示するレコードデータ取得
                SeikyuEditBillingModel SeikyuInputData = new SeikyuEditBillingModel();
                SeikyuInputData.ID = id;
                List<SeikyuEditBillingModel> BillingData = BLL.GetBillingDetail(SeikyuInputData);

                //各項目データを変数に格納
                DateTime BillingDate = BillingData[0].BillingDate;
                string BillingNo = BillingData[0].BillingNo;
                string BranchNo = BillingData[0].BranchNo;
                string OrderNo = BillingData[0].OrderNo;
                string ProjectContent = BillingData[0].ProjectContent;
                string ProjectAdd = BillingData[0].ProjectAdd;
                string Deliverables = BillingData[0].Deliverables;
                string CustomeID = BillingData[0].CustomeID;
                string ManagerID = BillingData[0].ManagerID;
                string AccountID = BillingData[0].BankAccountID;
                string PaymentType = BillingData[0].PaymentType;
                this.LockVer = BillingData[0].LockVer;

                DateTime firstDayOfMonth = new DateTime(BillingDate.Year, BillingDate.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                DtpProjectStartDate.Value = firstDayOfMonth;
                DtpProjectEndDate.Value = lastDayOfMonth;

                //各項目データを表示
                DtbBillingDate.Text = BillingDate.ToString();
                TxtBillingNo.Text = BillingNo;
                TxtBranchNo.Text = BranchNo;
                CmbCustomerName.SelectedValue = CustomeID;
                CmbManagerName.SelectedValue = ManagerID;
                CmbProjectName.SelectedValue = OrderNo;
                CmbDepartment.SelectedValue = CustomeID;
                TxtOrderNo.Text = OrderNo;
                TxtProjectContent.Text = ProjectContent;
                TxtProjectAdd .Text = ProjectAdd;
                TxtDelivarables .Text = Deliverables;
                CmbBankAccount.SelectedValue = AccountID;
                CmbPaymentType.SelectedValue = PaymentType;

                //詳細明細をグリットビューに表示
                string TargetID = BillingData[0].ID;
                SeikyuEditDetailsModel DetailInputData = new SeikyuEditDetailsModel();
                DetailInputData.ID = TargetID;
                List<SeikyuEditDetailsModel> BillingDetail = BLL.GetBillingGdbDetail(DetailInputData);
                DgbBillingDetail.DataSource = BillingDetail;

                int BillingAmount = 0;
                int Transportion = 0;

                //金額計算
                foreach (var item in BillingDetail)
                {
                    BillingAmount += item.BillingAmount;
                    Transportion += item.TransportationAmount;
                }

                TxtAllBillingAmount.Text = BillingAmount.ToString("N0");
                TxtAllBillingTax.Text = (BillingAmount * 0.1).ToString("N0");
                TxtAllBillingTransportion.Text = Transportion.ToString("N0");
                TxtAllBillingTotal.Text = (BillingAmount + BillingAmount * 0.1 + Transportion).ToString("N0");

                BaseFromInitialize("請求書作成(編集)", ButtonData.GetSeikyuEditFrm("0", LoginInfo.Department));
            }
            else if(mode == Common.UpdateModeConst.New)//新規作成ボタン処理
            {
                BaseFromInitialize("請求書作成(新規)", ButtonData.GetSeikyuEditFrm("0", LoginInfo.Department));

            }
            else if(mode == Common.UpdateModeConst.Copy)//新規複写ボタン処理
            {
                BaseFromInitialize("請求書作成(複写)", ButtonData.GetSeikyuEditFrm("0", LoginInfo.Department));
            }

            CmbCustomerName.SelectedIndexChanged += ChangeCustomerName;
        }


        public void RemoveEvent(object sender, EventArgs e)
        {
            // ログ出力
            log.Info("test");
           
        }


        public void BtnApproval_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public void BtnComplete_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public void BtnSended_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public void BtnSave_Click(object sender, EventArgs e)
        {
            validation();

            //入力された値を取得
            DateTime BillingDate = DateTime.Parse(DtbBillingDate.Text);
            string BillingNo = TxtBillingNo.Text;
            string BranchNo = TxtBranchNo.Text;
            string CustomerID = CmbCustomerName.SelectedValue.ToString();
            string CustomerName = CmbCustomerName.Text;
            string ManagerID = CmbManagerName.SelectedValue.ToString();
            string DepartmentName = CmbDepartment.Text;
            string OrderNo = TxtOrderNo.Text;
            string ProjectName = CmbProjectName.Text;
            string ProjectContent = TxtProjectContent.Text;
            string ProjectAdd = TxtProjectAdd.Text;
            string Delivarables = TxtDelivarables.Text;
            string BankAccountID = CmbBankAccount.SelectedValue.ToString();
            string PaymentType = CmbPaymentType.SelectedValue.ToString();
            string PaymentTyoeName = CmbPaymentType.Text;

            DateTime firstDayOfMonth = new DateTime(BillingDate.Year, BillingDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // 請求一覧更新
            SeikyuEditBillingModel InsertData = new SeikyuEditBillingModel();
            InsertData.BillingDate = BillingDate;
            InsertData.BillingFromDate = firstDayOfMonth;
            InsertData.BillingToDate = lastDayOfMonth;
            InsertData.BillingNo = BillingNo;
            InsertData.BranchNo = BranchNo;
            InsertData.CustomeID = CustomerID;
            InsertData.CustomerName = CustomerName;
            InsertData.ManagerID = ManagerID;
            InsertData.DepartmentName = DepartmentName;
            InsertData.OrderNo = OrderNo;
            InsertData.ProjectName = ProjectName;
            InsertData.ProjectContent = ProjectContent;
            InsertData.ProjectAdd = ProjectAdd;
            InsertData.Deliverables = Delivarables;
            InsertData.BankAccountID = BankAccountID;
            InsertData.PaymentType = PaymentType;
            InsertData.PaymentTypeName = PaymentTyoeName;
            InsertData.PaymentDate = lastDayOfMonth;
            InsertData.BillingAmount = 0;
            InsertData.Tax = 0;
            InsertData.BillingTax = 0;
            InsertData.TransportationAmount = 0;
            InsertData.BillingTotal = 0;
            InsertData.Status = "";
            
            InsertData.ID = ID;

            BLL.BillingInsert(InsertData);

            this.Close();

        }

        public void BtnUpdate_Click(object sender, EventArgs e)
        {
            //排他処理
            SeikyuEditBillingModel InputLockVerData = new SeikyuEditBillingModel();
            InputLockVerData.ID = ID;
            List<SeikyuEditBillingModel> LockVerData = BLL.GetLockVer(InputLockVerData);

            //先にレコード更新されていた場合はエラー
            if(LockVerData[0].LockVer != LockVer)
            {
                MessageBox.Show("エラーが発生しました");
                this.Close();
                return;
            } 

            //バリデーション
            validation();
            if (errorFlg == true)
            {
                MessageBox.Show("項目を全て入力してください");
                return;
            }

            var aaa = LoginInfo.LoginID;

            //入力値取得
            DateTime BillingDate = DateTime.Parse(DtbBillingDate.Text);
            string BillingNo = TxtBillingNo.Text;
            string BranchNo = TxtBranchNo.Text;
            string CustomerID = CmbCustomerName.SelectedValue.ToString();
            string ManagerID = CmbManagerName.SelectedValue.ToString();
            string OrderNo = TxtOrderNo.Text;
            string ProjectContent = TxtProjectContent.Text;
            string ProjectAdd = TxtProjectAdd.Text;
            string Delivarables = TxtDelivarables.Text;
            string BankAccountID = CmbBankAccount.SelectedValue.ToString();
            string PaymentType = CmbPaymentType.SelectedValue.ToString();

            // 請求一覧更新
            SeikyuEditBillingModel UpdateData = new SeikyuEditBillingModel();
            UpdateData.BillingDate = BillingDate;
            UpdateData.BillingNo = BillingNo;
            UpdateData.BranchNo = BranchNo;
            UpdateData.CustomeID = CustomerID;
            UpdateData.ManagerID = ManagerID;
            UpdateData.OrderNo = OrderNo;
            UpdateData.ProjectContent = ProjectContent;
            UpdateData.ProjectAdd = ProjectAdd;
            UpdateData.Deliverables = Delivarables;
            UpdateData.BankAccountID = BankAccountID;
            UpdateData.PaymentType = PaymentType;
            UpdateData.ID = ID;

            int aa = BLL.BillingUpdate(UpdateData);

            //LockVerに+1
            SeikyuEditBillingModel UpdateLockVerParam = new SeikyuEditBillingModel();
            UpdateLockVerParam.LockVer = LockVer+1;
            UpdateLockVerParam.ID = ID;
            BLL.LockVerUpdate(UpdateLockVerParam);

            this.Close();

        }

        public void BtnDelete_Click(object sender, EventArgs e)
        {
            SeikyuEditBillingModel DeleteData = new SeikyuEditBillingModel();
            DeleteData.ID = ID;
            int aa = BLL.BillingDelete(DeleteData) ;
            this.Close();

        }


        public void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void ChangeCustomerName(object sender, EventArgs e)
        {
            string CustomerID = "";

            if (CmbCustomerName.SelectedValue != null)
            {
                CustomerID = CmbCustomerName.SelectedValue.ToString();

                CustomeModel CustomeInputData = new CustomeModel();
                CustomeInputData.ID = CustomerID;
                List<CustomeModel> CustomeData = BLL.ChangeCustomerName(CustomeInputData);

                CmbDepartment.SelectedValue = CustomeData[0].ID;
                CmbProjectName.SelectedValue = CustomeData[0].OrderNo;
                TxtOrderNo.Text = CustomeData[0].OrderNo;
                TxtProjectContent.Text = CustomeData[0].ProjectContent;
                TxtProjectAdd.Text = CustomeData[0].ProjectAdd;
                TxtDelivarables.Text = CustomeData[0].Deliverables;
            }

        }

        private void validation()
        {
            if (CmbManagerName.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (CmbCustomerName.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (CmbProjectName.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (CmbDepartment.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (TxtOrderNo.Text == null)
            {
                errorFlg = true;
            }

            if (TxtProjectContent.Text == null)
            {
                errorFlg = true;
            }

            if (TxtProjectAdd.Text == null)
            {
                errorFlg = true;
            }

            if (TxtDelivarables.Text == null)
            {
                errorFlg = true;
            }

            if (CmbPaymentType.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (CmbBankAccount.SelectedValue == null)
            {
                errorFlg = true;
            }

            if (errorFlg == true)
            {
                MessageBox.Show("項目を全て入力してください");
                return;
            }
        }
    }
}
