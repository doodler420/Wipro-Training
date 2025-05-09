using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape");
    }
}

class Circle : Shape
{
    // Override the base class Draw method
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Program
{
    static void Main()
    {        
        // Demonstrate polymorphism 
        Shape shapeRef = new Circle();
        shapeRef.Draw();  // Output: "Drawing a Circle"
        
        // Compare with base class behavior
        Shape baseShape = new Shape();
        baseShape.Draw(); // Output: "Drawing a generic shape"
    }
}