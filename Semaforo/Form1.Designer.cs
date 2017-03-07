namespace Semaforo
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgGreen = new System.Windows.Forms.PictureBox();
            this.imgYellow = new System.Windows.Forms.PictureBox();
            this.imgRed = new System.Windows.Forms.PictureBox();
            this.lblSemafaro = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.imgRed2 = new System.Windows.Forms.PictureBox();
            this.imgYellow2 = new System.Windows.Forms.PictureBox();
            this.imgGreen2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreen2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGreen
            // 
            this.imgGreen.Image = ((System.Drawing.Image)(resources.GetObject("imgGreen.Image")));
            this.imgGreen.Location = new System.Drawing.Point(257, 54);
            this.imgGreen.Name = "imgGreen";
            this.imgGreen.Size = new System.Drawing.Size(62, 135);
            this.imgGreen.TabIndex = 0;
            this.imgGreen.TabStop = false;
            this.imgGreen.Visible = false;
            // 
            // imgYellow
            // 
            this.imgYellow.Image = ((System.Drawing.Image)(resources.GetObject("imgYellow.Image")));
            this.imgYellow.Location = new System.Drawing.Point(258, 54);
            this.imgYellow.Name = "imgYellow";
            this.imgYellow.Size = new System.Drawing.Size(61, 135);
            this.imgYellow.TabIndex = 1;
            this.imgYellow.TabStop = false;
            this.imgYellow.Visible = false;
            // 
            // imgRed
            // 
            this.imgRed.Image = ((System.Drawing.Image)(resources.GetObject("imgRed.Image")));
            this.imgRed.Location = new System.Drawing.Point(257, 54);
            this.imgRed.Name = "imgRed";
            this.imgRed.Size = new System.Drawing.Size(72, 135);
            this.imgRed.TabIndex = 2;
            this.imgRed.TabStop = false;
            this.imgRed.Visible = false;
            // 
            // lblSemafaro
            // 
            this.lblSemafaro.AutoSize = true;
            this.lblSemafaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemafaro.Location = new System.Drawing.Point(188, 9);
            this.lblSemafaro.Name = "lblSemafaro";
            this.lblSemafaro.Size = new System.Drawing.Size(187, 42);
            this.lblSemafaro.TabIndex = 3;
            this.lblSemafaro.Text = "Semáforo";
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(335, 432);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 4;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(155, 431);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(98, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 25);
            this.lblEstado.TabIndex = 6;
            // 
            // lblEstado2
            // 
            this.lblEstado2.AutoSize = true;
            this.lblEstado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado2.Location = new System.Drawing.Point(98, 296);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(0, 25);
            this.lblEstado2.TabIndex = 10;
            // 
            // imgRed2
            // 
            this.imgRed2.Image = ((System.Drawing.Image)(resources.GetObject("imgRed2.Image")));
            this.imgRed2.Location = new System.Drawing.Point(258, 247);
            this.imgRed2.Name = "imgRed2";
            this.imgRed2.Size = new System.Drawing.Size(72, 135);
            this.imgRed2.TabIndex = 9;
            this.imgRed2.TabStop = false;
            this.imgRed2.Visible = false;
            // 
            // imgYellow2
            // 
            this.imgYellow2.Image = ((System.Drawing.Image)(resources.GetObject("imgYellow2.Image")));
            this.imgYellow2.Location = new System.Drawing.Point(258, 247);
            this.imgYellow2.Name = "imgYellow2";
            this.imgYellow2.Size = new System.Drawing.Size(61, 135);
            this.imgYellow2.TabIndex = 8;
            this.imgYellow2.TabStop = false;
            this.imgYellow2.Visible = false;
            // 
            // imgGreen2
            // 
            this.imgGreen2.Image = ((System.Drawing.Image)(resources.GetObject("imgGreen2.Image")));
            this.imgGreen2.Location = new System.Drawing.Point(257, 247);
            this.imgGreen2.Name = "imgGreen2";
            this.imgGreen2.Size = new System.Drawing.Size(62, 135);
            this.imgGreen2.TabIndex = 7;
            this.imgGreen2.TabStop = false;
            this.imgGreen2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.lblEstado2);
            this.Controls.Add(this.imgRed2);
            this.Controls.Add(this.imgYellow2);
            this.Controls.Add(this.imgGreen2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.lblSemafaro);
            this.Controls.Add(this.imgRed);
            this.Controls.Add(this.imgYellow);
            this.Controls.Add(this.imgGreen);
            this.Name = "Form1";
            this.Text = "Semáforo";
            ((System.ComponentModel.ISupportInitialize)(this.imgGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGreen;
        private System.Windows.Forms.PictureBox imgYellow;
        private System.Windows.Forms.PictureBox imgRed;
        private System.Windows.Forms.Label lblSemafaro;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.PictureBox imgRed2;
        private System.Windows.Forms.PictureBox imgYellow2;
        private System.Windows.Forms.PictureBox imgGreen2;
    }
}

