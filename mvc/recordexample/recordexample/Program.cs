using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System;

namespace rec
{
    public record recordexmple
    {
        public int a { get; init; }
    public String nm { get; init; }

}

public class Program 
{
    public static void Main(String[] args)
    {
        recordexmple rec = new recordexmple
        {
            a = 1,
            nm = "SNEHA"
        };
        var emp1 = rec with { a = 12, nm = "yadav" };
        Console.WriteLine($" rec object value = ID :{rec.a}  Name : {rec.nm} \n emp1 object values =ID:{emp1.a} name {emp1.nm} ");
        Console.ReadLine();

    }
}
