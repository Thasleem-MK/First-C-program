using System;
namespace Model
{
    class Parent:Sample.Sample
    {
        public void sum(int num1,int num2)
        {
            System.Console.WriteLine($"The sum is: {num1+num2}");
        }
    }
    class Programs:Parent
    {
        public static void Main(string[] args)
        {
            Programs Obj2=new Programs();
            Obj2.sum(10,12);
        }
    }
}