using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementosConectados
{
	public partial class Form1 : Form
	{
		Network conjunto;

		public Form1()
		{
			InitializeComponent();
		}

		//Evento do botão para cadastrar o conjunto de elementos
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			int numElem = Convert.ToInt16(numElementos.Value);

			if (numElem != 0)
			{
				//Instancia Networs conjunto
				conjunto = new Network(numElem);

				//Desabilita o campo e o botão de cadastro de conjunto
				numElementos.Enabled = false;
				btnCadastrar.Enabled = false;

				//Popula os combos com os elementos disponíveis do conjunto
				cmbElem1Conect.DataSource = conjunto.getElements();
				cmbElem2Conect.DataSource = conjunto.getElements();
				cmbElem1Consult.DataSource = conjunto.getElements();
				cmbElem2Consult.DataSource = conjunto.getElements();
				btnConectar.Enabled = true;
				btnConsultar.Enabled = true;

			}
			else
			{
				MessageBox.Show("O número de elementos deve ser maior do que 0.");
			}
		}

		//Evento do botão que realiza a conexão entre dois elementos
		private void btnConectar_Click(object sender, EventArgs e)
		{
			//Tratamento de exceções
			try
			{
				conjunto.Connect((int)cmbElem1Conect.SelectedValue, (int)cmbElem2Conect.SelectedValue);

				listConnections.Items.Add(cmbElem1Conect.SelectedValue + " - " + cmbElem2Conect.SelectedValue);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		//Evento do botão que realiza a consulta de conexão entre dois elementos
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			//Tratamento de exceções
			try
			{
				if (conjunto.Query((int)cmbElem1Consult.SelectedValue, (int)cmbElem2Consult.SelectedValue))
				{
					MessageBox.Show(String.Format("Os elementos {0} e {1} estão conectados!", cmbElem1Consult.SelectedValue, cmbElem2Consult.SelectedValue));
				}
				else
				{
					MessageBox.Show(String.Format("Os elementos {0} e {1} não estão conectados!", cmbElem1Consult.SelectedValue, cmbElem2Consult.SelectedValue));
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		//Botão para redefinir o layout inicial do sistema
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			listConnections.Clear();
			cmbElem1Conect.DataSource = null;
			cmbElem2Conect.DataSource = null;
			cmbElem1Consult.DataSource = null;
			cmbElem2Consult.DataSource = null;
			btnCadastrar.Enabled = true;
			numElementos.Enabled = true;
			btnConectar.Enabled = false;
			btnConsultar.Enabled = false;
			conjunto = null;
		}

		//Realiza a saída do sistema
		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
