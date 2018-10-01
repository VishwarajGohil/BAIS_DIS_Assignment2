using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
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
            StockList currentStockList = this;

            StockNode current = this.head;
            StockNode nodeToMerge = listToMerge.head;


            while (nodeToMerge != null)
            {
                currentStockList.AddStock(nodeToMerge.StockHolding);

                nodeToMerge = nodeToMerge.Next;
            }

            currentStockList.SortByName();

            resultList = currentStockList;

            return resultList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = null;

            if (this.head == null)
            {
                Console.WriteLine("****************Empty List***************");
                return mostShareStock;
            }
            else
            {
                StockNode current = this.head;
                mostShareStock = current.StockHolding;

                if (current.Next == null)
                {
                    return mostShareStock;
                }
                else
                {
                    while (current != null)
                    {
                        if (current.StockHolding.Holdings > mostShareStock.Holdings)
                        {
                            mostShareStock = current.StockHolding;
                        }
                        current = current.Next;
                    }
                    return mostShareStock;
                }

            }

        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;

            if (this.head == null)
            {
                return length;
            }
            else
            {
                StockNode current = this.head;

                do
                {
                    current = current.Next;
                    length++;
                } while (current != null);

            }

            return length;
        }
    }
}