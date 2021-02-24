using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanymy.ChinaCalendar.Abstractions
{

    public class ChineseDateTimeModel
    {

        /// <summary>
        /// 当前阳历日期
        /// </summary>
        public DateTime CurrentDateTime { get; set; }

        /// <summary>
        /// 农历年
        /// </summary>
        public string ChineseYear { get; set; }

        /// <summary>
        /// 农历月
        /// </summary>
        public string ChineseMonth { get; set; }

        /// <summary>
        /// 农历日
        /// </summary>
        public string ChineseDay { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }





    }

}
