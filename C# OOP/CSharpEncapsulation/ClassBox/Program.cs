using System;

namespace ClassBox
{
    public class StartUp
    {
       

        static void Main(string[] args)
        {
            try
            {
                var lenght = double.Parse(Console.ReadLine());
                var widht = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                Box box = new Box(lenght, widht, height);

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurFaceArea():f2}");
                Console.WriteLine($"Volume - {box.GetVolume():f2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
