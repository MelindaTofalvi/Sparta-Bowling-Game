using System;
using System.Collections.Generic;

namespace Bowling
{
	public class Game : Frame
	{
      
		public static int Result { get; set; }
	      
		Dictionary<string, List<int>> PointsOfFrames = new Dictionary<string, List<int>>();

		CustomerInteraction customerInteraction = new CustomerInteraction();
	
		public void Play()
        {
			Result = 0;
            Rnd = new Random();
            for (int i = 1; i < 11; i++)
            {
				customerInteraction.AskForInput();

				ThrowFirstBall();
                
				PointsOfFrames.Add($"Frame_{i}", new List<int>() { FirstThrow });
				Console.WriteLine($"You scored {FirstThrow} at Frame-{i} with the first ball!");
                            
				if(PointsOfFrames[$"Frame_{i}"][0] == 10)
				{               
					try{
						if (PointsOfFrames[$"Frame_10"][0] == 10)
                        {
                            Console.WriteLine("WOW!! With this strike, You enabled two extra balls.");
                            Result += 10;
                            ExtraBall();
                            ExtraBall();
                            Console.WriteLine($"Your total point is {Result}.");
                        }
					}
					catch(KeyNotFoundException)
					{
						PointsOfFrames[$"Frame_{i}"].Add(0);
                        Console.WriteLine("Strike! You will see your total points in the next round.");
                        continue;
					}               
				}

				customerInteraction.AskForInput();

				ThrowSecondBall();
				PointsOfFrames[$"Frame_{i}"].Add(SecondThrow);
				Console.WriteLine($"You scored {SecondThrow} at Frame-{i} with the second ball!");

				if (PointsOfFrames[$"Frame_{i}"][0] + PointsOfFrames[$"Frame_{i}"][1] == 10)
				{
					try
                    {
                        if (PointsOfFrames[$"Frame_10"][0] + PointsOfFrames[$"Frame_10"][1] == 10)
                        {
							Console.WriteLine("Spare in the last Frame! You are great!");
                        }
                    }
                    catch (KeyNotFoundException)
                    {
						Console.WriteLine("Spare! You will see your total points in the next round.");
                        continue;
                    }
				}
 
                try
                {
					//check if strike in previous round. if yes, calculate points and print the total to the console
                    if (PointsOfFrames[$"Frame_{i - 1}"][0] == 10)
                    {
                        Result += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1] += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1] += 10;
                        Console.WriteLine($"Your total point is {Result}.");
                    }
					//check if spare in previous round. if yes, calculate points and print the total to the console
					else if(PointsOfFrames[$"Frame_{i - 1}"][0] + PointsOfFrames[$"Frame_{i - 1}"][1] == 10)
					{
						Result += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1] += PointsOfFrames[$"Frame_{i}"][0] += 10;                  
                        Console.WriteLine($"Your total point is {Result}.");
					}
                    else
                    {
                        Result += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1];
                        Console.WriteLine($"Your total point is {Result}.");
                    }
                }
                catch (KeyNotFoundException)
                {
                    Result += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1];
                    Console.WriteLine($"Your total point is {Result}.");
                    continue;
                } 
				catch(ArgumentOutOfRangeException)
				{
					Result += PointsOfFrames[$"Frame_{i}"][0] += PointsOfFrames[$"Frame_{i}"][1] += PointsOfFrames[$"Frame_{i}"][0] +=10;
                    Console.WriteLine($"Your total point is {Result}.");
                    continue;
				}
            }
        }

		public int ExtraBall()
        {
            ThrowFirstBall();
            PointsOfFrames[$"Frame_10"].Add(FirstThrow);
            Console.WriteLine($"Well done! You scored {FirstThrow} at Frame-10 with the first extra ball!");
            return Result += FirstThrow;
        }      
    }
}
