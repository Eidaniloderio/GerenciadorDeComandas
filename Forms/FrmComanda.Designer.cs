namespace GerenciadorDeComandas
{
    partial class FrmComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComanda));
            this.lblNomeComanda = new System.Windows.Forms.Label();
            this.btnFecharComanda = new System.Windows.Forms.Button();
            this.btnSalvarComanda = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.btnDecrementar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeComanda
            // 
            this.lblNomeComanda.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeComanda.Location = new System.Drawing.Point(202, 3);
            this.lblNomeComanda.Name = "lblNomeComanda";
            this.lblNomeComanda.Size = new System.Drawing.Size(664, 68);
            this.lblNomeComanda.TabIndex = 0;
            this.lblNomeComanda.Text = "Nome da comanda";
            this.lblNomeComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeComanda.Click += new System.EventHandler(this.lblNomeComanda_Click);
            // 
            // btnFecharComanda
            // 
            this.btnFecharComanda.BackColor = System.Drawing.Color.LightCoral;
            this.btnFecharComanda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharComanda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFecharComanda.Location = new System.Drawing.Point(15, 843);
            this.btnFecharComanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFecharComanda.Name = "btnFecharComanda";
            this.btnFecharComanda.Size = new System.Drawing.Size(221, 64);
            this.btnFecharComanda.TabIndex = 3;
            this.btnFecharComanda.Text = "Fechar Comanda";
            this.btnFecharComanda.UseVisualStyleBackColor = false;
            this.btnFecharComanda.Click += new System.EventHandler(this.btnFecharComanda_Click);
            // 
            // btnSalvarComanda
            // 
            this.btnSalvarComanda.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvarComanda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarComanda.Location = new System.Drawing.Point(701, 823);
            this.btnSalvarComanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarComanda.Name = "btnSalvarComanda";
            this.btnSalvarComanda.Size = new System.Drawing.Size(165, 58);
            this.btnSalvarComanda.TabIndex = 4;
            this.btnSalvarComanda.Text = "Salvar";
            this.btnSalvarComanda.UseVisualStyleBackColor = false;
            this.btnSalvarComanda.Click += new System.EventHandler(this.btnSalvarComanda_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Location = new System.Drawing.Point(203, 115);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 100;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(664, 702);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementar.Location = new System.Drawing.Point(975, 777);
            this.btnIncrementar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(93, 39);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "+";
            this.btnIncrementar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // btnDecrementar
            // 
            this.btnDecrementar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementar.Location = new System.Drawing.Point(873, 780);
            this.btnDecrementar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrementar.Name = "btnDecrementar";
            this.btnDecrementar.Size = new System.Drawing.Size(96, 37);
            this.btnDecrementar.TabIndex = 6;
            this.btnDecrementar.Text = "-";
            this.btnDecrementar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecrementar.UseVisualStyleBackColor = true;
            this.btnDecrementar.Click += new System.EventHandler(this.btnDecrementar_Click);
            // 
            // FrmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 921);
            this.Controls.Add(this.btnDecrementar);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.btnSalvarComanda);
            this.Controls.Add(this.btnFecharComanda);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblNomeComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComanda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comanda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComanda_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeComanda;
        private System.Windows.Forms.Button btnFecharComanda;
        private System.Windows.Forms.Button btnSalvarComanda;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Button btnDecrementar;
    }
}