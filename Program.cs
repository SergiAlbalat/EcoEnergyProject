using System;
namespace EcoEnergyProject
{
    public class Program
    {
        public static void Main()
        {
            const string ErrorNoOpcio = "La opcio escollida no existeix";
            bool sortir = false;
            try
            {
                while (!sortir)
                {
                    MyMethods.PrintMenu();
                    switch (MyMethods.IntroduirNum())
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            sortir = true;
                            break;
                        default:
                            Console.WriteLine(ErrorNoOpcio);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}