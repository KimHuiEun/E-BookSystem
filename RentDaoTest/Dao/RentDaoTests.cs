using Microsoft.VisualStudio.TestTools.UnitTesting;
using EBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDaoTest
{
    [TestClass()]
    public class RentDaoTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            Assert.Fail();
        }

        public void GetWithExtraTest()
        {

        }

        public void GetCount()
        {
            int count = Dao.Rent.GetCount();

            Assert.IsTrue(count > 0);
        }


    }
}