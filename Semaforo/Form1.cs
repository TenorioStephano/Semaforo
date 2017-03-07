using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string SetImg(int i)
        {
            switch(i)
            {
                case 1:
                    EscondeImgs();
                    imgGreen.Visible = true;
                    return "Livre";
                case 2:
                    EscondeImgs();
                    imgYellow.Visible = true;
                    return "Atenção";
                case 3:
                    EscondeImgs();
                    imgRed.Visible = true;
                    return "Pare";
                default:
                    return "Erro";
            }
        }

        public void EscondeImgs()
        {
            imgGreen.Visible = false;
            imgRed.Visible = false;
            imgYellow.Visible = false;
        }

        private bool inicio;
        private int i = 1;

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.
            Timer1.Interval = 2000;
            Timer1.Enabled = true;
            // Hook up timer's tick event handler.
            this.Timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender,System.EventArgs e)
        {
            if(inicio == false)
            {
                Timer1.Enabled = false;
            }
            else
            {
                lblEstado.Text = SetImg(i);
                i++;
                if(i > 3)
                    i = 1;
            }
        }

        private void btnComecar_Click(object sender,EventArgs e)
        {
            InitializeTimer();
            inicio = true;
        }

        private void btnParar_Click_1(object sender,EventArgs e)
        {
            Timer1.Enabled = false;
            //inicio = false;
            //InitializeTimer();
        }
    }
}
