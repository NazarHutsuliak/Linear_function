namespace LinearLibrary
{
    public class LinearFunction
    {
        private readonly Coordinates _coordinates;

        public Fraction K { get; private set; }
        public Fraction B { get; private set; }


        public LinearFunction(Coordinates coordinates)
        {
            _coordinates = coordinates;       
            K = new Fraction(0,  _coordinates.Y2 - _coordinates.Y1, _coordinates.X2 - _coordinates.X1);
            B = new Fraction(0, (_coordinates.X2 - _coordinates.X1) * _coordinates.Y1 - (_coordinates.Y2 - _coordinates.Y1)*_coordinates.X1 , _coordinates.X2 - _coordinates.X1);
               
        }
        
        public override string ToString()
        {   
            if(_coordinates.X1==_coordinates.Y1 && _coordinates.X2 == _coordinates.Y2)
                return  $"y = x";
            
            if (_coordinates.X1 == _coordinates.X2)
                return $"x = {_coordinates.X1}";

            if (_coordinates.Y1 == _coordinates.Y2)
                return $"y = {_coordinates.Y1}";

            if (B.sign == "+")
                return $"y = {K} * x + {B}";
            else
                return $"y = {K} * x {B}";
        }
    }
}
