using ClientesXML.entities;
using ClientesXML.exception;
using ClientesXML.service;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClientesXML
{

    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private ClientesDAO clientesDAO = new ClientesDAO();
        public string Path = "C:\\Users\\willy\\source\\repos\\ClientesXML\\ClientesXML\\dados\\Cadastros.xml";
        public Form1()
        {
            InitializeComponent();
            clientes = clientesDAO.Carregar(Path, dtgView);

        }
        private void btnCad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtMail.Text) || txtNome.Text is int)
            {
                MessageBox.Show($"Preencha todos os campos corretamente para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidaEmail(txtMail.Text))
            {
                MessageBox.Show($"Digite um email valido para prosseguir","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                Cliente cliente = new Cliente();
               if (Regex.IsMatch(txtNome.Text,@"\d")) {
                    txtNome.Clear();
                    throw new DomainException("Não pode conter numeros em um nome");
                }
                cliente.Nome = txtNome.Text;
                cliente.Email = txtMail.Text;
                clientes.Add(cliente);
                MessageBox.Show($"Cliente adicionado com sucesso!\n\nNome: {clientes.LastOrDefault().Nome}\nEmail: {clientes.LastOrDefault().Email}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCampos();
                clientesDAO.Salvar(Path, clientes);
                clientesDAO.Carregar(Path, dtgView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Brutal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                int rowIndex = dtgView.SelectedRows[0].Index;
                MessageBox.Show($"CLIENTE REMOVIDO\n\nNome: {clientes.ElementAt(rowIndex).Nome}\nEmail: {clientes.ElementAt(rowIndex).Email}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientes.RemoveAt(rowIndex);
                clientesDAO.Salvar(Path, clientes);
                clientesDAO.Carregar(Path, dtgView);
            }
        }
        private void ClearCampos()
        {
            txtNome.Clear();
            txtMail.Clear();
        }
        private bool ValidaEmail(string email)
        {
            try
            {
                var ValMail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
