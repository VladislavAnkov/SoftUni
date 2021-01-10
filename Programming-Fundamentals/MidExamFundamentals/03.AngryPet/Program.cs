using System;
using System.Linq;

namespace _03.AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int entrypoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typePriceRatings = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;

            int entryPointPriceRating = priceRatings[entrypoint];

            for (int i = entrypoint - 1; i >= 0; i--)
            {
                if (typeOfItems == "cheap")
                {
                    int currentRating = priceRatings[i];

                    if (typePriceRatings == "positive")
                    {
                        if (currentRating > 0 && currentRating < entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "negative")
                    {
                        if (currentRating < 0 && currentRating < entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "all")
                    {
                        if (currentRating < entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    int currentRating = priceRatings[i];

                    if (typePriceRatings == "positive")
                    {
                        if (currentRating > 0 && currentRating >= entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "negative")
                    {
                        if (currentRating < 0 && currentRating >= entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "all")
                    {
                        if (currentRating >= entryPointPriceRating)
                        {
                            leftSum += currentRating;
                        }
                    }
                }
            }

            for (int k = entrypoint + 1; k < priceRatings.Length; k++)
            {
                if (typeOfItems == "cheap")
                {
                    int currentRating = priceRatings[k];

                    if (typePriceRatings == "positive")
                    {
                        if (currentRating > 0 && currentRating < entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "negative")
                    {
                        if (currentRating < 0 && currentRating < entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "all")
                    {
                        if (currentRating < entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    int currentRating = priceRatings[k];

                    if (typePriceRatings == "positive")
                    {
                        if (currentRating > 0 && currentRating >= entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "negative")
                    {
                        if (currentRating < 0 && currentRating >= entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                    else if (typePriceRatings == "all")
                    {
                        if (currentRating >= entryPointPriceRating)
                        {
                            rightSum += currentRating;
                        }
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }
    }
}

