using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Linq2Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators
            #region Num1
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category)
            //    .Select(p => new
            //    {
            //        p.Key,
            //        NumOfUnits = p.Count()
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Num2
            //var result = from p in ListGenerator.ProductsList
            //             let CheapPrice = ListGenerator.ProductsList.Min(p => p.UnitPrice)
            //             where p.UnitPrice == CheapPrice
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.UnitPrice);
            //}
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into groupbyCat
            //             let minPriceInCategory = groupbyCat.Min(p => p.UnitPrice)
            //             from p in groupbyCat
            //             where p.UnitPrice == minPriceInCategory
            //             select new
            //             {
            //                 Category = groupbyCat.Key,
            //                 CheapestProduct = minPriceInCategory
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Num3
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into groupbyCat
            //             let minPriceInCategory = groupbyCat.Min(p => p.UnitPrice)
            //             from p in groupbyCat
            //             where p.UnitPrice == minPriceInCategory
            //             select new
            //             {
            //                 Category = groupbyCat.Key,
            //                 CheapestProduct = p
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Num4
            //var result = from p in ListGenerator.ProductsList
            //             let MaxPrice = ListGenerator.ProductsList.Max(p => p.UnitPrice)
            //             where p.UnitPrice == MaxPrice
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.UnitPrice);
            //}
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into groupbyCat
            //             let MaxPriceInCategory = groupbyCat.Max(p => p.UnitPrice)
            //             from p in groupbyCat
            //             where p.UnitPrice == MaxPriceInCategory
            //             select new
            //             {
            //                 Category = groupbyCat.Key,
            //                 CheapestProduct = MaxPriceInCategory
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Num5
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category
            //           into Maxproduct
            //             select new
            //             {
            //                 Maxproduct.Key,
            //                 MaxProductPrice = Maxproduct.Max(p => p.UnitPrice)

            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into groupbyCat
            //             let maxPriceInCategory = groupbyCat.Max(p => p.UnitPrice)
            //             from p in groupbyCat
            //             where p.UnitPrice == maxPriceInCategory
            //             select new
            //             {
            //                 Category = groupbyCat.Key,
            //                 MaxProduct = p
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Num6
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into groupbyCat
            //             let avgPriceInCategory = groupbyCat.Average(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = groupbyCat.Key,
            //                 AveragePrice = avgPriceInCategory
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = ListGenerator.ProductsList.
            //            Average(p => p.UnitPrice);
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Num1
            //var result=ListGenerator.ProductsList.Select(p=>p.Category).Distinct();
            //foreach (var item in result) { 

            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Num2
            //var seq1=ListGenerator.ProductsList.Select(x => x.ProductName.First());
            //var seq2=ListGenerator.CustomersList.Select(x => x.CustomerName.First());
            //var uniqeLetter=seq1.Concat(seq2).Distinct();
            //uniqeLetter=seq1.Union(seq2);
            //foreach (var item in uniqeLetter) { 
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Num3
            //var seq1 = ListGenerator.ProductsList.Select(x => x.ProductName.First());
            //var seq2 = ListGenerator.CustomersList.Select(x => x.CustomerName.First());
            //var intersectLetter = seq1.Intersect(seq2);
            //Console.WriteLine("The common First Letter");

            //foreach (var item in intersectLetter)
            //{
            //    Console.Write($"{item},");
            //}
            #endregion
            #region Num4
            //var Seq1 = ListGenerator.ProductsList.Select(x => x.ProductName.First());
            //var Seq2 = ListGenerator.CustomersList.Select(x => x.CustomerName.First());
            //var ExceptLetter = Seq1.Except(Seq2);
            //Console.WriteLine("The Except First Letter");

            //foreach (var item in ExceptLetter)
            //{
            //    Console.Write($"{item},");
            //}

            #endregion
            #region Num5
            //var Seq1 = ListGenerator.ProductsList.Select(x =>string.Concat(x.ProductName.TakeLast(3)));
            //var Seq2 = ListGenerator.CustomersList.Select(x =>string.Concat(x.CustomerName.TakeLast(3)));
            //var TheLastThreeLetters = Seq1.Concat(Seq2);
            //Console.WriteLine("The Except First Letter");

            //foreach (var item in TheLastThreeLetters)
            //{
            //    Console.Write($"{item},");
            //} 
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Num1
            //var Result = ListGenerator.CustomersList
            //    .Where(x => x.Region == "WA")
            //    .Select(x => x.Orders).Take(3);
            //Console.WriteLine("Orders from the first 3 customers in Washington:");
            //foreach (var orders in Result)
            //{
            //    foreach (var order in orders)
            //    {
            //        Console.WriteLine($"{order}");
            //    }
            //}
            //Console.WriteLine("//////////////////////////////////");
            //var Result2 = ListGenerator.CustomersList.Where(x => x.Region == "WA").Select(x => x.CustomerName);
            //foreach (var item in Result2) { Console.WriteLine(item); }
            //var Result1 = ListGenerator.CustomersList.Where(x => x.Region == "WA").SelectMany(x => x.Orders);
            //foreach (var item in Result1) { Console.WriteLine(item); }

            #endregion
            #region Num2
            //Console.WriteLine("Orders from the first 2 customers in Washington:");

            //var result = ListGenerator.CustomersList.Where(x => x.Region == "WA").SelectMany(x => x.Orders).Skip(2);
            //foreach (var order in result)
            //{
            //    Console.WriteLine($"{order}");
            //} 
            #endregion
            #region Num3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num > index);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion
            #region Num4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=numbers.SkipWhile(x=>x%3!=0);
            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //} 
            #endregion
            #region Num5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((num, index) => num > index);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region Num1
            //string[] words = File.ReadAllLines("dictionary_english.txt ");
            //bool isContain=words.Any(x=>x.Contains("ei"));
            //if (isContain) {
            //    Console.WriteLine("Yes there is at least one word contain this substring");
            //} else {
            //    Console.WriteLine("No there isn't  at least one word contain this substring");

            //}
            #endregion
            #region Num2
            //var Resultt = ListGenerator.ProductsList.GroupBy(x => x.Category).Where(p => p.Any(p => p.UnitsInStock == 0)).
            //    Select(x => new
            //    {
            //        x.Key,
            //        Product = x
            //    });
            //foreach (var item in Resultt)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item.Product)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}
            #endregion
            #region Num3
            //var resultt = ListGenerator.ProductsList.GroupBy(x => x.Category).Where(p => p.All(p => p.UnitsInStock>0)).
            //    Select(x => new
            //    {
            //        x.Key,
            //        Product = x
            //    });
            //foreach (var item in resultt)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item.Product)
            //    {
            //        Console.WriteLine(product);
            //    }
            //} 
            #endregion
            #endregion
            #region LINQ – Grouping Operators
            #region Num1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result=numbers.GroupBy(x => x%5).Select(x=>x);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion
            #region Num2
            //string[] words = File.ReadAllLines("dictionary_english.txt ");
            //var result=words.GroupBy(x=>x.First());
            //foreach (var word in result)
            //{
            //    Console.WriteLine($"Group by {word.Key}");
            //    foreach (var item in word)
            //    {
            //        Console.WriteLine(item);
            //    }
            //} 
            #endregion
            #region Num3
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var result = Arr.Select(x=>x.Trim()).GroupBy(word => string.Concat(word.OrderBy(c => c)));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Group({group.Key}):");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"  {item}");
            //    }
            //    Console.WriteLine(".....");
            //} 
            #endregion
            #endregion
        }
    }
}
