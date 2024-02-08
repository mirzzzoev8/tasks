namespace Task5;
public  class Counter
{
    int value;

    public Counter(int value)
    {
        this.value = value;
    }

    public void Decrement()
    {
        if (value > 0)
        {
            value--;
        }
    }

    public void Reset()
    {
        value = 0;
    }
}
