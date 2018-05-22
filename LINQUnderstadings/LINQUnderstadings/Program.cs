using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUnderstadings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------------------Restriction Operator----------------------------*/
            Console.WriteLine("---------Restriction Operator samples-------------");
            RestrictionOperators objRestrictionOperators = new RestrictionOperators();
            objRestrictionOperators.GetRestrictionSimple1();
            objRestrictionOperators.GetRestrictionSimple2();
            Console.Write("---------Press Enter------------");
            Console.ReadLine();
            /*------------------------------END-----------------------------------*/

            Console.Write("---------Projection Operator-------------");

            /*---------------------Projection Operator----------------------------*/
            ProjectionOperator objprojection = new ProjectionOperator();
            objprojection.GetSimpleSelect();
            //objprojection.GetSelect2();
            //objprojection.GetSelectTransformation();
            Console.WriteLine("----------------Select Filtered-------------------");
            //objprojection.GetSelectFiltered();
            Console.Write("---------Press Enter------------");
            Console.ReadLine();
            /*------------------------------END-----------------------------------*/


            /*--------------------Ordering Operator-----------------------------*/
            Console.WriteLine("------------------Order BY operator---------------------");
            OrderingOperator objordrOperator = new OrderingOperator();
            objordrOperator.GetSimpleOrderby();
            
            //objordrOperator.GetOrderBy();
            //Console.WriteLine("------------------Order BY operator Descending---------------------");
            //objordrOperator.GetOrderBydescending();
            Console.WriteLine("----------------------Reverse Operator-----------------------------");
            objordrOperator.GetReverseOperator();
            /*----------------------------END-----------------------------------*/
            Console.ReadLine();
        }
    }
}