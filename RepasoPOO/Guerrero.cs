namespace RepasoPOO;

//Herencia: Guerrero hereda de Personaje
public class Guerrero : Personaje
{
    //Encapsulamiento: Atributos privados
    private int defensa;
    private string arma;

    public int Defensa
    {
        get { return defensa; }
        set { defensa = value > 0 ? value : 0; }
    }

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    public Guerrero(string nombre, int vida, int ataque, string tipo, int defensa, string arma)
        : base(nombre, vida, ataque, tipo)
    {
        this.defensa = defensa > 0 ? defensa : 5;
        this.arma = arma;
    }

    //Polimorfismo: Sobrescritura del método MostrarInformacion
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Defensa: {Defensa}");
        Console.WriteLine($"Arma: {Arma}");
        Console.WriteLine($"Clase: Guerrero");
    }

    public void Defender()
    {
        Console.WriteLine($"{Nombre} se defiende con {Defensa} puntos de defensa!");
    }
}
