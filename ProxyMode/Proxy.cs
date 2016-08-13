namespace ProxyMode
{
    public class Proxy : IGiveGift
    {
        private readonly Pursuit _pursuit;

        public Proxy(SchoolGirl girl)
        {
            _pursuit = new Pursuit(girl);
        }

        public void GiveDolls()
        {
            _pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            _pursuit.GiveFlowers();
        }

        public void GiveCholocate()
        {
            _pursuit.GiveCholocate();
        }
    }
}