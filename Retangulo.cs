using System;
namespace Encapsulamento
{
    public class Retangulo : Figura
    {
        private double _largura;
        private double _altura;
        public double Largura
        {
            get
            {
                return this._largura;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Largura inválida");
                }
                else
                {
                    this._largura = value;             
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Altura
        {
            get
            {
                return this._altura;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double altura, double largura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        private void AtualizarArea()
        {
            this._area = this._altura * this._largura;
        }

        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * (this._largura + this._altura);
        }

    }
}
