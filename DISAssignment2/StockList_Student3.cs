using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISAssignment2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;
            StockNode current = this.head;
            StockNode previous = null;
            // While loop to calculate a stock's value until we reach the end of the list//
            while (current.Next != null)
            {
                // Multiplying a stock's Holdings with its CurrentPrice and storing in a variable called "value"//
                value += current.StockHolding.Holdings * current.StockHolding.CurrentPrice;
                previous = current;
                current = current.Next;
            }
            // Updating the variable "value" by summing up values of all stocks in the Portfolio//
            value += current.StockHolding.Holdings * current.StockHolding.CurrentPrice;

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to be compared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {            
            int similarityIndex = 0;
            StockNode current = this.head;
            StockNode previous = null;
            StockNode two = null;
            // While loop to check if the StockList to be compared has reached end of the list//
            while (listToCompare.head.Next != null)
            {
                // A second loop to check if the Stocklist that is being compared with listToCompare has reached the end of the list//
                while (current.Next != null)
                {
                    // Comparing stocks from the two lists//
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        //Increments similarityIndex by one everytime a match is found//
                        similarityIndex++;
                    }
                   
                    previous = current;
                    current = current.Next;
                }
                // If the list being compared with listToCompare reaches the end of the list//
                if(current.Next==null)
                {
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        similarityIndex++;
                    }
                }

                /* The first stock from listToCompare has been compared with all the stocks in the current StockList. The first stock of
                 * listToCompare is assigned to a variable called "two" and the next stock is compared all over again with stocks from the
                 * current StockList. */

                current = this.head;
                two = listToCompare.head;
                listToCompare.head = listToCompare.head.Next;
            }
            while (current.Next != null)
            {
                if (listToCompare.head.Next == null)
                {
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        similarityIndex++;
                    }

                    previous = current;
                    current = current.Next;
                }
                if (current.Next == null)
                {
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        similarityIndex++;
                    }
                }
            }
            // Returns the total value of the similarityIndex //
            return similarityIndex;
        }

            
        

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            // Declaration of a variable called mergeClient to traverse through the list//
            StockNode mergeClient = this.head;
            // While loop to check if mergeClient has reached the end of the list//
            while (mergeClient.Next != null)
            {
                // Print statement to print all the attributes of a single stock//
                Console.WriteLine("Symbol:" + mergeClient.StockHolding.Symbol + " Name:" + mergeClient.StockHolding.Name + " Holdings:" + mergeClient.StockHolding.Holdings + " CurrentPrice:" + mergeClient.StockHolding.CurrentPrice);
                mergeClient = mergeClient.Next;

            }
            // Print statement to print the attributes of all the stocks in the particluar Portfolio//
            Console.WriteLine("Symbol:" + mergeClient.StockHolding.Symbol + " Name:" + mergeClient.StockHolding.Name + " Holdings:" + mergeClient.StockHolding.Holdings + " CurrentPrice:" + mergeClient.StockHolding.CurrentPrice);
        }
    }
}
