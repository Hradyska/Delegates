namespace Delegates.Actions
{
    public sealed class Class1
    {
        private static Action<bool> _action = Program.Show;

        public static Action<bool> Action { get => _action; private set => _action = value; }

        public static float Pow(float x, float y)
        {
            return x * y;
        }
    }
}
