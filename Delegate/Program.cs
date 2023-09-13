
using Delegate.Classes;
using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Enter string: "); var str = Console.ReadLine();

        MyClass cls = new MyClass(str);
        Func funcDell = new Func(cls.Space); // params sadece sizin ora vereceyiniz parametrlerdi	
        funcDell.functions(cls.Reverse);
        //burda funcDell-e functionlari verirsiniz

        Run run = new Run();
        run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
    }
}
//ByVC