using System;
					
public class Program
{
	public Score currentScore;
	
	public void Main()
	{
		currentScore = new Score();
		
		Console.WriteLine("Your score is " + currentScore.score + "%.");
		compare(currentScore.score);
	}
	public class Score {
		//This should set the current score's value.
		public int score =96;
	}
	//This should compare the temperature to the limit and write the heat recommendations
	public void compare (int Score) {
		if(Score > 100) {
			Console.WriteLine("You got an A+.");
		}
		else if(Score >= 90) {
			Console.WriteLine("You got an A.");
		}
		else if(Score >= 80) {
			Console.WriteLine("You got a B.");
							  }
		else if(Score >= 70) {
			Console.WriteLine("You got a C.");
		}
		else {
			Console.WriteLine("You got an F.");
		{
		}
		}
	}
}