using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmentoria
{
    internal class Moto : Veiculo

    {

        public double valorFinalMoto()
        {
            if (this.Preco >= 20000.00)
            {
                return this.Preco * 1.03;
            }
            return this.Preco;
        }
        public double ImpostoMoto()
        {
            if (this.Preco >= 20000.00)
            {
                return this.Preco * 0.03;
            }

            else
            {
                return this.Preco - this.Preco;
            }

        }
        public int Cilindrada { get; set; }
        public Moto(string Marca, string Modelo, int Cilindrada, int Ano, string Cor, int km, double Preco) : base(Marca, Modelo, Ano, Cor, km, Preco)
        {
            this.Cilindrada = Cilindrada;
        }
        public override string ToString()
        {
            return "Moto: " + this.Marca + ";" + "\n"
                + "Modelo: " + this.Modelo + ";" + "\n"
                + "Cilindrada: " + this.Cilindrada + ";" + "\n"
                + "Ano: " + this.Ano + ";" + "\n"
                + "Cor: " + this.Cor + ";" + "\n"
                + "Preço: " + this.Preco + ";" + " Valor imposto: " + ImpostoMoto() + ";" + "\n"
                + "Preço Final: " + valorFinalMoto() + ";" + "\n"
                + "km: " + this.km + ".";
        }

    }
}
