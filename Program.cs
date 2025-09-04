using System;

class Bicicleta
{
    static void Main()
    {
        string modelo = Console.ReadLine();
        string nivelStr = Console.ReadLine();
        
        if (int.TryParse(nivelStr, out int nivelBateria))
        {
            BicicletaInterna bicicleta = new BicicletaInterna(modelo, nivelBateria);
            Console.WriteLine(bicicleta.ObterMensagem());
        }
        else
        {
            Console.WriteLine("Entrada de bateria inválida.");
        }
    }
}

class BicicletaInterna
{
    private string modelo;
    private int nivelBateria;

    public BicicletaInterna(string modelo, int nivelBateria)
    {
        this.modelo = modelo;
        this.nivelBateria = nivelBateria;
    }

    public double CalcularDistancia()
    {
        return (double)nivelBateria * 0.5;
    }

    public string ObterMensagem()
    {
        return $"{modelo}: Distancia estimada = {CalcularDistancia():F1} km";
    }
}
