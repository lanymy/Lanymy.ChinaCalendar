using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanymy.ChinaCalendar.DbModels
{


    [Table("ChinaCalendar")]
    public class ChineseDateTimeDbModel : BaseDbModel
    {

        /// <summary>
        /// 日期
        /// </summary>
        [Key]
        public DateTime DateTimeID { get; set; }

        /// <summary>
        /// 农历年
        /// </summary>
        [Description("农历年")]
        public string ChineseYear { get; set; }

        /// <summary>
        /// 农历月
        /// </summary>
        [Description("农历月")]
        public string ChineseMonth { get; set; }

        /// <summary>
        /// 农历日
        /// </summary>
        [Description("农历日")]
        public string ChineseDay { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [Description("星期")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// 星座
        /// </summary>
        [Description("星座")]
        public string XingZuo { get; set; }

        /// <summary>
        /// 月名
        /// </summary>
        [Description("月名")]
        public string YueMing { get; set; }
        /// <summary>
        /// 物候
        /// </summary>
        [Description("物候")]
        public string WuHou { get; set; }
        /// <summary>
        /// 月相
        /// </summary>
        [Description("月相")]
        public string YueXiang { get; set; }
        /// <summary>
        /// 日禄
        /// </summary>
        [Description("日禄")]
        public string RiLu { get; set; }

        /// <summary>
        /// 彭祖百忌
        /// </summary>
        [Description("彭祖百忌")]
        public string PengZuBaiJi { get; set; }

        /// <summary>
        /// 相冲
        /// </summary>
        [Description("相冲")]
        public string XiangChong { get; set; }

        /// <summary>
        /// 岁煞
        /// </summary>
        [Description("岁煞")]
        public string SuiSha { get; set; }

        /// <summary>
        /// 星宿
        /// </summary>
        [Description("星宿")]
        public string XingXiu { get; set; }

        /// <summary>
        /// 空亡所值
        /// </summary>
        [Description("空亡所值")]
        public string KongWangSuoZhi { get; set; }

        /// <summary>
        /// 阴阳贵神值位
        /// </summary>
        [Description("阴阳贵神值位")]
        public string YinYangGuiShenZhiWei { get; set; }

        /// <summary>
        /// 宜
        /// </summary>
        [Description("宜")]
        public string Yi { get; set; }
        /// <summary>
        /// 忌
        /// </summary>
        [Description("忌")]
        public string Ji { get; set; }

        /// <summary>
        /// 吉神宜趋
        /// </summary>
        [Description("吉神宜趋")]
        public string JiShenYiQu { get; set; }

        /// <summary>
        /// 凶煞宜忌
        /// </summary>
        [Description("凶煞宜忌")]
        public string XiongShaYiJi { get; set; }

        /// <summary>
        /// 财神位
        /// </summary>
        [Description("财神位")]
        public string CaiShenWei { get; set; }



    }

}
