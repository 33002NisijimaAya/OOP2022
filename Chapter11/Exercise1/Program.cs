using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xsportlists = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Member = x.Element("teammembers")
                                    });
            foreach (var sportlist in xsportlists) { 
                Console.WriteLine("{0} {1}", sportlist.Name,sportlist.Member.Value);
            }

        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sportlists = xdoc.Root.Elements()
                                        .Select(x => new {
                                            Name = (string)x.Element("name").Attribute("kanji"),
                                            Year = (string)x.Element("firstplayed")
                                        }).OrderBy(x=>x.Year);
            foreach (var sportlist in sportlists) {
                Console.WriteLine("{0}({1})", sportlist.Name,sportlist.Year);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var maxmember = xdoc.Root.Elements()
                                    .Select(x=> new {
                                        Name = (string)x.Element("name"),
                                        member = x.Element("teammembers")
                                    }).Max();
            Console.WriteLine(maxmember.Name);
        }

        private static void Exercise1_4(string file, string newfile) {

        }
    }
}
