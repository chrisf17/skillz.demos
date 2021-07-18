namespace interfaces.intro
{
    public class Car: IAccelerable
    {
        public int Speed{get; set;}
        public int MaxSpeed{get; set;}
        public void Accelerate(int a)
        {
            Speed += a;
        }
    }
}