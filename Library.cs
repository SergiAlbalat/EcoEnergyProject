using System;
namespace EcoEnergyProject
{
    public static class MyMethods
    {
        /// <summary>
        /// Imprimeix el menu principal
        /// </summary>
        public static void ImprimirMenu()
        {
            const string Title = "### ###   ## ##    ## ##            ### ###  ###  ##  ### ###  ### ##    ## ##   ##  ##   \r\n ##  ##  ##   ##  ##   ##            ##  ##    ## ##   ##  ##   ##  ##  ##   ##  ##  ##   \r\n ##      ##       ##   ##            ##       # ## #   ##       ##  ##  ##       ##  ##   \r\n ## ##   ##       ##   ##            ## ##    ## ##    ## ##    ## ##   ##  ###   ## ##   \r\n ##      ##       ##   ##            ##       ##  ##   ##       ## ##   ##   ##    ##     \r\n ##  ##  ##   ##  ##   ##            ##  ##   ##  ##   ##  ##   ##  ##  ##   ##    ##     \r\n### ###   ## ##    ## ##            ### ###  ###  ##  ### ###  #### ##   ## ##     ##     \r\n                                                                                          \r\n";
            const string Options = "\t\t\tSi us plau escolleig una opció:\n\t\t\t1- Iniciar Simulació\n\t\t\t2- Veure informe de simulacions\n\t\t\t3- Sortir";
            Console.WriteLine(Title);
            Console.WriteLine(Options);
        }

        /// <summary>
        /// Imprimeix el menu per seleccionar el tipus de simulació
        /// </summary>
        public static void ImprimirMenuObjecte()
        {
            const string MsgTipusEnergia = "Simulació numero {0}:\nQuin tipus d'energia utilitzara la simulació:\n1- Energia Solar\n2- Energia Eolica\n3- Energia Hidroelectrica";
            Console.WriteLine(MsgTipusEnergia, SistemaEnergia.GetContador() +1);
        }

        /// <summary>
        /// Imprimeix el menu per introduir el parametre corresponent depenent del tipus
        /// </summary>
        /// <param name="tipus">Tipus de simulació</param>
        public static void ImprimirMenuParametres(int tipus)
        {
            const string MsgParametreSolar = "Quantes hores al dia li donarà el sol? Valor minim 1 hora";
            const string MsgParametreEolic = "Quina es la velocitat en m/s a la que el vent mou el generador? Valor minim 5m/s";
            const string MsgParametreHidroelectric = "Quin es el cabal d'aigua que passa pel generador? Valor minim 20 metres cubics";
            switch (tipus)
            {
                case 1:
                    Console.WriteLine(MsgParametreSolar);
                    break;
                case 2:
                    Console.WriteLine(MsgParametreEolic);
                    break;
                case 3:
                    Console.WriteLine(MsgParametreHidroelectric);
                    break;
            }
        }

        /// <summary>
        /// Crear la simulació del tipus corresponent
        /// </summary>
        /// <param name="tipus">Tipus de simulació</param>
        /// <param name="argument">Argument utilitzat pel constructor</param>
        /// <returns>Instancia de la clase corresponent</returns>
        public static SistemaEnergia CrearSimulacio(int tipus, double argument)
        {
            const string MsgErrorForaRang = "El tipus seleccionat es troba fora de rang";
            switch (tipus)
            {
                case 1:
                    return new SistemaSolar(argument);
                case 2:
                    return new SistemaEolic(argument);
                case 3:
                    return new SistemaHidroelectric(argument);
                default:
                    throw new ArgumentOutOfRangeException(MsgErrorForaRang);
            }
        }

        /// <summary>
        /// Valida que el valor introduit sigui un número
        /// </summary>
        /// <returns>El número validad</returns>
        public static int IntroduirNum()
        {
            const string MissatgeError = "Opció no vàlida.";

            if (!int.TryParse(Console.ReadLine(), out int opcio))
            {
                throw new FormatException(MissatgeError);
            }
            return opcio;
        }

        /// <summary>
        /// Comprova que el número estigui dins del rang determinat
        /// </summary>
        /// <param name="num">Número a comprovar.</param>
        /// <param name="min">Minim del rang</param>
        /// <param name="max">Maxim del rang</param>
        /// <returns>Boolea que confirma si esta dins del rang</returns>
        public static bool NumDinsRang(int num, int min, int max)
        {
            return num >= min && num <= max;
        }
    }
}
