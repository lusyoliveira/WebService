using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            decimal ValorA;
            decimal ValorB;
            Calculadora.OperacoesBasicas operacao = Calculadora.OperacoesBasicas.Adicao;
            decimal Resultado;
            decimal.TryParse(TextBox1.Text, out ValorA);
            decimal.TryParse(TextBox2.Text, out ValorB);
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    operacao = Calculadora.OperacoesBasicas.Adicao;
                    break;
                case 1:
                    operacao = Calculadora.OperacoesBasicas.Divisao;
                    break;
                case 2:
                    operacao = Calculadora.OperacoesBasicas.Multiplicacao;
                    break;
                case 3:
                    operacao = Calculadora.OperacoesBasicas.Subtracao;
                    break;
                default:
                    operacao = Calculadora.OperacoesBasicas.Adicao;
                    break;
            }
            Calculadora.Service MeuWebService = new Calculadora.Service();
            Resultado = MeuWebService.Calculadora(ValorA, ValorB, operacao);
            TextBox3.Text = Resultado.ToString();
        }
    }
}