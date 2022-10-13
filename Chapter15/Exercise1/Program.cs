using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books.First(b => b.Price == Library.Books.Max(x => x.Price));
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var selected = Library.Books.GroupBy(b => b.PublishedYear);

            foreach (var item in selected.OrderBy(b => b.Key)) {
                Console.WriteLine("{0}年 {1}冊", item.Key, item.Count());
            }
        }

        private static void Exercise1_4() {
            var years = new List<int>();
            var selected = Library.Books
                        .Join(Library.Categories,       //結合する2番目のシーケンス
                            book => book.CategoryId,    //対象シーケンスの結合キー
                            category => category.Id,    //2番目のシーケンスの結合キー
                            (book, category) => new {
                                book.Title,
                                CategoryName = category.Name,
                                book.PublishedYear,
                                book.Price
                            }
                        );

            foreach (var book in selected.OrderByDescending(x => x.PublishedYear).ThenByDescending(x => x.Price)) {
                Console.WriteLine($" {book.PublishedYear}年 {book.Price}円 {book.Title} ({book.CategoryName})");
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                                .Where(b => b.PublishedYear == 2016)
                                .Join(Library.Categories,
                                      book => book.CategoryId,
                                      Category => Category.Id,
                                      (book, category) => category.Name)
                                .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var query = Library.Books
                         .Join(Library.Categories,
                            book => book.CategoryId,
                            category => category.Id,
                            (book, category) => new {
                                book.Title,
                                book.PublishedYear,
                                book.Price,
                                categoryName = category.Name
                            })
                         .GroupBy(x => x.categoryName)
                         .OrderBy(x => x.Key);

            foreach (var group in query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine(" {0}", item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                                .Where(b => b.CategoryId == categoryId)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);

            foreach (var group in groups) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var book in group) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }
        private static void Exercise1_8() {
            var query = Library.Categories
                                .GroupJoin(Library.Books,
                                           c => c.Id,
                                           b => b.CategoryId,
                                           (c, b) => new {
                                               CategoryName = c.Name,
                                               Count = b.Count(),
                                           })
                                .Where(x => x.Count >= 4);

            foreach (var category in query) {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
