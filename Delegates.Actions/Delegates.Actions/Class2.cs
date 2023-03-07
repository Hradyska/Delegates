namespace Delegates.Actions
{
    public class Class2
    {
        private static float _number;
        public static Func<float, bool> Calc(Func<float, float, float> powHandler, float x, float y)
        {
            _number = powHandler(x, y);
            return Result;
        }

        public static bool Result(float x)
        {
            if (_number % x == 0)
            {
                return true;
            }

            return false;
        }
    }
}
