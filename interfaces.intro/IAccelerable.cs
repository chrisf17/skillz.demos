namespace interfaces.intro{
    interface IAccelerable
    {
        int Speed{get;}
        int MaxSpeed{get; set;}
        void Accelerate(int a);
    }
}