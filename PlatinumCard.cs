using System;

public class PlatinumCard : ICard
{
	public PlatinumCard()
	{
		InitialCredit = 10000;
		MaxDailyDraw = 5000;
	}
	public decimal InitialCredit { get; set; }
	public decimal MaxDailyDraw { get; set; }

	public void GetCardDetails()
	{
		Console.WriteLine($"Card type is Platinum with an Inital Credit of {InitialCredit} and a maximum daily draw of {MaxDailyDraw}");
	}
}