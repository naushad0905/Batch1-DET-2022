using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LINQ
    {
        public static void Main()
        {

            #region Linq Query Data Source, Creation, Deffered, Early, Lamda Exp
            // The Three parts of a LINQ Query: Deffered Execution
            // // 1. Data Source.
            //List<int> numbers = new List<int>();
            //numbers.Add(110);
            //numbers.Add(100);
            //numbers.Add(105);
            //numbers.Add(102);

            ////2.Query Creation.SQL type
            //var numQuery = from num in numbers // select num from numbers
            //               select num;

            //Lamda Exp
            //var numQuery = numbers.Select(x => x);

            //Lamda Exp
            //var numQuery = numbers.Where(x => x > 102);

            ////2a.Early Creation. SQL type
            //var numQuery = from num in numbers // select num from numbers
            //               where num > 102
            //               select num;

            //numbers.Add(200);

            ////3.Query execution.
            //foreach (int num in numQuery)
            //{
            //    Console.WriteLine("{0} ", num);
            //    num.Dump(); // This is for LINQpad not for VS
            //}
            //Console.ReadLine();
            #endregion


            #region OrderBy

            //int[] numbers = { 9, 7, 8, 5 };

            //var result = numbers.OrderBy(n => n);

            //Console.WriteLine("Ordered list of numbers:");
            //foreach (int number in result)
            //    Console.WriteLine(number);
            #endregion


            #region OrderByDescending

            //string[] names = { "Tabrez", "Syed Naushad", "Irfan", "Noor", "Mateen", "Misbha" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);

            #endregion


            #region Reverse

            //char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            //var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Console.WriteLine(character);

            #endregion


            #region ThenBy

            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);

            #endregion


            #region ThenByDescending

            //    var dates = new DateTime[] {
            //new DateTime(2015, 3, 1),
            //new DateTime(2014, 7, 1),
            //new DateTime(2013, 5, 1),
            //new DateTime(2015, 1, 1),
            //new DateTime(2015, 7, 1)
            //    };

            //    var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            //    Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            //    foreach (DateTime dt in result)
            //        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
            #endregion


            #region Skip

            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.Skip(4);

            //Console.WriteLine("Skips the first 4 words:");
            //foreach (string word in result)
            //    Console.WriteLine(word);

            #endregion


            #region SkipWhile

            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Console.WriteLine(word);
            #endregion


            #region Take

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.Take(5);

            //Console.WriteLine("Takes the first 5 numbers only:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region TakeWhile

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.TakeWhile(n => n < 5);

            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region Aggregate (simple)

            //var numbers = new int[] { 1, 2, 3, 4, 5 };

            //var result = numbers.Aggregate((a, b) => a * b);

            //Console.WriteLine("Aggregated numbers by multiplication:");
            //Console.WriteLine(result);

            #endregion


            #region Average

            ////int[] numbers = { 10, 10, 20, 20 };

            ////var result = numbers.Average();

            ////Console.WriteLine("Average is:");
            ////Console.WriteLine(result);

            #endregion


            #region Count

            //string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim", "Allen" };

            //var result = names.Count();  //Returns the number of elements in a collection

            //Console.WriteLine("Counting names gives:");
            //Console.WriteLine(result);

            #endregion


            #region Max

            //int[] numbers = { 2, 8, 5, 9, 6, 1 };

            //var result = numbers.Max();  //Finds the largest value in a collection

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);

            #endregion


            #region Min

            //int[] numbers = { 6, 9, 3, 7, 5 };

            //var result = numbers.Min();  //Finds the smallest value in a collection.

            //Console.WriteLine("Lowest number is:");
            //Console.WriteLine(result);

            #endregion


            #region Sum

            //int[] numbers = { 2, 5, 10 };

            //var result = numbers.Sum();  //Calculates the total for a numeric collections

            //Console.WriteLine("The Total of numbers in collection is :");
            //Console.WriteLine(result);

            #endregion


            #region ElementAt

            //string[] words = { "One", "Two", "Three" };

            //var result = words.ElementAt(1);  //Retrieves the specified element from a collection of Array

            //Console.WriteLine("Element at index 1 in the array is:");
            //Console.WriteLine(result);

            #endregion


            #region ElementAtOrDefault

            //string[] colors = { "Red", "Green", "Blue" };

            //var resultIndex1 = colors.ElementAtOrDefault(1);

            //var resultIndex10 = colors.ElementAtOrDefault(10);  //Returns the specified index element in a sequence or a default value if the index is out of range

            //Console.WriteLine("Element at index 1 in the array contains:");
            //Console.WriteLine(resultIndex1);

            //Console.WriteLine("Element at index 10 in the array does not exist:");
            //Console.WriteLine(resultIndex10 == null);

            #endregion


            #region First (simple)

            //string[] fruits = { "Banana", "Apple", "Orange" };

            //var result = fruits.First();

            //Console.WriteLine("First element in the array is:");
            //Console.WriteLine(result);

            #endregion


            #region First (conditional)

            //string[] countries = { "Denmark", "Sweden", "Norway" };

            //var result = countries.First(c => c.Length == 6);

            //Console.WriteLine("First element with a length of 6 characters:");
            //Console.WriteLine(result);

            #endregion


            #region FirstOrDefault

            //string[] countries = { "Denmark", "Sweden", "Norway" };
            //string[] empty = { };

            //var result = countries.FirstOrDefault();

            //var resultEmpty = empty.FirstOrDefault(); //Returns the first element of a sequence, or a specified default value if the sequence contains no elements.

            //Console.WriteLine("First element in the countries array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("First element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);

            #endregion


            #region Last

            //int[] numbers = { 7, 3, 5 };

            //var result = numbers.Last();

            //Console.WriteLine("Last number in array is:");
            //Console.WriteLine(result);

            #endregion


            #region LastOrDefault (simple

            //string[] words = { "one", "two", "three" };
            //string[] empty = { };

            //var result = words.LastOrDefault();

            //var resultEmpty = empty.LastOrDefault();

            //Console.WriteLine("Last element in the words array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);

            #endregion


            #region LastOrDefault (cond.)

            //string[] words = { "one", "two", "three" };

            //var result = words.LastOrDefault(w => w.Length == 3);

            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            //Console.WriteLine("Last element in the words array having a length of 3:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            //Console.WriteLine(resultNoMatch == null);

            #endregion


            #region Single

            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.Single();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //try
            //{
            //    var resultEmpty = empty.Single();  // This will throw an exception because array contains no elements
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    var result3 = names3.Single();  // This will throw an exception as well because array contains more than one element
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion


            #region SingleOrDefault

            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.SingleOrDefault();

            //var resultEmpty = empty.SingleOrDefault();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            //Console.WriteLine(resultEmpty == null);

            //try
            //{
            //    var result3 = names3.SingleOrDefault();  // This will throw an exception as well because array contains more than one element
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion


            #region All

            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.All(n => n.StartsWith("B"));

            //Console.WriteLine("Does all of the names start with the letter 'B':");
            //Console.WriteLine(result);

            #endregion


            #region Any

            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.Any(n => n.StartsWith("B"));

            //Console.WriteLine("Does any of the names start with the letter 'B':");
            //Console.WriteLine(result);

            #endregion


            #region Contains

            //int[] numbers = { 1, 3, 5, 7, 9 };

            //var result = numbers.Contains(5);

            //Console.WriteLine("sequence contains the value 5:");
            //Console.WriteLine(result);

            #endregion


            #region Distinct

            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            //var result = numbers.Distinct();

            //Console.WriteLine("Distinct removes duplicate elements:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region Except

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Except(numbers2);

            //Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region Intersect

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Intersect(numbers2);

            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region Union

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Union(numbers2);

            //Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            #endregion


            #region In a array of names, find the names which contains 'o'

            //string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            //var names1 = from n in names
            //             where n.Contains("o")
            //             select n;

            //foreach (string n in names1)
            //{
            //    Console.WriteLine("sequence contains the value o:");
            //    Console.WriteLine(n);
            //}

            #endregion


            #region In a array of names, find the names which has max no of character length

            //string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson", "Syed Naushad" };
            //var names1 = names.OrderByDescending(x => x.Length);
            //var biggest = names1.Take(1);

            //foreach (var name in biggest)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion



            #region Segrigating words with there starting letter

            //List<string> words = new List<string> { "basket", "blueberry", "chimpaze", 
            //    "abacus", "banana", "apple", "cheese"};
            //var wordGroups = words.GroupBy(x => x[0]).Select
            //    (y => new { FirstLetter = y.Key, Words = y });

            //foreach (var item in wordGroups)
            //{
            //    Console.WriteLine("Worlds that start with the" + "letter '{0}' : ", item.FirstLetter);

            //    foreach( var w in item.Words)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}

            #endregion

            #region Segrigating words with there Length/Number of letter


            //List<string> words = new List<string> { "basket", "blueberry", "chimpaze",
            //    "abacus", "banana", "apple", "cheese"};
            //var wordGroups = words.GroupBy(x => x.Length).Select
            //   (y => new { lengthOfWords = y.Key, Words = y });



            #endregion

        }
    }
}
