namespace GerenciadorDeComandas.Forms
{
    partial class FrmComandaFechada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComandaFechada));
            this.dgvProdutosComprados = new System.Windows.Forms.DataGridView();
            this.lblNomeComanda = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnEditarComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutosComprados
            // 
            this.dgvProdutosComprados.AllowUserToAddRows = false;
            this.dgvProdutosComprados.AllowUserToDeleteRows = false;
            this.dgvProdutosComprados.AllowUserToResizeRows = false;
            this.dgvProdutosComprados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosComprados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutosComprados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosComprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutosComprados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutosComprados.EnableHeadersVisualStyles = false;
            this.dgvProdutosComprados.Location = new System.Drawing.Point(72, 95);
            this.dgvProdutosComprados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdutosComprados.Name = "dgvProdutosComprados";
            this.dgvProdutosComprados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosComprados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutosComprados.RowHeadersVisible = false;
            this.dgvProdutosComprados.RowHeadersWidth = 100;
            this.dgvProdutosComprados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.dgvProdutosComprados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutosComprados.RowTemplate.Height = 24;
            this.dgvProdutosComprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosComprados.Size = new System.Drawing.Size(977, 630);
            this.dgvProdutosComprados.TabIndex = 8;
            // 
            // lblNomeComanda
            // 
            this.lblNomeComanda.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeComanda.Location = new System.Drawing.Point(219, 11);
            this.lblNomeComanda.Name = "lblNomeComanda";
            this.lblNomeComanda.Size = new System.Drawing.Size(664, 68);
            this.lblNomeComanda.TabIndex = 7;
            this.lblNomeComanda.Text = "Nome da comanda";
            this.lblNomeComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.LightGreen;
            this.btnPagar.Location = new System.Drawing.Point(880, 834);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(181, 71);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total a receber:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(813, 727);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(236, 49);
            this.lblValorTotal.TabIndex = 11;
            this.lblValorTotal.Text = "Valor";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarComanda
            // 
            this.btnEditarComanda.BackColor = System.Drawing.Color.Aqua;
            this.btnEditarComanda.Location = new System.Drawing.Point(13, 837);
            this.btnEditarComanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarComanda.Name = "btnEditarComanda";
            this.btnEditarComanda.Size = new System.Drawing.Size(181, 71);
            this.btnEditarComanda.TabIndex = 12;
            this.btnEditarComanda.Text = "Editar Comanda";
            this.btnEditarComanda.UseVisualStyleBackColor = false;
            this.btnEditarComanda.Click += new System.EventHandler(this.btnEditarComanda_Click);
            // 
            // FrmComandaFechada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 921);
            this.Controls.Add(this.btnEditarComanda);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvProdutosComprados);
            this.Controls.Add(this.lblNomeComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComandaFechada";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comandas Fechadas";
            this.Load += new System.EventHandler(this.FrmComandaFechada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutosComprados;
        private System.Windows.Forms.Label lblNomeComanda;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnEditarComanda;
    }
}