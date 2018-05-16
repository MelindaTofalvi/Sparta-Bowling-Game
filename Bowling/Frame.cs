using System;

namespace Bowling
{
	public class Frame 
	{
      
    	public static int FirstThrow { get; set; }
    	public static int SecondThrow { get; set; }
    	public static int FirstRandomnum { get; set; }
    	public static int SecondRandomnum { get; set; }
    	public static Random Rnd { get; set; }

    	public void GetFirstRandomNumber()
    	{
    		FirstRandomnum = Rnd.Next(0, 11); // return a value between 0 and 10 inclusive
    	}

    	public void GetSecondRandomNumber()
    	{
    		int MaxNr = 10 - FirstThrow;
    		SecondRandomnum = Rnd.Next(0, MaxNr+1); // return a value between 0 and MaxNr inclusive
    	}

    	public void ThrowFirstBall()
    	{
    		GetFirstRandomNumber();
    		FirstThrow = FirstRandomnum;
    	}

    	public void ThrowSecondBall()
    	{
    		GetSecondRandomNumber();
    		SecondThrow = SecondRandomnum;
    	}

        
    }
}


