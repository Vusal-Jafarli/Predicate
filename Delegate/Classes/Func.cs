public class Func
{
    delegate void delegate_func(string x);
    private Action<string> function;

    public Action<string> Function
    {
        get { return function; }
        set { function = value; }
    }

    public void functions(Action<string> action)
    {
        Function += action;
    }
    public Func(Action<string> action)
    {
        Function = action;
        
    }


}
