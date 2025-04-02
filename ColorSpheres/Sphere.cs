using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private byte _color;
        private float _radius;
        private int _throwCount;

        public Sphere(byte color, float radius)
        {
            _color = color;
            _radius = radius;
            _throwCount = 0;
        }

        public void Pop()
        {
            radius = 0;
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
    }
}
