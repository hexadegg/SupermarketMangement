//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Product = new HashSet<Product>();
            this.PurchaseOrder = new HashSet<PurchaseOrder>();
        }
    
        public string Supplier_ID { get; set; }
        public string Supplier_Phone { get; set; }
        public string Supplier_Name { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
