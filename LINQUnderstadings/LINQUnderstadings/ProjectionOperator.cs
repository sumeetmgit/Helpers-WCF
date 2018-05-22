using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUnderstadings
{
    class ProjectionOperator
    {
        public void GetSimpleSelect()
        {
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var oQuery = from p in i select p;
            foreach (var t in oQuery)
            {
                Console.WriteLine("\n" + t);
            }
        }

        //public void GetSelect2()
        //{
        //    List<linqexamples.General.TestLinq> objTest = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    objTest = obj.GetItemsWithList();

        //    var oQuery = from p in objTest select new { Item = p.ItemName };

        //    foreach (var t in oQuery)
        //    {
        //        Console.WriteLine("ItemName = {0}", t.Item);
        //    }
        //}

        //public void GetSelectTransformation()
        //{
        //    int[] i = { 8, 7, 5, 4, 3, 6, 2, 8, 1, 0 };
        //    List<linqexamples.General.TestLinq> objTEst = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    objTEst = obj.GetItemsWithList();

        //    var oQuery = from p in i select new { ItemId = objTEst[p].ID, Item = objTEst[p].ItemName };

        //    foreach (var t in oQuery)
        //    {
        //        Console.WriteLine("ID = {0}, Item Name = {1}", t.ItemId, t.Item);
        //    }
        //}

        //public void GetSelectFiltered()
        //{
        //    int[] i = { 8, 7, 4, 5, 2, 6, 3, 8, 1, 0 };
        //    List<linqexamples.General.TestLinq> objTEst = new List<General.TestLinq>();
        //    getItemsdata obj = new getItemsdata();
        //    objTEst = obj.GetItemsWithList();

        //    var oQuery = from p in i where p < 5 select new { ItemId = objTEst[p].ID, Item = objTEst[p].ItemName };

        //    foreach (var t in oQuery)
        //    {
        //        Console.WriteLine("ID = {0}, Item Name = {1}", t.ItemId, t.Item);
        //    }
        //}
    }
}
