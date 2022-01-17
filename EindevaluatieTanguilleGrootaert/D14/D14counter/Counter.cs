namespace D14.D14counter
{
    internal class Counter
    {
        private int _value;
        private int _step = 1;

        public void SetValue(int value)
        { _value = value; }
        public int GetValue()
        { return _value; }

        public void SetStep(int step)
        { _step = step; }
        public int GetStep()
        { return _step; }

        public void Advance()
        { _value += _step; }
    }
}
