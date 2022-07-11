using System;

namespace csharp_playground
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var card = CardFactory.GetCardType(CardType.PLATINUM);
			card.GetCardDetails();
			var card2 = CardFactory.GetCardType(CardType.TITANIUM);
			card2.GetCardDetails();
		}
	}
}
