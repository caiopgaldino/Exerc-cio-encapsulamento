using System;
namespace Encapsulamento
{
    public class Triangulo : Figura
    {
        private double _lado1;
        private double _lado2;
        private double _lado3;
        public double Lado1
        {
            get
            {
                return this._lado1;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Lado 1 inválido");
                }
                else
                {
                    this._lado1 = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Lado2
        {
            get
            {
                return this._lado2;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Lado 2 inválido");
                }
                else
                {
                    this._lado2 = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Lado3
        {
            get
            {
                return this._lado3;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Lado 3 inválido");
                }
                else
                {
                    this._lado3 = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
        private Double P()//Calcula o semiperímetro, usei heron pra calcular a área:)
        {
            return (this.Lado1 + this.Lado2 + this.Lado3)/2;

        }
        private void AtualizarArea()
        {
            this._area = Math.Sqrt(P()*(P()-_lado1)* (P() - _lado2)* (P() - _lado3));
        }

        private void AtualizarPerimetro()
        {
            this._perimetro = this._lado1 + this._lado2 + this._lado3;
        }
    }
}

