namespace _211065
{
    partial class Biblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.lblquant = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_qnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_livro = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.lstCarrinho = new System.Windows.Forms.ListView();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.preco = new System.Windows.Forms.ColumnHeader();
            this.quantidade = new System.Windows.Forms.ColumnHeader();
            this.total = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(583, 97);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(144, 43);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar ao carrinho";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Location = new System.Drawing.Point(95, 100);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(78, 15);
            this.lblquant.TabIndex = 1;
            this.lblquant.Text = " Quantidade :";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(179, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(548, 23);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_qnt
            // 
            this.txt_qnt.Location = new System.Drawing.Point(179, 97);
            this.txt_qnt.Name = "txt_qnt";
            this.txt_qnt.Size = new System.Drawing.Size(100, 23);
            this.txt_qnt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // lbl_livro
            // 
            this.lbl_livro.AutoSize = true;
            this.lbl_livro.Location = new System.Drawing.Point(81, 50);
            this.lbl_livro.Name = "lbl_livro";
            this.lbl_livro.Size = new System.Drawing.Size(92, 15);
            this.lbl_livro.TabIndex = 9;
            this.lbl_livro.Text = "Nome do Livro :";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(352, 100);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(43, 15);
            this.lblpreco.TabIndex = 10;
            this.lblpreco.Text = "Preço :";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(462, 37);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(147, 37);
            this.btn_finalizar.TabIndex = 5;
            this.btn_finalizar.Text = "Finalizar Compras";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(629, 37);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(147, 37);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Cancelar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(403, 495);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(147, 37);
            this.btn_novo.TabIndex = 4;
            this.btn_novo.Text = "Adicionar mais livros";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.lblquant);
            this.groupBox2.Controls.Add(this.lbl_livro);
            this.groupBox2.Controls.Add(this.txt_qnt);
            this.groupBox2.Controls.Add(this.lblpreco);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(71, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 170);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(401, 97);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 23);
            this.txt_valor.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Location = new System.Drawing.Point(71, 563);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total da Compra :";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_total.Location = new System.Drawing.Point(95, 42);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(92, 30);
            this.txt_total.TabIndex = 0;
            this.txt_total.Text = "R$ 00,00";
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.quantidade,
            this.preco,
            this.total});
            this.lstCarrinho.Location = new System.Drawing.Point(248, 225);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(457, 242);
            this.lstCarrinho.TabIndex = 15;
            this.lstCarrinho.UseCompatibleStateImageBehavior = false;
            this.lstCarrinho.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Nome do Livro:";
            // 
            // preco
            // 
            this.preco.DisplayIndex = 1;
            this.preco.Text = "Preço Unit:";
            // 
            // quantidade
            // 
            this.quantidade.DisplayIndex = 2;
            this.quantidade.Text = "Qntd:";
            // 
            // total
            // 
            this.total.Text = "Total:";
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.lstCarrinho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label3);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add;
        private Label lblquant;
        private TextBox txt_nome;
        private TextBox txt_qnt;
        private Label label3;
        private Label lbl_livro;
        private Label lblpreco;
        private Button btn_finalizar;
        private Button btn_fechar;
        private Button btn_novo;
        private GroupBox groupBox2;
        private TextBox txt_valor;
        private GroupBox groupBox1;
        private Label txt_total;
        private ListView lstCarrinho;
        private ColumnHeader nome;
        private ColumnHeader preco;
        private ColumnHeader quantidade;
        private ColumnHeader total;
    }
}