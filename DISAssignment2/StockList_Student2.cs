using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISAssignment2
{
    public partial class StockList
    {
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different lists into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            // Creating a new Stocklist called resultList to store and return the merged lists//
            StockList resultList = new StockList();
            StockNode current = listToMerge.head;
            // While loop to merge stocks from Client2 Portfolio to resultList until the end of Client2 is reached//
            while (current.Next != null)
            {
                resultList.MergeStock(current.StockHolding);
                current = current.Next;
            }
            // For the last stock, it exits the loop and gets added separately//
            resultList.MergeStock(current.StockHolding);


            StockNode client1 = this.head;
            // While loop to merge stocks from Client1 Portfolio to resultList until the end of Client1 is reached//
            while (client1.Next != null)
            {
                resultList.MergeStock(client1.StockHolding);
                client1 = client1.Next;
            }
            // For the last stock, it exits the loop and gets added separately//
            resultList.MergeStock(client1.StockHolding);

            // Returns the final merged list//
            return resultList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = null;

            // Declaring a variable called "hol" to compare holdings of stocks//
            decimal hol = this.head.StockHolding.Holdings;
            StockNode current = this.head;
            decimal highNumber = 0.0m;

            // While loop to traverse the list and check for the if condition until the end of list is reached//
            while (current.Next != null)
            {
                
                decimal holcurr = current.StockHolding.Holdings;
               // Condition to compare the current stock's holdings and stock with maximum holdings//
                if (holcurr > highNumber)
                {
                    highNumber = holcurr;
                    mostShareStock = current.StockHolding;
                }
                current = current.Next;

            }
            // Returns the stock with maximum number of holdings//
            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;
            StockNode newnode = this.head;
            StockNode previous = null;
            // While loop to traverse through the list and increment the length variable by one for every stock until the end of list is reached//
            while (newnode.Next != null)
            {
                previous = newnode;
                newnode = newnode.Next;
                length++;
            }
            // For the last stock in the list, the loop is exited and length variable is incremented separately//
            length = length + 1;

            // Returns the final length i.e., the number of nodes in the list//
            return length;
        }

    }
}
