using CoreData;
using CoreEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CoreData
{
    
    public class UserDAL
    { 
        MoviedbContext db = null;
        public UserDAL()
        {

        }
        public UserDAL(MoviedbContext db)
        {
            this.db = db;
        }
        public string AddUser(User user)
        {

            // db = new MoviedbContext();
            db.users.Add(user);
            db.SaveChanges();
            return "added";
        }
        public string UpdateUser(User user)
        {
            //db = new MoviedbContext();
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteUser(int UserId)
        {
            // db = new MoviedbContext();
           User userObj = db.users.Find(UserId);
            db.Entry(userObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<User> ShowAll()
        {
            //db = new MoviedbContext();
            List<User> userList = db.users.ToList();
            return userList;

        }
    }
   
}
