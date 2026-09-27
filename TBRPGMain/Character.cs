using System;

public class Character
{

	static int charNum = 0;
	
		private string name;
		private int hp;
		private strength;
		private dexterity;
		private intelligence;
	
		Random random = new Random();

	
	public Character(string name, int hp, int strength, int dexterity, int intelligence)
	{
        charNum++;

        this.name = name;
		this.hp = hp;
		this.strength = strength;
		this.dexterity = dexterity;
		this.intelligence = intelligence;
	}

	public Character()
	{
        charNum++;

		this.name = "Character" + charNum;
		this.hp = 10;
		this.strength = random.Next(1, 10);
		this.dexterity = random.Next(1, 10);
		this.intelligence = random.Next(1, 10);
	}

	
}
