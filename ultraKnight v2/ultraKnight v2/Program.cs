using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultraKnight_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicio de las variables.
            string nombre, ultraKnight, muerte;
            int decisión;
            ultraKnight = " ##   ##   ###       ##                                ###  ##             ##              ###        ##\r\n ##   ##    ##       ##                                 ##  ##                              ##        ##\r\n ##   ##    ##      #####   ######    ####              ## ##   #####     ###      ### ##   ##       #####\r\n ##   ##    ##       ##      ##  ##      ##             ####    ##  ##     ##     ##  ##    #####     ##\r\n ##   ##    ##       ##      ##       #####             ## ##   ##  ##     ##     ##  ##    ##  ##    ##\r\n ##   ##    ##       ## ##   ##      ##  ##             ##  ##  ##  ##     ##      #####    ##  ##    ## ##\r\n  #####    ####       ###   ####      #####            ###  ##  ##  ##    ####        ##   ###  ##     ###\r\n                                                                                  #####";
            muerte = " ##   ##                               ##\r\n ### ###                               ##\r\n #######  ##  ##    ####    ######    #####    ####\r\n #######  ##  ##   ##  ##    ##  ##    ##     ##  ##\r\n ## # ##  ##  ##   ######    ##        ##     ######\r\n ##   ##  ##  ##   ##        ##        ## ##  ##\r\n ##   ##   ######   #####   ####        ###    #####";
            Console.WriteLine(ultraKnight);
            Console.WriteLine(" Bienvenido a Ultra Knight v2");
            Console.WriteLine(" Eres el Ultra Knight, un caballero principiante que recién sale de la academia de escribas. Has decidido que pasarte tu vida escribiendo te da demasiada ansiedad para soportar, así que robas la armadura y espada de un almacén y te lanzas a la aventura. ¿Qué te va a estar esperando?\r\n");
            Console.WriteLine(" [####] Reglas [####]\r\n");
            Console.WriteLine(" 1) Lee bien lo que se presenta en pantalla, va a ser importante para avanzar. Recuerda que no podrás volver atrás. \r\n");
            Console.WriteLine(" 2) Al momento de colocar palabras utilizar sólo mayúsculas.");
            Console.WriteLine(" Fin de las reglas.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("¿Cuál será tu nombre de aventuras?");
            nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" [{0}] Sales de casa con tu nueva armadura listo para emprender tu travesía. ¿Qué decides hacer? Podrías pedir indicaciones, preguntar a los pueblerinos que males acechan en éste mundo tan cruel, o podrías ir a donde te lleve el viento.", nombre);
            Console.WriteLine(" Pedir indicaciones. [1]");
            Console.WriteLine("  Por donde me lleve el viento. [2]");
            Console.WriteLine("");
            decisión = Console.ReadKey();
            Console.Clear();
            if (decisión.Key == ConsoleKey.D1)
            {
            }
            if (decisión.Key == ConsoleKey.D2)
            {
            }

        }
    }
}
