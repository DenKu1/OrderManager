using System;

namespace OrderManager.Lib.DAL.Entities
{
    public class Cooker
    {
        public int Id { get; set; }
       
        public TimeSpan WarmUpTime { get; set; }

        public TimeSpan CoolingTime { get; set; }

        public int CookerTypeId { get; set; }
        public CookerType CookerType { get; set; }       

        public DateTime FinishTime { get; set; }
    }
}
