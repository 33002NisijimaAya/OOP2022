﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {
        public string Title { get; set; }//歌のタイトル
        public string ArtistName { get; set; }//アーティスト名
        public int Length { get; set; }//演奏時間（秒）

        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }
    }
}
