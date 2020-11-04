using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinosario_chrome_mamalon
{
    public partial class Form1 : Form
    {
        int CambioApariencia;
        int PosicionInicialPisoY;
        int PosicionInicialpisoX;
        int velocidad = 5;

        bool BrincoDelDino;
        bool InicioJuego = true;

        Random RnTipoObstaculo;
        List<PictureBox> ListaObstaculos;

        public Form1()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            CambioApariencia = 0;
            BrincoDelDino = false;
            lblpuntuacion.Text = "0";
            RnTipoObstaculo = new Random();
            ListaObstaculos = new List<PictureBox>();

            CrearObstaculo(ListaObstaculos, this);
            PosicionInicialpisoX = 12;
            PosicionInicialPisoY = 197;

        }
        public void CrearObstaculo(List<PictureBox> ListaObstaculos, Form panelJuegoUno)
        {
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);
            PictureBox pb = new PictureBox();
            int PosicionObstaculo = (TipoObstaculo == 1) ? 190 : 201; ;
            pb.Image = Image.FromFile(Application.StartupPath + ((@"\ImgDino\Shrek.jpg")));  
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            ListaObstaculos.Add(pb);
            panelJuegoUno.Controls.Add(pb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!BrincoDelDino)
            {
                //Animacion del dino
                // Dino.Image=(CambioApariencia==0)? Properties
            }
            DetectorChoque.Location = Dino.Location;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //El dino Brinco
            if (BrincoDelDino)
            {
                int Brinco = Dino.Location.Y - 10;
                Dino.Location = new Point(Dino.Location.X, Brinco);
                if (Brinco <= 10)
                {
                    BrincoDelDino = false;
                }
            }
            else
            {
                if (Dino.Location.Y < PosicionInicialPisoY)
                {
                    int Brinco = Dino.Location.Y + 10;
                    Dino.Location = new Point(Dino.Location.X, Brinco);

                }
            }
            //animacion de carretera
            DetectorChoque.Location = Dino.Location;
            int Movimiento = Carretera.Location.X - 10;
            Carretera.Location = new Point(Movimiento, Carretera.Location.Y);
            //cuando se acabe reinicia
            if (Carretera.Location.X < -200)
            {
                Carretera.Location = new Point(PosicionInicialpisoX, PosicionInicialPisoY);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //leer obstaculos generados
            for (int i = 0; i < ListaObstaculos.Count; i = i + 1)
            {
                int MovimientoX;
                MovimientoX = ListaObstaculos[i].Location.X;
                MovimientoX = MovimientoX - velocidad;
                ListaObstaculos[i].Location = new Point(MovimientoX, ListaObstaculos[i].Location.Y);

            }
            //hay elementos  en el obstaculo
            if (ListaObstaculos.Count > 0)
            {
                if (ListaObstaculos[(ListaObstaculos.Count) - 1].Location.X < -300)
                {
                    CrearObstaculo(ListaObstaculos, this);
                }
            }
            if (ListaObstaculos.Count > 0)
            {
                for (int i = 0; i < ListaObstaculos.Count; i = i + 1)
                {
                    if (ListaObstaculos[i].Location.X < Dino.Location.Y)//si el obstaculo ya paso
                    {
                        lblpuntuacion.Text = Convert.ToString(Convert.ToInt32(lblpuntuacion.Text) + 1);
                    }
                    this.Controls.Remove(ListaObstaculos[i]);
                    ListaObstaculos.Remove(ListaObstaculos[i]);

                    //si hay choques con los obstaculos
                    if (ListaObstaculos[i].Bounds.IntersectsWith(DetectorChoque.Bounds))
                    {
                        timer1.Stop(); timer2.Stop(); timer3.Stop(); BtnReset.Visible = true; lblGameover.Visible = true;
                        this.Controls.Remove(ListaObstaculos[i]);
                        ListaObstaculos.Remove(ListaObstaculos[i]);
                    }

                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Space)) && (BrincoDelDino == false))
                //si ya tocaste el espacio
            {
                if (InicioJuego)
                {
                    IniciarJuego();
                    InicioJuego = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                }
                if (Dino.Location.Y>=PosicionInicialPisoY)
                {
                    BrincoDelDino = true;
                }
            }
        }
    }
}

