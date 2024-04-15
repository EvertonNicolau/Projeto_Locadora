
namespace projLocadora
{
    partial class frmFilmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProdutora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTituloFilme = new System.Windows.Forms.TextBox();
            this.TituloFilme = new System.Windows.Forms.Label();
            this.txtAnoFilme = new System.Windows.Forms.TextBox();
            this.AnoFilme = new System.Windows.Forms.Label();
            this.txtCodFilme = new System.Windows.Forms.TextBox();
            this.CodFilme = new System.Windows.Forms.Label();
            this.txtNovo = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTituloFilme);
            this.groupBox1.Controls.Add(this.TituloFilme);
            this.groupBox1.Controls.Add(this.txtAnoFilme);
            this.groupBox1.Controls.Add(this.AnoFilme);
            this.groupBox1.Controls.Add(this.txtCodFilme);
            this.groupBox1.Controls.Add(this.CodFilme);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(30, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.cmbGenero);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(452, 206);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(403, 164);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gêneros";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Suspense",
            "Comédia",
            "Terror",
            "Drama",
            "Romance",
            "Documentário",
            "Ficção Científica"});
            this.cmbGenero.Location = new System.Drawing.Point(199, 58);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(168, 31);
            this.cmbGenero.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gênero";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.cmbProdutora);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(18, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(403, 164);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtora";
            // 
            // cmbProdutora
            // 
            this.cmbProdutora.FormattingEnabled = true;
            this.cmbProdutora.Items.AddRange(new object[] {
            "Warner",
            "Disney",
            "HBO",
            "Netflix",
            "Universal",
            "Paramount",
            "Sony"});
            this.cmbProdutora.Location = new System.Drawing.Point(199, 58);
            this.cmbProdutora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProdutora.Name = "cmbProdutora";
            this.cmbProdutora.Size = new System.Drawing.Size(168, 31);
            this.cmbProdutora.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Produtora";
            // 
            // txtTituloFilme
            // 
            this.txtTituloFilme.Location = new System.Drawing.Point(319, 57);
            this.txtTituloFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTituloFilme.Name = "txtTituloFilme";
            this.txtTituloFilme.Size = new System.Drawing.Size(393, 30);
            this.txtTituloFilme.TabIndex = 5;
            // 
            // TituloFilme
            // 
            this.TituloFilme.AutoSize = true;
            this.TituloFilme.Location = new System.Drawing.Point(213, 57);
            this.TituloFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloFilme.Name = "TituloFilme";
            this.TituloFilme.Size = new System.Drawing.Size(73, 23);
            this.TituloFilme.TabIndex = 4;
            this.TituloFilme.Text = "Título";
            // 
            // txtAnoFilme
            // 
            this.txtAnoFilme.Location = new System.Drawing.Point(319, 133);
            this.txtAnoFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnoFilme.Name = "txtAnoFilme";
            this.txtAnoFilme.Size = new System.Drawing.Size(138, 30);
            this.txtAnoFilme.TabIndex = 3;
            // 
            // AnoFilme
            // 
            this.AnoFilme.AutoSize = true;
            this.AnoFilme.Location = new System.Drawing.Point(214, 133);
            this.AnoFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnoFilme.Name = "AnoFilme";
            this.AnoFilme.Size = new System.Drawing.Size(52, 23);
            this.AnoFilme.TabIndex = 2;
            this.AnoFilme.Text = "Ano";
            // 
            // txtCodFilme
            // 
            this.txtCodFilme.Location = new System.Drawing.Point(319, 95);
            this.txtCodFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodFilme.Name = "txtCodFilme";
            this.txtCodFilme.Size = new System.Drawing.Size(138, 30);
            this.txtCodFilme.TabIndex = 1;
            // 
            // CodFilme
            // 
            this.CodFilme.AutoSize = true;
            this.CodFilme.Location = new System.Drawing.Point(213, 95);
            this.CodFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodFilme.Name = "CodFilme";
            this.CodFilme.Size = new System.Drawing.Size(80, 23);
            this.CodFilme.TabIndex = 0;
            this.CodFilme.Text = "Código";
            // 
            // txtNovo
            // 
            this.txtNovo.Location = new System.Drawing.Point(115, 33);
            this.txtNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(105, 37);
            this.txtNovo.TabIndex = 2;
            this.txtNovo.Text = "Novo";
            this.txtNovo.UseVisualStyleBackColor = true;
            this.txtNovo.Click += new System.EventHandler(this.txtNovo_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(681, 33);
            this.txtModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(137, 37);
            this.txtModificar.TabIndex = 3;
            this.txtModificar.Text = "Modificar";
            this.txtModificar.UseVisualStyleBackColor = true;
            this.txtModificar.Click += new System.EventHandler(this.txtModificar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(512, 491);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(105, 29);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(681, 491);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(105, 29);
            this.btnUltimo.TabIndex = 5;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(300, 491);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(105, 29);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(132, 491);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(105, 29);
            this.btnPrimeiro.TabIndex = 7;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(497, 33);
            this.txtExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(120, 37);
            this.txtExcluir.TabIndex = 8;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(300, 33);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 37);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.txtSalvar_Click);
            // 
            // frmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(933, 565);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.txtNovo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.frmFilmes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProdutora;
        private System.Windows.Forms.TextBox txtTituloFilme;
        private System.Windows.Forms.Label TituloFilme;
        private System.Windows.Forms.TextBox txtAnoFilme;
        private System.Windows.Forms.Label AnoFilme;
        private System.Windows.Forms.TextBox txtCodFilme;
        private System.Windows.Forms.Label CodFilme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtNovo;
        private System.Windows.Forms.Button txtModificar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Button btnSalvar;
    }
}