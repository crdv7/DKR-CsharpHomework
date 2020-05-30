using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
   public class ClientService
    {
        public static void Add(Client client)
        {
            try
            {
                using(var db=new OrderContext())
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                }
            }catch(Exception e)
            {
                throw new ApplicationException($"添加错误!");
            }
        }
        public static List<Client> GetAll()
        {
            using(var db=new OrderContext())
            {
                return db.Clients.ToList();
            }
        }
    }
}
