namespace WFA_ex_veiculo
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
            this.rb_Caminhao = new System.Windows.Forms.RadioButton();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.lb_Quantidade = new System.Windows.Forms.Label();
            this.tb_assentos_ou_eixos = new System.Windows.Forms.TextBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.lvl_Dados = new System.Windows.Forms.ListView();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.rb_Onibus = new System.Windows.Forms.RadioButton();
            this.mtb_Placa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Caminhao
            // 
            this.rb_Caminhao.AutoSize = true;
            this.rb_Caminhao.Location = new System.Drawing.Point(201, 29);
            this.rb_Caminhao.Name = "rb_Caminhao";
            this.rb_Caminhao.Size = new System.Drawing.Size(89, 20);
            this.rb_Caminhao.TabIndex = 1;
            this.rb_Caminhao.TabStop = true;
            this.rb_Caminhao.Text = "Caminhão";
            this.rb_Caminhao.UseVisualStyleBackColor = true;
            this.rb_Caminhao.CheckedChanged += new System.EventHandler(this.rb_Caminhao_CheckedChanged);
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Location = new System.Drawing.Point(84, 79);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(42, 16);
            this.lb_Placa.TabIndex = 3;
            this.lb_Placa.Text = "Placa";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(84, 115);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 5;
            this.lbAno.Text = "Ano";
            // 
            // tb_Ano
            // 
            this.tb_Ano.Location = new System.Drawing.Point(185, 109);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(89, 22);
            this.tb_Ano.TabIndex = 6;
            // 
            // lb_Quantidade
            // 
            this.lb_Quantidade.AutoSize = true;
            this.lb_Quantidade.Location = new System.Drawing.Point(84, 163);
            this.lb_Quantidade.Name = "lb_Quantidade";
            this.lb_Quantidade.Size = new System.Drawing.Size(28, 16);
            this.lb_Quantidade.TabIndex = 7;
            this.lb_Quantidade.Text = "Qtd";
            // 
            // tb_assentos_ou_eixos
            // 
            this.tb_assentos_ou_eixos.Location = new System.Drawing.Point(185, 160);
            this.tb_assentos_ou_eixos.Name = "tb_assentos_ou_eixos";
            this.tb_assentos_ou_eixos.Size = new System.Drawing.Size(89, 22);
            this.tb_assentos_ou_eixos.TabIndex = 8;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Location = new System.Drawing.Point(470, 218);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(123, 51);
            this.bt_Cadastrar.TabIndex = 11;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(610, 219);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(123, 50);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // lvl_Dados
            // 
            this.lvl_Dados.HideSelection = false;
            this.lvl_Dados.Location = new System.Drawing.Point(87, 275);
            this.lvl_Dados.Name = "lvl_Dados";
            this.lvl_Dados.Size = new System.Drawing.Size(582, 153);
            this.lvl_Dados.TabIndex = 13;
            this.lvl_Dados.UseCompatibleStateImageBehavior = false;
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::WFA_ex_veiculo.Properties.Resources.onibus;
            this.pbImagem.Location = new System.Drawing.Point(470, 29);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(229, 180);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 14;
            this.pbImagem.TabStop = false;
            // 
            // rb_Onibus
            // 
            this.rb_Onibus.AutoSize = true;
            this.rb_Onibus.Location = new System.Drawing.Point(87, 28);
            this.rb_Onibus.Name = "rb_Onibus";
            this.rb_Onibus.Size = new System.Drawing.Size(70, 20);
            this.rb_Onibus.TabIndex = 15;
            this.rb_Onibus.TabStop = true;
            this.rb_Onibus.Text = "Ônibus";
            this.rb_Onibus.UseVisualStyleBackColor = true;
            this.rb_Onibus.CheckedChanged += new System.EventHandler(this.rb_Onibus_CheckedChanged);
            // 
            // mtb_Placa
            // 
            this.mtb_Placa.Location = new System.Drawing.Point(185, 73);
            this.mtb_Placa.Name = "mtb_Placa";
            this.mtb_Placa.Size = new System.Drawing.Size(89, 22);
            this.mtb_Placa.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtb_Placa);
            this.Controls.Add(this.rb_Onibus);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lvl_Dados);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.tb_assentos_ou_eixos);
            this.Controls.Add(this.lb_Quantidade);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lb_Placa);
            this.Controls.Add(this.rb_Caminhao);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_Caminhao;
        private System.Windows.Forms.Label lb_Placa;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Label lb_Quantidade;
        private System.Windows.Forms.TextBox tb_assentos_ou_eixos;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.ListView lvl_Dados;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.RadioButton rb_Onibus;
        private System.Windows.Forms.MaskedTextBox mtb_Placa;
    }
}

