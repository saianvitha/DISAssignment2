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
                resultList.AddStock(current.StockHolding);
                current = current.Next;


            }
            resultList.AddStock(current.StockHolding);

            StockNode client1 = this.head;
            while (client1.Next != null)
            {
                resultList.AddStock(client1.StockHolding);
                client1 = client1.Next;
            }
            resultList.AddStock(client1.StockHolding);


            

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
            Stock mostShareStock1 = null;
           decimal hol= this.head.StockHolding.Holdings;

            // write your implementation here
            StockNode current = this.head;
            StockNode previous = null;
            
            while(current.Next!=null)
            {
                previous = current;
                current = current.Next;
                decimal holprev = previous.StockHolding.Holdings;
                decimal holcurr = current.StockHolding.Holdings;
                if (holcurr > holprev)
                {
                    if(holcurr>hol)
                    {
                        
                        hol = holcurr;
                    }
                    mostShareStock = current.StockHolding;
                }
                else
                    mostShareStock = previous.StockHolding;
                

            }
           return mostShareStock1;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;

            // write your implementation here

            return length;
        }
    }
}
