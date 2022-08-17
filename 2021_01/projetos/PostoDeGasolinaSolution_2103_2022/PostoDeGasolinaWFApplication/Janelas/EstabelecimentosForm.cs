using PostoDeCombustivelCore.Errors.Failures;
using PostoDeGasolinaLibrary.Estabelecimentos.Controllers;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostoDeGasolinaWFApplication.Janelas
{
    public partial class EstabelecimentosForm : Form
    {
        public EstabelecimentosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show(_registrarEstabelecimento(textBox1.Text).Result);
        }

        private async Task<String> _registrarEstabelecimento(string nome)
        {
            var _controller = new RegistrarEstabelecimentoController();
            var controllerResult = await
                _controller.callable(
                    new EstabelecimentoEntity(nome)
                    );
            return controllerResult.Match(error =>
            {
                if (error is DataAccessFailure)
                {
                    return "Há problemas no acesso a dados";
                }
                return "Erro desconhecido";
            },
                    success =>
                    {
                        if (success)
                        {
                            return "Sucesso";
                        }
                        return "Falha";
                    });
        }
    }
}
