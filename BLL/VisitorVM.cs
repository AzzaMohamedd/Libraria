using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class VisitorVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string E_mail { get; set; }
        public string Password { get; set; }
    }
}
