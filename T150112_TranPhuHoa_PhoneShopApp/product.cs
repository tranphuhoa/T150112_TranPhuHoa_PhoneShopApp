//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T150112_TranPhuHoa_PhoneShopApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Warranty { get; set; }
        public string Price { get; set; }
        public string Situation { get; set; }
        public int Manufacturer_ID { get; set; }
        public byte[] Image { get; set; }
    
        public virtual manufacturer manufacturer { get; set; }
    }
}
