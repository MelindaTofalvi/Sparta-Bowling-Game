
namespace Bowling
{
	class MainClass
	{
		public static void Main()
		{
         
			CustomerInteraction customerInteraction = new CustomerInteraction();

			customerInteraction.Greeting();

			Game game = new Game();
			game.Play();

			customerInteraction.End_Of_Game_Message();
            
        }
    }
}
