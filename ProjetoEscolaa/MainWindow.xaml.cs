using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoEscolaa
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            // informações de registro
            string nomeFantasia = txtNomeFantasia.Text;
            string razãoSocial = txtRazaoSocial.Text;   
            string cnpj = txtCnpj.Text; 
            string inscriçãoEst = txtIscriacaoEst.Text;
            string telefoneEscola = txtTelefoneEscola.Text;
            string diretor = txtDiretor.Text;
            DatePicker dataCriacao = DataCriação;
            string tipo = "";
            
  
            // informações de localização
            string rua = txtRua.Text;
            string num = txtNumero.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cep = txtCep.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;

            if (rdPublico.IsChecked == true)
            {
                tipo = rdPublico.Content.ToString();
            }

            if (rdPrivado.IsChecked == true)
            {
                tipo = rdPrivado.Content.ToString();
            }


                MessageBox.Show("Informações de registro: " + Environment.NewLine +
                "Nome Fantasia: " + nomeFantasia + Environment.NewLine+
                "Razão social: " + razãoSocial + Environment.NewLine +
                "CNPJ :"+ cnpj + Environment.NewLine +
                "Incrição Estadual: " + inscriçãoEst + Environment.NewLine +
                "Telefone Escola: " + telefoneEscola + Environment.NewLine +
                "Tipo: " + tipo + Environment.NewLine +
                "Diretor responsavel: " + diretor + Environment.NewLine +
                "Data criação: " + dataCriacao + Environment.NewLine +
                "Informações de localização: " + Environment.NewLine +
                "Rua: " + rua + Environment.NewLine +
                "Numero: " + num + Environment.NewLine +
                "Bairro: " + bairro + Environment.NewLine +
                "Complemento: " + complemento + Environment.NewLine +
                "Telefone: " + telefone + Environment.NewLine +
                "Email: " + email + Environment.NewLine +
                "CEP: " + cep + Environment.NewLine +
                "Cidade: " + cidade + Environment.NewLine +
                "Estado: " + estado + Environment.NewLine);


            txtNomeFantasia.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCnpj.Clear();
            txtComplemento.Clear();
            txtDiretor.Clear();
            txtEmail.Clear();
            txtEstado.SelectedItem = null;
            txtIscriacaoEst.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtTelefoneEscola.Clear();
            txtRazaoSocial.Clear();
            DataCriação.SelectedDate = null;
            rdPrivado.IsChecked = false;
            rdPublico.IsChecked = false;


        }
    }
}
