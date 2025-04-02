using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color _color;
        private float _radius;
        private int _throwCount;

        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _throwCount = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _throwCount++;
            }
        }

        public int GetTimesThrown()
        {
            return _throwCount;
        }

        public override string ToString()
        {
            return $"Sphere({_color}, Radius: {_radius}, Times Thrown: {_throwCount})";
        }
    }
}
