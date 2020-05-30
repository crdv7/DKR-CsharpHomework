using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
  public  class ProductService
    {
        public static void Insert(Product product)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
            }catch(Exception e1)
            {
                throw new ApplicationException($"添加出现错误!");
            }
        }
        public static List<Product>GetAll()
        {
            using(var db=new OrderContext())
            {
                return db.Products.ToList();
            }
        }
    }
}
