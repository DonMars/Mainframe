using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Mainframe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Notas
            // Uso de continue; para regresar al inicio de un loop
            // Uso de #region y #regionend para la organización del código

            // Estación de Pruebas

            // Introducción /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Pantalla de Carga
            #region
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ░░░░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                       Cargando 0%");
            Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ▒░░░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                       Cargando 4%");
            Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      █▒░░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 15%");
            Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ████░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 32%");
            Thread.Sleep(2500);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ██████████▒░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 74%");
            Thread.Sleep(500);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ███████████░░");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 82%");
            Thread.Sleep(200);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ████████████▒");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 96%");
            Thread.Sleep(300);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ████████████▒");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 97%");
            Thread.Sleep(200);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ████████████▒");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 98%");
            Thread.Sleep(700);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                      ████████████▒");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                                      Cargando 99%");
            Thread.Sleep(2000);
            Console.Clear();

            // Intro Logo
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                   #      # #           #");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                   #      # #           #");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                # #      #  #  #       #");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.WriteLine("                                                   #      # #           #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                # #      #  #  #       #");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                 #      #   # #      # #");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.WriteLine("                                                   #      # #           #");
            Console.WriteLine("                                                # #      #  #  #       #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                 #      #   # #      # #");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                  #    #    ##     #     #");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.WriteLine("                                                   #      # #           #");
            Console.WriteLine("                                                # #      #  #  #       #");
            Console.WriteLine("                                                 #      #   # #      # #");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                  #    #    ##     #     #");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.WriteLine("                                                   #      # #           #");
            Console.WriteLine("                                                # #      #  #  #       #");
            Console.WriteLine("                                                 #      #   # #      # #");
            Console.WriteLine("                                                  #    #    ##     #     #");
            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                                                      Mars Presenta");
            Thread.Sleep(2500);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                             ########     # #     #######");
            Console.WriteLine("                                                   #      # #           #");
            Console.WriteLine("                                                # #      #  #  #       #");
            Console.WriteLine("                                                 #      #   # #      # #");
            Console.WriteLine("                                                  #    #    ##     #     #");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                                                      Mars Presenta");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                      Mars Presenta");
            Thread.Sleep(250);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                      Mars Presenta");
            Thread.Sleep(250);
            Console.Clear();
            Thread.Sleep(1500);
            #endregion

            // Juego ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Variables Prime (Reinicio del juego y Progreso Global)
            #region
            // bool que permite el reinicio del juego a partir de éste punto
            bool gameReset = true;

            // Variable que permite revisar un progreso global del juego
            int progresoGlobal = 0;
            // El progreso estaría basado en la totalidad del juego vista o explorada
            // Se reinicia hasta que se cierra el programa
            #endregion


            // Reinicio
            do
            {
                // Variables que permiten controlar el menú
                string menu = "0";
                int menuConv = 0;

                // Menú Principal
                #region
                do
                {
                    // Título del juego
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n\n\n           .-. . . .-. \r\n            |  |-| |-   '||    ||'     |     '||' '|.   '|' '||''''| '||''|.       |     '||    ||' '||''''|  \r\n            '  ' ` `-'   |||  |||     |||     ||   |'|   |   ||  .    ||   ||     |||     |||  |||   ||  .    \r\n                         |'|..'||    |  ||    ||   | '|. |   ||''|    ||''|'     |  ||    |'|..'||   ||''|    \r\n                         | '|' ||   .''''|.   ||   |   |||   ||       ||   |.   .''''|.   | '|' ||   ||       \r\n                        .|. | .||. .|.  .||. .||. .|.   '|  .||.     .||.  '|' .|.  .||. .|. | .||. .||.....| ");
                    Thread.Sleep(250);
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n\n\n           .-. . . .-. \r\n            |  |-| |-   '||    ||'     |     '||' '|.   '|' '||''''| '||''|.       |     '||    ||' '||''''|  \r\n            '  ' ` `-'   |||  |||     |||     ||   |'|   |   ||  .    ||   ||     |||     |||  |||   ||  .    \r\n                         |'|..'||    |  ||    ||   | '|. |   ||''|    ||''|'     |  ||    |'|..'||   ||''|    \r\n                         | '|' ||   .''''|.   ||   |   |||   ||       ||   |.   .''''|.   | '|' ||   ||       \r\n                        .|. | .||. .|.  .||. .||. .|.   '|  .||.     .||.  '|' .|.  .||. .|. | .||. .||.....| ");
                    Thread.Sleep(250);
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\n           .-. . . .-. \r\n            |  |-| |-   '||    ||'     |     '||' '|.   '|' '||''''| '||''|.       |     '||    ||' '||''''|  \r\n            '  ' ` `-'   |||  |||     |||     ||   |'|   |   ||  .    ||   ||     |||     |||  |||   ||  .    \r\n                         |'|..'||    |  ||    ||   | '|. |   ||''|    ||''|'     |  ||    |'|..'||   ||''|    \r\n                         | '|' ||   .''''|.   ||   |   |||   ||       ||   |.   .''''|.   | '|' ||   ||       \r\n                        .|. | .||. .|.  .||. .||. .|.   '|  .||.     .||.  '|' .|.  .||. .|. | .||. .||.....| ");
                    Thread.Sleep(250);
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\n           .-. . . .-. \r\n            |  |-| |-   '||    ||'     |     '||' '|.   '|' '||''''| '||''|.       |     '||    ||' '||''''|  \r\n            '  ' ` `-'   |||  |||     |||     ||   |'|   |   ||  .    ||   ||     |||     |||  |||   ||  .    \r\n                         |'|..'||    |  ||    ||   | '|. |   ||''|    ||''|'     |  ||    |'|..'||   ||''|    \r\n                         | '|' ||   .''''|.   ||   |   |||   ||       ||   |.   .''''|.   | '|' ||   ||       \r\n                        .|. | .||. .|.  .||. .||. .|.   '|  .||.     .||.  '|' .|.  .||. .|. | .||. .||.....| ");
                    Thread.Sleep(2200);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n                                                Subtitulo Chingón Épico");

                    // Control del Ménú
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\n\n\n\n            1. Iniciar programa");
                    Console.WriteLine("            2. Leer archivo readme");
                    Console.WriteLine("            3. Ver créditos");
                    Console.WriteLine("            4. Cerrar el acceso");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n\n\n            Digita el número de tu elección y presiona Enter para continuar");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    menu = Console.ReadLine();
                    Console.Clear();

                    // Valida lo ingresado
                    if (menu == "1" || menu == "2" || menu == "3" || menu == "4")
                    {
                        menuConv = Convert.ToInt32(menu);
                    }
                    else
                        menuConv = 0;
                }
                while (menuConv == 0);
                #endregion

                // Menú Opción 1 - Juego Nuevo
                while (menuConv == 1)
                {
                    // Variables principales
                    #region
                    // Sistema de Progreso
                    int progresoTotal = 0;
                    // El progreso está basado en logros únicos posibles en una misma partida
                    // Se reinicia con cada juego nuevo

                    // Generador de números aleatorios
                    Random numRand = new Random();

                    // Establece las vidas y munición inicial
                    int balas = 6;
                    int vidas = 3;

                    // Establece las llaves iniciales
                    int data = 0;

                    // Establece los bits iniciales
                    int bits = -1;

                    // Inicialización de variables secundarias
                    bool dataCheck = true; // Controla el acceso del final en el juego
                    bool gameOver = false; // Identifica la condición de Game Over
                    bool primerBala = true; // Identifica la primer recolección de munición
                    bool primerBateria = true; // Identifica la primer recolección de baterías
                    bool primerBit = true; // Identifica la primer recolección de bits
                    #endregion

                    //Intro
                    #region
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Inicializando procesos...");
                    Thread.Sleep(2500);
                    Console.WriteLine("\nRAM OK");
                    Console.WriteLine("ROM OK");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDescomprimiendo paquetes de sistema:");
                    Thread.Sleep(1000);
                    Console.WriteLine("0x00002D4EX.pkg");
                    Thread.Sleep(300);
                    Console.WriteLine("0x00006d3NA.pkg");
                    Thread.Sleep(200);
                    Console.WriteLine("0x000011dbF.pkg");
                    Thread.Sleep(200);
                    Console.WriteLine("0x000030MWO.pkg");
                    Thread.Sleep(200);
                    Console.WriteLine("0x000006HJd.pkg");
                    Thread.Sleep(400);
                    Console.WriteLine("\nError: 0x0000117AVQ.pkg NO ENCONTRADO\nSistemas de audio inoperables");
                    Thread.Sleep(200);
                    Console.WriteLine("\nAccesando a memoria interna");
                    Thread.Sleep(600);
                    Console.WriteLine("Recuperando datos corruptos");
                    Thread.Sleep(2500);
                    Console.WriteLine("\nCalibrando sensores neuronales");
                    Thread.Sleep(1500);
                    Console.WriteLine("Cargando Interfaz");
                    Thread.Sleep(500);
                    Console.WriteLine("Decodificando archivo guardado");
                    Thread.Sleep(700);
                    Console.WriteLine("\nSincronizando sistema operativo");
                    Thread.Sleep(3000);
                    Console.Clear();

                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sincronización neuronal completa");
                    Thread.Sleep(2000);
                    Console.Clear();
                    #endregion

                    // Inicio de la historia
                    #region
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Recargas por última vez tu revolver digital,");
                    Thread.Sleep(2000);
                    Console.WriteLine("los casquillos flotan hacia arriba, deshaciéndose en ceros y unos");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nCorres mientras miras por tu hombro, dos anti-agentes te persiguen\ndesde el tiroteo en los conductos");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nDe acuerdo a tu memoria, el acceso a la interfaz central está cerca");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    #endregion

                    // Primeras decisiones - Introducción a las mecánicas del juego
                    #region
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(1000);
                    Console.WriteLine("Después de avanzar un poco, llegas a lo que parece ser un acceso principal");
                    Thread.Sleep(2000);
                    Console.WriteLine("Puedes ver que está protegido por un sistema de defensas automático");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nNo te sobra el tiempo, y tienes que tomar una decisión:");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n1. Dispararle al sistema usando 1 bala de las seis que te quedan");
                    Console.WriteLine("2. Continuar con sigilo y tratar que el sistema no te vea");
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Gray;    
                    Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string eleccion = Console.ReadLine();
                    Console.Clear();

                    if (eleccion == "1" || eleccion == "2")
                    {
                        // Este if únicamente valida valor ingresado, si no es válido se reinicia el juego
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error, ingreso inválido");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEl juego se reiniciará");
                        Thread.Sleep(1000);
                        Console.WriteLine("\nPor favor intente de nuevo");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nPresiona cualquier tecla para continuar");
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    }
                        

                    if (eleccion == "1")
                    {
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tomas un respiro durante unos segundos, dejando todo\npensamiento atrás y sales de tu cobertura para disparar");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nEl sistema de defensas te reconoce inmediatamente,\npero disparas primero y...");
                        balas -= 1;
                        Thread.Sleep(3000);

                        int numeroRandom = Convert.ToInt32(numRand.Next(1, 51));

                        if (numeroRandom <= 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nLe das justo en el centro, haciéndolo explotar\nen cientos de ceros y unos");
                            Thread.Sleep(3000);

                            // Obtención de recursos de forma aleatoria
                            numeroRandom = numRand.Next(1, 9);

                            if (numeroRandom == 8)
                            {
                                primerBala = false;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nRevisas el área, y notas el brillo de un pequeño\nnúcleo azúl de munición");
                                Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nTu revólver está programado para convertir munición\ndígital de cualquier tipo");
                                Thread.Sleep(2000);
                                Console.WriteLine("\nLo recolectas, añadiéndo una bala adicional a tus recursos");
                                Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nPuedes tener un número ilimitado de balas");
                                balas += 1;
                            }
                            else if (numeroRandom < 8)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nRevisas el área, pero no encuentras nada");
                            }

                            Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nPresiona cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Thread.Sleep(2000);
                            Console.WriteLine("Todas las luces de alrededor se vuelven rojas\ny una alarma comienza a sonar en el área");
                            Thread.Sleep(2000);
                            Console.WriteLine("\nCorres rápidamente hacia la entrada y das un salto\npara cruzar por la puerta momentos antes de que cierre");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Thread.Sleep(3000);
                            Console.WriteLine("\nPresiona cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (numeroRandom <= 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nFallas el disparo");
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nTodas las luces de alrededor se vuelven rojas\ny una alarma comienza a sonar en el área");
                            Thread.Sleep(3000);

                            numeroRandom = numRand.Next(1, 4);

                            if (numeroRandom > 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nlas defensas apuntan y te logran dar un disparo,\nsientes una gran carga de energía fluyendo fuera de tí");
                                vidas -= 1;
                                Thread.Sleep(4000);
                            }
                            else if (numeroRandom <= 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nLas defensas te apuntan y disparan, pero no logran darte");
                                Thread.Sleep(3000);
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nTe impulsas dándo un salto para cruzar por\nla puerta momentos antes de que se cierre");
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nPresiona cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    if (eleccion == "2")
                    {
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Decides avanzar cuidadosamente sin hacer ruido, evitando\nllamar la atención de las defensas");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nNotas que hay una ventana de oportunidad en la que el\nsistema deja de vigilar durante unos segundos el punto\nexacto de acceso, y decides aprovechar ese momento");
                        Thread.Sleep(4000);
                        Console.WriteLine("\nHaces lo posible y te acercas por un tramo, estás a\nescasos metros de la entrada a punto de lograrlo...");
                        Thread.Sleep(3000);
                        Console.WriteLine("\n... cuándo una entidad pequeña e inidentificable\naparece de pronto entre los circuitos, omitiendo\nun pitido agudo que indica al sistema tu dirección");
                        Thread.Sleep(5000);
                        Console.WriteLine("\nLas defensas toman menos de un segundo en reconocerte");
                        Thread.Sleep(2000);
                        Console.WriteLine("Una alarma se activa y la puerta comienza a cerrarse");
                        Thread.Sleep(2000);
                        int numeroRandom;
                        numeroRandom = numRand.Next(1, 5);

                        if (numeroRandom >= 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nLas defensas apuntan, y te logran dar un disparo\nSientes una gran carga de energía fluyendo fuera de tí");
                            vidas -= 1;
                            Thread.Sleep(3000);
                        }
                        else if (numeroRandom < 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nLas defensas te apuntan y disparan, pero no logran darte");
                            Thread.Sleep(3000);
                        }
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nTe impulsas dándo un salto para cruzar por la puerta\nmomentos antes de que se cierre");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    #endregion

                    // Resultados del tutorial
                    #region
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("La puerta se cierra justo detrás de tí");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nHas llegado a tu destino, estás dentro del procesador central");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nPero ahora no tienes otra salida. Estás en cuarentena del más bajo nivel, y la\nencriptación de seguridad te es imposible de descifrar");
                    Thread.Sleep(4000);
                    Console.WriteLine("\nTe encuentras en un corredor que parece estar hecho de luz. Tanto el piso, cómo el techo\nestán completamente iluminados por una luz muy brillante que no te permite ver hasta el final");
                    Thread.Sleep(4000);
                    Console.WriteLine("\nRevisas el estado de tu revólver y tu carga de energía");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n// Tienes " + balas + " Balas - Te permiten dispararle a enemigos u objetos con tu revólver digital");
                    Console.WriteLine("// Tienes " + vidas + " Baterías - Almacenan la energía que te permite correr en éste plano");
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPuedes llevar contigo la munición que logres obtener y puedes tener hasta 5 baterías");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (vidas == 2)
                    {
                        Console.WriteLine("\nTus heridas no son graves, pero te quedan " + vidas + " baterías de las 3 que tenías");
                        Thread.Sleep(4000);
                    }
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n¡Si te quedas sin baterías dejarás de ejecutarte!");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nAvanzas por el corredor, dejando atrás el sonido de las alarmas");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(1000);
                    Console.WriteLine("Acercándote al final, notas que el corredor da hacia un cuarto\namplio, repleto de puertos y circuitos");
                    Thread.Sleep(3500);
                    Console.WriteLine("\nParece ser el control de accesos");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nNo tienes otro lugar hacia dónde ir y decides entrar");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    // Conceptos: Llaves de acceso, Condición de Victoria
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Te encuentras ante una gran sala circular con numerosos puertos,\nconexiones a otros espacios dentro del mismo plano");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nConectarte a esos puertos te llevaría a lugares desconocidos");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nEn el centro hay una plataforma circular dorada con un puerto principal");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nEstá rodeada por cinco pedestales de seguridad que te impiden\nacceder a ese espacio y al puerto");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPara ello necesitas encontrar 5 llaves de acceso administrativo");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\ny colocarlos en los pedestales para desbloquear acceso al procesador");
                    Thread.Sleep(2500);
                    Console.WriteLine("\nEstos paquetes de información están encriptados en algún lugar del sistema");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nTe acercas a los puertos para examinarlos y tomar una decisión");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nEn el menú de accesos podrás ver el estado actual\nde tus recursos y el progreso de la misión");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    #endregion

                    // Inicialización de variables para el juego a partír de éste punto
                    #region

                    // Control de Enemigos

                    // Niveles de Combate
                    int nivelCombate = 1;

                    // Vida del Enemigo
                    int hpEnemigo = 0;

                    // Daño del Enemigo
                    int dañoEnemigo = 0;

                    // Condición del Enemigo
                    int condicionEnemigo = 0;

                    // En Combate
                    bool enCombate = false;


                    // Escenarios programados
                    bool introHertz = true;
                    bool engraneSorpresa = true;
                    bool engraneSorpresa2 = true;
                    #endregion

                    // Inicialización de variables para el manejo del HUB
                    #region
                    // Variable 'menuDelay' controla la velocidad de impresión del menú
                    bool menuDelay = true;

                    // Variable 'puerto' controla acceso al puerto desde el menú
                    bool puerto1 = true;
                    bool puerto2 = true;
                    bool puerto3 = true;
                    bool puerto4 = true;
                    bool puerto5 = true;
                    bool puerto6 = true;
                    bool puerto7 = true;
                    bool puerto8 = true;
                    bool puerto9 = true;
                    bool puerto10 = true;
                    bool puerto11 = false;

                    // Variable 'switch' controla la elección actual del puerto en el menú
                    bool switch1 = false;
                    bool switch2 = false;
                    bool switch3 = false;
                    bool switch4 = false;
                    bool switch5 = false;
                    bool switch6 = false;
                    bool switch7 = false;
                    bool switch8 = false;
                    bool switch9 = false;
                    bool switch10 = false;
                    bool switch11 = false;
                    #endregion

                    // HUB Principal - Control de Accesos
                    while (dataCheck)
                    {
                        // Actualiza el nivel de combate de los Enemigos dependiendo de el progreso de la partida
                        #region
                        if (data == 1)
                        {
                            nivelCombate = 2;
                        }
                        else if (data == 2)
                        {
                            nivelCombate = 3;
                        }
                        else if (data == 3)
                        {
                            nivelCombate = 4;
                        }
                        #endregion

                        // Recordatorio de Variables
                        #region
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("===========================================================");
                        Thread.Sleep(200);
                        if (data == 0 && bits == -1)
                        {
                            Console.WriteLine("// Baterías: " + vidas + "   // Balas: " + balas);
                        }
                        else if (data > 0 && bits == -1)
                        {
                            Console.WriteLine("// Baterías: " + vidas + "   // Balas: " + balas + "   // Llaves: " + data);
                        }
                        else if (data == 0 && bits > -1)
                        {
                            Console.WriteLine("// Baterías: " + vidas + "   // Balas: " + balas + "   // Bits: " + bits);
                        }
                        else if (data > 0 && bits > -1)
                        {
                            Console.WriteLine("// Baterías: " + vidas + "   // Balas: " + balas + "   // Llaves: " + data + "   // Bits: " + bits);
                        }
                        Thread.Sleep(200);
                        Console.WriteLine("===========================================================");
    
                        // Progreso de la misión
                        Thread.Sleep(1000);
                        if (data == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Progreso: 0%");
                        }
                        else if (data == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Progreso: 20%");
                        }
                        else if (data == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Progreso: 40%");
                        }
                        else if (data == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Progreso: 60%");
                        }
                        else if (data == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Progreso: 80%");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Progreso: 100%");
                        }
                        #endregion

                        // Selección de Acceso
                        #region
                        // Cambia la velocidad en la que se despliega el siguiente texto del menú
                        if (menuDelay == true)
                        {
                            Thread.Sleep(3000);
                        }
                        else if (menuDelay == false)
                        {
                            Thread.Sleep(1000);
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nVes 10 puertos y un puerto principal");
                        Console.WriteLine("Los símbolos de cada uno son:");
    
                        // Cambia la velocidad en la que se despliega el siguiente texto del menú
                        if (menuDelay == true)
                        {
                            Thread.Sleep(2000);
                        }
                        else if (menuDelay == false)
                        {
                            Thread.Sleep(1000);
                        }
    
                        // Listado de puertos
                        if (puerto1 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("\n1. Nota musical");
                        Thread.Sleep(80);
                        if (puerto2 == true)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("2. Hoja de Árbol");
                        Thread.Sleep(75);
                        if (puerto3 == true)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("3. Cerebro humano");
                        Thread.Sleep(70);
                        if (puerto4 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("4. Engrane");
                        Thread.Sleep(60);
                        if (puerto5 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("5. Signo de interrogación");
                        Thread.Sleep(50);
                        if (puerto6 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("6. Gota de Agua");
                        Thread.Sleep(40);
                        if (puerto7 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("7. Microchip");
                        Thread.Sleep(30);
                        if (puerto8 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("8. Pantalla con Antenas");
                        Thread.Sleep(20);
                        if (puerto9 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("9. Prisma");
                        Thread.Sleep(10);
                        if (puerto10 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("10. Estrella");
                        if (puerto11 == true)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("11. Puerto Principal");
    
                        // Cambia la velocidad en la que se despliega el siguiente texto del menú
                        if (menuDelay == true)
                        {
                            Thread.Sleep(3000);
                            menuDelay = false;
                        }
                        else
                        {
                            Thread.Sleep(1000);
                        }
    
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        eleccion = Console.ReadLine();
                        Console.Clear();

                        // Switch que valida la elección del jugador
                        switch (eleccion)
                        {
                            case "1":
                                switch1 = true;
                                break;
                            case "2":
                                switch2 = true;
                                break;
                            case "3":
                                switch3 = true;
                                break;
                            case "4":
                                switch4 = true;
                                break;
                            case "5":
                                switch5 = true;
                                break;
                            case "6":
                                switch6 = true;
                                break;
                            case "7":
                                switch7 = true;
                                break;
                            case "8":
                                switch8 = true;
                                break;
                            case "9":
                                switch9 = true;
                                break;
                            case "10":
                                switch10 = true;
                                break;
                            case "11":
                                switch11 = true;
                                break;
                        }
                        #endregion

                        // Puertos - Espacios

                        // Puerto 1 - Nota Músical ////////////////////////////////////////////////////
                        /// /// /// L O R E /// /// ///

                        if (switch1 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen2();

                            // Inicio
                            {
                                if (introHertz == true)
                                {
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Tu visión tarda un poco en ajustarse a la luz");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nPuedes ver que estás en un espacio completamente vacío\ny rojo. No hay piso, no hay nada. Estás flotando");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("\nEsperas unos momentos para ver si sucede algo, pero no\npasa nada, te preguntas si debes romper la conexión");
                                    Thread.Sleep(4000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n1. Romper la conexión y regresar al control de accesos");
                                    Console.WriteLine("2. Esperar unos momentos más");
                                    Console.WriteLine("3. Gritar en el vacío");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    eleccion = Console.ReadLine();
                                    Console.Clear();

                                    if (eleccion == "1")
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Decides terminar la conexión");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nAntes de irte, sientes que podrías estar olvidando algo\npero no realizaste ningún cambio al sistema, y puedes\nvolver después si así lo decides");
                                        Thread.Sleep(4000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                        Console.ReadKey();
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        //Te regresa al menú de puertos y puedes volver a accesar
                                        Disconnect();
                                        switch1 = false;
                                        continue;
                                    }
                                    else if (eleccion == "2")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Te quedas esperando unos minutos, pero no sucede nada\ny sientes que pierdes el tiempo");
                                        Thread.Sleep(2500);
                                        Console.WriteLine("\nEstás a punto de irte, y escuchas un débil murmullo\nproveniente del vacío");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nPero no logras descifrar lo que dice, se escuchó\ncómo si la fuente estuviese lejos");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("\nEsperas un poco más, pero no vuelve a pasar");
                                        Thread.Sleep(1500);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\n1. Romper la conexión y regresar al control de accesos");
                                        Console.WriteLine("2. Gritar en el vacío");
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        eleccion = Console.ReadLine();
                                        Console.Clear();

                                        if (eleccion == "1")
                                        {
                                            Thread.Sleep(2000);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Has tenido suficiente y decides regresar");
                                            Thread.Sleep(2000);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("\nAntes de irte, sientes que podrías estar olvidando algo\npero no realizaste ningún cambio al sistema, y puedes\nvolver después si así lo decides");
                                            Thread.Sleep(4000);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                            Console.ReadKey();
                                            Thread.Sleep(1000);
                                            Console.Clear();

                                            //Te regresa al menú de puertos y puedes volver a accesar
                                            Disconnect();
                                            switch1 = false;
                                            continue;
                                        }

                                        else if (eleccion == "2")
                                        {
                                            Thread.Sleep(1000);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Gritas hacia el vacío rojo");
                                            Thread.Sleep(2000);
                                        }
                                        else
                                        {
                                            Thread.Sleep(1000);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("ERROR: Registro Inválido");
                                            Thread.Sleep(2000);
                                            Console.WriteLine("\nConexión anulada por el servidor");
                                            Thread.Sleep(2000);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("\nPresiona cualquier tecla para desconectarte");
                                            Console.ReadKey();

                                            //Te regresa al menú de puertos y puedes volver a accesar
                                            Disconnect();
                                            switch1 = false;
                                            continue;
                                        }

                                    }
                                    else if (eleccion == "3")
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Gritas hacia el vacío rojo");
                                        Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("ERROR: Registro Inválido");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nConexión anulada por el servidor");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para desconectarte");
                                        Console.ReadKey();

                                        //Te regresa al menú de puertos y puedes volver a accesar
                                        Disconnect();
                                        switch1 = false;
                                        continue;
                                    }

                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nPero no sucede nada durante varios minutos");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nDecides regresar al control de puertos");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nEstás a punto de irte, cuándo escuchas lo que parece\nuna voz que proviene desde muy lejos, apenas pudiste\noirlo entre el sonido hueco del vacío");
                                    Thread.Sleep(4500);
                                    Console.WriteLine("\nGritas con todas tus fuerzas de regreso, y esperas un\nmomento pero no obtienes respuesta");
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n1. Romper la conexión y regresar al control de accesos");
                                    Console.WriteLine("2. Esperar un poco más");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    eleccion = Console.ReadLine();
                                    Console.Clear();

                                    if (eleccion == "1")
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Decides terminar la conexión");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nJusto antes de irte, te distrae un sonido distante\nque poco a poco se está acercando");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("\nEs una voz gritando");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                        Console.ReadKey();
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    else if (eleccion == "2")
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Decides esperar unos momentos más, pero no pasa mucho\ntiempo hasta que escuchas algo de nuevo");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nUn sonido sordo que lentamente se está acercando");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("\nEs una voz gritando");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                        Console.ReadKey();
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("ERROR: Registro Inválido");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nConexión anulada por el servidor");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para desconectarte");
                                        Console.ReadKey();

                                        //Te regresa al menú de puertos y puedes volver a accesar
                                        Disconnect();
                                        switch1 = false;
                                        continue;
                                    }

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nE...R...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nE..ERA.!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nESPERA!");
                                    Thread.Sleep(2000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nVes flotando hacia tí un punto a lo lejos que tarda unos\nmomentos en acercárse, cuándo lo hace, puedes ver que\nes una especie de forma abstracta compuesta de puntos\ny figuras básicas, cómo circulos y triángulos");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("\nEs una visión muy extraña, y aunque la entidad no se\nmuestra hostil, te preguntas si es seguro");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nCuándo por fín llega contigo, está hablando sola");
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n... por eso el sonido precede a la materia");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nSinfonías enteras son generadas por el sonido de los\nátomos al vibrar en el aire");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("\nEl único límite, es el tiempo");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("\n¡Gracias por esperarme!");
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nParece ser un ente muy inteligente y animado\nsi es que un poco extravagante");
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Hola, mi nombre es Hertz");
                                Thread.Sleep(1000);
                                Console.WriteLine("¿Te importaría charlar conmigo?");
                                Thread.Sleep(2000);

                                if (introHertz == true)
                                {
                                    Console.WriteLine("\nDesde que borraron los archivos del sistema\nestá muy solitario por aquí...");
                                    Thread.Sleep(3200);
                                }

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n1. Escuchar a Hertz");
                                Console.WriteLine("2. Hacerle una pregunta");
                                Console.WriteLine("3. Explicarle tu misión");
                                Console.WriteLine("4. Romper la conexión");
                                Thread.Sleep(2000);

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\nÁrea del juego incompleta :(\nel único límite fué el tiempo");

                                if (introHertz == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\nTe has ganado 2000 Bits!");
                                    bits += 2000;
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n¡Felicidades!");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nPresiona cualquier tecla para desconectarte");
                                    Console.ReadKey();

                                    // Desactiva el Intro de Hertz (DEMO)
                                    introHertz = false;

                                    //Te regresa al menú de puertos y puedes volver a accesar
                                    Disconnect();
                                    switch1 = false;
                                    continue;
                                }

                            }

                            //Te regresa al menú de puertos y puedes volver a accesar
                            Disconnect();
                            switch1 = false;
                            continue;
                        }

                        // Puerto 2 - Hoja de Árbol ///////////////////////////////////////////////////
                        /// /// /// D A T A /// /// ///
                        if (switch2 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();

                            // Inicio
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Al llegar notas que estás en lo alto de una\ncascada, en medio de unas montañas");
                                Thread.Sleep(2500);
                                Console.WriteLine("\nSientes nauseas y por poco pierdes el balance,\nel suelo de piedra que pisas está resbalosa");
                                Thread.Sleep(3000);
                                Console.WriteLine("\nUnas rocas forman una serie de plataformas que\nte permiten bajar la cascada, puedes intentarlo\ny continuar explorando, o romper la conexión y\nregresar al control de accesos");
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n1. Romper la conexión");
                                Console.WriteLine("2.Bajar la cascada");
                                Thread.Sleep(2000);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Digita tu elección y presiona Enter para continuar");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                eleccion = Console.ReadLine();
                                Console.Clear();

                                if (eleccion == "1")
                                {
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Decides regresar al control de accesos");
                                    Thread.Sleep(2000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nAntes de irte, sientes que podrías estar olvidando algo\npero no realizaste ningún cambio al sistema, y puedes\nvolver después si así lo decides");
                                    Thread.Sleep(4000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    //Te regresa al menú de puertos y puedes volver a accesar
                                    Disconnect();
                                    switch2 = false;
                                    continue;
                                }
                                else if (eleccion == "2")
                                {
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Decides continuar explorando el lugar, e intentar\nbajar por la cascada");
                                    Thread.Sleep(3000);
                                }

                                Console.WriteLine("Decides continuar explorando el lugar, e intentar\nbajar por la cascada");
                                Thread.Sleep(3000);

                                //Te regresa al menú de puertos y puedes volver a accesar
                                Disconnect();
                                switch2 = false;
                                continue;
                            }
                        }

                        // Puerto 3 - Cerebro Humano //////////////////////////////////////////////////
                        if (switch3 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();




                            switch3 = false;
                            continue;
                        }

                        // Puerto 4 - Engrane /////////////////////////////////////////////////////////
                        /// /// /// D A T A /// /// ///
                        if (switch4 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();

                            // Inicio
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                if (engraneSorpresa == true)
                                {
                                    Console.WriteLine("Sientes mareos, y tomas unos momentos para\nrecuperar tu balance\n");
                                    Thread.Sleep(2500);
                                }

                                Console.WriteLine("Estás en un túnel ancho, con muros hechos de\nmaquinaria que llegan hasta lo alto del techo\nescondiéndose entre la oscuridad");
                                Thread.Sleep(3500);

                                // Checa si es la primera vez que estás aquí, y procede un escenario de introducción
                                if (engraneSorpresa == true)
                                {
                                    Console.WriteLine("\nEl lugar parece abandonado, patrones de circuitos\ncubren las paredes simulando una naturaleza salvaje");
                                    Thread.Sleep(3500);
                                    Console.WriteLine("\nNada parece estar funcionando, las pocas luces que\niluminan el espacio parpadean cómo si algo fallara en\nsus sistemas de energía");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("\nTe preguntas si debes seguir por éste camino, o si\nserá mejor romper la conexión y regresar después");
                                    Thread.Sleep(3500);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n1. Romper la conexión y regresar al control de accesos\n2. Continuar explorando el lugar");
                                    Thread.Sleep(3000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nDigita tu elección y presiona Enter para continuar");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    eleccion = Console.ReadLine();
                                    Console.Clear();

                                    // Decidir no seguir explorando
                                    if (eleccion == "1")
                                    {
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Decides terminar la conexión");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nAntes de irte sientes que podrías estar olvidando\nalgo, pero no realizaste cambios en el sistema y puedes\nvolver después si así lo decides");
                                        Thread.Sleep(4000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                        Console.ReadKey();
                                        Thread.Sleep(1000);
                                        Console.Clear();


                                        //Te regresa al menú de puertos y puedes volver a accesar
                                        Disconnect();
                                        switch4 = false;
                                        continue;
                                    }
                                    else if (eleccion == "2")
                                    {
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        //Te regresa al menú de puertos y puedes volver a accesar
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("ERROR: Registro Inválido");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("Conexión anulada por el servidor");
                                        Thread.Sleep(2000);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Presiona cualquier tecla para desconectarte");
                                        Console.ReadKey();
                                        Thread.Sleep(1000);

                                        Disconnect();
                                        switch4 = false;
                                        continue;
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nAvanzas hasta ver el brillo intenso de una pantalla verde");
                                Thread.Sleep(3000);

                                // Encuentro enemigo de introducción
                                if (engraneSorpresa2 == true)
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nTe acercas a ver lo que muestra, pero en ese instánte,\nidentificas a través de las sombras una creatura con\nformato arácnido que salta justo frente a tí");
                                    Thread.Sleep(5000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nEmite una especie de gruñido digital que pone en\nalerta todos tus sistemas, lo reconoces cómo un Bug");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("\nCreaturas salvajes generadas naturalmente por fallos\ndesconocidos en la programación original");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("\nPor lo que sabes, ésto debería ser imposible");
                                    Thread.Sleep(2000);

                                    // Introducción al Combate
                                    int numeroRandom;
                                    numeroRandom = numRand.Next(1, 6);
                                    if (numeroRandom >= 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nLa creatura dispara una especie de líquido verde\nque te da en el hombro quemándote gravemente");
                                        vidas -= 1;

                                        // Chequeo de GAME OVER
                                        if (vidas == 0)
                                        {
                                            Thread.Sleep(2500);
                                            GameOver1();
                                            GameOver2();
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                            Thread.Sleep(2000);
                                            gameOver = true;
                                            break;
                                        } 
                                        // Si aún tienes vidas
                                        else
                                        {
                                            Thread.Sleep(2000);

                                            // Te muestra un mensaje dependiendo de la cantidad de vidas que tienes
                                            Console.WriteLine("\n");
                                            if (vidas >= 4)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Tienes " + vidas + " baterías");
                                            }

                                            if (vidas >=2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Aún te quedan " + vidas + " baterías");
                                            }

                                            if (vidas < 2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Te queda " + vidas + " batería");
                                            }
                                                Thread.Sleep(2000);
                                        }
                                    }
                                    else if (numeroRandom < 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nLa creatura dispara una especie de líquido\nverde que te pasa por un lado sin tocarte");
                                        Thread.Sleep(3000);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("El líquido burbujea en el lugar en donde cae,\nun tablero de circuitos que acaba derretido\nen un instante");
                                        Thread.Sleep(3000);
                                    }

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nTe han sorprendido");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nEl bug hostíl bloquea tu camino amenazadoramente\ny debes tomar una rápida decisión");
                                    Thread.Sleep(2000);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                                    Thread.Sleep(3000);
                                    Console.ReadKey();
                                    Console.Clear();

                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Bug Verde quiere pelear");
                                    Thread.Sleep(1000);

                                    // Combate

                                    while ()
                                    // Establece propiedades dependiendo del Nivel de Combate
                                    if (nivelCombate == 1)
                                    {
                                        hpEnemigo = numRand.Next(1, 3);
                                        dañoEnemigo = 1;
                                    }
                                    if (nivelCombate == 2)
                                    {
                                        hpEnemigo = 2;
                                        dañoEnemigo = numRand.Next(1, 3);
                                    }
                                    if (nivelCombate == 3)
                                    {
                                        hpEnemigo = numRand.Next(2, 4);
                                        dañoEnemigo = numRand.Next(1, 3);
                                    }
                                    if (nivelCombate == 4)
                                    {
                                        hpEnemigo = 3;
                                        dañoEnemigo = 2;
                                    }
                                    if (nivelCombate == 5)
                                    {
                                        hpEnemigo = numRand.Next(3, 5);
                                        dañoEnemigo = numRand.Next(2, 4);
                                    }

                                    Thread.Sleep(2000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    if (balas == 0)
                                    {
                                        Console.WriteLine("\n1. Disparar");
                                        Console.WriteLine("2. Intentar evadir");
                                        Thread.Sleep(3000);
                                    }
                                    else
                                    {

                                        Console.WriteLine("\n1. Disparar\n2. Tratar de huir");
                                        Thread.Sleep(3000);
                                    }
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\nDigita tu elección y presiona Enter para continuar");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    eleccion = Console.ReadLine();
                                    Console.Clear();


                                    // Desactiva el texto descriptivo introductorio
                                    engraneSorpresa = false;

                                    // Desactiva el encuentro enemigo introductorio
                                    engraneSorpresa2 = false;
                                }
                            }

                            // Desactiva la descripción de introducción
                            engraneSorpresa = false;

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nLa pantalla te muestra la siguiente advertencia:");
                            Thread.Sleep(2000);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nPELIGRO: Archivos de sistema infectados");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nVirus auto-duplicante desconocido");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nRegistro de análisis: El virus fragmenta y defragmenta\nlos registros de memoria, impidiendo el acceso correcto\na los archivos del sistema");
                            Thread.Sleep(4000);
                            Console.WriteLine("\nEl sistema ha sido puesto bajo cuarentena");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nA partír de éste punto de restauración, cualquier\nprograma ingresado podría estar en riesgo de ser\ndefragmentado permanentemente");
                            Thread.Sleep(4000);
                            Console.WriteLine("\nEl sistema ha sido puesto bajo cuarentena");
                            Thread.Sleep(1000);

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\nDigita el número de tu elección y presiona Enter");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            eleccion = Console.ReadLine();
                            Console.Clear();
                        
                            //Te regresa al menú de puertos y puedes volver a accesar
                            Disconnect();
                            switch4 = false;
                            continue;
                        }

                        // Puerto 5 - Signo de Interrogación //////////////////////////////////////////
                        /// /// /// S H O P /// /// ///
                        if (switch5 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();




                            switch5 = false;
                            continue;
                        }

                        // Puerto 6 - Gota de Agua ////////////////////////////////////////////////////
                        /// /// /// D A T A /// /// ///
                        if (switch6 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();




                            switch6 = false;
                            continue;
                        }

                        // Puerto 7 - Microchip ///////////////////////////////////////////////////////
                        /// /// /// D A T A /// /// ///
                        if (switch7 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();

                            // Inicio
                            {

                            }



                            switch7 = false;
                            continue;
                        }

                        // Puerto 8 - Pantalla con Antenas ////////////////////////////////////////////
                        /// /// /// L O R E /// /// ///
                        if (switch8 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();




                            switch8 = false;
                            continue;
                        }

                        // Puerto 9 - Prisma //////////////////////////////////////////////////////////
                        /// /// /// M I N I /// /// ///
                        if (switch9 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();

                            // Inicio
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.Cyan;

                            
                            
                            }



                            //Te regresa al menú de puertos y puedes volver a accesar
                            Disconnect();
                            switch9 = false;
                            continue;
                        }

                        // Puerto 10 - Estrella ///////////////////////////////////////////////////////
                        /// /// /// D A T A /// /// ///
                        if (switch10 == true)
                        {
                            Thread.Sleep(1000);
                            LoadingScreen();



                            //Te regresa al menú de puertos y puedes volver a accesar
                            Disconnect();
                            switch9 = false;
                            continue;
                        }

                        // Puerto 11 - Puerto Principal ///////////////////////////////////////////////////////////////////////////////////////////////////////
                        if (switch11 == true)
                        {
                            if (puerto11 == false)
                            {
                                Thread.Sleep(1000);
                                ErrorScreen();
                                Console.Clear();
                                Thread.Sleep(1000);
                                switch11 = false;
                                continue;
                            }

                            //Te regresa al menú de puertos y puedes volver a accesar
                            Disconnect();
                            switch9 = false;
                            continue;
                        }
                    }

                    // Final del Juego ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    if (dataCheck == false)
                    {
                        // Inicia el final
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.WriteLine("Has llegado al final del juego");
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú principal");
                        Console.ReadKey();
                        Thread.Sleep(1000);
                    }


                    // Game Over

                    if (gameOver == true)
                    {
                        // Muestra una pantalla y reinicia el juego
                        Console.Clear();
                        Thread.Sleep(1000);

                        GameOverScreen();

                        gameOver = false;
                        menuConv = 0;
                    }

                }

                // Menú Opción 2 - Muestra el Readme
                while (menuConv == 2)
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Cargando Readme.txt");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Acerca de");
                    Thread.Sleep(200);
                    Console.WriteLine("==================================================================");
                    Thread.Sleep(200);
                    Console.WriteLine("\nMainframe es un juego de Consola C# en el que manejas un\nprograma que busca controlar la interfaz principal y\ncambiar el curso de la historia");
                    Thread.Sleep(200);
                    Console.WriteLine("\nLa aventura se desarrolla en un ambiente noir futurista,\ncon una historia llena de acción y misterio");
                    Thread.Sleep(200);
                    Console.WriteLine("\nTomarás decisiones claves para tu supervivencia, haciendo\nuso de tu inseparable revólver digital para enfrentar\ndiversos retos y cumplir tus objetivos");
                    Thread.Sleep(200);
                    Console.WriteLine("\nExplora todos los caminos y revela los secretos que esconde\nel procesador central");
                    Thread.Sleep(200);
                    Console.WriteLine("\n\nCómo jugar");
                    Thread.Sleep(200);
                    Console.WriteLine("==================================================================");
                    Thread.Sleep(200);
                    Console.WriteLine("\nAl desplegarse opciones, podrás tomar decisiones ingresando el\nnúmero de tu elección. Confirma la decisión presionando Enter");
                    Thread.Sleep(200);
                    Console.WriteLine("\nDeberás manejar los recursos limitados de Balas y Baterías\nMientras las balas te permiten atacar o defenderte, las Baterías\nson lo que te permiten seguir en el juego");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Si tus baterías se terminan, ¡es Game Over!");
                    Thread.Sleep(200);
                    Console.WriteLine("Tu munición no tiene límite, pero el máximo número de baterías\nque puedes llevar contigo es de 5");
                    Thread.Sleep(200);
                    Console.WriteLine("\nLos resultados de combate y de otras acciones son aleatorios\n¡puedes fallar tus disparos, y los enemigos también!");
                    Thread.Sleep(200);
                    Console.WriteLine("\nLos recursos encontrados en el juego, así cómo los que recuperan\nenergía o munición, son tratados de la misma manera");
                    Thread.Sleep(200);
                    Console.WriteLine("\nLos Bits son otro recurso que se encuentran en el juego, se\nutilizan como una forma de moneda para conseguir objetos,\naccesar a mini-juegos, entre otras sorpresas");
                    Thread.Sleep(200);
                    Console.WriteLine("\nCada partida es diferente y hay 2 finales a descubrir");
                    Thread.Sleep(200);
                    Console.WriteLine("\n\nExtras");
                    Thread.Sleep(200);
                    Console.WriteLine("==================================================================");
                    Thread.Sleep(200);
                    Console.WriteLine("\nProgramado en Visual Studio Community 2022");
                    Thread.Sleep(200);
                    Console.WriteLine("text-image.com - Convertidor de imágenes a ASCII");
                    Thread.Sleep(200);
                    Console.WriteLine("patorjk.com/software/taag - Generador de Texto en ASCII Art");
                    Thread.Sleep(200);
                    Console.WriteLine("Symbl.cc - Repositorio de símbolos y caracteres unicode");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPresiona cualquier tecla para regresar al menú principal");
                    Console.ReadKey();
                    Console.Clear();
                    menuConv = 0;
                }

                // Menú Opción 3 - Muestra los Créditos
                while (menuConv == 3)
                {
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n                            :.");
                    Thread.Sleep(120);
                    Console.WriteLine("                            Y7");
                    Thread.Sleep(115);
                    Console.WriteLine("        :?GGGP:   ~GGBG7.   Y?   .YGGGBBBGP5?^");
                    Thread.Sleep(105);
                    Console.WriteLine("          7&@@5  :G@@#~     Y?    ~@@@GJJ5B@@@Y");
                    Thread.Sleep(90);
                    Console.WriteLine("           :G@@G!#@@5.      Y?    :@@@7    ?@@@^");
                    Thread.Sleep(80);
                    Console.WriteLine("             J@@@@&7        Y?    ^@@@7   :P@@#:");
                    Thread.Sleep(70);
                    Console.WriteLine("             ^&@@@G.        Y?    ^@@@7:G#@@&P^");
                    Thread.Sleep(60);
                    Console.WriteLine("            7&@&5@@#^       Y?    ^@@@7 ^?7~:");
                    Thread.Sleep(50);
                    Console.WriteLine("           Y@@B^ !&@&7      Y?    :@@@7");
                    Thread.Sleep(40);
                    Console.WriteLine("         ^B@@P.   ^B@@5.    Y?    ~@@@J");
                    Thread.Sleep(30);
                    Console.WriteLine("        !PBBG^     !BGB5~   Y?   .YBGBP^");
                    Thread.Sleep(20);
                    Console.WriteLine("                            J?");
                    Thread.Sleep(10);
                    Console.WriteLine("                            .:");
                    Thread.Sleep(1400);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nTrabajo realizado en Abril 2023 para el final del 1er Tetramestre\nde 'Lógica de la Programación'. Clase impartida por el maestro\nSalvador Pérez para la Licenciatura en Diseño y Producción de\nVideojuegos de la XP Facultad de Videojuegos y Medios Interactivos");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n                            ♥");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Hecho con amor desde Cancún, Mex. por Marco 'Mars' Argaez");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nInspirado en los cortos animados de Animatrix 'Matriculado' e\n'Historia del detective', así como de la serie ReBoot de 1994");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n\nPresiona cualquier tecla para regresar al menú principal");
                    Console.ReadKey();
                    Console.Clear();
                    menuConv = 0;
                }

                // Menú Opción 4 - Cierra el juego
                while (menuConv == 4)
                {
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }

            // Loop que reinicia el juego en su totalidad
            while (gameReset);
        }

        // Métodos estáticos //////////////////////////////////////////////////////////////
        static void GameOver1()
        {
            // Generador de números aleatorios
            Random numRand = new Random();

            // Escribe una frase aleatoria
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            int numeroRandom = numRand.Next(1, 9);

            if (numeroRandom == 1)
            {
                Console.WriteLine("Era tu última batería");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 2)
            {
                Console.WriteLine("Ya no tienes más baterías");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 3)
            {
                Console.WriteLine("No tienes más baterías");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 4)
            {
                Console.WriteLine("Error: baterías insuficientes");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 5)
            {
                Console.WriteLine("Error: energía insuficiente");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 6)
            {
                Console.WriteLine("No tenías más baterías");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 7)
            {
                Console.WriteLine("Ya no tenías baterías");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 8)
            {
                Console.WriteLine("Ya no tienes energía");
                Thread.Sleep(2000);
            }
        }
        static void GameOver2()
        {
            // Generador de números aleatorios
            Random numRand = new Random();

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            int numeroRandom = numRand.Next(1, 9);

            // Escribe otra frase aleatoria
            Console.ForegroundColor = ConsoleColor.Yellow;
            numeroRandom = numRand.Next(1, 9);
            if (numeroRandom == 1)
            {
                Console.WriteLine("El shock neuronal causa el apagado inmediato\nde todos tus sistemas");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 2)
            {
                Console.WriteLine("Se apagan secuencialmente tus sistemas\nneuronales hasta que dejas de sentir");
                Thread.Sleep(3000);
            }
            else if (numeroRandom == 3)
            {
                Console.WriteLine("Tus sistemas dejan de funcionar en un instánte");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 4)
            {
                Console.WriteLine("El shock causa una cascada de errores en tus\nsistemas internos, apagándolos secuencialmente\nhasta que dejas de sentir");
                Thread.Sleep(3500);
            }
            else if (numeroRandom == 5)
            {
                Console.WriteLine("Una serie de errores occuren en tu sistema\ny tu cuerpo se apaga por completo");
                Thread.Sleep(3000);
            }
            else if (numeroRandom == 6)
            {
                Console.WriteLine("Se apagan tus sistemas al momento, sin darte\noportunidad de más");
                Thread.Sleep(3000);
            }
            else if (numeroRandom == 7)
            {
                Console.WriteLine("Se apagan todos tus sistemas en un instánte");
                Thread.Sleep(2000);
            }
            else if (numeroRandom == 8)
            {
                Console.WriteLine("Tus sistemas quedan atrapados en un bucle sin fin");
                Thread.Sleep(2000);
            }

        }
        static void GameOverScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                    SISTEMA TERMINADO");
            Thread.Sleep(3000);
        }
        static void Disconnect()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(5);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(10);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(15);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Thread.Sleep(20);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(25);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(30);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(35);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Thread.Sleep(40);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(45);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(50);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(60);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Thread.Sleep(70);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(80);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(85);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(85);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Thread.Sleep(90);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(90);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                   CONEXIÓN FINALIZADA");
            Thread.Sleep(1000);
            Console.Clear();
        }
        static void ErrorScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                ERROR: ACCESO DENEGADO");
            Thread.Sleep(100);
            Console.Clear();
        }
        static void LoadingScreen()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ^:^~!77^^:~~~~!!!..^:::   .:!~?^  .: ^GB#P^^.:.Y&GJ!^^!!:..~?~:.:~!^:^^:.~?J5GBBJ: :77P~ . .#P ~5PB!::...^. :..^:. :! \r\n  .:::~:  :~~~^^::.^~^....!~. .JJ7.  .?PPGGGJ^..^^....:~!~^~~~:..:!7^.:!?~^!YB&B~.... .!J~ ..YY^Y#G5^::::.::   .~~^~!^ \r\n .^::.   .::::~^::::... .:.   ^?J?^.:^~~^^^.....  :.  ^^    .. . .:.::^^:....^Y~.::!75BGG^.?^ .~7:.:. .~:::::... .!JJ^ \r\n  ^~::...::::.^!^.   ~!.     .^~^^!!..:77~... .. .    ...:^~!!?7~:..  .!:  ^.. ..^75GGGGJ   ..:?^~^   :!^:^~^^~~~^^^77 \r\n .::.  ...::::..  ^!:....^~!~:...:~~^~~~.  :^.     .  .~?5BPYP5G5GPJ!...      ::  .:^^~!!. .!?J7  :!. ..:^^.:!!~~!^.:7 \r\n ..  .:^~7?5PGP7~.^:^~7?7!!7^^^~!^.  ... .:^~!!~:  ..  !?5B5~^.~!PB5?~   ...   .^: ^!?^..~^~?J7:  .^^. .^~~..^~~~~~^:: \r\n   ^YY5YJ!!?77?YJ^ ::     .^7. :?~::. .~?YGGP5PGY7~::^~!7!7Y55555J?7!. ..  .......  ^~~^:!!::~^.   ...:...::::^~^^^.   \r\n 755?!^. :?J??!~. .77^~?YP~:~!!!^:    75GG5!. ?#5?7~7JJJ?!..:^:::~7?77~:^!?5PP5J!:  .:...::::.:!~:.  .!:   :~7:.:::.   \r\n !^. .. !GP~   .^:^?JYPB#&J:^:.  ~:. .?5GGJ?7YG5?7:..!???7:    :7?JJJ7~!?YB5:!YBG5?^ ...:~!^^~:7???7!^.!~.  ..::::..:. \r\n !:  ...#Y!!.^5PG7 .  ^::!?:.. ^   .  .:~7?JJ?!^:.   .....     .^~!~...!?YGP:.~JBGY!   .^7!..!~.  .:::.:^:~75J!^:::.   \r\n JG?^.  J#?.  .^!^^^:^!!!?^...:.  ..   .  .!7??77!~~                   .^!?YP55PPY7...::.:~!!^:J?^.  !: ^5J?JGG5J?~:.  \r\n ^?5PJ!:^~!YY!:. !J5GB#&#!::.  .. .  ..:::~!7777777~   .  ...  .   :!777!77!!^^::.. ..... .:^^P&#BG5J7. .~J57^^^~?P5?~ \r\n  .:~?JYGGY7?5! .7.  ^?5~:~!!:.:^.. !J5P55PY?!^:.                  ^~77???77:  .   ..   ^...:7?!7!^~~^~::   !BP. .^?P5 \r\n    .::^!?PJ~^^:..:::  .^7..~?~.   ^JP#5!..YB5?7. .:!~^:      ....   .:^~7?J?7~:.  ..  :. ..~7:.^. . :GPG!.~~JB! .  .! \r\n ..:.::::...  ^7:^!7??77^~^:!!:... .?YPB5!:7B5?7~!?JJJ?~.   .!???7:..!?YPP??JPB5?: ..~.  :::~&#BGYJ?~:^:.  ^JBY...  .~ \r\n   .:::..7!^.  .~:   :~!~.:^::....:  :!J5PPPY7~:~7??7!^:.::..~?JJJ?~!?YBP..:Y5BP?.   .:~!!!^:P5Y7~!?^ .^!!??Y~  :~7YPJ \r\n .  ::^~^::::...^:..   .:~::^7^^~~~.  ...::.  ..  ^77JY5555Y7!!7!~^:^7JPGY5GG5J7.  ::^?~ .7~..    .^..75J7!77~?J55Y7   \r\n :.:~~~~~^..^~^: .:^.  .!?J!^!:.:77^..~.   . .   :?YGB7!.:~JGPJ7. ..  :~!7!~^.  ... .^!!^^^!!~!77!^:^:~75GGPY7!~:.   : \r\n 7^.^~~~!!^ :^:..  !^  ^JJ7: .~!~^^^:  .:  . .  ..~JPG5P55YYBPJ!.  ..    .:^  .^~~^~~^..::~!!~::...7~.  ::::::..  ..:: \r\n 77^^^~~~~^~^::~^.  ^!^?^..   ~GPGP5?~.. ..^  .~:  ..:~7?77!~^....  .   . ...^!?^..^7^^^^:      ~7.   :~~.::::...::^^. \r\n .JY?: ...:::::~^ .:..!7. .?:.5BBGJ?^:.:J^....:^^::.:. .. .    :~.  ^. .:...:^^~~~:.:7JJ~.  .:. ...::::^~:::::    ::^. \r\n :!!^^~.   .:.:::::JP#P~75^. :Y7^  ...:P&#5!^^77^::!!^. .^~~^~~~^....:^..^7PGPP5Y:  .!JJ~  ^!:...^^^:.::^~~^^  .~:::.  \r\n ~^...^. : .^...::^GGP? 7&^ . :5?~^ .!GBGPYJ!::^^::!!^::^77..:~7~^~75#B.:::^5#BG? .:  :?~!^.   .::^: ~!!~~~~^::!7!~~:^ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ~~...   :7YJ:::^~~~!~:^^::!~   ^::!  .?^ YGP~^GBBP7~:  .!77!~:...^!7??7~^.  ^7^..:..    PB:.J7GY::.  ::.^:.^.. .~~^.. \r\n .:^~:^~!?!::^~~~~!!^. ^^::.  ..^:7?:  . .PG##PB&#PJ!~~~:..~!^:..:^~~~!:  :^^~?YP5~.^^...5G:!B#B!::::.::    ^~::~!:... \r\n   . .:::~.  ^^~~^::.:^^^: ..~~.  7JJ~  .!J???J?!::::^!7~^^!!:. .^!7..:!7^~?P#&#Y!YGGJ ~~.^!J?~~^..^:::.:. ...~?J~  .. \r\n   .:^::    :::::~^::.......:.   ^7?7~:^:^~!^^.  ..  :^....:. .. .^:^~~~~^:::7GBB##BP. :.  ^!^^.  :?~::^~^~~::^7JJ:    \r\n :. .^~::...::::.~~:   .!~      .::::~?:.:!7^..~.   .:: ..::^~!~:..   .~.  :  :^^~!??.  :!?J:.:^   ::::::~~~~!^.^!J~   \r\n  ..:..   ..::::::  .~7:::::~!7~::...:::^^^.  .:...   :!YPP5GGGGP5J7^....  ... ^~7~::^::?J?~  .~~...^~~. ^!!~~~~:~JY7. \r\n .. :   :^~77YPGGP7!:^::~77!~!!^^^!!^.  :...:~?JYY?7^.7JPBY^^..!~GB5?~   ...:^ .^7!:.~7^^!~:   .:. ..:^^:.:^~~~~. .77~ \r\n      7555J7^!7!7J57..^.    ..~7..~?^::. :7YPBGY77BPJ7777J5555YY55Y?7^^7JJ?!^.  .:::^^:....:.    .~!. ..:^^^^:::  .::: \r\n   ~5PJ!^: .~YJ?!~^. ^?!!7YPP^:!!!~:.   .?5B5Y: .7BPJ7^~~::~~!~~~!!!7JPGJJPBPY7: :.  .:~~^:~??~:...::.  :^~.::::.  ..: \r\n   ?GG!.   ~&5    ...!JJYGB&&!:::  .~:. :?5GPJ?JPPY?!:  ::  .  .::.~7YGG. .5BG5J. .::~?^.:!^^^!??7~^7^  .:.::::...::^: \r\n    :5PP7^..7YY!:.. ^J55PGB&#~:.  .  ..  .:~7???7~^:. ..    .  .   :!?YGP!~?PB5?:   .^7~^^!^:    .. .~7?PBPJ!^:.   .:: \r\n .:  .^7YY?JJ!~JP?..!!.:75BP:^~^. .!:. .~7?JYY?7!^:....    ..   ....:^!7?YYYJ?!: ..~: .^~^:?BP?^.^7..~PJ~~JY?YY7^:  .: \r\n ::.   .:^!JPBGJ?!: ..    :^~~^~7~.  ..75BGJ7!5GY?!:   ..       . ..:~!7??7~^.   .  .. .:^5&#BPP5Y! ..:!YJ7:.^!PP5~    \r\n .~::...::::::^  :7~^!??!^^^~^ .?!::.  ?5GGP:  YB5?!..::  .  .:  .~7?5PYJJ5G5J^ ..^:  .::^#&BGYJJ?:..    7&Y   .^5GY.  \r\n ::.  .::::.^~:.  ::...:~7?!:^~~^.  .:..!JPBPJ7PGY7!!!~^^!^~:.^~:!?YBY:  JYBPJ^   .:^!!!^:5G5J77?~. :~~7?5?. .:~7PP?   \r\n .::.  .:::^^~^:.  ^!.    .::...:^^::::  .^!?YY?!^!7JY55Y5555J7777?5BJ~JPBG5J^  ..:!7..~!:..   .~:.~YJ7!!7^!JY55Y:     \r\n ^77: .^~~~~:::^^^:. ...   .~!^:!7.:~7~. .^. ..  :?YGB!!:.:^7BPY7::!?Y5YJ7^...:. .:!!^^^~!^~!7~^.::~?YGGG5?7!^^.  .. . \r\n  ~YJ!:^~~~!!~  ~~^...^!.  :?JJ^.^^:^7!^..:.   ...:!JPPGGPGP5G5?~.  .....   ^^^:::...::^77!^:::.7!.  :^^:::..   ..::.. \r\n   :J7^.:!!~~~::::::.  ^:..?J7^  .!?!~^^:. .  .~^   ...~!!^^^:. .:.   .^: :!7^..7!::::..     :7:   .^~:.:::...::^^. .: \r\n    .?J7~::^~^^~^:^?^   ^^~!  .:  JG##BGG?^:::^~~^^:^: .. .:....:^.  :  .:^!!^:^^^!??~.  .....:....:^!^.:.:.   ::^:..  \r\n  :  :??7:.. .:::::^..:~^!J7:.^7.~GGP7?B&&GJ~^!7:..!7^. ..~!^^~!7^::::~7???7??:  :JJ?.  ^!:. .^^~:.::^~~^^  .^:::. ..  \r\n  . .~~^:^~.   .^.::::^P##J:YG:..:!:^JP5J7~^^. :~~^~^:...^!!:.:~!~~7YG&#5#&BG~    .7J::.:. .::^~..:~!~~~~^::~?7~~:^~^. \r\n :.:~!: ..^..^..^...::7GJ?^ P#.   ..:..:7~   :~!??7!^:..:^!!77:  .~75BBB!:PGP:.J^  ^^:^.  :~^::^:^!~~~~::.7YJ^......^~");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 7G##5:   :.  :7??:.~~~~~~~^::~7. .:.~5?!!^. .~..!!  .!JJ~..    .    ...^?7^.:!J!?JJJGG! ?:5P^:.  :^.~~^^..  .:^^.:Y#B \r\n ^~~!^:.....^?Y?:^:^~~~!~.:^::^:.  ^^:7.  !! 7BG57^..  :7J?7~:.  .:^^~7??!.  ^~^..^: J&:.5BBY::::..^  . :^..:!!:..7PGP \r\n ....:^~:^~!?~.:^~~~~!~:. :~^.. .^^..~Y7:   .YGB#B5?!:^::^~~^:...:^~!77:  ...^77JJ..:^?!?G5J!:.::::::   :^~!7~.     ~7 \r\n      . .:::^.  ^^~~^::.:~^^:. .:^.  ~JJ?. .~7!~~~^:^77^..~7^...:^7!..:!^:!YGB#BB! ~!  .7:... .7!:::^:::..^?Y?. ..  :^ \r\n      .:~::   .:::.:!~:....:.....   :!7!~~^:.^7!^. .:^::::^:.... :~~~^~!!^:^!JY55:   :~?!:~:  .^^::^^^~~~~~.~JJ^       \r\n   ::. .^^::...::::.^^.   .!^     ......^7~:^~!:. !^^^    ...^^: ..  .:^.  :^~~~~^. ~JJ?. .!! ..:^^. ^!!~~~::^?Y~  ..  \r\n .. ..:^..   .::::^^^  .!?:::^^!77~:::......::.  ..:.:^7J55PGPP5Y?~:. .^^! .~7!. :7^!?7~   .:...:^~^. ^~~~~~^:~?J!:... \r\n ::..  .  .:~!7?5GGG5?!::.:~!!^^~~^^:!7^. .::.:~?YPPPPYP#5^7^!~J7BGY7~^:..  .^~~~~!:..::   .......:::::^~~^^.  ^7~^^:^ \r\n        .J55Y?!^!~~7JY!..~.   ..:~7..~7^..  ^J5GBB?~:PBY5PY??7!?YPPPPPPGY7^. :.  ......:~:.   :7:   :~7^::::.   .::. . \r\n       :YGPJ:. :JGP!^^. ^???JPGG^:~!~^:.   :JPB5J: :JGPJ7~7??J???JPB:.~PBP5J^.....^!~~~:7J?7~^:.~^.  .:::::.:. .::~^.. \r\n :.. .  :!JPY7~~^^?Y?:..!7?5G##5:^^:  ~?:. ^?YGPYJYP5J7~. .. . :!J5B5. ~YBGY7   .^77  !~: .^~~^:^~.:^?!^:::....::^. .: \r\n  .::^.  ..:!?YGBPJJ5~ .~.  .~?^^!!!^......7YPPY5PPY?!^  .. ..  :~7JPPYY5G5?^ ....^!!!~:7!.   ^: :YJJPBB5?!^..  .^::.  \r\n :. .:::....:::^!J!::^~::~~^. .^7. ^?~.   ^YPB57  JBPJ7^ .. . .:!?YP5YYPG5?~ ..77  .^^:?##B5?!7: .7YJ~^!~!YPJ!^  .  .: \r\n  .:~:^...:.:::::..  ^!.:^!7?J?^^~^!~:....:?YPBB~. PGY?????77^!?5G5! .?JBGY~ . .::~!~^:5BG5J?J!  ^:^5B5^..:7PGP^       \r\n  ..::.    :.:::7!^.  .7^   .^~^..:...  .:. :7YGGPPP5P5J77J?YP5YPB::!PBGPY!  ..:!7:.~!::..   !^.~JY?!~!^~7J555^.       \r\n ^::^^!!.  ^^^~^:::::.......   .::.:~!~~~^:   .:^~7YG#J?!~^~~?#GYPPPPPJ!^.::. .:!7::~^~:^~!~:..:~JYGGGPJ?7!^.. .  ..:: \r\n ...:~??~:^~~~~~^. :~^^...::   :!?!^!~ .~?~: ^~^: .:~?Y5PPGGPP5?~::::.   :::.....:::^7?7~^^::77:  :~~^:::.   ..^:.. .: \r\n   .  :JY^::~~~!!~. ^^:.. ^7.  !JJ7. :~^~~~^. .^^.   . .^~:...   :^:!. :~!~^^7~:.....     :!:   .:^..:::...::^^. .::   \r\n       .?J!.^~~~~~^^:::^.  .^^^J!^.  .J5Y?7^:^~7~~~~~^. .. .^::::::. .^~?~:.:!~~7!^   .....:....:^!^.:::.   ::^^..     \r\n .^   .  7YJ~..:^:^^:.~?: ...:!^  ^! :GB##B57^^!:..^?~:...^!!::^!?~::^~~~7!:  !JJ7.  :^:..::^~^:::^~~^^   ::.:: ..     \r\n !7.  .  ^?7~^:.  .:::::..^JYPY!?^:. 7Y?7~...  .~7!!^:...:^~~:::^^~7YG##GP:   :!J?..:^: ..:~~. .~!~~~~~:.^77~^:^~^.... \r\n YGPJ:..~!:..^^  . ::..:::7BBG^.GB..:: .~~  .~???!~~:.. .:~!7??:  ..:75GBY :7.  !^^~.  :::::^.~!~~~~:^:!YJ~.....::!~~^ \r\n P#P~.:~:.  ..:^^~::^  .::YG~7.:PBJJJJ!?!:.:!?~...         ..~?J7.  ~!:.~^ .^~~!Y!.:. .7!::^~~~~~~~:.7??~   :   .7##BY ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  .   .^^^~J     ..:7?77^:.^::::::::.:^?G#P^7GY!7~^::~7^ .^!:. .^...^:  ... ::YGBGP!^7:JG~::  .^.:^^^ .    .~: ^5#?..  \r\n .?JYGB#?.   :   ~JJJ~.^~~~~^~~^:^?~  :..!7^:^~:!~  .7J!:..   ..... :^. :7!:.^Y5?77: ?YPG^::...^..:.:^. .^!^..!G##~    \r\n ^P7^^~~::....:~JY7:^^~~~~!~..^:::.   :!^7^  .~ .:   .^?J?!^.     ...:~7J7^  :^~:7G7~G#GJ:::::.^.   .!^^!!:. ...~?^ .^ \r\n .:.....:^^:^~77:..~~~~~~~. .:~^....!~. .JJ7.  .?5?~..:^~~~^:....:^!7??^..   ^:~?. .7!:.:. ^~:::::... :?J?. .:  ^?~7!^ \r\n : .     . ::..:   ^^~~^:::^~^:::..:.   ^?J?^.:^~~~~77^..~?~:...:^!~.:^^.:!JY^  . .^?^~^  .~!^:^~^~!~^^^!J?.      :J7^ \r\n ~ :    ..^~::   .:.:.:7~:....:.....   .^~^^!!..:77~^^^^^~^. .. .^!!::^77~~!7^  .7JJ~ .^^  ..:^:.^!~~~~.:?JY!   . .7^^ \r\n ::.  ::. .^^::...::::.::.   .!:    .......:~~^~~~.      ...:~:. ....:::~77:.:~:!J?!.  :~:..:~~^  ^!!~~~^:^YY~  .   :J \r\n  ..:. ..:^..   .:::^~!^  :!7:^^~!7?7^:::.... .... .:^!7JJY5YYY?7^:.    .~!~:^7~::~^.  .::...:^~^..:~~~~~:.:7?!~^::::~ \r\n ::::...  . ..~!???PBGGYJ!:..:^~~::~^~::7!^. .:^^~?YPGP5J!Y7PYYPYBP5?~.  :...::.. ..:    ..^^...:::^^^^::  .~^::..^:.. \r\n :.^:. .   .7YGG7~!^::75J~.^7.  .:::!~.:7!:..  !YPGGB7:.!J~~Y^:!.:?PBPY7::^.  .::^:.~7!^.  :^.  .:!!.::::.   .:^..     \r\n ..:..:.::  .:~?Y?5P?!?5?..?7  :?PJ:~77!^.  . ~YGB?7..?PGPYY55PBY. 7GGP5J: .::^7~.^!^!!???!^^?^  ...::::.::.:^^^.:.    \r\n   .:. .:::.  .::~7YGP?!^:.....  .^!~:^7~:   .?5BG!..J#PY7~.:7J5#P..~5BPJ:   .^7^.:!^.  .....:^~7YGY7~::.   :::. .::   \r\n    ...::^::.:.::::...  :7~^!???!!^~~.:7~::. .?5PGGJ..?BG5YYY5GG5:.~7GB57..  .:~77!:!PJ^  ^J:.!P?!?PPJJ?~:.  .^.:. ... \r\n     ..:^..   ::::.~!^.  .^:. .^!7!::^^:.  .:^:7Y5BB?^.!^^Y7~?J..^GGGP5?. ...~7^:^7^:^..  !!.^7PJ:.:!!!PG5?:   . .:^:: \r\n ...^:.::^^:  .::^^^^::.. ^~..    .. ....:...:. .~?YPB5YY?P7?7755GG5J7^^:...:~?:.^^~:.^~^:...^JJPGBGJ??7!::    ...:^:: \r\n ^::^^^~~7?^..~~~~~^:.^~^:...::.   :^^.^7~:~!~:    .:^7JY5555YY?7~^.  ... . ..:^:^!??7~~^:!7~  :!!~^:::.   .:^....^..  \r\n Y~.  .  ^JY!:^~~~!!~  :~~^...^:   ~?J7^~^..!?~::..... .:~^...      .^~~^~~:... ....   .~^.  ..:..:::....::^.  .:.  :. \r\n ^^~: ..  ^YJ7~.~!~~!~..^::.. ^~. .JJ?^  :7!~^!?~^:~!^. .. .:~^^^^:^!?^..^7^^~~:   .....^:...:^!~.::::   ::^~:.    ..^ \r\n :!J~      .7J!^^~~~~^~~::~!.  :~^7~...  .YY7^.^^:.^7~:....^7!..:!?~^~~~:..7JJ~.  .::.::::^^::::~~^^.  .:.::...  . . : \r\n .~7!!~  ..  7YJ^....:::::^~. :..^?:  !!.^.   .:!?7!~:....:^~~~^::.~?5Y:  .!JJ~  ^!:...^~^.  ^~~~~~~:..!?~^::^^....... \r\n ^: .?!..   .~!~^~^   .::.::::!PBB7!P?:^~^  .!J?!^::.     .^~7JJ~.   .: ::  :?~~^.   :::^:.~!~~~~^^:^YY7:....::^^^^^P~ \r\n    .B#BJ:.:!~. .::... ^. ..::5G5Y..777YY!.:~?~ .::  ..:..  ..:!J?:  ^!^~~::~?..:  :?~:^^~^~~~~~.:?JJ7.  .   .~B#G5YJ^ \r\n   :^#G! .!:    ..:~^^.^:  .::PP:7^^YGBBP~:  ..  :^:..:: ..~!. .7!^:^^7!?PY^J#GJ^:.::::.:::^::^!77?~..     7!^^~:.  .  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" !??7~~^^^^~~!7~.       :JJ7^..   .:^.::::~B#BPBBG:^  .:. .::^~~~^^^^:::!7^.:::::::^!^..  .^:..:^       :!::J5P.. ^??! \r\n !7:..   :~^^~7     :~~??~!~^:^^:^:::^^..:~?GG??YJ:.:~:  .^:. .~^...:.  ..  ::7J5PPPG7::  .^.:~:^:.. .^^^.:YB&J.. .777 \r\n ...^JY5G##7.   :  .7J?J7.:~~~!~^~^::!!   :.:7. .  .7J!. .: ...::...~~. :!^..!GGYP##P^::::.^.   .!^.:~!:..:7JP!  .~??~ \r\n ..:~5~::^^:::::.:7JY!:^^~!!~~^. ^^::.  ..^^7?:     :!JJ!^:.  ..     .:~??~...:^7Y?~!:.::::::.  ..:7??.  .  :?!:~!^.^. \r\n .:^:.... .:^::^~77: .~~~~~~^. :^~~:...~~.  7JJ~  .. .^7!!~^.....:^!7??!^.      !^::   ~?^.^^^^~^::!?J!  .   .:?~::^:. \r\n ..~~ . .  .. ::...  .::~~::::^^:::^:.:.   :7J?~:^^^~^..^7~:....:^~~^~~: .   ^!J?.:^.  .:::::^~~~!~.:?5Y!:     ??!:::: \r\n 7..!.:  . ..~~::   .:::.^7~:. ..^.....   .:^::~?:.:~!^^~~:.... :~?~..:~^^^.^JJ?:  :7:...^~^ .~~~~~^:~~?Y:  .. ..^Y?:  \r\n ! ^^..  :.  .^^.....::::.:..  ..^.   ..::  ...:^^^^~.  .. .:::. :::^~7^..7~^~7~.  ..:..^~~~^  ~!~~~~^:!JJ~.... .7GBBY \r\n Y?^.:.:....:^.   ..::^~!7^. ^77^~~!7??7^:^::.  ..:....^~!7???7~:.   ::^^^~:.....  ..::....:^:::^~~^~:  ^7!~~:~~:::::^ \r\n ~?. ^:::^. :.   ^~J5PBBBGYY!....:^^:.~^~..7!^....^!7J5GBP5GGPPGG5?^..:.  ......:^.    :?:   :^!^::::.  ..::. ..   ... \r\n  !:. ..  .:^.  ..:^7JPBBPJJ~        .^7^.:7~:.. .7YPGPPY:.JP.:Y#GP5?~::. .:~~~^:7J?!:...^:. ..^:.::::.  ::~^..  . . . \r\n :^.:  ::. .^^::...::::^!:..~!^~!7!:.:^7. ~?^:.  ^YPBB?::5BBBG^.!GBPY!  .:^77. ~~^::!77!^!!...~^::::....::^. .::  .::~ \r\n : . .   .:~::. .::::::^..  :~..:^~?J?^^~~!^. .:.^?Y5GBP^.?G::?55GG5J: ...^7~..7~.        :?JYBBPY7~:..  .::.  .. .:!. \r\n ...   ....::..   :.:::!~:.  .7^    .:^......  .::.^7YGGGPGGY5GBPY?!~....:~?:.^~~:.:^:....^JYPBBBP5Y!^.   : .^:::^. 7! \r\n ~:::::^~^^^~7!. .~^~~^:::^^:....:..  .....:^^^^::   .:~7????7!~:...:... .::^^^!??77!~^~7~ .:77!^^::.    :^....^::.:75 \r\n JGGGJ......^JJ7:^~~~~!~. :~^^^:.::.   ^!!^^?:.:!!^:::. .:^:  .   ^^^^::.... .:...  .^:... ....:::.....:^.  .:.  .:! ^ \r\n  .75!..  :  .JJ~~^^~~~~~. :~^:...!^  .7JJ!.:~^~^:.^?~:. .. .^~~^~!^..7!::::..  .....^:.  .^7~.::::.  ::^~....  ..^^ ~ \r\n ::::~7Y.    .!J5J^.~!~~~^:::::.  .^:.!J7~.  ...^^^^~^:....:^7~..:~^^^:^7??~.  .:::::.:^^::::~~^:.  ...::...  . . :!.: \r\n .:~::~?~.   .  ~J?7:::~^^~^::77.  .:^7.     .:~7J?7~:.....:^~!!~....  :JJ?.  ^!.. :~~^^. :~~~~~~: .~7~^:.^:. ....:~:. \r\n .^.:!!^~?~  ..  7?7^..  .::::::..~~!Y?~:...:7?!^..     .  .:^!?J!:     .!J^^.:  .::^^..^~~!!~^^:^JJ?~::::^:^^::^5!^.. \r\n ~??!:  :5J!^...~!^.:!:   .^..::::YB&GYPGJ..:!^  :!....::.. .. .~??:  .  ~^.:.  ^!^:^^^^!!~~~.~????:  ..  .^G#BPY5!:.. \r\n !?7:  .^&#P~.:^^:  ..^:^:.^.  ::^GPGPP5J^:  ..  .::..:~: .:^:. .!::.7J?75G?~^..^^:.:^^^~:^^!^7J!~^     ~!:^!^.  . .~! \r\n !??! ..?GY~.~^     . :^...^.  ..:!~^::::::.:!?::::^^~~~~^::. .:.  ^.5BBPG#B?::::.::..  . :!JY~        ^77!~^^:^^~!??7");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" !?:!J7?JJ!!.:!~~^~?^7.  :  .77!^~:    :...:::^::::::^^^~^::.^.^~:^~:^^!^.::::..:.. .  :^  .~   .    :~^?!Y:..~??7!~.^ \r\n :~!7?7!^^:::^^~?7.:       ^?Y7^... .:.::::::^PGJ:^  :!^..:^^^::^::::::^~~::::..:...   ^::^^~...  ..~^.^5#G.:  !7?7!~? \r\n ~??7~. .  .~7^:~~     !YJYY^:~~~~~~~^::^7: .^:!P:..^.   ::..:~~^::::.  ^:. ::~7?~:::..:: .. ^:..:7~..:YGBY   .7J7JY?~ \r\n :....:!5YPGBB^.   .  ^????!^^~~~!~.:^::^^.  ^^:!:.7?~  :^....^^:...!^. .^...!G5Y^:::::::.  .^^~!7^  .  .!7.:!!^~^:.:. \r\n .~^:.^~Y^:::^:^::::~?J?^:^^~!!~~~. :~^.. .^^..~Y7:^?J7^..   .^.    ...:!?~.^!:... .7^.::^:::..~JY!  .   ~~7!~^^!~.  : \r\n ~~^.:~:.... .:^.:^~7~. :~~~~~~: :~^^~~. .:^.  ~JJ?..~?77~^...^...^~!7??7~:~?^^~.  .^:::~^~~~~~^:!Y?:^.   .^~7~~~:~7?7 \r\n ??::.~: . .  ...::...  .::~~::::^^:.:^^:::   :!7!~~^..^!^:......:^~!!~..7JJ!  .7: ..:^^ .!!~~~^:?Y55?.    .J~~:. ..^~ \r\n P#G! :~..  ....~^::  .::::.~7^.   :~....  .:....:^7~:^~!^......:~?^..~~^7?7:   ::..:~~^::.^!!~~~::^YJ^  .   .J#P!...  \r\n 5BB7 !..  .:.  .^:.....:::.... ...::.  ..::.. .......::. ..... .^^~~^!~:.:::  .::::^^:^~^..^~~~~~::^??!^:...:7?JYPP7. \r\n 5BY::~. ..  .^^..   .:::~!??^. ~7~^~!77??!^^~^:. ...:^.:^!77!~: .:. ...... .^.  ....:..:::::^~^^^  .~~^:::~^..::.!~^: \r\n 5G: ~:^. .^:  .::.  .:::~7YY~^:!^^~!7~.:^~^..?!:....~7J5PGPPP5Y7^~^.. ..:::.^~^.   ^!.  .^!7.::.:.   .::...     .:~:. \r\n .::^: .    ..^^^:..:.:::::..  :7^:~!7??7^^~:~7^.....7Y5PGBBBGG5Y?: ...:!!^~~^7??7!~::7^  ...::::.:...^:~:.    ...^::. \r\n ..~^.      . :^.    ::::.~7^.   ^~.  .^~~..::..  .:^~!Y5PPPGP5Y?!:...:~?^ :!^:.^!!~^:!^:^7Y7~:::.  .:::  .^:  ^.!. 55 \r\n .^^7:::..:~:.::~!.  ::^~~::::...::...   ::  ..... .:. .^!77!~^.:^... .:^~^^~???77!~^7!..:?J7!^::.   ..:^:  .. .:~.?GG \r\n .~YGJ?77^.:::^~??~::~~~~~^:.:~^::^::^:.  .::.:^!~~~^^. .:::. .::........ .:::.   ::.:.  ...::::.....^:. ...  ..~.:GBP \r\n   ..!5#P:   .. :?Y!::^~~!!~.::^^~^..::.  .!?7^~!. :?!^. ....:~!^:^7~:....::  ....^~.  .^!!.::::.  .:^~:....  ::! :P#G \r\n ^^.  .:^~?^     ~55Y?^:~~~!!: ^^:....7^  ^JJ?: :!~~~^:.....:^!~..:~~~7!^   .::^^:.::^^:::^~^::   ..::...  .  ..!.:^7J \r\n !J7!:^~^7!^.    ^^7Y?::~~~~~^^^::^:   ^~:J!^^!7??7!~:..::..:~!77!. !JJ7   :^:..^!^^~^ .~~~~~~^  ^7~^:.::.  . ..~^.:^! \r\n ^. .^!~^~~?~~.  .  ^JJ7...:::^:.:7^  ...~!.^??^...    .:.   ..^7J?~.!J7..:^. ..:^^..^^~!!~~^^:7JJ!^:::^::::::?!^.:^~: \r\n .:.::~:~7^.~7:  .  :77!^^.  .::::::.:?YPJ...^:  :7:...^^:.. ::. ^??:.!^^~.  :::::^.~!!~~^:!777J~. ..   :5BGP55?^..... \r\n ^7YY7J?:   !BG5~..^7^..:~. . .^..:::^??!^:. :^. ..:.:^~!:..::.  .^...Y7::. .!!::^~~~~~~~::J5YY?.    .!::7!:. .. ^!7?! \r\n 7!!!?77. ..J&G!.:~:.. ...^^~:.^.  ......::::^!^::::::^::^^^:...!:  ^:?GG~::::.:::. ...:!JJ!.      ..~J!^^::::^~7??7~^ \r\n ~.:7!??!...Y7?^~~.   .   ::  :^.    .:..::::.:7^^:~^.^~.:::^:~^^^::::::~::::..^.   .~^~77^  ..  !^!7:!~~^.!7JJJ7??:!7 ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("555PJ~:^~~!!.  !?7::!?:!7:    .:!~.:^^ .:..^. .:..:....:7~~~!!~~~~~~~~^^.  ..  ::^~.    ~^   ..   .^^!:^: .!??~^^:.~PBG\r\n!!!77:7J7JJJ7!::!!77:7~::  ..  ~?7~:^.   .^..::::::::::~~^::~^^~~^~!^^^!^.......::.:^..:^^ ..    ^~..JGG.: .7??7~.?5PY^\r\n  .^~7??7~^:..::^~7?...  ....^7??!:..:..::::::.:^^. ^7~.::^::.:!^..::::~^::::::.:. .^..^.::.. :!~:.^P#&Y    !???JJ?: :G\r\n.:~777!^. ...:!J~:^^     ~PGP5J.:~~~~~^~^::~?:  :: ...  .:..^~^^~^:::...!~: :::::::.^.   .!^:~!^. ..:~?7  :!!!~!7~^.  :\r\n!!~:....^7PY5GBG~.   .  ^??!7!~^~~~!!~.:^:::.   ^~~7^ .^!....^^~:..:~:  ..  :^. ^^:::::... :7JJ:  :  .?~~!!^^!~:  .:.. \r\n7~::~^:.:^J::::::^::^^~?J?~:^^~!!!~^~..^~^....!^  ^J?~..    .::...  :...~7~~:  .!!::^~^~~^^^~!??: .    ^!:7!77~:::~J7~!\r\nJ777^:.^!:.     ::..:^!!. .~~~~~^^..^~^:!~:..:.   ~?JJ?7~:. .^^  .::^~!?J^ .~:  .::^:.^!~~~~.:J5P5Y^    .?7~:^:^!????7J\r\nP5Y5?^^.~: . .  ...::. .  .::^~^:::^^:..::^^::.  :~!~^~!^:.......:~!7?J?!   :~...:^~^ :~~~~~~^~77Y?   .  ^:~7^    .~7??\r\nG###BG~ ^^..  ....~~::. ..^::.:7~:.  .!^...   ^::....:~!~:......:~7!^:~~^   .::.^!~:^~^ :!!~~~^:^JY?. .   .?##GJ!~  ^!7\r\nB###B5  ~:^  :~.  .^^:....::::... ..:.:.  .::::........ ....... ..::.....::..::^...::^^..:^~~~~. .!7!~^^^^:^^^^7G?~.. .\r\nJYY?!! ^:..  ..:.:^^::...::::..^  :?!:~77??J?^^~~^:. ...^~~~~~~:. ...... ::.    .~~  ..:^^^^:::  .::::..::. ...:^:::^~:\r\n?7^: ^7:   .   ..~::.  .::::.~~:.  ::....~7?7::~~^:. .:^!7JYJ7!~:.  :^~~^:!?7~...:::  .:~~.::::.   .:~...  .   :!~..^!?\r\n.!^:::::...  .....:::.  :::^^^~^:.  ^!.    .::.........:~~~!!!^:.. .:^~~^^7JJ??7!:~J^  :..::::...::^^:.:..  ...~ ^!!JJJ\r\n. ..^7PJ^^:^:^~^^~!77. .~~~~~:::^^::...::...::. ....:.. ....... ........:^::.  .:.::.  ..::::.....^^.  .^^  ^:~. JB###B\r\n7!^. ~!JG##Y:   . .7YJ~:^~~~!!^ :~~:~!^:::.   :~~::!7!^.......^!~:.....:^.   ..:!:   :~7^.::::. .::^~....  .::~ :PBB##B\r\n??7~.    ^7!:^  .   !Y7!~^~~~~~~^.:^~:...~^   ~?J?!!~^:......:^~!^^~~:   ::^^::...^^:::^~^::.    .::...  . . .~ ^~?555P\r\nJ7????!~:^:~7J.    :J5PPY~.~~~~!^.:^::.  :~. .?J7~^^:.  :^. .:~7??JJ!.  .::.:~!^:~~..^^^^~~~. .~7^::.::     ..!^.:^777J\r\n!!7J!:::^77!?^~~    . .??!~^^^!~^~^::~!.  .~~7!...:  ...:^.    ..~?J~  ^!:...^~^..~^^~!!~~^:^7??!^^^:^::::::?~:.:^~::^7\r\n ....  :~7^^!!!~?:  :  .?J?: ....::::^^..::. :.  .~:...^^^....~^. :?~~~.  ..::^^ ^~~~~~^~~!~7J~. .   .:PGP5YP?^.. ..^!!\r\n:   :~!~~!~!^. !?~... .^!~^^!:   .^:.:::::: .~!...:::^^^^~^..:.  ... ::  .?!::^~^~~~~~:.?5PGP!     :^:^J?~.... ^!!77!^:\r\nB~ .7?Y???7.   7&#G~..^!^  .::.:. ^. .:.::::::^~:::::.:!^.::^::.^7^. ^^:.:::::::.::.:~???~..:.  ...7?~^:...::~7??7~^.  \r\n:J55Y:^7??7: ..PB5:.^^.    . :^::.^:..:.......:7^^^!~^~!~:~::^^!::::::::::..^.   .^:~7?!  ..  .:^?:77!!:.!7JJJ???:!7!~!\r\nPBG7.:^~~??7:..~:!~~.    .   :~    .~^.^   .  .^^~~~~~~~~!!~~^!:..:.:..:. .^. :. :~:.^!:.    .77:7!::7J7. .!7!~~:~JP5Y5");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(":^:7BPY5PY.  ....  .:^:?!  ~Y?7^:..7~. ..:^^~^^.^   ^:..^!!!.~J555J~~JJJ777~:.: .:.  .   ..  ::.:^^.. .~??^.:...?GBY77!\r\n7PPPP55J~:~~!!~. .75J!^^7!^J^  .  .~7^:~~. ...:........~^^~~~^~^~~^:^~^^. .^:  ^:^~::^       .^^.?JP^..:7??7!.~5GB77#?.\r\nJ!^~~~7!:???JJJ7!::~~7J!:?.    .  ~J?!:..  ..::.:^:::.~~^^^!~~~~~~!!~~^!^...   .:.:~:^:.. .^^^..7G&G..  ~7??7?J!::JB#BG\r\n...  .~!???!^:....:^!?7...  ^^~^!J7~!^::^^:^:.:^^..~7~:::^::.:?!^.:::^:!:.::::..^.    ~^.:~!^...7J5Y   :7?77J7~:  7GG##\r\n :^:^!77!~: .:.:~JY^.:.     7PYGPY^.~~~!~^^^^:^7~   .. .:::^~^:^^^::::..7!:.::::::.  ..:!??:  .  .77:^!~:^^.. ..    !##\r\n!~!!~^.....^?PY5PG5:.   . .~J7~!~^^~~~~~^..^^::.  .. .:!:...^^:~:..::.  .   ~?^:^^^^~:::~?J7. .   .^7~7!7JP7:  ^^.. :55\r\n7JJ7^:^~^:.:~7::::::~:^^^!??7^^^~~!!~^^~7^:~~: ..!~.  .   ..:^^:.. .~^. ..  .:::::^~~~!!:.7YY!!~.  :^:77~~~:^!7?Y7?7^7J\r\n:J5J777^:.~!.      :..::^7~  .~~~~^^:..~!^.~~^:.:.   ^!~:  .^^^   ...   ^7....^~^ .~!~~~^:?5PYY7.    ~J!^:..:^!77?77:~7\r\nJ!!PP55J~^ ~... .  ...::.    .::^~^:::^:...::^^^::...:^::........^!7~.  ..:.:~~.:?~^^~!~~~^^^7Y!  ..  .:YP7.    ^7??!^.\r\n5!?5PGGPP^ !.:    .::~~::...::::.^7~:   :7: .   .^^: ................:..::^^:^~::~~. ^~~~~~~:~7J7:.....^YPPPPY~..:^!?7^\r\n5YJ??!^..^~: . .  ..^^^:. ::.:::::..   ....  .^^^:.................  :^:  .:.....::::::~~^^:  :7~^^:^!^:::::J7~:....:~!\r\n?7^:!~^..^^..     . .::.   .:::.:7~:   .7^   .:^^..........:..........^^:.   :7:   :~7^::::.   .::. ..    ..:^..^~!::!7\r\n!~:....:~~J:.::.^~^:^^~7^  .^^^~^:::::.......  .^:  ..................^^^:   ...   ..:::::::: .:^^~..  . . .~^:.:~7??Y5\r\n^7?!^:..^YPPP5Y~....::7J7~:^~~~~~^..^~^:^^:^^:::.:................ ::^.     :7^   .^7~.::::...::~~::.    :.! .55GGP5J!5\r\n.^!?J?^. . :7P5^.  ..  ~Y?^^:~!~!~^^~?^.~~:.:..   ~!!^:.......::::...:::^^::...:::::^~^::..    :::..  .  ..! :!JPPPP!~Y\r\n7~:!7?77~^...::~?7     ~YYP5?^^~~~!~: :~^:...!~   ...   :^^.  :~!^.  .::.^^~::!~:.:^^^~~~:  ^7^::..:.     .!!..:!77J5Y^\r\nY?^7?7YJ7!~:^~^7?:::  .~7!Y5?:.~!~~~^:::::.  .: .:~. ..::^:..   .   ^!:. .^~:^7~^^~!!~~~^^!7?7~^^:~^::::.!~:::^~^:^7JY7\r\n55^ .:^^  .!5Y7!7^7^.   .  7J?!:::~^^^^::7!.  .  .::..:~:^~. ..!^. .:   ::^^. :~~!~~^^~~~!J7: ..  .:JP55JPY~:....:~!!~7\r\n##J     . ..^^.~!~:!?.  .  .??7:..  .::::::.:!7:..:::^^^::~^:.:.  .   ^7^:^^^^~!~~~.:JPG55J     .:.^YY7^::. :~~!7!~:^: \r\n##GP7. .~7J77?7^.  ?5?!:..:!~:.^!.   .^..::::.:!^^:::.:!?^..:^:::^7~..:^:.:^^^^:^^!~!J7^~~~   . !J!^:.....^!7??!~.  .. \r\nB###Y^:~J??7?7!  ..5&BJ..^^^. ..:^:^:.:.   ...:!^~~!!~~~~~~!^:^~!::::^:.:^..  ...~?Y!. .     7^~J7~~^.!7JJJ??J:~!~^^:^7\r\n.!#Y~GGP!.~7??7:...PYJ::~.       ^^:~~:^  .^.  ^^~~^^~~^~^~~~~^~........:. .  ^~:^7!:  .  :J~~?^^!JP?: .~7!~~^^?5P5PPP?\r\n~!?JBGY...::^??!. ..:~:::.. ..   .  .:: :::^7!!JJJ~^?Y5YJ!.~!~^. .^   :::^^^^:.. .^7..::!7J!. ~?::^..   ..   ?P5J5BJ:^^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("..  : .J#&&#&J     .:^!!7?J.   7##B! .!:.  ....:..:.^77~:.....777?:   ..  .^:!~.   ......~7..:^:.. ^??^     :5GY~~^?!. \r\n~!!^~:7B5YYPJ. ...  ..:^^.^?:.^?!^:...^7:..::.:^. .~^::~???^!YPY?GY~~!!~~!7~::. ..   ..   .~^7!!^ .^??7~!.:!PBP7P?. :  \r\n~ ~?PGPP5PJ^^!!77!. .?GJ~7!^J^7~  ..  ^77^^!.         :^^~~^:~~~!!^:^!!~.:^~:..:::...   .^~..JB#::  ~7??~~7YJ7~Y&G?7!:.\r\n~J5?^:^^^!~:???JJJ77:^~^!??:7:      .~JJ!:... .::::..^7^^~!!~~~~~~~!~~^~.  .   .. ^:..:7~..:YB#G.   ~???YJ7^  5#######B\r\nY5~ ..  .~!??7!^..  .:^!J7    .7!~7JY?:^~^^~~^^^::^~~^^:^.:.:!!!^.^^:^^7:.::::.  .^^~!7^. .  .!?..^!~^~::::.   .^?B####\r\n.:. :^^~77!~~: .^:~?55^... .   75?5PJ~:^~~~!~.^^::^^: .::^^^:^!~^::::::^7~:.:::::...!JY!  ..  ~~!7!^^~J7^   .   .B####G\r\nJ55?!!!~:.....~JPJYY5J:.   . :7Y!~~^^^~~!!~^..^^:.. ..^:. .~~.:~:..:.  .^~^:^~^~~~~~^:!J7::..  :!.JJ~~J7:..^7~^^.^??JPB\r\n..:!JJ?^:^~^:::^!:.:.:^~:^~~7?!~^^~~~!!~::~J7.:~^...^^. ...:^^^^...:7~. ..:^^ .!!~~!^.J5GJ!Y7   ..77~^~:~7??JJ7Y~~55PPP\r\n:~:^YYJ7?7^:.~!.      ...::^!^  .~~~^^^:..~~::^^:^::.      ^^^:     .::..:~^^^^^~~~~~:^7JJY7   .  7^~^.   .:!7??~^^:.::\r\n^^:~PJJ7!!. ..~ ....  ..:^:.   .:::^~^:::::...::^^::^::....:^:....  .:^::^~..??:.^!!~!~^:^YY~  .   .J##5!:: .~7??!.  ..\r\n:^7JY7^!7^:.^7:       ..^:.    ^.::.^J!:   :?:     .^^:. ..  ... ^~^:::^^.::::~^..^~~~~~:.:7?!~^::::~~!!YG?^...:~77~.::\r\nJ777~^..^^:::^~.....:^..::^^.  :::^^^^::...:~..    .:  ..     ..  ::    ..^:...:::^^^^::  .~^::..^:.....^~:::^^..^~!7!?\r\n.:.~77~:...:7P5!~~~::^:^~!?7:..~~~~~^:.:~^:::.:^:::^!^. ..  .....^^.     :J~   .!?!.::.^.   .:^...      .!^.:^77^7YJ?~^\r\n :  .~??7~. :^!5B#5:   .  ~JY~:^~~~!!~.:7J..~~:^^::  ....:::....:^^:::^::...:::::^~^:::.    :::..  .... ~.. .~!7JJ57:^^\r\n::.:^^^7??!^.   .~~:!. .   ~YJ?7^:~~~~~~^~^^~^..::.     .^^^.     .::^^^^::~~:.:^^^~~~:  :!^::...      .!~..:!?7JYY^:~^\r\nPPP55!^J7?J??7~:^^~7?:    !5!?GPY::!~~!!: :^:.. .~7^...:^^^:... .:^...^~:.!Y~^:~!!~~~^:~!?7~~^:~^:..:.~~:::^~~^^7JY7:..\r\nGGJ??~.:~~?~..:~J~~?J:~~  ..::7Y7:^~~~~~^~^::^^.  .:..:~:.^~. .:~:. ..:^~..^~~!~~^^^~^~Y?^...  ..75YJ?5Y!:....:~~!!?55J\r\nP#####:   ..  ^7Y!^^!!7^~   .  ~YJ!...:::::.:~7^::::::^^~^:^^^::. .^^:::^.^!!~~~:^?5PJ5?   .. ..:5PJ!^^: .^~!!7!^^: .:.\r\n&####Y^.   .::::^^^!~..7!.  .  ^7!~^^.  .::::..!^^:^^.:!!7^.::^::^^!~::^~~~~^~~^.7YY?~!J.    !Y!^:.   .:~7?J7~:  .: :Y5\r\nB#######P. :7?Y??J!.   5BG5^..~7:..:~...   .  .!^~~!!~~~~~~!!~^^!~.:::::. .. :~JY7:      .7:7?!^^^:!7J?????:^!^::.:!5Y!\r\n.:!?JG#P~!?J?~!??7!  :.B#5:.^~..  ...^::...~^:.^~!~:^~!~~~^^~~^^^         .~^^77~  ..  ^7^J^!7~?G?: .~?7!7^^?PP5PGGJ~.:\r\n  : .!G75BG?^.~!7??^..:?!7^~:    .   .. .:.^7!~!!7!^JPJJPY7:7?7~::^~.  ^:.::..:7~....:^7~.:?~.^^^:.  ... .75YJ5BJ^~^!!!\r\n .~?~~~JGP~     :??~ ...^:..!~......   .~!:^:   .   :??7?:...::~!?~..:.::...  .:!: ~G##Y   .??7!!^:.     !&&&&#Y: :. :.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(". .^~^   ~5&#BYY!7?7:  ^7?Y???~   .J&B^ ^7       ^7.:.   .    .^^:.  ~!. :!5P~..^~: ^7!:..~!:..:?J^ ..  .JPJ^::!7.  .  \r\n.  .: .. :5#&&&#~      ..:^~!77.  ^GGGJ: ^!:. . .:.~!~. ..   :~~7^    .    ^.:~:    ...:^~~.^..^??7:^...?GBY??^::. .~~.\r\n:..!!!~!^YBYJJY!. ...  .:77!:.~?:~?^ .  .:!!..^^..~^~~!J?7~!JGJ:7GJ^^^^::^!~:^:      .~^.!5B7.. ~???!:^5PP7~&P~:^.  .^.\r\nJY?:.!YGGP5PP?^~7!??~. :?G7:!Y~~7::   :  ^??!:^:  .. .:^~~::!777?7!:~?77^~!~:.:.. .~!^..?B##:   :7???J?!. J###&#BGY!^7~\r\n!?!7Y5!..::^~^^??????7!:^^^!7!~~~  ... :7?J7:..:....:!^^~!!~~~^^~~~~~~^^. ..  ^~:^~!:.. :^7Y: .^!7!~7!~:  .!JJ5P5B&&J?!\r\n..^YY: :.  :~7J?7^:.   .:^!Y~    .5!:7P5Y:.~~~~~^~~:~^:^:^.:!~~!^^~~^^^7:... ...~?J!  ..  !7~!!~:^!^.        :5B###B7. \r\n^...:. :^~!7!~^^. :~~7YG5:.. ..   ?Y?Y5?^:~~~~!~.:^::::^^^::!!7~:.:::::~:~~^~~^^^!7J~ .    .7^JJ^:JBJ:  :... !BBGB#?. :\r\nPJ?J55?!!~^.....:!557?JY7..  ...^?Y~^~^^^~~!!~~^.:~^.....:~~. .~^:::::::^..~!~~!^.7YP?^~?^ :~:~?7^~~.^^~?J!7~:!?YYP5!!~\r\n... .:!YJ?^^~~^:::^^....:^~:~~!?7~^:~~~~!!~:^~J7. ^~:.....^^::^^......^~~..^~~~~~.^YPY!7?.    ~J!^:::^!77???7:7J?Y5PGJ~\r\n:....^!YJ!!7!!:.7!:      ...:::!:  :~~~^^::.:~~::^..^^::. :^^^:..::.:^^. !5~~~~~~~^^~~?Y^  .. .::?J^    .~???~^.    ~5Y\r\n?J55J??7!^.~~^:.::...   .. .:^..   :.:~~::::::....:::::^!~:~!^^:::^~^.:^.:!~. ~!~~~~^:!JJ!...  .^PBBGJ7^ .^!7?!. .~ .?P\r\n..:^..!7!^.....!75^:::::~~:~^~7^  .~^~~^:::^::....::..:~?:   .?!:..:::...::^:::^~~~~:  :7!~~^~~::::::5?!:.. .^!7!:.::..\r\n5J. ~: .~?7!^. :?YPBBP!......~JJ7:^~~~~~~. ^!:.:^.:~^::^~^~~:^7^:::::.....:::::~~:.:   ..^:. ..   ...^:..:~~.:!!???55J?\r\nYP!    .^~7??!.    ^JJ^.. ..  :YJ~~^^~~~~~~~5?  ^^:.::...^^^^..::^~..::.^~^..::^~~~:  .~:::. .      .~7.:!!?!~?Y7~....^\r\n~JGPYY??7:!?7?77!^::::!?7    .7?!JPY~.~~~~~^..~~^......^^::^^.....:~^ .~Y~^.^!!~~~~:^^7?!~~:~~:....^^::::~!~^7JY7:.....\r\n~!7YPYYJ7:~?!JJ!^^.^~^!?~:~: ^J~^7P5?.:!~~!!:.^:::::::^~:  ^~:.....^~^.^~~~!~~~^^^^^JJ!... ...~J??7YP!:.....^~!7?55Y?JP\r\n:. !BBGGG7 ...:  .7B5:^?Y^!:    . ^J7!^^^~~^~~^^^::::.:~7~!::^^^::::^:.^!~~~~^:7Y5JYJ.  .. ..:YBPJ!~^ .^^^!7!~^:..^...^\r\n .!G####G~        .^!^:^!!~!7  .:  ~JJ!. ....::7~^^^!^^!~~!^.^::^:~:^~^~~~~~..J5P?:~P^    :Y!^:.    .^!?J?!:  .^..?5~. \r\n^?7&&B5P5??!.  .^~!~!!!~. .J7^: . :~!^:~~. ..  ^^~~~~~~^^~~~!!~^^!^.:..:..:!??7^....  :~~!77~^~:!7??????^:~^:...^Y5?!7!\r\n~?~!5GB#&&##5. ~?JJ???^   .B&#Y:.:~!. ..:.:~~~:!77!:~7?7!!!^:~~^:.  .  .^:!??~  ..  ..!!^Y7:!PJ: .~??!7!^7PP5PPGY7..?YJ\r\n.^.  .^:^5&7~5PP~:!???!  .^#P?.:~:      .^:^!~^^^^^^?GJ^?GY7^7?J7^~^~:.:^:.~!:.    :?!:?!.:!7?~.  .... ^JJ?YG5~!~!!!:.:\r\n.^!. .:.:7JJBGY:..^:!??~. ::~!^^..     :~^.:.   .    :7~~^.  ....~!~... .  :!~ :7PGG!   !7~~^:...     :#&&&#P^ .. ::  .\r\n  .  .77::^?GY.   . :J?^ ..~~...!7~ .~~..^Y5!:  ^~. .:^^.    .   .^.7~.      !~ :G&P.   ^?J?YJ7^  .~7!~JYB#&G~   :~^.  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      :~^. .J7B#GYG##&&#5..~JJ7777!. :.PY7~~~ .!: ^GBG5~:~!?!~7J77?^~?~...::!JYJ?^.^^^~!^..:??^ ^~  ^J5!.^~^~  ..  .   \r\n  .. .^~^   ~5&#BJ7::^^.  .~7J??J7.   !#&5. !: .~!.:^ . .::. ::!7^:.^?~::7PBBY^.77:..:^:.. :??!.... :YGG!7~!!.. ^: .   \r\n   .  :: .: ^5##&&&~      .  .:^^?!  :YYJ7^..!!:.:~^^   .   ..~!~.    .   .~:.^:. :~:~?J?...!??77:.?GBP~GP: ..  :!:.^!:\r\n:~~:.:!~!~7!YGY???^.....  .^YY7~::77^J~     .^7^.:^7!!?7!~~7PJ::?5~.......~^:~^::^^.:Y#&!.  :77?!77J~^!Y##GP57~:.^:.:~~\r\n^!JJY?:.!YPPP55P?^!?7JJ!...?P!.:Y5.J.    .  :J?7:.. .:~!!:^7JJ?JYY7:7??7!7!^..:!~...!Y5G^  .~??7JJ!^  ~PBB#BGG#BYJ57:.:\r\n^~7~7!?5Y^....^~^^????7?7!:^^~77~!~~..::^:^??!!^::^:!~^~~!~~~^:^~^^^~~^:  .:~7?!  ..  ~?^:~!^:^:....      :??5#&B~^ .^^\r\n::...^J?. ^.  :!7J?!:.    .:^!Y~    .P7.:PG5!.^~~~!^^^^:~^^~~~~~~~!~~^~!^^..^?JJ:  .  .^~!!!^^?PJ.   .   .B&&&#G7.   ^!\r\nY~~~:..^:..^~77~^::. ^!!JPB5:.  ..  .?YJ5Y7::~~~~~^. ^^::.:77~?!..:::^:^~~~~^.~JY!^^:. :J^YY~.^YJ:  :!^:. 7YJYGG^.::::.\r\nY5GGJ??YY?7!~^.....:!5Y!77?~... ...!JY^^^^^~~~!!~^7^:~~^^~~.  :^^^^~~. ^!~~~~.!5GY.:5J. .::!?~~~:^77?YJ7Y~!55P5P5J!~~!:\r\nJ5GPY7!~7YJJ?^:!7^:..^^:...:^~:^~!?7^::~~~~!!^.:~J~. .^^:^~: .^^:^~^.!7^~!~~~^.~J5YY7     .J~~:. ..:~7?77^^~^^!!Y5?:.JJ\r\n^^~:.^J?^!7~^..::::^~!.....^!^.::^!.  :!~^^^::.:~^::^..:^^::^^^^:...  J7^:~!!!!^::~YJ:  .   .JBP7... .!?J7~.  .  ?G5~!7\r\n:..^7^ .^.:!?!^....7PPJ?77:.:::^~??~::~~~~~^:.:~^^^~::^^:::::.:^^::~^^^~:.:^~~~~~::~??!^:...:7?JYPP7:...^!?!:.^: ^7~..:\r\n7!~YGJ. .  .~7J?!. ..:7P#5:   .  :?Y!::^~!!!~:^!Y.  ..:^^^^:::^:..^^:^~^::::^^~!^  .!~::.^!^.....~7^:.::..^~7!^!?^..^^^\r\nJY:.75Y!~^^~^:77?7~:.  .:^^?:     ~YY5J!.^~~~!~^7!.:~^:^~: .^^:^^.  :J~^.^!!~~~~^::!?!~^:~~^....:^...^77:^7JJY?!!7Y5GPJ\r\n:!~^~J5P5PP57^J??Y??7~:~~~77:..  7P^.?G57.~~~~!~. ~~^^^^^  .^~^^~~:^7~~~!~~~^^^^:JY7:.. ...^77!~JP!^.....^~!?JYY?7JGGPY\r\n.::::.:PBYJJ7..^^!^  :7Y~.^YY^?^ .^^~!YY!.^!~~~~:^^::..~7!!7:.::^^..^~~~~~::!J5YYJ.  ..   .Y#G5?7!..::^~!7!~:.:^..:~!~Y\r\n~^   .~P#&&&#^       .?PJ^^!7!!:.   . .?J?^..^^!~^^~!~~~~~~~^:~::^^^!~~~~.~YPG~.!P^    :Y!^::    .:~7J?!^. .~..7J^. .:^\r\n^^. :~P&#PJJ:      .. ..^::!!:^7!  ..  ~?7~:.  :^^~^^^~^:^^~~!!~~^!^^::^!~7J!^~^^:.^~~^!7~^~:!!777???~^~^... :J5Y!!~!~^\r\n:.:!5JJB#GPBBBBP~  ^!?J7??!.  .P5J!...~!^..^!7~7???:!JYJ???7^.~!~:. ..:!?J~  .    .J.Y5^.^YJ:.:~JJ7?7^7P555PP57:.?YJJ7^\r\n^~^.:^.:~?5PG##P7:^???!?77:  .:##P~.:^:::^^^~:......^5Y::?G?~^!7?7!7^::^7~.  .  ^J^!7^:~!J5~:  .:...:7?7JG577!!~!^::~~:\r\n^!~..!:   : .Y#~YBGY:.77??7...!5?!.~^ .:^:.^.   .     ^!~:.   .   ^~~:..~7..:!?JY^  ~?^^^.. .      :#&&##P~ .. ::  ..  \r\n   . :^  .~~~7!PB5~ ....!??^ ...~:...!?::?BBP?:.~?^.:^~7::  ::.   .^ ~!. :7 .Y#&J.   !J??J7~:  .::..!JB#&G~   :~^.  .  \r\n   .   .  ~^^^.!5J^  :^ :J?:..:!!^:^.^7J5Y?^^:..^?!^777J7~!77~^^JPGG~ :!. ^!^7JB.:  ~7777JJ!. JB####GJP#B??^ .^~:      ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  ..   .^?!:::!5JJJ5GB#####P:!J57.^?7?7^:..~.~~75P?!.   :J~..YJ7^JP7 :!?J^^:::.^^:......!?^ ^!  75Y^.!?~^....       .  \r\n         ^~:. ^?JB#Y~7PGGBGJ: :?JJ7?7!. ..?#J^.. ?##GY~::~?~^J!..~J^:!!:    :~~!~: ... .7?7 ..   7PP!^^~?:. .. ..   .  \r\n.~.  .  .^^.   ~G&#BY!       .:^!77?J^   ^###7 .: ~~:: .~~:.^^?5?!^^!J~::?PB#G?^7!!^7..:!??~!^.^JGBJJ5^..:  ^7:..^.....\r\n .   ..  ^: :. ~GB#&&#:        .:^^.:?~ :77^^...:~::   .    .^^~:.   .:  .:?~..  ~P#Y.. :77?7~^YJJ7~##Y!!^.  .:.:7~~!!7\r\n.~~:!!^:^~^!777PGJ7?7....:.  ^!P?!^!!^?~!!. ..  ^7?7!!~^::^Y?:::??.   .  .^:::..!GB#!   .???JY?!. ~B#&&&##B577J7^:::~!7\r\n ..^7JJY7.:?5PP5Y5P7^7?7JJ~:..?Y^.:7G!!~       ^JY7:^!77:~J5Y??7YP?^7777!77!:  .  ^7~ .!!^~^^^^:   .^~~~^:J##?J?:..^?~:\r\n^^:^~!~!!Y5J:  ..^^^~???777!~:^^~?!^~~~::!~^!?YJ:^~^^^~~~^^~^::~~~^:~~~::?JJ.  .  .7~7!~^^7?~         .?GB###7:  :!^.  \r\n~^~^:. .^?! .~. .^7?J7~..    ::^!Y.    ^P~.:YGY!:^~~~!!!~~~~~~~~~!!!~~~~^^~?J^..   .?:J5^ .7#7:  ...  J####B?. .  ::.  \r\n~?5Y!7!::.~^.:~!7!~:::..!??5B#Y.   ..  :JYY5J~..^!~~~~...:77~!7~..^~!~~~~.!YP5::7?:.7!777!^!!::.^??~!::!7JYGY^^^~!^  ..\r\n!Y577J7^?PGY7!~:.. .. ^~P7^~~!^:.....:7YJ:^^^~~~~!~~~!7::^:. .~^:^::~~~~~:.!5P7:7Y:    ~?7^^^^!7J?J7?7:?55P5PPJ~.~!^^~!\r\n^^^:. .:.....^77~:. ..~?G~.....::^!7??7^^:~~~~!!^.:~J.   :.  .:. .77~~~~~~~:^!?JY:  .. :^^!~.   .^!??7^^:...:?5?:~5JJ7~\r\n^^!~^^7P5: ^:  ^7?7~: .~!5B#B!.   . :JJ?::~~~~!!: :7: ..  .^.  .. .?^..!!~~~~^:7YJ^ .   .~B#B5!~. :~7?7~. .^ .YG?^^~!^^\r\n^7JJ5!:?5?: . .^^!??7^.   .~7^:: ..  .JY7!^:^~~~~~~77.  :.  .:   .?!^ :!!~~~~^:^!??7!^::..:::^GJ!....:~77~....::. .:^^:\r\n!!^~!!.^?PP55YYJ:!J7J??7!^^^:!?7    .??^!P5!.:~~~~~^:^:^~. ..^:.!!~~~!~~~~^^^:7Y?^.....::~~^:~G!^ ... .:^!7JGP?^!?7!5Y7\r\n .  ^!~^~^JGYJ?7::!~??~:::~!^~?!!!!.:??:.YP57.~~~~!~^..~7!~!?:...^~~~!~..^?YYJJ^   :   .?#BPY?7:.:.:^!77!:.:!:::!7!Y5J~\r\n  .::  . .!B####5  ..:  .!#?. :55:?.  ..:^JJ~:^~~~~!!!~~~~~~~~~!!!~~~^:~JP5^.^P~    .Y!^:^.   ..^7??7~. .~: ~?^. .:^~~^\r\n  .^7:  .!B##BBY:         ~??~^~~7~!:  .. .?YJ^:^~~::^~~:.:^~^~~~^^~~^:?YJ7~~7^:^~~^~?!^~^~!!777??!^^^.   .7557!~!~^:~^\r\n.~?~...!Y!##5^:~^^:.   :::::~^~!: ^?~     .!77!77??^755???J5J!:!7!^:!JJ!.      :7^GJ^.:?J:.:~JY7??~!55Y5555J^.!YJ?7^.. \r\n!!!^::^?J?75B##&&&##7  ~?YJ7??:   ^#BG7..:^:^.  ..  .7J:::75~^^~~!!7?7^  ..  ~!^J^!!:~7P?^  .:.:..~77JPP??7!~~~:^!!^~!:\r\n?7!~~7^.:: ..^77YB#7!?JY~~!?77: ..7&G7  ..:7^.  ..    :~^~.    .   :^~^...::~7^.^?^.^^^.        .G&&#BG7..:.:^. ..   . \r\n..:..^:.:7~  .. :557BB5~.:!~??7:. 7~7!!^!P#BGJ^.^?7:^~7Y?^^..~~. ..^~ :. !B##7   :J?77!^:.       ~YB#&#!.  .^^.  .  .~:\r\n  .    . .. ..7!^~~PGJ.  .. !??. ... .~7!!^    :~!^:J!::!J^~?!::^JG##J...:J#P.. .~7?7JJ?^ .?5BGP57^?##Y7~ .:~^.        \r\n  .        . .^^7!.^Y5?  ~~ :?7:......^~.:::::7J!^ ~PY^~?5: ^J^   .!?P57!~:~^ ::7???~.!5J!:5######BPJJJ57:.:~?~.   ..  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  ~Y!    :~!!!~..:^:^:.::^~~!P&^YBGJ.:!^!??7.  :^:^^!!7JJ?7. .  .   .^?J7J?!~?7~^::^~^. .:^:JB5^^JY7~^:.   .~.  .    . \r\n  .. .:   .^?!:.:!PJ7YPBB#&&&##?.!?Y~^7??7^...YJ!::    ~J~: !JJ~!J?: ^!JJ!~!!!~7!~^^7?7 .^   !PY^:^^7:  .  .    :.  77:\r\n^^.         :~^. ^7Y##7..~?JYJ!: .!?5???!.  .!&BB#BP?^..~?^:Y!. .!5^.~!~    ...^^  .7??^::..^5BG?J~^^:. ^~. ..  .    ^7\r\n^  .~.  .  .^:.   ~B&##P?        ..:^~!7?.  .GBBYJJ!!..!7~:~^?YJ?!~^??^.:7J5PGGBG.. :7??7^.?PG5^P#!.:.   :^.:?~~~^~!7?Y\r\n7^: .   ..  ^^.:. !GB##&B.   .    .~7!^.~J::?!..      .     :^^~:.  .~: .~?PPB#&J    !7?7J??^.^G####BG57:^!::^::~7???77\r\n!!~:!!^!!^^~~^!7J?PPY77~..::^.  ~?P^:.:J7^?:^.  :  .:.:...!7~^:~7:    .    ..^7Y7  .~77!7?!^.  !Y5PPY?YGB7?G7..:!!!~:. \r\n77^  .^7JJY7.^J555YJY5!~??7YJ!^..??^:^!PY^7   .. .~?JJ?^~YP5!77~5P7^~~~^.  :  :?~^!!^:~~.  .        ^^7B&G~!..::~~.    \r\n~??~~:^~~^~!55?.   .:^^!??7!!!~~^^^!?!:^^:::~7:~55Y~.~~^:~~~^^~77!^:77?J7. .   .~~!J^.^75!..  .   :G#&&#B?.   ~!:  .   \r\n~??7~!~^: .^7! .~. .~7??7^..   .^^^~J.    :P~.~Y5?~:^~~!~~~~.:~~~~~~~.^J55~~!^..J~5P~. :55^  :^.. .YP5PBP: :....      .\r\n7J7~!7?!^..  .  .!??!^..:.:?JYPB#J.   :.  :JJYY?^..:^~~~~!!~~!~~~~~~~:.?5P^ ^?7..^^:7?~~~:^!!?Y?7?^~JY55PJ?~~!!. .:    \r\n7!!^::::..!J! .!..^77~:...7PB##BG~.     ^JYJ::^^~~!~~~~!^7^..~J~~~~~^:..75PJ??.    .Y!^:..::~77?7?:^7!7?JP57..J?777~~!:\r\n: ..^7???^JPY.    .^!?J7^    :?GJ..  .. .7Y!^^^~!!~~~~!Y.     .J7~~~~!!~^^^!Y7. .:  ..7P?:    :7??7~.    .JPJ^????^.. .\r\n:!~~777?J:.!5PJ?!~7~:77?77~:...:^~J^     !JJP57..:^^~~~^J~..:!^!~~~~!!~~^::?YJ~     .^PB##G5?...:~77^..~: !Y7:.:^::^~~7\r\n    :. .!!~~?J5555Y7^??7Y?7!^:~~~77^::..!J^ :PP?:.~~~~~~!!~~!7~~~~^:..:7JYJJ~   :   .7#BG5YJ~:...:!??7.  .  ..:~77!~!J?\r\n:      ....: .YBP55Y. .:^^  :JP^..~5P~?:.^!~~YPY~.~!~~~~~:.~~~~~~~~:^7557:^P~     J~^^~.   ..:!??7~. .~: ^7^. .^~!~!??~\r\n   .  :!!   .!G#&&&B~       .~P7^.:J7^!.      !J777::~!7~::^~~^^~~.^YPP!:!!^^:^^:~?!^^^^~~!!7??7^^^.    !5P7~^~~^:~~??~\r\n.   .^~::. ^~5&BJ~~      . .  .~!:^!!~~?^  ..  ^~~!~!5P!!?!YPY!^??J?!: ...  !~?P7~:^7?:.^!JY??J~~YYJYYY5J~.~YJ??^.  ^77\r\n .:^~!!:..!GJ7GGY7?55YY!.  ^~77~77!:  ~Y7^.     ..   :7~:^^77:..::::  :   ::7^!Y^..:5Y~  .^::..^77JPPJJ?!^^~^^!7~~!:^!!\r\n77???7!::::^!~^75G#####B! :7?J???7.   !&#BP5?^. .~.  ..~^^^.    .      . ~?^:?~.^!7!: .  .    P###BG?..:.^~. ..   . .^!\r\nY??7!~~~~?^.:^   .:.!BB^YGPY.^7???^ ..5#GGGPY?^.:7?~~!?YYJ^~:^7!..^~??JGBB^  .77!~^:..        7P##&#!.   ::.  .  .~:  :\r\n?^.   .  ....~~  :::~J?PBP~..:^^??7.  ^^.::    ^!~::Y7. .~Y:^?!..:?PB#BB&?.  .~???5?!: .^?J??~:.~B#5!~ .:!^.  .     .^^\r\n:!7. .:    .  .  .7~^:^JP7.  :. !J?^:^!7~~~~~!?Y!~ .?J7^?J?..^?!    :^!J5...:7???^~JJ!.!B#&&&#BBP5?7P7:.:~?~.   ..  .  \r\n .    .   ^.   .:^~7JY^:JBY:^^. .^~~^:^!!?!!7Y7J?~.   .. .  !??J7!~^:.^:   !??7^!:.?GBP:&G7~!^^^.:~:~^..^!!!~:    ^Y~. ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("!:77.^~:!?777????7~^~~..:..  .: :5JJBGJ .. ..7~~!!?^:!57~^..   .~    .:^.^5P57^.   :.^J?7Y5^~YY?7!!.   .!:  ^...  .. ^:\r\n^:  .^J:   .:~!!!^...!7!!^!??JYJP#Y:GPP~.~7!??7!~~7777JJJ?:    ~:  ..:~7!Y?^:~~^. .::~. :?5?::!^~: ..   .   ..  ~!: ^!?\r\n^!^     ..   .~?~:.:?P7~JYPPB#&&&#P..~J?!!?77: ...  ..?J~^ ^??~!!!^. ~7JJ?!7777??7?:...  7PBJ!~~7^. .:. .   ..   :^!^. \r\n ^Y^^.     .  .^!:  ~!P#B: ..:^:^.  .^!JJ7J7.   ^P?^.  !7:.57.  .?P^ ^77:.  ....^??77~.~YBB??B!  :  .~~..!^:::::~7Y5^:^\r\n.~Y:  :~.  .  .::   .!#&&#G7  ..... .. .:~:77  .J5Y?::!77~~~J?!!77!^77^..:~!7..  !7?7!7J7~~7B#BP5?~^..^..~~^!7?J???YPY^\r\n^ !7^. .   .. .~~.:..JGGB##5    ...^.:?J?!^:!?^?7.   ..   .:~~^7^:..^7^.:?5BY   .7J7?Y?!. .YB###BGBG5!75?:..:!777!~^~!~\r\n.^?!!^:!~~7!~~!:^!JYJPPY7!^.:::^.  ~YP.   ?P:7:.   ...   :~~~::!^    .:.  .77.:!!:^^....    ..::.  ^PP~YJ^..~?!:.     !\r\n~7777:  .^7?JY~:!YYJYJ?YY^!J??YJ!~.:?7^^!755^!..::^::7!!JG5^!J^:55^:.  .   :^7~!~^!JJ^ ......  .!55B&&7^  :~^:.    :.  \r\nYY7~??~~:^^~^~7PY~    .^^~7??7~~~^^^^^!?^:^:.^^:?^:5G57:~7!!~!?JJ?77Y?^^:.  7:JG^   ^B~^  .    5&&&#B?: .  ^^. ..     .\r\nJJ7!??^:.:.. .7P7 ~7. :!7??!:..   :~^^~?     ~P^:JPY~..^~~~. .^^~::JPG~.?!:::^?J?7^:7J^. :7!^^.:7?J5B?.:^^~:  .    ~^  \r\n7777...:~7!~~7P5^ ..  :!??7^  :.^Y##!.  .~   ~JJY?7^....:~!:.~~^:.  75G~:!Y:  ..~?!^~^^!?J?J7J7^J5PPPP5?~:!~::^^... .^^\r\n7~!^^^^~7JJY7.!5Y~::.:^^~??7!:.   :~~^!  .  .JYYJ!::~~^^:~!7!~:^^^~::!JYJY:     ~~^^:.  .:~7??!:^^.::~Y5!.!5JJ7~^~^^~!7\r\n~^: ...^~::~!:~75PPPP5Y^!J7JJJ?7^^~^!?!.   .J7:^G5?. .:^~!::!~:..:::!7YJ?!.  ~.  .~B#5^.:. :7??!^  .. :YG?^!!7~:...!?77\r\n  :~.   .  :~^^^:7B5J?7:.^^!7^..:77^^77??~:::~?.^PPY^:~~^:  ~~~^..^JP5^^57     !~^^!:.  ...~7??!:  !7 ~PJ: ..:.:^7?!!?J\r\n.     .. .^^. . .7B#&&&G    .  :^B!   :G5:?. .:~^?5?!7?J7!^!!!!:!5GP^:?^^~.::::?7~^^^^^~~!??7~^^.    ^YPJ~^^^^:^^7?~7Y5\r\n  .:    .::~^  :!#&#GP?.   ....: :JJ7^~!~7^:   .  ::^YP^^J7^JGY7!?~:^:^..!:Y5?!~^!7:.~!JYJ?J7^JJ??J?YY7:^JY??^.  :7777!\r\n?     .:~?~..:?5~PG~. ..:.   . ....:^:~!^.!7:  .:.    ^!::^~~^.  ...    .?.PY    YP!. .^^^:.:!7J5PYYY!^:!~~77!~!::!!7~.\r\n^~~^^~777!^...?57!YGBGB##BBY. .~7YJ7J?:   ?B5?^ :7^..::7^^~:.   ..    !J^7!:^~?J?^.^: .    J##BGG5:.^.~!: ...  . .~!7.:\r\n:JPY???J?7!^^~..^:.^!?5PB##J~^!J777?7!  ..!7!^..:7?^!7777JJ!~~!7!::7JYY:  !7:^:.. . .....  !B#&&#7.   .:.  .   ~^  .J!.\r\n^^:Y5?!^::^:^7:.~~.  .. ~BY!BBP!.^77??^....   .!7~.:5J.  .~5::77. .~?P!   .7J7JJ7~.  .::^:.  :G#B!!  :!^.  .     .^:J! \r\n .^!~:.   .   ...:: .:!~~7?BG?. ....????7777!7JY7!  ~7!~~??~ :~?J..  ..: .!7?7!?J~. 5B&&&#B55YJ!!PJ:..^?~.   .:     :!^\r\nY~~ :!!  ..       .. .~^!::75?:  ~::. .^~!^^7Y!7!^..  .!    .7J?J?77!~~!!??7!!.:PPG^?#G55YJJ7~!!77:..^!!!~:.   .J~.  .^\r\n^:. .   . ^  .7.   .~!7?YY~^YP?7?~::   .^~YP5!.::.    ~:   ..:!!57:^?!!!~7:...: 7GB57P^ .:   .:..^~^^!7???7777!:~^.~7:^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("~!7J5B#? ...75YJ?7??!~~~~7: ~!^  ::~!775G5.     .:!GGG~.PBBBP^ :^. 5&&&&G5BJ7GPYJ?7JY5?^!?J7777^.  .^:  !^^^:^~~ .:5G#?\r\n5YJ!:7!.^~:~7777????7~:^~:.:.    ^..JB^BBG^.::.:^!:^7Y7:....   ^~   ~7JJ^^5PGY?^. .:!PP!:~J7~:...   ..  .   .:. .!~B@? \r\n~:.^:  .^J:    :~!!!^..:7J77?JPGGBGB#B^!55J.:?7?7??77J?J?^..  :^.  ...:~^Y?~^^^.     :5G?:^^?~. ..  .   ..  :!::~^:GY::\r\nJ?::!^.    :.   .^?^..:?P!~^!77?PGB#B5^ :7?Y7?77:..:^?J!~ .~~^!?^.. .!JJJ?777?7!~~.:~PBG?57..:  .!~..:....  .^?5:....  \r\n7GJ ^Y^^.     .  .^!:  ^~G&B^   :^.     :^!?7?J~     .7!..YJ~...~55: ~7J~::::!???~:755J^Y&5!~^.  .^..77~!!7????YYJ?:.. \r\n7PP:~Y:  :~.  .  .:. .  !B&&#BJ ..:....   .:^::?~ .~^^~?!^7?~:.:^77:!!^.     ~???YJ?^ .P##&&&#BP?!?7~::.^7??????Y5!.:. \r\n:GB~ !7~: .  ... .!~.^.:YGPG#BY    . .!~^?7?~~~^7!~?:.:. .:~?!7J!^::??^^!. ^!~~~^~^^.   ^!7?7^~!J~.JG!.::~!!!^:...:~~:.\r\nYY~.~?!!^:!~~?7!!!::!Y55PPY?!:.^^^~.  ~P5    ^G?^7       .~~..:~.     .7!!!!^^~?!. ......:^. :.~P#P!7...:7!.    . .7:  \r\n   ~777?^...^7?JJ^:7YJ???7JJ^!J??YJ!~..!!^~!7YY^^:.~~^!755:^?!:^5!..    ^!~5~..:~5:~~...   .Y##&&#J:   !!:  .   .  . .^\r\n  :!77?7^^^!~!!^75BP^    .^^~777!~^^:^^^~!?^.::.^~:!7:?G5J???JJYPG!^77..~:JG7.  .P5:  .:.. :GBGB#5. :. ...  .  .:  :^J!\r\nP: ?!!7^...^7J?J^!55^    .~~???!:     .^^7J     ~P!^YPJ:.    ..:?5Y~^^~!..~~~77~~!::^^7Y77!:~?JJPP7!~~7!. ..   .:. .?7:\r\nP:.?!!..!^~7!!7?^.~YG5YJ?J!:77??77~^:::^!J^    .??75PY:         .JPP!7J:    :J!~:^:^~77??7?:~J?Y55G5!.:7!~!7~^~. !!?..Y\r\n:~?: ...   ..  ~7~~!75PYY?!:!7!Y?~^^.~~~7?~^~: ~7^^~Y5?: .     :?P5~!57     !J~^:     .!???~~:.   ^55!:JJJ?^...:7!!?..P\r\n^Y~:  ::     ... .: .J#BGGG^ ..::  :JB^  :!G5:~..!?^~PP5JJ?7?JYGJ^!!:~!....:?7~^^^::^^!777!^^.    :5BG7^~!~7^^:!?77!^  \r\n^. .      .  .~7.  .7B#&##P^   ...^!:5~:. ^P7^!    :.!5!:!J~:JP?!^~!..^:J5?7!~~!:.!!JYJ?J7:??7777JY?^^?J7?^...:7777!.  \r\n  :!. ..   .~7:...!!Y&G!:: .^:...... .!?!^^~!7~7.     .~^..^~:.      ~~!B!    JG!. .~~^^::~?Y5P5557^.!!!7?!~!::!!7!.^JY\r\n..~!^.  .:~!!!::.~GY:~?~^:~77~^   .:^^^^~~!^..!^~7?::^~J?!7!:.  :..7!~?^~!^77?~^7. .    7BBGPGP^.^:~!: ...  . .!!7.:GB~\r\n..^.~YY?7???77^.::~7?!?PB#&&&##G: :7JY???!      :!!^~?~^::!?7~!?!~^~: ^?:.^^:.  ....:.. 7##&&#7. . .:.  .   ^^  .J!.5G?\r\n ..:7YYY????7!!~!7..^.  .^!!5#G^?YYJ^~7??!:.::^?7!..J5!. .^75..!7.     ^J?77!^:.    .:^  .^G&#!~  .!^.  .      ::J! 7B?\r\n  .....YJ~.  ....:..^!:  :..!P?5BG7:.~~!7??77?JY?7. .:^77^!~. ^!?J^:. .!7?7YJ7: :YGBBG5?!!!~~!5Y:..^?~.   .:    .^7::?J\r\n.:?G^:~::~:  ..   .. .. .^?~^^7GP~     .^^^^7Y~~^...  .^^   .:7JJJ77??7?7?^.?5Y7:G#BBBBBGY??!J?::.:~!!~:    .J^.  :~::^\r\n ~@&7!: .::   .   .   ...:~!J!:~P57:. .:!JGGP~:7?!^.  ^^.   ...:!Y7^:!~^:::.:PG#~G5:.^.   .^.:~^:^77???7!!!~:~^.~!:~?J5\r\n~#B5^. ^~::^^:!  .~.  .:!777JJ!^755Y?7YYPG??GPP&&&&G. ^^ .YGGBP.:PGG7:.      JGP?7!~::  :!~..7!~~~!??7??Y5?..: !##P5J7!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  :~   ..^. .:^7YJ?YJ?!.... .  ..:. ..J!:::!Y?7J55G775J7GB##&Y:.:.7##B5!. :..??^.!?JY?7~^~7!^  ...  !7!~:^~?: :YPBP~.  \r\n!!!77JYP##~ :.:J5Y??77??!~~~7^.:~:  ...~?75GG~ .~YBGY?~B&##BJ .:...B&&&#5JY!!5J7!!~~^75J7~^:    :^  ..    .  ^:5&B. .~.\r\nJP55J7^:!^.^~:~!~!7??777~:.:^:^^..::~~^J&77#G5.:^.~J5!.::::.  ^~~  :J5GG!~P5GGY!^^J5!:^^!~  .   .   .:  ^?^.:!~#&~..  .\r\n7!!~::~:  .^?.    :~!!~:.:~JY7~J5GB#&&&##Y.~?Y!:77~!J?J!:..  ...:     .::JJ?!::. 7GB5?7^^^. .~^..    .   .~?^. .:..  ..\r\n7^!J?::7^.    :.   .~7^..:YY!!..^^.~?JYY7^ .~?YJ??!~JJ77. ::.!?7.   .!?J?J!~!!.^5GG7!&5:.:   .~..!7~~~^~7?J5?~7~:.     \r\nJ!^7B! 7J::      .  .^!.  ~!#&B^.. ~!.     ..:^~!7?:.J~..?Y7::^^7Y?. !7Y!~7??7JJ!..JB###BG5?^:!^::^:^7???7??YPJ^.. .~^.\r\n^:!?G5.~J.  ^^   .  .:. . .7#&&##7  ...:.:: .~!!^.^J:^?!^?7:    :?7:^!~::!?7!?7~:  :YPPPPJYPP~:JP?.:.^!7?77!!??^:~.7&BG\r\n@&^^BG:.7!!. .  ... :!!:^.^PGPGBG!    . .~J7?^^::??:J::.^^7Y?~?Y7~~~7~^!~:^~:. .  .  .^~  ...!7^55^.:~7!^:.    77^ .^.^\r\nYYJJ7:.77!!::~~!?777!.^75P5P5Y?~::^~~~. .!GJ    .5P:?.  .^^:..:~.   :7^?!::7?Y.!~..:..:^ ^7?G&&7!  :^^~.    :. ..  .^~.\r\n5!PY: ~?!77   .^?JY?:^?J?~!!!?7:7J7JJJ!!.:!~~!7?Y?:...^?^:^!~~:~!~. ~~!B~    !G~~  .    5&&&&BY:   .!^. ..     ...!~:^7\r\nG:7#5 ^?!!:~!~!7??J?.^J5?~^:^^.^777!77~~~~~~!!.....!~:^Y77?JYY!:?!:...^JJ7~::75~. .!^:: ^YYYPB7..:.:.  .   .~:  :JJ ^GY\r\n~JG5:^!^::  . :^..^7^~7Y5P5P5Y~!Y7JJ?7!^:~^!?~... .Y!..PPJ. .?PG:.^Y: ...~7!^~::!7?JY7J7^J5P5P5Y7~^!^..::  . .::!~:?G5~\r\nJG! 7Y^  .!.   .  .::::.~BGYJJ~ :^^!: .^Y?::~7JJ~...:~?^!JYJ???Y^:^7.....!7!^~~~~!7!777~.^~^~!?5Y~ !J???!~!~:~!?~ ?#Y.5\r\n?~.^7:..     ..  ^!:   .?B#&&&G    .  ^~P?    ^G?:!..~!~:^!7~::?~....!Y?77~~~^.!!?JJ???:!7!~~~7JJ~.!5JJ^.   ~7!7! :JP!5\r\n.~^.  .. .:    .^^^:  ~!#&BY?! ::...:.~7.JJ7::!J~!:   .^^. .^~.  .7:YP:    !B7.  ~!~~^:~?Y5PPPP7~.~777?7~~^:!!!?..!JJYY\r\n^.:. ^!?    .:^~7~:.:JP^7?: .  ^~.     .  :~^:~!~~!~^~!YJ!7J?:^...J:7J:.::77J!.  .   ^PGP5PG!.^:~7^ ..:. .. !!?..5B7:#@\r\nGB&Y.^::77!!!777!~.:.7PY:^55Y?5P55J^  .~!?!!77^:^!~:!J:.  .:7J^~?^:J^.^!7!. ::.:...  !#&&&#J. .  :.  .   :^  .?!.YGJ!^^\r\n.^!: ..:?P5??7???7~:^::^7^^JPG#####5..~JJ???7!~Y7!. ?5?:^::!JY..~J:.?7!~^...     .!!  :^G&&7!  .!~:  .      ::?J ^BJ^~7\r\n     .:~?!?5J?7!~~~~!7..~.   :.:J&?~PGP!.~!~!J?J?7.   .!?7:::. !7?Y~!???Y?!. :~JJ?7~.:^..!!J5:..:7~.   .:    .^7:.?Y!^7\r\n...  ... .:J!:       ...:~. .::^7?JBGJ..::~7JJ^::.    ...:   .:!J?J7!77^~Y?~.J#&&&&##BPY~~JY!:.:~!!~:     7~.  :!::^!!!\r\n.  ..^#&!~^.^?~  ..   .   .  ^!^^:!5Y^:~JPGPP!^5P5J:  ^~^   .:::.~5J~.^:.JGBY~&5~~!^::.^~:^:..^!77??7!~~^:~~.:~::!?Y55Y\r\n.^:  P&P:~  ..    .  :^    .^~!?Y?^^~!77JP7!Y5Y&&&&#. .:: !G####!!YGBY~. :PGG!J~..:  :~^.:7!~~!???77?Y5Y^.:.:B#G5YJ?777\r\n  .^5#P5^ .7!^:~!!7  ...  :!7!~~7?JJ?7.:7J:.:..!5###?.:..7#&##BJJP?!GPPJ77Y7^::~Y:. .^..  . .:..~?JYJJ5?^.. .~:.   ^:  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(".. ...    ..  :...::. ^Y?.    .   ..   . .:^??!:.7Y: .   .^!YP!:~!JY!.. .~::.  . .^~!7!!! .^..:^77^::^~!~:.7PPPY7.  ...\r\n ..  :^   .:~. ..^7Y5JJJ??~::^.:: .:^^  .!J:^^7??Y?!!!:?5G##G?:. :PBP5!.  . .!7:.!JJ?77^.   :~  :^.:...: ..JG&? .~. .  \r\n!7?7?7?J55G##^.:.:J5Y?777???!^~!^..^.   : .JY?BGGBPJ5JB&&&&G: .:. ^#&&#B77!^!Y7^^^!!^^  .   .    .  .!^  !~B@Y ...   ..\r\n~~7J5YJ7!:.^:.~!:^~^~77?77!~:.:~!~7^^!7?J?Y#G:GGP5YP! ~77!^  ^~~^  JB###?JPY5GPGP~!^!!.  :. .    .   ^:~^^ ~?::  ......\r\n!~~!!!~::!:  .^7     .^!!~:.:!5Y!.~5PGB#&&&#G^ ^J?7Y?7~..   .: .:   ..::.75PGGBG!GY. ..  ^!:.^~:.:..:~?57.:..  .:  ....\r\n^7J?^~JJ:.7~..   :.    ^7:..:YJ7?: .^ .^~^~:.  ^!JY7???: .  ^!^~   ..~7??Y?7J7!!Y#B5J?~:. ^..^!^~!7??7??Y55?^:.  .  .  \r\n7G57~~7B! 7J:: ..   .  :^!.  ~!#&B!:. ^?:      . .:~^^: ~JJ~~77!77^ .77J7YJ7^  7B##&##BBP77JJ~..:!???7???55~ : .P57:  .\r\nJ!~~^!?GP.~J.  ::   .  .:  . .?#&&&#?   ..:.:!:.7J?!^::.??.     :57..::^:..:.    .^^:.:~^. :5G!:::~!77~^::^~^~::555BGY?\r\nY@@@&^~BP..7!!. : .::. ^7!^~:~GP55G5^   .. .~7?7.   ~P~:~75?:^7?7!:^~~~JJ7 ....: .^J. :.:YBJ!J:..:?7:.     :J^. ...:!J5\r\nG@@@G.PB7 77~!~!?77??7?7.^75P5555?~:^~~!!. .!G?   ..7Y^!^:^. :~~!!^G7    J7!J^....  .7GG#&#Y:  .!~:     ..     .~!^^~!~\r\n^:!7~7B5:.7!!. ^::!~^~!~.~JGPPGGGP~Y5?JJ?~!..^^~!!?Y!.. ..::::....:?J:.  .GY:  ..   ~#####Y: .  .:.  .   .  ^:?! ^YJ!^7\r\nG7:~?B7.7J.  ::   ..  ~!~^~~YGJ?7!.:!!??^:::!~^!7!77^...:^?YJ^:...:77!7!^~7^:.:7?!~^.~7?JG5~^^^!~  ..   :^  .??.^GY~^!P\r\n7~~?5! ^J^^. ..  .  .::  : .?B####7  ...  :?B:  .:?J^....:::^.. ..~Y?!7~^^: ~~?JJ?Y5~5GGGPPGY~:^7~^~!:.^  !~7:.JBJ~7~::\r\n~!!~^~~:.    ..     .^!.  :?#&#BBJ:   ...:?77Y    ~G!~7^~: .:::7:J?:..  !B7. .~7!~~:^?555PPP7~ !?????!?!~~!!? ^BG.Y@@@B\r\n5J!:...  ^7^     ..!?^..:7?7#P^.:  ?~. ....: !JJ!^~~:~7J?~:?Y?~^^P7   .!??~:  .   :YP5Y5B7:~^!7~ .::. :. !!?:.YB7.&@@@G\r\n?5GBYY5^.~^~::.:^!!!~:.:^G5: .:^: :^^.    ....:^:.:.!P^     .!Y:::^!?J?::!^.:..   7#&&&#J. .  :.  .   ::  .?~.5GJ~~!!!J\r\n. .:7PG: : ^Y5J??????!:..~JY!7PBBB####BJ  :!?Y7J77: ^7?!!!~^JY7 :^:~:....     .7!  ^~B&&?~  .!~:  .   .. ..7J ^BJ~~!YGY\r\n  .  .  .::755Y??7???7~^~^..^..^~JY5B#P!~!??7YJ??!:.   ~~~! .. .7??7JJ7^. ..^^^^. :: :J7?5:..:!~.    :   ..^7..JY~:?Y?~\r\n....  :.  ..^.~5J!^:.:::~~..!^.  : .JB!5BGGP5?:::..   .: ..   ..~7?Y??J~..P#&&&#BPP5!.~JP7:.:~!!~:     !^.  :!^:~!!!!~!\r\n......  .:!~ :^~^:   .    . .:. .~7~!~5GPGPYPY!B##GY  :~^~  :~!!~ ~PYYPPG:5#PJYJ??~^7!7!:.:^!77777~^^::!!:.^..~!?J5Y?~~\r\n..   ... !@&!!. ^!^  .    .   .  ^~~!^^^!Y7^7?7G#&&&! .:...5#&&&#JYJPBGG#JJY: :.  .::.:!~^~7??777?J5Y^.:.:G#G55YJ?????7\r\n  . .~. ~#BY.: :...:.::  ^^    ^!!?JJ7..!7: .  .!5GBG^ ..7P##BPJ^!7!7YJ??~^:?7.. ^~:. ::.^::~???JJ557^.. .!^..  ^:  ...\r\n...  .!JPGP?::~!~^::~77^:..^: ~7!77~~. .  ..:^. ..~YY!^:~557~.   : .Y?.:!7?~:. ..   .        .75! .^:...:  ..    ......");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(".....  .:......  ::  ... :!^.~^  ..         :~: .. ..^~^.^..!::~~^..^:~J: . ..   .  .^^7^:~!!^:^!!7!!~^^YG7Y57.   .^:::\r\n!:... ....   ..  :...:^~:^YY!.       .. .  ..!..!7: ..   .^7Y77?????^ ..:!^:.  .  .::   .^  :7^^::^!: .7PBG^... ..  ...\r\n^  ...  :^  .:^!. ..^?J5YJ?7??!^~^^7:.:!~. .:~!!?J~:^.^75GBB5^   ^PGY7:   . .^~. ::..   .:   .   .:  ~^Y&#. .^.  ...  .\r\n~?77???JJY5P5G#G:.:.~Y5J7777???!::~^.::.   :..7#~7?G5P&&&&#~  ::..!&&#BY^:^.!J7:~?.  .  .    :   !~::!:JB!:.  .......  \r\n57!~~?JYJ?!^..:.:!!.::^~77777~~::^!J????5GGGGB##!~5~ ?55Y?. :~.~: .G#&&&YPP?~JY^.:.  ~!:.... .   :!Y7.. .   ... . .. ..\r\n^~!~~~!!!~:^7:  .^~     :^!!^:.:?P?^  !??75BB#BP! .~!:.     ::^.:   :~!~.!Y7~#B7^~.   ::.^?~~!!7???JY?J!^:..::  ...  ::\r\n7!.~J5?:~YJ..?~..   .     ~!:..:5??J: .~  :^.     :^!?: .  ^^^~^   ..:~!^. 7##&&&#BGY!77!^:::7???777?Y5J^..  ::    ....\r\n7? JGJ~~~JB^ J7.. ..   .  :~~   ~J&&B!^  !!::::..   .:.:7?~!J~?!^^. .~~^:   :!7??~~7?~ ^55?:::~77??77?YJ:.^ J&B5!:.::  \r\n~7!J77?~~JG5.~?.  ::   .  .:  . .Y#&&&&7   ..~^^~7^?7?!??.      !PY7!^    ..  :!. .~  :^^P5:.:^!!~^.    !!^.:!^7PGGPJ?7\r\n?~777GGY:?BY..?77  . .^.. ~!!^~:?B5Y5PJ. . .  :~?7!.   .PY!. .^!7:.:^5!^7^.7^..^~ .^~P#&!7...:^!:    .. ^:.  :^..~!JY?!\r\n:^5P!.^~YG?:!!...    .:. :!~!7J?J???~: ~!!7~. :?B!  ..^^!~^:.^7Y!     JJ^!. .    Y#&&&#5^   :7^. ..     ...^~^^!7!~~~~!\r\n.^YPJ~~YP~ 7J^. .~.      ...:. ^BBP5P? .::~.  ^GY:.:~YP:..   ...55!:..?B~. .^:.. ?PPPBB~ .:....     .^. .:?J :P5~~?5Y~.\r\n!~~~~!7!^:~~...      .  ^!^   :JB&&&#P.   .  ~^?J.    ^J?^.::^~:~:.. ^BJ^  ^?!!! .~7J?J??7~~!^  :.   ....!7:!PP!^.~PP~.\r\n!?YJ!~:.^^.  .^  :    .~~::..!~#&G7~^ ^^..^7:^7~~P^: .77!: .!YG:    ~!J~:  ... .755J5BJ^~~!!~...^: .. !7?: ?B5:?PG7!?~?\r\n??YPGGP?:~^.^!7.   .^~!7~:.:JG~^^. ~. .7:....    :77JG!.     .!J~77?~!!^:~..   ^#&&&#5: .. .:  .   .:  .7!.JBY~!JJ7J7!~\r\n  ::.:!5B&5 ^:.?Y?77??77!:::75P~ ^?7~^777!:   :^~~. .^~!?!?!~??~.^:   ..:^:.~!. ^!G&&5~   ^~:. ..  .: ..!Y.:GY~!^7PY.7?\r\n. ..    .:. ..:?55?7777??7:..:!7?!YG##&&&##J .^!!^...  ^^~^~  . .7!^:     .:^  ^: .YJ7Y^..:!~.    .   ..^?..?5!:75Y!.~J\r\n.:. .... .:..:^!YJYJ???7!!~~7~..:   .~~7G&7!J7.^!^:.  .::^:.    .:!!. ^5BBBG577?!. :7PY^:.^!7~:     ^^.  :7~:~!!!!~~!!^\r\n.. .. .  .:   ....~57:.  ...:...!~. .:.:JY~?PG?#&&#B: :~:~^  !JYY?.^Y!^B#BBBBGPY??7Y7~::^~!7777~:::.!7: ...^~7?JJ?!~!7Y\r\n. .......  .:^GY.!^:^!.  :    .  .  .7!:7J7:^^^YB#&&?..:^. :B&&&&B5GJ?^BJ..^    .:.:~::~???7777?Y5!:::.5&G5PP5YYJ??77?!\r\n.. ...  .^.  G@P^!  ::.  .   ..   ...: .~~: ..  :7YGG~   :YGBBPJ!.^^^??7!~::  ^!^.:7~^~~!??7?JY5Y?~..  7!^.. :^  ...  :\r\n...  .:  :.:P#PJ...!^:.^:!^  ^:   .::  .  .::~^.. :??7??!7Y?~:    . .77..!... . ..    .  .~JY~:!~:.:.:.  ..  .... ....!\r\n::::..   ~YY?P5~^~!!!!~^:^!!~:^7^^.  .   .. . .?!:^:.^~~^:!: :.^!^:.  . .^: .       .:  :~.^7^  ..  .^. ......:.  .....");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("..:^:....  .. .. .....  :^GG!7. ~7:      .7:      ..    ^!~~!!7????77!^:   ..   ..  ~?~!7~~?Y?7!?7~~7P!^55^.  :7~::. ~:\r\n....:...  .:. ......^^.  ..  ~?:..  .:       .. .  .:^:.7^:~..^^~^.:~~7?.   .   :^   ...^7~^:^~7!..!PGBJ~.  ........:^:\r\n~^!7:... ....       ...::^??!JY?~. ..    ...: ..^:..... ..^J7?JYJ7!!: ::^^:..  .    .!   : .  .. .:!B&7  ~: ...  .:.   \r\n~:::  ...  :^ .:^!?. ..^?JYJJ?77??!!~~7~..~^. .... ...:!Y5GG!  ..!P57^   .. ... ..  .    :. .7!. !~P@5..     ..:.  .^~^\r\n7::!??7??J5Y5PG5P#P.:::!YYJ?7777??7:.:^::~....^~:7G5JB#&&&J:.:.:.:5##BY~... .~:. ^^...   .   .:7!:  ^..   .... ..  .:~^\r\n!?557!~!?JJ?7^:... :!7...:^!777!~^^:7?YJ~J5GB######PGBBBP! .^..:. !&&&&#JG5^ ..  .~^.^?~^~^^~7?YY^!^:. .^~........:. ..\r\n^~7^~!~~~~!!~:^7^  .:: .   .^77^:.:JP7^  .~~:~JY55J~. ..   ^:?:~.  ~?Y5GG###BG5?~:^~.:^^:!7??777?YY?!^:.     ..  ...  .\r\n:~^7!.!5PJ:~5Y..?~..   .     ^!:..:Y7Y5^ :^. .~:     ...  .:~G::  . .  .JGGGBP5PGJ^7PJ~:.!7??77??J55^ . .??^.  .^. ....\r\n.:!7J.JP?^~~JB^ J7.. :.   . .:~~   ~Y&&B?~  !^.~?!:.:. ^~^!J~~?~.. .. .   .^. .~.   ~5G~:.:~!77!~^~!~:~.:BBGGY7~^::::. \r\n:^!7!~J7  ~Y5GJ.??   :.   .  .: .: :Y###&&7   ..^~7~!!J~^..:^::^?5^.~..7!~:~7. :..?P!?5^..^?!^:.    ^J~. ...~J5GGY?7???\r\n7:5: JBGJ~~JG~.?J.  ^^   ..  :^:...7#PPBBJ   ..  :~J7^.          ^P^~7~^~.. ..^Y5B&&Y^. .~^:.    .:  .  .^!^:^~~7?7!~7Y\r\n?:~!~^!!~!?J^.~?:^.     .  .^^  . :JB###&J   ..  ^~B:             .G7^  ..   7##&#BY^ .  ^^:  .     .^.7!.:??!~!!^~!!:?\r\n57~!777!~~^:!~.  .  ..    .:^~:  ^?&&#P5!.. ..^^^7!^5!           ^!Y~:  ..   7BBPP#J. ..^:  ..   ^~  .7J.:G5~~?GB5 .5:!\r\n???77YGG5J~...  ^?!     .:!?^..:JJ~PY:.:  7~:~77:.~::5?^.:^:..^^J7!~!!^..   ~#&###5^ :. ::  .   ..   !J:7G5Y!  !Y!^7!~:\r\n .:^:^^~7YGGGB~.~:~~~^^!77!~:.:^PP!   .~. .^:     .. ..^?!~?7^!~. :..!?!.:!. ~?B&&P~   ^~^. ..  .:  .!Y.:GY~!:!5Y.?7!:.\r\n.... .^:  .^?Y: : :Y5J???77?7!::~JP?:?PP55GGPPJ.   ..  :.P7.:  ...     .~:. :: :557Y^..:~^     .   ..~?..J5~:?PP?.^J:!:\r\n.  ...   ..    .::!?YY?777???7^:^::^~:~J5GB###GGYY7~  .~.J:^    .  ^7YYJ?~.^~:  :!55^:.^!7^.   . .:.  :7~:~7!~~~~~!^!~:\r\n:.  :....... ~~. .:^7~J5J7!~^~^~?~.:~.  .:.^5BJB&&&&? .^:.^: ^5GBBGP##&&&#BG5J~?5J?^:^^!777!^:...!7^ ...:^!7?J?!!!!YPJ!\r\n^~:.   . .....  ..^  :~?^.   .    ..^^  :^. ...~YB##P:.:.^..!&&&&#Y5BJ^~~::..^^:^:..!???77???YY7::^.J#GYGPP55Y??7??7^.!\r\n:~~.. .:..  .  ..?@B^!..~?.  :    .  .. .:: ..   :7YP7..  ^PGP5?^..:..... .:~:.^7~~!!??77??JYYJ~..  ??~:. :^  .:.. :::~\r\n   .:.  . . .!  ^&#?:: ..  . .   ~:     .  .:^~:: .!!7JYJ?7J~:. .... :~.. .:..    ....~?YY!?J~:::..       .... ....!!^^\r\n.:^........  .^7GGP7..^7~^:^~7~...   :^   .    77^~^.:^~^..~::7::^:..  ...   .   :.  ..:?!. ..  .^^. .... ...  ...:....\r\n:~..::^7^  .:YP!^G?~~!?!!7J7~^7!~7~  ..    .   .^~777???7!!~!!~.   ..      .!.   .  .7!..!~YB^:.  ....  . ..  .....^:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(".     ..  .:!^:.. .......  :.J@B^~  .  ...!  .^.    :.    !??777777??J7:  ^!.   ^7!^:~??Y?!:!?!~!JJ ?P?:. :77^:: :^....\r\n^....:^.....  .. .  .:...  .:!?^~~.:?~  ..   ::.       .^~~77??77????!:    :.   :..^!!~^^~~!7~:^YG5YJ!. ...:.....~:   .\r\n...:...:...  ... .....~^^.  .:. :J?:    .   ..    ..:..?~^~..^~!~~:^!~!!        :7.  ~.:...:: .^P#B: :: ..    :.... ...\r\n??7^^!!.... ....       ...:^^?YJJJ??!::^..:...^^. .::: ..:?!7?J??~:~:.~~::...    .   .   ^~. ^!J@&: ...   ...  ..:..:~:\r\nJY7~::....:. .^:..^!?J  ..~JYJ??777???!^~!~..^:   ^. .^!?5P!.:^^^75Y~.  :::. .. ..   ..  .^^^~..J~:.  .......  .~?^~:..\r\n^^~!.^?J77??555PGPYP#?.^::7YY???777??7:..^!~7^^!77J?5B#&&P~.: .. ~G#G5!. .:  :!~..~:.:...^!YY:::..  ::.::.  ......:.   \r\n::!7JPY!!!!???7~::... ^7! ...^!777!^^:^J55?:^5PGB#&&&&##Y..:...:. ?&&&#BJJ!:. .^..!~~!7?????JYY7^^:..^^ ......::  .:...\r\n~^::~!^!~^~~~!7~:~7:  .:. .   .^7!^.:^55~:   .^ .^~~~^..  ^^!?:!. .YG###&##BGY7?J7::.!???!7777JY?~..  ..     ....  ..:.\r\n..::!^J^.?PP7:~5Y..J~..   .     ^~:. ^J7PP: :. :.!~.     .:^&#.:     .:~^:.~^^  ?G5?.^~77?????J5?..: J#P7:. ^:  ... .7!\r\n:..~~7? ^##G?^^PP .Y~  .~.  .. .^~^   ~P&&BJ! .!::YBP?:~^^?^7!~^...:::~!.. .:  ..~P5::.^!!!~:....~~^.!Y75BGPJ7!!7^:..:^\r\n^~:!:^?::7J7^~Y5^ 7?^:  ^.  .  ..  :: ^5###&&~   ..:!Y~:!5!7~!P:~~?PG5!.^! .::J##~J:...~?^.   .  !^.  ...:!?55?!~7JY~.!\r\n~75P?~~!!!~~!!~^^~:.    .   .  :!~   ^5#&##BJ.   .  !7:J5^.^.:Y5:!?...    7G##&#G~.  ^7^.     .     :~~~~!!~~!!!!~?5P7~\r\n7.^YJ7~!?55?!:..:  .:!  .    :7!:...?~B#5^:: ~~.~YGPJ!~:5?~7~Y7:^Y!:..   :#&&##G~ .:  .:. .   :. .^7J..J5!^!J7^:7!:7:~^\r\n^^..:~7777JPGB5!?!.^~!:. .:^!!!~:::JG7..  :. ..!!^:^...^!~7^7~:~:7PB5:.!: ~JB&&B~.  .~^.  .  .!.  :Y^ YG~^7P##! !?^!..:\r\n~7: ...  :^..:7P#P ::.75J?????77^^.75PJ. ::~..^~:.     :.G@!.:     .~7.:  ^ :PG??~ .:~^.    .   .:^J: JP!:7PPY..Y^!^:..\r\n::...  ....    ..  ..^?YY?777!7??!..:!Y?!JGBB#&###GY. .!.7?^^  ..:^^^^. ^. . .^YP~:.:!?~.   .....  :!~:~7!~!~^~!~^!::^~\r\n:....  .:. .... :^...^^!YYJ?????7!^~!:.:: .^!JYG#&&&5 .:. .:. 7B##&&&#GPP5~.755Y~:^:~!77!^..  ~?^  ..::~!7??!!!!JPY7!::\r\n.  .:. ....  .::.::  ..::.J57~:..:.:!:.^!:  .: .!5B#B! .. :.^J&&#BGJY??7~^7!7~:.:7??777???JY?^:~.!BPJPGPPP5J?77??~.~~^^\r\n..:~^7~.  .......  .::?:.~^^::   .    . .. ..::  .^J57^:^:.~PPY?~.  ^   .:..^!~^!???777?7JYY!..  ?Y7~:.:^...::...::~7JJ\r\n^~:..::.  .:..   ....B@P~~ .~~   .   .    ...::^~..~^~?JJJ?!?^.. .::.  ^^:..::.^::!??JJJYJ^^:...  .    .:.. ....~7^^7JJ\r\n.:. . ..:.   .. :^ .P&G!. .:...:.~.  7^        ~7~!^:^~!~^..~^^?:.:...    .   .    .7Y~ .::...^^~.........   ..::..:...\r\n.   .~: .......  ^?Y5G5~:^!7~^^^^!!:..:    :   .:!????77??77!~~:        .^    .  ^?^.^!:!!:.  ...:.  ..... .....^::...^\r\n. ..^^ .:^!?^  .7PY.!5!!~?!^!7YJ?!:^!?^    ~^  .!???777777??7.    :.    ^:  ~. .  .  ~^P@G.:.  ...... ..:^~^.  ..     .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("..^!!!:  ^^.::!::J^.  .::.   ^: .@B?:. ^~~^^~7J~.   !J~ ~J!^?5J!~7JY: .~^^::. .^?~ P?:!~~~7!^!5.^PJ~^ .^~7^:. ^^^^:^^:.\r\n~:~:     ..  .:^::... . ....  .:^@&7~. ..  . ::.   :.    7JJ??????JJJJJ^ .7!.  .!!.^77!!!7~^7PY~5Y~   .~^::. ~^   .~~!^\r\n:^~^...:::...:.  .. .  :^:..:  .:^.:!^.~!. .:          :^~???77777???!.    :    ~?~^::^~!..^5G#J:.. .:. .....::.  . ^7.\r\n .....:::::...  ... .:...~!^....^~::J5!.        .. . .7!~~::~!777!~!!~~:   .     .   ... .~~B@?  ^:.  ..  ...   .^^^7~ \r\n??JJJ?^:!!.... ..:.    .   ..:^^!YYYJ???!^~^:!^ .~^^~.:..!^~!7!!~:.^::?!..  ..   ..  ~7:.~^!#5::   . ....  .^7::~::^!!^\r\nY77JJ7!:::..:^:..^:.:~?5Y  ..~Y5J7777!7??7^:~^..:.   .:~?5?^~7777?J?....~^~^...  ..  .^7J:. ..  ....::   ...:^~^:. ::. \r\n:..:^~~.~?J777?5PPGGP?5G7.~:^7YJ???777??7^.^~??7?7J5PG##BJ^.     ?GPY7.   .^.:?!~~~!7??JY??7::. .~!^^:. ....  ...  :.  \r\n.:^::!?YPJ!!!!??7!^::..  ^?!   .:!77!~:::~JP57. !JJ?PB#B^ .:. .:..G&&&#GY!~7~^::.~7??!77????~~^....  ...  ...  ....::::\r\n..:~^:.~~^!~~~!~!?!^~7^  ... .   .^?7:.:~PY^.  . :. .:.  :~:!^:~. ~JY?!?JJ::5P?~.~???777?7J5Y~.. .~~.   .:. .....^^::..\r\n..^~^..!.Y! ^55^:~PY .Y~^:         ^~:. :??GG^ :. ^.~Y!::..B@B :  .^:  :    .?PP^::^!7??7!!7?~.~.^&#G5!^:^....   ~!:^?J\r\n^::^~Y?J~^!!~!!~7?7^:~!::.     .. .^?^   ~G&&#57 .~::Y##B!^GG7^YPGP?.~. :..~?^JP~..^7!~^.    ~?~..^::JPGGPJ???7!^:^!!?Y\r\n.^:!^:Y57~~!??7~^::!^.  .. .:    .^^^: .~7&&BJJ^ :..:~7?P?   !PJ?7^..:.:??P#&J~. .::~:    ..  .   :~:.^~!?J7~~7YY^:7:^.\r\nJ?!!~:^77???JPGGP?:.:. ^7!    .:^!7~..^Y5^?7..:  !.7PGGP~!PG^~B#BY:.^. !5#&&#!.  :?^. ..     .:.~!:^!?7!!~~!!~^JJY!^::^\r\nJJ~:~~  .....:^^!5GB&!.~:^77!!7777!^.::5PJ.    :  .~.  ^ 5@&^.::!Y7.~  ^ :GBJ7^ .:~^.        :~~Y: ?G!::Y5~ ^5.!..^^^..\r\n.:::^^..... .:.   .~!. ..^J5J??777???~.~?P5:.?J?~7JJ~  ~^:7^~^  .:. .: .. .^JG!:.:!?~.   .. ..  :7~:!?!~!~~~!~^!.:^~:..\r\n::::....   ..  ...  . ..:~!7???77!???!.::^~7!!YG#&&&B..:. .:. .PBB5???7  !5PY!:::~!!7!:.   ~J^   .:.^~7??!!!!?PY?!::^:.\r\n  .:.  ..  ......:^^!~: .::7J?YJ??7!~!~!?:.^.   .!5GBY. .  .:7G##BGP5????J!^::7??777???JJ?~:~.~P575PGPPPJ7!7?J!.^~^:...\r\n .:: ..^~^:...   .:....  .. ..JJ^.   . ....:~^~....7Y?7777~^7PY!^.   .::.^~::!??7!7777J55!..  JPJ7^::^..:^::.:::!7??7!J\r\n^!!~::~:.7~.  .:.. ..  .:J#7:!.:!~  .:   ..  ..~?::^.:~!!77~~7..:.^~^!: :!^^~^!??7?JYY7^^^:.   .    .:.  ... ~!^:?JJJ??\r\n ^?~:~..  ...  ..   :^  ^@#7~: ...   .     .   :!~!!~!!77!~::~~~J. . ...       .!YY^:~^:...:~!...:.. ..   ..::::::.... \r\n.!~ .   ::.....  .. ...!#GP~. ~~:::^^?~    :.   .!???77777???!^^.         ..  ~!.^!: ::.  ::.:~:  .....  ....:::...^^^:\r\n:!~~.   :~..::^~.   :J57?G?^^77!!!!^:~!.  .~7: :?JJJJ?77???JJ?.   .:    .: .  .: .!!#@!:.  .... . ....:^^.  ..     .~:~\r\n.:^^::^^^. :^7!^: :~?P! Y?~~7!~~7^7G.:J~.  ::^^!:.:YJ7~!J5J~!J! ^?!.  .:??~~^^^^ .:!G@^ .^    ::.. .:?^.!::.^^  .~!!^:.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("..:...::::^^!!!::^:.^:.. . .. ..:~ .BBPJ. !7^::J~.  :^J!~. ....   :.  .~YG&BJJ?!^^7~7JJ?^^57:5?^~^:.^J7^: .^~~~^^^.....\r\n:...:^~!~. .^^.::!..!!.. ....    :. G@5:^ .:..^:   ~7^.~7:.~Y7~^^~!7.  :~7!:. .:~!.JY?!~!J5.7PJ.. .!!^:: :^.   ^~~:...~\r\n^:^~^~.     ..  .:^:...:. ......  ::P#7!^ :!:   . ...  .?JJJJJ?77?YY?7J!.:7~.  :?^:~7:.:YPGP7^   ........~:.  ..:?:...J\r\n.  :^^^...:::....  ... . .~77^:^.  ..  ^?^.:   :  .   ..~???7777777??7:   .:   .. ... ^:5&B. :~...    ...    :^.~7.. ~?\r\n:.  ....::::::..  ...  .:. .!!^  .::7?~?YJ!. ..      !!~~~~!7?7777777~^.   . ..  ~?^ :!7&&^..     .:.  .:~:.:^:^7!:....\r\n7????JYY?:^!~ ...  .^.    .   .:^^^~?JJ?77??7!~~!!...~..~::~~~!~^:.^~^?!      .   :^7^. ::..  ..... ....^7:.~^::~!^:^:.\r\n7JYY!7??7!:::::^~:..^^:~7YGJ ...!55J7777!!??7^.:^::~..^!Y?!?JJJYJ77!..::..7!^^^:^!7J5!^!::. .~^~!!^  .....:~.   :.  :~~\r\n .:...:^~^:7J?7!7JPPPPPY7YP^.~:~?J????777??7~:!7YY!?YPBB5~    . .JG5?::~:.^^:~7?J777?JY?:::  :!~.......:.  ... :^..   .\r\n  ..:^::!?Y5?!!!!?7!~^.:.   ^J^   .:!7!!~:::7YPY~  .~!::. :.  .: ^YPGP!~55!:.^???!!7777JJ7~:.     ..   ..  .......:..:^\r\n  .:^:^^777!.^7777?J?~:~7^  .. ..   .^?!:.:!G?^.  .  :  ~~.^7..^:  :..  :YGY~:~!7?77???YP7... ?P?^.  ^:  ....:!~^^^::..\r\n^^  :.:!^YPJ!!!!7!~!~^^!~..    :.     :::. ~!Y#B: ^ .~:JG5G&&P757..  ..  .?GY::.^!!7!^::^^^~^.?GYGG5J!~^~~:. .^::7YYJ??\r\nJY7!!7~7.:?J?!!?5PY?~...  .^J      .:77:..^Y~5BJ... !7:P@@@&@@@B^~? ...7GP~Y~..:!?^..     J~:  ...~J5PP?!!?J?^.!!!7!7JJ\r\nJ?JY5?::^. .:~~~~!J5GGYPY.^~^^:::^~!7!~.:.?GJ.  ..  ..!5?P&&B5B5:~. ^ .G#P~! .:.:.     :     .^~~^~!~!7!!!!?P5~~^.^. ^~\r\n..::^~^~7:....  :^  .^?PY ...!5Y???77?7!~:~JG5^  ..^  :~:.7~.~!. .  .. .^7P?:.:~?~.   .. ..  :7!.^?J?7777~.~?!7^^:^^.  \r\n^:..:.......  ...   .     .:^7JJ?777!!7??~.:!Y5~~5GPY^ ..   : ..:~~.  ^?P5J::.^!!!!^.   :J~.  .:.:~~7?!!!!75Y?!::^^..  \r\n:   ..::. ..  .:.......^!:  :::7JJ?777??7~:^^::!::?5G5.      :YBBG5?~J5?7:^!7?777??????!:~::YY!JPPPPPJ7!!?J?^^~^:..... \r\n~~:   ..  .^:.. ..  ^!7!^~: .::!~!5Y?7~^^^^~7:.::..!?7?JJ?J?!75?^..~::^:.:7??7!7777?557... 7G5J!^^^::^~^:::::!77?7!JYJ7\r\n.^^:^!~:::~.:7~:...  ....  ...: .:7~:          ^J^^^..^~!!~~::!..^:..~7~~!!??77?JJ?!~~^:.   .    .^.  ... :7^:7YYJJ????\r\n....:~7~.^:.:~:.  .:..    ..:#@?~^ :7!  .. .   .^~7777777?7!^^~~!7.     ....!?YJ!??^::  :~!. .:.. ...  ..:::::::.... .:\r\n?! . ~!::^.    .:    ...^^  P&P:^  ..  .   :.   .7???777777???!::   .  :.  ..^?~  ..  .^:^77~. .....  .:..:::...:^::  .\r\nJ^...?^..  .:^........   :!5BG5^.:!!^:?^  .~7^ ~J7?YYJ????JJJJJ.   ..  .  :!^ :!!GG::  ......  ::..::^.  ..     .~^~~::\r\n!...:~~~.  .^^ .:^!7. ..75J.Y5!~~7JJ:~7:.  :~!~^  .77!^^~7Y7.:7!.:7~.  .^.... ^:J@&  :.   ....  .~7..~::.^^. .~!~~:...:\r\n.....:^^~~~^. .:!J~.::~^75:^5~:7JJ?~7~:~7??P&B5!.  .:.  ....  ^~?^:  .^?^.^77 .?PG#: ^~.. ...  ..:^::~:.~!!~^::::...:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("....!???7!~:.....!7^^^.   ..: .  ..   755PP^^J7.^?Y5#G!~:.  ..^?Y?: ..   ....~YP57~~?YJ5757 !77:~YY7:. .:^~:^:::::..:..\r\n..:..:...:::::^!!~:.^:.:~:. ....  ..7  7&PY^ .?~. ..!BPJ:.  .:....^.  :^7?Y5GG5Y7!J?7!P::55~:  ~!!^:. ^^::.^^^....:~!. \r\n^^:::..:^~!~.  :^..:!::~!:.  .... .  ..~@&~~. ..  :~^.~~. :?!^:.::^^.  ~?P5^....^7~:7PPJYJ^   .::... ~^.   ^^7~.. 7YJ?7\r\n..^^.^~^~.   . :.  .::.. .^. ..:.... .:~Y~~!.:7!  :^. .JJ?JYJ?7!7J5Y~^!!.^~:   :^ ..YG&J..:  :.  ....... ....?...:JJYYJ\r\n  ..  .:::....::....  .:... .~?J?~^:. .:. .?J:.      ..~???7777777??J?~  .~: :^:  !~B@J  ..   ...  ......^^^7!.  ^!?JYY\r\n  ::....:::::::::..  ...  .:.  ~~:. .::!YJJYJ?!:.:..^!~~!!7??777????7^.      .~:^^~.JY::   ....... .:?^ :~:.~!~^.. .^!7\r\n!7??J?JJYYY?::!^  ..  .^.    ..  .:~~~~7???777??!~~!7:.~:.^^~7!~~::~~~?~......^?5~....  .:.:^^:. :^:.~~^^:..:^^.:~~^:. \r\n7~!7JYJ~!?7!!:::^^~~^::~~^7JPBJ ...!55J7777!!???^..:~~^??7JYJYJJ?~~~ .~!~~!7????JYYJ^::  ^7J?!~. ....  :.   :   .::!^:.\r\n^:  ....:::~^:?J7!~7JPPPP5J~?Y::~:~??77???7777!~^7Y5Y^^Y7  ...:.^YY??7^:.^7??!7777?7~^^:...:  .... .:.  :...^::. .:~^~^\r\n^.  .  :^.~~?GGYJJ77J7!!^.::   ^J^   .:~!!!^.:.?55?:   .^^. . .:.~. !PP?:~7??777777J5Y~..  .:    .....  ..:::........  \r\n~77?Y?::~^!^.757~~!?Y?!~:.^.  .^^      .~Y!..:7G7~. ... .::~^..:.    :YPY:::~77???7?JJ^.^ ~&#57:.:^. . .  !!:~77!~^: ..\r\n7JJJ??JYJ!~^::^~7???YPGGP!:~:.^!!    .^~!!^..:5P:^:..!  :!B&#?:. ~:..^:5P^..^!!~~:.   ~!~.:!^!PGGPY?7?7~^.:^^!J5Y??JJ?7\r\n:..:^!!7?~:~!  . . .::.:75B&? ^.^JJ777??77~:::YP5^     :..^!::.. :. .~!PJ:..~Y!:      :~.  .^.:~!?YJ7~~7Y?.:7^~::7Y??7!\r\n  ........:::.........    ::  ..^J5Y?77777??7~:?PP7 .~::: . .^^.   .!55Y::.^!!!~:.   .J^.  .^.^~!7?77JJJPGY^~.^^  ..  ^\r\n:~^~:. .:::...:.  :.  ...  ....:^^~777777!???^.::7J?JY^.....  ~Y^:J55?^~!77777??7777~:~^.??^7Y5PPPJ7~!7JJ^^!^::. ..  .^\r\n.::!:..   :.  .:  .... .^!7J7~  .::?YYJ????7!!~!!. ^~~7JYYJYJ??J~~!^..:7??!!7777?557... 7BGY?!~~^^~!~^^^::!!77!~?Y?7~~!\r\n .:^~~: :^^..:^^~^..^: .:^^:.^.  ..:.^5J~:.....^J!~~::^~!7~^^..~..!!~^!???77???7!~~~:.  ..    .^.  ..  :!^.7YYYJJ?J??77\r\n7~^. ..^~!~:.~^ :?^.  .......  .:7J.^~^:~.      .^77???777??7!!~~!~..^::!??JJJY7::.  :^~  ...  ...  ..::^^:^::::...::  \r\nYYJ?!^. .~7~:^......  ...   ... !@&7!. :~: .~.  :?J??7777777???!..       :?J: .:. ..^~?J?!. ...:.  .:..::....:::.  ..  \r\nJYYJJ~ ..7: :.  .....    .. ^. !#B5:. ^:.  :~^.~7~~Y5J7777JYJ?JJ: .::  ~?:.~~^?!:.  ...:::..^: ..::.  .:..   .~^~~.:~. \r\n7?JYJ...^7^^.  .:~....::.   :7YJPG?:^7~....:J5?~  .^~^:.:^!J^ .~~.:!^   .  ~^B@?..  . ..... .:~!:.~:. ::. .^!^~:..::::^\r\n..!!^....^^^...:^..:^!!!. :^Y5^.57!?J7!J5PGPPJJ~:   :....:.  ..?5G7.. .^?: :JP&Y  7.   .... ..!^.:~::~!!~:::::...:..:..\r\n..:...::::^^~~^.  :!JY~:!!7.~5!YYJJ!~!YP57....   .. :7YJ^..  .:~!G&YJ?^.!J~:PP5P7.  .:    :..   .:^:77:.....^!!7??!:...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(".   .  ^?JYYYJ?7!:. .?~.:.  ..........  .Y57:5?JPP! .~.   .:. .!7^ .....  .:   .:~JJ~!^ ^!?77YYY!.   ...^^.:^^......   \r\n  ....:!??7!!^.....:~!^:^:..  .:.   .: . .7BPGY?5PBG!.:.  ...:JP5?. ::   .:: .!YY7~..Y5~~:.:^7!^: .^^~^^^^.....:~.    .\r\n::..::......:::::~!!~..^:.:7~.  ....   ^^  &#J^:.::J&BY^:  .:.^7^:^.  ..^^~?PGGPY5P~?5?.   ^~::: :~.   :~~~.. ^J?7~:...\r\n~~^^::::..:~^~^. .:: .:~.^7~:^.   ....  .::&@J~:  ::^~^  .!^:.....:.. .!5BB7~^^^JPBG~..  ..  ....::.   ..7^ ..?YYYJ?7~~\r\n..  .~:.~~~~.   ..:.  .:... :: .~~~^..:  ..^..!^.^7: :J?!?5Y7!~~!?YJ:.^~:^:.  ^:Y&#. .~.  ..  ...   .:~:~7. .:??JJJJ?7!\r\n     ..  .:::....::..:.  .:... .~J55J!: ..:~:.757:    !???777???7?JJJJ7. :?^.:!:G&!:.  . ...:. ..!~.:^:.~7:...:^7JYYY?7\r\n..   ::..:::::^:^^^:..  ...  ...  ~^:....:~JYYJ???!^^~~77??77!777????~.   .~J~.  .   ....... .:^:7?: ~^::~!~^:...::~77!\r\n~!777?JJJJJY5Y7.^!.   .  .^.    :.  .:~!!!77777!7??7^:^:.^~!777!!~^!!~~~!7??YY7?~:: .~!?YYJ7. ::..:^~:. .:.  :!!~:. ...\r\nJ^~!^^!?Y7~~7!7!::^~~!!~^^~!!J5B#7 ...?55?77777!7??~.:^!7?J?JJ?7~:.:::7??7777?J?^..: .~7!::.....:.  ..  ::.    .!:^::::\r\nJ^~^~:~7J. .~~~ .JJ!::7YGGP5Y7^77.^~:~7777??77777~~~?55J::^::^!~?PY!:^???!!77777?7!~:.     ..   ..  .....:.:..:~~^:.^~.\r\n^7??JJJ?????7!7::!??7!?5GGPJ~... .~Y:    :~!!~:.::Y55~   .    .  ~5G?~~!7?777???YP7... !?~.   ^:  ....:~^^::...    ... \r\n  .:^^~7?JJY?::~. ..::::^!?5GPBG.:~:~!^^~!77!~...7G5~  .  :~^ .   ^5P?.:.~!77!!~~!!:^^.5#GG57~^::::.. .~::7YJ??7~:^:.  \r\n  ..    ...::^^~^..... .^.  .~J? ...!55???777?7!~~7P5~       .   ^J55^..:~!!~:.   .Y!. ...^?PGGP?77??7^:!!7?????JYJ??!^\r\n.~~..^~~^..:.......  ...  ..     .:^!7??7777!!7??^:!YPJ~~^.:::.75PY!!~!7777??7!!7~:~^.~7^~JYPGGY?:.~JY: ^~~. .??~:~^~~?\r\n::::^:~:    .::  ..  .:.....::~7~. .:.^7??7777??7^.:.:~7?JJJJJ?7~^.^??7!77777?Y5J:.: ~BBPY?!!~~~77!!~^:~7!7~^!Y?!^^~~:?\r\n... .:~!!^  .:. ..~^:. .:  !JYY?7!. .:^??JY???7!~~~!^^~!!77!~^..^:^7??7!77777!!!!^:. .:.    ^:  .   .!^.!Y5YJJJJJJ??77!\r\n~77~::...:^^!~:::!..77:^^. ..:....   .. .^Y!:   .^7???777!77??77!~~^!???JYYJ!:.:...:~  ...   ... ...:^^^^^^^^:..^:.  ..\r\n7?JYYJ7^:...:!~..^:.^7:. ..... .  .:^BB^!^.:?^  !JJJ??77??777???!.   .75J:^~^:...!?Y5J~. ...::  .:...:....::..  ...    \r\n!7?JJJJ??^. .7!^^^.   ...  ..  .^.  G@P^~  .:^:~~:.JYJ!~~!7J5J7?Y^ .!~.^!. ::.  :..^~!~: ::  ..:.   :..    ~~~~.:~.   .\r\n!~7?JYYYJ:..:?...  .::....  .:  ..^P#PY:^^^~G#57. ..::....:^!:  ^^^:^. .!7&&^:.  ....   .^:^7~.~^. .:.  :~^~::.::::^^~~\r\n...:~7?J! ..~!~^   .^^ :::~^   .75J~5PYPPGGY7~~::   ^::!^.:.  .:JG&Y:: ::?B@. :^   .:..  .^?:..^:.^~!~:::^:......::..:^\r\n..   .~:.....^^^^^^^: .:!7^^..^~Y5..~7Y5?: ::.   .: .?5PJ^... ..^.!GBP5?JGPB?. . ..    :......^::!~::....:~!!7?7:..... \r\n   ......^^:.:^.:..  .~JYY7!?!~ :7~7Y!^.   :..  .... :77: .::   .~. ~PPY?P~!55.  .:......... .^.^?: .:!7?JYYYJ?!  .    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  .:  ..  :777???JJJ?...:7...  .:~..::^!:  .?5J!.  .... .:..  :^^^.  .. .   .::^7. ~7?7?YY75Y^      !~..^~^....... .. .\r\n....   .  ~?JYYYJ?7!^. .!7:^:. ....... ..   ^55PY:  !.   ...  :~^. .....  ....  ..7?~~~::?J!:. .^~~^:^:.:...:. .   ....\r\n.  ......:!?7!~~:....::^~:.^:.:.....    ...^ .PBPBY: :   .: .75G57  ::   .^:  ^?Y5P~.  ^7~::. ^^.  :~~^...:!?~.. .:.  .\r\n:.^^:..::......^^^::~!~^.:^..:!7.. ....    :. ?@P~Y&BY~:   ::~YY7~: . . ...~J5PBY!:  ....... ^^.   .:!!...!YJJJ?~::^!J5\r\n~.:^~^^::::.::~:~:   :: .:~:^?~:~^.   ....  ::J&Y~~!!~. .:::. ^. .:.  :?P##JJB&?  ~. ..   .:.  . .:..7: ..?JJJJ?77777?7\r\n....   .~:.^~~~.   ..:.  ....  .: :7JJ7~::.  ..  :7^^?!^!5J!~^:^~7?!. .^^!!^G@5...    ..:.  .^:.::^:!7...:~7?JYJJ?7!  .\r\n ..     ..  ...:....::..:.  ::... .^755Y?^ .::!?~75J7?JJJ????????JYY???~~~^ .!..   .... ....:77. ^^..~!^:...:!?JYJ?:  .\r\n~....  .:^::^^^^^^^^~^... ....  ...  ^:..::.:^?JJJ?7??????7!777777????7?5J:~::.  ^^^!7!~: ^!::7!::^..^~~.^^^:...:~^:...\r\n  ^7??77?JJJJ?Y5Y!.:~.   .  .^.   .^.  .:!!77777777!??7~^!777777777???77?JYJ~::..^?Y55J7: ... ..::   :   .^^!^:....::..\r\n .^7Y5?!7??JJJ???77~~~!!7?7!!77?J5B#! :..?5Y?7777777??!:~7!?77!~::7??!!77777~:.^:..:^...... ::  .:...^:.   .~^~^::::^^~\r\n.... .^!7?JJ?JYY!:^:.:^~7???YGB#P?5?:~~~?J?????777!!~!!J5J7~!J55!^7??7!77777JYJ~::   .     ....  ...:.....::::. .~:   .\r\n      ..  .:^^~!~^~7. ...  :: .^?P#? :.:?Y?7????77~^:75G7     !PP?:^~777???7?YJ:.: ~#G?^. :^  ... .!!^~!~^::.  ..      \r\n.   .^. .::::.....::..  .....    ..  ..~?YY?777777??7~!55?!^!?5Y7!^~!777????7J?~^!:!P?P#BPY?777~::.:^:~Y5J?JJ?7!^. ....\r\n~^^.::^^~^!.   .:^...:.  ::...... ::..:^::~77777!!??7::^!7??77!:!??7777777?Y5J:.:.^B#PYJ?777?J?77!~~!7???JJJ??7!?YY7~. \r\n..:::...::!^^.   .   .:.  ... .!?Y5Y?~..::^JYJ?77???7!7777777!^^7??!!77777777!^.. .^..   ^:  ..   ~:.~J5YJ?JJJ?77??7~  \r\n...::~:...:^~^.^~^..^^:~7::~^ :~7?7~^~. .::~:?5J7????777777!7??????77?JJ?~:.::..:^  ...   ... ...:~~^~~~~~^::^^.  ....^\r\n.. .?JYJ7!:...:^!!:.^^ .7?:...  .....  ..~. :^!~?J?JYJ?????????JJ?7JY?~?7::. :7J55?^. ...::  .:...:..:.....  ...    .. \r\n.  ~7?JJYJ?7~:...!7::^:.:^.. .:..     ..?@#~!!^^:  ~J7!^:^~!J5?^!J~^7^  ..  .^:^?JJ?^ ..  .....  :...  .~~~~..~.   ....\r\n!777777?JJJJ?:  .?:.^:    .:.    . .!. ~&#Y?B#GJ:   :...^..::^.  ^~~^!?#5::  ....   .:~:^7~:~^. .:.  :^:~:::::::^^^^:.:\r\n5Y7~::~?JYYY7...~7:.   .^^ .......  .~?BGPY!:.:..   :~!JY~::.  :^YG&P^5@P .:.   .... ..!7^..^:.^~!~::^^^:.....::..:^~::\r\n..  :. ..^77^ ..^~~:   :~..::~7~  .:555J!. .~.   .:. !YGPJ: ..   : :YBGBG. ^:..  . ....::.:~::~~^:.....^~~!7!:....... .\r\n. ..   . .^...:.:^^^~~^:  :~J?::^^~7?:.  ..... ..... .^~:. ...   .~. .YP55!   :. .......  :^:!7. .:~77JYYYJ?!  ..  ....\r\n. .. .......:~~..^7      :J5?JY?777!  !^.:.   . ..  .^^^:  ..:. ....  .!J5J.  .!^::. ~:.  .. 7^ ..7JJJJ???77^  ..  :: .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" :.  .. .:^!?J?7!!7?YYYJ7...!!^^   .^: ::~7^.  ^^::... : ..:!~:!^^.~!.. ...:...:^~7Y5J~?P?. ..  ^!. ^~~^::. .......  :.\r\n..   ..  ..  ^77?7??JJJ?^ ..7: .  .:^: .:.^^      ..   .... .:~:^~:.... .. ..::~?:.^^?YJ!.  .:^:^^:.::......    :..   .\r\n......    .  !?JYYYJ7!!^...~?~:^.    .: .  ..     .~.   ...  .^::.  ..:.    ..  .  :~!~:: .^::.:^^:....^!^    :.    . .\r\n^... .......:!7!~^^.....:^^^..^^.:~:.  ...  ..!.   ..   .: .!JPPJ~ .::   .^:       .^:.:..~:   .~~7:..:YJJ7!^...:~7??!~\r\n.:!::~^:..::.....:^~^::~!~^.^^ .~!7::  .... .  ..:&5?^:  .:^75GPJ!. .   ....  :. ..  . :....  .. !~ . 7JYYY?7!!7J5PGPY7\r\n~^?^.:^^^::::::::~:^.   :. .^~:~!^^:::........  :^5?!. ...:..!7:..:   ^75PP. .:.   ... ......:~:!?:...??????7777!^::.. \r\n:::...    .~..^~~~.  ..::  .....  .. ~YPPPJ!^:. .:.  :.^Y?~^::::^~!^  .:!G!:.  .......  .!7..^^.:~^...:^!?YYYJ?7. .:.  \r\n~.  ..    ...   .......:....   ::... .^7Y5Y?7..::~YJ?YJJJJ??7!77?Y5J!~.....  ...:^:...:^:^??  !:.:!!~:.. :^~7??!. .    \r\n  ^~....  .^^:^~~~~~~^~!:... ...   ...  :...:^:.^7???77777777777777?JYYY!::. ^?YPGG5?: ::..^~^:...^: .^!~^.  .:.:......\r\n  !^.::..^?Y5P5?7J5J^ .^  ...  :~. ..:^. .:^7777777777!7??77!777?7!777?7~..^:^^7J?~^: ..... ...  ..   ..:~::...:^:::^~:\r\n.. .  .  .::.:~77?J?^:~: . .   .  .!P#&^ . .J5J?77777777?!!!!!7?7!!7777777~~^.. .   ... ...  ....::::..:^~^^.^^..:^^:.:\r\n....    ..    ......:^^:..... .^.  .:~^ ...~55?777777??7!:?7?^!7??777777?Y57... :~:.  .:. .....:^^:......    ..    ....\r\n^.::::..^~.:^~~:..::::....  ... ...   . ..^~~7777777!!7?7!!!!!?777777777J5Y: . .&&G7.  ..  . . .!^:7??7!~:..:.       ..\r\n:~^^::^::..::~^..   .:  ... ..... .:^7J7^:^^..^7?777!7??77!77??7!!777777??7~:. .~^... ^^  ..   :. :?5J775P5Y?~...:.:!. \r\n .....:...  .^~!^. :^. .:^~^:.:: .?5GGG5J~..::!YYYJ?77777777777777???7^::::...:.  ..   ... ...:!~^~!~!!~^^~^: .....^~  \r\n    .  ~7?7~^: .::~!!:.:!  7J^:^:..::^:..:   ....~!J5Y?77!7???JJJYJJY!::..!?JYY7^......:.  ............   ...     .. .~\r\n.  :.  !?JYYY?!^:...^~:.:^..!7:. .......  .:^P!:.  :7~^::::^~?5!.^. .:. ..^!JPGPY! ..  .....  .:..  .^!~~..~:    ....::\r\n ..:::~7777??????:...7!^^:......  ...  .:.  YBP?^.  :. .!!..:... .~!Y~:. ....:...:::^:~!:~^.  :.  .^.~^:::::::^^^:.:?^~\r\n!J5PP5Y?7!7?JYYJ?.. ^7.... ....:..  .. .^   . .   ...~?5G57^:.  :^?5&~..  . ....  ::!!!. :^.:^!!::^~^^.....:::.:^~^:!^.\r\n~7?J?!^:..^!7JJY~ ..!!^:   .~: :.::..      .~.   .:. ^JPGY7. .:   ...  .7.   ...  .:!:.:^..^^^^.....^^^~!!^.......  ..^\r\n. .    .:.  .:7^:...:^^:.::^: .:~!!^  .  ..    .:..  .::^:  ...   .~.     ..  . :..   .^^^7!...:~!7?YYYY?7. .    ......\r\n.   ..:.   ......::::^^:^:.  .~?YJ^^..?!::.. .. ....:~^:^:. ....   ..      :^.....^:.  ...?:  .??JJ????77~  .:  .:.  ..\r\n.:. ....... .:::~~^ .~~  ..  !PY~?55?!^:...:... ..!~.^~!^^!:.. :. ..:::^. .^7!:: .~.   ^^~7...!JYYY?7!!7???!^:   .   ^ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(":^:.  ^~.. ~JPBBG5?!^^!???JY^ .:^~^:..:^^ .:7J7~:...::..  ..^^..:.:^::^:     .^^.  ..:. ::. .:. :^~~^~:  ...........:~!\r\n:.. :.  ..  .^!7??7!~!?JYYJ?...^7:^.   :~ .::7?7^:....:. .:!~.^:^:.~^.  .::::....:!JJ~.  ...^~:.^~^......   ...  ..  .^\r\n:~... . :.  :.  ^77????????~ ..!!.:.  :::.....:. :. . .... .:~~^!~:^:.. :. ..::!?7?~:. :^~~^^^:.....^: .  ...     .~: :\r\nBP:......    . .!?YYYY?7!~:...^7~:^:..  .:.    : .:.. ....  .:. ::.  ...    .:.:!~::. ^^   .~~~:...?J7~:. .. .:^^::.   \r\n?!:^..  .......:!!~^^:....:^^^:..^:..!!.. ....   :!:   .:. :7J5J!. ....  .:. ... .....^:   ..^7...~JYYYJ7~^!?5PGGPY!.. \r\n .^.:!::~^:::::.....^~~^:.~!^:.^^..~?~::.  .....   ^:.  ..:?5B#GY! .:.  .:!: ...   :.    .^^:7^ ..7?JJJ?!~!7?JYYJ7~. ..\r\n?7!~^7:.:^^^::::::::~.:.   :. .:~^~~:^:.:^^^^^..:  ...   :..7YJ^.::  .:::   . ..:.  .^!.:^^.^!:...~?7?JJJJ?7!....   .. \r\nJ?^::....    .~. ^~!~.  .:::  ... .  .. ~YPBBGY!: ..:^~?!^:.:!:..:^.....  .....   .:.~?~ .~..:~~:....~7JYYJ?:  ..  :. .\r\n  .^.  ..    ...   ............   :......:!YJJ?7~^.:^JYYY?7!~^~!7J5J!::. :!!?YYJ7^..^:^J~.:~:.^!~:^^:...:~7~:...   ....\r\n. ::   ....  .:. :~!!!!!~!!:... ....   ..  :...:^^.^!777777?????????!..~:!JPGGG5?: ... .:~:.  :.  .~~!^. ...::..... ...\r\n7^:::..      ..   ..:^~~~!7:.... .~!....:^  ..~???7777777!!!!!!7?777!^.:^:.:~!.......::  .:. .^..   .~:^^::::^^~~~~^~^:\r\n!~~7.....  .~: .^^^:..........  ..    . ..  ::~?JJ?7777!!!!!!!!!7777?JJ?!::   . ..   ...  .......:.:^^^: .~:  .:.. !!~!\r\n::~~^~~~^^:::::~:!.   ..^: .:.  ::.......~~:..^^.^!77777!!!!!!7777777?JJ!..  ^:....~~. .....!!~~^^:..   ..      ..::::7\r\n... .:...::... .:!~~:   :   .^:. ... .7YPGGPJ!^~..~?????7???777777!^::^:....  ...  .... ...:7!~!7!7!~:....  ....   :^ .\r\n....   ...:^!~:...:^^:^!^.:^^.^J~.^: ^7J55J7!^  ::~J5Y?!!~~!7?JYYJ~:.^~77?JJ!:......:.  ............   ...     .   ^.  \r\n. .:  ... .7?YYJ7~....^^!:..~. ~?~.::.  ......  ....^^:..~:.:^!?~~:.. :!YGBBGY! ..  . .... .::.. .^!~^..~:    ....:::7?\r\n ..   ... ~7?JJJJ?77~...:!~.:^:.~~.  .:..  .  :::.  .^.:?Y7..:.  .:.  :..^~~~^:..^:^~^~^.  :   .:.^^:^^::::^^^:..7^~!7?\r\n... ^7?JJJ?77~!7?JJ??.. :?^:~.    ..   . . :!:.   :. ~JPBB5?^..  .:^.  ....   .^:~7!:.:~.:^!~..^!~^:. ..::::^^~^:!^.^. \r\n . ~YPGBG5J!~~7JYYYY!...!!..   :::.... ... .:.  .... .!J5Y?^. :.   :!^   ....  .~7:.:^..:^~^:....:::^!!^.......  ..^:^7\r\n   .::^~^. ....:~7J?:..:~~~.   :~..::^!: ..    .... ..:..:.  ....  .:. :.   .:.  ..:^:^!~...:^~!7JYYYJ7. .    .....::Y#\r\n^ .!.      ..    :~.....:^^^^~^:  :^???7^:.. .: ...::~!^^~^. ....    :  :.....::.  .:.~7.  ^?????????7~  .:  .:.. ...~~\r\n^.  ..  ..:.  ......:~^..~^...  .^?J7^....::::.  .^!:.:^^:^!:.  :....:^!?7::: ~^   .^:7~...?JYYJ?7~!7??7~^.   .   ^ ...\r\n!^:...........  :~^~~^^  :.  .:. ::.  .^^.. .  .:::^:.::.^^..  .:::...:~7J?:. :~:..:^~^:..:YJJJ?7~^!?YGBBPJ! ..~~  .:^:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("PG!:~!!~::  . !J5PP5J!:  ..:^~?~.....^^^~!^.    ^~.      :~!!^::.:::^~^::^7^:.^~!:  ...     .:^^~~^..  .:...:...^75GGBG\r\n#&Y:::.  ^^.. !JPBBBPY7!~7?JJJY7 ..~~~^  .:~. :...:^:.. .:.:^::::::~^^~.  .   ~~^.      .!: :~~:.... .. ...  .:  .:^^~!\r\n:~7:.. ^   .   .:~!??7!^^7?JJJJ:...?:..   .~. ::::...:.  .~^.::!:.:~:.  ..::::....  :^~~^^:.::...: .    ....  .:: :~?~.\r\n   ~~... ..:.  :.  !7???????7!~.. ~?:::. ....... . . . ...:^~!~~!~:~^.. :.....::: .^.. .^^^:...~7!:.  ..  .....:.  :!!^\r\n..!#J::.....    . .7JYYYJ7~~^....:~^.^^..:.... .  .. .:..  .^.  ^:. ... .   ......~:.  .:^?:...JYJJ?!^.:~7Y555?!:   .^7\r\n.:!!^:^.. ........:~~^:::....:^~^:..~^.:~?:. ...:     .:. .~7??!^. ..... .     :.. .  ::.~!.. ~?JYJ?7~!?JPBBBG5?: ....^\r\n:.. .^.^7:^~^^::::.. .:^~!^..~~^:.~:.^?7^:::.   ....  ...:?5B##GY~ .:.     .:.  ..^..:^:~7^...^!7??7!~!777!~~^:. ..::  \r\n?JJ?7!~^7...^::.:::^^:^^...   :  .^~^~^:^. :!7JJ7~:::   :.:?5G57^^.    ....  ...:^?^ :7..:~:...:~7JYYYJ?7. .:   ..   ^ \r\nJ777!:::....    :^. ^~!^. ..::. ...  .. .  !YGB##GJ~ .::::.:??^..:.  .^:^!!~^..:.:^J7..~..:!!^:...^~7JJ?!  ..  .:......\r\nYJ7!:.::..       ..    ...:..:....  .:......:!J?777J7..:7!~:.:^~~:::.^JPB##BPJ: :^.^!^:^...^^..^~^:. .^:::... .  . .::7\r\n7???!^^:...    ::  .........:::..  ..    ..   ....:^::^~7??77??7~: ^Y!!7Y5Y?!: ..... .:.  ..   .:^~::...:::.:^^. :.:::7\r\n .:^:^?~::^^^:.:^:^^~~....:::...:  .:. .... .:. .:::~!77777777777!~:::. .:. .... .:.  ....:::.  .^~^~:^:.:^^^^:^?~:^:. \r\n7:::.^..^^::::::...:~~:.   .:  .:.  .... .~7JYJ7~~J~ .~7??77???!^::^:....    .     .  ...::.....::..  ::    ....~^!7?77\r\nJ::: .  .....::::. .:^!^..^^:..^^^!^.:^ .?5B##BPY~.:::~~^^.:~!7^..!J7!!7?!.......:.  ....:......    ..       ..::.:!?JY\r\n..... ..   .  ~?JJ7~^. .:^!!^..!..!Y~:....^!!7~:^:  .:..:77^..:::. ^JPB##G57  . ... .....^:....^~~^. ^:    .....::~!!7J\r\n :.  ...  :.  !?JYYYJ7~^....^:. !^ :?~:...  ....    .^^!YP5?:.:.  .::~?JJ?7^ .^::^^~^.  ..   ..:~:^^:::.::::..!^~!7JJJJ\r\n  ::.. ..:^~~!777~!7??77~...:7~:^:..^:.  .:..    .:. ^JPB#BPJ^...  ....   .::.^!?~..~:::~~..^!!~:. ..::::^^~~:7~.^:..::\r\n^......7YGBBBPY?7~!?JJJ?7 . ~!.::. .  .:   . .  ....  ^!JJ?~: .:.     .... .:7!:.^~...^~~^::..::::^~::....... ..^::~~:.\r\n7~.   .!J5P55?!^:^!?JJYY^...?~:.   :~:......  ..... .:^. .:.  ..:. ..  . ....::.:^.:~^....:~~!?JYYJ?^ .    .....::7&?..\r\n^!~^  .:.....  .:  .:!?!...:^~~.  .^: ::::....:  .:~:~!~^!~^:. . .     ....... .:^:7!...^!7?????J?7!  .:  .:.. ...^7   \r\n.^?!^ :^.   ...    . ::...:.:^^~~~:. .....:::..  .:~:..!^::^!:.  :....:::..~:.  ...?:...?JJJ?7^^!777!~:.   .   ^....~~.\r\n!~^^:.  ::  ... .......:~~^ :!:       :~~   .  .^^^~::::::^^.:. ..:::...:. ~:.  :~~!.. !YJJYJ7!!7JPBBBPY!...:~   :::?&#\r\nGGGP5?^........:  . :~~~^^:  .  ...  .!~^.::!^::^~~^::..:^!!~:.     .^^  . .^!!^^^.....~?!^:... :!J5PGPY7..  ::^!!~:^GG");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   .::^7:.^?~::.  .::^^:.  .:    .^...::::^:. .~!^::^!!^:. ..^~^.!!!^:::.......^:.::    ....^!^:^..:^.:!~:..^!5###BG^ .\r\n?J5GB!:~!!^::. . !YPGPP5J!:..:^~!??:....^^:^~~~~~:   :..:~~^::.......:::^~!^^:^~^.:. ~: .^~~^::  ......  .: .^^~!7JY:  \r\n7YPB&Y:::   ^:.. ~J5GPGGY?7!7?YYYYJ...~7~~.  .^~.::..  .::^~^:::::^!~~^. .:   !~!^:::~^.:^:......   ....  ... :~!~^^^..\r\n:^:.^~....^   .   .:^~777!^:~7?JJ?~ ..!~ .   .^^ ...:.  .^^:..!~..:^.... .....^~^:::^^^....:^~.   .:       ^~ .^7!: :?~\r\n~Y:   !!... ..:.  :.  !7?JJJ??7!:^...:?~:~:   ..:.  :  ..^~:!~7!~::!^.  :..:. ~^.   ^~!~.. 7Y??!^....:~77!^:.  .^^!?:.^\r\n.. ..7#J::.....    . :?JYYJ?!~^:....:~:.:^:.~:.. .......  .^:. .~^..... .  ......  . :?...^JYYYJ?7!7J5BPG#GY7    :~?^:^\r\n....:^^::^.. .......::~^:.::..::^~~^:.:^7::!7^:  .....:.. .^~~^::   ..:... .......^^^7!...~77??7^:~7?Y5555J7. .:~. :~!~\r\n::^::..:^.^7:^~~^::::.. .:~~!^..~~:::!:.~J!:..::....... .7YGBBBP?. .:.....  .:?^.:~.:~~....:!7?????77!....   ..  :  .:^\r\nJ7?JJJJ?!~^!...:::.:^:^^:^: .   ..  .:~^^:.^. ^7YPP5J!^^:^JPBGGJ7~...::.. .^.:!?^:7^..:~::..::!JYYYJ?:  ..  :.   :. ..~\r\n77?JYYY?^:...:.    ^^  ^~!~:...:^.....  .. .  !YGBBBB5?:. ^JYJ~. .7?5PGPY7^  :.~Y~ ^~::~!!^::..::^7?!:...   .......77. \r\n::::.^~~^~?...:.. .~^.:^~~^:^^:......  .^...:...~?7~~!?J:....: :?7JPBGBBPJ^ .:..:^~:.  :.  :!!~:. ...:...... ...^:7#5..\r\n..^:..:::~:^~~^^^^::::^:!.    .::  ..  .:.......!7^..^! ..:^:.. !~..^77::.... ..  ..  .:.    .~:^::.:^^^^^~~:^^.:..:~..\r\n..J&?:^... ......:... .:~!!:  .:  .:~^:..:: :?5GBGBPY7J^ :..:..7J!~^!7!. .:...^:  ......:::::~~^:.:~. .:::..?!^~~^..:::\r\n  ~J:......   ....~77^::..::^~!~::^~ :Y!.:. :7YGGGPJ7:  ^?JJ~ .:75BBGBGY7  . ..  .....^:...:~!~^  :^    .:...::7YYYJ?77\r\n~....:  ..:  .:. .7?YYYJ!::..::~:..:!^^?!:.^. ..::...^!?PGGPJ~:^^~JPPP5?~ .^:.:^~^.  ..   . :~:~^:^:.:::...~^~~7JJJJJ7?\r\n~:.  :  ..   ....~77??????7:....^~:.~^.:?^.  .....:. .?5BBBB5?. .......::..:~J!..!::.~~. :!!~:....::^:^~~~:7~.~:..::^^:\r\n^~~:  ~:...!?Y555Y?7~:^7???7!...^7~^^....... ...:...  .:~!!~:  .:.....  ::7!^.!~:..^!~~::...:..^~::....... ..::::^:....\r\n~:^7!:    !YGBBPBPJ7!!?JYYYJ~ ..7^ ..  .....  .. .. .:~.  .^.  .......  .:~:.^^.:^:.....^^!?JJYJ?^ .     ....::7#Y:. ..\r\n~..77^^:  .:~!??!^....^!?JYJ...^7~^.   :~.....:  .:!^:~!7~!^~^... .   :..   .^:~?^...^:~7??JJJJ77  .:  .:......~?.  .Y!\r\n^?^..~7^. ^^. .    ..   .~~:....^^^::::~^::...  ...^:..^!:.:^^.  .:... :^:.  . :7.. ^?JJ??~:^!777~:..   .   ^....^^.:^:\r\n..^^^~7~^ ...  ...:   ......:^:.:~::::!~!.  ..  ^!~!^::::::~^::.  ..::.^^.   ~~!!...?JYYYJ7!!?YPGPGPJ!. .:^   .::?&BPY7\r\n  .JJ7!~^^. ..  ......  :::^~~: .~. :.^~^:^^!!^::::......::^~~:. :.  .~~~~~^:^^.....??7~~::.:!J5GPBGY7.. .::^~!~:^BGPYJ\r\n. :PG###P7^...~~:.:: .^.^~~:...    :^..^:......:::^~~!.:~^.  .:^!!^:.^!~: .:^::::...^:    ::  .^^^^^:. .:.^7~::7^:^..  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(". .:^^:.^~~^.^?!~~^.  .:...   ..   ..:..:~~. ~..~:. ...^7JJYYJ?!:!?JYYYJJ?7:::..:~~^^.  ~?~:^:.:~~?J!:..:^!YG#BG? :J.  \r\n:!:  ..::^7::~7^... .^~!77!~.  :. ...!:....:^^~~^:::~~:...:^!7!::77?7!~!^.... .^^.:..^^~^^^... ..........~7JY55P^   .:~\r\n!JJY5GBB^:~!~:::. ..?5BBY5B5J!^:~77?JY! ..:^~:.:.  .~:.:~^:.... .......::^~^:::~::^..~~:......  ....  :   :^^~~!^. :?JJ\r\n:~~!J5G&?::.   ^:. .!J5G55G5J7~~?JYYJJ^...?^^.   ...  .^^^!^:::.::^~~!^. :^. .^^^^^......~.    ..      :! .~77: :!^~??!\r\n.:::~:.:^.. .^   .   ..:~777!^:.~7?7?!.  ~7...  .:::.  .:::..^^^.::^.::.  .     ^~~^.. ~??!:. ..  .:^:...  .~~~~!7!^:??\r\n::^!Y.  .J~......:.  :. .7?JJJJ??7^.....:!!:^:..  ..  .:~~:~^7?!^.:!:.  ..::.   ..?^...?YYYJ?!^^!J5P5PPY7:  .:^?~  !^:.\r\n.. .. .:Y#!::....   .   ~?JJJ?7~^^.....:^:.:^..~7:. ...  :~^...:!^:.... ..    :^:~7...^?JJJ?!^~7JPB5JGBPJ:   .:~7~~~^~:\r\n ......:::::::. ......:::^:......::~~!:..:^?!^7!^::  ..  .::::..:.  ... .:!^.:^.:!!...:::!7~^^^!77???7!^. ..^^  :^^:7BB\r\n..:^^~^^..^~.~7:~~~^:^::....^~!!: .^~.::!..7J^.. .:::^^:~JPGPGPY!. .  .:::77..?:.:^:....^!?JYYJJ?7. ..   ..  .^  .^JBG5\r\n .^:~~~!!777~7!  :^::.:::^~:~. .   ..  .:^::..^. !JPBPGG5YGB?GB5YYYJ7~:. .:^J?^^~..^!^^....~7JYJ?!  ..  .:.. ...:..:.:^\r\n.......  .^:^!~^^^^^^.:::~^^^    ..^....   .. .  7YPB55BPJ?Y5JJPBPY#B5J: :^.!7:.~:.:~~::^^:...:~^^....   ......!B:   J7\r\n.. ..^PY^::.:. ::...::....:^!^:.  ..   ::.. ... :7Y5PPPYJJ?:7J?YPP5P5?^  .. ..::.  ..   :~~~:. ..::...::. :.:^^YG~.. ..\r\n!Y   .GJ:.:...   ....:^~:..::^^:.~~:.:~::!!.:: .?5G#Y5BPJJ5YJ?5B5YBPY7. . ...  ....^:.    ^~:~:::.:^^^^^^!~:::  .......\r\n~:....:... . :.  ..  ^?JYJ7~....:~!^..^::7J~.. .:~7JYYY5GBJGGYYGG5BPY7. ^:.::^^.  ..     .~:~^^::..:^:  ~?~!77!~~~~:^. \r\n5PGY^.. :.  ..   .. .!7JJYYJ?!^....:^:.:?:.77:::.  ...~YPG5GPY!^~~^^:. ..^??..!::.^^. :~!~^....::^^^^~~:7!.~^::^^~~:^..\r\nB#Y:^^:  :^.. .^~!7?777!~^^~77^::...~!:.^:.:!:. ...  .:..^^:^.  ..  .::~7^!?~::.:~~~^::..:..:^:::....:. .::::..:...... \r\n:~^~~~!~:.. ..?5BGY5BPJ7~^~7JJJ?~...!!:^^.   ... ...:^!^...:~:. ... ..!!..^^.:^::....::^!?JJJ?!.. .   ....::~#P^.. . ..\r\n.:^7. ^?~:.. .!YPP5PPY7~~!?JYYYJ:..:?:..  .::..  .:!^.^!?7~~:~!:.  ..  ..:^:~!^.....:7?JJJJJ?7. .:.  .. ....^5.   ?!^.:\r\n??^^~7!~~~~.  ..::^^:. .. .^!?J! ..^~~^     .   .:.^^:.^~~:.:::.  .:::.  .:.!!. .~?777!::^!777~:..   ..  :. ..::..~^:^:\r\n!??~^!: .!?~. ~^      ...    ~:.....^^^^^.  :: .:!~!^::::::^~~:^.  ...   .^:?:...?JYYJ?!^!?YP55P5J!. ..:   .::!#G5J!~^:\r\n?JJ~ .^~~~~^:   :. ....  .......^~:.^^:~^::^~~^:.....:. ....:^~^..^.  .:.:~^^.. ^YJ??7~^^!?5BPJGBPJ:   :::~~~::GBBP5JJ7\r\n!^.   :555JJ7~:.......... ..^^^~^^..:.:~:.....:~~!!77?:.~7~^....:~~^^:^~~^^:.. .:!:.. ..  .~7??7!^. ...:7!::7~:^:.  .7^\r\n  .7^ !GB&BP?^:...!J?~~:.:^:~7!. .^^^~^...::!??JYYYJ?7:~??JYJJ7^......^:.~..^~:..:..   ..   .....   ^^~!?~.:~^^..^^:. .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("...!?^~!77???~:^!?::^!!^. !^   ....  .....:^~~~^:..^::~^!7?77!~!!!!77~:.  .  ..  :::~~^::^..7YGJ^.  .^:~~5BGP:.?^ .!?^.\r\nY?:...::^:.:~~:.^?!^^^.   .....   :.    ::..:^^~:. ..^!JYYYYJ?~..~7?JJJJ!~^.::..:~~~~~~... .:..^^:..:~JGB#BG7  .. .7^~^\r\nJ^.:7:  .:~:^7::~7^... .!?YY5Y?!: ....:^!!:....^:::^^..::^!7?7~.~??JJJ?7~^:....~~~~^:.:. ....... .^. .:^^~!?~   ~?J7 .:\r\n...!YY5GB#B^:~~^..^. ..?5BG!7GBY?!~!?JJJYJ...^~~^.:!^:^^:. .:.  .^::...:::^:..:::::..:...   .:..   .: .~77:.^~:~JJ7.  .\r\n7?:.^^~?JP#?::. . :.. .~?YP5Y55J7^:!?JYJJ~ ..7^..     :~~!^^:...:::^~~:.:!~.^^^:...:~7:.. .:   .....:  .~!~.:7!:^77~.  \r\n:^:.^:^!: .:.. .^  ..   ...^7!7!~:::~!!!!.. :?^.^.    ..:^:.::::::^~:~:     :^!!...!YJJ?7^..:~?Y5Y?!^.  ^:^!?^:~^~????7\r\n7~::.^~J   .5~.......   :. .7?JJYYJ?7:  ...:~~::^:.....~!.^:?7?~..^~..    .:..?: ..?JYYJ?!!7J5B57?BGY7    :!?..^!:  .::\r\n:.:.. . ..:5#!::....   . ..~?JJ??!^::....::::.:!..^?^. .:~~^:.^~!^^^:.::..:^:77...:!!77~:.:!?Y555PP5?: ..^..~!!~:7Y!:  \r\n^  . .....:..::::: .:....::.::...:.::^~~!:.::^7?~~!^.:. .:.... .^.  .:?!..!:.:~. ..  ^!!77777!!^^::.. .. ..  ::^J&##BPJ\r\n.  .......   .:.~~~~~~~^^^:....^~~~: .^^.::!..7?^..  :~!?Y5555J!^..:..^!!~?!:.:^^....^~?JYYY?7:  :.  ...  ^. .:!J7!!^^^\r\n::. .....~!^.:::^.:~^^:^^^::.::!^..    .  .:^:...^. 7YPB5YB??BPGGY7:  :.!Y^ ^^.:~!~^:. .^~7??7.      .......~~.  :!~:::\r\n.^.:!^  .7&?:^. . ......:... .:^~!:  :^...:^^^..:: ^JPBB~?GBBJ~G#PY~ .^..^^^^...^:. :!!^:. .:.:...... . .^:!#J.  :7::^.\r\n:::~!^   ^7.......    . .!??!^^. .:^~!~:.^~ .J7.:. .7YGG5GJ7BYYBGY?. ^:..:^^.  .    .::!::..:^^^::^~^.^::::^!!:.... .::\r\n^^:~!!?7:. .:  ..:  .:. .7?YYYY?~^:...^^..:~?!!!^..:..^!Y55PPYJ7~^. ..:7?:.!::.^^. .~!~~:...:^^^~~~~~~!.::   .......  .\r\nYPG##&5^::. .. ..  ..:::~!7777777~. .. .^:..!..!?:.. .:. ....:. .:::~~~?7^::.:~!!^::.::...:..:....:: :^:::..:..... .  :\r\n  .!YJ:^!!~..^:...7YPP555Y?!:..^!7~!^...!7^:::.::.:^^^!~^.::~~:. .:?~:.~^.::::....:::~7??J?!.. .    .. ::~BG~.. . ..:.:\r\n::.  :~~..7!^    !YG#J!JBPJ7!!?JYYJJ: ..?:.:.     .~^..^?7?^^.~!:..:..^^.^~:...  .7?JYYYJ?7: .:.  .. ....^P:   7!^.::^7\r\n7???7~:~:^7!^:^. .^!?Y55J!^::^7?JJY?...~7::     :^:^^::::::..^:..    .:::?^ ..~!~!~::^~!7!7^...   ..  :. ..:. .!~:^:.^^\r\n  .~77^:~?::^!~:  :.....   :.  .:7!^...:^^^.^!:.:~~^^::...::^!~~^.    ..:?...^JJYJ?!:^!?Y555PY?~. ... . ..:!#PJ?~::..?7\r\n.  .!?J!:~^.:!7~: ^.   ....   ...:...:.:^..:^:::....:^.  .:...:^^:^!:.^~~~.. ?YYJJ?7~!?YGB7!P#PJ:  .^..^~~::B##GP5Y7. .\r\n:. !J?!.  ^?!~^^:.  :. . .. .. ...:^~~~~:...::~7???J??!.^7?7!^:...^^:::^....:~7^:.... .!?Y55YJ7:  ..:!!^:7~:~^:  .7^ :?\r\n^~^?:. .  ~GG#BGY!:..:::..:. ...~~~~~~:..::.^!!JJJJJ7~:.^??YYYYJ!^.. .:~^^^..::    .:   ......  .^^^~?~.:~^^..:::....7Y\r\n.:77. :?^.YGBG7!^::  .^JPY7:.^:.^~~^::. ... .  .:~77!!!~~!77??7^~^:^:.:^~~~^......  ....   :7..:!!^::77~^^7???77!~7!:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(":..  ..:.:.  .:^!!~^~~..:77~:   .. ........ .^^. ..   .:  :7JPGJ~JGPY7:   .........:^:. !PG7:  .:~::.^YGG! ^^:!7YY!!^..\r\n7J!..:!7^~!77??7^^^~7!^^~~:. :~.   ..:   .........^..:.:^~!7!!?YYJ?77~. ...  ... ..:^:..~:^7!^...^7PB&#GY. ~.  ~~::.  .\r\n55Y57.....::..^~~..~7~^::.  .:::^:.  .:.   .~......:~?JYYYY?7^...^!????7^:: ::...:^.  ...... .:..:~~!7?5!   :~?J::^:  .\r\n?JJ7: ^7.  :~!:~7^^!!: .  ^?5PPPPPJ!:..:^~!7J^....::..^~!?J??!..~??JYYYJ7!~:.........   .:..  ... .^~!^^~:.:JJ?^  .7^..\r\n. .. .?Y5PB##B::^~:.:^.. :JP#P!^?#PJ7!7?JYYYJ:..:7~~^^:...:^:   .!~^:.::..:.....:!:    :.      .!. :!7^..!~^~?!:    :7:\r\n:~!7?..::^7?5B!:.. . ... .~7Y5555Y?!^.:!JJJJ! . ~! . :~~!^:... .....::::^~!!:. :YJ?!~.....^!7!~:.   ^^^~~7!~:^7?!^...:^\r\nJ?:^^.:^^~!. ......:  ..   ...^7!7!~^:.:^::^:...7!:^::::^::::.::::^!^!: . !~ ..7JYYYJ?!!7YPPY5PGY7. .::^7~..!^^^~??7!^!\r\n~577^::.:!7   ^P^.......  .:. :??YYYYJ?7.    .:~^.:^:.~~.:.7~.!^.:^^..:~^~?....??J?7~::7J5BJ~75BPJ:   .^!!^^!^:.   ... \r\n??^:.:. .. ..~GG^^: ..   .. ..!????7~::....::::...7:.~7!^!~~..!!!:!!..^:.^!.......~:..:^!7?YYYY?!: ..~^ .^~~:!GPY~..?^ \r\n5::^... ....::...:^^. ::.......:...:::::^!!~:.::^!7::^:.:.  .. :^:~7~.!~..::. . .:7?JJJJ?7!: ..    .  .: .:^?##BGPP5?. \r\nYJ!.::..:  .:GG~::... ::.......  .^77^. :^^.::!.:?!:.. .^7J??7~.  ..:!7^^:..~~::...^7JYYJ?~  ..  .:.. .. ..:~::^:....??\r\n::^::^~!Y.  .57.......   ...^~!^....:^^:!~^.:~..7?:::  7YPB#BGY7. :::??..!:.:~!^^^:....^7!^...    ......~P:   J7~^^:^::\r\n?J....:~::^:..... . :.  ..  ^?JYYJ7^...:^~~..:^:!!:... .~7?JJ7~.  ..!?^.~^..^~: .^77~:  .......... ..:^^P#^.. :..:^.!JJ\r\n .7555PGB#Y^:. ..  ..   .. .!7?JJJJ?7^. . .::..^7:^7~::^  .  .: .^::!7^::.:~!!^:::::...:.......:^ .^^:...::....  ..:::Y\r\n.:?::~YGB?:^~^. :~.. .~7JYYY?7!^::.:~. .....~^..~:.!7:!!!:.^^!~~7!::?:..:::::....:^!77??7:. ..   .. .^^5G!... . ...:^!?\r\n ...   .:^!~^!7^.   .?5BP7!?BPJ7^.^!??7?:...7!^^:..:^:.:7:^?::.^!.:^:.:~:.    .7?JJYYYJ?^  ..  .......:P!   ~7:.:::!!Y?\r\n7^~7?7~^^^7. ^?~::. .7YGGYJ5G5?!!7JYYYJ?.. ^7...:~^~^::::.::::^:.::~:!?:...^:::^.:^~!777^...   ..  ....:.. .!!^^^.^^:7J\r\n^....^!??^:~!7!~^^^   .^~7?7~:....~!?JY~ ..!!~^::^^:.:......:^!!~: . ~!.. ~?JJJ7:.:!?JY555Y7~. ... ....:~B5?7^.:..?77!^\r\n.7^    :~7!^~7..:7!:  ~:      .:.   .!^:....:..::.:^^~:   .^:...:^^~~7^...JJYYYJ7!7J5BJ^!Y#PJ^ ..^:.:^^^:P&#BG5YJ: .. .\r\n..:7:  :?JJ~.:^^^!!^. ...  ..:.   ..........^~7?JYYJJ?!..~????!^^..::....:J?7~~:..:!JPPP5PPJ~  . .~7~^!~:!!^. .7~ .!JJ?\r\n.  :^:.??!:   ~Y?7!~^:..:. ......  .^:...::.:^^7?J??7^...^7?JYYYJ?!:.. ...^.    :.  .:^^^:.  .:::^7!..~~^...:.....!5YYY\r\n:   ::^!  .~. ?GB&#G?~:..:~!^:^..:^:......   ..  ^777?YY?!!7!!~^.:..^:........   :..   .^^ .:~~~^~7~~^^!??777!^!!^..~J?\r\n..:!~?Y7~::~.^GG5~.::~:.  :7PP7..:^: .........  .!JPGY!JGPJ7^  :.   ....^~:  ....... .: . .~7?^..^!^^!!~:.  ...:..  ..:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(":::.:?~:   :!^.    :7J?~.:^^~~^^:...:. ....:. ........   .~?5GPPPPP57:...     ...:75PY?^.  !!~~:  :757 ..7Y!YBG5~::::::\r\n::::... ..:.:.  .:^~~^:~7..:!?~:.:. .  ... .... ...  .:  .7JPB7^~7BGY?:   .........:!7JY7:  .^^7JGBGP^ ?~  ^7:... .!^.:\r\n~!?JY7:.:!!~!777??7^^^~~~~~~~:   ^.     ..   ...::. . ..:^77?YP555Y?7^  .:   ... .  .........^7Y5PPGJ.  ..^7~~~.  .~^::\r\n?55YYY57.......  :~!. ~?^::..  :^!!7!~:  :.  ..~^::!??JJYJ?7^:::^^!777!^... .:.....  ...  :.  .:^^~!!. .!JJ7  .!: ..:^^\r\n^7!?JJ!. ^?: .^!7:~7^~!~.    ~YPGPYYGPJ!^:^!77?J7...:~7?JJJ?7. .~7?JYYYJ?7~::^: .  ... .   .~. ^!?^..~~^?J7:   ::::..::\r\nGJ:  .:.:?Y5GB#&B::^^: :~.. :JPBP7~^GGY?!!?JYYYJ~...:. ..^~~.  .~77!~^~^....7?!:.  .. ..::...   ^~~^^!!^:^!^:   .!~   .\r\n?!~^!77?..:.^!7YG!:.... ... .^!J555YJ?!^. :7???7.  :?~~~:...   ..:....::...~YYYJJ7~:~7YPPPPY7^. ..::~!~^~:!JJ?!~:.:!:  \r\n!JY?7:^^.:^^!7. ..:....  ..   .. :!!7!~~^:.........!7::~^:::...::^~!~~?^ ..7?JJJ?~~7J5BJ:7JBGY!   .^!7. ^!:..:~~~:^~:::\r\n!J^!5!!:::.:~~   ~G^.......   .. :?JYYYYJ?7.     .^^..^:..~~ .~:.:^^.~7:...^^^!:  .^7J55YYPGPJ^ ....:!!!~:!7:   ^^ .7Y?\r\n7!:55^..~.    ..!#G~^. .. .......!??77!^.....:::::.. ~~:~~!^ ^?~:.~~ .::.     :~~~~~!7!7!!~^:. ...^  .:^:7##BPJ!7~ .^Y5\r\n5P7^:77.::^77  .~#7::. .......:^:^~. ....^~~~~~::^::!~..::....::^:~^...:::...:!7JYYYJ?7:  ..  ...  ^. .:7PYJJ!777~::.  \r\n.:JJ7~ .:.^~^ ..:^........   .  !?J?!~:...:^!!:.:~..?7...  .  .. !?:.~:.:!!^:...:~7?J?7. ..   .. ....::.. :~~... ^7JJ:.\r\n   ::~!7!~??J5?:.  ^   ..  .:. .7?JYYYJ7~:...:^:..::~::::.....:..~7:.^::^~~~!~:... .^^:^:.........:.~#7.  ~J^:^.!7::7PP\r\n5Y~. ^77YPB##Y:^:.  :... .:^^~!!!7!~!!~~^      :^: ^!.:~7~ :!~!:~!...::::::....^!!77?!:...... .. .^^5#?..    .~:.^YP:^J\r\n?YJ. ^~   :77:~!!!:.....:?5GPYY55J7~.  .~^:^....7~.:^:.:~: ^!..:^:.:^:.    .77JJYYYJ?~  ..  .......:G7.  ^!:.:::~~5?:?!\r\n^::~^:^~~:. :~! .!7^.   ~YG#Y7:7#PJ7~~7JJJJ?.. :?~~!~^:::..::::~^:!!:.......::^~~!77!^  ..  ..  ....:.. .!7~^^.^~:!?JY7\r\n  :!^.:~!??J!:~^^!~::..  ^7YPPPP5?!^~7?JYYY7...:^.......   ..::~~~?~  .!???7:  :~7JYYYY?!^. ..  .. ..~PJ!~^... 7777~~!?\r\n.   ^!.   :~!~.:~!^^~~^.  ...:::. ... :^!??:...:^^~!!7~.  .^~^....:...^JJYYJ?!~7JPB!~7Y#PJ^ ..~: .^^^:G&#BGPYJ^.:.  .7G\r\n:::..::.   :!??~^!..:?7^..!.     ...  . .~::^7?JYYYYJ?!. .!??JJ?7!:.. !YJ?7!~:^!J5BYJPGGY7.   .^!~~!~:7?~:..7~ .~?J?77~\r\n^^:.. :7:  !JJ7. .~!~~^^.  .:  ....  .....:  ..^!777!~:::.:7?JYYJ??!:::!... .:  .~!77!~:. ...:^7! .~~^  .. ....!5YJJ55?\r\n::^~.  .~~^?^:.   7GPP5J7^.......... .....   ::  :7?J5555Y?77~::: . .::...   ..     .^.  .~~^~~~~~^^!????7!~!!^.:!5YJ7!\r\n:.^7. ...:!~  :?..5GBBYJ^^.  :!YJ!!:.........   .7JPBJ~~!BGY?:  :.   ..  ... .... . .:..~7!:..7!:^^~^^.  .:.::.  ..::::\r\n::::::^Y5B5!J7:. ~PJ~  :~~~!  .:?YP5?:...      ..:7YGPPP5G5J!.   ........  :.... .:. .:^^~~^^^:^?J?^    .:7:   :~7^.:::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  .:::^~^:::::. ..^~.  ~JJ7  .~?777!!!^...^~~:....  .  .^:  ....:.     ^~   :....:   .:7?~!^.  ^!~ ..JG^~B#B7::::..^.  \r\n..::::.^7~:   :7:     :!?7!^^::^!!^:   :.   .........   .:~?Y5PPP5J7^. .:   : ...~7?~.  .^:^^!5GG? ~!.:~J7^:^..^:::.:. \r\n...::::..  .::.:. .:^^^:::^7~.:~7~: ^^    ...  ...  ..  :?YGB7~?7?#GY7:   ... .....:^^...^75B##GP. ..  ^7^^.  .7!::^~^~\r\n.^~!7J55!:.^~~~7??7??!^^~~^^::^^:   .....   ..     . ...:77J5PY?Y55J?~  ..   .......  :: .:^^^!?7.  :7JJ:.:^.  .::^:.~!\r\nYY7?5YJJY5!...  ..  ^~~. !7^:.  .:~?JY5Y?!:  ....:^!!7?J?77^^~7!!~!77~:. .  .    :...  .:. ^!?~::^::?J?~   ^!...:^~:.:^\r\n:..~?7JJ?^. !7:.:!J7:~!~!!^.   .75GGG?~YB5?7~!7JJJYY?JJYYJ?!.   :!?JYYYJ!!^..  :.   ....:. .^!!:.~7^:~~^    .:~....:::^\r\n :PG7.  .:.^JYPG##&G:^^:. :~.. ~JPBY7!~5GY?~:!?JYYJ7 ..^!!!:.  .!????7!7YYJJ7~:.:^!JYYJ7^.  ::.:^~~~^.^!!^.  .^:   :~7:\r\n.5^7!!!?777 ...^~!JP^.. ..  .. .^!?YYYYJ7~:.  ^!!!7:. .....  .  .:.... !JYYYJ7!7?YGP!JPBPY7. ...^7~.:!:!!7??7~:7!.  ..:\r\n:! 7YJ7!:~^.^^^7!. ..:....  ..  ..  ^777!!~^::    ....~~:::....:::^:...~!7?!:..!?YB5:~?5BPJ:   .^7~::7^.  ......^^!?G5?\r\n7.:JP^:!J5~..:^P^  .?G:.......  ..  ~?JYYYJ?7!.     .::..~^. .^:.:^^...    .  .:^7?Y5555Y?^ ..~: .~!~:~PY!. .7^ :5Y77YP\r\nP~7!7P5^::.^^~~?.  .J!.......      :7?JY?~:.....:^:::.. .~^  ^!^ ..:.  .  :7????777!:....   .  .. .::7###BGPY?. .^7YJ!^\r\nBB~   :!?:::.:~^^!^.. ..  .:.  ..  ^?JYYJ?~::...^~:..^~~  .:.  ^~^..:~^:..::~?JYYJ?~  .:  .:.  .. ..^7~^~^.:::7!^   ^GB\r\n^!JY7^.  7YPGBB#&J^:. ..  ..   ...:!77?????7^. .  .:.. :!^  :~.....::^^:.....~7JJ??^      .......^Y.   7!~^^..^^YP7~7~Y\r\nPY77JP^ :?: .!YG7:~~~: .~.. :7J5555Y?7~:.. .    .. :~:.:^.  ^~:.::..   ..!7?JYYYJ?!  ..  ........55.  .P~:..:5J!:^PJ~ 7\r\n?5GY7~^......  .^!^:~?~.   .?5BG?!:YB5?!..:~77!!....~^::....:::~~:...    :^~~!7777~  ..  ..   ...^:   ~7~^^:^~^!77Y?.^^\r\n:... .~?^~7??7!!:!^.^7^::.  !YPBPJ~5B5?7!7JYYYJ7  ...:.     ..... ..!!~!^   :^!?JYYY?!^. ..  .: ..:5J~~^... !77??7!7^5^\r\n:7~:   :^.  .^77~.^~~~^:.::  .^7JY5Y7~:.:~7JJYY?!!7???7.   .~7~^.. ~JJYJ?!:~7YGP!!?YBGY! ..~^  :^^:5&##GPYJ^.:.   ~PG~ \r\n^^^:....~^.    :~~::!!.:~!^. .:.....  .:  ..^!7?YYYJ?7^.  .!?JYYJJ7JYJJJ?!~7?YBP^7PGGPJ: . .:!!~!~:!Y7~::77. :7?J??7:..\r\n^:.:~^:...~~.  ^?J?^:~:.^?!^ .:.   ..:    .  . .:~77!~~!!~^^!7?JJ?!7~^:.... :!?555YJ!:.  .:^77. ^!^   .  .. ~YYJ?JY?7JY\r\n!~.:^::.  .~:..JJ7^  .!?!^^^:. .:  .......   .:  :7J555JYP5J77^... .     .:   .....   .^::::^~~^^~?77??7~~~~.^!5PY?7~^:\r\n~^~^::~7.  .^^!~. .. .YGB#BP?~...:^:.........   .7YG#J!7~!BGY?^  ..   ..  ....   :~ .^!~^.^?^:::^~~:. ...:^:  ..::::...\r\n .:.:::^..:::!J~..~7 ~GGP?^~:^.  .~J?!... .   ....^7J5PGP55J!^.   ......... . .:   :^~7^::^^~7?!:     .!^   .^!~.::::..\r\n  .::.::::~G##7^PY.. ^7^. .:!~7?:.   ::...:.  ^^     .::.... .^.  .. .....^~^...:~~!!!7?~.  !JJ!  .^^:. .::::::~^:::.  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("::!^  .~~~^^::.:~^... ^~. .JJ~.   !GG###5^:...::..... .:^^^^^~:. .^~!~~~7!^:^?#&!.^^~~~~: .!~:.. J#^.P#BY::::..^    .~:\r\n:.   .:::^~^:::::.. .:^.  :?JJ^ .^!!~~~^^:....:.. .:  .~:    . .. .. ..^:. ...:~... :^^^..^JPY .::7!?PY?!:.::::::.  .:^\r\n::...::::.^7^.   ^7:     .~7!~~~:.:!7~:.  .:  .......  ..:~7JJY5Y7~:. .^^  .:   :~...^~JG#&BG^ ^~  .7:...  !7:::^^^^..:\r\n......::::..  :^^.....^~~^:..:!!^^~!^. .!.   ..:. ...  .7YG#J7JYJ5BPJ~.   ... ........~!7?JYY.  .:!?!:~^   ::::^^^~~~~~\r\n ..:~!7J5PP7~.^~^~7??77?~^^~!~:...::   .::::.   :. ... .7?YG57~~?5G5?~  .... :... ..   :^~~^~^..!JJ7.  ~!...:^~: ^!!~~~\r\n??5YJ77J?7JYY! .:      :~~  !7^:.  .^7YPPPPPJ7:...:^~!777!~!7YYJ?777!:  .. ..      .^~ .~?!. ^7^~?7^   .:....:^^:::~~^~\r\nJ?~..:7?7??7^ .!7::~?Y?:~!!!!^.   .?5BPP7.^BPJ7!!?JYYYYYJ?!. ...:!7?JJ?!^:.....^!!^:.   :^^~^~~:..^^..   .7~   .^~~:::.\r\n .. ^GG!.  .^.^JJ5GB#&G:^^:  :~.. ~JPB5?!!5GY?!.:!JJJJ?77?~.   :7?JJYYYYJ?7~!?5GP5PG5?^. .. .^~~~^:7J?!^:..:^.  .:^.:::\r\n   .5:7777J777 ...^^^75^.. :.  .. .:~7JJYJ?!^:.   ^^:~:.:.      ^^~7??J?7^:!?YBP .?PBPY!  .:^77. ~~^.:~77!^~7:..^^:::::\r\n   ?7.7JBB~  .^~~~!~   :^....  ..  ..  ^7777!!~^:       .:............:.   ^!?5PY?J5BPJ^ . .:~7!~!^~^.   :. .7JJPBG5?~^\r\n.. YBJ^. ~JJ7 ...^^:....:... ..:.  .:  !?JYYYJ?7!.......:.....::.  .   .::^^^~77?J?7!~: ..:~  .^^:~BBGY!:7~ .!5Y~^77!Y5\r\n^:..JP?:  ..^?YJJY5PBJ^.  ^   ..   .. .7?JJYYJ?7^... :::   .   ::: ...:7?JJYJJ?7:  ..  ..   ^  .:7BGP5YYYJ^ ...:?5Y:.:^\r\n5Y!7!^~Y57. ^7^!YGB#7:^^:  ^^.. .^!!7??77!^^^^^:      .::.............~7?JYYYJ?7  .:  .:... ..::.:.:^^... !J?~  :7BP ..\r\n^~?5GBGJJ?: .:   .^~^~~!7~:. . :?5BPJ?YP5?!^.  .:............:.       :^~!77?77~  ..  ..   ...^:   ^!~~~^:  :GBJ7:~Y   \r\n:::::~!...!~^~!7~:.:~!  !7^:.  ~YPBPJ: JB5?!::!?J??7~^^.     ...:~::^   .:^~7JJJJ!~:. ..  .: ..:J7^^^... ~77JJ?77.Y^   \r\n:::.::.  .^^..:^!?J7:^~~~^....  ^7YGG55G5J7!!?JYYYJJJ??^   .^777?JJJJ7:.~?YPP?!?YBPY! ..~^  .:^:5&#BG5JJ^:^:   ~5B7 .. \r\n.:::^!^:   ^?:   ..^^..:~~^~^^:   .:~!!~:....:^!?JJJ?!:... .~?JYYYYYJ?7!7JP#!.~5PBPJ:   .:~!!!~:75J!^^77. :!7????^..^7J\r\n^^~~:.::^:......   ^!?~^7~ .~?~: :~.      .. ... :!777?JYJ7~~!77?7~^^:..:!JPPPPP5?~:  .:^!7. ^!^.     :: ^YYJ7?J7!JY5JJ\r\n~~~~!~ :~^:...!!.  !JJ7..^~^~!~^.  .. ...:  ...  ^?YPPJ!~75P5?7:  .. .:.  .:^:::.  .:...:^!~^^~77!7?7~^^^.~7PG5Y?!~^:. \r\n~~~~~^^^::::   :^:~J7^.  .JYJ77!~:...  .. ....  .~?5BP7Y?77BGY7:  ... .:..   .~: .:!~^^!!::..^~!^:....:~:  ..:::::..  .\r\n:..^^^^^::!7.  ..:7:  ^~ :PB##B5~^...^:   ..  :^. .^~?Y55YY?!^..   ......  ..   :~77:..~~^!!~:     .7~   .^!~.::::...::\r\n^:.  .::::::..~7J5J!7:^: ?PY!..:^~:  ..^:...  :^..  . ....    :~.  :. .......:^^~~~!!^. :JJ?^   ::. ..:::::^~^:::.    :\r\n:~.    ^..::::?B#G^.BP...:~!. .~!~~~~.:##J^:^~7!~~!~^.  :^^^^^::. .:....^...:^Y#BBGG?.  .~JJ^  ~~....^~^.:::^~~~:  :!::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Thread.Sleep(50);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(40);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Thread.Sleep(30);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Conexión neuronal exitosa");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(2000);
        }
        static void LoadingScreen2()
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Shock neuronal inminente");
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ^:^~!77^^:~~~~!!!..^:::   .:!~?^  .: ^GB#P^^.:.Y&GJ!^^!!:..~?~:.:~!^:^^:.~?J5GBBJ: :77P~ . .#P ~5PB!::...^. :..^:. :! \r\n  .:::~:  :~~~^^::.^~^....!~. .JJ7.  .?PPGGGJ^..^^....:~!~^~~~:..:!7^.:!?~^!YB&B~.... .!J~ ..YY^Y#G5^::::.::   .~~^~!^ \r\n .^::.   .::::~^::::... .:.   ^?J?^.:^~~^^^.....  :.  ^^    .. . .:.::^^:....^Y~.::!75BGG^.?^ .~7:.:. .~:::::... .!JJ^ \r\n  ^~::...::::.^!^.   ~!.     .^~^^!!..:77~... .. .    ...:^~!!?7~:..  .!:  ^.. ..^75GGGGJ   ..:?^~^   :!^:^~^^~~~^^^77 \r\n .::.  ...::::..  ^!:....^~!~:...:~~^~~~.  :^.     .  .~?5BPYP5G5GPJ!...      ::  .:^^~!!. .!?J7  :!. ..:^^.:!!~~!^.:7 \r\n ..  .:^~7?5PGP7~.^:^~7?7!!7^^^~!^.  ... .:^~!!~:  ..  !?5B5~^.~!PB5?~   ...   .^: ^!?^..~^~?J7:  .^^. .^~~..^~~~~~^:: \r\n   ^YY5YJ!!?77?YJ^ ::     .^7. :?~::. .~?YGGP5PGY7~::^~!7!7Y55555J?7!. ..  .......  ^~~^:!!::~^.   ...:...::::^~^^^.   \r\n 755?!^. :?J??!~. .77^~?YP~:~!!!^:    75GG5!. ?#5?7~7JJJ?!..:^:::~7?77~:^!?5PP5J!:  .:...::::.:!~:.  .!:   :~7:.:::.   \r\n !^. .. !GP~   .^:^?JYPB#&J:^:.  ~:. .?5GGJ?7YG5?7:..!???7:    :7?JJJ7~!?YB5:!YBG5?^ ...:~!^^~:7???7!^.!~.  ..::::..:. \r\n !:  ...#Y!!.^5PG7 .  ^::!?:.. ^   .  .:~7?JJ?!^:.   .....     .^~!~...!?YGP:.~JBGY!   .^7!..!~.  .:::.:^:~75J!^:::.   \r\n JG?^.  J#?.  .^!^^^:^!!!?^...:.  ..   .  .!7??77!~~                   .^!?YP55PPY7...::.:~!!^:J?^.  !: ^5J?JGG5J?~:.  \r\n ^?5PJ!:^~!YY!:. !J5GB#&#!::.  .. .  ..:::~!7777777~   .  ...  .   :!777!77!!^^::.. ..... .:^^P&#BG5J7. .~J57^^^~?P5?~ \r\n  .:~?JYGGY7?5! .7.  ^?5~:~!!:.:^.. !J5P55PY?!^:.                  ^~77???77:  .   ..   ^...:7?!7!^~~^~::   !BP. .^?P5 \r\n    .::^!?PJ~^^:..:::  .^7..~?~.   ^JP#5!..YB5?7. .:!~^:      ....   .:^~7?J?7~:.  ..  :. ..~7:.^. . :GPG!.~~JB! .  .! \r\n ..:.::::...  ^7:^!7??77^~^:!!:... .?YPB5!:7B5?7~!?JJJ?~.   .!???7:..!?YPP??JPB5?: ..~.  :::~&#BGYJ?~:^:.  ^JBY...  .~ \r\n   .:::..7!^.  .~:   :~!~.:^::....:  :!J5PPPY7~:~7??7!^:.::..~?JJJ?~!?YBP..:Y5BP?.   .:~!!!^:P5Y7~!?^ .^!!??Y~  :~7YPJ \r\n .  ::^~^::::...^:..   .:~::^7^^~~~.  ...::.  ..  ^77JY5555Y7!!7!~^:^7JPGY5GG5J7.  ::^?~ .7~..    .^..75J7!77~?J55Y7   \r\n :.:~~~~~^..^~^: .:^.  .!?J!^!:.:77^..~.   . .   :?YGB7!.:~JGPJ7. ..  :~!7!~^.  ... .^!!^^^!!~!77!^:^:~75GGPY7!~:.   : \r\n 7^.^~~~!!^ :^:..  !^  ^JJ7: .~!~^^^:  .:  . .  ..~JPG5P55YYBPJ!.  ..    .:^  .^~~^~~^..::~!!~::...7~.  ::::::..  ..:: \r\n 77^^^~~~~^~^::~^.  ^!^?^..   ~GPGP5?~.. ..^  .~:  ..:~7?77!~^....  .   . ...^!?^..^7^^^^:      ~7.   :~~.::::...::^^. \r\n .JY?: ...:::::~^ .:..!7. .?:.5BBGJ?^:.:J^....:^^::.:. .. .    :~.  ^. .:...:^^~~~:.:7JJ~.  .:. ...::::^~:::::    ::^. \r\n :!!^^~.   .:.:::::JP#P~75^. :Y7^  ...:P&#5!^^77^::!!^. .^~~^~~~^....:^..^7PGPP5Y:  .!JJ~  ^!:...^^^:.::^~~^^  .~:::.  \r\n ~^...^. : .^...::^GGP? 7&^ . :5?~^ .!GBGPYJ!::^^::!!^::^77..:~7~^~75#B.:::^5#BG? .:  :?~!^.   .::^: ~!!~~~~^::!7!~~:^ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ~~...   :7YJ:::^~~~!~:^^::!~   ^::!  .?^ YGP~^GBBP7~:  .!77!~:...^!7??7~^.  ^7^..:..    PB:.J7GY::.  ::.^:.^.. .~~^.. \r\n .:^~:^~!?!::^~~~~!!^. ^^::.  ..^:7?:  . .PG##PB&#PJ!~~~:..~!^:..:^~~~!:  :^^~?YP5~.^^...5G:!B#B!::::.::    ^~::~!:... \r\n   . .:::~.  ^^~~^::.:^^^: ..~~.  7JJ~  .!J???J?!::::^!7~^^!!:. .^!7..:!7^~?P#&#Y!YGGJ ~~.^!J?~~^..^:::.:. ...~?J~  .. \r\n   .:^::    :::::~^::.......:.   ^7?7~:^:^~!^^.  ..  :^....:. .. .^:^~~~~^:::7GBB##BP. :.  ^!^^.  :?~::^~^~~::^7JJ:    \r\n :. .^~::...::::.~~:   .!~      .::::~?:.:!7^..~.   .:: ..::^~!~:..   .~.  :  :^^~!??.  :!?J:.:^   ::::::~~~~!^.^!J~   \r\n  ..:..   ..::::::  .~7:::::~!7~::...:::^^^.  .:...   :!YPP5GGGGP5J7^....  ... ^~7~::^::?J?~  .~~...^~~. ^!!~~~~:~JY7. \r\n .. :   :^~77YPGGP7!:^::~77!~!!^^^!!^.  :...:~?JYY?7^.7JPBY^^..!~GB5?~   ...:^ .^7!:.~7^^!~:   .:. ..:^^:.:^~~~~. .77~ \r\n      7555J7^!7!7J57..^.    ..~7..~?^::. :7YPBGY77BPJ7777J5555YY55Y?7^^7JJ?!^.  .:::^^:....:.    .~!. ..:^^^^:::  .::: \r\n   ~5PJ!^: .~YJ?!~^. ^?!!7YPP^:!!!~:.   .?5B5Y: .7BPJ7^~~::~~!~~~!!!7JPGJJPBPY7: :.  .:~~^:~??~:...::.  :^~.::::.  ..: \r\n   ?GG!.   ~&5    ...!JJYGB&&!:::  .~:. :?5GPJ?JPPY?!:  ::  .  .::.~7YGG. .5BG5J. .::~?^.:!^^^!??7~^7^  .:.::::...::^: \r\n    :5PP7^..7YY!:.. ^J55PGB&#~:.  .  ..  .:~7???7~^:. ..    .  .   :!?YGP!~?PB5?:   .^7~^^!^:    .. .~7?PBPJ!^:.   .:: \r\n .:  .^7YY?JJ!~JP?..!!.:75BP:^~^. .!:. .~7?JYY?7!^:....    ..   ....:^!7?YYYJ?!: ..~: .^~^:?BP?^.^7..~PJ~~JY?YY7^:  .: \r\n ::.   .:^!JPBGJ?!: ..    :^~~^~7~.  ..75BGJ7!5GY?!:   ..       . ..:~!7??7~^.   .  .. .:^5&#BPP5Y! ..:!YJ7:.^!PP5~    \r\n .~::...::::::^  :7~^!??!^^^~^ .?!::.  ?5GGP:  YB5?!..::  .  .:  .~7?5PYJJ5G5J^ ..^:  .::^#&BGYJJ?:..    7&Y   .^5GY.  \r\n ::.  .::::.^~:.  ::...:~7?!:^~~^.  .:..!JPBPJ7PGY7!!!~^^!^~:.^~:!?YBY:  JYBPJ^   .:^!!!^:5G5J77?~. :~~7?5?. .:~7PP?   \r\n .::.  .:::^^~^:.  ^!.    .::...:^^::::  .^!?YY?!^!7JY55Y5555J7777?5BJ~JPBG5J^  ..:!7..~!:..   .~:.~YJ7!!7^!JY55Y:     \r\n ^77: .^~~~~:::^^^:. ...   .~!^:!7.:~7~. .^. ..  :?YGB!!:.:^7BPY7::!?Y5YJ7^...:. .:!!^^^~!^~!7~^.::~?YGGG5?7!^^.  .. . \r\n  ~YJ!:^~~~!!~  ~~^...^!.  :?JJ^.^^:^7!^..:.   ...:!JPPGGPGP5G5?~.  .....   ^^^:::...::^77!^:::.7!.  :^^:::..   ..::.. \r\n   :J7^.:!!~~~::::::.  ^:..?J7^  .!?!~^^:. .  .~^   ...~!!^^^:. .:.   .^: :!7^..7!::::..     :7:   .^~:.:::...::^^. .: \r\n    .?J7~::^~^^~^:^?^   ^^~!  .:  JG##BGG?^:::^~~^^:^: .. .:....:^.  :  .:^!!^:^^^!??~.  .....:....:^!^.:.:.   ::^:..  \r\n  :  :??7:.. .:::::^..:~^!J7:.^7.~GGP7?B&&GJ~^!7:..!7^. ..~!^^~!7^::::~7???7??:  :JJ?.  ^!:. .^^~:.::^~~^^  .^:::. ..  \r\n  . .~~^:^~.   .^.::::^P##J:YG:..:!:^JP5J7~^^. :~~^~^:...^!!:.:~!~~7YG&#5#&BG~    .7J::.:. .::^~..:~!~~~~^::~?7~~:^~^. \r\n :.:~!: ..^..^..^...::7GJ?^ P#.   ..:..:7~   :~!??7!^:..:^!!77:  .~75BBB!:PGP:.J^  ^^:^.  :~^::^:^!~~~~::.7YJ^......^~");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" 7G##5:   :.  :7??:.~~~~~~~^::~7. .:.~5?!!^. .~..!!  .!JJ~..    .    ...^?7^.:!J!?JJJGG! ?:5P^:.  :^.~~^^..  .:^^.:Y#B \r\n ^~~!^:.....^?Y?:^:^~~~!~.:^::^:.  ^^:7.  !! 7BG57^..  :7J?7~:.  .:^^~7??!.  ^~^..^: J&:.5BBY::::..^  . :^..:!!:..7PGP \r\n ....:^~:^~!?~.:^~~~~!~:. :~^.. .^^..~Y7:   .YGB#B5?!:^::^~~^:...:^~!77:  ...^77JJ..:^?!?G5J!:.::::::   :^~!7~.     ~7 \r\n      . .:::^.  ^^~~^::.:~^^:. .:^.  ~JJ?. .~7!~~~^:^77^..~7^...:^7!..:!^:!YGB#BB! ~!  .7:... .7!:::^:::..^?Y?. ..  :^ \r\n      .:~::   .:::.:!~:....:.....   :!7!~~^:.^7!^. .:^::::^:.... :~~~^~!!^:^!JY55:   :~?!:~:  .^^::^^^~~~~~.~JJ^       \r\n   ::. .^^::...::::.^^.   .!^     ......^7~:^~!:. !^^^    ...^^: ..  .:^.  :^~~~~^. ~JJ?. .!! ..:^^. ^!!~~~::^?Y~  ..  \r\n .. ..:^..   .::::^^^  .!?:::^^!77~:::......::.  ..:.:^7J55PGPP5Y?~:. .^^! .~7!. :7^!?7~   .:...:^~^. ^~~~~~^:~?J!:... \r\n ::..  .  .:~!7?5GGG5?!::.:~!!^^~~^^:!7^. .::.:~?YPPPPYP#5^7^!~J7BGY7~^:..  .^~~~~!:..::   .......:::::^~~^^.  ^7~^^:^ \r\n        .J55Y?!^!~~7JY!..~.   ..:~7..~7^..  ^J5GBB?~:PBY5PY??7!?YPPPPPPGY7^. :.  ......:~:.   :7:   :~7^::::.   .::. . \r\n       :YGPJ:. :JGP!^^. ^???JPGG^:~!~^:.   :JPB5J: :JGPJ7~7??J???JPB:.~PBP5J^.....^!~~~:7J?7~^:.~^.  .:::::.:. .::~^.. \r\n :.. .  :!JPY7~~^^?Y?:..!7?5G##5:^^:  ~?:. ^?YGPYJYP5J7~. .. . :!J5B5. ~YBGY7   .^77  !~: .^~~^:^~.:^?!^:::....::^. .: \r\n  .::^.  ..:!?YGBPJJ5~ .~.  .~?^^!!!^......7YPPY5PPY?!^  .. ..  :~7JPPYY5G5?^ ....^!!!~:7!.   ^: :YJJPBB5?!^..  .^::.  \r\n :. .:::....:::^!J!::^~::~~^. .^7. ^?~.   ^YPB57  JBPJ7^ .. . .:!?YP5YYPG5?~ ..77  .^^:?##B5?!7: .7YJ~^!~!YPJ!^  .  .: \r\n  .:~:^...:.:::::..  ^!.:^!7?J?^^~^!~:....:?YPBB~. PGY?????77^!?5G5! .?JBGY~ . .::~!~^:5BG5J?J!  ^:^5B5^..:7PGP^       \r\n  ..::.    :.:::7!^.  .7^   .^~^..:...  .:. :7YGGPPP5P5J77J?YP5YPB::!PBGPY!  ..:!7:.~!::..   !^.~JY?!~!^~7J555^.       \r\n ^::^^!!.  ^^^~^:::::.......   .::.:~!~~~^:   .:^~7YG#J?!~^~~?#GYPPPPPJ!^.::. .:!7::~^~:^~!~:..:~JYGGGPJ?7!^.. .  ..:: \r\n ...:~??~:^~~~~~^. :~^^...::   :!?!^!~ .~?~: ^~^: .:~?Y5PPGGPP5?~::::.   :::.....:::^7?7~^^::77:  :~~^:::.   ..^:.. .: \r\n   .  :JY^::~~~!!~. ^^:.. ^7.  !JJ7. :~^~~~^. .^^.   . .^~:...   :^:!. :~!~^^7~:.....     :!:   .:^..:::...::^^. .::   \r\n       .?J!.^~~~~~^^:::^.  .^^^J!^.  .J5Y?7^:^~7~~~~~^. .. .^::::::. .^~?~:.:!~~7!^   .....:....:^!^.:::.   ::^^..     \r\n .^   .  7YJ~..:^:^^:.~?: ...:!^  ^! :GB##B57^^!:..^?~:...^!!::^!?~::^~~~7!:  !JJ7.  :^:..::^~^:::^~~^^   ::.:: ..     \r\n !7.  .  ^?7~^:.  .:::::..^JYPY!?^:. 7Y?7~...  .~7!!^:...:^~~:::^^~7YG##GP:   :!J?..:^: ..:~~. .~!~~~~~:.^77~^:^~^.... \r\n YGPJ:..~!:..^^  . ::..:::7BBG^.GB..:: .~~  .~???!~~:.. .:~!7??:  ..:75GBY :7.  !^^~.  :::::^.~!~~~~:^:!YJ~.....::!~~^ \r\n P#P~.:~:.  ..:^^~::^  .::YG~7.:PBJJJJ!?!:.:!?~...         ..~?J7.  ~!:.~^ .^~~!Y!.:. .7!::^~~~~~~~:.7??~   :   .7##BY ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  .   .^^^~J     ..:7?77^:.^::::::::.:^?G#P^7GY!7~^::~7^ .^!:. .^...^:  ... ::YGBGP!^7:JG~::  .^.:^^^ .    .~: ^5#?..  \r\n .?JYGB#?.   :   ~JJJ~.^~~~~^~~^:^?~  :..!7^:^~:!~  .7J!:..   ..... :^. :7!:.^Y5?77: ?YPG^::...^..:.:^. .^!^..!G##~    \r\n ^P7^^~~::....:~JY7:^^~~~~!~..^:::.   :!^7^  .~ .:   .^?J?!^.     ...:~7J7^  :^~:7G7~G#GJ:::::.^.   .!^^!!:. ...~?^ .^ \r\n .:.....:^^:^~77:..~~~~~~~. .:~^....!~. .JJ7.  .?5?~..:^~~~^:....:^!7??^..   ^:~?. .7!:.:. ^~:::::... :?J?. .:  ^?~7!^ \r\n : .     . ::..:   ^^~~^:::^~^:::..:.   ^?J?^.:^~~~~77^..~?~:...:^!~.:^^.:!JY^  . .^?^~^  .~!^:^~^~!~^^^!J?.      :J7^ \r\n ~ :    ..^~::   .:.:.:7~:....:.....   .^~^^!!..:77~^^^^^~^. .. .^!!::^77~~!7^  .7JJ~ .^^  ..:^:.^!~~~~.:?JY!   . .7^^ \r\n ::.  ::. .^^::...::::.::.   .!:    .......:~~^~~~.      ...:~:. ....:::~77:.:~:!J?!.  :~:..:~~^  ^!!~~~^:^YY~  .   :J \r\n  ..:. ..:^..   .:::^~!^  :!7:^^~!7?7^:::.... .... .:^!7JJY5YYY?7^:.    .~!~:^7~::~^.  .::...:^~^..:~~~~~:.:7?!~^::::~ \r\n ::::...  . ..~!???PBGGYJ!:..:^~~::~^~::7!^. .:^^~?YPGP5J!Y7PYYPYBP5?~.  :...::.. ..:    ..^^...:::^^^^::  .~^::..^:.. \r\n :.^:. .   .7YGG7~!^::75J~.^7.  .:::!~.:7!:..  !YPGGB7:.!J~~Y^:!.:?PBPY7::^.  .::^:.~7!^.  :^.  .:!!.::::.   .:^..     \r\n ..:..:.::  .:~?Y?5P?!?5?..?7  :?PJ:~77!^.  . ~YGB?7..?PGPYY55PBY. 7GGP5J: .::^7~.^!^!!???!^^?^  ...::::.::.:^^^.:.    \r\n   .:. .:::.  .::~7YGP?!^:.....  .^!~:^7~:   .?5BG!..J#PY7~.:7J5#P..~5BPJ:   .^7^.:!^.  .....:^~7YGY7~::.   :::. .::   \r\n    ...::^::.:.::::...  :7~^!???!!^~~.:7~::. .?5PGGJ..?BG5YYY5GG5:.~7GB57..  .:~77!:!PJ^  ^J:.!P?!?PPJJ?~:.  .^.:. ... \r\n     ..:^..   ::::.~!^.  .^:. .^!7!::^^:.  .:^:7Y5BB?^.!^^Y7~?J..^GGGP5?. ...~7^:^7^:^..  !!.^7PJ:.:!!!PG5?:   . .:^:: \r\n ...^:.::^^:  .::^^^^::.. ^~..    .. ....:...:. .~?YPB5YY?P7?7755GG5J7^^:...:~?:.^^~:.^~^:...^JJPGBGJ??7!::    ...:^:: \r\n ^::^^^~~7?^..~~~~~^:.^~^:...::.   :^^.^7~:~!~:    .:^7JY5555YY?7~^.  ... . ..:^:^!??7~~^:!7~  :!!~^:::.   .:^....^..  \r\n Y~.  .  ^JY!:^~~~!!~  :~~^...^:   ~?J7^~^..!?~::..... .:~^...      .^~~^~~:... ....   .~^.  ..:..:::....::^.  .:.  :. \r\n ^^~: ..  ^YJ7~.~!~~!~..^::.. ^~. .JJ?^  :7!~^!?~^:~!^. .. .:~^^^^:^!?^..^7^^~~:   .....^:...:^!~.::::   ::^~:.    ..^ \r\n :!J~      .7J!^^~~~~^~~::~!.  :~^7~...  .YY7^.^^:.^7~:....^7!..:!?~^~~~:..7JJ~.  .::.::::^^::::~~^^.  .:.::...  . . : \r\n .~7!!~  ..  7YJ^....:::::^~. :..^?:  !!.^.   .:!?7!~:....:^~~~^::.~?5Y:  .!JJ~  ^!:...^~^.  ^~~~~~~:..!?~^::^^....... \r\n ^: .?!..   .~!~^~^   .::.::::!PBB7!P?:^~^  .!J?!^::.     .^~7JJ~.   .: ::  :?~~^.   :::^:.~!~~~~^^:^YY7:....::^^^^^P~ \r\n    .B#BJ:.:!~. .::... ^. ..::5G5Y..777YY!.:~?~ .::  ..:..  ..:!J?:  ^!^~~::~?..:  :?~:^^~^~~~~~.:?JJ7.  .   .~B#G5YJ^ \r\n   :^#G! .!:    ..:~^^.^:  .::PP:7^^YGBBP~:  ..  :^:..:: ..~!. .7!^:^^7!?PY^J#GJ^:.::::.:::^::^!77?~..     7!^^~:.  .  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" !??7~~^^^^~~!7~.       :JJ7^..   .:^.::::~B#BPBBG:^  .:. .::^~~~^^^^:::!7^.:::::::^!^..  .^:..:^       :!::J5P.. ^??! \r\n !7:..   :~^^~7     :~~??~!~^:^^:^:::^^..:~?GG??YJ:.:~:  .^:. .~^...:.  ..  ::7J5PPPG7::  .^.:~:^:.. .^^^.:YB&J.. .777 \r\n ...^JY5G##7.   :  .7J?J7.:~~~!~^~^::!!   :.:7. .  .7J!. .: ...::...~~. :!^..!GGYP##P^::::.^.   .!^.:~!:..:7JP!  .~??~ \r\n ..:~5~::^^:::::.:7JY!:^^~!!~~^. ^^::.  ..^^7?:     :!JJ!^:.  ..     .:~??~...:^7Y?~!:.::::::.  ..:7??.  .  :?!:~!^.^. \r\n .:^:.... .:^::^~77: .~~~~~~^. :^~~:...~~.  7JJ~  .. .^7!!~^.....:^!7??!^.      !^::   ~?^.^^^^~^::!?J!  .   .:?~::^:. \r\n ..~~ . .  .. ::...  .::~~::::^^:::^:.:.   :7J?~:^^^~^..^7~:....:^~~^~~: .   ^!J?.:^.  .:::::^~~~!~.:?5Y!:     ??!:::: \r\n 7..!.:  . ..~~::   .:::.^7~:. ..^.....   .:^::~?:.:~!^^~~:.... :~?~..:~^^^.^JJ?:  :7:...^~^ .~~~~~^:~~?Y:  .. ..^Y?:  \r\n ! ^^..  :.  .^^.....::::.:..  ..^.   ..::  ...:^^^^~.  .. .:::. :::^~7^..7~^~7~.  ..:..^~~~^  ~!~~~~^:!JJ~.... .7GBBY \r\n Y?^.:.:....:^.   ..::^~!7^. ^77^~~!7??7^:^::.  ..:....^~!7???7~:.   ::^^^~:.....  ..::....:^:::^~~^~:  ^7!~~:~~:::::^ \r\n ~?. ^:::^. :.   ^~J5PBBBGYY!....:^^:.~^~..7!^....^!7J5GBP5GGPPGG5?^..:.  ......:^.    :?:   :^!^::::.  ..::. ..   ... \r\n  !:. ..  .:^.  ..:^7JPBBPJJ~        .^7^.:7~:.. .7YPGPPY:.JP.:Y#GP5?~::. .:~~~^:7J?!:...^:. ..^:.::::.  ::~^..  . . . \r\n :^.:  ::. .^^::...::::^!:..~!^~!7!:.:^7. ~?^:.  ^YPBB?::5BBBG^.!GBPY!  .:^77. ~~^::!77!^!!...~^::::....::^. .::  .::~ \r\n : . .   .:~::. .::::::^..  :~..:^~?J?^^~~!^. .:.^?Y5GBP^.?G::?55GG5J: ...^7~..7~.        :?JYBBPY7~:..  .::.  .. .:!. \r\n ...   ....::..   :.:::!~:.  .7^    .:^......  .::.^7YGGGPGGY5GBPY?!~....:~?:.^~~:.:^:....^JYPBBBP5Y!^.   : .^:::^. 7! \r\n ~:::::^~^^^~7!. .~^~~^:::^^:....:..  .....:^^^^::   .:~7????7!~:...:... .::^^^!??77!~^~7~ .:77!^^::.    :^....^::.:75 \r\n JGGGJ......^JJ7:^~~~~!~. :~^^^:.::.   ^!!^^?:.:!!^:::. .:^:  .   ^^^^::.... .:...  .^:... ....:::.....:^.  .:.  .:! ^ \r\n  .75!..  :  .JJ~~^^~~~~~. :~^:...!^  .7JJ!.:~^~^:.^?~:. .. .^~~^~!^..7!::::..  .....^:.  .^7~.::::.  ::^~....  ..^^ ~ \r\n ::::~7Y.    .!J5J^.~!~~~^:::::.  .^:.!J7~.  ...^^^^~^:....:^7~..:~^^^:^7??~.  .:::::.:^^::::~~^:.  ...::...  . . :!.: \r\n .:~::~?~.   .  ~J?7:::~^^~^::77.  .:^7.     .:~7J?7~:.....:^~!!~....  :JJ?.  ^!.. :~~^^. :~~~~~~: .~7~^:.^:. ....:~:. \r\n .^.:!!^~?~  ..  7?7^..  .::::::..~~!Y?~:...:7?!^..     .  .:^!?J!:     .!J^^.:  .::^^..^~~!!~^^:^JJ?~::::^:^^::^5!^.. \r\n ~??!:  :5J!^...~!^.:!:   .^..::::YB&GYPGJ..:!^  :!....::.. .. .~??:  .  ~^.:.  ^!^:^^^^!!~~~.~????:  ..  .^G#BPY5!:.. \r\n !?7:  .^&#P~.:^^:  ..^:^:.^.  ::^GPGPP5J^:  ..  .::..:~: .:^:. .!::.7J?75G?~^..^^:.:^^^~:^^!^7J!~^     ~!:^!^.  . .~! \r\n !??! ..?GY~.~^     . :^...^.  ..:!~^::::::.:!?::::^^~~~~^::. .:.  ^.5BBPG#B?::::.::..  . :!JY~        ^77!~^^:^^~!??7");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" !?:!J7?JJ!!.:!~~^~?^7.  :  .77!^~:    :...:::^::::::^^^~^::.^.^~:^~:^^!^.::::..:.. .  :^  .~   .    :~^?!Y:..~??7!~.^ \r\n :~!7?7!^^:::^^~?7.:       ^?Y7^... .:.::::::^PGJ:^  :!^..:^^^::^::::::^~~::::..:...   ^::^^~...  ..~^.^5#G.:  !7?7!~? \r\n ~??7~. .  .~7^:~~     !YJYY^:~~~~~~~^::^7: .^:!P:..^.   ::..:~~^::::.  ^:. ::~7?~:::..:: .. ^:..:7~..:YGBY   .7J7JY?~ \r\n :....:!5YPGBB^.   .  ^????!^^~~~!~.:^::^^.  ^^:!:.7?~  :^....^^:...!^. .^...!G5Y^:::::::.  .^^~!7^  .  .!7.:!!^~^:.:. \r\n .~^:.^~Y^:::^:^::::~?J?^:^^~!!~~~. :~^.. .^^..~Y7:^?J7^..   .^.    ...:!?~.^!:... .7^.::^:::..~JY!  .   ~~7!~^^!~.  : \r\n ~~^.:~:.... .:^.:^~7~. :~~~~~~: :~^^~~. .:^.  ~JJ?..~?77~^...^...^~!7??7~:~?^^~.  .^:::~^~~~~~^:!Y?:^.   .^~7~~~:~7?7 \r\n ??::.~: . .  ...::...  .::~~::::^^:.:^^:::   :!7!~~^..^!^:......:^~!!~..7JJ!  .7: ..:^^ .!!~~~^:?Y55?.    .J~~:. ..^~ \r\n P#G! :~..  ....~^::  .::::.~7^.   :~....  .:....:^7~:^~!^......:~?^..~~^7?7:   ::..:~~^::.^!!~~~::^YJ^  .   .J#P!...  \r\n 5BB7 !..  .:.  .^:.....:::.... ...::.  ..::.. .......::. ..... .^^~~^!~:.:::  .::::^^:^~^..^~~~~~::^??!^:...:7?JYPP7. \r\n 5BY::~. ..  .^^..   .:::~!??^. ~7~^~!77??!^^~^:. ...:^.:^!77!~: .:. ...... .^.  ....:..:::::^~^^^  .~~^:::~^..::.!~^: \r\n 5G: ~:^. .^:  .::.  .:::~7YY~^:!^^~!7~.:^~^..?!:....~7J5PGPPP5Y7^~^.. ..:::.^~^.   ^!.  .^!7.::.:.   .::...     .:~:. \r\n .::^: .    ..^^^:..:.:::::..  :7^:~!7??7^^~:~7^.....7Y5PGBBBGG5Y?: ...:!!^~~^7??7!~::7^  ...::::.:...^:~:.    ...^::. \r\n ..~^.      . :^.    ::::.~7^.   ^~.  .^~~..::..  .:^~!Y5PPPGP5Y?!:...:~?^ :!^:.^!!~^:!^:^7Y7~:::.  .:::  .^:  ^.!. 55 \r\n .^^7:::..:~:.::~!.  ::^~~::::...::...   ::  ..... .:. .^!77!~^.:^... .:^~^^~???77!~^7!..:?J7!^::.   ..:^:  .. .:~.?GG \r\n .~YGJ?77^.:::^~??~::~~~~~^:.:~^::^::^:.  .::.:^!~~~^^. .:::. .::........ .:::.   ::.:.  ...::::.....^:. ...  ..~.:GBP \r\n   ..!5#P:   .. :?Y!::^~~!!~.::^^~^..::.  .!?7^~!. :?!^. ....:~!^:^7~:....::  ....^~.  .^!!.::::.  .:^~:....  ::! :P#G \r\n ^^.  .:^~?^     ~55Y?^:~~~!!: ^^:....7^  ^JJ?: :!~~~^:.....:^!~..:~~~7!^   .::^^:.::^^:::^~^::   ..::...  .  ..!.:^7J \r\n !J7!:^~^7!^.    ^^7Y?::~~~~~^^^::^:   ^~:J!^^!7??7!~:..::..:~!77!. !JJ7   :^:..^!^^~^ .~~~~~~^  ^7~^:.::.  . ..~^.:^! \r\n ^. .^!~^~~?~~.  .  ^JJ7...:::^:.:7^  ...~!.^??^...    .:.   ..^7J?~.!J7..:^. ..:^^..^^~!!~~^^:7JJ!^:::^::::::?!^.:^~: \r\n .:.::~:~7^.~7:  .  :77!^^.  .::::::.:?YPJ...^:  :7:...^^:.. ::. ^??:.!^^~.  :::::^.~!!~~^:!777J~. ..   :5BGP55?^..... \r\n ^7YY7J?:   !BG5~..^7^..:~. . .^..:::^??!^:. :^. ..:.:^~!:..::.  .^...Y7::. .!!::^~~~~~~~::J5YY?.    .!::7!:. .. ^!7?! \r\n 7!!!?77. ..J&G!.:~:.. ...^^~:.^.  ......::::^!^::::::^::^^^:...!:  ^:?GG~::::.:::. ...:!JJ!.      ..~J!^^::::^~7??7~^ \r\n ~.:7!??!...Y7?^~~.   .   ::  :^.    .:..::::.:7^^:~^.^~.:::^:~^^^::::::~::::..^.   .~^~77^  ..  !^!7:!~~^.!7JJJ7??:!7 ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("555PJ~:^~~!!.  !?7::!?:!7:    .:!~.:^^ .:..^. .:..:....:7~~~!!~~~~~~~~^^.  ..  ::^~.    ~^   ..   .^^!:^: .!??~^^:.~PBG\r\n!!!77:7J7JJJ7!::!!77:7~::  ..  ~?7~:^.   .^..::::::::::~~^::~^^~~^~!^^^!^.......::.:^..:^^ ..    ^~..JGG.: .7??7~.?5PY^\r\n  .^~7??7~^:..::^~7?...  ....^7??!:..:..::::::.:^^. ^7~.::^::.:!^..::::~^::::::.:. .^..^.::.. :!~:.^P#&Y    !???JJ?: :G\r\n.:~777!^. ...:!J~:^^     ~PGP5J.:~~~~~^~^::~?:  :: ...  .:..^~^^~^:::...!~: :::::::.^.   .!^:~!^. ..:~?7  :!!!~!7~^.  :\r\n!!~:....^7PY5GBG~.   .  ^??!7!~^~~~!!~.:^:::.   ^~~7^ .^!....^^~:..:~:  ..  :^. ^^:::::... :7JJ:  :  .?~~!!^^!~:  .:.. \r\n7~::~^:.:^J::::::^::^^~?J?~:^^~!!!~^~..^~^....!^  ^J?~..    .::...  :...~7~~:  .!!::^~^~~^^^~!??: .    ^!:7!77~:::~J7~!\r\nJ777^:.^!:.     ::..:^!!. .~~~~~^^..^~^:!~:..:.   ~?JJ?7~:. .^^  .::^~!?J^ .~:  .::^:.^!~~~~.:J5P5Y^    .?7~:^:^!????7J\r\nP5Y5?^^.~: . .  ...::. .  .::^~^:::^^:..::^^::.  :~!~^~!^:.......:~!7?J?!   :~...:^~^ :~~~~~~^~77Y?   .  ^:~7^    .~7??\r\nG###BG~ ^^..  ....~~::. ..^::.:7~:.  .!^...   ^::....:~!~:......:~7!^:~~^   .::.^!~:^~^ :!!~~~^:^JY?. .   .?##GJ!~  ^!7\r\nB###B5  ~:^  :~.  .^^:....::::... ..:.:.  .::::........ ....... ..::.....::..::^...::^^..:^~~~~. .!7!~^^^^:^^^^7G?~.. .\r\nJYY?!! ^:..  ..:.:^^::...::::..^  :?!:~77??J?^^~~^:. ...^~~~~~~:. ...... ::.    .~~  ..:^^^^:::  .::::..::. ...:^:::^~:\r\n?7^: ^7:   .   ..~::.  .::::.~~:.  ::....~7?7::~~^:. .:^!7JYJ7!~:.  :^~~^:!?7~...:::  .:~~.::::.   .:~...  .   :!~..^!?\r\n.!^:::::...  .....:::.  :::^^^~^:.  ^!.    .::.........:~~~!!!^:.. .:^~~^^7JJ??7!:~J^  :..::::...::^^:.:..  ...~ ^!!JJJ\r\n. ..^7PJ^^:^:^~^^~!77. .~~~~~:::^^::...::...::. ....:.. ....... ........:^::.  .:.::.  ..::::.....^^.  .^^  ^:~. JB###B\r\n7!^. ~!JG##Y:   . .7YJ~:^~~~!!^ :~~:~!^:::.   :~~::!7!^.......^!~:.....:^.   ..:!:   :~7^.::::. .::^~....  .::~ :PBB##B\r\n??7~.    ^7!:^  .   !Y7!~^~~~~~~^.:^~:...~^   ~?J?!!~^:......:^~!^^~~:   ::^^::...^^:::^~^::.    .::...  . . .~ ^~?555P\r\nJ7????!~:^:~7J.    :J5PPY~.~~~~!^.:^::.  :~. .?J7~^^:.  :^. .:~7??JJ!.  .::.:~!^:~~..^^^^~~~. .~7^::.::     ..!^.:^777J\r\n!!7J!:::^77!?^~~    . .??!~^^^!~^~^::~!.  .~~7!...:  ...:^.    ..~?J~  ^!:...^~^..~^^~!!~~^:^7??!^^^:^::::::?~:.:^~::^7\r\n ....  :~7^^!!!~?:  :  .?J?: ....::::^^..::. :.  .~:...^^^....~^. :?~~~.  ..::^^ ^~~~~~^~~!~7J~. .   .:PGP5YP?^.. ..^!!\r\n:   :~!~~!~!^. !?~... .^!~^^!:   .^:.:::::: .~!...:::^^^^~^..:.  ... ::  .?!::^~^~~~~~:.?5PGP!     :^:^J?~.... ^!!77!^:\r\nB~ .7?Y???7.   7&#G~..^!^  .::.:. ^. .:.::::::^~:::::.:!^.::^::.^7^. ^^:.:::::::.::.:~???~..:.  ...7?~^:...::~7??7~^.  \r\n:J55Y:^7??7: ..PB5:.^^.    . :^::.^:..:.......:7^^^!~^~!~:~::^^!::::::::::..^.   .^:~7?!  ..  .:^?:77!!:.!7JJJ???:!7!~!\r\nPBG7.:^~~??7:..~:!~~.    .   :~    .~^.^   .  .^^~~~~~~~~!!~~^!:..:.:..:. .^. :. :~:.^!:.    .77:7!::7J7. .!7!~~:~JP5Y5");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(":^:7BPY5PY.  ....  .:^:?!  ~Y?7^:..7~. ..:^^~^^.^   ^:..^!!!.~J555J~~JJJ777~:.: .:.  .   ..  ::.:^^.. .~??^.:...?GBY77!\r\n7PPPP55J~:~~!!~. .75J!^^7!^J^  .  .~7^:~~. ...:........~^^~~~^~^~~^:^~^^. .^:  ^:^~::^       .^^.?JP^..:7??7!.~5GB77#?.\r\nJ!^~~~7!:???JJJ7!::~~7J!:?.    .  ~J?!:..  ..::.:^:::.~~^^^!~~~~~~!!~~^!^...   .:.:~:^:.. .^^^..7G&G..  ~7??7?J!::JB#BG\r\n...  .~!???!^:....:^!?7...  ^^~^!J7~!^::^^:^:.:^^..~7~:::^::.:?!^.:::^:!:.::::..^.    ~^.:~!^...7J5Y   :7?77J7~:  7GG##\r\n :^:^!77!~: .:.:~JY^.:.     7PYGPY^.~~~!~^^^^:^7~   .. .:::^~^:^^^::::..7!:.::::::.  ..:!??:  .  .77:^!~:^^.. ..    !##\r\n!~!!~^.....^?PY5PG5:.   . .~J7~!~^^~~~~~^..^^::.  .. .:!:...^^:~:..::.  .   ~?^:^^^^~:::~?J7. .   .^7~7!7JP7:  ^^.. :55\r\n7JJ7^:^~^:.:~7::::::~:^^^!??7^^^~~!!~^^~7^:~~: ..!~.  .   ..:^^:.. .~^. ..  .:::::^~~~!!:.7YY!!~.  :^:77~~~:^!7?Y7?7^7J\r\n:J5J777^:.~!.      :..::^7~  .~~~~^^:..~!^.~~^:.:.   ^!~:  .^^^   ...   ^7....^~^ .~!~~~^:?5PYY7.    ~J!^:..:^!77?77:~7\r\nJ!!PP55J~^ ~... .  ...::.    .::^~^:::^:...::^^^::...:^::........^!7~.  ..:.:~~.:?~^^~!~~~^^^7Y!  ..  .:YP7.    ^7??!^.\r\n5!?5PGGPP^ !.:    .::~~::...::::.^7~:   :7: .   .^^: ................:..::^^:^~::~~. ^~~~~~~:~7J7:.....^YPPPPY~..:^!?7^\r\n5YJ??!^..^~: . .  ..^^^:. ::.:::::..   ....  .^^^:.................  :^:  .:.....::::::~~^^:  :7~^^:^!^:::::J7~:....:~!\r\n?7^:!~^..^^..     . .::.   .:::.:7~:   .7^   .:^^..........:..........^^:.   :7:   :~7^::::.   .::. ..    ..:^..^~!::!7\r\n!~:....:~~J:.::.^~^:^^~7^  .^^^~^:::::.......  .^:  ..................^^^:   ...   ..:::::::: .:^^~..  . . .~^:.:~7??Y5\r\n^7?!^:..^YPPP5Y~....::7J7~:^~~~~~^..^~^:^^:^^:::.:................ ::^.     :7^   .^7~.::::...::~~::.    :.! .55GGP5J!5\r\n.^!?J?^. . :7P5^.  ..  ~Y?^^:~!~!~^^~?^.~~:.:..   ~!!^:.......::::...:::^^::...:::::^~^::..    :::..  .  ..! :!JPPPP!~Y\r\n7~:!7?77~^...::~?7     ~YYP5?^^~~~!~: :~^:...!~   ...   :^^.  :~!^.  .::.^^~::!~:.:^^^~~~:  ^7^::..:.     .!!..:!77J5Y^\r\nY?^7?7YJ7!~:^~^7?:::  .~7!Y5?:.~!~~~^:::::.  .: .:~. ..::^:..   .   ^!:. .^~:^7~^^~!!~~~^^!7?7~^^:~^::::.!~:::^~^:^7JY7\r\n55^ .:^^  .!5Y7!7^7^.   .  7J?!:::~^^^^::7!.  .  .::..:~:^~. ..!^. .:   ::^^. :~~!~~^^~~~!J7: ..  .:JP55JPY~:....:~!!~7\r\n##J     . ..^^.~!~:!?.  .  .??7:..  .::::::.:!7:..:::^^^::~^:.:.  .   ^7^:^^^^~!~~~.:JPG55J     .:.^YY7^::. :~~!7!~:^: \r\n##GP7. .~7J77?7^.  ?5?!:..:!~:.^!.   .^..::::.:!^^:::.:!?^..:^:::^7~..:^:.:^^^^:^^!~!J7^~~~   . !J!^:.....^!7??!~.  .. \r\nB###Y^:~J??7?7!  ..5&BJ..^^^. ..:^:^:.:.   ...:!^~~!!~~~~~~!^:^~!::::^:.:^..  ...~?Y!. .     7^~J7~~^.!7JJJ??J:~!~^^:^7\r\n.!#Y~GGP!.~7??7:...PYJ::~.       ^^:~~:^  .^.  ^^~~^^~~^~^~~~~^~........:. .  ^~:^7!:  .  :J~~?^^!JP?: .~7!~~^^?5P5PPP?\r\n~!?JBGY...::^??!. ..:~:::.. ..   .  .:: :::^7!!JJJ~^?Y5YJ!.~!~^. .^   :::^^^^:.. .^7..::!7J!. ~?::^..   ..   ?P5J5BJ:^^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("..  : .J#&&#&J     .:^!!7?J.   7##B! .!:.  ....:..:.^77~:.....777?:   ..  .^:!~.   ......~7..:^:.. ^??^     :5GY~~^?!. \r\n~!!^~:7B5YYPJ. ...  ..:^^.^?:.^?!^:...^7:..::.:^. .~^::~???^!YPY?GY~~!!~~!7~::. ..   ..   .~^7!!^ .^??7~!.:!PBP7P?. :  \r\n~ ~?PGPP5PJ^^!!77!. .?GJ~7!^J^7~  ..  ^77^^!.         :^^~~^:~~~!!^:^!!~.:^~:..:::...   .^~..JB#::  ~7??~~7YJ7~Y&G?7!:.\r\n~J5?^:^^^!~:???JJJ77:^~^!??:7:      .~JJ!:... .::::..^7^^~!!~~~~~~~!~~^~.  .   .. ^:..:7~..:YB#G.   ~???YJ7^  5#######B\r\nY5~ ..  .~!??7!^..  .:^!J7    .7!~7JY?:^~^^~~^^^::^~~^^:^.:.:!!!^.^^:^^7:.::::.  .^^~!7^. .  .!?..^!~^~::::.   .^?B####\r\n.:. :^^~77!~~: .^:~?55^... .   75?5PJ~:^~~~!~.^^::^^: .::^^^:^!~^::::::^7~:.:::::...!JY!  ..  ~~!7!^^~J7^   .   .B####G\r\nJ55?!!!~:.....~JPJYY5J:.   . :7Y!~~^^^~~!!~^..^^:.. ..^:. .~~.:~:..:.  .^~^:^~^~~~~~^:!J7::..  :!.JJ~~J7:..^7~^^.^??JPB\r\n..:!JJ?^:^~^:::^!:.:.:^~:^~~7?!~^^~~~!!~::~J7.:~^...^^. ...:^^^^...:7~. ..:^^ .!!~~!^.J5GJ!Y7   ..77~^~:~7??JJ7Y~~55PPP\r\n:~:^YYJ7?7^:.~!.      ...::^!^  .~~~^^^:..~~::^^:^::.      ^^^:     .::..:~^^^^^~~~~~:^7JJY7   .  7^~^.   .:!7??~^^:.::\r\n^^:~PJJ7!!. ..~ ....  ..:^:.   .:::^~^:::::...::^^::^::....:^:....  .:^::^~..??:.^!!~!~^:^YY~  .   .J##5!:: .~7??!.  ..\r\n:^7JY7^!7^:.^7:       ..^:.    ^.::.^J!:   :?:     .^^:. ..  ... ^~^:::^^.::::~^..^~~~~~:.:7?!~^::::~~!!YG?^...:~77~.::\r\nJ777~^..^^:::^~.....:^..::^^.  :::^^^^::...:~..    .:  ..     ..  ::    ..^:...:::^^^^::  .~^::..^:.....^~:::^^..^~!7!?\r\n.:.~77~:...:7P5!~~~::^:^~!?7:..~~~~~^:.:~^:::.:^:::^!^. ..  .....^^.     :J~   .!?!.::.^.   .:^...      .!^.:^77^7YJ?~^\r\n :  .~??7~. :^!5B#5:   .  ~JY~:^~~~!!~.:7J..~~:^^::  ....:::....:^^:::^::...:::::^~^:::.    :::..  .... ~.. .~!7JJ57:^^\r\n::.:^^^7??!^.   .~~:!. .   ~YJ?7^:~~~~~~^~^^~^..::.     .^^^.     .::^^^^::~~:.:^^^~~~:  :!^::...      .!~..:!?7JYY^:~^\r\nPPP55!^J7?J??7~:^^~7?:    !5!?GPY::!~~!!: :^:.. .~7^...:^^^:... .:^...^~:.!Y~^:~!!~~~^:~!?7~~^:~^:..:.~~:::^~~^^7JY7:..\r\nGGJ??~.:~~?~..:~J~~?J:~~  ..::7Y7:^~~~~~^~^::^^.  .:..:~:.^~. .:~:. ..:^~..^~~!~~^^^~^~Y?^...  ..75YJ?5Y!:....:~~!!?55J\r\nP#####:   ..  ^7Y!^^!!7^~   .  ~YJ!...:::::.:~7^::::::^^~^:^^^::. .^^:::^.^!!~~~:^?5PJ5?   .. ..:5PJ!^^: .^~!!7!^^: .:.\r\n&####Y^.   .::::^^^!~..7!.  .  ^7!~^^.  .::::..!^^:^^.:!!7^.::^::^^!~::^~~~~^~~^.7YY?~!J.    !Y!^:.   .:~7?J7~:  .: :Y5\r\nB#######P. :7?Y??J!.   5BG5^..~7:..:~...   .  .!^~~!!~~~~~~!!~^^!~.:::::. .. :~JY7:      .7:7?!^^^:!7J?????:^!^::.:!5Y!\r\n.:!?JG#P~!?J?~!??7!  :.B#5:.^~..  ...^::...~^:.^~!~:^~!~~~^^~~^^^         .~^^77~  ..  ^7^J^!7~?G?: .~?7!7^^?PP5PGGJ~.:\r\n  : .!G75BG?^.~!7??^..:?!7^~:    .   .. .:.^7!~!!7!^JPJJPY7:7?7~::^~.  ^:.::..:7~....:^7~.:?~.^^^:.  ... .75YJ5BJ^~^!!!\r\n .~?~~~JGP~     :??~ ...^:..!~......   .~!:^:   .   :??7?:...::~!?~..:.::...  .:!: ~G##Y   .??7!!^:.     !&&&&#Y: :. :.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(". .^~^   ~5&#BYY!7?7:  ^7?Y???~   .J&B^ ^7       ^7.:.   .    .^^:.  ~!. :!5P~..^~: ^7!:..~!:..:?J^ ..  .JPJ^::!7.  .  \r\n.  .: .. :5#&&&#~      ..:^~!77.  ^GGGJ: ^!:. . .:.~!~. ..   :~~7^    .    ^.:~:    ...:^~~.^..^??7:^...?GBY??^::. .~~.\r\n:..!!!~!^YBYJJY!. ...  .:77!:.~?:~?^ .  .:!!..^^..~^~~!J?7~!JGJ:7GJ^^^^::^!~:^:      .~^.!5B7.. ~???!:^5PP7~&P~:^.  .^.\r\nJY?:.!YGGP5PP?^~7!??~. :?G7:!Y~~7::   :  ^??!:^:  .. .:^~~::!777?7!:~?77^~!~:.:.. .~!^..?B##:   :7???J?!. J###&#BGY!^7~\r\n!?!7Y5!..::^~^^??????7!:^^^!7!~~~  ... :7?J7:..:....:!^^~!!~~~^^~~~~~~^^. ..  ^~:^~!:.. :^7Y: .^!7!~7!~:  .!JJ5P5B&&J?!\r\n..^YY: :.  :~7J?7^:.   .:^!Y~    .5!:7P5Y:.~~~~~^~~:~^:^:^.:!~~!^^~~^^^7:... ...~?J!  ..  !7~!!~:^!^.        :5B###B7. \r\n^...:. :^~!7!~^^. :~~7YG5:.. ..   ?Y?Y5?^:~~~~!~.:^::::^^^::!!7~:.:::::~:~~^~~^^^!7J~ .    .7^JJ^:JBJ:  :... !BBGB#?. :\r\nPJ?J55?!!~^.....:!557?JY7..  ...^?Y~^~^^^~~!!~~^.:~^.....:~~. .~^:::::::^..~!~~!^.7YP?^~?^ :~:~?7^~~.^^~?J!7~:!?YYP5!!~\r\n... .:!YJ?^^~~^:::^^....:^~:~~!?7~^:~~~~!!~:^~J7. ^~:.....^^::^^......^~~..^~~~~~.^YPY!7?.    ~J!^:::^!77???7:7J?Y5PGJ~\r\n:....^!YJ!!7!!:.7!:      ...:::!:  :~~~^^::.:~~::^..^^::. :^^^:..::.:^^. !5~~~~~~~^^~~?Y^  .. .::?J^    .~???~^.    ~5Y\r\n?J55J??7!^.~~^:.::...   .. .:^..   :.:~~::::::....:::::^!~:~!^^:::^~^.:^.:!~. ~!~~~~^:!JJ!...  .^PBBGJ7^ .^!7?!. .~ .?P\r\n..:^..!7!^.....!75^:::::~~:~^~7^  .~^~~^:::^::....::..:~?:   .?!:..:::...::^:::^~~~~:  :7!~~^~~::::::5?!:.. .^!7!:.::..\r\n5J. ~: .~?7!^. :?YPBBP!......~JJ7:^~~~~~~. ^!:.:^.:~^::^~^~~:^7^:::::.....:::::~~:.:   ..^:. ..   ...^:..:~~.:!!???55J?\r\nYP!    .^~7??!.    ^JJ^.. ..  :YJ~~^^~~~~~~~5?  ^^:.::...^^^^..::^~..::.^~^..::^~~~:  .~:::. .      .~7.:!!?!~?Y7~....^\r\n~JGPYY??7:!?7?77!^::::!?7    .7?!JPY~.~~~~~^..~~^......^^::^^.....:~^ .~Y~^.^!!~~~~:^^7?!~~:~~:....^^::::~!~^7JY7:.....\r\n~!7YPYYJ7:~?!JJ!^^.^~^!?~:~: ^J~^7P5?.:!~~!!:.^:::::::^~:  ^~:.....^~^.^~~~!~~~^^^^^JJ!... ...~J??7YP!:.....^~!7?55Y?JP\r\n:. !BBGGG7 ...:  .7B5:^?Y^!:    . ^J7!^^^~~^~~^^^::::.:~7~!::^^^::::^:.^!~~~~^:7Y5JYJ.  .. ..:YBPJ!~^ .^^^!7!~^:..^...^\r\n .!G####G~        .^!^:^!!~!7  .:  ~JJ!. ....::7~^^^!^^!~~!^.^::^:~:^~^~~~~~..J5P?:~P^    :Y!^:.    .^!?J?!:  .^..?5~. \r\n^?7&&B5P5??!.  .^~!~!!!~. .J7^: . :~!^:~~. ..  ^^~~~~~~^^~~~!!~^^!^.:..:..:!??7^....  :~~!77~^~:!7??????^:~^:...^Y5?!7!\r\n~?~!5GB#&&##5. ~?JJ???^   .B&#Y:.:~!. ..:.:~~~:!77!:~7?7!!!^:~~^:.  .  .^:!??~  ..  ..!!^Y7:!PJ: .~??!7!^7PP5PPGY7..?YJ\r\n.^.  .^:^5&7~5PP~:!???!  .^#P?.:~:      .^:^!~^^^^^^?GJ^?GY7^7?J7^~^~:.:^:.~!:.    :?!:?!.:!7?~.  .... ^JJ?YG5~!~!!!:.:\r\n.^!. .:.:7JJBGY:..^:!??~. ::~!^^..     :~^.:.   .    :7~~^.  ....~!~... .  :!~ :7PGG!   !7~~^:...     :#&&&#P^ .. ::  .\r\n  .  .77::^?GY.   . :J?^ ..~~...!7~ .~~..^Y5!:  ^~. .:^^.    .   .^.7~.      !~ :G&P.   ^?J?YJ7^  .~7!~JYB#&G~   :~^.  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      :~^. .J7B#GYG##&&#5..~JJ7777!. :.PY7~~~ .!: ^GBG5~:~!?!~7J77?^~?~...::!JYJ?^.^^^~!^..:??^ ^~  ^J5!.^~^~  ..  .   \r\n  .. .^~^   ~5&#BJ7::^^.  .~7J??J7.   !#&5. !: .~!.:^ . .::. ::!7^:.^?~::7PBBY^.77:..:^:.. :??!.... :YGG!7~!!.. ^: .   \r\n   .  :: .: ^5##&&&~      .  .:^^?!  :YYJ7^..!!:.:~^^   .   ..~!~.    .   .~:.^:. :~:~?J?...!??77:.?GBP~GP: ..  :!:.^!:\r\n:~~:.:!~!~7!YGY???^.....  .^YY7~::77^J~     .^7^.:^7!!?7!~~7PJ::?5~.......~^:~^::^^.:Y#&!.  :77?!77J~^!Y##GP57~:.^:.:~~\r\n^!JJY?:.!YPPP55P?^!?7JJ!...?P!.:Y5.J.    .  :J?7:.. .:~!!:^7JJ?JYY7:7??7!7!^..:!~...!Y5G^  .~??7JJ!^  ~PBB#BGG#BYJ57:.:\r\n^~7~7!?5Y^....^~^^????7?7!:^^~77~!~~..::^:^??!!^::^:!~^~~!~~~^:^~^^^~~^:  .:~7?!  ..  ~?^:~!^:^:....      :??5#&B~^ .^^\r\n::...^J?. ^.  :!7J?!:.    .:^!Y~    .P7.:PG5!.^~~~!^^^^:~^^~~~~~~~!~~^~!^^..^?JJ:  .  .^~!!!^^?PJ.   .   .B&&&#G7.   ^!\r\nY~~~:..^:..^~77~^::. ^!!JPB5:.  ..  .?YJ5Y7::~~~~~^. ^^::.:77~?!..:::^:^~~~~^.~JY!^^:. :J^YY~.^YJ:  :!^:. 7YJYGG^.::::.\r\nY5GGJ??YY?7!~^.....:!5Y!77?~... ...!JY^^^^^~~~!!~^7^:~~^^~~.  :^^^^~~. ^!~~~~.!5GY.:5J. .::!?~~~:^77?YJ7Y~!55P5P5J!~~!:\r\nJ5GPY7!~7YJJ?^:!7^:..^^:...:^~:^~!?7^::~~~~!!^.:~J~. .^^:^~: .^^:^~^.!7^~!~~~^.~J5YY7     .J~~:. ..:~7?77^^~^^!!Y5?:.JJ\r\n^^~:.^J?^!7~^..::::^~!.....^!^.::^!.  :!~^^^::.:~^::^..:^^::^^^^:...  J7^:~!!!!^::~YJ:  .   .JBP7... .!?J7~.  .  ?G5~!7\r\n:..^7^ .^.:!?!^....7PPJ?77:.:::^~??~::~~~~~^:.:~^^^~::^^:::::.:^^::~^^^~:.:^~~~~~::~??!^:...:7?JYPP7:...^!?!:.^: ^7~..:\r\n7!~YGJ. .  .~7J?!. ..:7P#5:   .  :?Y!::^~!!!~:^!Y.  ..:^^^^:::^:..^^:^~^::::^^~!^  .!~::.^!^.....~7^:.::..^~7!^!?^..^^^\r\nJY:.75Y!~^^~^:77?7~:.  .:^^?:     ~YY5J!.^~~~!~^7!.:~^:^~: .^^:^^.  :J~^.^!!~~~~^::!?!~^:~~^....:^...^77:^7JJY?!!7Y5GPJ\r\n:!~^~J5P5PP57^J??Y??7~:~~~77:..  7P^.?G57.~~~~!~. ~~^^^^^  .^~^^~~:^7~~~!~~~^^^^:JY7:.. ...^77!~JP!^.....^~!?JYY?7JGGPY\r\n.::::.:PBYJJ7..^^!^  :7Y~.^YY^?^ .^^~!YY!.^!~~~~:^^::..~7!!7:.::^^..^~~~~~::!J5YYJ.  ..   .Y#G5?7!..::^~!7!~:.:^..:~!~Y\r\n~^   .~P#&&&#^       .?PJ^^!7!!:.   . .?J?^..^^!~^^~!~~~~~~~^:~::^^^!~~~~.~YPG~.!P^    :Y!^::    .:~7J?!^. .~..7J^. .:^\r\n^^. :~P&#PJJ:      .. ..^::!!:^7!  ..  ~?7~:.  :^^~^^^~^:^^~~!!~~^!^^::^!~7J!^~^^:.^~~^!7~^~:!!777???~^~^... :J5Y!!~!~^\r\n:.:!5JJB#GPBBBBP~  ^!?J7??!.  .P5J!...~!^..^!7~7???:!JYJ???7^.~!~:. ..:!?J~  .    .J.Y5^.^YJ:.:~JJ7?7^7P555PP57:.?YJJ7^\r\n^~^.:^.:~?5PG##P7:^???!?77:  .:##P~.:^:::^^^~:......^5Y::?G?~^!7?7!7^::^7~.  .  ^J^!7^:~!J5~:  .:...:7?7JG577!!~!^::~~:\r\n^!~..!:   : .Y#~YBGY:.77??7...!5?!.~^ .:^:.^.   .     ^!~:.   .   ^~~:..~7..:!?JY^  ~?^^^.. .      :#&&##P~ .. ::  ..  \r\n   . :^  .~~~7!PB5~ ....!??^ ...~:...!?::?BBP?:.~?^.:^~7::  ::.   .^ ~!. :7 .Y#&J.   !J??J7~:  .::..!JB#&G~   :~^.  .  \r\n   .   .  ~^^^.!5J^  :^ :J?:..:!!^:^.^7J5Y?^^:..^?!^777J7~!77~^^JPGG~ :!. ^!^7JB.:  ~7777JJ!. JB####GJP#B??^ .^~:      ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  ..   .^?!:::!5JJJ5GB#####P:!J57.^?7?7^:..~.~~75P?!.   :J~..YJ7^JP7 :!?J^^:::.^^:......!?^ ^!  75Y^.!?~^....       .  \r\n         ^~:. ^?JB#Y~7PGGBGJ: :?JJ7?7!. ..?#J^.. ?##GY~::~?~^J!..~J^:!!:    :~~!~: ... .7?7 ..   7PP!^^~?:. .. ..   .  \r\n.~.  .  .^^.   ~G&#BY!       .:^!77?J^   ^###7 .: ~~:: .~~:.^^?5?!^^!J~::?PB#G?^7!!^7..:!??~!^.^JGBJJ5^..:  ^7:..^.....\r\n .   ..  ^: :. ~GB#&&#:        .:^^.:?~ :77^^...:~::   .    .^^~:.   .:  .:?~..  ~P#Y.. :77?7~^YJJ7~##Y!!^.  .:.:7~~!!7\r\n.~~:!!^:^~^!777PGJ7?7....:.  ^!P?!^!!^?~!!. ..  ^7?7!!~^::^Y?:::??.   .  .^:::..!GB#!   .???JY?!. ~B#&&&##B577J7^:::~!7\r\n ..^7JJY7.:?5PP5Y5P7^7?7JJ~:..?Y^.:7G!!~       ^JY7:^!77:~J5Y??7YP?^7777!77!:  .  ^7~ .!!^~^^^^:   .^~~~^:J##?J?:..^?~:\r\n^^:^~!~!!Y5J:  ..^^^~???777!~:^^~?!^~~~::!~^!?YJ:^~^^^~~~^^~^::~~~^:~~~::?JJ.  .  .7~7!~^^7?~         .?GB###7:  :!^.  \r\n~^~^:. .^?! .~. .^7?J7~..    ::^!Y.    ^P~.:YGY!:^~~~!!!~~~~~~~~~!!!~~~~^^~?J^..   .?:J5^ .7#7:  ...  J####B?. .  ::.  \r\n~?5Y!7!::.~^.:~!7!~:::..!??5B#Y.   ..  :JYY5J~..^!~~~~...:77~!7~..^~!~~~~.!YP5::7?:.7!777!^!!::.^??~!::!7JYGY^^^~!^  ..\r\n!Y577J7^?PGY7!~:.. .. ^~P7^~~!^:.....:7YJ:^^^~~~~!~~~!7::^:. .~^:^::~~~~~:.!5P7:7Y:    ~?7^^^^!7J?J7?7:?55P5PPJ~.~!^^~!\r\n^^^:. .:.....^77~:. ..~?G~.....::^!7??7^^:~~~~!!^.:~J.   :.  .:. .77~~~~~~~:^!?JY:  .. :^^!~.   .^!??7^^:...:?5?:~5JJ7~\r\n^^!~^^7P5: ^:  ^7?7~: .~!5B#B!.   . :JJ?::~~~~!!: :7: ..  .^.  .. .?^..!!~~~~^:7YJ^ .   .~B#B5!~. :~7?7~. .^ .YG?^^~!^^\r\n^7JJ5!:?5?: . .^^!??7^.   .~7^:: ..  .JY7!^:^~~~~~~77.  :.  .:   .?!^ :!!~~~~^:^!??7!^::..:::^GJ!....:~77~....::. .:^^:\r\n!!^~!!.^?PP55YYJ:!J7J??7!^^^:!?7    .??^!P5!.:~~~~~^:^:^~. ..^:.!!~~~!~~~~^^^:7Y?^.....::~~^:~G!^ ... .:^!7JGP?^!?7!5Y7\r\n .  ^!~^~^JGYJ?7::!~??~:::~!^~?!!!!.:??:.YP57.~~~~!~^..~7!~!?:...^~~~!~..^?YYJJ^   :   .?#BPY?7:.:.:^!77!:.:!:::!7!Y5J~\r\n  .::  . .!B####5  ..:  .!#?. :55:?.  ..:^JJ~:^~~~~!!!~~~~~~~~~!!!~~~^:~JP5^.^P~    .Y!^:^.   ..^7??7~. .~: ~?^. .:^~~^\r\n  .^7:  .!B##BBY:         ~??~^~~7~!:  .. .?YJ^:^~~::^~~:.:^~^~~~^^~~^:?YJ7~~7^:^~~^~?!^~^~!!777??!^^^.   .7557!~!~^:~^\r\n.~?~...!Y!##5^:~^^:.   :::::~^~!: ^?~     .!77!77??^755???J5J!:!7!^:!JJ!.      :7^GJ^.:?J:.:~JY7??~!55Y5555J^.!YJ?7^.. \r\n!!!^::^?J?75B##&&&##7  ~?YJ7??:   ^#BG7..:^:^.  ..  .7J:::75~^^~~!!7?7^  ..  ~!^J^!!:~7P?^  .:.:..~77JPP??7!~~~:^!!^~!:\r\n?7!~~7^.:: ..^77YB#7!?JY~~!?77: ..7&G7  ..:7^.  ..    :~^~.    .   :^~^...::~7^.^?^.^^^.        .G&&#BG7..:.:^. ..   . \r\n..:..^:.:7~  .. :557BB5~.:!~??7:. 7~7!!^!P#BGJ^.^?7:^~7Y?^^..~~. ..^~ :. !B##7   :J?77!^:.       ~YB#&#!.  .^^.  .  .~:\r\n  .    . .. ..7!^~~PGJ.  .. !??. ... .~7!!^    :~!^:J!::!J^~?!::^JG##J...:J#P.. .~7?7JJ?^ .?5BGP57^?##Y7~ .:~^.        \r\n  .        . .^^7!.^Y5?  ~~ :?7:......^~.:::::7J!^ ~PY^~?5: ^J^   .!?P57!~:~^ ::7???~.!5J!:5######BPJJJ57:.:~?~.   ..  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  ~Y!    :~!!!~..:^:^:.::^~~!P&^YBGJ.:!^!??7.  :^:^^!!7JJ?7. .  .   .^?J7J?!~?7~^::^~^. .:^:JB5^^JY7~^:.   .~.  .    . \r\n  .. .:   .^?!:.:!PJ7YPBB#&&&##?.!?Y~^7??7^...YJ!::    ~J~: !JJ~!J?: ^!JJ!~!!!~7!~^^7?7 .^   !PY^:^^7:  .  .    :.  77:\r\n^^.         :~^. ^7Y##7..~?JYJ!: .!?5???!.  .!&BB#BP?^..~?^:Y!. .!5^.~!~    ...^^  .7??^::..^5BG?J~^^:. ^~. ..  .    ^7\r\n^  .~.  .  .^:.   ~B&##P?        ..:^~!7?.  .GBBYJJ!!..!7~:~^?YJ?!~^??^.:7J5PGGBG.. :7??7^.?PG5^P#!.:.   :^.:?~~~^~!7?Y\r\n7^: .   ..  ^^.:. !GB##&B.   .    .~7!^.~J::?!..      .     :^^~:.  .~: .~?PPB#&J    !7?7J??^.^G####BG57:^!::^::~7???77\r\n!!~:!!^!!^^~~^!7J?PPY77~..::^.  ~?P^:.:J7^?:^.  :  .:.:...!7~^:~7:    .    ..^7Y7  .~77!7?!^.  !Y5PPY?YGB7?G7..:!!!~:. \r\n77^  .^7JJY7.^J555YJY5!~??7YJ!^..??^:^!PY^7   .. .~?JJ?^~YP5!77~5P7^~~~^.  :  :?~^!!^:~~.  .        ^^7B&G~!..::~~.    \r\n~??~~:^~~^~!55?.   .:^^!??7!!!~~^^^!?!:^^:::~7:~55Y~.~~^:~~~^^~77!^:77?J7. .   .~~!J^.^75!..  .   :G#&&#B?.   ~!:  .   \r\n~??7~!~^: .^7! .~. .~7??7^..   .^^^~J.    :P~.~Y5?~:^~~!~~~~.:~~~~~~~.^J55~~!^..J~5P~. :55^  :^.. .YP5PBP: :....      .\r\n7J7~!7?!^..  .  .!??!^..:.:?JYPB#J.   :.  :JJYY?^..:^~~~~!!~~!~~~~~~~:.?5P^ ^?7..^^:7?~~~:^!!?Y?7?^~JY55PJ?~~!!. .:    \r\n7!!^::::..!J! .!..^77~:...7PB##BG~.     ^JYJ::^^~~!~~~~!^7^..~J~~~~~^:..75PJ??.    .Y!^:..::~77?7?:^7!7?JP57..J?777~~!:\r\n: ..^7???^JPY.    .^!?J7^    :?GJ..  .. .7Y!^^^~!!~~~~!Y.     .J7~~~~!!~^^^!Y7. .:  ..7P?:    :7??7~.    .JPJ^????^.. .\r\n:!~~777?J:.!5PJ?!~7~:77?77~:...:^~J^     !JJP57..:^^~~~^J~..:!^!~~~~!!~~^::?YJ~     .^PB##G5?...:~77^..~: !Y7:.:^::^~~7\r\n    :. .!!~~?J5555Y7^??7Y?7!^:~~~77^::..!J^ :PP?:.~~~~~~!!~~!7~~~~^:..:7JYJJ~   :   .7#BG5YJ~:...:!??7.  .  ..:~77!~!J?\r\n:      ....: .YBP55Y. .:^^  :JP^..~5P~?:.^!~~YPY~.~!~~~~~:.~~~~~~~~:^7557:^P~     J~^^~.   ..:!??7~. .~: ^7^. .^~!~!??~\r\n   .  :!!   .!G#&&&B~       .~P7^.:J7^!.      !J777::~!7~::^~~^^~~.^YPP!:!!^^:^^:~?!^^^^~~!!7??7^^^.    !5P7~^~~^:~~??~\r\n.   .^~::. ^~5&BJ~~      . .  .~!:^!!~~?^  ..  ^~~!~!5P!!?!YPY!^??J?!: ...  !~?P7~:^7?:.^!JY??J~~YYJYYY5J~.~YJ??^.  ^77\r\n .:^~!!:..!GJ7GGY7?55YY!.  ^~77~77!:  ~Y7^.     ..   :7~:^^77:..::::  :   ::7^!Y^..:5Y~  .^::..^77JPPJJ?!^^~^^!7~~!:^!!\r\n77???7!::::^!~^75G#####B! :7?J???7.   !&#BP5?^. .~.  ..~^^^.    .      . ~?^:?~.^!7!: .  .    P###BG?..:.^~. ..   . .^!\r\nY??7!~~~~?^.:^   .:.!BB^YGPY.^7???^ ..5#GGGPY?^.:7?~~!?YYJ^~:^7!..^~??JGBB^  .77!~^:..        7P##&#!.   ::.  .  .~:  :\r\n?^.   .  ....~~  :::~J?PBP~..:^^??7.  ^^.::    ^!~::Y7. .~Y:^?!..:?PB#BB&?.  .~???5?!: .^?J??~:.~B#5!~ .:!^.  .     .^^\r\n:!7. .:    .  .  .7~^:^JP7.  :. !J?^:^!7~~~~~!?Y!~ .?J7^?J?..^?!    :^!J5...:7???^~JJ!.!B#&&&#BBP5?7P7:.:~?~.   ..  .  \r\n .    .   ^.   .:^~7JY^:JBY:^^. .^~~^:^!!?!!7Y7J?~.   .. .  !??J7!~^:.^:   !??7^!:.?GBP:&G7~!^^^.:~:~^..^!!!~:    ^Y~. ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("!:77.^~:!?777????7~^~~..:..  .: :5JJBGJ .. ..7~~!!?^:!57~^..   .~    .:^.^5P57^.   :.^J?7Y5^~YY?7!!.   .!:  ^...  .. ^:\r\n^:  .^J:   .:~!!!^...!7!!^!??JYJP#Y:GPP~.~7!??7!~~7777JJJ?:    ~:  ..:~7!Y?^:~~^. .::~. :?5?::!^~: ..   .   ..  ~!: ^!?\r\n^!^     ..   .~?~:.:?P7~JYPPB#&&&#P..~J?!!?77: ...  ..?J~^ ^??~!!!^. ~7JJ?!7777??7?:...  7PBJ!~~7^. .:. .   ..   :^!^. \r\n ^Y^^.     .  .^!:  ~!P#B: ..:^:^.  .^!JJ7J7.   ^P?^.  !7:.57.  .?P^ ^77:.  ....^??77~.~YBB??B!  :  .~~..!^:::::~7Y5^:^\r\n.~Y:  :~.  .  .::   .!#&&#G7  ..... .. .:~:77  .J5Y?::!77~~~J?!!77!^77^..:~!7..  !7?7!7J7~~7B#BP5?~^..^..~~^!7?J???YPY^\r\n^ !7^. .   .. .~~.:..JGGB##5    ...^.:?J?!^:!?^?7.   ..   .:~~^7^:..^7^.:?5BY   .7J7?Y?!. .YB###BGBG5!75?:..:!777!~^~!~\r\n.^?!!^:!~~7!~~!:^!JYJPPY7!^.:::^.  ~YP.   ?P:7:.   ...   :~~~::!^    .:.  .77.:!!:^^....    ..::.  ^PP~YJ^..~?!:.     !\r\n~7777:  .^7?JY~:!YYJYJ?YY^!J??YJ!~.:?7^^!755^!..::^::7!!JG5^!J^:55^:.  .   :^7~!~^!JJ^ ......  .!55B&&7^  :~^:.    :.  \r\nYY7~??~~:^^~^~7PY~    .^^~7??7~~~^^^^^!?^:^:.^^:?^:5G57:~7!!~!?JJ?77Y?^^:.  7:JG^   ^B~^  .    5&&&#B?: .  ^^. ..     .\r\nJJ7!??^:.:.. .7P7 ~7. :!7??!:..   :~^^~?     ~P^:JPY~..^~~~. .^^~::JPG~.?!:::^?J?7^:7J^. :7!^^.:7?J5B?.:^^~:  .    ~^  \r\n7777...:~7!~~7P5^ ..  :!??7^  :.^Y##!.  .~   ~JJY?7^....:~!:.~~^:.  75G~:!Y:  ..~?!^~^^!?J?J7J7^J5PPPP5?~:!~::^^... .^^\r\n7~!^^^^~7JJY7.!5Y~::.:^^~??7!:.   :~~^!  .  .JYYJ!::~~^^:~!7!~:^^^~::!JYJY:     ~~^^:.  .:~7??!:^^.::~Y5!.!5JJ7~^~^^~!7\r\n~^: ...^~::~!:~75PPPP5Y^!J7JJJ?7^^~^!?!.   .J7:^G5?. .:^~!::!~:..:::!7YJ?!.  ~.  .~B#5^.:. :7??!^  .. :YG?^!!7~:...!?77\r\n  :~.   .  :~^^^:7B5J?7:.^^!7^..:77^^77??~:::~?.^PPY^:~~^:  ~~~^..^JP5^^57     !~^^!:.  ...~7??!:  !7 ~PJ: ..:.:^7?!!?J\r\n.     .. .^^. . .7B#&&&G    .  :^B!   :G5:?. .:~^?5?!7?J7!^!!!!:!5GP^:?^^~.::::?7~^^^^^~~!??7~^^.    ^YPJ~^^^^:^^7?~7Y5\r\n  .:    .::~^  :!#&#GP?.   ....: :JJ7^~!~7^:   .  ::^YP^^J7^JGY7!?~:^:^..!:Y5?!~^!7:.~!JYJ?J7^JJ??J?YY7:^JY??^.  :7777!\r\n?     .:~?~..:?5~PG~. ..:.   . ....:^:~!^.!7:  .:.    ^!::^~~^.  ...    .?.PY    YP!. .^^^:.:!7J5PYYY!^:!~~77!~!::!!7~.\r\n^~~^^~777!^...?57!YGBGB##BBY. .~7YJ7J?:   ?B5?^ :7^..::7^^~:.   ..    !J^7!:^~?J?^.^: .    J##BGG5:.^.~!: ...  . .~!7.:\r\n:JPY???J?7!^^~..^:.^!?5PB##J~^!J777?7!  ..!7!^..:7?^!7777JJ!~~!7!::7JYY:  !7:^:.. . .....  !B#&&#7.   .:.  .   ~^  .J!.\r\n^^:Y5?!^::^:^7:.~~.  .. ~BY!BBP!.^77??^....   .!7~.:5J.  .~5::77. .~?P!   .7J7JJ7~.  .::^:.  :G#B!!  :!^.  .     .^:J! \r\n .^!~:.   .   ...:: .:!~~7?BG?. ....????7777!7JY7!  ~7!~~??~ :~?J..  ..: .!7?7!?J~. 5B&&&#B55YJ!!PJ:..^?~.   .:     :!^\r\nY~~ :!!  ..       .. .~^!::75?:  ~::. .^~!^^7Y!7!^..  .!    .7J?J?77!~~!!??7!!.:PPG^?#G55YJJ7~!!77:..^!!!~:.   .J~.  .^\r\n^:. .   . ^  .7.   .~!7?YY~^YP?7?~::   .^~YP5!.::.    ~:   ..:!!57:^?!!!~7:...: 7GB57P^ .:   .:..^~^^!7???7777!:~^.~7:^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("~!7J5B#? ...75YJ?7??!~~~~7: ~!^  ::~!775G5.     .:!GGG~.PBBBP^ :^. 5&&&&G5BJ7GPYJ?7JY5?^!?J7777^.  .^:  !^^^:^~~ .:5G#?\r\n5YJ!:7!.^~:~7777????7~:^~:.:.    ^..JB^BBG^.::.:^!:^7Y7:....   ^~   ~7JJ^^5PGY?^. .:!PP!:~J7~:...   ..  .   .:. .!~B@? \r\n~:.^:  .^J:    :~!!!^..:7J77?JPGGBGB#B^!55J.:?7?7??77J?J?^..  :^.  ...:~^Y?~^^^.     :5G?:^^?~. ..  .   ..  :!::~^:GY::\r\nJ?::!^.    :.   .^?^..:?P!~^!77?PGB#B5^ :7?Y7?77:..:^?J!~ .~~^!?^.. .!JJJ?777?7!~~.:~PBG?57..:  .!~..:....  .^?5:....  \r\n7GJ ^Y^^.     .  .^!:  ^~G&B^   :^.     :^!?7?J~     .7!..YJ~...~55: ~7J~::::!???~:755J^Y&5!~^.  .^..77~!!7????YYJ?:.. \r\n7PP:~Y:  :~.  .  .:. .  !B&&#BJ ..:....   .:^::?~ .~^^~?!^7?~:.:^77:!!^.     ~???YJ?^ .P##&&&#BP?!?7~::.^7??????Y5!.:. \r\n:GB~ !7~: .  ... .!~.^.:YGPG#BY    . .!~^?7?~~~^7!~?:.:. .:~?!7J!^::??^^!. ^!~~~^~^^.   ^!7?7^~!J~.JG!.::~!!!^:...:~~:.\r\nYY~.~?!!^:!~~?7!!!::!Y55PPY?!:.^^^~.  ~P5    ^G?^7       .~~..:~.     .7!!!!^^~?!. ......:^. :.~P#P!7...:7!.    . .7:  \r\n   ~777?^...^7?JJ^:7YJ???7JJ^!J??YJ!~..!!^~!7YY^^:.~~^!755:^?!:^5!..    ^!~5~..:~5:~~...   .Y##&&#J:   !!:  .   .  . .^\r\n  :!77?7^^^!~!!^75BP^    .^^~777!~^^:^^^~!?^.::.^~:!7:?G5J???JJYPG!^77..~:JG7.  .P5:  .:.. :GBGB#5. :. ...  .  .:  :^J!\r\nP: ?!!7^...^7J?J^!55^    .~~???!:     .^^7J     ~P!^YPJ:.    ..:?5Y~^^~!..~~~77~~!::^^7Y77!:~?JJPP7!~~7!. ..   .:. .?7:\r\nP:.?!!..!^~7!!7?^.~YG5YJ?J!:77??77~^:::^!J^    .??75PY:         .JPP!7J:    :J!~:^:^~77??7?:~J?Y55G5!.:7!~!7~^~. !!?..Y\r\n:~?: ...   ..  ~7~~!75PYY?!:!7!Y?~^^.~~~7?~^~: ~7^^~Y5?: .     :?P5~!57     !J~^:     .!???~~:.   ^55!:JJJ?^...:7!!?..P\r\n^Y~:  ::     ... .: .J#BGGG^ ..::  :JB^  :!G5:~..!?^~PP5JJ?7?JYGJ^!!:~!....:?7~^^^::^^!777!^^.    :5BG7^~!~7^^:!?77!^  \r\n^. .      .  .~7.  .7B#&##P^   ...^!:5~:. ^P7^!    :.!5!:!J~:JP?!^~!..^:J5?7!~~!:.!!JYJ?J7:??7777JY?^^?J7?^...:7777!.  \r\n  :!. ..   .~7:...!!Y&G!:: .^:...... .!?!^^~!7~7.     .~^..^~:.      ~~!B!    JG!. .~~^^::~?Y5P5557^.!!!7?!~!::!!7!.^JY\r\n..~!^.  .:~!!!::.~GY:~?~^:~77~^   .:^^^^~~!^..!^~7?::^~J?!7!:.  :..7!~?^~!^77?~^7. .    7BBGPGP^.^:~!: ...  . .!!7.:GB~\r\n..^.~YY?7???77^.::~7?!?PB#&&&##G: :7JY???!      :!!^~?~^::!?7~!?!~^~: ^?:.^^:.  ....:.. 7##&&#7. . .:.  .   ^^  .J!.5G?\r\n ..:7YYY????7!!~!7..^.  .^!!5#G^?YYJ^~7??!:.::^?7!..J5!. .^75..!7.     ^J?77!^:.    .:^  .^G&#!~  .!^.  .      ::J! 7B?\r\n  .....YJ~.  ....:..^!:  :..!P?5BG7:.~~!7??77?JY?7. .:^77^!~. ^!?J^:. .!7?7YJ7: :YGBBG5?!!!~~!5Y:..^?~.   .:    .^7::?J\r\n.:?G^:~::~:  ..   .. .. .^?~^^7GP~     .^^^^7Y~~^...  .^^   .:7JJJ77??7?7?^.?5Y7:G#BBBBBGY??!J?::.:~!!~:    .J^.  :~::^\r\n ~@&7!: .::   .   .   ...:~!J!:~P57:. .:!JGGP~:7?!^.  ^^.   ...:!Y7^:!~^:::.:PG#~G5:.^.   .^.:~^:^77???7!!!~:~^.~!:~?J5\r\n~#B5^. ^~::^^:!  .~.  .:!777JJ!^755Y?7YYPG??GPP&&&&G. ^^ .YGGBP.:PGG7:.      JGP?7!~::  :!~..7!~~~!??7??Y5?..: !##P5J7!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  :~   ..^. .:^7YJ?YJ?!.... .  ..:. ..J!:::!Y?7J55G775J7GB##&Y:.:.7##B5!. :..??^.!?JY?7~^~7!^  ...  !7!~:^~?: :YPBP~.  \r\n!!!77JYP##~ :.:J5Y??77??!~~~7^.:~:  ...~?75GG~ .~YBGY?~B&##BJ .:...B&&&#5JY!!5J7!!~~^75J7~^:    :^  ..    .  ^:5&B. .~.\r\nJP55J7^:!^.^~:~!~!7??777~:.:^:^^..::~~^J&77#G5.:^.~J5!.::::.  ^~~  :J5GG!~P5GGY!^^J5!:^^!~  .   .   .:  ^?^.:!~#&~..  .\r\n7!!~::~:  .^?.    :~!!~:.:~JY7~J5GB#&&&##Y.~?Y!:77~!J?J!:..  ...:     .::JJ?!::. 7GB5?7^^^. .~^..    .   .~?^. .:..  ..\r\n7^!J?::7^.    :.   .~7^..:YY!!..^^.~?JYY7^ .~?YJ??!~JJ77. ::.!?7.   .!?J?J!~!!.^5GG7!&5:.:   .~..!7~~~^~7?J5?~7~:.     \r\nJ!^7B! 7J::      .  .^!.  ~!#&B^.. ~!.     ..:^~!7?:.J~..?Y7::^^7Y?. !7Y!~7??7JJ!..JB###BG5?^:!^::^:^7???7??YPJ^.. .~^.\r\n^:!?G5.~J.  ^^   .  .:. . .7#&&##7  ...:.:: .~!!^.^J:^?!^?7:    :?7:^!~::!?7!?7~:  :YPPPPJYPP~:JP?.:.^!7?77!!??^:~.7&BG\r\n@&^^BG:.7!!. .  ... :!!:^.^PGPGBG!    . .~J7?^^::??:J::.^^7Y?~?Y7~~~7~^!~:^~:. .  .  .^~  ...!7^55^.:~7!^:.    77^ .^.^\r\nYYJJ7:.77!!::~~!?777!.^75P5P5Y?~::^~~~. .!GJ    .5P:?.  .^^:..:~.   :7^?!::7?Y.!~..:..:^ ^7?G&&7!  :^^~.    :. ..  .^~.\r\n5!PY: ~?!77   .^?JY?:^?J?~!!!?7:7J7JJJ!!.:!~~!7?Y?:...^?^:^!~~:~!~. ~~!B~    !G~~  .    5&&&&BY:   .!^. ..     ...!~:^7\r\nG:7#5 ^?!!:~!~!7??J?.^J5?~^:^^.^777!77~~~~~~!!.....!~:^Y77?JYY!:?!:...^JJ7~::75~. .!^:: ^YYYPB7..:.:.  .   .~:  :JJ ^GY\r\n~JG5:^!^::  . :^..^7^~7Y5P5P5Y~!Y7JJ?7!^:~^!?~... .Y!..PPJ. .?PG:.^Y: ...~7!^~::!7?JY7J7^J5P5P5Y7~^!^..::  . .::!~:?G5~\r\nJG! 7Y^  .!.   .  .::::.~BGYJJ~ :^^!: .^Y?::~7JJ~...:~?^!JYJ???Y^:^7.....!7!^~~~~!7!777~.^~^~!?5Y~ !J???!~!~:~!?~ ?#Y.5\r\n?~.^7:..     ..  ^!:   .?B#&&&G    .  ^~P?    ^G?:!..~!~:^!7~::?~....!Y?77~~~^.!!?JJ???:!7!~~~7JJ~.!5JJ^.   ~7!7! :JP!5\r\n.~^.  .. .:    .^^^:  ~!#&BY?! ::...:.~7.JJ7::!J~!:   .^^. .^~.  .7:YP:    !B7.  ~!~~^:~?Y5PPPP7~.~777?7~~^:!!!?..!JJYY\r\n^.:. ^!?    .:^~7~:.:JP^7?: .  ^~.     .  :~^:~!~~!~^~!YJ!7J?:^...J:7J:.::77J!.  .   ^PGP5PG!.^:~7^ ..:. .. !!?..5B7:#@\r\nGB&Y.^::77!!!777!~.:.7PY:^55Y?5P55J^  .~!?!!77^:^!~:!J:.  .:7J^~?^:J^.^!7!. ::.:...  !#&&&#J. .  :.  .   :^  .?!.YGJ!^^\r\n.^!: ..:?P5??7???7~:^::^7^^JPG#####5..~JJ???7!~Y7!. ?5?:^::!JY..~J:.?7!~^...     .!!  :^G&&7!  .!~:  .      ::?J ^BJ^~7\r\n     .:~?!?5J?7!~~~~!7..~.   :.:J&?~PGP!.~!~!J?J?7.   .!?7:::. !7?Y~!???Y?!. :~JJ?7~.:^..!!J5:..:7~.   .:    .^7:.?Y!^7\r\n...  ... .:J!:       ...:~. .::^7?JBGJ..::~7JJ^::.    ...:   .:!J?J7!77^~Y?~.J#&&&&##BPY~~JY!:.:~!!~:     7~.  :!::^!!!\r\n.  ..^#&!~^.^?~  ..   .   .  ^!^^:!5Y^:~JPGPP!^5P5J:  ^~^   .:::.~5J~.^:.JGBY~&5~~!^::.^~:^:..^!77??7!~~^:~~.:~::!?Y55Y\r\n.^:  P&P:~  ..    .  :^    .^~!?Y?^^~!77JP7!Y5Y&&&&#. .:: !G####!!YGBY~. :PGG!J~..:  :~^.:7!~~!???77?Y5Y^.:.:B#G5YJ?777\r\n  .^5#P5^ .7!^:~!!7  ...  :!7!~~7?JJ?7.:7J:.:..!5###?.:..7#&##BJJP?!GPPJ77Y7^::~Y:. .^..  . .:..~?JYJJ5?^.. .~:.   ^:  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(".. ...    ..  :...::. ^Y?.    .   ..   . .:^??!:.7Y: .   .^!YP!:~!JY!.. .~::.  . .^~!7!!! .^..:^77^::^~!~:.7PPPY7.  ...\r\n ..  :^   .:~. ..^7Y5JJJ??~::^.:: .:^^  .!J:^^7??Y?!!!:?5G##G?:. :PBP5!.  . .!7:.!JJ?77^.   :~  :^.:...: ..JG&? .~. .  \r\n!7?7?7?J55G##^.:.:J5Y?777???!^~!^..^.   : .JY?BGGBPJ5JB&&&&G: .:. ^#&&#B77!^!Y7^^^!!^^  .   .    .  .!^  !~B@Y ...   ..\r\n~~7J5YJ7!:.^:.~!:^~^~77?77!~:.:~!~7^^!7?J?Y#G:GGP5YP! ~77!^  ^~~^  JB###?JPY5GPGP~!^!!.  :. .    .   ^:~^^ ~?::  ......\r\n!~~!!!~::!:  .^7     .^!!~:.:!5Y!.~5PGB#&&&#G^ ^J?7Y?7~..   .: .:   ..::.75PGGBG!GY. ..  ^!:.^~:.:..:~?57.:..  .:  ....\r\n^7J?^~JJ:.7~..   :.    ^7:..:YJ7?: .^ .^~^~:.  ^!JY7???: .  ^!^~   ..~7??Y?7J7!!Y#B5J?~:. ^..^!^~!7??7??Y55?^:.  .  .  \r\n7G57~~7B! 7J:: ..   .  :^!.  ~!#&B!:. ^?:      . .:~^^: ~JJ~~77!77^ .77J7YJ7^  7B##&##BBP77JJ~..:!???7???55~ : .P57:  .\r\nJ!~~^!?GP.~J.  ::   .  .:  . .?#&&&#?   ..:.:!:.7J?!^::.??.     :57..::^:..:.    .^^:.:~^. :5G!:::~!77~^::^~^~::555BGY?\r\nY@@@&^~BP..7!!. : .::. ^7!^~:~GP55G5^   .. .~7?7.   ~P~:~75?:^7?7!:^~~~JJ7 ....: .^J. :.:YBJ!J:..:?7:.     :J^. ...:!J5\r\nG@@@G.PB7 77~!~!?77??7?7.^75P5555?~:^~~!!. .!G?   ..7Y^!^:^. :~~!!^G7    J7!J^....  .7GG#&#Y:  .!~:     ..     .~!^^~!~\r\n^:!7~7B5:.7!!. ^::!~^~!~.~JGPPGGGP~Y5?JJ?~!..^^~!!?Y!.. ..::::....:?J:.  .GY:  ..   ~#####Y: .  .:.  .   .  ^:?! ^YJ!^7\r\nG7:~?B7.7J.  ::   ..  ~!~^~~YGJ?7!.:!!??^:::!~^!7!77^...:^?YJ^:...:77!7!^~7^:.:7?!~^.~7?JG5~^^^!~  ..   :^  .??.^GY~^!P\r\n7~~?5! ^J^^. ..  .  .::  : .?B####7  ...  :?B:  .:?J^....:::^.. ..~Y?!7~^^: ~~?JJ?Y5~5GGGPPGY~:^7~^~!:.^  !~7:.JBJ~7~::\r\n~!!~^~~:.    ..     .^!.  :?#&#BBJ:   ...:?77Y    ~G!~7^~: .:::7:J?:..  !B7. .~7!~~:^?555PPP7~ !?????!?!~~!!? ^BG.Y@@@B\r\n5J!:...  ^7^     ..!?^..:7?7#P^.:  ?~. ....: !JJ!^~~:~7J?~:?Y?~^^P7   .!??~:  .   :YP5Y5B7:~^!7~ .::. :. !!?:.YB7.&@@@G\r\n?5GBYY5^.~^~::.:^!!!~:.:^G5: .:^: :^^.    ....:^:.:.!P^     .!Y:::^!?J?::!^.:..   7#&&&#J. .  :.  .   ::  .?~.5GJ~~!!!J\r\n. .:7PG: : ^Y5J??????!:..~JY!7PBBB####BJ  :!?Y7J77: ^7?!!!~^JY7 :^:~:....     .7!  ^~B&&?~  .!~:  .   .. ..7J ^BJ~~!YGY\r\n  .  .  .::755Y??7???7~^~^..^..^~JY5B#P!~!??7YJ??!:.   ~~~! .. .7??7JJ7^. ..^^^^. :: :J7?5:..:!~.    :   ..^7..JY~:?Y?~\r\n....  :.  ..^.~5J!^:.:::~~..!^.  : .JB!5BGGP5?:::..   .: ..   ..~7?Y??J~..P#&&&#BPP5!.~JP7:.:~!!~:     !^.  :!^:~!!!!~!\r\n......  .:!~ :^~^:   .    . .:. .~7~!~5GPGPYPY!B##GY  :~^~  :~!!~ ~PYYPPG:5#PJYJ??~^7!7!:.:^!77777~^^::!!:.^..~!?J5Y?~~\r\n..   ... !@&!!. ^!^  .    .   .  ^~~!^^^!Y7^7?7G#&&&! .:...5#&&&#JYJPBGG#JJY: :.  .::.:!~^~7??777?J5Y^.:.:G#G55YJ?????7\r\n  . .~. ~#BY.: :...:.::  ^^    ^!!?JJ7..!7: .  .!5GBG^ ..7P##BPJ^!7!7YJ??~^:?7.. ^~:. ::.^::~???JJ557^.. .!^..  ^:  ...\r\n...  .!JPGP?::~!~^::~77^:..^: ~7!77~~. .  ..:^. ..~YY!^:~557~.   : .Y?.:!7?~:. ..   .        .75! .^:...:  ..    ......");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(".....  .:......  ::  ... :!^.~^  ..         :~: .. ..^~^.^..!::~~^..^:~J: . ..   .  .^^7^:~!!^:^!!7!!~^^YG7Y57.   .^:::\r\n!:... ....   ..  :...:^~:^YY!.       .. .  ..!..!7: ..   .^7Y77?????^ ..:!^:.  .  .::   .^  :7^^::^!: .7PBG^... ..  ...\r\n^  ...  :^  .:^!. ..^?J5YJ?7??!^~^^7:.:!~. .:~!!?J~:^.^75GBB5^   ^PGY7:   . .^~. ::..   .:   .   .:  ~^Y&#. .^.  ...  .\r\n~?77???JJY5P5G#G:.:.~Y5J7777???!::~^.::.   :..7#~7?G5P&&&&#~  ::..!&&#BY^:^.!J7:~?.  .  .    :   !~::!:JB!:.  .......  \r\n57!~~?JYJ?!^..:.:!!.::^~77777~~::^!J????5GGGGB##!~5~ ?55Y?. :~.~: .G#&&&YPP?~JY^.:.  ~!:.... .   :!Y7.. .   ... . .. ..\r\n^~!~~~!!!~:^7:  .^~     :^!!^:.:?P?^  !??75BB#BP! .~!:.     ::^.:   :~!~.!Y7~#B7^~.   ::.^?~~!!7???JY?J!^:..::  ...  ::\r\n7!.~J5?:~YJ..?~..   .     ~!:..:5??J: .~  :^.     :^!?: .  ^^^~^   ..:~!^. 7##&&&#BGY!77!^:::7???777?Y5J^..  ::    ....\r\n7? JGJ~~~JB^ J7.. ..   .  :~~   ~J&&B!^  !!::::..   .:.:7?~!J~?!^^. .~~^:   :!7??~~7?~ ^55?:::~77??77?YJ:.^ J&B5!:.::  \r\n~7!J77?~~JG5.~?.  ::   .  .:  . .Y#&&&&7   ..~^^~7^?7?!??.      !PY7!^    ..  :!. .~  :^^P5:.:^!!~^.    !!^.:!^7PGGPJ?7\r\n?~777GGY:?BY..?77  . .^.. ~!!^~:?B5Y5PJ. . .  :~?7!.   .PY!. .^!7:.:^5!^7^.7^..^~ .^~P#&!7...:^!:    .. ^:.  :^..~!JY?!\r\n:^5P!.^~YG?:!!...    .:. :!~!7J?J???~: ~!!7~. :?B!  ..^^!~^:.^7Y!     JJ^!. .    Y#&&&#5^   :7^. ..     ...^~^^!7!~~~~!\r\n.^YPJ~~YP~ 7J^. .~.      ...:. ^BBP5P? .::~.  ^GY:.:~YP:..   ...55!:..?B~. .^:.. ?PPPBB~ .:....     .^. .:?J :P5~~?5Y~.\r\n!~~~~!7!^:~~...      .  ^!^   :JB&&&#P.   .  ~^?J.    ^J?^.::^~:~:.. ^BJ^  ^?!!! .~7J?J??7~~!^  :.   ....!7:!PP!^.~PP~.\r\n!?YJ!~:.^^.  .^  :    .~~::..!~#&G7~^ ^^..^7:^7~~P^: .77!: .!YG:    ~!J~:  ... .755J5BJ^~~!!~...^: .. !7?: ?B5:?PG7!?~?\r\n??YPGGP?:~^.^!7.   .^~!7~:.:JG~^^. ~. .7:....    :77JG!.     .!J~77?~!!^:~..   ^#&&&#5: .. .:  .   .:  .7!.JBY~!JJ7J7!~\r\n  ::.:!5B&5 ^:.?Y?77??77!:::75P~ ^?7~^777!:   :^~~. .^~!?!?!~??~.^:   ..:^:.~!. ^!G&&5~   ^~:. ..  .: ..!Y.:GY~!^7PY.7?\r\n. ..    .:. ..:?55?7777??7:..:!7?!YG##&&&##J .^!!^...  ^^~^~  . .7!^:     .:^  ^: .YJ7Y^..:!~.    .   ..^?..?5!:75Y!.~J\r\n.:. .... .:..:^!YJYJ???7!!~~7~..:   .~~7G&7!J7.^!^:.  .::^:.    .:!!. ^5BBBG577?!. :7PY^:.^!7~:     ^^.  :7~:~!!!!~~!!^\r\n.. .. .  .:   ....~57:.  ...:...!~. .:.:JY~?PG?#&&#B: :~:~^  !JYY?.^Y!^B#BBBBGPY??7Y7~::^~!7777~:::.!7: ...^~7?JJ?!~!7Y\r\n. .......  .:^GY.!^:^!.  :    .  .  .7!:7J7:^^^YB#&&?..:^. :B&&&&B5GJ?^BJ..^    .:.:~::~???7777?Y5!:::.5&G5PP5YYJ??77?!\r\n.. ...  .^.  G@P^!  ::.  .   ..   ...: .~~: ..  :7YGG~   :YGBBPJ!.^^^??7!~::  ^!^.:7~^~~!??7?JY5Y?~..  7!^.. :^  ...  :\r\n...  .:  :.:P#PJ...!^:.^:!^  ^:   .::  .  .::~^.. :??7??!7Y?~:    . .77..!... . ..    .  .~JY~:!~:.:.:.  ..  .... ....!\r\n::::..   ~YY?P5~^~!!!!~^:^!!~:^7^^.  .   .. . .?!:^:.^~~^:!: :.^!^:.  . .^: .       .:  :~.^7^  ..  .^. ......:.  .....");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("..:^:....  .. .. .....  :^GG!7. ~7:      .7:      ..    ^!~~!!7????77!^:   ..   ..  ~?~!7~~?Y?7!?7~~7P!^55^.  :7~::. ~:\r\n....:...  .:. ......^^.  ..  ~?:..  .:       .. .  .:^:.7^:~..^^~^.:~~7?.   .   :^   ...^7~^:^~7!..!PGBJ~.  ........:^:\r\n~^!7:... ....       ...::^??!JY?~. ..    ...: ..^:..... ..^J7?JYJ7!!: ::^^:..  .    .!   : .  .. .:!B&7  ~: ...  .:.   \r\n~:::  ...  :^ .:^!?. ..^?JYJJ?77??!!~~7~..~^. .... ...:!Y5GG!  ..!P57^   .. ... ..  .    :. .7!. !~P@5..     ..:.  .^~^\r\n7::!??7??J5Y5PG5P#P.:::!YYJ?7777??7:.:^::~....^~:7G5JB#&&&J:.:.:.:5##BY~... .~:. ^^...   .   .:7!:  ^..   .... ..  .:~^\r\n!?557!~!?JJ?7^:... :!7...:^!777!~^^:7?YJ~J5GB######PGBBBP! .^..:. !&&&&#JG5^ ..  .~^.^?~^~^^~7?YY^!^:. .^~........:. ..\r\n^~7^~!~~~~!!~:^7^  .:: .   .^77^:.:JP7^  .~~:~JY55J~. ..   ^:?:~.  ~?Y5GG###BG5?~:^~.:^^:!7??777?YY?!^:.     ..  ...  .\r\n:~^7!.!5PJ:~5Y..?~..   .     ^!:..:Y7Y5^ :^. .~:     ...  .:~G::  . .  .JGGGBP5PGJ^7PJ~:.!7??77??J55^ . .??^.  .^. ....\r\n.:!7J.JP?^~~JB^ J7.. :.   . .:~~   ~Y&&B?~  !^.~?!:.:. ^~^!J~~?~.. .. .   .^. .~.   ~5G~:.:~!77!~^~!~:~.:BBGGY7~^::::. \r\n:^!7!~J7  ~Y5GJ.??   :.   .  .: .: :Y###&&7   ..^~7~!!J~^..:^::^?5^.~..7!~:~7. :..?P!?5^..^?!^:.    ^J~. ...~J5GGY?7???\r\n7:5: JBGJ~~JG~.?J.  ^^   ..  :^:...7#PPBBJ   ..  :~J7^.          ^P^~7~^~.. ..^Y5B&&Y^. .~^:.    .:  .  .^!^:^~~7?7!~7Y\r\n?:~!~^!!~!?J^.~?:^.     .  .^^  . :JB###&J   ..  ^~B:             .G7^  ..   7##&#BY^ .  ^^:  .     .^.7!.:??!~!!^~!!:?\r\n57~!777!~~^:!~.  .  ..    .:^~:  ^?&&#P5!.. ..^^^7!^5!           ^!Y~:  ..   7BBPP#J. ..^:  ..   ^~  .7J.:G5~~?GB5 .5:!\r\n???77YGG5J~...  ^?!     .:!?^..:JJ~PY:.:  7~:~77:.~::5?^.:^:..^^J7!~!!^..   ~#&###5^ :. ::  .   ..   !J:7G5Y!  !Y!^7!~:\r\n .:^:^^~7YGGGB~.~:~~~^^!77!~:.:^PP!   .~. .^:     .. ..^?!~?7^!~. :..!?!.:!. ~?B&&P~   ^~^. ..  .:  .!Y.:GY~!:!5Y.?7!:.\r\n.... .^:  .^?Y: : :Y5J???77?7!::~JP?:?PP55GGPPJ.   ..  :.P7.:  ...     .~:. :: :557Y^..:~^     .   ..~?..J5~:?PP?.^J:!:\r\n.  ...   ..    .::!?YY?777???7^:^::^~:~J5GB###GGYY7~  .~.J:^    .  ^7YYJ?~.^~:  :!55^:.^!7^.   . .:.  :7~:~7!~~~~~!^!~:\r\n:.  :....... ~~. .:^7~J5J7!~^~^~?~.:~.  .:.^5BJB&&&&? .^:.^: ^5GBBGP##&&&#BG5J~?5J?^:^^!777!^:...!7^ ...:^!7?J?!!!!YPJ!\r\n^~:.   . .....  ..^  :~?^.   .    ..^^  :^. ...~YB##P:.:.^..!&&&&#Y5BJ^~~::..^^:^:..!???77???YY7::^.J#GYGPP55Y??7??7^.!\r\n:~~.. .:..  .  ..?@B^!..~?.  :    .  .. .:: ..   :7YP7..  ^PGP5?^..:..... .:~:.^7~~!!??77??JYYJ~..  ??~:. :^  .:.. :::~\r\n   .:.  . . .!  ^&#?:: ..  . .   ~:     .  .:^~:: .!!7JYJ?7J~:. .... :~.. .:..    ....~?YY!?J~:::..       .... ....!!^^\r\n.:^........  .^7GGP7..^7~^:^~7~...   :^   .    77^~^.:^~^..~::7::^:..  ...   .   :.  ..:?!. ..  .^^. .... ...  ...:....\r\n:~..::^7^  .:YP!^G?~~!?!!7J7~^7!~7~  ..    .   .^~777???7!!~!!~.   ..      .!.   .  .7!..!~YB^:.  ....  . ..  .....^:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(".     ..  .:!^:.. .......  :.J@B^~  .  ...!  .^.    :.    !??777777??J7:  ^!.   ^7!^:~??Y?!:!?!~!JJ ?P?:. :77^:: :^....\r\n^....:^.....  .. .  .:...  .:!?^~~.:?~  ..   ::.       .^~~77??77????!:    :.   :..^!!~^^~~!7~:^YG5YJ!. ...:.....~:   .\r\n...:...:...  ... .....~^^.  .:. :J?:    .   ..    ..:..?~^~..^~!~~:^!~!!        :7.  ~.:...:: .^P#B: :: ..    :.... ...\r\n??7^^!!.... ....       ...:^^?YJJJ??!::^..:...^^. .::: ..:?!7?J??~:~:.~~::...    .   .   ^~. ^!J@&: ...   ...  ..:..:~:\r\nJY7~::....:. .^:..^!?J  ..~JYJ??777???!^~!~..^:   ^. .^!?5P!.:^^^75Y~.  :::. .. ..   ..  .^^^~..J~:.  .......  .~?^~:..\r\n^^~!.^?J77??555PGPYP#?.^::7YY???777??7:..^!~7^^!77J?5B#&&P~.: .. ~G#G5!. .:  :!~..~:.:...^!YY:::..  ::.::.  ......:.   \r\n::!7JPY!!!!???7~::... ^7! ...^!777!^^:^J55?:^5PGB#&&&&##Y..:...:. ?&&&#BJJ!:. .^..!~~!7?????JYY7^^:..^^ ......::  .:...\r\n~^::~!^!~^~~~!7~:~7:  .:. .   .^7!^.:^55~:   .^ .^~~~^..  ^^!?:!. .YG###&##BGY7?J7::.!???!7777JY?~..  ..     ....  ..:.\r\n..::!^J^.?PP7:~5Y..J~..   .     ^~:. ^J7PP: :. :.!~.     .:^&#.:     .:~^:.~^^  ?G5?.^~77?????J5?..: J#P7:. ^:  ... .7!\r\n:..~~7? ^##G?^^PP .Y~  .~.  .. .^~^   ~P&&BJ! .!::YBP?:~^^?^7!~^...:::~!.. .:  ..~P5::.^!!!~:....~~^.!Y75BGPJ7!!7^:..:^\r\n^~:!:^?::7J7^~Y5^ 7?^:  ^.  .  ..  :: ^5###&&~   ..:!Y~:!5!7~!P:~~?PG5!.^! .::J##~J:...~?^.   .  !^.  ...:!?55?!~7JY~.!\r\n~75P?~~!!!~~!!~^^~:.    .   .  :!~   ^5#&##BJ.   .  !7:J5^.^.:Y5:!?...    7G##&#G~.  ^7^.     .     :~~~~!!~~!!!!~?5P7~\r\n7.^YJ7~!?55?!:..:  .:!  .    :7!:...?~B#5^:: ~~.~YGPJ!~:5?~7~Y7:^Y!:..   :#&&##G~ .:  .:. .   :. .^7J..J5!^!J7^:7!:7:~^\r\n^^..:~7777JPGB5!?!.^~!:. .:^!!!~:::JG7..  :. ..!!^:^...^!~7^7~:~:7PB5:.!: ~JB&&B~.  .~^.  .  .!.  :Y^ YG~^7P##! !?^!..:\r\n~7: ...  :^..:7P#P ::.75J?????77^^.75PJ. ::~..^~:.     :.G@!.:     .~7.:  ^ :PG??~ .:~^.    .   .:^J: JP!:7PPY..Y^!^:..\r\n::...  ....    ..  ..^?YY?777!7??!..:!Y?!JGBB#&###GY. .!.7?^^  ..:^^^^. ^. . .^YP~:.:!?~.   .....  :!~:~7!~!~^~!~^!::^~\r\n:....  .:. .... :^...^^!YYJ?????7!^~!:.:: .^!JYG#&&&5 .:. .:. 7B##&&&#GPP5~.755Y~:^:~!77!^..  ~?^  ..::~!7??!!!!JPY7!::\r\n.  .:. ....  .::.::  ..::.J57~:..:.:!:.^!:  .: .!5B#B! .. :.^J&&#BGJY??7~^7!7~:.:7??777???JY?^:~.!BPJPGPPP5J?77??~.~~^^\r\n..:~^7~.  .......  .::?:.~^^::   .    . .. ..::  .^J57^:^:.~PPY?~.  ^   .:..^!~^!???777?7JYY!..  ?Y7~:.:^...::...::~7JJ\r\n^~:..::.  .:..   ....B@P~~ .~~   .   .    ...::^~..~^~?JJJ?!?^.. .::.  ^^:..::.^::!??JJJYJ^^:...  .    .:.. ....~7^^7JJ\r\n.:. . ..:.   .. :^ .P&G!. .:...:.~.  7^        ~7~!^:^~!~^..~^^?:.:...    .   .    .7Y~ .::...^^~.........   ..::..:...\r\n.   .~: .......  ^?Y5G5~:^!7~^^^^!!:..:    :   .:!????77??77!~~:        .^    .  ^?^.^!:!!:.  ...:.  ..... .....^::...^\r\n. ..^^ .:^!?^  .7PY.!5!!~?!^!7YJ?!:^!?^    ~^  .!???777777??7.    :.    ^:  ~. .  .  ~^P@G.:.  ...... ..:^~^.  ..     .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("..^!!!:  ^^.::!::J^.  .::.   ^: .@B?:. ^~~^^~7J~.   !J~ ~J!^?5J!~7JY: .~^^::. .^?~ P?:!~~~7!^!5.^PJ~^ .^~7^:. ^^^^:^^:.\r\n~:~:     ..  .:^::... . ....  .:^@&7~. ..  . ::.   :.    7JJ??????JJJJJ^ .7!.  .!!.^77!!!7~^7PY~5Y~   .~^::. ~^   .~~!^\r\n:^~^...:::...:.  .. .  :^:..:  .:^.:!^.~!. .:          :^~???77777???!.    :    ~?~^::^~!..^5G#J:.. .:. .....::.  . ^7.\r\n .....:::::...  ... .:...~!^....^~::J5!.        .. . .7!~~::~!777!~!!~~:   .     .   ... .~~B@?  ^:.  ..  ...   .^^^7~ \r\n??JJJ?^:!!.... ..:.    .   ..:^^!YYYJ???!^~^:!^ .~^^~.:..!^~!7!!~:.^::?!..  ..   ..  ~7:.~^!#5::   . ....  .^7::~::^!!^\r\nY77JJ7!:::..:^:..^:.:~?5Y  ..~Y5J7777!7??7^:~^..:.   .:~?5?^~7777?J?....~^~^...  ..  .^7J:. ..  ....::   ...:^~^:. ::. \r\n:..:^~~.~?J777?5PPGGP?5G7.~:^7YJ???777??7^.^~??7?7J5PG##BJ^.     ?GPY7.   .^.:?!~~~!7??JY??7::. .~!^^:. ....  ...  :.  \r\n.:^::!?YPJ!!!!??7!^::..  ^?!   .:!77!~:::~JP57. !JJ?PB#B^ .:. .:..G&&&#GY!~7~^::.~7??!77????~~^....  ...  ...  ....::::\r\n..:~^:.~~^!~~~!~!?!^~7^  ... .   .^?7:.:~PY^.  . :. .:.  :~:!^:~. ~JY?!?JJ::5P?~.~???777?7J5Y~.. .~~.   .:. .....^^::..\r\n..^~^..!.Y! ^55^:~PY .Y~^:         ^~:. :??GG^ :. ^.~Y!::..B@B :  .^:  :    .?PP^::^!7??7!!7?~.~.^&#G5!^:^....   ~!:^?J\r\n^::^~Y?J~^!!~!!~7?7^:~!::.     .. .^?^   ~G&&#57 .~::Y##B!^GG7^YPGP?.~. :..~?^JP~..^7!~^.    ~?~..^::JPGGPJ???7!^:^!!?Y\r\n.^:!^:Y57~~!??7~^::!^.  .. .:    .^^^: .~7&&BJJ^ :..:~7?P?   !PJ?7^..:.:??P#&J~. .::~:    ..  .   :~:.^~!?J7~~7YY^:7:^.\r\nJ?!!~:^77???JPGGP?:.:. ^7!    .:^!7~..^Y5^?7..:  !.7PGGP~!PG^~B#BY:.^. !5#&&#!.  :?^. ..     .:.~!:^!?7!!~~!!~^JJY!^::^\r\nJJ~:~~  .....:^^!5GB&!.~:^77!!7777!^.::5PJ.    :  .~.  ^ 5@&^.::!Y7.~  ^ :GBJ7^ .:~^.        :~~Y: ?G!::Y5~ ^5.!..^^^..\r\n.:::^^..... .:.   .~!. ..^J5J??777???~.~?P5:.?J?~7JJ~  ~^:7^~^  .:. .: .. .^JG!:.:!?~.   .. ..  :7~:!?!~!~~~!~^!.:^~:..\r\n::::....   ..  ...  . ..:~!7???77!???!.::^~7!!YG#&&&B..:. .:. .PBB5???7  !5PY!:::~!!7!:.   ~J^   .:.^~7??!!!!?PY?!::^:.\r\n  .:.  ..  ......:^^!~: .::7J?YJ??7!~!~!?:.^.   .!5GBY. .  .:7G##BGP5????J!^::7??777???JJ?~:~.~P575PGPPPJ7!7?J!.^~^:...\r\n .:: ..^~^:...   .:....  .. ..JJ^.   . ....:~^~....7Y?7777~^7PY!^.   .::.^~::!??7!7777J55!..  JPJ7^::^..:^::.:::!7??7!J\r\n^!!~::~:.7~.  .:.. ..  .:J#7:!.:!~  .:   ..  ..~?::^.:~!!77~~7..:.^~^!: :!^^~^!??7?JYY7^^^:.   .    .:.  ... ~!^:?JJJ??\r\n ^?~:~..  ...  ..   :^  ^@#7~: ...   .     .   :!~!!~!!77!~::~~~J. . ...       .!YY^:~^:...:~!...:.. ..   ..::::::.... \r\n.!~ .   ::.....  .. ...!#GP~. ~~:::^^?~    :.   .!???77777???!^^.         ..  ~!.^!: ::.  ::.:~:  .....  ....:::...^^^:\r\n:!~~.   :~..::^~.   :J57?G?^^77!!!!^:~!.  .~7: :?JJJJ?77???JJ?.   .:    .: .  .: .!!#@!:.  .... . ....:^^.  ..     .~:~\r\n.:^^::^^^. :^7!^: :~?P! Y?~~7!~~7^7G.:J~.  ::^^!:.:YJ7~!J5J~!J! ^?!.  .:??~~^^^^ .:!G@^ .^    ::.. .:?^.!::.^^  .~!!^:.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("..:...::::^^!!!::^:.^:.. . .. ..:~ .BBPJ. !7^::J~.  :^J!~. ....   :.  .~YG&BJJ?!^^7~7JJ?^^57:5?^~^:.^J7^: .^~~~^^^.....\r\n:...:^~!~. .^^.::!..!!.. ....    :. G@5:^ .:..^:   ~7^.~7:.~Y7~^^~!7.  :~7!:. .:~!.JY?!~!J5.7PJ.. .!!^:: :^.   ^~~:...~\r\n^:^~^~.     ..  .:^:...:. ......  ::P#7!^ :!:   . ...  .?JJJJJ?77?YY?7J!.:7~.  :?^:~7:.:YPGP7^   ........~:.  ..:?:...J\r\n.  :^^^...:::....  ... . .~77^:^.  ..  ^?^.:   :  .   ..~???7777777??7:   .:   .. ... ^:5&B. :~...    ...    :^.~7.. ~?\r\n:.  ....::::::..  ...  .:. .!!^  .::7?~?YJ!. ..      !!~~~~!7?7777777~^.   . ..  ~?^ :!7&&^..     .:.  .:~:.:^:^7!:....\r\n7????JYY?:^!~ ...  .^.    .   .:^^^~?JJ?77??7!~~!!...~..~::~~~!~^:.^~^?!      .   :^7^. ::..  ..... ....^7:.~^::~!^:^:.\r\n7JYY!7??7!:::::^~:..^^:~7YGJ ...!55J7777!!??7^.:^::~..^!Y?!?JJJYJ77!..::..7!^^^:^!7J5!^!::. .~^~!!^  .....:~.   :.  :~~\r\n .:...:^~^:7J?7!7JPPPPPY7YP^.~:~?J????777??7~:!7YY!?YPBB5~    . .JG5?::~:.^^:~7?J777?JY?:::  :!~.......:.  ... :^..   .\r\n  ..:^::!?Y5?!!!!?7!~^.:.   ^J^   .:!7!!~:::7YPY~  .~!::. :.  .: ^YPGP!~55!:.^???!!7777JJ7~:.     ..   ..  .......:..:^\r\n  .:^:^^777!.^7777?J?~:~7^  .. ..   .^?!:.:!G?^.  .  :  ~~.^7..^:  :..  :YGY~:~!7?77???YP7... ?P?^.  ^:  ....:!~^^^::..\r\n^^  :.:!^YPJ!!!!7!~!~^^!~..    :.     :::. ~!Y#B: ^ .~:JG5G&&P757..  ..  .?GY::.^!!7!^::^^^~^.?GYGG5J!~^~~:. .^::7YYJ??\r\nJY7!!7~7.:?J?!!?5PY?~...  .^J      .:77:..^Y~5BJ... !7:P@@@&@@@B^~? ...7GP~Y~..:!?^..     J~:  ...~J5PP?!!?J?^.!!!7!7JJ\r\nJ?JY5?::^. .:~~~~!J5GGYPY.^~^^:::^~!7!~.:.?GJ.  ..  ..!5?P&&B5B5:~. ^ .G#P~! .:.:.     :     .^~~^~!~!7!!!!?P5~~^.^. ^~\r\n..::^~^~7:....  :^  .^?PY ...!5Y???77?7!~:~JG5^  ..^  :~:.7~.~!. .  .. .^7P?:.:~?~.   .. ..  :7!.^?J?7777~.~?!7^^:^^.  \r\n^:..:.......  ...   .     .:^7JJ?777!!7??~.:!Y5~~5GPY^ ..   : ..:~~.  ^?P5J::.^!!!!^.   :J~.  .:.:~~7?!!!!75Y?!::^^..  \r\n:   ..::. ..  .:.......^!:  :::7JJ?777??7~:^^::!::?5G5.      :YBBG5?~J5?7:^!7?777??????!:~::YY!JPPPPPJ7!!?J?^^~^:..... \r\n~~:   ..  .^:.. ..  ^!7!^~: .::!~!5Y?7~^^^^~7:.::..!?7?JJ?J?!75?^..~::^:.:7??7!7777?557... 7G5J!^^^::^~^:::::!77?7!JYJ7\r\n.^^:^!~:::~.:7~:...  ....  ...: .:7~:          ^J^^^..^~!!~~::!..^:..~7~~!!??77?JJ?!~~^:.   .    .^.  ... :7^:7YYJJ????\r\n....:~7~.^:.:~:.  .:..    ..:#@?~^ :7!  .. .   .^~7777777?7!^^~~!7.     ....!?YJ!??^::  :~!. .:.. ...  ..:::::::.... .:\r\n?! . ~!::^.    .:    ...^^  P&P:^  ..  .   :.   .7???777777???!::   .  :.  ..^?~  ..  .^:^77~. .....  .:..:::...:^::  .\r\nJ^...?^..  .:^........   :!5BG5^.:!!^:?^  .~7^ ~J7?YYJ????JJJJJ.   ..  .  :!^ :!!GG::  ......  ::..::^.  ..     .~^~~::\r\n!...:~~~.  .^^ .:^!7. ..75J.Y5!~~7JJ:~7:.  :~!~^  .77!^^~7Y7.:7!.:7~.  .^.... ^:J@&  :.   ....  .~7..~::.^^. .~!~~:...:\r\n.....:^^~~~^. .:!J~.::~^75:^5~:7JJ?~7~:~7??P&B5!.  .:.  ....  ^~?^:  .^?^.^77 .?PG#: ^~.. ...  ..:^::~:.~!!~^::::...:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("....!???7!~:.....!7^^^.   ..: .  ..   755PP^^J7.^?Y5#G!~:.  ..^?Y?: ..   ....~YP57~~?YJ5757 !77:~YY7:. .:^~:^:::::..:..\r\n..:..:...:::::^!!~:.^:.:~:. ....  ..7  7&PY^ .?~. ..!BPJ:.  .:....^.  :^7?Y5GG5Y7!J?7!P::55~:  ~!!^:. ^^::.^^^....:~!. \r\n^^:::..:^~!~.  :^..:!::~!:.  .... .  ..~@&~~. ..  :~^.~~. :?!^:.::^^.  ~?P5^....^7~:7PPJYJ^   .::... ~^.   ^^7~.. 7YJ?7\r\n..^^.^~^~.   . :.  .::.. .^. ..:.... .:~Y~~!.:7!  :^. .JJ?JYJ?7!7J5Y~^!!.^~:   :^ ..YG&J..:  :.  ....... ....?...:JJYYJ\r\n  ..  .:::....::....  .:... .~?J?~^:. .:. .?J:.      ..~???7777777??J?~  .~: :^:  !~B@J  ..   ...  ......^^^7!.  ^!?JYY\r\n  ::....:::::::::..  ...  .:.  ~~:. .::!YJJYJ?!:.:..^!~~!!7??777????7^.      .~:^^~.JY::   ....... .:?^ :~:.~!~^.. .^!7\r\n!7??J?JJYYY?::!^  ..  .^.    ..  .:~~~~7???777??!~~!7:.~:.^^~7!~~::~~~?~......^?5~....  .:.:^^:. :^:.~~^^:..:^^.:~~^:. \r\n7~!7JYJ~!?7!!:::^^~~^::~~^7JPBJ ...!55J7777!!???^..:~~^??7JYJYJJ?~~~ .~!~~!7????JYYJ^::  ^7J?!~. ....  :.   :   .::!^:.\r\n^:  ....:::~^:?J7!~7JPPPP5J~?Y::~:~??77???7777!~^7Y5Y^^Y7  ...:.^YY??7^:.^7??!7777?7~^^:...:  .... .:.  :...^::. .:~^~^\r\n^.  .  :^.~~?GGYJJ77J7!!^.::   ^J^   .:~!!!^.:.?55?:   .^^. . .:.~. !PP?:~7??777777J5Y~..  .:    .....  ..:::........  \r\n~77?Y?::~^!^.757~~!?Y?!~:.^.  .^^      .~Y!..:7G7~. ... .::~^..:.    :YPY:::~77???7?JJ^.^ ~&#57:.:^. . .  !!:~77!~^: ..\r\n7JJJ??JYJ!~^::^~7???YPGGP!:~:.^!!    .^~!!^..:5P:^:..!  :!B&#?:. ~:..^:5P^..^!!~~:.   ~!~.:!^!PGGPY?7?7~^.:^^!J5Y??JJ?7\r\n:..:^!!7?~:~!  . . .::.:75B&? ^.^JJ777??77~:::YP5^     :..^!::.. :. .~!PJ:..~Y!:      :~.  .^.:~!?YJ7~~7Y?.:7^~::7Y??7!\r\n  ........:::.........    ::  ..^J5Y?77777??7~:?PP7 .~::: . .^^.   .!55Y::.^!!!~:.   .J^.  .^.^~!7?77JJJPGY^~.^^  ..  ^\r\n:~^~:. .:::...:.  :.  ...  ....:^^~777777!???^.::7J?JY^.....  ~Y^:J55?^~!77777??7777~:~^.??^7Y5PPPJ7~!7JJ^^!^::. ..  .^\r\n.::!:..   :.  .:  .... .^!7J7~  .::?YYJ????7!!~!!. ^~~7JYYJYJ??J~~!^..:7??!!7777?557... 7BGY?!~~^^~!~^^^::!!77!~?Y?7~~!\r\n .:^~~: :^^..:^^~^..^: .:^^:.^.  ..:.^5J~:.....^J!~~::^~!7~^^..~..!!~^!???77???7!~~~:.  ..    .^.  ..  :!^.7YYYJJ?J??77\r\n7~^. ..^~!~:.~^ :?^.  .......  .:7J.^~^:~.      .^77???777??7!!~~!~..^::!??JJJY7::.  :^~  ...  ...  ..::^^:^::::...::  \r\nYYJ?!^. .~7~:^......  ...   ... !@&7!. :~: .~.  :?J??7777777???!..       :?J: .:. ..^~?J?!. ...:.  .:..::....:::.  ..  \r\nJYYJJ~ ..7: :.  .....    .. ^. !#B5:. ^:.  :~^.~7~~Y5J7777JYJ?JJ: .::  ~?:.~~^?!:.  ...:::..^: ..::.  .:..   .~^~~.:~. \r\n7?JYJ...^7^^.  .:~....::.   :7YJPG?:^7~....:J5?~  .^~^:.:^!J^ .~~.:!^   .  ~^B@?..  . ..... .:~!:.~:. ::. .^!^~:..::::^\r\n..!!^....^^^...:^..:^!!!. :^Y5^.57!?J7!J5PGPPJJ~:   :....:.  ..?5G7.. .^?: :JP&Y  7.   .... ..!^.:~::~!!~:::::...:..:..\r\n..:...::::^^~~^.  :!JY~:!!7.~5!YYJJ!~!YP57....   .. :7YJ^..  .:~!G&YJ?^.!J~:PP5P7.  .:    :..   .:^:77:.....^!!7??!:...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(".   .  ^?JYYYJ?7!:. .?~.:.  ..........  .Y57:5?JPP! .~.   .:. .!7^ .....  .:   .:~JJ~!^ ^!?77YYY!.   ...^^.:^^......   \r\n  ....:!??7!!^.....:~!^:^:..  .:.   .: . .7BPGY?5PBG!.:.  ...:JP5?. ::   .:: .!YY7~..Y5~~:.:^7!^: .^^~^^^^.....:~.    .\r\n::..::......:::::~!!~..^:.:7~.  ....   ^^  &#J^:.::J&BY^:  .:.^7^:^.  ..^^~?PGGPY5P~?5?.   ^~::: :~.   :~~~.. ^J?7~:...\r\n~~^^::::..:~^~^. .:: .:~.^7~:^.   ....  .::&@J~:  ::^~^  .!^:.....:.. .!5BB7~^^^JPBG~..  ..  ....::.   ..7^ ..?YYYJ?7~~\r\n..  .~:.~~~~.   ..:.  .:... :: .~~~^..:  ..^..!^.^7: :J?!?5Y7!~~!?YJ:.^~:^:.  ^:Y&#. .~.  ..  ...   .:~:~7. .:??JJJJ?7!\r\n     ..  .:::....::..:.  .:... .~J55J!: ..:~:.757:    !???777???7?JJJJ7. :?^.:!:G&!:.  . ...:. ..!~.:^:.~7:...:^7JYYY?7\r\n..   ::..:::::^:^^^:..  ...  ...  ~^:....:~JYYJ???!^^~~77??77!777????~.   .~J~.  .   ....... .:^:7?: ~^::~!~^:...::~77!\r\n~!777?JJJJJY5Y7.^!.   .  .^.    :.  .:~!!!77777!7??7^:^:.^~!777!!~^!!~~~!7??YY7?~:: .~!?YYJ7. ::..:^~:. .:.  :!!~:. ...\r\nJ^~!^^!?Y7~~7!7!::^~~!!~^^~!!J5B#7 ...?55?77777!7??~.:^!7?J?JJ?7~:.:::7??7777?J?^..: .~7!::.....:.  ..  ::.    .!:^::::\r\nJ^~^~:~7J. .~~~ .JJ!::7YGGP5Y7^77.^~:~7777??77777~~~?55J::^::^!~?PY!:^???!!77777?7!~:.     ..   ..  .....:.:..:~~^:.^~.\r\n^7??JJJ?????7!7::!??7!?5GGPJ~... .~Y:    :~!!~:.::Y55~   .    .  ~5G?~~!7?777???YP7... !?~.   ^:  ....:~^^::...    ... \r\n  .:^^~7?JJY?::~. ..::::^!?5GPBG.:~:~!^^~!77!~...7G5~  .  :~^ .   ^5P?.:.~!77!!~~!!:^^.5#GG57~^::::.. .~::7YJ??7~:^:.  \r\n  ..    ...::^^~^..... .^.  .~J? ...!55???777?7!~~7P5~       .   ^J55^..:~!!~:.   .Y!. ...^?PGGP?77??7^:!!7?????JYJ??!^\r\n.~~..^~~^..:.......  ...  ..     .:^!7??7777!!7??^:!YPJ~~^.:::.75PY!!~!7777??7!!7~:~^.~7^~JYPGGY?:.~JY: ^~~. .??~:~^~~?\r\n::::^:~:    .::  ..  .:.....::~7~. .:.^7??7777??7^.:.:~7?JJJJJ?7~^.^??7!77777?Y5J:.: ~BBPY?!!~~~77!!~^:~7!7~^!Y?!^^~~:?\r\n... .:~!!^  .:. ..~^:. .:  !JYY?7!. .:^??JY???7!~~~!^^~!!77!~^..^:^7??7!77777!!!!^:. .:.    ^:  .   .!^.!Y5YJJJJJJ??77!\r\n~77~::...:^^!~:::!..77:^^. ..:....   .. .^Y!:   .^7???777!77??77!~~^!???JYYJ!:.:...:~  ...   ... ...:^^^^^^^^:..^:.  ..\r\n7?JYYJ7^:...:!~..^:.^7:. ..... .  .:^BB^!^.:?^  !JJJ??77??777???!.   .75J:^~^:...!?Y5J~. ...::  .:...:....::..  ...    \r\n!7?JJJJ??^. .7!^^^.   ...  ..  .^.  G@P^~  .:^:~~:.JYJ!~~!7J5J7?Y^ .!~.^!. ::.  :..^~!~: ::  ..:.   :..    ~~~~.:~.   .\r\n!~7?JYYYJ:..:?...  .::....  .:  ..^P#PY:^^^~G#57. ..::....:^!:  ^^^:^. .!7&&^:.  ....   .^:^7~.~^. .:.  :~^~::.::::^^~~\r\n...:~7?J! ..~!~^   .^^ :::~^   .75J~5PYPPGGY7~~::   ^::!^.:.  .:JG&Y:: ::?B@. :^   .:..  .^?:..^:.^~!~:::^:......::..:^\r\n..   .~:.....^^^^^^^: .:!7^^..^~Y5..~7Y5?: ::.   .: .?5PJ^... ..^.!GBP5?JGPB?. . ..    :......^::!~::....:~!!7?7:..... \r\n   ......^^:.:^.:..  .~JYY7!?!~ :7~7Y!^.   :..  .... :77: .::   .~. ~PPY?P~!55.  .:......... .^.^?: .:!7?JYYYJ?!  .    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  .:  ..  :777???JJJ?...:7...  .:~..::^!:  .?5J!.  .... .:..  :^^^.  .. .   .::^7. ~7?7?YY75Y^      !~..^~^....... .. .\r\n....   .  ~?JYYYJ?7!^. .!7:^:. ....... ..   ^55PY:  !.   ...  :~^. .....  ....  ..7?~~~::?J!:. .^~~^:^:.:...:. .   ....\r\n.  ......:!?7!~~:....::^~:.^:.:.....    ...^ .PBPBY: :   .: .75G57  ::   .^:  ^?Y5P~.  ^7~::. ^^.  :~~^...:!?~.. .:.  .\r\n:.^^:..::......^^^::~!~^.:^..:!7.. ....    :. ?@P~Y&BY~:   ::~YY7~: . . ...~J5PBY!:  ....... ^^.   .:!!...!YJJJ?~::^!J5\r\n~.:^~^^::::.::~:~:   :: .:~:^?~:~^.   ....  ::J&Y~~!!~. .:::. ^. .:.  :?P##JJB&?  ~. ..   .:.  . .:..7: ..?JJJJ?77777?7\r\n....   .~:.^~~~.   ..:.  ....  .: :7JJ7~::.  ..  :7^^?!^!5J!~^:^~7?!. .^^!!^G@5...    ..:.  .^:.::^:!7...:~7?JYJJ?7!  .\r\n ..     ..  ...:....::..:.  ::... .^755Y?^ .::!?~75J7?JJJ????????JYY???~~~^ .!..   .... ....:77. ^^..~!^:...:!?JYJ?:  .\r\n~....  .:^::^^^^^^^^~^... ....  ...  ^:..::.:^?JJJ?7??????7!777777????7?5J:~::.  ^^^!7!~: ^!::7!::^..^~~.^^^:...:~^:...\r\n  ^7??77?JJJJ?Y5Y!.:~.   .  .^.   .^.  .:!!77777777!??7~^!777777777???77?JYJ~::..^?Y55J7: ... ..::   :   .^^!^:....::..\r\n .^7Y5?!7??JJJ???77~~~!!7?7!!77?J5B#! :..?5Y?7777777??!:~7!?77!~::7??!!77777~:.^:..:^...... ::  .:...^:.   .~^~^::::^^~\r\n.... .^!7?JJ?JYY!:^:.:^~7???YGB#P?5?:~~~?J?????777!!~!!J5J7~!J55!^7??7!77777JYJ~::   .     ....  ...:.....::::. .~:   .\r\n      ..  .:^^~!~^~7. ...  :: .^?P#? :.:?Y?7????77~^:75G7     !PP?:^~777???7?YJ:.: ~#G?^. :^  ... .!!^~!~^::.  ..      \r\n.   .^. .::::.....::..  .....    ..  ..~?YY?777777??7~!55?!^!?5Y7!^~!777????7J?~^!:!P?P#BPY?777~::.:^:~Y5J?JJ?7!^. ....\r\n~^^.::^^~^!.   .:^...:.  ::...... ::..:^::~77777!!??7::^!7??77!:!??7777777?Y5J:.:.^B#PYJ?777?J?77!~~!7???JJJ??7!?YY7~. \r\n..:::...::!^^.   .   .:.  ... .!?Y5Y?~..::^JYJ?77???7!7777777!^^7??!!77777777!^.. .^..   ^:  ..   ~:.~J5YJ?JJJ?77??7~  \r\n...::~:...:^~^.^~^..^^:~7::~^ :~7?7~^~. .::~:?5J7????777777!7??????77?JJ?~:.::..:^  ...   ... ...:~~^~~~~~^::^^.  ....^\r\n.. .?JYJ7!:...:^!!:.^^ .7?:...  .....  ..~. :^!~?J?JYJ?????????JJ?7JY?~?7::. :7J55?^. ...::  .:...:..:.....  ...    .. \r\n.  ~7?JJYJ?7~:...!7::^:.:^.. .:..     ..?@#~!!^^:  ~J7!^:^~!J5?^!J~^7^  ..  .^:^?JJ?^ ..  .....  :...  .~~~~..~.   ....\r\n!777777?JJJJ?:  .?:.^:    .:.    . .!. ~&#Y?B#GJ:   :...^..::^.  ^~~^!?#5::  ....   .:~:^7~:~^. .:.  :^:~:::::::^^^^:.:\r\n5Y7~::~?JYYY7...~7:.   .^^ .......  .~?BGPY!:.:..   :~!JY~::.  :^YG&P^5@P .:.   .... ..!7^..^:.^~!~::^^^:.....::..:^~::\r\n..  :. ..^77^ ..^~~:   :~..::~7~  .:555J!. .~.   .:. !YGPJ: ..   : :YBGBG. ^:..  . ....::.:~::~~^:.....^~~!7!:....... .\r\n. ..   . .^...:.:^^^~~^:  :~J?::^^~7?:.  ..... ..... .^~:. ...   .~. .YP55!   :. .......  :^:!7. .:~77JYYYJ?!  ..  ....\r\n. .. .......:~~..^7      :J5?JY?777!  !^.:.   . ..  .^^^:  ..:. ....  .!J5J.  .!^::. ~:.  .. 7^ ..7JJJJ???77^  ..  :: .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" :.  .. .:^!?J?7!!7?YYYJ7...!!^^   .^: ::~7^.  ^^::... : ..:!~:!^^.~!.. ...:...:^~7Y5J~?P?. ..  ^!. ^~~^::. .......  :.\r\n..   ..  ..  ^77?7??JJJ?^ ..7: .  .:^: .:.^^      ..   .... .:~:^~:.... .. ..::~?:.^^?YJ!.  .:^:^^:.::......    :..   .\r\n......    .  !?JYYYJ7!!^...~?~:^.    .: .  ..     .~.   ...  .^::.  ..:.    ..  .  :~!~:: .^::.:^^:....^!^    :.    . .\r\n^... .......:!7!~^^.....:^^^..^^.:~:.  ...  ..!.   ..   .: .!JPPJ~ .::   .^:       .^:.:..~:   .~~7:..:YJJ7!^...:~7??!~\r\n.:!::~^:..::.....:^~^::~!~^.^^ .~!7::  .... .  ..:&5?^:  .:^75GPJ!. .   ....  :. ..  . :....  .. !~ . 7JYYY?7!!7J5PGPY7\r\n~^?^.:^^^::::::::~:^.   :. .^~:~!^^:::........  :^5?!. ...:..!7:..:   ^75PP. .:.   ... ......:~:!?:...??????7777!^::.. \r\n:::...    .~..^~~~.  ..::  .....  .. ~YPPPJ!^:. .:.  :.^Y?~^::::^~!^  .:!G!:.  .......  .!7..^^.:~^...:^!?YYYJ?7. .:.  \r\n~.  ..    ...   .......:....   ::... .^7Y5Y?7..::~YJ?YJJJJ??7!77?Y5J!~.....  ...:^:...:^:^??  !:.:!!~:.. :^~7??!. .    \r\n  ^~....  .^^:^~~~~~~^~!:... ...   ...  :...:^:.^7???77777777777777?JYYY!::. ^?YPGG5?: ::..^~^:...^: .^!~^.  .:.:......\r\n  !^.::..^?Y5P5?7J5J^ .^  ...  :~. ..:^. .:^7777777777!7??77!777?7!777?7~..^:^^7J?~^: ..... ...  ..   ..:~::...:^:::^~:\r\n.. .  .  .::.:~77?J?^:~: . .   .  .!P#&^ . .J5J?77777777?!!!!!7?7!!7777777~~^.. .   ... ...  ....::::..:^~^^.^^..:^^:.:\r\n....    ..    ......:^^:..... .^.  .:~^ ...~55?777777??7!:?7?^!7??777777?Y57... :~:.  .:. .....:^^:......    ..    ....\r\n^.::::..^~.:^~~:..::::....  ... ...   . ..^~~7777777!!7?7!!!!!?777777777J5Y: . .&&G7.  ..  . . .!^:7??7!~:..:.       ..\r\n:~^^::^::..::~^..   .:  ... ..... .:^7J7^:^^..^7?777!7??77!77??7!!777777??7~:. .~^... ^^  ..   :. :?5J775P5Y?~...:.:!. \r\n .....:...  .^~!^. :^. .:^~^:.:: .?5GGG5J~..::!YYYJ?77777777777777???7^::::...:.  ..   ... ...:!~^~!~!!~^^~^: .....^~  \r\n    .  ~7?7~^: .::~!!:.:!  7J^:^:..::^:..:   ....~!J5Y?77!7???JJJYJJY!::..!?JYY7^......:.  ............   ...     .. .~\r\n.  :.  !?JYYY?!^:...^~:.:^..!7:. .......  .:^P!:.  :7~^::::^~?5!.^. .:. ..^!JPGPY! ..  .....  .:..  .^!~~..~:    ....::\r\n ..:::~7777??????:...7!^^:......  ...  .:.  YBP?^.  :. .!!..:... .~!Y~:. ....:...:::^:~!:~^.  :.  .^.~^:::::::^^^:.:?^~\r\n!J5PP5Y?7!7?JYYJ?.. ^7.... ....:..  .. .^   . .   ...~?5G57^:.  :^?5&~..  . ....  ::!!!. :^.:^!!::^~^^.....:::.:^~^:!^.\r\n~7?J?!^:..^!7JJY~ ..!!^:   .~: :.::..      .~.   .:. ^JPGY7. .:   ...  .7.   ...  .:!:.:^..^^^^.....^^^~!!^.......  ..^\r\n. .    .:.  .:7^:...:^^:.::^: .:~!!^  .  ..    .:..  .::^:  ...   .~.     ..  . :..   .^^^7!...:~!7?YYYY?7. .    ......\r\n.   ..:.   ......::::^^:^:.  .~?YJ^^..?!::.. .. ....:~^:^:. ....   ..      :^.....^:.  ...?:  .??JJ????77~  .:  .:.  ..\r\n.:. ....... .:::~~^ .~~  ..  !PY~?55?!^:...:... ..!~.^~!^^!:.. :. ..:::^. .^7!:: .~.   ^^~7...!JYYY?7!!7???!^:   .   ^ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(":^:.  ^~.. ~JPBBG5?!^^!???JY^ .:^~^:..:^^ .:7J7~:...::..  ..^^..:.:^::^:     .^^.  ..:. ::. .:. :^~~^~:  ...........:~!\r\n:.. :.  ..  .^!7??7!~!?JYYJ?...^7:^.   :~ .::7?7^:....:. .:!~.^:^:.~^.  .::::....:!JJ~.  ...^~:.^~^......   ...  ..  .^\r\n:~... . :.  :.  ^77????????~ ..!!.:.  :::.....:. :. . .... .:~~^!~:^:.. :. ..::!?7?~:. :^~~^^^:.....^: .  ...     .~: :\r\nBP:......    . .!?YYYY?7!~:...^7~:^:..  .:.    : .:.. ....  .:. ::.  ...    .:.:!~::. ^^   .~~~:...?J7~:. .. .:^^::.   \r\n?!:^..  .......:!!~^^:....:^^^:..^:..!!.. ....   :!:   .:. :7J5J!. ....  .:. ... .....^:   ..^7...~JYYYJ7~^!?5PGGPY!.. \r\n .^.:!::~^:::::.....^~~^:.~!^:.^^..~?~::.  .....   ^:.  ..:?5B#GY! .:.  .:!: ...   :.    .^^:7^ ..7?JJJ?!~!7?JYYJ7~. ..\r\n?7!~^7:.:^^^::::::::~.:.   :. .:~^~~:^:.:^^^^^..:  ...   :..7YJ^.::  .:::   . ..:.  .^!.:^^.^!:...~?7?JJJJ?7!....   .. \r\nJ?^::....    .~. ^~!~.  .:::  ... .  .. ~YPBBGY!: ..:^~?!^:.:!:..:^.....  .....   .:.~?~ .~..:~~:....~7JYYJ?:  ..  :. .\r\n  .^.  ..    ...   ............   :......:!YJJ?7~^.:^JYYY?7!~^~!7J5J!::. :!!?YYJ7^..^:^J~.:~:.^!~:^^:...:~7~:...   ....\r\n. ::   ....  .:. :~!!!!!~!!:... ....   ..  :...:^^.^!777777?????????!..~:!JPGGG5?: ... .:~:.  :.  .~~!^. ...::..... ...\r\n7^:::..      ..   ..:^~~~!7:.... .~!....:^  ..~???7777777!!!!!!7?777!^.:^:.:~!.......::  .:. .^..   .~:^^::::^^~~~~^~^:\r\n!~~7.....  .~: .^^^:..........  ..    . ..  ::~?JJ?7777!!!!!!!!!7777?JJ?!::   . ..   ...  .......:.:^^^: .~:  .:.. !!~!\r\n::~~^~~~^^:::::~:!.   ..^: .:.  ::.......~~:..^^.^!77777!!!!!!7777777?JJ!..  ^:....~~. .....!!~~^^:..   ..      ..::::7\r\n... .:...::... .:!~~:   :   .^:. ... .7YPGGPJ!^~..~?????7???777777!^::^:....  ...  .... ...:7!~!7!7!~:....  ....   :^ .\r\n....   ...:^!~:...:^^:^!^.:^^.^J~.^: ^7J55J7!^  ::~J5Y?!!~~!7?JYYJ~:.^~77?JJ!:......:.  ............   ...     .   ^.  \r\n. .:  ... .7?YYJ7~....^^!:..~. ~?~.::.  ......  ....^^:..~:.:^!?~~:.. :!YGBBGY! ..  . .... .::.. .^!~^..~:    ....:::7?\r\n ..   ... ~7?JJJJ?77~...:!~.:^:.~~.  .:..  .  :::.  .^.:?Y7..:.  .:.  :..^~~~^:..^:^~^~^.  :   .:.^^:^^::::^^^:..7^~!7?\r\n... ^7?JJJ?77~!7?JJ??.. :?^:~.    ..   . . :!:.   :. ~JPBB5?^..  .:^.  ....   .^:~7!:.:~.:^!~..^!~^:. ..::::^^~^:!^.^. \r\n . ~YPGBG5J!~~7JYYYY!...!!..   :::.... ... .:.  .... .!J5Y?^. :.   :!^   ....  .~7:.:^..:^~^:....:::^!!^.......  ..^:^7\r\n   .::^~^. ....:~7J?:..:~~~.   :~..::^!: ..    .... ..:..:.  ....  .:. :.   .:.  ..:^:^!~...:^~!7JYYYJ7. .    .....::Y#\r\n^ .!.      ..    :~.....:^^^^~^:  :^???7^:.. .: ...::~!^^~^. ....    :  :.....::.  .:.~7.  ^?????????7~  .:  .:.. ...~~\r\n^.  ..  ..:.  ......:~^..~^...  .^?J7^....::::.  .^!:.:^^:^!:.  :....:^!?7::: ~^   .^:7~...?JYYJ?7~!7??7~^.   .   ^ ...\r\n!^:...........  :~^~~^^  :.  .:. ::.  .^^.. .  .:::^:.::.^^..  .:::...:~7J?:. :~:..:^~^:..:YJJJ?7~^!?YGBBPJ! ..~~  .:^:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("PG!:~!!~::  . !J5PP5J!:  ..:^~?~.....^^^~!^.    ^~.      :~!!^::.:::^~^::^7^:.^~!:  ...     .:^^~~^..  .:...:...^75GGBG\r\n#&Y:::.  ^^.. !JPBBBPY7!~7?JJJY7 ..~~~^  .:~. :...:^:.. .:.:^::::::~^^~.  .   ~~^.      .!: :~~:.... .. ...  .:  .:^^~!\r\n:~7:.. ^   .   .:~!??7!^^7?JJJJ:...?:..   .~. ::::...:.  .~^.::!:.:~:.  ..::::....  :^~~^^:.::...: .    ....  .:: :~?~.\r\n   ~~... ..:.  :.  !7???????7!~.. ~?:::. ....... . . . ...:^~!~~!~:~^.. :.....::: .^.. .^^^:...~7!:.  ..  .....:.  :!!^\r\n..!#J::.....    . .7JYYYJ7~~^....:~^.^^..:.... .  .. .:..  .^.  ^:. ... .   ......~:.  .:^?:...JYJJ?!^.:~7Y555?!:   .^7\r\n.:!!^:^.. ........:~~^:::....:^~^:..~^.:~?:. ...:     .:. .~7??!^. ..... .     :.. .  ::.~!.. ~?JYJ?7~!?JPBBBG5?: ....^\r\n:.. .^.^7:^~^^::::.. .:^~!^..~~^:.~:.^?7^:::.   ....  ...:?5B##GY~ .:.     .:.  ..^..:^:~7^...^!7??7!~!777!~~^:. ..::  \r\n?JJ?7!~^7...^::.:::^^:^^...   :  .^~^~^:^. :!7JJ7~:::   :.:?5G57^^.    ....  ...:^?^ :7..:~:...:~7JYYYJ?7. .:   ..   ^ \r\nJ777!:::....    :^. ^~!^. ..::. ...  .. .  !YGB##GJ~ .::::.:??^..:.  .^:^!!~^..:.:^J7..~..:!!^:...^~7JJ?!  ..  .:......\r\nYJ7!:.::..       ..    ...:..:....  .:......:!J?777J7..:7!~:.:^~~:::.^JPB##BPJ: :^.^!^:^...^^..^~^:. .^:::... .  . .::7\r\n7???!^^:...    ::  .........:::..  ..    ..   ....:^::^~7??77??7~: ^Y!!7Y5Y?!: ..... .:.  ..   .:^~::...:::.:^^. :.:::7\r\n .:^:^?~::^^^:.:^:^^~~....:::...:  .:. .... .:. .:::~!77777777777!~:::. .:. .... .:.  ....:::.  .^~^~:^:.:^^^^:^?~:^:. \r\n7:::.^..^^::::::...:~~:.   .:  .:.  .... .~7JYJ7~~J~ .~7??77???!^::^:....    .     .  ...::.....::..  ::    ....~^!7?77\r\nJ::: .  .....::::. .:^!^..^^:..^^^!^.:^ .?5B##BPY~.:::~~^^.:~!7^..!J7!!7?!.......:.  ....:......    ..       ..::.:!?JY\r\n..... ..   .  ~?JJ7~^. .:^!!^..!..!Y~:....^!!7~:^:  .:..:77^..:::. ^JPB##G57  . ... .....^:....^~~^. ^:    .....::~!!7J\r\n :.  ...  :.  !?JYYYJ7~^....^:. !^ :?~:...  ....    .^^!YP5?:.:.  .::~?JJ?7^ .^::^^~^.  ..   ..:~:^^:::.::::..!^~!7JJJJ\r\n  ::.. ..:^~~!777~!7??77~...:7~:^:..^:.  .:..    .:. ^JPB#BPJ^...  ....   .::.^!?~..~:::~~..^!!~:. ..::::^^~~:7~.^:..::\r\n^......7YGBBBPY?7~!?JJJ?7 . ~!.::. .  .:   . .  ....  ^!JJ?~: .:.     .... .:7!:.^~...^~~^::..::::^~::....... ..^::~~:.\r\n7~.   .!J5P55?!^:^!?JJYY^...?~:.   :~:......  ..... .:^. .:.  ..:. ..  . ....::.:^.:~^....:~~!?JYYJ?^ .    .....::7&?..\r\n^!~^  .:.....  .:  .:!?!...:^~~.  .^: ::::....:  .:~:~!~^!~^:. . .     ....... .:^:7!...^!7?????J?7!  .:  .:.. ...^7   \r\n.^?!^ :^.   ...    . ::...:.:^^~~~:. .....:::..  .:~:..!^::^!:.  :....:::..~:.  ...?:...?JJJ?7^^!777!~:.   .   ^....~~.\r\n!~^^:.  ::  ... .......:~~^ :!:       :~~   .  .^^^~::::::^^.:. ..:::...:. ~:.  :~~!.. !YJJYJ7!!7JPBBBPY!...:~   :::?&#\r\nGGGP5?^........:  . :~~~^^:  .  ...  .!~^.::!^::^~~^::..:^!!~:.     .^^  . .^!!^^^.....~?!^:... :!J5PGPY7..  ::^!!~:^GG");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   .::^7:.^?~::.  .::^^:.  .:    .^...::::^:. .~!^::^!!^:. ..^~^.!!!^:::.......^:.::    ....^!^:^..:^.:!~:..^!5###BG^ .\r\n?J5GB!:~!!^::. . !YPGPP5J!:..:^~!??:....^^:^~~~~~:   :..:~~^::.......:::^~!^^:^~^.:. ~: .^~~^::  ......  .: .^^~!7JY:  \r\n7YPB&Y:::   ^:.. ~J5GPGGY?7!7?YYYYJ...~7~~.  .^~.::..  .::^~^:::::^!~~^. .:   !~!^:::~^.:^:......   ....  ... :~!~^^^..\r\n:^:.^~....^   .   .:^~777!^:~7?JJ?~ ..!~ .   .^^ ...:.  .^^:..!~..:^.... .....^~^:::^^^....:^~.   .:       ^~ .^7!: :?~\r\n~Y:   !!... ..:.  :.  !7?JJJ??7!:^...:?~:~:   ..:.  :  ..^~:!~7!~::!^.  :..:. ~^.   ^~!~.. 7Y??!^....:~77!^:.  .^^!?:.^\r\n.. ..7#J::.....    . :?JYYJ?!~^:....:~:.:^:.~:.. .......  .^:. .~^..... .  ......  . :?...^JYYYJ?7!7J5BPG#GY7    :~?^:^\r\n....:^^::^.. .......::~^:.::..::^~~^:.:^7::!7^:  .....:.. .^~~^::   ..:... .......^^^7!...~77??7^:~7?Y5555J7. .:~. :~!~\r\n::^::..:^.^7:^~~^::::.. .:~~!^..~~:::!:.~J!:..::....... .7YGBBBP?. .:.....  .:?^.:~.:~~....:!7?????77!....   ..  :  .:^\r\nJ7?JJJJ?!~^!...:::.:^:^^:^: .   ..  .:~^^:.^. ^7YPP5J!^^:^JPBGGJ7~...::.. .^.:!?^:7^..:~::..::!JYYYJ?:  ..  :.   :. ..~\r\n77?JYYY?^:...:.    ^^  ^~!~:...:^.....  .. .  !YGBBBB5?:. ^JYJ~. .7?5PGPY7^  :.~Y~ ^~::~!!^::..::^7?!:...   .......77. \r\n::::.^~~^~?...:.. .~^.:^~~^:^^:......  .^...:...~?7~~!?J:....: :?7JPBGBBPJ^ .:..:^~:.  :.  :!!~:. ...:...... ...^:7#5..\r\n..^:..:::~:^~~^^^^::::^:!.    .::  ..  .:.......!7^..^! ..:^:.. !~..^77::.... ..  ..  .:.    .~:^::.:^^^^^~~:^^.:..:~..\r\n..J&?:^... ......:... .:~!!:  .:  .:~^:..:: :?5GBGBPY7J^ :..:..7J!~^!7!. .:...^:  ......:::::~~^:.:~. .:::..?!^~~^..:::\r\n  ~J:......   ....~77^::..::^~!~::^~ :Y!.:. :7YGGGPJ7:  ^?JJ~ .:75BBGBGY7  . ..  .....^:...:~!~^  :^    .:...::7YYYJ?77\r\n~....:  ..:  .:. .7?YYYJ!::..::~:..:!^^?!:.^. ..::...^!?PGGPJ~:^^~JPPP5?~ .^:.:^~^.  ..   . :~:~^:^:.:::...~^~~7JJJJJ7?\r\n~:.  :  ..   ....~77??????7:....^~:.~^.:?^.  .....:. .?5BBBB5?. .......::..:~J!..!::.~~. :!!~:....::^:^~~~:7~.~:..::^^:\r\n^~~:  ~:...!?Y555Y?7~:^7???7!...^7~^^....... ...:...  .:~!!~:  .:.....  ::7!^.!~:..^!~~::...:..^~::....... ..::::^:....\r\n~:^7!:    !YGBBPBPJ7!!?JYYYJ~ ..7^ ..  .....  .. .. .:~.  .^.  .......  .:~:.^^.:^:.....^^!?JJYJ?^ .     ....::7#Y:. ..\r\n~..77^^:  .:~!??!^....^!?JYJ...^7~^.   :~.....:  .:!^:~!7~!^~^... .   :..   .^:~?^...^:~7??JJJJ77  .:  .:......~?.  .Y!\r\n^?^..~7^. ^^. .    ..   .~~:....^^^::::~^::...  ...^:..^!:.:^^.  .:... :^:.  . :7.. ^?JJ??~:^!777~:..   .   ^....^^.:^:\r\n..^^^~7~^ ...  ...:   ......:^:.:~::::!~!.  ..  ^!~!^::::::~^::.  ..::.^^.   ~~!!...?JYYYJ7!!?YPGPGPJ!. .:^   .::?&BPY7\r\n  .JJ7!~^^. ..  ......  :::^~~: .~. :.^~^:^^!!^::::......::^~~:. :.  .~~~~~^:^^.....??7~~::.:!J5GPBGY7.. .::^~!~:^BGPYJ\r\n. :PG###P7^...~~:.:: .^.^~~:...    :^..^:......:::^~~!.:~^.  .:^!!^:.^!~: .:^::::...^:    ::  .^^^^^:. .:.^7~::7^:^..  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(". .:^^:.^~~^.^?!~~^.  .:...   ..   ..:..:~~. ~..~:. ...^7JJYYJ?!:!?JYYYJJ?7:::..:~~^^.  ~?~:^:.:~~?J!:..:^!YG#BG? :J.  \r\n:!:  ..::^7::~7^... .^~!77!~.  :. ...!:....:^^~~^:::~~:...:^!7!::77?7!~!^.... .^^.:..^^~^^^... ..........~7JY55P^   .:~\r\n!JJY5GBB^:~!~:::. ..?5BBY5B5J!^:~77?JY! ..:^~:.:.  .~:.:~^:.... .......::^~^:::~::^..~~:......  ....  :   :^^~~!^. :?JJ\r\n:~~!J5G&?::.   ^:. .!J5G55G5J7~~?JYYJJ^...?^^.   ...  .^^^!^:::.::^~~!^. :^. .^^^^^......~.    ..      :! .~77: :!^~??!\r\n.:::~:.:^.. .^   .   ..:~777!^:.~7?7?!.  ~7...  .:::.  .:::..^^^.::^.::.  .     ^~~^.. ~??!:. ..  .:^:...  .~~~~!7!^:??\r\n::^!Y.  .J~......:.  :. .7?JJJJ??7^.....:!!:^:..  ..  .:~~:~^7?!^.:!:.  ..::.   ..?^...?YYYJ?!^^!J5P5PPY7:  .:^?~  !^:.\r\n.. .. .:Y#!::....   .   ~?JJJ?7~^^.....:^:.:^..~7:. ...  :~^...:!^:.... ..    :^:~7...^?JJJ?!^~7JPB5JGBPJ:   .:~7~~~^~:\r\n ......:::::::. ......:::^:......::~~!:..:^?!^7!^::  ..  .::::..:.  ... .:!^.:^.:!!...:::!7~^^^!77???7!^. ..^^  :^^:7BB\r\n..:^^~^^..^~.~7:~~~^:^::....^~!!: .^~.::!..7J^.. .:::^^:~JPGPGPY!. .  .:::77..?:.:^:....^!?JYYJJ?7. ..   ..  .^  .^JBG5\r\n .^:~~~!!777~7!  :^::.:::^~:~. .   ..  .:^::..^. !JPBPGG5YGB?GB5YYYJ7~:. .:^J?^^~..^!^^....~7JYJ?!  ..  .:.. ...:..:.:^\r\n.......  .^:^!~^^^^^^.:::~^^^    ..^....   .. .  7YPB55BPJ?Y5JJPBPY#B5J: :^.!7:.~:.:~~::^^:...:~^^....   ......!B:   J7\r\n.. ..^PY^::.:. ::...::....:^!^:.  ..   ::.. ... :7Y5PPPYJJ?:7J?YPP5P5?^  .. ..::.  ..   :~~~:. ..::...::. :.:^^YG~.. ..\r\n!Y   .GJ:.:...   ....:^~:..::^^:.~~:.:~::!!.:: .?5G#Y5BPJJ5YJ?5B5YBPY7. . ...  ....^:.    ^~:~:::.:^^^^^^!~:::  .......\r\n~:....:... . :.  ..  ^?JYJ7~....:~!^..^::7J~.. .:~7JYYY5GBJGGYYGG5BPY7. ^:.::^^.  ..     .~:~^^::..:^:  ~?~!77!~~~~:^. \r\n5PGY^.. :.  ..   .. .!7JJYYJ?!^....:^:.:?:.77:::.  ...~YPG5GPY!^~~^^:. ..^??..!::.^^. :~!~^....::^^^^~~:7!.~^::^^~~:^..\r\nB#Y:^^:  :^.. .^~!7?777!~^^~77^::...~!:.^:.:!:. ...  .:..^^:^.  ..  .::~7^!?~::.:~~~^::..:..:^:::....:. .::::..:...... \r\n:~^~~~!~:.. ..?5BGY5BPJ7~^~7JJJ?~...!!:^^.   ... ...:^!^...:~:. ... ..!!..^^.:^::....::^!?JJJ?!.. .   ....::~#P^.. . ..\r\n.:^7. ^?~:.. .!YPP5PPY7~~!?JYYYJ:..:?:..  .::..  .:!^.^!?7~~:~!:.  ..  ..:^:~!^.....:7?JJJJJ?7. .:.  .. ....^5.   ?!^.:\r\n??^^~7!~~~~.  ..::^^:. .. .^!?J! ..^~~^     .   .:.^^:.^~~:.:::.  .:::.  .:.!!. .~?777!::^!777~:..   ..  :. ..::..~^:^:\r\n!??~^!: .!?~. ~^      ...    ~:.....^^^^^.  :: .:!~!^::::::^~~:^.  ...   .^:?:...?JYYJ?!^!?YP55P5J!. ..:   .::!#G5J!~^:\r\n?JJ~ .^~~~~^:   :. ....  .......^~:.^^:~^::^~~^:.....:. ....:^~^..^.  .:.:~^^.. ^YJ??7~^^!?5BPJGBPJ:   :::~~~::GBBP5JJ7\r\n!^.   :555JJ7~:.......... ..^^^~^^..:.:~:.....:~~!!77?:.~7~^....:~~^^:^~~^^:.. .:!:.. ..  .~7??7!^. ...:7!::7~:^:.  .7^\r\n  .7^ !GB&BP?^:...!J?~~:.:^:~7!. .^^^~^...::!??JYYYJ?7:~??JYJJ7^......^:.~..^~:..:..   ..   .....   ^^~!?~.:~^^..^^:. .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("...!?^~!77???~:^!?::^!!^. !^   ....  .....:^~~~^:..^::~^!7?77!~!!!!77~:.  .  ..  :::~~^::^..7YGJ^.  .^:~~5BGP:.?^ .!?^.\r\nY?:...::^:.:~~:.^?!^^^.   .....   :.    ::..:^^~:. ..^!JYYYYJ?~..~7?JJJJ!~^.::..:~~~~~~... .:..^^:..:~JGB#BG7  .. .7^~^\r\nJ^.:7:  .:~:^7::~7^... .!?YY5Y?!: ....:^!!:....^:::^^..::^!7?7~.~??JJJ?7~^:....~~~~^:.:. ....... .^. .:^^~!?~   ~?J7 .:\r\n...!YY5GB#B^:~~^..^. ..?5BG!7GBY?!~!?JJJYJ...^~~^.:!^:^^:. .:.  .^::...:::^:..:::::..:...   .:..   .: .~77:.^~:~JJ7.  .\r\n7?:.^^~?JP#?::. . :.. .~?YP5Y55J7^:!?JYJJ~ ..7^..     :~~!^^:...:::^~~:.:!~.^^^:...:~7:.. .:   .....:  .~!~.:7!:^77~.  \r\n:^:.^:^!: .:.. .^  ..   ...^7!7!~:::~!!!!.. :?^.^.    ..:^:.::::::^~:~:     :^!!...!YJJ?7^..:~?Y5Y?!^.  ^:^!?^:~^~????7\r\n7~::.^~J   .5~.......   :. .7?JJYYJ?7:  ...:~~::^:.....~!.^:?7?~..^~..    .:..?: ..?JYYJ?!!7J5B57?BGY7    :!?..^!:  .::\r\n:.:.. . ..:5#!::....   . ..~?JJ??!^::....::::.:!..^?^. .:~~^:.^~!^^^:.::..:^:77...:!!77~:.:!?Y555PP5?: ..^..~!!~:7Y!:  \r\n^  . .....:..::::: .:....::.::...:.::^~~!:.::^7?~~!^.:. .:.... .^.  .:?!..!:.:~. ..  ^!!77777!!^^::.. .. ..  ::^J&##BPJ\r\n.  .......   .:.~~~~~~~^^^:....^~~~: .^^.::!..7?^..  :~!?Y5555J!^..:..^!!~?!:.:^^....^~?JYYY?7:  :.  ...  ^. .:!J7!!^^^\r\n::. .....~!^.:::^.:~^^:^^^::.::!^..    .  .:^:...^. 7YPB5YB??BPGGY7:  :.!Y^ ^^.:~!~^:. .^~7??7.      .......~~.  :!~:::\r\n.^.:!^  .7&?:^. . ......:... .:^~!:  :^...:^^^..:: ^JPBB~?GBBJ~G#PY~ .^..^^^^...^:. :!!^:. .:.:...... . .^:!#J.  :7::^.\r\n:::~!^   ^7.......    . .!??!^^. .:^~!~:.^~ .J7.:. .7YGG5GJ7BYYBGY?. ^:..:^^.  .    .::!::..:^^^::^~^.^::::^!!:.... .::\r\n^^:~!!?7:. .:  ..:  .:. .7?YYYY?~^:...^^..:~?!!!^..:..^!Y55PPYJ7~^. ..:7?:.!::.^^. .~!~~:...:^^^~~~~~~!.::   .......  .\r\nYPG##&5^::. .. ..  ..:::~!7777777~. .. .^:..!..!?:.. .:. ....:. .:::~~~?7^::.:~!!^::.::...:..:....:: :^:::..:..... .  :\r\n  .!YJ:^!!~..^:...7YPP555Y?!:..^!7~!^...!7^:::.::.:^^^!~^.::~~:. .:?~:.~^.::::....:::~7??J?!.. .    .. ::~BG~.. . ..:.:\r\n::.  :~~..7!^    !YG#J!JBPJ7!!?JYYJJ: ..?:.:.     .~^..^?7?^^.~!:..:..^^.^~:...  .7?JYYYJ?7: .:.  .. ....^P:   7!^.::^7\r\n7???7~:~:^7!^:^. .^!?Y55J!^::^7?JJY?...~7::     :^:^^::::::..^:..    .:::?^ ..~!~!~::^~!7!7^...   ..  :. ..:. .!~:^:.^^\r\n  .~77^:~?::^!~:  :.....   :.  .:7!^...:^^^.^!:.:~~^^::...::^!~~^.    ..:?...^JJYJ?!:^!?Y555PY?~. ... . ..:!#PJ?~::..?7\r\n.  .!?J!:~^.:!7~: ^.   ....   ...:...:.:^..:^:::....:^.  .:...:^^:^!:.^~~~.. ?YYJJ?7~!?YGB7!P#PJ:  .^..^~~::B##GP5Y7. .\r\n:. !J?!.  ^?!~^^:.  :. . .. .. ...:^~~~~:...::~7???J??!.^7?7!^:...^^:::^....:~7^:.... .!?Y55YJ7:  ..:!!^:7~:~^:  .7^ :?\r\n^~^?:. .  ~GG#BGY!:..:::..:. ...~~~~~~:..::.^!!JJJJJ7~:.^??YYYYJ!^.. .:~^^^..::    .:   ......  .^^^~?~.:~^^..:::....7Y\r\n.:77. :?^.YGBG7!^::  .^JPY7:.^:.^~~^::. ... .  .:~77!!!~~!77??7^~^:^:.:^~~~^......  ....   :7..:!!^::77~^^7???77!~7!:..");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(":..  ..:.:.  .:^!!~^~~..:77~:   .. ........ .^^. ..   .:  :7JPGJ~JGPY7:   .........:^:. !PG7:  .:~::.^YGG! ^^:!7YY!!^..\r\n7J!..:!7^~!77??7^^^~7!^^~~:. :~.   ..:   .........^..:.:^~!7!!?YYJ?77~. ...  ... ..:^:..~:^7!^...^7PB&#GY. ~.  ~~::.  .\r\n55Y57.....::..^~~..~7~^::.  .:::^:.  .:.   .~......:~?JYYYY?7^...^!????7^:: ::...:^.  ...... .:..:~~!7?5!   :~?J::^:  .\r\n?JJ7: ^7.  :~!:~7^^!!: .  ^?5PPPPPJ!:..:^~!7J^....::..^~!?J??!..~??JYYYJ7!~:.........   .:..  ... .^~!^^~:.:JJ?^  .7^..\r\n. .. .?Y5PB##B::^~:.:^.. :JP#P!^?#PJ7!7?JYYYJ:..:7~~^^:...:^:   .!~^:.::..:.....:!:    :.      .!. :!7^..!~^~?!:    :7:\r\n:~!7?..::^7?5B!:.. . ... .~7Y5555Y?!^.:!JJJJ! . ~! . :~~!^:... .....::::^~!!:. :YJ?!~.....^!7!~:.   ^^^~~7!~:^7?!^...:^\r\nJ?:^^.:^^~!. ......:  ..   ...^7!7!~^:.:^::^:...7!:^::::^::::.::::^!^!: . !~ ..7JYYYJ?!!7YPPY5PGY7. .::^7~..!^^^~??7!^!\r\n~577^::.:!7   ^P^.......  .:. :??YYYYJ?7.    .:~^.:^:.~~.:.7~.!^.:^^..:~^~?....??J?7~::7J5BJ~75BPJ:   .^!!^^!^:.   ... \r\n??^:.:. .. ..~GG^^: ..   .. ..!????7~::....::::...7:.~7!^!~~..!!!:!!..^:.^!.......~:..:^!7?YYYY?!: ..~^ .^~~:!GPY~..?^ \r\n5::^... ....::...:^^. ::.......:...:::::^!!~:.::^!7::^:.:.  .. :^:~7~.!~..::. . .:7?JJJJ?7!: ..    .  .: .:^?##BGPP5?. \r\nYJ!.::..:  .:GG~::... ::.......  .^77^. :^^.::!.:?!:.. .^7J??7~.  ..:!7^^:..~~::...^7JYYJ?~  ..  .:.. .. ..:~::^:....??\r\n::^::^~!Y.  .57.......   ...^~!^....:^^:!~^.:~..7?:::  7YPB#BGY7. :::??..!:.:~!^^^:....^7!^...    ......~P:   J7~^^:^::\r\n?J....:~::^:..... . :.  ..  ^?JYYJ7^...:^~~..:^:!!:... .~7?JJ7~.  ..!?^.~^..^~: .^77~:  .......... ..:^^P#^.. :..:^.!JJ\r\n .7555PGB#Y^:. ..  ..   .. .!7?JJJJ?7^. . .::..^7:^7~::^  .  .: .^::!7^::.:~!!^:::::...:.......:^ .^^:...::....  ..:::Y\r\n.:?::~YGB?:^~^. :~.. .~7JYYY?7!^::.:~. .....~^..~:.!7:!!!:.^^!~~7!::?:..:::::....:^!77??7:. ..   .. .^^5G!... . ...:^!?\r\n ...   .:^!~^!7^.   .?5BP7!?BPJ7^.^!??7?:...7!^^:..:^:.:7:^?::.^!.:^:.:~:.    .7?JJYYYJ?^  ..  .......:P!   ~7:.:::!!Y?\r\n7^~7?7~^^^7. ^?~::. .7YGGYJ5G5?!!7JYYYJ?.. ^7...:~^~^::::.::::^:.::~:!?:...^:::^.:^~!777^...   ..  ....:.. .!!^^^.^^:7J\r\n^....^!??^:~!7!~^^^   .^~7?7~:....~!?JY~ ..!!~^::^^:.:......:^!!~: . ~!.. ~?JJJ7:.:!?JY555Y7~. ... ....:~B5?7^.:..?77!^\r\n.7^    :~7!^~7..:7!:  ~:      .:.   .!^:....:..::.:^^~:   .^:...:^^~~7^...JJYYYJ7!7J5BJ^!Y#PJ^ ..^:.:^^^:P&#BG5YJ: .. .\r\n..:7:  :?JJ~.:^^^!!^. ...  ..:.   ..........^~7?JYYJJ?!..~????!^^..::....:J?7~~:..:!JPPP5PPJ~  . .~7~^!~:!!^. .7~ .!JJ?\r\n.  :^:.??!:   ~Y?7!~^:..:. ......  .^:...::.:^^7?J??7^...^7?JYYYJ?!:.. ...^.    :.  .:^^^:.  .:::^7!..~~^...:.....!5YYY\r\n:   ::^!  .~. ?GB&#G?~:..:~!^:^..:^:......   ..  ^777?YY?!!7!!~^.:..^:........   :..   .^^ .:~~~^~7~~^^!??777!^!!^..~J?\r\n..:!~?Y7~::~.^GG5~.::~:.  :7PP7..:^: .........  .!JPGY!JGPJ7^  :.   ....^~:  ....... .: . .~7?^..^!^^!!~:.  ...:..  ..:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(":::.:?~:   :!^.    :7J?~.:^^~~^^:...:. ....:. ........   .~?5GPPPPP57:...     ...:75PY?^.  !!~~:  :757 ..7Y!YBG5~::::::\r\n::::... ..:.:.  .:^~~^:~7..:!?~:.:. .  ... .... ...  .:  .7JPB7^~7BGY?:   .........:!7JY7:  .^^7JGBGP^ ?~  ^7:... .!^.:\r\n~!?JY7:.:!!~!777??7^^^~~~~~~~:   ^.     ..   ...::. . ..:^77?YP555Y?7^  .:   ... .  .........^7Y5PPGJ.  ..^7~~~.  .~^::\r\n?55YYY57.......  :~!. ~?^::..  :^!!7!~:  :.  ..~^::!??JJYJ?7^:::^^!777!^... .:.....  ...  :.  .:^^~!!. .!JJ7  .!: ..:^^\r\n^7!?JJ!. ^?: .^!7:~7^~!~.    ~YPGPYYGPJ!^:^!77?J7...:~7?JJJ?7. .~7?JYYYJ?7~::^: .  ... .   .~. ^!?^..~~^?J7:   ::::..::\r\nGJ:  .:.:?Y5GB#&B::^^: :~.. :JPBP7~^GGY?!!?JYYYJ~...:. ..^~~.  .~77!~^~^....7?!:.  .. ..::...   ^~~^^!!^:^!^:   .!~   .\r\n?!~^!77?..:.^!7YG!:.... ... .^!J555YJ?!^. :7???7.  :?~~~:...   ..:....::...~YYYJJ7~:~7YPPPPY7^. ..::~!~^~:!JJ?!~:.:!:  \r\n!JY?7:^^.:^^!7. ..:....  ..   .. :!!7!~~^:.........!7::~^:::...::^~!~~?^ ..7?JJJ?~~7J5BJ:7JBGY!   .^!7. ^!:..:~~~:^~:::\r\n!J^!5!!:::.:~~   ~G^.......   .. :?JYYYYJ?7.     .^^..^:..~~ .~:.:^^.~7:...^^^!:  .^7J55YYPGPJ^ ....:!!!~:!7:   ^^ .7Y?\r\n7!:55^..~.    ..!#G~^. .. .......!??77!^.....:::::.. ~~:~~!^ ^?~:.~~ .::.     :~~~~~!7!7!!~^:. ...^  .:^:7##BPJ!7~ .^Y5\r\n5P7^:77.::^77  .~#7::. .......:^:^~. ....^~~~~~::^::!~..::....::^:~^...:::...:!7JYYYJ?7:  ..  ...  ^. .:7PYJJ!777~::.  \r\n.:JJ7~ .:.^~^ ..:^........   .  !?J?!~:...:^!!:.:~..?7...  .  .. !?:.~:.:!!^:...:~7?J?7. ..   .. ....::.. :~~... ^7JJ:.\r\n   ::~!7!~??J5?:.  ^   ..  .:. .7?JYYYJ7~:...:^:..::~::::.....:..~7:.^::^~~~!~:... .^^:^:.........:.~#7.  ~J^:^.!7::7PP\r\n5Y~. ^77YPB##Y:^:.  :... .:^^~!!!7!~!!~~^      :^: ^!.:~7~ :!~!:~!...::::::....^!!77?!:...... .. .^^5#?..    .~:.^YP:^J\r\n?YJ. ^~   :77:~!!!:.....:?5GPYY55J7~.  .~^:^....7~.:^:.:~: ^!..:^:.:^:.    .77JJYYYJ?~  ..  .......:G7.  ^!:.:::~~5?:?!\r\n^::~^:^~~:. :~! .!7^.   ~YG#Y7:7#PJ7~~7JJJJ?.. :?~~!~^:::..::::~^:!!:.......::^~~!77!^  ..  ..  ....:.. .!7~^^.^~:!?JY7\r\n  :!^.:~!??J!:~^^!~::..  ^7YPPPP5?!^~7?JYYY7...:^.......   ..::~~~?~  .!???7:  :~7JYYYY?!^. ..  .. ..~PJ!~^... 7777~~!?\r\n.   ^!.   :~!~.:~!^^~~^.  ...:::. ... :^!??:...:^^~!!7~.  .^~^....:...^JJYYJ?!~7JPB!~7Y#PJ^ ..~: .^^^:G&#BGPYJ^.:.  .7G\r\n:::..::.   :!??~^!..:?7^..!.     ...  . .~::^7?JYYYYJ?!. .!??JJ?7!:.. !YJ?7!~:^!J5BYJPGGY7.   .^!~~!~:7?~:..7~ .~?J?77~\r\n^^:.. :7:  !JJ7. .~!~~^^.  .:  ....  .....:  ..^!777!~:::.:7?JYYJ??!:::!... .:  .~!77!~:. ...:^7! .~~^  .. ....!5YJJ55?\r\n::^~.  .~~^?^:.   7GPP5J7^.......... .....   ::  :7?J5555Y?77~::: . .::...   ..     .^.  .~~^~~~~~^^!????7!~!!^.:!5YJ7!\r\n:.^7. ...:!~  :?..5GBBYJ^^.  :!YJ!!:.........   .7JPBJ~~!BGY?:  :.   ..  ... .... . .:..~7!:..7!:^^~^^.  .:.::.  ..::::\r\n::::::^Y5B5!J7:. ~PJ~  :~~~!  .:?YP5?:...      ..:7YGPPP5G5J!.   ........  :.... .:. .:^^~~^^^:^?J?^    .:7:   :~7^.:::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  .:::^~^:::::. ..^~.  ~JJ7  .~?777!!!^...^~~:....  .  .^:  ....:.     ^~   :....:   .:7?~!^.  ^!~ ..JG^~B#B7::::..^.  \r\n..::::.^7~:   :7:     :!?7!^^::^!!^:   :.   .........   .:~?Y5PPP5J7^. .:   : ...~7?~.  .^:^^!5GG? ~!.:~J7^:^..^:::.:. \r\n...::::..  .::.:. .:^^^:::^7~.:~7~: ^^    ...  ...  ..  :?YGB7~?7?#GY7:   ... .....:^^...^75B##GP. ..  ^7^^.  .7!::^~^~\r\n.^~!7J55!:.^~~~7??7??!^^~~^^::^^:   .....   ..     . ...:77J5PY?Y55J?~  ..   .......  :: .:^^^!?7.  :7JJ:.:^.  .::^:.~!\r\nYY7?5YJJY5!...  ..  ^~~. !7^:.  .:~?JY5Y?!:  ....:^!!7?J?77^^~7!!~!77~:. .  .    :...  .:. ^!?~::^::?J?~   ^!...:^~:.:^\r\n:..~?7JJ?^. !7:.:!J7:~!~!!^.   .75GGG?~YB5?7~!7JJJYY?JJYYJ?!.   :!?JYYYJ!!^..  :.   ....:. .^!!:.~7^:~~^    .:~....:::^\r\n :PG7.  .:.^JYPG##&G:^^:. :~.. ~JPBY7!~5GY?~:!?JYYJ7 ..^!!!:.  .!????7!7YYJJ7~:.:^!JYYJ7^.  ::.:^~~~^.^!!^.  .^:   :~7:\r\n.5^7!!!?777 ...^~!JP^.. ..  .. .^!?YYYYJ7~:.  ^!!!7:. .....  .  .:.... !JYYYJ7!7?YGP!JPBPY7. ...^7~.:!:!!7??7~:7!.  ..:\r\n:! 7YJ7!:~^.^^^7!. ..:....  ..  ..  ^777!!~^::    ....~~:::....:::^:...~!7?!:..!?YB5:~?5BPJ:   .^7~::7^.  ......^^!?G5?\r\n7.:JP^:!J5~..:^P^  .?G:.......  ..  ~?JYYYJ?7!.     .::..~^. .^:.:^^...    .  .:^7?Y5555Y?^ ..~: .~!~:~PY!. .7^ :5Y77YP\r\nP~7!7P5^::.^^~~?.  .J!.......      :7?JY?~:.....:^:::.. .~^  ^!^ ..:.  .  :7????777!:....   .  .. .::7###BGPY?. .^7YJ!^\r\nBB~   :!?:::.:~^^!^.. ..  .:.  ..  ^?JYYJ?~::...^~:..^~~  .:.  ^~^..:~^:..::~?JYYJ?~  .:  .:.  .. ..^7~^~^.:::7!^   ^GB\r\n^!JY7^.  7YPGBB#&J^:. ..  ..   ...:!77?????7^. .  .:.. :!^  :~.....::^^:.....~7JJ??^      .......^Y.   7!~^^..^^YP7~7~Y\r\nPY77JP^ :?: .!YG7:~~~: .~.. :7J5555Y?7~:.. .    .. :~:.:^.  ^~:.::..   ..!7?JYYYJ?!  ..  ........55.  .P~:..:5J!:^PJ~ 7\r\n?5GY7~^......  .^!^:~?~.   .?5BG?!:YB5?!..:~77!!....~^::....:::~~:...    :^~~!7777~  ..  ..   ...^:   ~7~^^:^~^!77Y?.^^\r\n:... .~?^~7??7!!:!^.^7^::.  !YPBPJ~5B5?7!7JYYYJ7  ...:.     ..... ..!!~!^   :^!?JYYY?!^. ..  .: ..:5J~~^... !77??7!7^5^\r\n:7~:   :^.  .^77~.^~~~^:.::  .^7JY5Y7~:.:~7JJYY?!!7???7.   .~7~^.. ~JJYJ?!:~7YGP!!?YBGY! ..~^  :^^:5&##GPYJ^.:.   ~PG~ \r\n^^^:....~^.    :~~::!!.:~!^. .:.....  .:  ..^!7?YYYJ?7^.  .!?JYYJJ7JYJJJ?!~7?YBP^7PGGPJ: . .:!!~!~:!Y7~::77. :7?J??7:..\r\n^:.:~^:...~~.  ^?J?^:~:.^?!^ .:.   ..:    .  . .:~77!~~!!~^^!7?JJ?!7~^:.... :!?555YJ!:.  .:^77. ^!^   .  .. ~YYJ?JY?7JY\r\n!~.:^::.  .~:..JJ7^  .!?!^^^:. .:  .......   .:  :7J555JYP5J77^... .     .:   .....   .^::::^~~^^~?77??7~~~~.^!5PY?7~^:\r\n~^~^::~7.  .^^!~. .. .YGB#BP?~...:^:.........   .7YG#J!7~!BGY?^  ..   ..  ....   :~ .^!~^.^?^:::^~~:. ...:^:  ..::::...\r\n .:.:::^..:::!J~..~7 ~GGP?^~:^.  .~J?!... .   ....^7J5PGP55J!^.   ......... . .:   :^~7^::^^~7?!:     .!^   .^!~.::::..\r\n  .::.::::~G##7^PY.. ^7^. .:!~7?:.   ::...:.  ^^     .::.... .^.  .. .....^~^...:~~!!!7?~.  !JJ!  .^^:. .::::::~^:::.  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("::!^  .~~~^^::.:~^... ^~. .JJ~.   !GG###5^:...::..... .:^^^^^~:. .^~!~~~7!^:^?#&!.^^~~~~: .!~:.. J#^.P#BY::::..^    .~:\r\n:.   .:::^~^:::::.. .:^.  :?JJ^ .^!!~~~^^:....:.. .:  .~:    . .. .. ..^:. ...:~... :^^^..^JPY .::7!?PY?!:.::::::.  .:^\r\n::...::::.^7^.   ^7:     .~7!~~~:.:!7~:.  .:  .......  ..:~7JJY5Y7~:. .^^  .:   :~...^~JG#&BG^ ^~  .7:...  !7:::^^^^..:\r\n......::::..  :^^.....^~~^:..:!!^^~!^. .!.   ..:. ...  .7YG#J7JYJ5BPJ~.   ... ........~!7?JYY.  .:!?!:~^   ::::^^^~~~~~\r\n ..:~!7J5PP7~.^~^~7??77?~^^~!~:...::   .::::.   :. ... .7?YG57~~?5G5?~  .... :... ..   :^~~^~^..!JJ7.  ~!...:^~: ^!!~~~\r\n??5YJ77J?7JYY! .:      :~~  !7^:.  .^7YPPPPPJ7:...:^~!777!~!7YYJ?777!:  .. ..      .^~ .~?!. ^7^~?7^   .:....:^^:::~~^~\r\nJ?~..:7?7??7^ .!7::~?Y?:~!!!!^.   .?5BPP7.^BPJ7!!?JYYYYYJ?!. ...:!7?JJ?!^:.....^!!^:.   :^^~^~~:..^^..   .7~   .^~~:::.\r\n .. ^GG!.  .^.^JJ5GB#&G:^^:  :~.. ~JPB5?!!5GY?!.:!JJJJ?77?~.   :7?JJYYYYJ?7~!?5GP5PG5?^. .. .^~~~^:7J?!^:..:^.  .:^.:::\r\n   .5:7777J777 ...^^^75^.. :.  .. .:~7JJYJ?!^:.   ^^:~:.:.      ^^~7??J?7^:!?YBP .?PBPY!  .:^77. ~~^.:~77!^~7:..^^:::::\r\n   ?7.7JBB~  .^~~~!~   :^....  ..  ..  ^7777!!~^:       .:............:.   ^!?5PY?J5BPJ^ . .:~7!~!^~^.   :. .7JJPBG5?~^\r\n.. YBJ^. ~JJ7 ...^^:....:... ..:.  .:  !?JYYYJ?7!.......:.....::.  .   .::^^^~77?J?7!~: ..:~  .^^:~BBGY!:7~ .!5Y~^77!Y5\r\n^:..JP?:  ..^?YJJY5PBJ^.  ^   ..   .. .7?JJYYJ?7^... :::   .   ::: ...:7?JJYJJ?7:  ..  ..   ^  .:7BGP5YYYJ^ ...:?5Y:.:^\r\n5Y!7!^~Y57. ^7^!YGB#7:^^:  ^^.. .^!!7??77!^^^^^:      .::.............~7?JYYYJ?7  .:  .:... ..::.:.:^^... !J?~  :7BP ..\r\n^~?5GBGJJ?: .:   .^~^~~!7~:. . :?5BPJ?YP5?!^.  .:............:.       :^~!77?77~  ..  ..   ...^:   ^!~~~^:  :GBJ7:~Y   \r\n:::::~!...!~^~!7~:.:~!  !7^:.  ~YPBPJ: JB5?!::!?J??7~^^.     ...:~::^   .:^~7JJJJ!~:. ..  .: ..:J7^^^... ~77JJ?77.Y^   \r\n:::.::.  .^^..:^!?J7:^~~~^....  ^7YGG55G5J7!!?JYYYJJJ??^   .^777?JJJJ7:.~?YPP?!?YBPY! ..~^  .:^:5&#BG5JJ^:^:   ~5B7 .. \r\n.:::^!^:   ^?:   ..^^..:~~^~^^:   .:~!!~:....:^!?JJJ?!:... .~?JYYYYYJ?7!7JP#!.~5PBPJ:   .:~!!!~:75J!^^77. :!7????^..^7J\r\n^^~~:.::^:......   ^!?~^7~ .~?~: :~.      .. ... :!777?JYJ7~~!77?7~^^:..:!JPPPPP5?~:  .:^!7. ^!^.     :: ^YYJ7?J7!JY5JJ\r\n~~~~!~ :~^:...!!.  !JJ7..^~^~!~^.  .. ...:  ...  ^?YPPJ!~75P5?7:  .. .:.  .:^:::.  .:...:^!~^^~77!7?7~^^^.~7PG5Y?!~^:. \r\n~~~~~^^^::::   :^:~J7^.  .JYJ77!~:...  .. ....  .~?5BP7Y?77BGY7:  ... .:..   .~: .:!~^^!!::..^~!^:....:~:  ..:::::..  .\r\n:..^^^^^::!7.  ..:7:  ^~ :PB##B5~^...^:   ..  :^. .^~?Y55YY?!^..   ......  ..   :~77:..~~^!!~:     .7~   .^!~.::::...::\r\n^:.  .::::::..~7J5J!7:^: ?PY!..:^~:  ..^:...  :^..  . ....    :~.  :. .......:^^~~~!!^. :JJ?^   ::. ..:::::^~^:::.    :\r\n:~.    ^..::::?B#G^.BP...:~!. .~!~~~~.:##J^:^~7!~~!~^.  :^^^^^::. .:....^...:^Y#BBGG?.  .~JJ^  ~~....^~^.:::^~~~:  :!::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n                                                       Conectando");
            Thread.Sleep(20);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Thread.Sleep(70);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(40);
            Console.Clear();
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               Conexión neuronal exitosa");
            Thread.Sleep(2000);
            Console.WriteLine("\n                                        ERROR ARCHIVOS DE SISTEMA NO ENCONTRADOS");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(2000);
        }
    }
}