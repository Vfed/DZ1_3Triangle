using System;

namespace W1DZ1_3Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            Console.Write("Enter katet1 length :");
            bool k1_check = Int32.TryParse(Console.ReadLine(), out int k1);
            Console.Write("Enter katet1 length :");
            bool k2_check = Int32.TryParse(Console.ReadLine(), out int k2);
            double gep =0;
            double angl1 = 0, angl2 = 0;
            if (k1 <= 0 && k2 <= 0) {
                error += "katets cant be 0 or negative; ";
            }

            if (k1_check && k2_check)
            {
                gep = Math.Sqrt( k1*k1 + k2*k2);
                angl1 = Math.Round(Math.Acos(k1 / gep)*(180/Math.PI),3);
                angl2 = Math.Round(Math.Acos(k2 / gep) * (180 / Math.PI),3);
                gep = Math.Round(gep, 3);
            }
            else 
            {
                error += "Some katet problems; ";
            }

            if (error.Length > 0)
            {
                Console.WriteLine(error);
            }
            else 
            {
                Console.WriteLine("\n Hipotenuza = " + gep+"\n Angle1 = "+angl1+"\n Angle2 = "+angl2);
            }
            Console.ReadKey();
        }
    }
}
