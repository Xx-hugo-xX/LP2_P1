﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LP2_P1
{
    public struct TitleEpisode
    {
        public string Tconst { get; }
        public string ParentTconst { get; }
        public int? SeasonNumber { get; }
        public int? EpisodeNumber { get; }

        public TitleEpisode(string tconst, string parentTconst,
            int? seasonNumber = null, int? episodeNumber = null)
        {
            Tconst = tconst;
            ParentTconst = parentTconst;
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodeNumber;
        }
    }
}
