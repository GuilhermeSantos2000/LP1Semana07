using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color Red = new Color(255, 0, 0);
            Color Blue = new Color(0, 0, 255);
            Color Green = new Color(0, 255, 0);

            Sphere redSphere = new Sphere(Red, 10);
            Sphere blueSphere = new Sphere(Blue, 15);
            Sphere greenSphere = new Sphere(Green, 20);

            redSphere.Throw();
            redSphere.Throw();
            blueSphere.Throw();

            greenSphere.Pop();

            Console.WriteLine(redSphere);
            Console.WriteLine(blueSphere);
            Console.WriteLine(greenSphere);
        }
    }
}
