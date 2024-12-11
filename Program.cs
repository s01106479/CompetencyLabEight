using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 1 - Add name, Course number, and CRN as a single line comment or multi-line comment at the beginning of the code. 
/* Isabella Tomasek
 * Course Number: 1050
 * CRN: 86411
 */

namespace CompetencyLabEight
{
    class Program
    {
        public static void Main(string[] args)
        {
            Furniture myFurniture = new Furniture(); //Create a Furniture object
            myFurniture.FurnitureDetail();

            //Step 5 - Create an object of type Dresser. Call its FurnitureDetail() method.
            Dresser myDresser = new Dresser();
            myDresser.FurnitureDetail();

            //Step 6 - Create an object of type Desk. Call its FurnitureDetail() method.
            Desk myDesk = new Desk();
            myDesk.FurnitureDetail();

            //Step 7 - Create an object of type Bed. Call its FurnitureDetail() method.
            Bed myBed = new Bed();
            myBed.FurnitureDetail();

        }    //end of Main Method
    }   //end of class Program

    //Given class Furniture with method FurnitureDetail( ) that outputs "The furniture is made of wood."
    //Please leave the following Furniture class code in your lab
    class Furniture  // Base class (parent) 
    {
        public void FurnitureDetail()
        {
            Console.WriteLine("The furniture is made of wood.");
        }
    }   //end of class Furniture

    //Step 2 - Create a derived (child) class called Dresser. Add a method called FurnitureDetail() that outputs: "The dresser is made from cherry    wood."
    class Dresser : Furniture
    {
        public void FurnitureDetail()
        {
            Console.WriteLine("The dresser is made from cherry wood.");
        }
    }

    //Step 3 - Create a derived (child) class called Desk. Add a method called FurnitureDetail() that outputs: "The desk is made from oak wood."
    class Desk : Furniture
    {
        public void FurnitureDetail()
        {
            Console.WriteLine("The desk is made from oak wood.");
        }
    }

    //Step 4 - Create a derived (child) class called Bed. Add a method called FurnitureDetail() that outputs: "The bed is made from walnut wood."
    class Bed : Furniture
    {
        public void FurnitureDetail()
        {
            Console.WriteLine("The bed is made from walnut wood.");
        }
    }
}

