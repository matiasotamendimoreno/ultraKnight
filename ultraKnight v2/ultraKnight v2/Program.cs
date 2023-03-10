using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Base para los inicios de desición.
//Console.WriteLine();
//Console.WriteLine(" [{0}]  ", nombre);
//Console.WriteLine(" [1]");
//Console.WriteLine(" [2]");
//Console.WriteLine("");
//Console.Write(" Eliges (Apretar número) ");
//tecla = Console.ReadKey();
namespace ultraKnight_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicio de las variables.
            string nombre, ultraKnight, muerte, fin;
            ConsoleKeyInfo tecla;
            ultraKnight = " ##   ##   ###       ##                                ###  ##             ##              ###        ##\r\n ##   ##    ##       ##                                 ##  ##                              ##        ##\r\n ##   ##    ##      #####   ######    ####              ## ##   #####     ###      ### ##   ##       #####\r\n ##   ##    ##       ##      ##  ##      ##             ####    ##  ##     ##     ##  ##    #####     ##\r\n ##   ##    ##       ##      ##       #####             ## ##   ##  ##     ##     ##  ##    ##  ##    ##\r\n ##   ##    ##       ## ##   ##      ##  ##             ##  ##  ##  ##     ##      #####    ##  ##    ## ##\r\n  #####    ####       ###   ####      #####            ###  ##  ##  ##    ####        ##   ###  ##     ###\r\n                                                                                  #####";
            muerte = " ##   ##                               ##\r\n ### ###                               ##\r\n #######  ##  ##    ####    ######    #####    ####\r\n #######  ##  ##   ##  ##    ##  ##    ##     ##  ##\r\n ## # ##  ##  ##   ######    ##        ##     ######\r\n ##   ##  ##  ##   ##        ##        ## ##  ##\r\n ##   ##   ######   #####   ####        ###    #####";
            fin = " #######    ##\r\n  ##   #\r\n  ## #     ###     #####\r\n  ####      ##     ##  ##\r\n  ## #      ##     ##  ##\r\n  ##        ##     ##  ##\r\n ####      ####    ##  ##";
            Console.WriteLine(ultraKnight);
            Console.WriteLine(" Bienvenido a Ultra Knight v2");
            Console.WriteLine(" Eres el Ultra Knight, un caballero principiante que recién sale de la academia de escribas. Has decidido que pasarte tu vida escribiendo te da demasiada ansiedad para soportar, así que robas la armadura y espada de un almacén y te lanzas a la aventura. ¿Qué te va a estar esperando?\r\n");
            Console.WriteLine();
            Console.WriteLine(" [####] Reglas [####]\r\n");
            Console.WriteLine(" 1) Lee bien lo que se presenta en pantalla, va a ser importante para avanzar. Recuerda que no podrás volver atrás. \r\n");
            Console.WriteLine(" 2) Al momento de colocar palabras utilizar sólo mayúsculas.");
            Console.WriteLine(" Fin de las reglas.");
            Console.ReadKey();
            Console.Clear();
            // Inicio de agregar el nombre del usuario.
            Console.WriteLine("¿Cuál será tu nombre de aventuras?");
            nombre = Console.ReadLine();
            // Fin de agregar nombre de usuario.
            // Inicio de las rutas.
            Console.WriteLine();
            Console.WriteLine(" [{0}]  Sale de casa con tu nueva armadura listo para emprender tu travesía. ¿Qué decides hacer? Podrías pedir indicaciones, preguntar a los pueblerinos que males acechan en éste mundo tan cruel, o podrías ir a donde te lleve el viento, o quizás simplemente volver a casa.", nombre);
            Console.WriteLine(" Pedir indicaciones. [1]");
            Console.WriteLine(" Por donde me lleve el viento. [2]");
            Console.WriteLine(" Volver a casa. [3]");
            Console.WriteLine("");
            Console.Write(" Eliges (Apretar número) ");
            tecla = Console.ReadKey();
            Console.WriteLine();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                Console.WriteLine(" [{0}] Decide ir a preguntar a los aldeanos y termina llegando con Herbert, el herrero. El te comenta que el mercader de la capital ha venido con malas noticias. Un terrible dragón ha secuestrado a la princesa y no piensa dejarla ir.", nombre);
                Console.WriteLine(" Podría ser tu primera aventura pero Herbert no te lo recomienda, dice que es muy mala idea y que puedes morir.");
                Console.WriteLine(" Hacer caso al herrero. [1]");
                Console.WriteLine(" Seguir tu nuevo camino. [2]");
                Console.WriteLine("");
                Console.Write(" Eliges (Apretar número) ");
                tecla = Console.ReadKey();
                Console.WriteLine();
                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Console.WriteLine(ultraKnight);
                    Console.WriteLine();
                    Console.WriteLine("Decides hacer caso al herrero, el tiene razón, otros se pueden encargar de una misión suicida cómo ésta.");
                    Console.WriteLine("[Nadie logró rescatar a la princesa del temible Dragón y por ende una cruzada se ha librado, no hay guerreros para cuidar ni tu pueblo ni ninguno. Un señor vampiro, ser que fue creciendo gracias a que nadie lo detuvo, ahora atemoriza a tu pueblo. No estás a salvo.]");
                    Console.WriteLine();
                    Console.WriteLine(fin);
                    Console.ReadKey();
                }
                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Console.WriteLine(" [{0}] Decide hacer caso omiso, es mejor aventurarse antes de quedarse de brazos cruzados. Herbert se despide de ti orgulloso de conocer a alguien tan valiente, y a la vez tonto. Ahora te encuentras con que debes seguir el camino hacia el bosque, allí hay una gran gruta que abre paso hacia cavernas espantosas, seguramente el monstruo esté allí.", nombre);
                    Console.WriteLine("Llegas a la entrada y pasas. La cueva está plagada de cristales que iluminan de manera extraña, ¿Tomas alguno? Puede servir de antorcha.");
                    Console.WriteLine(" Tomar un cristal. [1]");
                    Console.WriteLine(" Dejar todo como está.[2]");
                    Console.WriteLine("");
                    Console.Write(" Eliges (Apretar número) ");
                    tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        tecla = Console.ReadKey();
                    }
                    if (tecla.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        tecla = Console.ReadKey();
                    }

                }
            }
            if (tecla.Key == ConsoleKey.D2)
            {
            }
            if (tecla.Key == ConsoleKey.D3)  
            {
                Console.WriteLine();
                Console.WriteLine(ultraKnight);
                Console.WriteLine();
                Console.WriteLine(" [{0}] Decide volver a casa. La vida es más fácil si te arrepientes de ésto, no morirás si te quedas escribiendo libros.", nombre);
                Console.WriteLine(" [Nadie logró rescatar a la princesa del temible Dragón y por ende una cruzada se ha librado, no hay guerreros para cuidar ni tu pueblo ni ninguno. Un señor vampiro, ser que fue creciendo gracias a que nadie lo detuvo, ahora atemoriza a tu pueblo. No estás a salvo.]");
                Console.WriteLine();
                Console.WriteLine(fin);
                Console.ReadKey();
            }
            // Fin de las rutas.
        }
    }
}
