using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
#if false 
            List<Song> songs = new List<Song>();
            var song1 = new Song("アナと雪の女王", "アナ", 60);
            songs.Add(song1);
            var song2 = new Song("女々しくて", "ゴールデンボンバー", 60);
            songs.Add(song2);
            var song3 = new Song("アンパンマン", "食パンまん", 60);
            songs.Add(song3);
#endif
            var songs = new Song[] {
                new Song("女々しくて", "ゴールデンボンバー", 522),
                new Song("アナと雪の女王", "アナ", 312),
                new Song("アンパンマン", "食パンまん", 60),
            };

            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}", song.Title, song.ArtistName,TimeSpan.FromSeconds(song.Length));
                //Console.Write("{0},{1},",song.Title,song.ArtistName);
                //Console.WriteLine(TimeSpan.FromSeconds(song.Length).ToString(@"mm\:ss"));
            }
        }
    }
}
