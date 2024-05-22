namespace Calculadora.WinForms
{
    partial class CalculadoraForm
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
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPrimeiroNumero = new TextBox();
            txtSegundoNumero = new TextBox();
            rdbAdicao = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            lblResultado = new Label();
            label4 = new Label();
            listHitoricooperacoes = new ListBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(33, 244);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(350, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Primeiro Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Segundo Número:";
            // 
            // txtPrimeiroNumero
            // 
            txtPrimeiroNumero.Location = new Point(130, 57);
            txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            txtPrimeiroNumero.Size = new Size(190, 23);
            txtPrimeiroNumero.TabIndex = 4;
            // 
            // txtSegundoNumero
            // 
            txtSegundoNumero.Location = new Point(130, 86);
            txtSegundoNumero.Name = "txtSegundoNumero";
            txtSegundoNumero.Size = new Size(190, 23);
            txtSegundoNumero.TabIndex = 5;
            // 
            // rdbAdicao
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Location = new Point(20, 133);
            rdbAdicao.Name = "rdbAdicao";
            rdbAdicao.Size = new Size(65, 19);
            rdbAdicao.TabIndex = 6;
            rdbAdicao.TabStop = true;
            rdbAdicao.Text = "Adição ";
            rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(120, 133);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 7;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(220, 133);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(100, 19);
            rdbMultiplicacao.TabIndex = 8;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação ";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(320, 133);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 9;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(98, 302);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 40);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 312);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 11;
            label4.Text = "Resultado:";
            // 
            // listHitoricooperacoes
            // 
            listHitoricooperacoes.FormattingEnabled = true;
            listHitoricooperacoes.ItemHeight = 15;
            listHitoricooperacoes.Location = new Point(33, 345);
            listHitoricooperacoes.Name = "listHitoricooperacoes";
            listHitoricooperacoes.Size = new Size(350, 139);
            listHitoricooperacoes.TabIndex = 12;
            // 
            // CalculadoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 499);
            Controls.Add(listHitoricooperacoes);
            Controls.Add(label4);
            Controls.Add(lblResultado);
            Controls.Add(rdbDivisao);
            Controls.Add(rdbMultiplicacao);
            Controls.Add(rdbSubtracao);
            Controls.Add(rdbAdicao);
            Controls.Add(txtSegundoNumero);
            Controls.Add(txtPrimeiroNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "CalculadoraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora 2024";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtPrimeiroNumero;
        private TextBox txtSegundoNumero;
        private RadioButton rdbAdicao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbDivisao;
        private Label lblResultado;
        private Label label4;
        private ListBox listHitoricooperacoes;
    }
}
