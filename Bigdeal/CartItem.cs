using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bigdeal
{
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public CartItem(int productId, string productName, decimal price, int quantity)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{ProductName} - Quantity: {Quantity} - Price: {Price:C}";
        }
    }

}

