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
    
    public partial class Category
    {
        public Category()
        {
            this.Product = new HashSet<Product>();
        }
    
        public string Category_ID { get; set; }
        public string Classification_Standard { get; set; }
        public string Category_Name { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
