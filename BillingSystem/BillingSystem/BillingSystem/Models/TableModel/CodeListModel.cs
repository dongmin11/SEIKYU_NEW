namespace BillingSystem.Models
{
    /// <summary>
    /// コードマスタ
    /// </summary>
    public class CodeListModel
    {
        /// <summary>
        /// 区分ID
        /// </summary>
        public string KindID { get; set; }

        /// <summary>
        /// コード
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 表示順
        /// </summary>
        public int Sort { get; set; }
    }
}
