//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LYY_SnacksWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int CartID { get; set; }
        public string UserID { get; set; }
        public int GoodsID { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> flag { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual Users Users { get; set; }
    }
}
