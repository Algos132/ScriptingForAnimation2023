using System;
					
public class Programs
{
	public food fruit;
	public food grain;
    public food vegitable;
    public food meat;
	
	public void Main(){
		fruit = new food();
		grain = new food();
        vegitable = new food();
        meat = new food();
	{
		
		fruit.quantity = 3;}
        fruit.sustaining = 1.25f;
		fruit.eatOne = true;

		grain.quantity = 5;
        grain.sustaining = 3f;
        grain.eatOne = false;

        vegitable.quantity = 4;
        vegitable.sustaining = 2.5f;
		vegitable.eatOne = false;

        meat.quantity = 2;
		meat.sustaining = 4f;

		
		Console.WriteLine("you have " + fruit.quantity + "fruit.");
        if (fruit.eatOne == true)
            Console.WriteLine("You've eaten one fruit gained + " + fruit.sustaining + " sustenance.");

		Console.WriteLine ("you have " + grain.quantity + " grain.");
        if (grain.eatOne == true)
            Console.WriteLine ("You've eaten one grain +" + grain.sustaining + " sustenance.");

        Console.WriteLine("you have " + vegitable.quantity + " vegitable.");
        if (grain.eatOne == true)
            Console.WriteLine ("You've eaten one vegitable +" + vegitable.sustaining + " sustenance.");

        Console.WriteLine("you have " + meat.quantity + " meat.");
        if (meat.eatOne == true)
            Console.WriteLine ("You've eaten one meat +" + meat.sustaining + " sustenance.");
	}
public class food {
	public int quantity;
	public float sustaining;
	public bool eatOne = true;}
}