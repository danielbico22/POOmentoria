using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmentoria
{
    public class Veiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Cor { get; set; }

        public double Preco { get; set; }

        public int km { get; set; }

        public Veiculo(string Marca, string Modelo, int Ano, string Cor, int km, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Cor = Cor;
            this.km = km;
            this.Preco = Preco;
            
        }

        public double valorFinal()
        {
            if (this.Preco >= 60000.00)
            {
                return this.Preco * 1.05;
            }
            else
            {
                return this.Preco * 1.025;
            }
        }  
        public double Imposto()
        {
            if(this.Preco >= 60000.00)
            {
                return this.Preco * 0.05;
            }
            
            else
            {
                return this.Preco * 0.025;
            }
            
        }

        
        public override string ToString()
        {
            return "Carro: " + this.Marca + ";" + "\n"
                + "Modelo: " + this.Modelo + ";" + "\n"
                + "Ano: " + this.Ano + ";" + "\n"
                + "Cor: " + this.Cor + ";" + "\n"
                + "Preço: " + this.Preco + ";" + " Valor imposto: " + Imposto() + ";" + "\n"
                + "Preço Final: " + valorFinal() + ";" + "\n"
                + "km: " + this.km +".";
        }
        

    }
}
