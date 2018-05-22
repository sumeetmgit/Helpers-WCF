using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUnderstadings
{
    class OrderingOperator
    {
        public void GetSimpleOrderby()
        {
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var oQuery = from p in i orderby p ascending select p;

            foreach (var p in oQuery)
            {
                Console.WriteLine("\n \t" + p);
            }
        }

        //public void GetOrderBy()
        //{
        //    List<linqexamples.General.TestLinq> objTest = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    objTest = obj.GetItemsWithList();

        //    //var oQuery = from p in objTest orderby p.ID descending select p;
        //    var oQuery = from p in objTest.OrderBy(a => a.ID == "5") select p;

        //    foreach (var t in oQuery)
        //    {
        //        Console.WriteLine("ID = {0}, ItemName = {1} , Amount = {2}", t.ID, t.ItemName, t.Amount);
        //    }
        //}

        //public void GetOrderBydescending()
        //{
        //    List<linqexamples.General.TestLinq> objTest = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    objTest = obj.GetItemsWithList();

        //    var oQuery = from p in objTest orderby p.ItemName descending select p;

        //    foreach (var t in oQuery)
        //    {
        //        Console.WriteLine("ID = {0}, Item Name = {1}, Amount = {2}", t.ID, t.ItemName, t.Amount);
        //    }
        //}

        public void GetReverseOperator()
        {
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var oQuery = i.Reverse();

            foreach (var p in oQuery)
            {
                Console.WriteLine("\n" + p);

            }
        }
    }
}
