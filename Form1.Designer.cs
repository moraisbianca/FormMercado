namespace ProjetoLoja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoja = new System.Windows.Forms.DataGridView();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_revenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupboxAlteracao = new System.Windows.Forms.GroupBox();
            this.txtboxDescricao = new System.Windows.Forms.TextBox();
            this.txtboxRevenda = new System.Windows.Forms.TextBox();
            this.txtboxEstoque = new System.Windows.Forms.TextBox();
            this.txtboxCompra = new System.Windows.Forms.TextBox();
            this.txtboxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).BeginInit();
            this.groupboxAlteracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoja
            // 
            this.dgvLoja.AllowUserToAddRows = false;
            this.dgvLoja.AllowUserToDeleteRows = false;
            this.dgvLoja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok,
            this.ID,
            this.EAN,
            this.produto,
            this.preco_compra,
            this.preco_revenda,
            this.estoque});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoja.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLoja.Location = new System.Drawing.Point(42, 94);
            this.dgvLoja.Name = "dgvLoja";
            this.dgvLoja.ReadOnly = true;
            this.dgvLoja.Size = new System.Drawing.Size(717, 257);
            this.dgvLoja.TabIndex = 0;
            this.dgvLoja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoja_CellClick);
            // 
            // ok
            // 
            this.ok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ok.HeaderText = "";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            this.ok.Width = 50;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // EAN
            // 
            this.EAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EAN.DefaultCellStyle = dataGridViewCellStyle9;
            this.EAN.HeaderText = "Cód. Barras";
            this.EAN.Name = "EAN";
            this.EAN.ReadOnly = true;
            this.EAN.Width = 150;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.produto.DefaultCellStyle = dataGridViewCellStyle10;
            this.produto.HeaderText = "Descrição";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 130;
            // 
            // preco_compra
            // 
            this.preco_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.preco_compra.DefaultCellStyle = dataGridViewCellStyle11;
            this.preco_compra.HeaderText = "Compra";
            this.preco_compra.Name = "preco_compra";
            this.preco_compra.ReadOnly = true;
            // 
            // preco_revenda
            // 
            this.preco_revenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.preco_revenda.DefaultCellStyle = dataGridViewCellStyle12;
            this.preco_revenda.HeaderText = "Revenda";
            this.preco_revenda.Name = "preco_revenda";
            this.preco_revenda.ReadOnly = true;
            // 
            // estoque
            // 
            this.estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estoque.DefaultCellStyle = dataGridViewCellStyle13;
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            this.estoque.Width = 93;
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMarcar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Location = new System.Drawing.Point(499, 28);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(127, 42);
            this.btnMarcar.TabIndex = 2;
            this.btnMarcar.Text = "Marcar todos";
            this.btnMarcar.UseVisualStyleBackColor = false;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(42, 28);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(127, 42);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar arquivo";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDesmarcar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.Location = new System.Drawing.Point(632, 28);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(127, 42);
            this.btnDesmarcar.TabIndex = 3;
            this.btnDesmarcar.Text = "Desmarcar todos";
            this.btnDesmarcar.UseVisualStyleBackColor = false;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(616, 545);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(143, 51);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar Aplicação";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAumentar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(616, 373);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(143, 52);
            this.btnAumentar.TabIndex = 4;
            this.btnAumentar.Text = "Aumentar preço de revenda";
            this.btnAumentar.UseVisualStyleBackColor = false;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(616, 431);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(143, 52);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // groupboxAlteracao
            // 
            this.groupboxAlteracao.Controls.Add(this.txtboxDescricao);
            this.groupboxAlteracao.Controls.Add(this.txtboxRevenda);
            this.groupboxAlteracao.Controls.Add(this.txtboxEstoque);
            this.groupboxAlteracao.Controls.Add(this.txtboxCompra);
            this.groupboxAlteracao.Controls.Add(this.txtboxCodigo);
            this.groupboxAlteracao.Controls.Add(this.label1);
            this.groupboxAlteracao.Controls.Add(this.label5);
            this.groupboxAlteracao.Controls.Add(this.label2);
            this.groupboxAlteracao.Controls.Add(this.label4);
            this.groupboxAlteracao.Controls.Add(this.label3);
            this.groupboxAlteracao.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxAlteracao.Location = new System.Drawing.Point(42, 357);
            this.groupboxAlteracao.Name = "groupboxAlteracao";
            this.groupboxAlteracao.Size = new System.Drawing.Size(559, 239);
            this.groupboxAlteracao.TabIndex = 12;
            this.groupboxAlteracao.TabStop = false;
            // 
            // txtboxDescricao
            // 
            this.txtboxDescricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDescricao.Location = new System.Drawing.Point(140, 84);
            this.txtboxDescricao.Name = "txtboxDescricao";
            this.txtboxDescricao.Size = new System.Drawing.Size(369, 23);
            this.txtboxDescricao.TabIndex = 9;
            // 
            // txtboxRevenda
            // 
            this.txtboxRevenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRevenda.Location = new System.Drawing.Point(140, 154);
            this.txtboxRevenda.Name = "txtboxRevenda";
            this.txtboxRevenda.Size = new System.Drawing.Size(369, 23);
            this.txtboxRevenda.TabIndex = 11;
            // 
            // txtboxEstoque
            // 
            this.txtboxEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEstoque.Location = new System.Drawing.Point(140, 187);
            this.txtboxEstoque.Name = "txtboxEstoque";
            this.txtboxEstoque.Size = new System.Drawing.Size(369, 23);
            this.txtboxEstoque.TabIndex = 12;
            // 
            // txtboxCompra
            // 
            this.txtboxCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCompra.Location = new System.Drawing.Point(140, 118);
            this.txtboxCompra.Name = "txtboxCompra";
            this.txtboxCompra.Size = new System.Drawing.Size(369, 23);
            this.txtboxCompra.TabIndex = 10;
            // 
            // txtboxCodigo
            // 
            this.txtboxCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigo.Location = new System.Drawing.Point(140, 48);
            this.txtboxCodigo.Name = "txtboxCodigo";
            this.txtboxCodigo.Size = new System.Drawing.Size(369, 23);
            this.txtboxCodigo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cód. Barras:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Revenda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Compra:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(616, 489);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 51);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupboxAlteracao);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.dgvLoja);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).EndInit();
            this.groupboxAlteracao.ResumeLayout(false);
            this.groupboxAlteracao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoja;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupboxAlteracao;
        private System.Windows.Forms.TextBox txtboxDescricao;
        private System.Windows.Forms.TextBox txtboxRevenda;
        private System.Windows.Forms.TextBox txtboxEstoque;
        private System.Windows.Forms.TextBox txtboxCompra;
        private System.Windows.Forms.TextBox txtboxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_revenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}

