namespace RepasoPOO;

//Herencia: Mago hereda de Personaje
public class Mago : Personaje
{
    //Encapsulamiento: Atributos privados
    private int mana;
    private string hechizo;

    public int Mana
    {
        get { return mana; }
        set { mana = value > 0 ? value : 0; }
    }

    public string Hechizo
    {
        get { return hechizo; }
        set { hechizo = value; }
    }

    public Mago(string nombre, int vida, int ataque, string tipo, int mana, string hechizo)
        : base(nombre, vida, ataque, tipo)
    {
        this.mana = mana > 0 ? mana : 50;
        this.hechizo = hechizo;
    }

    //Polimorfismo: Sobrescritura del método MostrarInformacion
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Maná: {Mana}");
        Console.WriteLine($"Hechizo Principal: {Hechizo}");
        Console.WriteLine($"Clase: Mago");
    }

    public void LanzarHechizo()
    {
        if (Mana >= 10)
        {
            Console.WriteLine($"{Nombre} lanza {Hechizo}!");
            Mana -= 10;
        }
        else
        {
            Console.WriteLine($"{Nombre} no tiene suficiente maná!");
        }
    }
}
