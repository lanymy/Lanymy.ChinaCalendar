using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanymy.ChinaCalendar.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Lanymy.ChinaCalendar
{


    public class LanymyChinaCalendar : IDisposable
    {

        private readonly ChinaCalendarDbContext _CurrentChinaCalendarDbContext;
        private readonly DbConnection _CurrentChinaCalendarDbContextDbConnection;


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

        public string GetToday()
        {
            return string.Empty;
        }

        public string PreDay()
        {
            return string.Empty;
        }

        public string NextDay()
        {
            return string.Empty;
        }

        public string GoTo()
        {
            return string.Empty;
        }

        public void Dispose()
        {
            _CurrentChinaCalendarDbContext?.Dispose();
        }
    }


}
