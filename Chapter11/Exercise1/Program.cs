using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Member = x.Element("teammembers")
                                    });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Member.Value);
            }

        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var sportlists = xdoc.Root.Elements()
                                        .Select(x => new {
                                            Name = x.Element("name").Attribute("kanji").Value,
                                            Year = x.Element("firstplayed").Value
                                        }).OrderBy(x => x.Year);
            foreach (var sportlist in sportlists) {
                Console.WriteLine("{0}({1})", sportlist.Name, sportlist.Year);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sport = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = x.Element("name").Value,
                                        member = x.Element("teammembers").Value
                                    }).OrderByDescending(x => int.Parse(x.member)).First();

            Console.WriteLine("{0} ({1}人)",sport.Name,sport.member);

        }


        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);
            var soccer = new XElement("file",
                                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                new XElement("teammembers", "11"),
                                new XElement("fistplayed", "1863")
                                );
            
            xdoc.Root.Add(soccer);
            xdoc.Save("sports.xml");
            //foreach (var xsportlist in xdoc.Root.Elements()) {
            //    var name = xsportlist.Element("name");
            //    var member = xsportlist.Element("teammembers");
            //    Console.WriteLine("{0} {1}", name.Value, member.Value);
            //}
        }
    }
}
