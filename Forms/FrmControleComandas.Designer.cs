namespace GerenciadorDeComandas
{
    partial class FrmControleComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleComandas));
            this.tabControlComandas = new System.Windows.Forms.TabControl();
            this.tabComandasAbertas = new System.Windows.Forms.TabPage();
            this.btnDecrementarPag = new System.Windows.Forms.Button();
            this.btnIncrementarPag = new System.Windows.Forms.Button();
            this.panelComandasAbertas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblComandasAberdas = new System.Windows.Forms.Label();
            this.tabNovaComanda = new System.Windows.Forms.TabPage();
            this.btnAbrirComanda = new System.Windows.Forms.Button();
            this.mtxtDataHoje = new System.Windows.Forms.MaskedTextBox();
            this.lblDataComanda = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeComanda = new System.Windows.Forms.Label();
            this.lblNovaComanda = new System.Windows.Forms.Label();
            this.tabComandaFechadas = new System.Windows.Forms.TabPage();
            this.dtpDatasComandas = new System.Windows.Forms.DateTimePicker();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelComandasFechadas = new System.Windows.Forms.FlowLayoutPanel();
            this.TabComandasFechadas = new System.Windows.Forms.Label();
            this.lblComandas = new System.Windows.Forms.Label();
            this.tabControlComandas.SuspendLayout();
            this.tabComandasAbertas.SuspendLayout();
            this.tabNovaComanda.SuspendLayout();
            this.tabComandaFechadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlComandas
            // 
            this.tabControlComandas.Controls.Add(this.tabComandasAbertas);
            this.tabControlComandas.Controls.Add(this.tabNovaComanda);
            this.tabControlComandas.Controls.Add(this.tabComandaFechadas);
            this.tabControlComandas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlComandas.Location = new System.Drawing.Point(12, 68);
            this.tabControlComandas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlComandas.Multiline = true;
            this.tabControlComandas.Name = "tabControlComandas";
            this.tabControlComandas.SelectedIndex = 0;
            this.tabControlComandas.Size = new System.Drawing.Size(1880, 995);
            this.tabControlComandas.TabIndex = 2;
            this.tabControlComandas.SelectedIndexChanged += new System.EventHandler(this.tabControlComandas_SelectedIndexChanged);
            // 
            // tabComandasAbertas
            // 
            this.tabComandasAbertas.Controls.Add(this.btnDecrementarPag);
            this.tabComandasAbertas.Controls.Add(this.btnIncrementarPag);
            this.tabComandasAbertas.Controls.Add(this.panelComandasAbertas);
            this.tabComandasAbertas.Controls.Add(this.lblComandasAberdas);
            this.tabComandasAbertas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabComandasAbertas.Location = new System.Drawing.Point(4, 46);
            this.tabComandasAbertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComandasAbertas.Name = "tabComandasAbertas";
            this.tabComandasAbertas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComandasAbertas.Size = new System.Drawing.Size(1872, 945);
            this.tabComandasAbertas.TabIndex = 0;
            this.tabComandasAbertas.Text = " Abertas";
            this.tabComandasAbertas.UseVisualStyleBackColor = true;
            // 
            // btnDecrementarPag
            // 
            this.btnDecrementarPag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementarPag.Location = new System.Drawing.Point(761, 834);
            this.btnDecrementarPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrementarPag.Name = "btnDecrementarPag";
            this.btnDecrementarPag.Size = new System.Drawing.Size(198, 40);
            this.btnDecrementarPag.TabIndex = 18;
            this.btnDecrementarPag.Text = "Pagina Anterior";
            this.btnDecrementarPag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecrementarPag.UseVisualStyleBackColor = true;
            this.btnDecrementarPag.Click += new System.EventHandler(this.btnDecrementarPag_Click);
            // 
            // btnIncrementarPag
            // 
            this.btnIncrementarPag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementarPag.Location = new System.Drawing.Point(983, 834);
            this.btnIncrementarPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncrementarPag.Name = "btnIncrementarPag";
            this.btnIncrementarPag.Size = new System.Drawing.Size(213, 40);
            this.btnIncrementarPag.TabIndex = 17;
            this.btnIncrementarPag.Text = "Próxima Pagina";
            this.btnIncrementarPag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncrementarPag.UseVisualStyleBackColor = true;
            this.btnIncrementarPag.Click += new System.EventHandler(this.btnIncrementarPag_Click);
            // 
            // panelComandasAbertas
            // 
            this.panelComandasAbertas.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelComandasAbertas.Location = new System.Drawing.Point(15, 122);
            this.panelComandasAbertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelComandasAbertas.Name = "panelComandasAbertas";
            this.panelComandasAbertas.Size = new System.Drawing.Size(1835, 698);
            this.panelComandasAbertas.TabIndex = 3;
            // 
            // lblComandasAberdas
            // 
            this.lblComandasAberdas.AutoSize = true;
            this.lblComandasAberdas.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandasAberdas.Location = new System.Drawing.Point(803, 27);
            this.lblComandasAberdas.Name = "lblComandasAberdas";
            this.lblComandasAberdas.Size = new System.Drawing.Size(197, 65);
            this.lblComandasAberdas.TabIndex = 2;
            this.lblComandasAberdas.Text = "Abertas";
            // 
            // tabNovaComanda
            // 
            this.tabNovaComanda.Controls.Add(this.btnAbrirComanda);
            this.tabNovaComanda.Controls.Add(this.mtxtDataHoje);
            this.tabNovaComanda.Controls.Add(this.lblDataComanda);
            this.tabNovaComanda.Controls.Add(this.txtNomeCliente);
            this.tabNovaComanda.Controls.Add(this.lblNomeComanda);
            this.tabNovaComanda.Controls.Add(this.lblNovaComanda);
            this.tabNovaComanda.Location = new System.Drawing.Point(4, 46);
            this.tabNovaComanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNovaComanda.Name = "tabNovaComanda";
            this.tabNovaComanda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNovaComanda.Size = new System.Drawing.Size(1872, 911);
            this.tabNovaComanda.TabIndex = 1;
            this.tabNovaComanda.Text = "Nova";
            this.tabNovaComanda.UseVisualStyleBackColor = true;
            // 
            // btnAbrirComanda
            // 
            this.btnAbrirComanda.BackColor = System.Drawing.Color.LightGreen;
            this.btnAbrirComanda.Location = new System.Drawing.Point(781, 577);
            this.btnAbrirComanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirComanda.Name = "btnAbrirComanda";
            this.btnAbrirComanda.Size = new System.Drawing.Size(331, 89);
            this.btnAbrirComanda.TabIndex = 8;
            this.btnAbrirComanda.Text = "Abrir comanda";
            this.btnAbrirComanda.UseVisualStyleBackColor = false;
            this.btnAbrirComanda.Click += new System.EventHandler(this.btnAbrirComanda_Click);
            // 
            // mtxtDataHoje
            // 
            this.mtxtDataHoje.Location = new System.Drawing.Point(1349, 247);
            this.mtxtDataHoje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtDataHoje.Mask = "00/00/0000";
            this.mtxtDataHoje.Name = "mtxtDataHoje";
            this.mtxtDataHoje.Size = new System.Drawing.Size(304, 43);
            this.mtxtDataHoje.TabIndex = 7;
            this.mtxtDataHoje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDataHoje.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataComanda
            // 
            this.lblDataComanda.AutoSize = true;
            this.lblDataComanda.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataComanda.Location = new System.Drawing.Point(1185, 225);
            this.lblDataComanda.Name = "lblDataComanda";
            this.lblDataComanda.Size = new System.Drawing.Size(141, 65);
            this.lblDataComanda.TabIndex = 6;
            this.lblDataComanda.Text = "Data:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(336, 244);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(760, 43);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // lblNomeComanda
            // 
            this.lblNomeComanda.AutoSize = true;
            this.lblNomeComanda.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeComanda.Location = new System.Drawing.Point(123, 225);
            this.lblNomeComanda.Name = "lblNomeComanda";
            this.lblNomeComanda.Size = new System.Drawing.Size(188, 65);
            this.lblNomeComanda.TabIndex = 4;
            this.lblNomeComanda.Text = "Nome: ";
            // 
            // lblNovaComanda
            // 
            this.lblNovaComanda.AutoSize = true;
            this.lblNovaComanda.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaComanda.Location = new System.Drawing.Point(853, 34);
            this.lblNovaComanda.Name = "lblNovaComanda";
            this.lblNovaComanda.Size = new System.Drawing.Size(147, 65);
            this.lblNovaComanda.TabIndex = 3;
            this.lblNovaComanda.Text = "Novo";
            // 
            // tabComandaFechadas
            // 
            this.tabComandaFechadas.Controls.Add(this.dtpDatasComandas);
            this.tabComandaFechadas.Controls.Add(this.lblValorFinal);
            this.tabComandaFechadas.Controls.Add(this.label1);
            this.tabComandaFechadas.Controls.Add(this.panelComandasFechadas);
            this.tabComandaFechadas.Controls.Add(this.TabComandasFechadas);
            this.tabComandaFechadas.Location = new System.Drawing.Point(4, 46);
            this.tabComandaFechadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComandaFechadas.Name = "tabComandaFechadas";
            this.tabComandaFechadas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComandaFechadas.Size = new System.Drawing.Size(1872, 911);
            this.tabComandaFechadas.TabIndex = 2;
            this.tabComandaFechadas.Text = "Fechadas";
            this.tabComandaFechadas.UseVisualStyleBackColor = true;
            // 
            // dtpDatasComandas
            // 
            this.dtpDatasComandas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatasComandas.Location = new System.Drawing.Point(1618, 76);
            this.dtpDatasComandas.Name = "dtpDatasComandas";
            this.dtpDatasComandas.Size = new System.Drawing.Size(234, 43);
            this.dtpDatasComandas.TabIndex = 14;
            this.dtpDatasComandas.ValueChanged += new System.EventHandler(this.dtpDatasComandas_ValueChanged);
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(319, 75);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(236, 49);
            this.lblValorFinal.TabIndex = 13;
            this.lblValorFinal.Text = "Valor";
            this.lblValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total recebido:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelComandasFechadas
            // 
            this.panelComandasFechadas.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelComandasFechadas.Location = new System.Drawing.Point(17, 138);
            this.panelComandasFechadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelComandasFechadas.Name = "panelComandasFechadas";
            this.panelComandasFechadas.Size = new System.Drawing.Size(1835, 718);
            this.panelComandasFechadas.TabIndex = 5;
            // 
            // TabComandasFechadas
            // 
            this.TabComandasFechadas.AutoSize = true;
            this.TabComandasFechadas.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabComandasFechadas.Location = new System.Drawing.Point(827, 2);
            this.TabComandasFechadas.Name = "TabComandasFechadas";
            this.TabComandasFechadas.Size = new System.Drawing.Size(193, 65);
            this.TabComandasFechadas.TabIndex = 4;
            this.TabComandasFechadas.Text = "Antigas";
            // 
            // lblComandas
            // 
            this.lblComandas.AutoSize = true;
            this.lblComandas.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandas.Location = new System.Drawing.Point(812, 1);
            this.lblComandas.Name = "lblComandas";
            this.lblComandas.Size = new System.Drawing.Size(258, 65);
            this.lblComandas.TabIndex = 3;
            this.lblComandas.Text = "Comandas";
            // 
            // FrmControleComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1061);
            this.Controls.Add(this.tabControlComandas);
            this.Controls.Add(this.lblComandas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmControleComandas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de comanda";
            this.tabControlComandas.ResumeLayout(false);
            this.tabComandasAbertas.ResumeLayout(false);
            this.tabComandasAbertas.PerformLayout();
            this.tabNovaComanda.ResumeLayout(false);
            this.tabNovaComanda.PerformLayout();
            this.tabComandaFechadas.ResumeLayout(false);
            this.tabComandaFechadas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlComandas;
        private System.Windows.Forms.TabPage tabNovaComanda;
        private System.Windows.Forms.Label lblComandasAberdas;
        private System.Windows.Forms.Label lblComandas;
        private System.Windows.Forms.Label lblNovaComanda;
        private System.Windows.Forms.MaskedTextBox mtxtDataHoje;
        private System.Windows.Forms.Label lblDataComanda;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeComanda;
        private System.Windows.Forms.Button btnAbrirComanda;
        private System.Windows.Forms.TabPage tabComandaFechadas;
        private System.Windows.Forms.Label TabComandasFechadas;
        private System.Windows.Forms.TabPage tabComandasAbertas;
        private System.Windows.Forms.FlowLayoutPanel panelComandasAbertas;
        private System.Windows.Forms.FlowLayoutPanel panelComandasFechadas;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatasComandas;
        private System.Windows.Forms.Button btnDecrementarPag;
        private System.Windows.Forms.Button btnIncrementarPag;
    }
}