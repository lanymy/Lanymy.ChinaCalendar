using System;
using Lanymy.ChinaCalendar;
using Lanymy.Common.ExtensionFunctions;
using Lanymy.Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Converters;

namespace Lanymy.ChinaCalendarTests
{


    [TestClass()]
    public class ChinaCalendarTests
    {


        [TestMethod()]
        public void ChinaCalendarTest()
        {

            var todayDate = DateTime.Now.Date;
            var chinaCalendar = new LanymyChinaCalendar();
            //chinaCalendar.Test();
            var currentDateTime = chinaCalendar.GetToday();
            Assert.AreEqual(todayDate, currentDateTime.DateTimeID);

            currentDateTime = chinaCalendar.PreDay();
            Assert.AreEqual(todayDate.AddDays(-1), currentDateTime.DateTimeID);

            currentDateTime = chinaCalendar.NextDay();
            Assert.AreEqual(todayDate, currentDateTime.DateTimeID);


            todayDate = todayDate.AddDays(30);
            currentDateTime = chinaCalendar.GoTo(todayDate);
            Assert.AreEqual(todayDate, currentDateTime.DateTimeID);


        }



    }
}