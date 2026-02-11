namespace RepasoPOO;

class Program
{
    //Polimorfismo - Lista que puede contener Guerreros y Magos
    static List<Personaje> personajes = new List<Personaje>();

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    CrearPersonaje();
                    break;
                case 2:
                    MostrarPersonajes();
                    break;
                case 3:
                    Console.WriteLine("\n¡Gracias por jugar!.");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }

            if (opcion != 3)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Sistema de Personajes");
        Console.WriteLine("\n1. Crear un nuevo personaje");
        Console.WriteLine("2. Mostrar personajes creados");
        Console.WriteLine("3. Salir");
    }

    static int LeerOpcion()
    {
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        return -1;
    }

    static void CrearPersonaje()
    {
        Console.Clear();
        Console.WriteLine("Crear un personaje");
        Console.WriteLine("\nSeleccione el tipo de personaje:");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Mago");
        Console.Write("\nOpción: ");

        int tipo = LeerOpcion();

        Console.Write("\nNombre del personaje: ");
        string nombre = Console.ReadLine() ?? "Sin nombre";

        Console.Write("Vida: ");
        int vida = LeerEntero();

        Console.Write("Ataque: ");
        int ataque = LeerEntero();

        Console.Write("Tipo (Aliado/Villano): ");
        string tipoPersonaje = Console.ReadLine() ?? "Aliado";

        if (tipo == 1)
        {
            Console.Write("Defensa: ");
            int defensa = LeerEntero();

            Console.Write("Arma: ");
            string arma = Console.ReadLine() ?? "Espada";

            Guerrero guerrero = new Guerrero(nombre, vida, ataque, tipoPersonaje, defensa, arma);
            personajes.Add(guerrero);
            Console.WriteLine("\n¡Guerrero creado exitosamente!");
        }
        else if (tipo == 2)
        {
            Console.Write("Maná: ");
            int mana = LeerEntero();

            Console.Write("Hechizo principal: ");
            string hechizo = Console.ReadLine() ?? "Bola de Fuego";

            Mago mago = new Mago(nombre, vida, ataque, tipoPersonaje, mana, hechizo);
            personajes.Add(mago);
            Console.WriteLine("\n¡Mago creado exitosamente!");
        }
        else
        {
            Console.WriteLine("\nTipo de personaje inválido.");
        }
    }

    static void MostrarPersonajes()
    {
        Console.Clear();
        Console.WriteLine("Personajes disponibles");

        if (personajes.Count == 0)
        {
            Console.WriteLine("\nNo hay personajes creados aún.");
            return;
        }

        for (int i = 0; i < personajes.Count; i++)
        {
            Console.WriteLine($"\n═══ Personaje #{i + 1} ═══");
            //Polimorfismo: se muestra la información de cada personaje, ya sea Guerrero o Mago
            personajes[i].MostrarInformacion();
        }

        Console.WriteLine($"\n\nTotal de personajes: {personajes.Count}");
    }

    static int LeerEntero()
    {
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            return numero;
        }
        return 0;
    }
}
