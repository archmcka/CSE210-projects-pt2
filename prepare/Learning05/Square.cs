using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Square: Shape 
{
    private double _side;

    public Square (double side, string color) : base (color)    
    {
        _side = side;
    }
    public override double GetArea()
        {

        return _side * _side;
    }
}