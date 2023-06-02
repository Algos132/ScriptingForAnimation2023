using System;
					
public class Program
{
	public Score currentScore;
    public Subject currentSubject;
	
	public void Main()
	{
		currentScore = new Score();
        currentSubject = new Subject();
		
		Console.WriteLine("You had a " + currentSubject.subject + " Test.");
		Console.WriteLine("Your score is " + currentScore.score + "%.");
		compare(currentScore.score);
		trying(currentScore.score);
		
	}
	public class Subject {
		//This sets the test's subject
		public string subject = "Math";
	}
	public class Score {
		//This should set the current score's value.
		public int score = 65;
	}
	//This should compare the temperature to the limit and write the heat recommendations
	public void trying (int Score) {
		if(Score <= 80) {
			Console.WriteLine("With practice and studying, you will improve! Keep trying! You'll get a better score in " + currentSubject.subject + " In no time!");
		} }
		
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