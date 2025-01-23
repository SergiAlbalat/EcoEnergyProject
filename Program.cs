using System;
namespace EcoEnergyProject
{
    public class Program
    {
        public static void Main()
        {
            const string MsgNumeroSim = "Cuantes simulacions vols executar?";
            const string MsgCreacioCorrecte = "La simulació ha sigut creada correctament";
            const string ErrorNoOpcio = "La opcio escollida no existeix";
            const string MsgInfoTaula = "Tipus de Energia\tEnergia Generada:\tData Creació:";
            const string MsgInfoSim = "{0}\t\t\t{1}\t\t\t{2}";
            const string MsgFinalTaula = "Prem un botó per tornar al menu inicial";
            const int MinTipus = 1;
            const int MaxTipus = 3;
            SistemaEnergia[] llistaSimulacions = new SistemaEnergia[300];

            bool sortir = false;
            MyMethods.ImprimirMenu();
            try
            {
                while (!sortir)
                {
                    switch (MyMethods.IntroduirNum())
                    {
                        case 1:
                            Console.WriteLine(MsgNumeroSim);
                            int numeroSimulacions = MyMethods.IntroduirNum();
                            for(int i = 0; i < numeroSimulacions; i++)
                            {
                                int tipus;
                                double parametre;
                                MyMethods.ImprimirMenuObjecte();
                                do
                                {
                                    tipus = MyMethods.IntroduirNum();
                                } while (!MyMethods.NumDinsRang(tipus, MinTipus, MaxTipus));
                                MyMethods.ImprimirMenuParametres(tipus);
                                parametre = MyMethods.IntroduirNum();
                                llistaSimulacions[SistemaEnergia.ContadorSimulacions] = MyMethods.CrearSimulacio(tipus, parametre);
                                Console.WriteLine(MsgCreacioCorrecte);
                            }
                            MyMethods.ImprimirMenu();
                            break;
                        case 2:
                            
                            Console.WriteLine(MsgInfoTaula);
                            for (int i = 0; i < SistemaEnergia.ContadorSimulacions; i++)
                            {
                                Console.WriteLine(MsgInfoSim, llistaSimulacions[i].GetTipus(), llistaSimulacions[i].GetEnergia(), llistaSimulacions[i].GetData());
                            }
                            Console.WriteLine(MsgFinalTaula);
                            string? relleno = Console.ReadLine();
                            MyMethods.ImprimirMenu();
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