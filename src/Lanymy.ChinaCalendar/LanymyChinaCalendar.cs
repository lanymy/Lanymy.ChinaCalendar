using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanymy.ChinaCalendar.Abstractions;
using Lanymy.ChinaCalendar.DbModels;
using Lanymy.Common.ExtensionFunctions;
using Lanymy.Common.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Lanymy.ChinaCalendar
{


    public class LanymyChinaCalendar : IDisposable
    {

        private readonly ChinaCalendarDbContext _CurrentChinaCalendarDbContext;
        private readonly DbConnection _CurrentChinaCalendarDbContextDbConnection;
        private DateTime _CurrentDateTime = DateTime.Now.Date;


        public LanymyChinaCalendar()
        {

            _CurrentChinaCalendarDbContext = GlobalSettings.GetChinaCalendarDbContext();
            _CurrentChinaCalendarDbContextDbConnection = _CurrentChinaCalendarDbContext.Database.GetDbConnection();

        }

        private void CheckDbConnection()
        {
            if (_CurrentChinaCalendarDbContextDbConnection.State != ConnectionState.Open)
            {
                _CurrentChinaCalendarDbContextDbConnection.Open();
            }
        }


        public ChineseDateTimeModel GetToday()
        {
            return GoTo(DateTime.Now);
        }

        public ChineseDateTimeModel PreDay()
        {
            return GoTo(_CurrentDateTime.AddDays(-1));
        }

        public ChineseDateTimeModel NextDay()
        {
            return GoTo(_CurrentDateTime.AddDays(1));
        }

        public ChineseDateTimeModel GoTo(DateTime dt)
        {
            _CurrentDateTime = dt.Date;
            CheckDbConnection();
            var dtTemp = _CurrentChinaCalendarDbContext.ChineseDateTimes.Where(o => o.DateTimeID == _CurrentDateTime).FirstOrDefault();
            return dtTemp.IfIsNullOrEmpty() ? new ChineseDateTimeModel { DateTimeID = _CurrentDateTime } : dtTemp.DeepClone<ChineseDateTimeDbModel, ChineseDateTimeModel>();
        }

        public void Dispose()
        {
            _CurrentChinaCalendarDbContext?.Dispose();
        }
    }


}
