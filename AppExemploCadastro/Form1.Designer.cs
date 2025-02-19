namespace AppExemploCadastro
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
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultaLista = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(791, 42);
            this.label5.TabIndex = 22;
            this.label5.Text = "GESTÃO DE PESSOAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConsultaLista
            // 
            this.btConsultaLista.Image = global::AppExemploCadastro.Properties.Resources.CONSULTA2;
            this.btConsultaLista.Location = new System.Drawing.Point(529, 267);
            this.btConsultaLista.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultaLista.Name = "btConsultaLista";
            this.btConsultaLista.Size = new System.Drawing.Size(156, 112);
            this.btConsultaLista.TabIndex = 26;
            this.btConsultaLista.UseVisualStyleBackColor = true;
            this.btConsultaLista.Click += new System.EventHandler(this.btConsultaLista_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Image = global::AppExemploCadastro.Properties.Resources.CONSULTA;
            this.btConsulta.Location = new System.Drawing.Point(118, 267);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(156, 112);
            this.btConsulta.TabIndex = 25;
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btLista
            // 
            this.btLista.Image = global::AppExemploCadastro.Properties.Resources.LISTA2;
            this.btLista.Location = new System.Drawing.Point(327, 267);
            this.btLista.Margin = new System.Windows.Forms.Padding(4);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(156, 112);
            this.btLista.TabIndex = 24;
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Location = new System.Drawing.Point(118, 115);
            this.btCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(156, 112);
            this.btCadastro.TabIndex = 23;
            this.btCadastro.Text = "CADASTRAR PESSOA";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(327, 115);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(156, 112);
            this.btAtualizar.TabIndex = 27;
            this.btAtualizar.Text = "ATUALIZAR PESSOA";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(529, 115);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(156, 112);
            this.btExcluir.TabIndex = 27;
            this.btExcluir.Text = "EXCLUIR PESSOA";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 436);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btConsultaLista);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SISTEMA DE CADASTRO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btConsultaLista;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
    }
}

