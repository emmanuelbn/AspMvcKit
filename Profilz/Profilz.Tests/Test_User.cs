using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Profilz.Models;

namespace Profilz.Tests
{
    [TestClass]
    public class Test_User
    {
        [TestMethod]
        public void Test_Create_User()
        {

            User user = new User() { Username = "Dylan", Email = "d@d.d", Password = "123465789" };
            Dal.Db.Users.Add(user);
            Dal.Db.SaveChanges();
        }
        [TestMethod]
        public void Test_Update_User()
        {
            User userchange = Dal.Db.Users.Find(1);
            userchange.Email = "ffff@fff.f";
            Dal.Db.Update(userchange);
            Dal.Db.SaveChanges();
        }
        [TestMethod]
        public void Test_Remove_User()
        {
            Dal.Db.Users.Remove(Dal.Db.Users.Find(3));
            Dal.Db.SaveChanges();
        }
    }
}
