namespace WindowsFormsApp1
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
            this.btnContadorSemThread = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numContador = new System.Windows.Forms.NumericUpDown();
            this.btnContadorComThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numContador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContadorSemThread
            // 
            this.btnContadorSemThread.Location = new System.Drawing.Point(24, 53);
            this.btnContadorSemThread.Name = "btnContadorSemThread";
            this.btnContadorSemThread.Size = new System.Drawing.Size(194, 23);
            this.btnContadorSemThread.TabIndex = 0;
            this.btnContadorSemThread.Text = "Iniciar contagem (SEM TRHEAD)";
            this.btnContadorSemThread.UseVisualStyleBackColor = true;
            this.btnContadorSemThread.Click += new System.EventHandler(this.btnContadorSemThread_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(24, 82);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(764, 356);
            this.log.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contador inicial: ";
            // 
            // numContador
            // 
            this.numContador.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numContador.Location = new System.Drawing.Point(120, 15);
            this.numContador.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numContador.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numContador.Name = "numContador";
            this.numContador.Size = new System.Drawing.Size(120, 20);
            this.numContador.TabIndex = 5;
            this.numContador.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnContadorComThread
            // 
            this.btnContadorComThread.Location = new System.Drawing.Point(248, 53);
            this.btnContadorComThread.Name = "btnContadorComThread";
            this.btnContadorComThread.Size = new System.Drawing.Size(272, 23);
            this.btnContadorComThread.TabIndex = 6;
            this.btnContadorComThread.Text = "Iniciar contagem (COM TRHEAD SIMPLES)";
            this.btnContadorComThread.UseVisualStyleBackColor = true;
            this.btnContadorComThread.Click += new System.EventHandler(this.btnContadorComThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContadorComThread);
            this.Controls.Add(this.numContador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btnContadorSemThread);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numContador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContadorSemThread;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numContador;
        private System.Windows.Forms.Button btnContadorComThread;
    }
}

