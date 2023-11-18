using System;
using System.IO;

namespace BillingSystem
{
    public class CommonUtil
    {
        #region バイナリファイルを読み込みバイト配列
        /// <summary>
        /// バイナリファイルを読み込みバイト配列
        /// </summary>
        /// <param name="strFilePath">ファイルフルパス</param>
        /// <returns></returns>
        public byte[] ReadBinary(string strFilePath)
        {
            byte[] data = null;
            try
            {
                if (File.Exists(strFilePath))
                {
                    //ファイルをメモリへ読み込む
                    using (FileStream fs = new FileStream(strFilePath, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        //バイナリ形式でプログラム内に読み込む
                        BinaryReader br = new BinaryReader(fs);
                        //ファイルサイズを求める
                        FileInfo fi = new FileInfo(strFilePath);
                        long filesize = fi.Length;
                        data = new byte[filesize];

                        fs.Read(data, 0, data.Length);
                        fs.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return data;
        }
        #endregion

        #region バイナリ(Byte配列)出力(ファイル全部を１回で書込む)
        /// <summary>
        /// バイナリ(Byte配列)出力(ファイル全部を１回で書込む)
        /// </summary>
        /// <param name="fpath">ファイルPATH</param>
        /// <param name="dt">出力するByte配列データ</param>
        public void WriteBinary(string fpath, byte[] dt)
        {
            Stream sw = null;
            BinaryWriter bw = null;
            try
            {
                sw = File.Open(fpath, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(sw);
                bw.Write(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (bw != null) bw.Close();
                if (sw != null) sw.Close();
            }
        }
        #endregion

        #region ファイル存在チェック
        /// <summary>
        /// ファイル存在チェック
        /// </summary>
        /// <param name="strFilePath"></param>
        /// <returns></returns>
        public bool IsFileExist(string strFilePath)
        {
            if (File.Exists(strFilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
