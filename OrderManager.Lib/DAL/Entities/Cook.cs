using System;

namespace OrderManager.Lib.DAL.Entities
{
    public class Cook
    {
        public int Id { get; set; }

        public float SkillCoefficient { get; set; }   

        public DateTime FinishTime { get; set; }
    }

}

