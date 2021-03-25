namespace AppNutricao
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastro = new System.Windows.Forms.ToolStripButton();
            this.tsbIMC = new System.Windows.Forms.ToolStripButton();
            this.tsbmetabolismo = new System.Windows.Forms.ToolStripButton();
            this.tsbpesoideal = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastro,
            this.tsbIMC,
            this.tsbmetabolismo,
            this.tsbpesoideal,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(69, 857);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadastro
            // 
            this.tsbCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastro.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastro.Image")));
            this.tsbCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastro.Name = "tsbCadastro";
            this.tsbCadastro.Size = new System.Drawing.Size(66, 68);
            this.tsbCadastro.Text = "Cadastrar";
            this.tsbCadastro.Click += new System.EventHandler(this.tsbCadastro_Click);
            // 
            // tsbIMC
            // 
            this.tsbIMC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIMC.Image = ((System.Drawing.Image)(resources.GetObject("tsbIMC.Image")));
            this.tsbIMC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIMC.Name = "tsbIMC";
            this.tsbIMC.Size = new System.Drawing.Size(66, 68);
            this.tsbIMC.Text = "Cálculadora de IMC";
            this.tsbIMC.Click += new System.EventHandler(this.tsbIMC_Click);
            // 
            // tsbmetabolismo
            // 
            this.tsbmetabolismo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbmetabolismo.Image = ((System.Drawing.Image)(resources.GetObject("tsbmetabolismo.Image")));
            this.tsbmetabolismo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmetabolismo.Name = "tsbmetabolismo";
            this.tsbmetabolismo.Size = new System.Drawing.Size(66, 68);
            this.tsbmetabolismo.Text = "Cálculadora de metabolismo basal";
            this.tsbmetabolismo.Click += new System.EventHandler(this.tsbmetabolismo_Click);
            // 
            // tsbpesoideal
            // 
            this.tsbpesoideal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbpesoideal.Image = ((System.Drawing.Image)(resources.GetObject("tsbpesoideal.Image")));
            this.tsbpesoideal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbpesoideal.Name = "tsbpesoideal";
            this.tsbpesoideal.Size = new System.Drawing.Size(66, 68);
            this.tsbpesoideal.Text = "Cálculadora de peso ideal";
            this.tsbpesoideal.Click += new System.EventHandler(this.tsbpesoideal_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(66, 68);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1218, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nutree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1179, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ajuda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1501, 857);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadastro;
        private System.Windows.Forms.ToolStripButton tsbIMC;
        private System.Windows.Forms.ToolStripButton tsbmetabolismo;
        private System.Windows.Forms.ToolStripButton tsbpesoideal;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

