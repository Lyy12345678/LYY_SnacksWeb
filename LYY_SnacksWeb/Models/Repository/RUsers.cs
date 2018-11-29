using LYY_SnacksWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYY_SnacksWeb.Models
{
    public class RUsers:IUsers
    {
        SnackEntities1 db = new SnackEntities1();
       void IUsers.Create(Users users)
        {
            db.Users.Add(users);
            db.SaveChanges();
            //return true;
            
        }
    
    }
}