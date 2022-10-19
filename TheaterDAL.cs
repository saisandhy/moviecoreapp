using CoreEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreData
{
    public class TheaterDAL
    {

        MoviedbContext db = null;
        public TheaterDAL()
        {
        }
        public TheaterDAL(MoviedbContext db)
        {
            this.db = db;
        }

        public string AddTheater(Theater theater)
        {

            // db = new MoviedbContext();
            db.theaters.Add(theater);
            db.SaveChanges();
            return "added";
        }
        public string UpdateTheater(Theater theater)
        {
            //db = new MoviedbContext();
            db.Entry(theater).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteTheater(int TheaterId)
        {
            // db = new MoviedbContext();
            Theater theaterObj = db.theaters.Find(TheaterId);
            db.Entry(theaterObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Theater> ShowAll()
        {
            //db = new MoviedbContext();
            List<Theater> theaterList = db.theaters.ToList();
            return theaterList;

        }
    }
}
