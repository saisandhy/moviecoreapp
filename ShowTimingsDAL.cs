using CoreEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreData
{
    public class ShowTimingsDAL
    {
        MoviedbContext db = null;

        public ShowTimingsDAL()
        {
        }
        public ShowTimingsDAL(MoviedbContext db)
        {
            this.db = db;
        }
        public string AddShowtimming(ShowTiming showTiming)
        {

            // db = new MoviedbContext();
            db.showTimings.Add(showTiming);
            db.SaveChanges();
            return "added";
        }
        public string UpdateShowtimming(ShowTiming showTiming)
        {
            //db = new MoviedbContext();
            db.Entry(showTiming).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteShowtimming(int ShowTimingId)
        {
            // db = new MoviedbContext();
            ShowTiming showTimingObj = db.showTimings.Find(ShowTimingId);
            db.Entry(showTimingObj).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<ShowTiming> ShowAll()
        {
            //db = new MoviedbContext();
            List<ShowTiming> showTimingList = db.showTimings.ToList();
            return showTimingList;
        }
    }

}
