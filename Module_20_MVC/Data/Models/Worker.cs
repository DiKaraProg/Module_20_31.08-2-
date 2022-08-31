using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Module_20_MVC.Data.Models
{
    public class Worker
    {
        int id;
        string lastName;
        string name;
        string fatherName;
        string phoneNumber;
        string address;
        string note;

        public int Id { get { return id; } set { id = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string FatherName { get { return fatherName; } set { fatherName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Note { get { return note; } set { note = value; } }
        public List<Worker> Workers { get; set; }
        public Worker Work { get; set; }

        public Worker(int id, string lastName, string name, string fathername, string phonenumber, string address, string note)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.fatherName = fathername;
            this.phoneNumber = phonenumber;
            this.address = address;
            this.note = note;

        }
        public Worker() { }
        public IEnumerable<Worker> AllWorkers()
        {
            string json = File.ReadAllText("wwwroot/json/json.json");
            
            Workers= JsonConvert.DeserializeObject<List<Worker>>(json);
            return Workers;
        }
        public Worker One_Worker(string id)
        {
            var workers = AllWorkers();
            foreach (var item in workers)
            {
                if (int.Parse(id) == item.id)
                {
                    Work = item;
                    return item;
                }
                
            }
            return null;
        }
    }

}
