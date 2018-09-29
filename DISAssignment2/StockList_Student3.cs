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

        //    // write your implementation here
        //    StockNode current = this.head.Next.StockHolding;
        //    StockNode previous = null;
        //    while (current.Next != null)
        //    {
        //        value += current.StockHolding.Holdings * current.StockHolding.CurrentPrice;
        //        previous = current;
        //        current = current.Next;
        //    }

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            //int similarityIndex1 = 0;
            //int similarityIndex2 = 0;
            int similarityIndex = 0;

            // write your implementation here
            StockNode current = this.head;
            StockNode previous = null;
            StockNode two = null;
            while (listToCompare.head.Next != null)
            {
                while (current.Next != null)
                {
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        similarityIndex++;
                    }
                   
                    previous = current;
                    current = current.Next;
                }
                if(current.Next==null)
                {
                    if (current.StockHolding.Name == listToCompare.head.StockHolding.Name)
                    {
                        similarityIndex++;
                    }
                }
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
            return similarityIndex;
        }

            
        

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode mergeClient = this.head;
            while (mergeClient.Next != null)
            {
                Console.WriteLine("Symbol:" + mergeClient.StockHolding.Symbol + " Name:" + mergeClient.StockHolding.Name + " Holdings:" + mergeClient.StockHolding.Holdings + " CurrentPrice:" + mergeClient.StockHolding.CurrentPrice);
                mergeClient = mergeClient.Next;

            }
            Console.WriteLine("Symbol:" + mergeClient.StockHolding.Symbol + " Name:" + mergeClient.StockHolding.Name + " Holdings:" + mergeClient.StockHolding.Holdings + " CurrentPrice:" + mergeClient.StockHolding.CurrentPrice);
        }
    }
}
