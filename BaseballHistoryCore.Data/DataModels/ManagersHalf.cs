﻿using System;
using System.Collections.Generic;

namespace BaseballHistoryCore.Data.DataModels
{
    public partial class ManagersHalf
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public short Inseason { get; set; }
        public short Half { get; set; }
        public short? G { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public short? Rank { get; set; }

        public virtual Master Player { get; set; }
        public virtual Team Teams { get; set; }
    }
}
