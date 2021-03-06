﻿using System.Collections.Generic;

namespace BaseballHistoryCore.API.ViewModels
{
    public class TeamViewModel
    {
        public string TeamId { get; set; }
        public string LgId { get; set; }
        public short YearId { get; set; }
        public string FranchId { get; set; }
        public string DivId { get; set; }
        public short? Rank { get; set; }
        public short? G { get; set; }
        public short? Ghome { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public string DivWin { get; set; }
        public string Wcwin { get; set; }
        public string LgWin { get; set; }
        public string Wswin { get; set; }
        public short? R { get; set; }
        public short? Ab { get; set; }
        public short? H { get; set; }
        public short? _2B { get; set; }
        public short? _3B { get; set; }
        public short? Hr { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Hbp { get; set; }
        public short? Sf { get; set; }
        public short? Ra { get; set; }
        public short? Er { get; set; }
        public double? Era { get; set; }
        public short? Cg { get; set; }
        public short? Sho { get; set; }
        public short? Sv { get; set; }
        public int? Ipouts { get; set; }
        public short? Ha { get; set; }
        public short? Hra { get; set; }
        public short? Bba { get; set; }
        public short? Soa { get; set; }
        public int? E { get; set; }
        public int? Dp { get; set; }
        public double? Fp { get; set; }
        public string Name { get; set; }
        public string Park { get; set; }
        public int? Attendance { get; set; }
        public int? Bpf { get; set; }
        public int? Ppf { get; set; }
        public string TeamIdbr { get; set; }
        public string TeamIdlahman45 { get; set; }
        public string TeamIdretro { get; set; }

        public virtual ICollection<AllstarFullViewModel> AllstarFull { get; set; }
        public virtual ICollection<AppearanceViewModel> Appearances { get; set; }
        public virtual ICollection<BattingViewModel> Batting { get; set; }
        public virtual ICollection<BattingPostViewModel> BattingPost { get; set; }
        public virtual ICollection<FieldingViewModel> Fielding { get; set; }
        public virtual ICollection<FieldingOFsplitViewModel> FieldingOfsplit { get; set; }
        public virtual ICollection<FieldingPostViewModel> FieldingPost { get; set; }
        public virtual ICollection<HomeGameViewModel> HomeGames { get; set; }
        public virtual ICollection<ManagerViewModel> Managers { get; set; }
        public virtual ICollection<ManagersHalfViewModel> ManagersHalf { get; set; }
        public virtual ICollection<PitchingViewModel> Pitching { get; set; }
        public virtual ICollection<PitchingPostViewModel> PitchingPost { get; set; }
        public virtual ICollection<SalaryViewModel> Salaries { get; set; }
        public virtual ICollection<SeriesPostViewModel> SeriesPostTeams { get; set; }
        public virtual ICollection<SeriesPostViewModel> SeriesPostTeamsNavigation { get; set; }
        public virtual ICollection<TeamsHalfViewModel> TeamsHalf { get; set; }
        public virtual TeamFranchiseViewModel Franch { get; set; }
    }
}
