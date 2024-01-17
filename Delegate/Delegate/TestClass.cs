namespace Delegate;














public abstract class TestClass
{
    public abstract void Write();
    public void AddCar(int a, int b)
    {
        System.Console.WriteLine(a + b);
    }



}

public class Sedan : TestClass
{
    public override void Write()
    {
        throw new NotImplementedException();
    }
}
public class Truck : TestClass
{
    public override void Write()
    {
        throw new NotImplementedException();
    }
}
public class Car : TestClass
{
    public override void Write()
    {
        throw new NotImplementedException();
    }




}


