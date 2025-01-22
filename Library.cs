using System;
namespace EcoEnergyProject
{
    public class MyMethods
    {
        public static void PrintMenu()
        {
            const string Title = "### ###   ## ##    ## ##            ### ###  ###  ##  ### ###  ### ##    ## ##   ##  ##   \r\n ##  ##  ##   ##  ##   ##            ##  ##    ## ##   ##  ##   ##  ##  ##   ##  ##  ##   \r\n ##      ##       ##   ##            ##       # ## #   ##       ##  ##  ##       ##  ##   \r\n ## ##   ##       ##   ##            ## ##    ## ##    ## ##    ## ##   ##  ###   ## ##   \r\n ##      ##       ##   ##            ##       ##  ##   ##       ## ##   ##   ##    ##     \r\n ##  ##  ##   ##  ##   ##            ##  ##   ##  ##   ##  ##   ##  ##  ##   ##    ##     \r\n### ###   ## ##    ## ##            ### ###  ###  ##  ### ###  #### ##   ## ##     ##     \r\n                                                                                          \r\n";
            const string Options = "\t\t\tSi us plau escolleig una opció:\n\t\t\t1- Iniciar Simulació\n\t\t\t2- Veure informe de simulacions\n\t\t\t3- Sortir";
            Console.WriteLine(Title);
            Console.WriteLine(Options);
        }

        public static int IntroduirNum()
        {
            const string MissatgeError = "Opció no vàlida. Si us plau, torna-ho a intentar.";

            if (!int.TryParse(Console.ReadLine(), out int opcio))
            {
                throw new FormatException(MissatgeError);
            }
            return opcio;
        }
    }
}
