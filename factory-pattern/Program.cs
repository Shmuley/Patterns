// See https://aka.ms/new-console-template for more information
CardFactory factory = new FreedomCardFactory(5000, 0);
var card = factory.GetCreditCard();
Console.WriteLine("You card is {0}", card.GetCreditType());

public interface CreditCard
{
    string GetCreditType();
    int GetCreditLimit();
    int GetAnnualCharge();
}

class FreedomCard : CreditCard
{
    private string _cardType;
    private int _creditLimit;
    private int _annualCharge;

    public FreedomCard(int creditLimit, int annualCharge)
    {
        _cardType = "Freedom";
        _creditLimit = creditLimit;
        _annualCharge = annualCharge;
    }

    public string CardType { get => _cardType; }
    public int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
    public int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }

    public int GetAnnualCharge()
    {
        return AnnualCharge;
    }

    public int GetCreditLimit()
    {
        return CreditLimit;
    }

    public string GetCreditType()
    {
        return CardType;
    }
}

abstract class CardFactory
{
    public abstract CreditCard GetCreditCard();
}

class FreedomCardFactory : CardFactory
{
    private int _creditLimit;
    private int _annualCharge;

    public FreedomCardFactory(int creditLimit, int annualCharge)
    {
        _creditLimit = creditLimit;
        _annualCharge = annualCharge;
    }

    public override CreditCard GetCreditCard()
    {
        return new FreedomCard(_creditLimit, _annualCharge);
    }
}