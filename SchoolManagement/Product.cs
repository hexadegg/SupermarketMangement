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
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
            this.Purchasing = new HashSet<Purchasing>();
            this.Category = new HashSet<Category>();
        }
    
        public string Product_ID { get; set; }
        public bool Discount_Info { get; set; }
        public string Product_Name { get; set; }
        public Nullable<decimal> Selling_Price { get; set; }
        public string Depict { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string stock_ID { get; set; }
        public string Supplier_ID { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Purchasing> Purchasing { get; set; }
        public virtual ICollection<Category> Category { get; set; }
    }
}
