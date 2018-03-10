namespace PromotoraEventos
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.fancyDecorations = new System.Windows.Forms.CheckBox();
            this.healthyOption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of People";
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.Location = new System.Drawing.Point(70, 64);
            this.numberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(120, 22);
            this.numberOfPeople.TabIndex = 1;
            this.numberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeople.ValueChanged += new System.EventHandler(this.NumberOfPeople_ValueChanged);
            // 
            // fancyDecorations
            // 
            this.fancyDecorations.AutoSize = true;
            this.fancyDecorations.Checked = true;
            this.fancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorations.Location = new System.Drawing.Point(70, 101);
            this.fancyDecorations.Name = "fancyDecorations";
            this.fancyDecorations.Size = new System.Drawing.Size(148, 21);
            this.fancyDecorations.TabIndex = 2;
            this.fancyDecorations.Text = "Fancy Decorations";
            this.fancyDecorations.UseVisualStyleBackColor = true;
            this.fancyDecorations.CheckedChanged += new System.EventHandler(this.fancyDecorations_CheckedChanged);
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Location = new System.Drawing.Point(70, 129);
            this.healthyOption.Name = "healthyOption";
            this.healthyOption.Size = new System.Drawing.Size(124, 21);
            this.healthyOption.TabIndex = 3;
            this.healthyOption.Text = "Healthy Option";
            this.healthyOption.UseVisualStyleBackColor = true;
            this.healthyOption.CheckedChanged += new System.EventHandler(this.healthyOption_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(78, 180);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(140, 17);
            this.labelCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthyOption);
            this.Controls.Add(this.fancyDecorations);
            this.Controls.Add(this.numberOfPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfPeople;
        private System.Windows.Forms.CheckBox fancyDecorations;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCost;
    }
}

