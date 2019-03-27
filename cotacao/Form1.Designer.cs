namespace cotacao
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnCompra = new System.Windows.Forms.Button();
			this.btnVenda = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblValor = new System.Windows.Forms.Label();
			this.rbnDolar = new System.Windows.Forms.RadioButton();
			this.rbnEuro = new System.Windows.Forms.RadioButton();
			this.rbnIene = new System.Windows.Forms.RadioButton();
			this.rbnDolarCanadense = new System.Windows.Forms.RadioButton();
			this.gbxMoeda = new System.Windows.Forms.GroupBox();
			this.gbxMoeda.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCompra
			// 
			this.btnCompra.Location = new System.Drawing.Point(53, 179);
			this.btnCompra.Name = "btnCompra";
			this.btnCompra.Size = new System.Drawing.Size(92, 35);
			this.btnCompra.TabIndex = 3;
			this.btnCompra.Text = "COMPRA";
			this.btnCompra.UseVisualStyleBackColor = true;
			this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
			// 
			// btnVenda
			// 
			this.btnVenda.Location = new System.Drawing.Point(161, 179);
			this.btnVenda.Name = "btnVenda";
			this.btnVenda.Size = new System.Drawing.Size(92, 35);
			this.btnVenda.TabIndex = 4;
			this.btnVenda.Text = "VENDA";
			this.btnVenda.UseVisualStyleBackColor = true;
			this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(104, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(93, 20);
			this.lblTitulo.TabIndex = 7;
			this.lblTitulo.Text = "COTAÇÃO";
			// 
			// lblValor
			// 
			this.lblValor.BackColor = System.Drawing.Color.NavajoWhite;
			this.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblValor.Location = new System.Drawing.Point(105, 234);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(106, 23);
			this.lblValor.TabIndex = 8;
			// 
			// rbnDolar
			// 
			this.rbnDolar.AutoSize = true;
			this.rbnDolar.Location = new System.Drawing.Point(7, 30);
			this.rbnDolar.Name = "rbnDolar";
			this.rbnDolar.Size = new System.Drawing.Size(50, 17);
			this.rbnDolar.TabIndex = 0;
			this.rbnDolar.TabStop = true;
			this.rbnDolar.Text = "Dólar";
			this.rbnDolar.UseVisualStyleBackColor = true;
			// 
			// rbnEuro
			// 
			this.rbnEuro.AutoSize = true;
			this.rbnEuro.Location = new System.Drawing.Point(120, 53);
			this.rbnEuro.Name = "rbnEuro";
			this.rbnEuro.Size = new System.Drawing.Size(47, 17);
			this.rbnEuro.TabIndex = 1;
			this.rbnEuro.TabStop = true;
			this.rbnEuro.Text = "Euro";
			this.rbnEuro.UseVisualStyleBackColor = true;
			// 
			// rbnIene
			// 
			this.rbnIene.AutoSize = true;
			this.rbnIene.Location = new System.Drawing.Point(120, 30);
			this.rbnIene.Name = "rbnIene";
			this.rbnIene.Size = new System.Drawing.Size(46, 17);
			this.rbnIene.TabIndex = 2;
			this.rbnIene.TabStop = true;
			this.rbnIene.Text = "Iene";
			this.rbnIene.UseVisualStyleBackColor = true;
			// 
			// rbnDolarCanadense
			// 
			this.rbnDolarCanadense.AutoSize = true;
			this.rbnDolarCanadense.Location = new System.Drawing.Point(7, 53);
			this.rbnDolarCanadense.Name = "rbnDolarCanadense";
			this.rbnDolarCanadense.Size = new System.Drawing.Size(107, 17);
			this.rbnDolarCanadense.TabIndex = 3;
			this.rbnDolarCanadense.TabStop = true;
			this.rbnDolarCanadense.Text = "Dólar Canadense";
			this.rbnDolarCanadense.UseVisualStyleBackColor = true;
			// 
			// gbxMoeda
			// 
			this.gbxMoeda.Controls.Add(this.rbnDolarCanadense);
			this.gbxMoeda.Controls.Add(this.rbnIene);
			this.gbxMoeda.Controls.Add(this.rbnEuro);
			this.gbxMoeda.Controls.Add(this.rbnDolar);
			this.gbxMoeda.Location = new System.Drawing.Point(53, 67);
			this.gbxMoeda.Name = "gbxMoeda";
			this.gbxMoeda.Size = new System.Drawing.Size(200, 95);
			this.gbxMoeda.TabIndex = 1;
			this.gbxMoeda.TabStop = false;
			this.gbxMoeda.Text = "Selecione a Moeda";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 295);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnVenda);
			this.Controls.Add(this.btnCompra);
			this.Controls.Add(this.gbxMoeda);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Cotação";
			this.gbxMoeda.ResumeLayout(false);
			this.gbxMoeda.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCompra;
		private System.Windows.Forms.Button btnVenda;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.RadioButton rbnDolar;
		private System.Windows.Forms.RadioButton rbnEuro;
		private System.Windows.Forms.RadioButton rbnIene;
		private System.Windows.Forms.RadioButton rbnDolarCanadense;
		private System.Windows.Forms.GroupBox gbxMoeda;
	}
}

