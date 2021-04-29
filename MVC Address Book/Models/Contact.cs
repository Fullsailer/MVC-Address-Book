using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Address_Book.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int HomePhone { get; set; }
        public int WorkPhone { get; set; }
        public int CellPhone { get; set; }
        public int FaxNumber { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string ContactCategory { get; set; }
        public Category Category { get; set; }
    }
}
