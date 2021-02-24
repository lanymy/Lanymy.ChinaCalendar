using Microsoft.EntityFrameworkCore;

namespace Lanymy.ChinaCalendar.DbModels
{

    public class ChinaCalendarDbContext : DbContext
    {

        private static string _CurrentConnectionString;

        public ChinaCalendarDbContext(string connectionString)
        {

            _CurrentConnectionString = connectionString;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_CurrentConnectionString);
        }

        public DbSet<ChineseDateTimeDbModel> ChineseDateTimes { get; set; }


    }


}
