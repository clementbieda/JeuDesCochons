

public class IntNormalizable
{
    private int _value;
    private int _max;

    public IntNormalizable(int initValue, int maxValue)
    {
        _value = initValue;
        _max = maxValue;
    }

    public int GetValue()
    {
        return _value;
    }

    public void SetValue(int newValue)
    {
        if (_value > _max)
        {
            _value = _max;
        }
        else
        {
            _value = newValue;
        }
    }

    public int Normalize()
    {
        return _max == 0 ? 1 : _value / _max; //Comme un if
    }
}
