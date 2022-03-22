namespace WinForms_KT
{
    partial class Form1
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.lbl_vaga = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_dtabertura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_incluir1 = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_requisitos = new System.Windows.Forms.Label();
            this.btn_incluir2 = new System.Windows.Forms.Button();
            this.btn_incluir3 = new System.Windows.Forms.Button();
            this.lbl_Desejaveis = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dtabertura = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.cbx_homeoffice = new System.Windows.Forms.CheckBox();
            this.cbx_cltflex = new System.Windows.Forms.CheckBox();
            this.cbx_cooperativa = new System.Windows.Forms.CheckBox();
            this.cbx_pj = new System.Windows.Forms.CheckBox();
            this.cbx_clt = new System.Windows.Forms.CheckBox();
            this.cbx_cidade = new System.Windows.Forms.ComboBox();
            this.cbx_pais = new System.Windows.Forms.ComboBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.column_requisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_excluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_desejavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_excluir2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_excluir3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_excluir4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(106, 8);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            this.lbl_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_data,
            this.column_titulo,
            this.column_local,
            this.column_excluir3,
            this.column_editar,
            this.column_excluir4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1487, 427);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_requisito,
            this.column_excluir});
            this.dataGridView2.Location = new System.Drawing.Point(93, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(408, 86);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_desejavel,
            this.column_excluir2});
            this.dataGridView3.Location = new System.Drawing.Point(678, 229);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(403, 86);
            this.dataGridView3.TabIndex = 3;
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Location = new System.Drawing.Point(56, 45);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(80, 25);
            this.lbl_empresa.TabIndex = 4;
            this.lbl_empresa.Text = "Empresa";
            // 
            // lbl_vaga
            // 
            this.lbl_vaga.AutoSize = true;
            this.lbl_vaga.Location = new System.Drawing.Point(12, 84);
            this.lbl_vaga.Name = "lbl_vaga";
            this.lbl_vaga.Size = new System.Drawing.Size(124, 25);
            this.lbl_vaga.TabIndex = 5;
            this.lbl_vaga.Text = "Titulo da vaga";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(93, 123);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(42, 25);
            this.lbl_pais.TabIndex = 6;
            this.lbl_pais.Text = "Pais";
            // 
            // lbl_dtabertura
            // 
            this.lbl_dtabertura.AutoSize = true;
            this.lbl_dtabertura.Location = new System.Drawing.Point(320, 9);
            this.lbl_dtabertura.Name = "lbl_dtabertura";
            this.lbl_dtabertura.Size = new System.Drawing.Size(123, 25);
            this.lbl_dtabertura.TabIndex = 12;
            this.lbl_dtabertura.Text = "Data Abertura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Codigo";
            // 
            // btn_incluir1
            // 
            this.btn_incluir1.Location = new System.Drawing.Point(1107, 12);
            this.btn_incluir1.Name = "btn_incluir1";
            this.btn_incluir1.Size = new System.Drawing.Size(112, 34);
            this.btn_incluir1.TabIndex = 14;
            this.btn_incluir1.Text = "Incluir";
            this.btn_incluir1.UseVisualStyleBackColor = true;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(645, 48);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 25);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Email";
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Location = new System.Drawing.Point(286, 120);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(33, 25);
            this.lbl_uf.TabIndex = 16;
            this.lbl_uf.Text = "UF";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(413, 123);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(67, 25);
            this.lbl_cidade.TabIndex = 17;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_requisitos
            // 
            this.lbl_requisitos.AutoSize = true;
            this.lbl_requisitos.Location = new System.Drawing.Point(-6, 201);
            this.lbl_requisitos.Name = "lbl_requisitos";
            this.lbl_requisitos.Size = new System.Drawing.Size(93, 25);
            this.lbl_requisitos.TabIndex = 18;
            this.lbl_requisitos.Text = "Requisitos";
            // 
            // btn_incluir2
            // 
            this.btn_incluir2.Location = new System.Drawing.Point(389, 188);
            this.btn_incluir2.Name = "btn_incluir2";
            this.btn_incluir2.Size = new System.Drawing.Size(112, 36);
            this.btn_incluir2.TabIndex = 19;
            this.btn_incluir2.Text = "Incluir";
            this.btn_incluir2.UseVisualStyleBackColor = true;
            // 
            // btn_incluir3
            // 
            this.btn_incluir3.Location = new System.Drawing.Point(999, 188);
            this.btn_incluir3.Name = "btn_incluir3";
            this.btn_incluir3.Size = new System.Drawing.Size(82, 34);
            this.btn_incluir3.TabIndex = 20;
            this.btn_incluir3.Text = "Incluir";
            this.btn_incluir3.UseVisualStyleBackColor = true;
            // 
            // lbl_Desejaveis
            // 
            this.lbl_Desejaveis.AutoSize = true;
            this.lbl_Desejaveis.Location = new System.Drawing.Point(578, 197);
            this.lbl_Desejaveis.Name = "lbl_Desejaveis";
            this.lbl_Desejaveis.Size = new System.Drawing.Size(94, 25);
            this.lbl_Desejaveis.TabIndex = 21;
            this.lbl_Desejaveis.Text = "Desejaveis";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(142, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(150, 31);
            this.txt_id.TabIndex = 22;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_dtabertura
            // 
            this.txt_dtabertura.Location = new System.Drawing.Point(445, 8);
            this.txt_dtabertura.Name = "txt_dtabertura";
            this.txt_dtabertura.Size = new System.Drawing.Size(150, 31);
            this.txt_dtabertura.TabIndex = 23;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(702, 9);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(379, 31);
            this.txt_codigo.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(702, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 31);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(497, 31);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 81);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(939, 31);
            this.textBox6.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(93, 192);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(290, 31);
            this.textBox10.TabIndex = 31;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(678, 193);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(315, 31);
            this.textBox11.TabIndex = 32;
            // 
            // cbx_homeoffice
            // 
            this.cbx_homeoffice.AutoSize = true;
            this.cbx_homeoffice.Location = new System.Drawing.Point(192, 164);
            this.cbx_homeoffice.Name = "cbx_homeoffice";
            this.cbx_homeoffice.Size = new System.Drawing.Size(134, 29);
            this.cbx_homeoffice.TabIndex = 33;
            this.cbx_homeoffice.Text = "HomeOffice";
            this.cbx_homeoffice.UseVisualStyleBackColor = true;
            // 
            // cbx_cltflex
            // 
            this.cbx_cltflex.AutoSize = true;
            this.cbx_cltflex.Location = new System.Drawing.Point(702, 164);
            this.cbx_cltflex.Name = "cbx_cltflex";
            this.cbx_cltflex.Size = new System.Drawing.Size(100, 29);
            this.cbx_cltflex.TabIndex = 34;
            this.cbx_cltflex.Text = "CLT Flex";
            this.cbx_cltflex.UseVisualStyleBackColor = true;
            // 
            // cbx_cooperativa
            // 
            this.cbx_cooperativa.AutoSize = true;
            this.cbx_cooperativa.Location = new System.Drawing.Point(538, 164);
            this.cbx_cooperativa.Name = "cbx_cooperativa";
            this.cbx_cooperativa.Size = new System.Drawing.Size(134, 29);
            this.cbx_cooperativa.TabIndex = 35;
            this.cbx_cooperativa.Text = "Cooperativa";
            this.cbx_cooperativa.UseVisualStyleBackColor = true;
            // 
            // cbx_pj
            // 
            this.cbx_pj.AutoSize = true;
            this.cbx_pj.Location = new System.Drawing.Point(445, 164);
            this.cbx_pj.Name = "cbx_pj";
            this.cbx_pj.Size = new System.Drawing.Size(53, 29);
            this.cbx_pj.TabIndex = 36;
            this.cbx_pj.Text = "PJ";
            this.cbx_pj.UseVisualStyleBackColor = true;
            // 
            // cbx_clt
            // 
            this.cbx_clt.AutoSize = true;
            this.cbx_clt.Location = new System.Drawing.Point(336, 163);
            this.cbx_clt.Name = "cbx_clt";
            this.cbx_clt.Size = new System.Drawing.Size(65, 29);
            this.cbx_clt.TabIndex = 37;
            this.cbx_clt.Text = "CLT";
            this.cbx_clt.UseVisualStyleBackColor = true;
            // 
            // cbx_cidade
            // 
            this.cbx_cidade.FormattingEnabled = true;
            this.cbx_cidade.Location = new System.Drawing.Point(486, 118);
            this.cbx_cidade.Name = "cbx_cidade";
            this.cbx_cidade.Size = new System.Drawing.Size(595, 33);
            this.cbx_cidade.TabIndex = 38;
            // 
            // cbx_pais
            // 
            this.cbx_pais.FormattingEnabled = true;
            this.cbx_pais.Location = new System.Drawing.Point(142, 120);
            this.cbx_pais.Name = "cbx_pais";
            this.cbx_pais.Size = new System.Drawing.Size(103, 33);
            this.cbx_pais.TabIndex = 39;
            // 
            // cbx_uf
            // 
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Location = new System.Drawing.Point(316, 118);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(55, 33);
            this.cbx_uf.TabIndex = 40;
            // 
            // column_requisito
            // 
            this.column_requisito.HeaderText = "Requisito";
            this.column_requisito.MinimumWidth = 8;
            this.column_requisito.Name = "column_requisito";
            this.column_requisito.Width = 150;
            // 
            // column_excluir
            // 
            this.column_excluir.HeaderText = "Excluir";
            this.column_excluir.MinimumWidth = 8;
            this.column_excluir.Name = "column_excluir";
            this.column_excluir.Width = 150;
            // 
            // column_desejavel
            // 
            this.column_desejavel.HeaderText = "Desejavel";
            this.column_desejavel.MinimumWidth = 8;
            this.column_desejavel.Name = "column_desejavel";
            this.column_desejavel.Width = 150;
            // 
            // column_excluir2
            // 
            this.column_excluir2.HeaderText = "Excluir";
            this.column_excluir2.MinimumWidth = 8;
            this.column_excluir2.Name = "column_excluir2";
            this.column_excluir2.Width = 150;
            // 
            // column_id
            // 
            this.column_id.HeaderText = "ID";
            this.column_id.MinimumWidth = 8;
            this.column_id.Name = "column_id";
            this.column_id.Width = 150;
            // 
            // column_data
            // 
            this.column_data.HeaderText = "Data";
            this.column_data.MinimumWidth = 8;
            this.column_data.Name = "column_data";
            this.column_data.Width = 150;
            // 
            // column_titulo
            // 
            this.column_titulo.HeaderText = "Titulo";
            this.column_titulo.MinimumWidth = 8;
            this.column_titulo.Name = "column_titulo";
            this.column_titulo.Width = 150;
            // 
            // column_local
            // 
            this.column_local.HeaderText = "Local";
            this.column_local.MinimumWidth = 8;
            this.column_local.Name = "column_local";
            this.column_local.Width = 150;
            // 
            // column_excluir3
            // 
            this.column_excluir3.HeaderText = "Excluir";
            this.column_excluir3.MinimumWidth = 8;
            this.column_excluir3.Name = "column_excluir3";
            this.column_excluir3.Width = 150;
            // 
            // column_editar
            // 
            this.column_editar.HeaderText = "Editar";
            this.column_editar.MinimumWidth = 8;
            this.column_editar.Name = "column_editar";
            this.column_editar.Width = 150;
            // 
            // column_excluir4
            // 
            this.column_excluir4.HeaderText = "Excluir";
            this.column_excluir4.MinimumWidth = 8;
            this.column_excluir4.Name = "column_excluir4";
            this.column_excluir4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 732);
            this.Controls.Add(this.cbx_uf);
            this.Controls.Add(this.cbx_pais);
            this.Controls.Add(this.cbx_cidade);
            this.Controls.Add(this.cbx_clt);
            this.Controls.Add(this.cbx_pj);
            this.Controls.Add(this.cbx_cooperativa);
            this.Controls.Add(this.cbx_cltflex);
            this.Controls.Add(this.cbx_homeoffice);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_dtabertura);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_Desejaveis);
            this.Controls.Add(this.btn_incluir3);
            this.Controls.Add(this.btn_incluir2);
            this.Controls.Add(this.lbl_requisitos);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_incluir1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_dtabertura);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_vaga);
            this.Controls.Add(this.lbl_empresa);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_id;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label lbl_empresa;
        private Label lbl_vaga;
        private Label lbl_pais;
        private Label lbl_dtabertura;
        private Label label11;
        private Button btn_incluir1;
        private Label lbl_email;
        private Label lbl_uf;
        private Label lbl_cidade;
        private Label lbl_requisitos;
        private Button btn_incluir2;
        private Button btn_incluir3;
        private Label lbl_Desejaveis;
        private TextBox txt_id;
        private TextBox txt_dtabertura;
        private TextBox txt_codigo;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox10;
        private TextBox textBox11;
        private CheckBox cbx_homeoffice;
        private CheckBox cbx_cltflex;
        private CheckBox cbx_cooperativa;
        private CheckBox cbx_pj;
        private CheckBox cbx_clt;
        private ComboBox cbx_cidade;
        private ComboBox cbx_pais;
        private ComboBox cbx_uf;
        private DataGridViewTextBoxColumn column_id;
        private DataGridViewTextBoxColumn column_data;
        private DataGridViewTextBoxColumn column_titulo;
        private DataGridViewTextBoxColumn column_local;
        private DataGridViewTextBoxColumn column_excluir3;
        private DataGridViewTextBoxColumn column_editar;
        private DataGridViewTextBoxColumn column_excluir4;
        private DataGridViewTextBoxColumn column_requisito;
        private DataGridViewTextBoxColumn column_excluir;
        private DataGridViewTextBoxColumn column_desejavel;
        private DataGridViewTextBoxColumn column_excluir2;
    }
}