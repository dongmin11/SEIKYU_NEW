using BillingSystem.Menu;
using System;
using System.Windows.Forms;

namespace BillingSystem
{
    static class Program
    {        
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Mutex名を決める（必ずアプリケーション固有の文字列に変更すること！）
            string mutexName = "BillingSystem";
            //Mutexオブジェクトを作成する
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, mutexName);

            bool hasHandle = false;
            try
            {
                //ミューテックスの所有権を要求する
                hasHandle = mutex.WaitOne(0, false);
            }
            //.NET Framework 2.0以降の場合
            catch (System.Threading.AbandonedMutexException)
            {
                //別のアプリケーションがミューテックスを解放しないで終了した時
                hasHandle = true;
            }
            //ミューテックスを得られたか調べる
            if (hasHandle == false)
            {
                //得られなかった場合は、すでに起動していると判断して終了
                MessageBox.Show("多重起動はできません。");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFrm());
        }
    }
}
