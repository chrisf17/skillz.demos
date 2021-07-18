namespace interfaces.intro
{
    public class Rocket: IAccelerable
    {
        public int Speed{get; set;}
        public int MaxSpeed{get; set;}
        public void Accelerate(int amount)
        {
            System.Threading.Thread.Sleep(5 * amount);
            Speed += amount;
        }
    }
}