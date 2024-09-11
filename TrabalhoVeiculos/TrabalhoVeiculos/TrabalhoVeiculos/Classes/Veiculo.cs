using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoVeiculos.Classes
{
    internal class Veiculo
    {
        //Propriedades
        private string marca;
        private string modelo;
        private string cor;
        private int ano;
        private int numPortas;
        private int chassi;
        private string proprietario;
        private float veloAtual;
        private int veloMax;
        private int qntdDeMarchas;



        //Construtor
        public Veiculo()
        {
            Random random = new Random();
            chassi = random.Next(0, 10000);

            Console.WriteLine($"O número do seu chassi é: {chassi}");
        }

        //Atributos

        public int QntdDeMarchas
        {
            get { return qntdDeMarchas; }
            set { qntdDeMarchas = value; }
        }
        public int VeloMax
        {
            get { return veloMax; }
            set { veloMax = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int NumPortas
        {
            get { return numPortas; }
            set { numPortas = value; }
        }
        public string Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }


        //Métodos
        public void Acelerar(float kms)
        {
            veloAtual = veloAtual + kms;
            Console.WriteLine($"Sua Velocidade Atuel é de: {veloAtual}");
        }
        public void Frear()
        {
            veloAtual = 0;
            Console.WriteLine($"Veiculo Freado, sua velocidade atual é de: {veloAtual}");

        }

        public void Imprimir()
        {
            Console.WriteLine($"Marca do Veiculo: {marca}");
            Console.WriteLine($"Modelo do Veiculo: {modelo}");
            Console.WriteLine($"Cor do Veiculo: {cor}");
            Console.WriteLine($"Ano do Veiculo: {ano}");
            Console.WriteLine($"Númeor de Portas: {numPortas}");
            Console.WriteLine($"Nome do Proprietario: {proprietario}");
            Console.WriteLine($"Aproximadamente {veloMax} km/h (205 mph)");
            Console.WriteLine($"Quantidade de marchas: {qntdDeMarchas}");
        }
    }
}
