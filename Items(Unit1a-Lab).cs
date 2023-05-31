using System;
					
public class Items
{
	public Item swordBlade;
	public Ability maxMight;
	
	public void Main()
	{
		swordBlade = new Item();
		maxMight = new Ability();
		
		Console.WriteLine("Your " + swordBlade.itemName + "'s base damage is " + swordBlade.baseDamage + ".");
		if (maxMight.abilityReady == (true))
			Console.WriteLine("Your ability " + maxMight.abilityName + " is ready!");
		else
			Console.WriteLine("Your ability " + maxMight.abilityName + " is not ready.");
			//This next line should multiply the base damage of "Sword" and multiplier of "Maximum Might" together to make the new damage equal 12.5
			Console.WriteLine("Using " + maxMight.abilityName + " will boost your " + swordBlade.itemName + "'s power to " + swordBlade.baseDamage * maxMight.powerUp);
	}
	public class Item{
		//This should set the base damage of "Sword" to 5
		public int baseDamage = 5;
		public string itemName = "Sword";
		
}
	public class Ability {
		//This should give the ability "Maximum Might" a multiplier of 2.5
		public string abilityName = "Maximum Might";
		//I vaguely remember if/else functions from a previous class, so I wanted to experiment with bool and see if I can't make connections based on it. 
		//Update, thanks to trial, error, and reading the bug reports I was able to successfully format the if/else function correctly!
		//If the bool for abilityReady is false, then it will display "Your ability Maximum Might is not ready. If it's changed to true it should display "Your ability Maximum Might is ready!"
		public bool abilityReady = false;
		public float powerUp = 2.5f;
}
}