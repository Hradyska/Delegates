namespace Delegates.Actions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float divider = 5;
            Func<float, float, float> powHandler = Class1.Pow;
            Func<float, bool> resHandler = Class2.Calc(powHandler, 23, 15);
            Class1.Action(resHandler(divider));
        }

        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}