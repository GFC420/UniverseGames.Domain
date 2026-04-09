namespace UniverseGames.UI
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
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            label1 = new Label();
            txtCategoria = new TextBox();
            txtProdutora = new TextBox();
            dgvTabela = new DataGridView();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnListar = new Button();
            btnBuscar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rdr;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1074, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(327, 132);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(120, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(448, 41);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 2;
            label1.Text = "Universe Games";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(502, 132);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(120, 23);
            txtCategoria.TabIndex = 1;
            // 
            // txtProdutora
            // 
            txtProdutora.Location = new Point(675, 132);
            txtProdutora.Name = "txtProdutora";
            txtProdutora.PlaceholderText = "Produtora";
            txtProdutora.Size = new Size(120, 23);
            txtProdutora.TabIndex = 1;
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(27, 290);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.Size = new Size(1049, 212);
            dgvTabela.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Tomato;
            btnCadastrar.Location = new Point(250, 199);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Tomato;
            btnAtualizar.Location = new Point(392, 199);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Tomato;
            btnListar.Location = new Point(523, 199);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Tomato;
            btnBuscar.Location = new Point(655, 199);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Tomato;
            btnRemover.Location = new Point(795, 199);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 527);
            Controls.Add(btnRemover);
            Controls.Add(btnBuscar);
            Controls.Add(btnListar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvTabela);
            Controls.Add(label1);
            Controls.Add(txtProdutora);
            Controls.Add(txtCategoria);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCategoria;
        private TextBox txtProdutora;
        private DataGridView dgvTabela;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnListar;
        private Button btnBuscar;
        private Button btnRemover;
    }
}
