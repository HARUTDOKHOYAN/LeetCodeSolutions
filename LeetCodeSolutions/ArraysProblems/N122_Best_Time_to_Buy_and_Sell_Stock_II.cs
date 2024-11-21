using System;

namespace LeetCodeSolutions.ArraysProblems;

public class N122_Best_Time_to_Buy_and_Sell_Stock_II : ILeetCodeRun
{
    public void Run()
    {
        MaxProfit([2,1,2,0,1]);
    }

    public int MaxProfit(int[] prices)
    {
        var myStockPrice = -1;
        var profit = 0;
        for(int i = 0 ; i < prices.Length - 1 ; i++){
            if(myStockPrice != 0 && prices[i] > prices[i+1]){
                 profit += prices[i] - myStockPrice;
                 myStockPrice = -1;
            }
            if(myStockPrice == -1 && prices[i] < prices[i+1])
                myStockPrice = prices[i];
        }
        if(myStockPrice != -1 )
           profit += prices[prices.Length - 1] - myStockPrice;

        return profit;
    }
}

