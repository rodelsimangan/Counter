using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Counter.Models
{
    public class CounterRepository : ICounterRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public Counter GetCounter()
        {
            db = new ApplicationDbContext();
            var counter = db.Counter.AsNoTracking().FirstOrDefault();
            db.Dispose();
            return counter;
        }

        public void UpdateCounter(Counter input)
        {
            db = new ApplicationDbContext();
            db.Entry(input).State = EntityState.Modified;
            db.SaveChanges();
            db.Dispose();
        }
    }
}