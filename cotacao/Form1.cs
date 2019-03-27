using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotacao
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnVenda_Click(object sender, EventArgs e)
		{
			int codigoVenda = 0;

			if (rbnDolar.Checked == true)
			codigoVenda = 1;
			
			if (rbnDolarCanadense.Checked == true)
			codigoVenda = 21635;
			
			if (rbnIene.Checked == true)
			codigoVenda = 21621;

			if (rbnEuro.Checked == true)
			codigoVenda = 21619;

			CotarVenda(codigoVenda);
		}

		private void CotarVenda(int codigoVenda)
		{
			var service = new Moeda.FachadaWSSGSClient();
			var cotacao = service.getUltimoValorVO(codigoVenda);
			string valor = (cotacao.ultimoValor.svalor).ToString();
			lblValor.Text = valor.ToString();
		}

		private void btnCompra_Click(object sender, EventArgs e)
		{
			int codigoCompra = 0;

			if (rbnDolar.Checked == true)
				codigoCompra = 10813;

			if (rbnDolarCanadense.Checked == true)
				codigoCompra = 21636;

			if (rbnIene.Checked == true)
				codigoCompra = 21622;

			if (rbnEuro.Checked == true)
				codigoCompra = 21620;

			CotarCompra(codigoCompra);
		}

		private void CotarCompra(int codigoCompra)
		{
			var service = new Moeda.FachadaWSSGSClient();
			var cotacao = service.getUltimoValorVO(codigoCompra);
			string valor = (cotacao.ultimoValor.svalor).ToString();
			lblValor.Text = valor.ToString();
		}
	}
}
