public interface IBuyer 
{
   int Repute { get; }

   int Coins { get; }

    void AddCoin(int value);

    void RemoveCoin(int value);

    void AddRepute(int value);
}
