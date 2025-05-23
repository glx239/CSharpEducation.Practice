namespace Practice4.Task1;

public class MathHelper
{
    private int arg_first;
    private int arg_second;

    public int ArgFirst {get => arg_first; set => arg_first = value; }
    public int ArgSecond {get => arg_second; set => arg_second = value; }

    public int Add()
    {
        return arg_first + arg_second;
    }

    public int Subtract()
    {
        return arg_first - arg_second;
    }

    public int Multiply()
    {
        return arg_first * arg_second;
    }

    public int Divide()
    {
        if (arg_second == 0)
        {
            throw new DivideByZeroException();
        }
        return arg_first / arg_second;
    }
}
