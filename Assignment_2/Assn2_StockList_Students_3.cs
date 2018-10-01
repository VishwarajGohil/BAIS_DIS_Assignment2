using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
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

            // write your implementation here
            StockNode current = this.head;

            if (current.Next == null)
            {
                //To Get the value of portfolio that is value of each stock multiplied by the number of holdings.
                value = current.StockHolding.Holdings * current.StockHolding.CurrentPrice;
            }
            else
            {
                while (current != null)
                {
                    value += current.StockHolding.Holdings * current.StockHolding.CurrentPrice;
                    current = current.Next;
                }

            }

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;

            StockNode current = this.head;
            while (current != null)
            {
                StockNode current1 = listToCompare.head;
                while (current1 != null)
                {
                    //To Compare the list of Stock of both the lists 
                    if (current.StockHolding.Name == current1.StockHolding.Name)
                    {

                        similarityIndex++;
                    }
                    current1 = current1.Next;
                }
                current = current.Next;

            }

            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            if (this.head == null)
            {
                Console.WriteLine("****************Empty List***************");
            }
            else
            {
                StockNode current = this.head;

                int counter = 1;
                //Loop to print Symbol,Name,Holdings,Current Price
                while (current != null)
                {
                    Console.WriteLine("****************Node number: " + counter + "***************");
                    Console.WriteLine("Symbol: " + current.StockHolding.Symbol);
                    Console.WriteLine("Name: " + current.StockHolding.Name);
                    Console.WriteLine("Holdings: " + current.StockHolding.Holdings);
                    Console.WriteLine("CurrentPrice: " + current.StockHolding.CurrentPrice);
                    Console.WriteLine("");

                    current = current.Next;
                    counter++;
                }
            }

        }
    }
}