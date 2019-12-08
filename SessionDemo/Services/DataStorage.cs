using SessionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionDemo.Services
{
    public class DataStorage
    {
        private ApplicationDbContext _db;

        public DataStorage(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Student> FetchStudents()
        {
            return _db.Students.ToList();
        }


    }
}
