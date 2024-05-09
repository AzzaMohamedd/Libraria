using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;

namespace DAL
{
    interface IVisitorVMRepository
    {
        bool Add(VisitorVM vis);
    }
    public class VisitorVMRepository : IVisitorVMRepository
    {
        LibraryEntities db = new LibraryEntities();
        public bool Add(VisitorVM vis)
        {
            if (vis != null)
            {
                Visitor obj = new Visitor();
                obj.FirstName = vis.FirstName;
                obj.LastName = vis.LastName;
                obj.E_mail = vis.E_mail;
                obj.Password = vis.Password;
                db.Visitor.Add(obj);
                db.SaveChanges();
                return true;
            }
            else
                return false;
           
        }
    }
}
