namespace Rafael
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.labelDor = new System.Windows.Forms.Label();
            this.labelCaputra = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.dataSet1 = new System.Data.DataSet();
            this.lvVoos = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Captura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distancia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Custo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDor = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.mtxtData);
            this.panel2.Controls.Add(this.txtDor);
            this.panel2.Controls.Add(this.txtDistancia);
            this.panel2.Controls.Add(this.txtCusto);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.rbSim);
            this.panel2.Controls.Add(this.rbNao);
            this.panel2.Controls.Add(this.labelDor);
            this.panel2.Controls.Add(this.labelCaputra);
            this.panel2.Controls.Add(this.labelDistancia);
            this.panel2.Controls.Add(this.labelCusto);
            this.panel2.Controls.Add(this.labelData);
            this.panel2.Location = new System.Drawing.Point(416, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 256);
            this.panel2.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(8, 163);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 12;
            this.labelId.Visible = false;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(56, 13);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(303, 20);
            this.mtxtData.TabIndex = 3;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(56, 65);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(303, 20);
            this.txtDistancia.TabIndex = 5;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(56, 39);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(303, 20);
            this.txtCusto.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(102, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(183, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(212, 94);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 7;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(56, 94);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 6;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Nao";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // labelDor
            // 
            this.labelDor.AutoSize = true;
            this.labelDor.Location = new System.Drawing.Point(8, 122);
            this.labelDor.Name = "labelDor";
            this.labelDor.Size = new System.Drawing.Size(49, 13);
            this.labelDor.TabIndex = 4;
            this.labelDor.Text = "Nivel dor";
            // 
            // labelCaputra
            // 
            this.labelCaputra.AutoSize = true;
            this.labelCaputra.Location = new System.Drawing.Point(8, 96);
            this.labelCaputra.Name = "labelCaputra";
            this.labelCaputra.Size = new System.Drawing.Size(44, 13);
            this.labelCaputra.TabIndex = 3;
            this.labelCaputra.Text = "Captura";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(8, 66);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(51, 13);
            this.labelDistancia.TabIndex = 2;
            this.labelDistancia.Text = "Distancia";
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(8, 39);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(34, 13);
            this.labelCusto.TabIndex = 1;
            this.labelCusto.Text = "Custo";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(8, 13);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(84, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnIncluir);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Location = new System.Drawing.Point(416, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 35);
            this.panel3.TabIndex = 2;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(3, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // lvVoos
            // 
            this.lvVoos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Captura,
            this.Dor,
            this.ID,
            this.Distancia,
            this.Custo});
            this.lvVoos.FullRowSelect = true;
            this.lvVoos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvVoos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvVoos.Location = new System.Drawing.Point(12, 8);
            this.lvVoos.Name = "lvVoos";
            this.lvVoos.Size = new System.Drawing.Size(397, 299);
            this.lvVoos.TabIndex = 3;
            this.lvVoos.UseCompatibleStateImageBehavior = false;
            this.lvVoos.View = System.Windows.Forms.View.Details;
            this.lvVoos.SelectedIndexChanged += new System.EventHandler(this.lvVoos_SelectedIndexChanged);
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 120;
            // 
            // Captura
            // 
            this.Captura.Text = "Captura";
            // 
            // Dor
            // 
            this.Dor.Text = "Nivel de dor";
            this.Dor.Width = 300;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Distancia
            // 
            this.Distancia.Text = "Distancia";
            this.Distancia.Width = 0;
            // 
            // Custo
            // 
            this.Custo.Text = "Custo";
            this.Custo.Width = 0;
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(56, 122);
            this.txtDor.MaxLength = 10;
            this.txtDor.Name = "txtDor";
            this.txtDor.Size = new System.Drawing.Size(303, 20);
            this.txtDor.TabIndex = 8;
            this.txtDor.TextChanged += new System.EventHandler(this.txtDor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.lvVoos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDor;
        private System.Windows.Forms.Label labelCaputra;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListView lvVoos;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Captura;
        private System.Windows.Forms.ColumnHeader Dor;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Distancia;
        private System.Windows.Forms.ColumnHeader Custo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtDor;
    }
}

