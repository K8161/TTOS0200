using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T6
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public double InvoiceTotal { get; set; }

        public List<Product> Products { get; }

        public Invoice()
        {
            Products = new List<Product>();
        }

        //method to add products to Invoice
        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine("{0}: {1}e", product.Name, product.Price);

        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "\nCustomer: " + CustomerName + "\n";
            foreach (Product p in Products)
            {
                if (s != null) s += "\n-" + p.ToString();
                InvoiceTotal = InvoiceTotal + p.Total;
            }
            return s + "\nTotal sum: " + InvoiceTotal;
        }
    }
}
