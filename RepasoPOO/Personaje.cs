namespace RepasoPOO;

//Abstracción: Clase abstracta
public abstract class Personaje
{
    //Encapsulamiento: Atributos privados
    private string nombre;
    private int vida;
    private int ataque;
    private string tipo;

    //Encapsulamiento: Propiedades públicas para acceder a los atributos privados
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value > 0 ? value : 0; }
    }

    public int Ataque
    {
        get { return ataque; }
        set { ataque = value > 0 ? value : 0; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public Personaje(string nombre, int vida, int ataque, string tipo)
    {
        this.nombre = nombre;
        this.vida = vida > 0 ? vida : 100;
        this.ataque = ataque > 0 ? ataque : 10;
        this.tipo = tipo;
    }

    //Polimorfismo: Método virtual que puede ser sobrescrito por clases derivadas
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"\n--- Información del Personaje ---");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Tipo: {Tipo}");
    }

    public void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca con {Ataque} puntos de daño!");
    }
}
