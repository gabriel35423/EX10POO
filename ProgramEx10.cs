using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex9
{
    internal class Peso
    {
        private double peso;
        private double altura;
       
        public void setpeso(double peso)
        {
            this.peso = peso;
        }
        public void setaltura(double altura)
        {
            this.altura = altura;
        }
        public double getpeso()
        {
            return this.peso;
        }
        public double getaltura()
        {
            return this.altura;
        }

        public void calcular()
        {
            double y;
           
            y = peso / (this.altura * this.altura);

            if (y < 20)
            {
                Console.WriteLine("abaixo  do peso", y);
            }
            else if (y >= 20 && y < 25)
            {
                Console.WriteLine("peso ideal", y);
            }
            else
            {
                Console.WriteLine("acima do peso", y);
            }
            
        }

        //Relação peso/altura²   (R) Mensagem
        //R < 20                 Abaixo do peso
        //20 <= R< 25            Peso ideal
        //R >= 25                Acima do peso
    }
}
