using System;
using System.Collections.Generic;

namespace Assignment_20
{


    /// <summary>
    /// Represents a Book in the library
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Available: {IsAvailable}";
        }
    }

    /// <summary>
    /// Represents a library member (base class)
    /// </summary>
    public abstract class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        protected Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public abstract void DisplayMemberType();
    }

    /// <summary>
    /// Represents a regular member (inherits from Member)
    /// </summary>
    public class RegularMember : Member
    {
        public RegularMember(int memberId, string name) : base(memberId, name) { }

        public override void DisplayMemberType()
        {
            Console.WriteLine($"{Name} is a Regular Member");
        }
    }

    /// <summary>
    /// Represents a premium member (inherits from Member)
    /// </summary>
    public class PremiumMember : Member
    {
        public PremiumMember(int memberId, string name) : base(memberId, name) { }

        public override void DisplayMemberType()
        {
            Console.WriteLine($"{Name} is a Premium Member");
        }
    }

    /// <summary>
    /// Represents a Book Transaction
    /// </summary>
    public class Transaction
    {
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Transaction(Member member, Book book)
        {
            Member = member;
            Book = book;
            BorrowDate = DateTime.Now;
        }

        public string GetStatus()
        {
            return ReturnDate == null ? "Pending" : "Returned";
        }

        public override string ToString()
        {
            return $"Member: {Member.Name}, Book: {Book.Title}, Borrowed: {BorrowDate}, " +
                   $"Returned: {(ReturnDate.HasValue ? ReturnDate.Value.ToString() : "Not yet")}, Status: {GetStatus()}";
        }
    }

    /// <summary>
    /// Interface for library operations
    /// </summary>
    public interface ILibraryOperations
    {
        void AddBook(Book book);
        void RemoveBook(int id);
        void RegisterMember(Member member);
        void LendBook(int bookId, int memberId);
        void ReturnBook(int bookId, int memberId);
        void ShowAllTransactions();
    }

    /// <summary>
    /// Main Library class implementing ILibraryOperations
    /// </summary>
    public class Library : ILibraryOperations
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();
        private List<Transaction> transactions = new List<Transaction>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added successfully!");
        }

        public void RemoveBook(int id)
        {
            Book book = books.Find(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Book '{book.Title}' removed successfully!");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void RegisterMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.Name}' registered successfully!");
        }

        public void LendBook(int bookId, int memberId)
        {
            try
            {
                Book book = books.Find(b => b.Id == bookId);
                Member member = members.Find(m => m.MemberId == memberId);

                if (book == null || member == null)
                    throw new Exception("Invalid Book ID or Member ID!");

                if (!book.IsAvailable)
                    throw new Exception("Book is not available!");

                book.IsAvailable = false;
                Transaction transaction = new Transaction(member, book);
                transactions.Add(transaction);

                Console.WriteLine($"Book '{book.Title}' lent to {member.Name} successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void ReturnBook(int bookId, int memberId)
        {
            Transaction transaction = transactions.Find(t => t.Book.Id == bookId && t.Member.MemberId == memberId && t.ReturnDate == null);
            if (transaction != null)
            {
                transaction.Book.IsAvailable = true;
                transaction.ReturnDate = DateTime.Now;
                Console.WriteLine($"Book '{transaction.Book.Title}' returned successfully by {transaction.Member.Name}!");
            }
            else
            {
                Console.WriteLine("No active transaction found for this book and member!");
            }
        }

        public void ShowAllTransactions()
        {
            Console.WriteLine("\n--- Transaction History ---");
            foreach (var t in transactions)
            {
                Console.WriteLine(t);
            }
        }
    }

    /// <summary>
    /// Main Program class
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books
            library.AddBook(new Book(1, "C# Programming", "Nishil Maharjan"));
            library.AddBook(new Book(2, "AI Fundamentals", "Rita KC"));

            // Registering members
            library.RegisterMember(new RegularMember(101, "Nishil Maharjan"));
            library.RegisterMember(new PremiumMember(102, "Binesh Rai"));

            // Lending books
            library.LendBook(1, 101);
            library.LendBook(2, 102);

            // Returning a book
            library.ReturnBook(1, 101);

            // Show all transactions
            library.ShowAllTransactions();
        }
    }

}