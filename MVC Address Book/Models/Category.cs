using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Address_Book.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }




        public ICollection<Contact> Contact { get; set; } = new HashSet<Contact>();
    }
}
