using System;

public class Interactable : Item
{
	static int itemNum = 0;
	string name;
	string description;
	int hardness;

	Random random = new Random();

	public Interactable(string name, string description, int hardness)
	{

		itemNum++;
		this.name = name;
		this.description = description;
		this.hardness = hardness;
	}

	public Interactable() 
	{
		itemNum++;

		this.name = "Item" + itemNum;
		this.description = "This is " + this.name + ". It is nothing less, and nothing more.";
		this.hardness = 0;
	}
}
