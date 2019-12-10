using Phonebook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data
{
    // Responsible for providing a list of contacts

    public class DataAccess
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
