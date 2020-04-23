namespace BraidGame
{
    public class Bank
    {
        public Bank(int countMoney)
        {
            _countMoney = countMoney;
        }
        
        private int _countMoney;

        public void AddMoney(int m)
        {
            _countMoney += m;
        }

        public int GetMoney()
        {
            return _countMoney;
        }

    }
}