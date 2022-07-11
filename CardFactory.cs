public enum CardType
{
	PLATINUM = 0,
	TITANIUM = 1,
	MONEYBACK = 2
}

public interface ICard
{
	void GetCardDetails();
}
public static class CardFactory
{
	public static ICard GetCardType(CardType cardType)
	{
		ICard card = null;

		switch (cardType)
		{
			case CardType.PLATINUM:
				card = new PlatinumCard();
				break;
			case CardType.TITANIUM:
				card = new TitaniumCard();
				break;
			case CardType.MONEYBACK:
				return null;
		}

		return card;
	}
}