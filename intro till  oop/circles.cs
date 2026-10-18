using System;
using System.Collections.Generic;
using System.Text;

namespace intro_till__oop
{
        public class Circle
        {
        float _pi = 3.141f;
        int Radius;

        // Constructor
        public Circle(int radius)
        {
            Radius = radius;
        }

        // Calculate the area
        public float GetArea()
        {
            return Radius * Radius * _pi;
        }
    }
    
}

