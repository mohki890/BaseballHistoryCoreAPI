﻿namespace BaseballHistoryCore.Data.DataModels
{
    public class AwardsShareManager
    {
        public string PlayerId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string AwardId { get; set; }
        public short? PointsWon { get; set; }
        public short? PointsMax { get; set; }
        public short? VotesFirst { get; set; }

        public virtual Master Player { get; set; }
    }
}
