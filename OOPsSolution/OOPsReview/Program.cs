using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {   //console is a reference to a system static class
            //static classes are used by typing the class name
            //static classes do not store variable data
            //static classes are used by everyone
            //methods of a static class will be placed after
            //  the object dot operator
            

            //Create an instance of a non static class
            //If you createa  declarative using JUST the 
            //      class name then this is ONLY a pointer 
            //      that can hold instance of the class
            //      specified
            //Currrent value of aVariable is null

            FencePanel aVariable=null;

            //if you use the new command with the class
            //      the new command will physically create
            //      an instance of the class

            //when this statement is executed, the Default 
            //      constructor of the FencePanel class will 
            //      be called on your behalf.
            FencePanel anInstance = new FencePanel();
            anInstance.Height = 5.8;
            anInstance.Width = 8.0;
            anInstance.Style = "Neighbour Friendly";

            Console.WriteLine("Width is:"+anInstance.Width.ToString());
            Console.WriteLine("Height is:" + anInstance.Height.ToString());
            Console.WriteLine("Style is:" + anInstance.Style );
            Console.WriteLine("Price is:" + anInstance.Price + "\n");


            FencePanel anGInstance = new FencePanel(4.0, 6.8, "private", 32.89);
            
                Console.WriteLine("Width is:" + anGInstance.Width.ToString());
            Console.WriteLine("Height is:" + anGInstance.Height.ToString());
            Console.WriteLine("Style is:" + anGInstance.Style );
            Console.WriteLine("Price is:" + anGInstance.Price + "\n");

            //Using instances of classes
            string menuItem ="0";
            Fence CustomerFence = new Fence();
            //palce data from the right side into the left side
            CustomerFence.FenceEstimate = anGInstance;
            CustomerFence.Gates = null;
            string inputValue;
            //allows it to be re used
            Gate theGate = null;
            do
            {
                theGate = new Gate();
                Console.WriteLine("Height: ");
                inputValue = Console.ReadLine();
                theGate.Height = double.Parse(inputValue);

                Console.WriteLine("Width: ");
                inputValue = Console.ReadLine();
                theGate.Width = double.Parse(inputValue);

                Console.WriteLine("Style: ");
                inputValue = Console.ReadLine();
                theGate.gateStyle = (inputValue);

                Console.WriteLine("Price: ");
                inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    theGate.Price = null;
                }
                else
                {
                    theGate.Price = double.Parse(inputValue);
                }

                //the local instance of gate needs to be saved
                //      into the Fence 
                CustomerFence.Gates.Add(theGate);

                Console.WriteLine("Another Gate (Y or N): ");
                inputValue = Console.ReadLine();
                menuItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";

            } while (menuItem !="0");
            Console.WriteLine("Fence Length: ");
            inputValue = Console.ReadLine();
            double linearLength =double.Parse(inputValue);
            //using the CustomerFence Data calculate the cost
            double numberOfPanels = CustomerFence.FenceEstimate.EstimatedNumberOfPanels(linearLength);
            double FencePrice = Math.Ceiling(numberOfPanels)*double.Parse(CustomerFence.FenceEstimate.Price.ToString());
            double gateCost = 0.0;
            foreach(Gate item in CustomerFence.Gates)
            {
                gateCost += double.Parse(item.Price.ToString());
            }
            Console.WriteLine("Total Fence Estimate");
            Console.WriteLine("Number of panels: " + numberOfPanels.ToString());
            Console.WriteLine("Cost of panels: " + FencePrice.ToString());
            Console.WriteLine("Number of gates: " + CustomerFence.Gates.Count.ToString());
            Console.WriteLine("Cost of gates: " + gateCost.ToString());
            Console.WriteLine("Total: "+(FencePrice+gateCost).ToString());
            Console.ReadLine();

        }//eom(end of method)

    }//eoc(end of class)

}//eon(end of namespace)
