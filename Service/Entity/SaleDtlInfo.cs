using System;

namespace Service.Entity
{
    public class SaleDtlInfo
    {
        private Int32 proId;
        private string proName;
        private string supplierName;
        private string specName;
        private string unitName;
        private decimal quantity;
        private decimal unitPrice;
        private decimal discount;
        private decimal paidIn;
        /// <summary>
        /// 编号
        /// </summary>
        public int ProId { get => proId; set => proId = value; }
        /// <summary>
        /// 品名
        /// </summary>
        public string ProName { get => proName; set => proName = value; }
        /// <summary>
        /// 厂商
        /// </summary>
        public string SupplierName { get => supplierName; set => supplierName = value; }
        /// <summary>
        /// 规格
        /// </summary>
        public string SpecName { get => specName; set => specName = value; }
        /// <summary>
        /// 单位
        /// </summary>
        public string UnitName { get => unitName; set => unitName = value; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get => quantity; set => quantity = value; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Discount { get => discount; set => discount = value; }
        /// <summary>
        /// 折扣价
        /// </summary>
        public decimal PaidIn { get => paidIn; set => paidIn = value; }
    }
}
