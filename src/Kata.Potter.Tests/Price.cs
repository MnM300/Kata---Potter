using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Potter.Tests
{
    public class Price
    {
        public static double GetTotalCost(int[] books)
        {
            const double totalCost = 0;

            return books.Length <= 0 ? totalCost : books.Length * 8;
        }

        public static double GetTotalDiscountCost(int[] bookList)
        {
            double totalCost = 0;

            var bookSets = GetBookSets(bookList);
            var maxValue =bookSets.Values.Max();
            
            while (maxValue > 0)
            {

                var test = bookSets.Count(x => x.Value == maxValue);
                
                totalCost += GetDiscount(test);
                
                foreach (var book in bookSets.Where(x => x.Value == maxValue).ToList())
                {
                    bookSets[book.Key] = book.Value - 1;
                }

                --maxValue;
            }

            return totalCost;
        }

        public static Dictionary<int, int> GetBookSets(int[] bookList)
        {
            var bookSets = new Dictionary<int, int>();

            foreach (var book in bookList)
            {
                if (bookSets.ContainsKey(book))
                {
                    var bookCount = bookSets[book];
                    bookSets.Remove(book);
                    bookSets.Add(book, ++bookCount);
                }
                else
                {
                    bookSets.Add(book, 1);
                }
            }
            return bookSets;
        }
        
        public static double Optimizeset(int[] bookList)
        {
            var distinctList = bookList.Distinct().ToArray();

            var duplicateList = bookList.Except(distinctList).ToArray();

            var test = duplicateList;


            return 0;
        }

        public static double GetDiscount(int setSize)
        {
            double cost = 0;

            switch (setSize)
            {
                case 0:
                    break;
                case 1:
                    cost = 8;
                    break;
                case 2:
                    cost = setSize * 8 * 0.95;
                    break;
                case 3:
                    cost = setSize * 8 * 0.9;
                    break;
                case 4:
                    cost = setSize * 8 * 0.8;
                    break;
                case 5:
                    cost = setSize * 8 * 0.75;
                    break;
            }
            return cost;
        }
    }
}