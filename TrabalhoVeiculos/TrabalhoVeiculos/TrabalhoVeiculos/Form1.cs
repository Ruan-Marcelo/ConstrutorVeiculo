using TrabalhoVeiculos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Veiculo o_Veiculo = new Veiculo();
            
        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            o_Veiculo.Acelerar(10f);
        }

        private void btnFrear_Click(object sender, EventArgs e)
        {
            o_Veiculo.Frear();          
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            o_Veiculo.Marca = "Mazda";
            o_Veiculo.Modelo = "787B";
            o_Veiculo.Cor = "Verde e Laranja";
            o_Veiculo.Ano = 1991;
            o_Veiculo.NumPortas = 2;
            o_Veiculo.Proprietario = "Ruan Marcelo";
            o_Veiculo.VeloMax = 330;
            o_Veiculo.QntdDeMarchas = 6;

            o_Veiculo.Imprimir();
        }
    } 
}
