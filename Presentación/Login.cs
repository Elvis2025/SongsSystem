using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentación
{
    public partial class Login : Form
    {
        //VistaGeneral vistaGeneral;
        public int num = 1;
        public string nombre;
        public int codeUs = 0;
        public Login()
        {
            InitializeComponent();
             
            
        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

       

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightPink;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Size = new Size(36, 36);
        }
       

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Turquoise;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.Size = new Size(31, 31);
        }

        private void claveUsuario_MouseHover(object sender, EventArgs e)
        {
            if (claveUsuario.Text == "1234")
            {
                claveUsuario.Text = "";
            }
        }



        private void nombreUsuario_MouseHover(object sender, EventArgs e)
        {
            if(nombreUsuario.Text == "Nombre")
            {
                nombreUsuario.Text = "";
            }
        }

        private void nombreUsuario_MouseLeave(object sender, EventArgs e)
        {
            if(nombreUsuario.Text == "")
            {
                nombreUsuario.Text = "Nombre";
            }
        }

        private void nombreUsuario_Enter(object sender, EventArgs e)
        {
            if(nombreUsuario.Text == "")
            {
                nombreUsuario.Text = "Nombre";
            }
            else
            {
                nombreUsuario.Text = "";
            }
        }

        private void nombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nombreUsuario.Text == "Nombre")
            {
                nombreUsuario.Text = "";
            }
            
        }

     
        private void claveUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (claveUsuario.Text == "")
            {
                claveUsuario.Text = "1234";
            }
        }

        private void claveUsuario_Enter(object sender, EventArgs e)
        {
            if (claveUsuario.Text == "")
            {
                claveUsuario.Text = "1234";
            }
            else
            {
                claveUsuario.Text = "";
            }
        }

        private void claveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (claveUsuario.Text == "1234")
            {
                claveUsuario.Text = "";
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
          

            if(AllSingers.singers.inicioDeSeccion(nombreUsuario.Text,Convert.ToInt32(claveUsuario.Text)) == true)
            {
                nombre = nombreUsuario.Text;
                
                codeUs = Convert.ToInt32(claveUsuario.Text);               
                num = 0;
               
                this.Close();

            }
            else
            {
                MessageBox.Show("Registo no encontrado","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
          //  vistaGeneral.Close();
        }


        /***********  Botones   ***********************************/
        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.BackColor = Color.LightPink;
            button1.Font = new Font(button1.Font, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Turquoise;
            button1.Font = new Font(button1.Font, FontStyle.Regular);
        }

        

        private void label2_MouseHover(object sender, EventArgs e)
        {
            if(claveUsuario.Text == "1234")
            {
                claveUsuario.Text = "";
            }
            claveUsuario.UseSystemPasswordChar = false;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if(claveUsuario.Text == "")
            {
                claveUsuario.Text = "1234";
            }
            claveUsuario.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
