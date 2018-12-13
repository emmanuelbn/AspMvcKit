using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Profilz.Models
{
    public class Dal : DbContext
    {

        #region 
        public DbSet<User> Users { get; set; }
        #endregion

        private static Dal _context;

        public static Dal Db
        {
            get
            {
                if (_context==null)
                {
                    _context = new Dal();
                }
                return _context;
            }
        }
        public Dal():base("mainTest")
        {

        }
        public Dal(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Dal>());
        }

        public bool Update(User source)
        {
            User dbItem = Users.Find(source.Id);
            if (dbItem != null)
            {
                dbItem.UpdateFrom(source);
                return true;
            }
            return false;
        }
    }
}