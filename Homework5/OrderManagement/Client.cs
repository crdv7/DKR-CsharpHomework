
using System.Collections.Generic;

using System;
namespace OrderManagement
{
    public class Client {
        public string Id { get; }
        public string Name { get; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Client(string name, string address, string phoneNumber)
        {
            Random rd = new Random();
            Id = rd.Next(1000).ToString().PadLeft(3, '0');
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   Id == client.Id &&
                   Name == client.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 222782879;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format("用户ID:{0}\t用户名:{1}\t用户地址{2}\t用户电话{3}", Id, Name, Address, PhoneNumber);
        }
    }
}
