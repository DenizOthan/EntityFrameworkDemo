using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; }//Primary key = o tablodaki kaydı diğerlerinden ayıran özellik
        public int CategoryId { get; set; }// Foreign key=başka tabloyla ilişkilendirme alanı
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }


    }
}
