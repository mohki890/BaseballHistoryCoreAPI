﻿namespace BaseballHistoryCore.Data.DataModels
{
    public class SeriesPost
    {
        public string TeamIdwinner { get; set; }
        public string LgIdwinner { get; set; }
        public short YearId { get; set; }
        public string Round { get; set; }
        public string TeamIdloser { get; set; }
        public string LgIdloser { get; set; }
        public short? Wins { get; set; }
        public short? Losses { get; set; }
        public short? Ties { get; set; }

        public virtual Team Teams { get; set; }
        public virtual Team TeamsNavigation { get; set; }
    }
}
