using System;
public class Animal
{
    public void eat()
    
    { Console.WriteLine(" animal can Eat..."); }
}
public class Dog : Animal
{
    public void bark() 
    
    { Console.WriteLine("Dog can bark..."); }
}
public class BabyDog : Dog
{
    public void weep()
    
    { Console.WriteLine("Weeping..."); }
}
class Animal2
{
    public static void Main(string[] args)
    {
        BabyDog d1 = new BabyDog();
        d1.eat();
        d1.bark();
        d1.weep();
    }
}