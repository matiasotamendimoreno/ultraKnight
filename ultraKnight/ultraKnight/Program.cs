using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultraKnight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
            Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
            Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
            Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
            Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
            Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
            Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
            Console.WriteLine("                                                                                  #####");

            Console.WriteLine(" Bienvenido a ULTRA KNIGHT.");
            Console.WriteLine(" Tú eres el 'Ultra Knight', o así te hacías llamar de niño.");
            Console.WriteLine(" Ahora estás en tu segunda misión, la primera fue graduarte de una secundaria [técnica], por mucha fama y victoria.");
            Console.WriteLine(" Deberás salvar a la princesa que ha sido secuestrada por el temible [Dragón Guerrero Psíquico Ancestral].");
            Console.WriteLine(" ¿Estás listo?");
            Console.Write(" Apretar cualquier tecla: ");
            Console.ReadKey();
            Console.Clear();
            // Fin del comienso.

            // Inicio de las reglas
            Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
            Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
            Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
            Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
            Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
            Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
            Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
            Console.WriteLine("                                                                                  #####");

            Console.WriteLine(" -- Reglas del juego --");
            Console.WriteLine(" 1) El que no lee las reglas es puto.");
            Console.WriteLine(" 2) Leer atentamente lo que se te muestra, no vaya a ser que te pierdas de algo.");
            Console.WriteLine(" 3) No hay puntos de guardado.");
            Console.WriteLine(" Fin de las reglas.");
            Console.Write(" Apretar cualquier tecla: ");
            Console.ReadKey();
            //Fin de las reglas.

            // Comienso.
            Console.Clear();
            Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
            Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
            Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
            Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
            Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
            Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
            Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
            Console.WriteLine("                                                                                  #####");
            ConsoleKeyInfo tecla;
            Console.WriteLine(" Ahora toca lo más sencillo, empezar a caminar. ¿Qué harás?");
            Console.WriteLine(" Caminar a la aventura. [1]");
            Console.WriteLine(" Lo haré mañana. [2]");
            Console.WriteLine(" Escribe la letra de la opción a elegir: ");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                Console.WriteLine("                                                                                  #####");
                Console.WriteLine(" Has caminado por días, incluso semanas, y no has sabido por dónde ir. Decides volver a casa, piensas que debiste haberte quedado hasta que encuentras un cartel que dice ‘Guarida del [Dragón Guerrero Psíquico Ancestral]’ a 20km de distancia, quiere conocerte.’ y piensas ‘¡Los dioses están de mi lado!’.");
                Console.WriteLine(" Ahora has llegado a tu verdadero camino. Has encontrado la entrada de la cueva del [Dragón Guerrero Psíquico Ancestral]. Pero… ¡OH NO! Un guerrero esquelético se encuentra custodiando la entrada. Se encuentra temblando, como lo haría una criatura esquelética. ¿Qué harás?");
                Console.WriteLine(" Golpearlo. [1]");
                Console.WriteLine(" Darle tu capa. [2]");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                    Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                    Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                    Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                    Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                    Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                    Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                    Console.WriteLine("                                                                                  #####");
                    Console.WriteLine(" ¡Oh no! Te has dado cuenta muy tarde de que eres un programador… ¡No un luchador! El esqueleto barre el suelo contigo y terminas con varios huesos rotos.");
                    Console.WriteLine(" Terminaste siendo llevado por el SAME casi muerto, el esqueleto ha sido imputado por intento de homicidio. Has muerto 2 días después por las heridas. El esqueleto quedó libre a la semana.] FIN.");
                    Console.WriteLine("");

                    Console.WriteLine("                                       ##");
                    Console.WriteLine("                                       ##");
                    Console.WriteLine(" ##  ##   ##  ##    ####    ######    #####    ####");
                    Console.WriteLine(" #######  ##  ##   ##  ##    ##  ##    ##     ##  ##");
                    Console.WriteLine(" ## # ##  ##  ##   ######    ##        ##     ##  ##");
                    Console.WriteLine(" ##   ##  ##  ##   ##        ##        ## ##  ##  ##");
                    Console.WriteLine(" ##   ##   ######   #####   ####        ###    ####");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                    Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                    Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                    Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                    Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                    Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                    Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                    Console.WriteLine("                                                                                  #####");
                    Console.WriteLine(" El esqueleto sólo quería algo de cobijo, el pobre se moría de frío. De manera de agradecimiento el te regala su espada *Has conseguido [Espada]* y se largó de allí.");
                    Console.WriteLine(" Ahora te encuentras con una nueva decisión. ¿Entrar a la cueva o merodear para buscar otra?");
                    Console.WriteLine(" Entrara. [1]");
                    Console.WriteLine(" Merodear. [2]");
                    tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                        Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                        Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                        Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                        Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                        Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                        Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                        Console.WriteLine("                                                                                  #####");
                        Console.WriteLine("");

                        Console.WriteLine(" Has ido por la entrada principal y avanzado varios metros hasta encontrar la caverna. Allí, delante tuyo, se encuentra la gran bestia. ¿Qué decides?");
                        Console.WriteLine(" Gritar de miedo. [1]");
                        tecla = Console.ReadKey();
                        if (tecla.Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                            Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                            Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                            Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                            Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                            Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                            Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                            Console.WriteLine("                                                                                  #####");
                            Console.WriteLine(" No has ni podido abrir la boca que todo se funde a negro.");
                            Console.WriteLine(" [Una vez eres un espíritu ambulante vez que fuiste desintegrado, además de que ves al resto de fantasmas que querían encontrar a la princesa. Bueno, ¿Alguien sabe jugar al UNO?] FIN.");
                            Console.WriteLine("");

                            Console.WriteLine("                                       ##");
                            Console.WriteLine("                                       ##");
                            Console.WriteLine(" ##  ##   ##  ##    ####    ######    #####    ####");
                            Console.WriteLine(" #######  ##  ##   ##  ##    ##  ##    ##     ##  ##");
                            Console.WriteLine(" ## # ##  ##  ##   ######    ##        ##     ##  ##");
                            Console.WriteLine(" ##   ##  ##  ##   ##        ##        ## ##  ##  ##");
                            Console.WriteLine(" ##   ##   ######   #####   ####        ###    ####");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (tecla.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                        Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                        Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                        Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                        Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                        Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                        Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                        Console.WriteLine("                                                                                  #####");
                        Console.WriteLine(" Logras encontrar una reja extraña que decides romper.");
                        Console.WriteLine(" ¡Has encontrado a la princesa! Felicidades. Pero no todo está resuelto aún, debes marcharte antes de que te hagan puré. Ahora que has encontrado el amor de tu vida es momento de… ¿Casarte?");
                        Console.WriteLine(" Continuará.");

                        Console.WriteLine("");

                        Console.WriteLine("   ###      ##");
                        Console.WriteLine("  ## ##");
                        Console.WriteLine("   #       ###     #####");
                        Console.WriteLine(" ####       ##     ##  ##");
                        Console.WriteLine("  ##        ##     ##  ##");
                        Console.WriteLine("  ##        ##     ##  ##");
                        Console.WriteLine(" ####      ####    ##  ##");

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                        Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                        Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                        Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                        Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                        Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                        Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                        Console.WriteLine("                                                                                  #####");
                        Console.WriteLine(" Gracias por jugar.");
                        Console.WriteLine(" Este juego fue desarrollado, escrito y diseñado por: Matías Otamendi Moreno.");
                        Console.ReadKey();
                        Console.Clear();
                    }


                }

            }
            if (tecla.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("           ###       ##                                ###                 ##              ###        ##");
                Console.WriteLine("            ##       ##                                 ##                                  ##        ##");
                Console.WriteLine(" ##  ##     ##      #####   ######    ####              ##  ##  #####     ###      ### ##   ##       #####");
                Console.WriteLine(" ##  ##     ##       ##      ##  ##      ##             ## ##   ##  ##     ##     ##  ##    #####     ##");
                Console.WriteLine(" ##  ##     ##       ##      ##       #####             ####    ##  ##     ##     ##  ##    ##  ##    ##");
                Console.WriteLine(" ##  ##     ##       ## ##   ##      ##  ##             ## ##   ##  ##     ##      #####    ##  ##    ## ##");
                Console.WriteLine("  ######   ####       ###   ####      #####             ##  ##  ##  ##    ####        ##   ###  ##     ###");
                Console.WriteLine("                                                                                  #####");
                Console.WriteLine(" Decidiste bien, ¿Quién va a querer irse a buscar a alguien que ni conoces? ¡¿Además protegida por un [Dragón Guerrero Psíquico Ancestral]?! Para eso es mejor Tinder.");
                Console.WriteLine(" [Te has quedado en casa, jamás la pusiste y moriste a los 30 por tomar demasiada Monster.] FIN");
                Console.WriteLine("");

                Console.WriteLine("                                       ##");
                Console.WriteLine("                                       ##");
                Console.WriteLine(" ##  ##   ##  ##    ####    ######    #####    ####");
                Console.WriteLine(" #######  ##  ##   ##  ##    ##  ##    ##     ##  ##");
                Console.WriteLine(" ## # ##  ##  ##   ######    ##        ##     ##  ##");
                Console.WriteLine(" ##   ##  ##  ##   ##        ##        ## ##  ##  ##");
                Console.WriteLine(" ##   ##   ######   #####   ####        ###    ####");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
