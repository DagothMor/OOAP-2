using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP
{
    internal class Task1
    {
        public void Run()
        {
            var person = new Person();
            var employee = new Employee();

            // Пример полиморфизма.
            sayName(employee);

            // Реализация композиции
            var myLibrary = new Library
            {
                Name = "Lib",
                BookShelves = new List<BookShelf>
    {
        new BookShelf
        {
            Number = 1,
            Books = new List<Book>
            {
                new Book
                {
                    Title = "BOOK",
                    Author = "Topse Cret",
                    YearPublished = 2019
                }
            }
        }
    }
            };
        }

        public void sayName(Person person)
        {
            Console.WriteLine(person.Name);
        }
    }


    class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    // Пример Наследования.
    class Employee : Person
    {

    }

    //___

    // Пример композиции:
    public class Library
    {
        public string Name { get; set; }

        public List<BookShelf> BookShelves { get; set; } = new List<BookShelf>();
    }

    public class BookShelf
    {
        public int Number { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int YearPublished { get; set; }
    }
}
