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
    
    public partial class Indent
    {
        public Indent()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public string Order_ID { get; set; }
        public Nullable<decimal> TotalOrder_Money { get; set; }
        public System.DateTime Order_Date { get; set; }
        public string Payment_ID { get; set; }
        public string Employee_ID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
