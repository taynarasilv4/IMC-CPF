using System.Runtime.CompilerServices;

public class Pessoa
{
    private string nome;
    private string cpf;
    private int idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, int idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public double CalcularIMC(double altura, double peso)
    {
        return peso / Math.Pow(altura, 2);
    }


    public (double,string, string) CalcularIMC()
    {
       double imc = this.peso / Math.Pow(this.altura, 2);
       string classificacao = "Magreza" + "Normal" + "SobrePeso" + "obesidade" + "obesidade Grave";
       string grau = "0" + "0" + "1" + "2" + "3";



            if ( imc < 18.5)
            {

                 classificacao = "Magraza";
                 grau = "0";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classificacao = "Normal";
                grau = "0";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                classificacao =  "Sobrepeso";
                grau = "1";
            }
            else if (imc >= 30.0 && imc <= 39.9)
            {
                classificacao = "Obesidade";
                grau = "2";
            }
            else
            {
                classificacao = "Obesidade Grave";
                grau = "3";
            }
        

       

        return (imc, classificacao, grau);
    }

    public double getPessoa()
    {
        return this.peso;
         
    }

    public void setPessoa(double peso)
    {
        this.peso = peso;
    }

    public double getAltura() 
    {
        return this.altura;
    }

    public void getAltura(double altura)
    {
        this.altura = altura;
    }


}