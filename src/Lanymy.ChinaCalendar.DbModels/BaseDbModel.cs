using System;
using Lanymy.Common.Abstractions.Interfaces;

namespace Lanymy.ChinaCalendar.DbModels
{
    public abstract class BaseDbModel : ITimestampProperties, IIsDeleteProperties
    {

        public DateTime CreateDateTime { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
