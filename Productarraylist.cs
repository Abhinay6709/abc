using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab7q2
{
    class Productarraylist
    {
        ArrayList products = new ArrayList();
        public void Addingproduct(Product product)
        {
            products.Add(product);

        }
        public Product Searchproduct(int id)
        {
            Product product = new Product();
            foreach (Product p in products)
            {
                if (p.ProductNo == id)
                {
                    product = p;
                }

            }
            return product;

        }




        public bool Deleteproduct(int id)

        {
            Product product = null;
            foreach (Product p in products)
            {
                if (p.ProductNo == id)
                {
                    product = p;
                    break;
                }
            }
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateandsaveProduct(int pid, double price, int stock)
        {
            Product product = null;
            foreach (Product p in products)
            {
                if (p.ProductNo == pid)
                {
                    product = p;
                    break;
                }
            }
            if (product != null)
            {
                products.Remove(product);

                product.rate = price;
                product.stock = stock;
                products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveInOrder(Product product)
        {
            products.Add(product);
            var List = (from Product i in products orderby i.ProductNo select i).ToList();
            products = new ArrayList(List);
            foreach(Product p in products)
            {
                Console.WriteLine($"ID:{p.ProductNo},Nmae:{p.Productname},Price:{p.rate},Stock:{p.stock}");
            }
           
        }
    }
}


