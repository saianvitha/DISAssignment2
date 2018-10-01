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
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            StockList resultList = new StockList();
            StockNode current = listToMerge.head;

            while (current.Next != null)
            {
                resultList.MergeStock(current.StockHolding);
                current = current.Next;


            }
            resultList.MergeStock(current.StockHolding);

            StockNode client1 = this.head;
            while (client1.Next != null)
            {
                resultList.MergeStock(client1.StockHolding);
                client1 = client1.Next;
            }
            resultList.MergeStock(client1.StockHolding);




            // write your implementation here

            return resultList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = null;
            decimal hol = this.head.StockHolding.Holdings;


            // write your implementation here

            StockNode current = this.head;
            decimal highNumber = 0.0m;


            while (current.Next != null)
            {

                //previous = current;
                current = current.Next;
              //  decimal holprev = previous.StockHolding.Holdings;
                decimal holcurr = current.StockHolding.Holdings;
               

                if (holcurr > highNumber)
                {
                    highNumber = holcurr;
                    mostShareStock = current.StockHolding;

                }
                //else
                //{
                //    highNumber = holprev;

                //    mostShareStock = previous.StockHolding;
                //}
                


            }


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
            while (newnode.Next != null)
            {
                previous = newnode;
                newnode = newnode.Next;
                length++;
            }
            length = length + 1;
            // write your implementation here

            return length;
        }



    }
}
