using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class bookclass
    {
       

        public static void Main()
        {
            //AddNewBook();
            //DeleteBook();
            //UpdateBook();
            //GetAllBooks();
            //AddnewCustomerAndOrder();
            //AddOrder();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            Console.ReadLine();
        }

        #region Add New Book

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 5;
        //    book.BookName = "DF Core";
        //    book.author = "Jack";
        //    book.price = 500;

        //    try
        //    {
        //        ctx.Books.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Book Added succesfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        #endregion



        #region Delet Book

        //public static void DeleteBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 1;
        //    book.BookName = "EF Core";
        //    book.author = "Jack";
        //    book.price = 100;

        //    try
        //    {
        //        ctx.Books.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Book deletion successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        #endregion



        #region Update Book

        //public static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    book.BookID = 2;
        //    book.BookName = "Core";
        //    book.author = "Jhon";
        //    book.price = 600;

        //    try
        //    {
        //        ctx.Books.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Book Updation successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        #endregion



        #region Get All Books

        //public static void GetAllBooks()

        //{

        //    var ctx = new BookContext();
        //    var Books = ctx.Books;


        //    foreach (var b in Books)
        //    {
        //        Console.WriteLine(b.BookName);
        //        Console.WriteLine(b.BookID);
        //    }
        //}
        #endregion



        #region Add new Customer And Order

        //private static void AddnewCustomerAndOrder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 2;
        //    customer.Name = "Jaleel";
        //    customer.Age = 22;

        //    Order ord = new Order();
        //    ord.Order_ID = 200;
        //    ord.Amount = 288238;
        //    ord.OrderDate = DateTime.Now;


        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and Order is Created");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message); 
        //    }
        //}
        #endregion



        #region GetAllCustomersWithOrder_EagertLoading
        //private static void AddOrder()
        //{
        //    //Eager loading means that the related data is loaded
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");



        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion



        #region GetAllCustomersWithOrder_ExplicitLoading

        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());


        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        #endregion


        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();


            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();


            ctx.Dispose();


            UpdateCustomerName(customer);
        }

        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Jack";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            // ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }

    }
}
