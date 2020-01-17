

using System;

public class Veiculo{ 

    private string marca;
    private string modelo;
    private string placa;
    private string cor;
    private double km;
    private bool ligado;
    private int litrosCombustivel;
    private int velocidade;
    private double preco;

    public Veiculo(string marca, string modelo, string placa, string cor, double km, bool ligado, int litrosCombustivel, int velocidade, double preco)
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Cor = cor;
        Km = km;
        Ligado = ligado;
        LitrosCombustivel = litrosCombustivel;
        Velocidade = velocidade;
        Preco = preco;
    }

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public double Km { get; set; }
    public bool Ligado { get; set; }
    public int LitrosCombustivel { get; set; }
    public int Velocidade { get; set; }
    public double Preco { get; set; }



    public void ligar() {
        if (Ligado == true)
        {
            Console.WriteLine("O carro já está ligado.");
        }
        else
        {
            Ligado = true;
        }
    
    }

    public void desligar() {

        if(Ligado == true)
        {
            Ligado = false;
        }
        else
        {
            Console.WriteLine("O carro já está desligado.");
        }
    
    }

    public void acelerar()
    {
        if(Ligado == true)
        {
            Velocidade += 20;
            LitrosCombustivel -= 1;
        }
        else
        {
            Console.WriteLine("Não é possível acelerar, o carro está desligado.");
        }

    }

    public void abastecer(int qtdLitros) {

        int maximoLitros = 100;
        int diferencaLitros = maximoLitros - LitrosCombustivel;

        if(qtdLitros <= diferencaLitros)
        {
            LitrosCombustivel += qtdLitros;
            Console.WriteLine("O total de litros do tanque é de " + LitrosCombustivel+".");
        }
        else
        {
            LitrosCombustivel -= qtdLitros;
            Console.WriteLine("Não é possível abastecer, a quantidade excede o máximo permitido de 100 litros. É possível abastecer a quantidade de " + diferencaLitros+" litros.");
        }

    }
    public void frear() {
        if (Ligado == true && Velocidade > 0)
        {
            Velocidade -= 10;
        }
        else
        {
            Console.WriteLine("O carro está desligado.");
        }
    
    }

    public void pintar(String cor)
    {
        Cor = cor;
        Console.WriteLine("A cor do carro é " + Cor + ".");
    }

   









}