using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtOrders
    {
        public DtOrders()
        {
            DtOrderGoods = new HashSet<DtOrderGoods>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string TradeNo { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? PaymentId { get; set; }
        public decimal? PaymentFee { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentTime { get; set; }
        public int? ExpressId { get; set; }
        public string ExpressNo { get; set; }
        public decimal? ExpressFee { get; set; }
        public byte? ExpressStatus { get; set; }
        public DateTime? ExpressTime { get; set; }
        public string AcceptName { get; set; }
        public string PostCode { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
        public string Remark { get; set; }
        public byte? IsInvoice { get; set; }
        public string InvoiceTitle { get; set; }
        public decimal? InvoiceTaxes { get; set; }
        public decimal? PayableAmount { get; set; }
        public decimal? RealAmount { get; set; }
        public decimal? OrderAmount { get; set; }
        public int? Point { get; set; }
        public byte? Status { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public DateTime? CompleteTime { get; set; }

        public virtual ICollection<DtOrderGoods> DtOrderGoods { get; set; }
    }
}
