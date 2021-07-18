using System;
namespace interfaces.intro
{
    public static class Accelerator
    {
        public static void AccelerateToMaxSpeed(Car item, Action<int> notify = null)
        {
            while(item.Speed < item.MaxSpeed)
            {
                item.Accelerate(5);
                notify?.Invoke(item.Speed);
            }
        }
    }
}