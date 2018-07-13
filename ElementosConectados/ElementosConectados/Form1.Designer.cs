namespace ElementosConectados
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
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConectar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbElem2Conect = new System.Windows.Forms.ComboBox();
			this.cmbElem1Conect = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbElem2Consult = new System.Windows.Forms.ComboBox();
			this.cmbElem1Consult = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listConnections = new System.Windows.Forms.ListView();
			this.numElementos = new System.Windows.Forms.NumericUpDown();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numElementos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(96, 35);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 1;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Número de elementos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Elemento 1";
			// 
			// btnConectar
			// 
			this.btnConectar.Enabled = false;
			this.btnConectar.Location = new System.Drawing.Point(84, 82);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(75, 23);
			this.btnConectar.TabIndex = 4;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Elemento 2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Elemento 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Elemento 1";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Enabled = false;
			this.btnConsultar.Location = new System.Drawing.Point(84, 82);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 9;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbElem2Conect);
			this.groupBox1.Controls.Add(this.cmbElem1Conect);
			this.groupBox1.Controls.Add(this.btnConectar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(169, 111);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Conectar";
			// 
			// cmbElem2Conect
			// 
			this.cmbElem2Conect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbElem2Conect.FormattingEnabled = true;
			this.cmbElem2Conect.Location = new System.Drawing.Point(3, 84);
			this.cmbElem2Conect.Name = "cmbElem2Conect";
			this.cmbElem2Conect.Size = new System.Drawing.Size(63, 21);
			this.cmbElem2Conect.TabIndex = 17;
			// 
			// cmbElem1Conect
			// 
			this.cmbElem1Conect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbElem1Conect.FormattingEnabled = true;
			this.cmbElem1Conect.Location = new System.Drawing.Point(3, 38);
			this.cmbElem1Conect.Name = "cmbElem1Conect";
			this.cmbElem1Conect.Size = new System.Drawing.Size(63, 21);
			this.cmbElem1Conect.TabIndex = 16;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbElem2Consult);
			this.groupBox2.Controls.Add(this.cmbElem1Consult);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnConsultar);
			this.groupBox2.Location = new System.Drawing.Point(12, 194);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(169, 111);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Consultar";
			// 
			// cmbElem2Consult
			// 
			this.cmbElem2Consult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbElem2Consult.FormattingEnabled = true;
			this.cmbElem2Consult.Location = new System.Drawing.Point(3, 84);
			this.cmbElem2Consult.Name = "cmbElem2Consult";
			this.cmbElem2Consult.Size = new System.Drawing.Size(63, 21);
			this.cmbElem2Consult.TabIndex = 19;
			// 
			// cmbElem1Consult
			// 
			this.cmbElem1Consult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbElem1Consult.FormattingEnabled = true;
			this.cmbElem1Consult.Location = new System.Drawing.Point(3, 38);
			this.cmbElem1Consult.Name = "cmbElem1Consult";
			this.cmbElem1Consult.Size = new System.Drawing.Size(63, 21);
			this.cmbElem1Consult.TabIndex = 18;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listConnections);
			this.groupBox3.Location = new System.Drawing.Point(187, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(123, 293);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Conexões";
			// 
			// listConnections
			// 
			this.listConnections.GridLines = true;
			this.listConnections.Location = new System.Drawing.Point(7, 20);
			this.listConnections.Name = "listConnections";
			this.listConnections.Size = new System.Drawing.Size(109, 267);
			this.listConnections.TabIndex = 0;
			this.listConnections.UseCompatibleStateImageBehavior = false;
			this.listConnections.View = System.Windows.Forms.View.List;
			// 
			// numElementos
			// 
			this.numElementos.Location = new System.Drawing.Point(12, 38);
			this.numElementos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numElementos.Name = "numElementos";
			this.numElementos.Size = new System.Drawing.Size(66, 20);
			this.numElementos.TabIndex = 16;
			this.numElementos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(157, 311);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 17;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(238, 312);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 18;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 337);
			this.ControlBox = false;
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.numElementos);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCadastrar);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Conjunto de elementos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numElementos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbElem2Conect;
		private System.Windows.Forms.ComboBox cmbElem1Conect;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbElem2Consult;
		private System.Windows.Forms.ComboBox cmbElem1Consult;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listConnections;
		private System.Windows.Forms.NumericUpDown numElementos;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
	}
}

