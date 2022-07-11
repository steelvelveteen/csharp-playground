using System;

public class TitaniumCard : ICard
{
	public decimal InitialCredit { get; set; }
	public decimal MaxDailyDraw { get; set; }
	public TitaniumCard()
	{
		InitialCredit = 25000;
		MaxDailyDraw = 6000;
	}
	public void GetCardDetails()
	{
		Console.WriteLine($"Card type is Titanium with an Inital Credit of {InitialCredit} and a maximum daily draw of {MaxDailyDraw}");
	}
}
