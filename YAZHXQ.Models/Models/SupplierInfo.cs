using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SupplierInfo
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string PostCode { get; set; }
        public string RegAddr { get; set; }
        public string CompanyTel { get; set; }
        public string TaxId { get; set; }
        public string FaxNum { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceAddr { get; set; }
        public string Corporate { get; set; }
        public string Contacts { get; set; }
        public string LinkTel { get; set; }
        public string CompanyNature { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
