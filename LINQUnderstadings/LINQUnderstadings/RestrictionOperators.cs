using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUnderstadings
{
    public class RestrictionOperators
    {
        /// <summary>
        /// Getting data from array where nuber is less than 3 using where extension method.
        /// </summary>
        public void GetRestrictionSimple1()
        {
            int[] numberA = { 1, 2, 3, 4, 5 };

            var data = from odata in numberA.Where(x => x < 3) select odata;

            foreach (var p in data.ToList())
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------");
        }

        /// <summary>
        /// Getting data from array where number is less than 50 using where.
        /// </summary>
        public void GetRestrictionSimple2()
        {
            int[] numberA = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var GetData = from oData in numberA where oData < 50 select oData;

            foreach (var p in GetData.ToList())
            {
                Console.WriteLine(p);
            }
        }

        //public void GetRestriction()
        //{
        //    List<linqexamples.General.TestLinq> Items = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    Items = obj.GetItemsWithList();

        //    var query = from p in Items where Convert.ToInt32(p.ID) < 5 select p;

        //    foreach (var t in query)
        //    {
        //        Console.WriteLine("ID =" + t.ID + " " + ", ItemName =" + t.ItemName + " " + ", Amount =" + t.Amount);
        //    }
        //}

        //public void GetRestrictionWithDrillDown()
        //{
        //    List<linqexamples.General.TestLinq> Items = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    Items = obj.GetItemsWithList();

        //    var query = from p in Items where Convert.ToInt32(p.ID) < 5 select p;

        //    foreach (var t in query)
        //    {
        //        Console.WriteLine("ID : {0} ,ItemName : {1},Amount : {2}", t.ID, t.ItemName, t.Amount);
        //    }
        //}
    }
}
