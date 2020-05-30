
using System.Collections.Generic;

using System;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement
{
    public class Client {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public Client() {
            ID = Guid.NewGuid().ToString();
        }
        public Client(string name):this()
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   ID == client.ID &&
                   Name == client.Name;
        }


        public override string ToString()
        {
            return string.Format("用户ID:{0}\t用户名:{1}", ID, Name);
        }

        public override int GetHashCode()
        {
            int hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
