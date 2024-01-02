using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentación
{
    public partial class VistaGeneral : Form
    {
        public VistaGeneral()
        {
            /**/
            InitializeComponent();
            //MessageBox.Show("");
            /* texituraList();
             singerList();
             scaleList();*/
            vistaP();
            componentesVisibles();
            labNombreUsuario.Visible = false;
            //componentesIniciarSeccion();
            //controlesDeOpciones();

        }
        DataTable dt = new DataTable();
        Login login = new Login();
        int claveUs;
        public void controlesDeOpciones()
        {
            lineaVertical.Visible = true;
            opciones.Visible = true;
            btnHome.Visible = true;
            labTituloCanciones.Visible = true;
            controlOpciones.Visible = true;
            labTiulo.Visible = false;
            controlOpciones.Visible = true;

            controlOpciones.Location = new Point(25, 273);

            btnIniciarSeccion.Location = new Point(25, 7);

            this.Size = new Size(1122, 659);
            this.StartPosition = FormStartPosition.WindowsDefaultBounds;
            btnCerrar.Location = new Point(1079, 11);

            //labTiulo.Location = new Point(355, 40);

            btnHome.Location = new Point(231, 140);


            txtBuscar.Location = new Point(291, 150);
            txtBuscar.Size = new Size(312, 22);

            labTituloCanciones.Location = new Point(225, 226);

            btnBuscar.Location = new Point(595, 145);

            labEscalaMusical.Location = new Point(636, 152);//

            btnBuscarEscala.Location = new Point(754, 145);//

            listaEscala.Location = new Point(754, 185);//

            labBuscarUsuario.Location = new Point(804, 152);//

            btnBuscarUsuario.Location = new Point(871, 145);//

            listaUsuario.Location = new Point(871, 185);//

            labBuscarTexitura.Location = new Point(917, 152);//

            btnBuscarTexitura.Location = new Point(984, 145);//

            listaTexitura.Location = new Point(984, 185);//

            lineaHorizontal.Location = new Point(231, 185);
            lineaHorizontal.Size = new Size(852, 2);

            vistaGeneralCanciones.Location = new Point(231, 273);

        }
        public void componentesIniciarSeccion()
        {
            //int code = AllSingers.singers.idCantante(c);


            labTodasLasPropuestas.Visible = false;
            lineaVertical.Visible = true;
            opciones.Visible = true;
            btnHome.Visible = true;
            labTituloCanciones.Visible = true;
            controlOpciones.Visible = false;
            //btnIniciarSeccion.Visible = true;

            /*  controlOpciones.Location = new Point(25, 273);*/

            labTituloCanciones.Location = new Point(77, 226);

            btnIniciarSeccion.Location = new Point(25, 7);
            btnIniciarSeccion.Size = new Size(167, 35);

            btnCerrar.Location = new Point(912, 11);


            labTiulo.Location = new Point(355, 40);

            btnHome.Location = new Point(77, 143);


            txtBuscar.Location = new Point(137, 150);
            txtBuscar.Size = new Size(312, 22);

            btnBuscar.Location = new Point(441, 145);

            labEscalaMusical.Location = new Point(482, 152);

            btnBuscarEscala.Location = new Point(600, 145);

            listaEscala.Location = new Point(600, 185);

            labBuscarUsuario.Location = new Point(650, 152);

            btnBuscarUsuario.Location = new Point(717, 145);

            listaUsuario.Location = new Point(717, 185);

            labBuscarTexitura.Location = new Point(763, 152);

            btnBuscarTexitura.Location = new Point(830, 145);

            listaTexitura.Location = new Point(830, 185);

            lineaHorizontal.Location = new Point(77, 185);
            lineaHorizontal.Size = new Size(852, 2);

            vistaGeneralCanciones.Location = new Point(77, 273);

            this.Size = new Size(955, 659);
            this.StartPosition = FormStartPosition.WindowsDefaultBounds;

        }
        public void componentesVisibles()
        {
            dt.Clear();
            vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
            labTodasLasPropuestas.Visible = false;
            controlOpciones.Visible = false;
            labNombreUsuario.Visible = false;
            lineaVertical.Visible = false;
            opciones.Visible = false;
            btnHome.Visible = false;
            labTituloCanciones.Visible = false;
            //btnIniciarSeccion.Visible = true;

            btnIniciarSeccion.Location = new Point(25, 7);
            btnIniciarSeccion.Size = new Size(167, 35);

            btnCerrar.Location = new Point(856, 7);

            labTiulo.Location = new Point(355, 40);

            txtBuscar.Location = new Point(42, 144);
            txtBuscar.Size = new Size(251, 22);

            btnBuscar.Location = new Point(285, 139);

            labEscalaMusical.Location = new Point(332, 146);

            btnBuscarEscala.Location = new Point(451, 139);

            listaEscala.Location = new Point(451, 177);

            labBuscarUsuario.Location = new Point(502, 146);

            btnBuscarUsuario.Location = new Point(569, 139);

            listaUsuario.Location = new Point(569, 177);

            labBuscarTexitura.Location = new Point(643, 144);

            btnBuscarTexitura.Location = new Point(710, 137);

            listaTexitura.Location = new Point(710, 177);

            lineaHorizontal.Location = new Point(25, 177);
            lineaHorizontal.Size = new Size(852, 2);

            vistaGeneralCanciones.Location = new Point(25, 206);

            this.Size = new Size(899, 592);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }
        public void singerList()
        {
            List<string> listS = new List<string>();
            listS.Add("None");
            listaUsuario.DataSource = AllSingers.singers.allSingers(listS);

        }
        public void scaleList()
        {

            List<string> listS = new List<string>();
            //listS.Clear();
            listS.Add("None");

            listaEscala.DataSource = AllSingers.singers.todasLasEscalas(listS);
        }
        public void texituraList()
        {
            List<string> listS = new List<string>();
            listS.Add("None");
            listaTexitura.DataSource = AllSingers.singers.todasTexituras(listS);
        }

        private void vistaP()
        {
            dt.Clear();
            vistaGeneralCanciones.DataSource = null;
            vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);

        }



        /**************** Boton para cerrar App **********************************************/

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.LightPink;
            btnCerrar.BorderStyle = BorderStyle.Fixed3D;
            btnCerrar.Size = new Size(36, 36);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Turquoise;
            btnCerrar.BorderStyle = BorderStyle.None;
            btnCerrar.Size = new Size(31, 31);
        }
        /****************************************************************************/





        /******* Buscar Escala y la lista de Escalas  *********************************************/
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            scaleList();
            listaEscala.Visible = !listaEscala.Visible;

            if (listaEscala.Visible == true)
            {

                btnBuscarEscala.BorderStyle = BorderStyle.Fixed3D;
                btnBuscarEscala.BackColor = Color.LightPink;
            }
            if (listaEscala.Visible == false)
            {
                btnBuscarEscala.BorderStyle = BorderStyle.None;
                btnBuscarEscala.BackColor = Color.Turquoise;
            }

        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            btnBuscarEscala.BackColor = Color.LightPink;
            btnBuscarEscala.BorderStyle = BorderStyle.Fixed3D;
            btnBuscarEscala.Size = new Size(36, 36);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {


            if (listaEscala.Visible == true)
            {
                btnBuscarEscala.BackColor = Color.LightPink;
                btnBuscarEscala.BorderStyle = BorderStyle.Fixed3D;
                btnBuscarEscala.Size = new Size(36, 36);
            }
            if (listaEscala.Visible == false)
            {
                btnBuscarEscala.BackColor = Color.Turquoise;
                btnBuscarEscala.BorderStyle = BorderStyle.None;
                btnBuscarEscala.Size = new Size(31, 31);
            }


        }
        private void listBox2_MouseHover(object sender, EventArgs e)
        {

        }
        private void listBox2_MouseLeave(object sender, EventArgs e)
        {
            listaEscala.Visible = false;
            btnBuscarEscala.BackColor = Color.Turquoise;
            btnBuscarEscala.BorderStyle = BorderStyle.None;
            btnBuscarEscala.Size = new Size(31, 31);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listaEscala.SelectedItem.ToString();
            if (labTodasLasPropuestas.Visible == false)
            {
                if (selectedItem != "None")
                {
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPorEscala(dt, selectedItem);
                    listaEscala.Visible = false;
                    btnBuscarEscala.BorderStyle = BorderStyle.None;

                }
                else
                {
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
                    listaEscala.Visible = false;
                    btnBuscarEscala.BorderStyle = BorderStyle.None;
                }
            }
            else
            {

                if (labTodasLasPropuestas.Visible == true)
                {
                    if (selectedItem != "None")
                    {
                        vistaGeneralCanciones.DataSource = null;
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPropuestaPorEscala(dt, selectedItem);
                        listaEscala.Visible = false;
                        btnBuscarEscala.BorderStyle = BorderStyle.None;
                        btnBuscarEscala.BackColor = Color.Turquoise;
                    }
                    else
                    {
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        listaEscala.Visible = false;
                        btnBuscarEscala.BorderStyle = BorderStyle.None;
                        btnBuscarEscala.BackColor = Color.Turquoise;
                    }
                }
            }
        }
        /********************************************************************************/



        /***** Boton para buscar usuarios y la lista de Usuarios **************************************************/
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            singerList();
            listaUsuario.Visible = !listaUsuario.Visible;
            if (listaUsuario.Visible == true)
            {
                btnBuscarUsuario.BorderStyle = BorderStyle.Fixed3D;
                btnBuscarUsuario.BackColor = Color.LightPink;
            }
            if (listaUsuario.Visible == false)
            {
                btnBuscarUsuario.BorderStyle = BorderStyle.None;
                btnBuscarUsuario.BackColor = Color.Turquoise;
            }

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            btnBuscarUsuario.BackColor = Color.LightPink;
            btnBuscarUsuario.BorderStyle = BorderStyle.Fixed3D;
            btnBuscarUsuario.Size = new Size(36, 36);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (listaUsuario.Visible == false)
            {
                btnBuscarUsuario.BackColor = Color.Turquoise;
                btnBuscarUsuario.BorderStyle = BorderStyle.None;
                btnBuscarUsuario.Size = new Size(31, 31);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listaUsuario.SelectedItem.ToString();

            if (labTodasLasPropuestas.Visible == false)
            {

                if (selectedItem != "None")
                {
                    vistaGeneralCanciones.DataSource = null;
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.buscarNombre(dt, selectedItem);
                    listaUsuario.Visible = false;
                    btnBuscarUsuario.BorderStyle = BorderStyle.None;
                    btnBuscarUsuario.BackColor = Color.Turquoise;
                }
                else
                {
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
                    listaUsuario.Visible = false;
                    btnBuscarUsuario.BorderStyle = BorderStyle.None;
                    btnBuscarUsuario.BackColor = Color.Turquoise;
                }
            }
            else
            {

                if (labTodasLasPropuestas.Visible == true)
                {
                    if (selectedItem != "None")
                    {
                        vistaGeneralCanciones.DataSource = null;
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPropuestaPorNombre(dt, selectedItem);
                        listaUsuario.Visible = false;
                        btnBuscarUsuario.BorderStyle = BorderStyle.None;
                        btnBuscarUsuario.BackColor = Color.Turquoise;
                    }
                    else
                    {
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        listaUsuario.Visible = false;
                        btnBuscarUsuario.BorderStyle = BorderStyle.None;
                        btnBuscarUsuario.BackColor = Color.Turquoise;
                    }
                }
            }
        }
        /********************************************************************************/






        /**** Boton buscar ****************************************************************/
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            btnBuscar.BorderStyle = BorderStyle.Fixed3D;
            btnBuscar.BackColor = Color.LightPink;

            timerBtn.Start();
            dt.Clear();
            if (labTodasLasPropuestas.Visible == false)
            {

                vistaGeneralCanciones.DataSource = AllSingers.singers.buscar(dt, txtBuscar.Text);

            }
            else
            {
                vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPropuesta(dt, txtBuscar.Text);
            }


        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.LightPink;
            btnBuscar.BorderStyle = BorderStyle.Fixed3D;
            btnBuscar.Size = new Size(36, 36);
            btnBuscar.Cursor = Cursors.Hand;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.Turquoise;
            btnBuscar.BorderStyle = BorderStyle.None;
            btnBuscar.Size = new Size(31, 31);
        }
        /****************************************************************************/






        /*** boton buscar por Texitura y la lita de Texitura *************************************************/

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            texituraList();
            listaTexitura.Visible = !listaTexitura.Visible;

            if (listaTexitura.Visible == true)
            {
                btnBuscarTexitura.BorderStyle = BorderStyle.Fixed3D;
                btnBuscarTexitura.BackColor = Color.LightPink;
            }
            if (listaTexitura.Visible == false)
            {
                btnBuscarTexitura.BorderStyle = BorderStyle.None;
                btnBuscarTexitura.BackColor = Color.Turquoise;
            }


        }


        //buscar por la lista de texituras
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listaTexitura.SelectedItem.ToString();
            if (labTodasLasPropuestas.Visible == false)
            {

                if (selectedItem != "None")
                {
                    vistaGeneralCanciones.DataSource = null;
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPorTexitura(dt, selectedItem);
                    listaTexitura.Visible = false;
                    btnBuscarTexitura.BorderStyle = BorderStyle.None;
                    btnBuscarTexitura.BackColor = Color.Turquoise;
                }
                else
                {
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);
                    listaTexitura.Visible = false;
                    btnBuscarTexitura.BorderStyle = BorderStyle.None;
                    btnBuscarTexitura.BackColor = Color.Turquoise;
                }
            }
            else
            {

                if (labTodasLasPropuestas.Visible == true)
                {
                    if (selectedItem != "None")
                    {
                        vistaGeneralCanciones.DataSource = null;
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.buscarPropuestaPorTexitura(dt, selectedItem);
                        listaTexitura.Visible = false;
                        btnBuscarTexitura.BorderStyle = BorderStyle.None;
                        btnBuscarTexitura.BackColor = Color.Turquoise;
                    }
                    else
                    {
                        dt.Clear();
                        vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                        listaTexitura.Visible = false;
                        btnBuscarTexitura.BorderStyle = BorderStyle.None;
                        btnBuscarTexitura.BackColor = Color.Turquoise;
                    }
                }
            }

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            btnBuscarTexitura.BackColor = Color.LightPink;
            btnBuscarTexitura.BorderStyle = BorderStyle.Fixed3D;
            btnBuscarTexitura.Size = new Size(36, 36);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (listaTexitura.Visible == false)
            {
                btnBuscarUsuario.BackColor = Color.Turquoise;
                btnBuscarUsuario.BorderStyle = BorderStyle.None;
                btnBuscarUsuario.Size = new Size(31, 31);
            }
        }
        /********************************************************************************/



        /*** metodos para ocultar las listas y cambiar de estado los botones*/
        private void busqueUsuario()
        {
            listaUsuario.Visible = false;
            btnBuscarUsuario.BackColor = Color.Turquoise;
            btnBuscarUsuario.BorderStyle = BorderStyle.None;
            btnBuscarUsuario.Size = new Size(31, 31);
        }

        private void busqueEscala()
        {
            listaEscala.Visible = false;
            btnBuscarEscala.BackColor = Color.Turquoise;
            btnBuscarEscala.BorderStyle = BorderStyle.None;
            btnBuscarEscala.Size = new Size(31, 31);
        }
        private void busqueTexitura()
        {
            listaTexitura.Visible = false;
            btnBuscarTexitura.BackColor = Color.Turquoise;
            btnBuscarTexitura.BorderStyle = BorderStyle.None;
            btnBuscarTexitura.Size = new Size(31, 31);
        }

        private void VistaGeneral_MouseHover(object sender, EventArgs e)
        {
            busqueUsuario();
            busqueEscala();
            busqueTexitura();
        }
        /*******************************************************************/




        /**** Boton Iniciar seccion y label ****************************************/


        private void labIniciarSeccion_MouseHover(object sender, EventArgs e)
        {
            btnIniciarSeccion.BorderStyle = BorderStyle.Fixed3D;
            btnIniciarSeccion.BackColor = Color.LightPink;

            //btnIniciarSeccion.Size = new Size(180, 36);

            btnIniciarSeccion.Font = new Font(btnIniciarSeccion.Font, FontStyle.Bold);
        }

        private void labIniciarSeccion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSeccion.BorderStyle = BorderStyle.None;
            btnIniciarSeccion.BackColor = Color.Turquoise;
            btnIniciarSeccion.BackColor = Color.Turquoise;
            //btnIniciarSeccion.Size = new Size(167, 35);

            btnIniciarSeccion.Font = new Font(btnIniciarSeccion.Font, FontStyle.Regular);
        }
        int c;
        int code;
        private void labIniciarSeccion_Click(object sender, EventArgs e)
        {
            //  labIniciarSeccion.Text = "hola";
            // this.Hide();

            if (labNombreUsuario.Visible != true)
            {
                Login login = new Login();

                login.ShowDialog();
                if (login.num == 0)
                {
                    componentesIniciarSeccion();

                    this.StartPosition = FormStartPosition.CenterScreen;
                    btnIniciarSeccion.Text = "         Cerrar Seccion";
                    labTiulo.Visible = false;
                    labNombreUsuario.Visible = true;
                    labNombreUsuario.Text = login.nombre;
                    c = login.codeUs;
                    code = AllSingers.singers.idCantante(c);
                    if (code == 1 || code == 7)
                    {

                        btnAprobarPropuesta.Enabled = true;
                        btnAgregarUsuario.Enabled = true;
                        btnEliminarUsuario.Enabled = true;
                        btnAprobarPropuesta.Cursor = Cursors.Hand;
                        btnAgregarUsuario.Cursor = Cursors.Hand;
                        btnEliminarUsuario.Cursor = Cursors.Hand;

                    }
                    else
                    {

                        btnAprobarPropuesta.Enabled = false;
                        btnAgregarUsuario.Enabled = false;
                        btnEliminarUsuario.Enabled = false;
                        btnAprobarPropuesta.Cursor = Cursors.No;
                        btnAgregarUsuario.Cursor = Cursors.No;
                        btnEliminarUsuario.Cursor = Cursors.No;
                    }


                    int x = (Width - labNombreUsuario.Width) / 2;
                    labNombreUsuario.Location = new Point(x, 40);

                    /* this.Size = new Size(1500, 592);
                     this.StartPosition = FormStartPosition.WindowsDefaultLocation;*/
                }
            }
            else
            {
                componentesVisibles();
                btnIniciarSeccion.Text = "         Iniciar Seccion";
                labNombreUsuario.Visible = false;
                labTiulo.Visible = true;
            }



        }

        private void VistaGeneral_Load(object sender, EventArgs e)
        {

        }
        /***************************************************************************/




        /*** Diseño Boton de Opciones *************************************/
        private bool opcionesAbiertas = false;
        private void opciones_Click(object sender, EventArgs e)
        {


            if (!opcionesAbiertas)
            {

                this.StartPosition = FormStartPosition.CenterScreen;
                controlesDeOpciones();
                lineaVertical.Visible = false;
                opcionesAbiertas = true;
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                componentesIniciarSeccion();
                labTodasLasPropuestas.Visible = false;
                lineaVertical.Visible = true;
                opcionesAbiertas = false;
            }
            timerBtn.Start();
        }
        private void opciones_MouseHover(object sender, EventArgs e)
        {
            opciones.BorderStyle = BorderStyle.Fixed3D;
            opciones.BackColor = Color.LightPink;
            opciones.Size = new Size(36, 36);
            opciones.Cursor = Cursors.Hand;
        }

        private void opciones_MouseLeave(object sender, EventArgs e)
        {
            opciones.BorderStyle = BorderStyle.None;
            opciones.BackColor = Color.Turquoise;
            opciones.Size = new Size(32, 32);
        }

        /*******************************************************************/




        /********* Bonton de Inicio *******************************************/
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            timerBtn.Start();
            componentesIniciarSeccion();
            // vistaGeneralCanciones.Rows.Clear();
            vistaGeneralCanciones.DataSource = null;
            dt.Clear();
            vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);

        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BorderStyle = BorderStyle.Fixed3D;
            btnHome.BackColor = Color.LightPink;
            btnHome.Size = new Size(40, 40);
            btnHome.Cursor = Cursors.Hand;

        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BorderStyle = BorderStyle.None;
            btnHome.BackColor = Color.Turquoise;
            btnHome.Size = new Size(36, 36);
        }

        private void controlOpciones_Paint(object sender, PaintEventArgs e)
        {

        }
        /*****************************************************************************/









        //**************************Boton Ediar Usuario *********************************//
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            pnEditarUsuario.Visible = true;
            labTituloCanciones.Visible = false;
            labTodasLasPropuestas.Visible = false;

            dt.Clear();
            dt = AllSingers.singers.seleccionarCantantesActivos(dt, code);
            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                // Asigna los valores de la fila a los TextBox correspondientes
                txtNombreEd.Text = fila["Nombre"].ToString();
                txtApellidoEd.Text = fila["Apellido"].ToString();
                txtEdadEd.Text = fila["Edad"].ToString();
                txtTexituraEd.Text = fila["TexituraVocal"].ToString();

                actulizado = false;
                nombre = txtNombreEd.Text;
                apellido = txtApellidoEd.Text;
                texitura = txtTexituraEd.Text;
                claveInicioSeccion = c;
                clave = Convert.ToInt32(txtClaveEd.Text);
                claveNueva = Convert.ToInt32(txtNuevaClaveEd.Text);
                claveNuevaC = Convert.ToInt32(txtNuevaClaveEd2.Text);
                edad = Convert.ToInt32(txtEdadEd.Text);
            }
            else
            {
                // La fila especificada no existe en el DataTable
                MessageBox.Show("El índice de fila especificado no es válido.");
            }

            
        }

        private void btnEditarUsuario_MouseHover(object sender, EventArgs e)
        {
            btnEditarUsuario.BorderStyle = BorderStyle.Fixed3D;
            btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnEditarUsuario.Size = new Size(183, 38);


            btnEditarUsuario.Font = new Font(btnEditarUsuario.Font.FontFamily, 12, FontStyle.Bold);

           
        }

        private void btnEditarUsuario_MouseLeave(object sender, EventArgs e)
        {

            //178; 35
            btnEditarUsuario.Font = new Font(btnEditarUsuario.Font.FontFamily, 11, FontStyle.Regular);
            btnEditarUsuario.BorderStyle = BorderStyle.FixedSingle;
            btnEditarUsuario.BackColor = Color.Turquoise;
            btnEditarUsuario.Size = new Size(178, 35);
        }

        private void btnCerrarEditarUsuario_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEditarUsuario.BackColor = Color.LightPink;
            btnCerrarEditarUsuario.BorderStyle = BorderStyle.Fixed3D;
            btnCerrarEditarUsuario.Size = new Size(36, 36);
        }

        private void btnCerrarEditarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEditarUsuario.BackColor = Color.Turquoise;
            btnCerrarEditarUsuario.BorderStyle = BorderStyle.None;
            btnCerrarEditarUsuario.Size = new Size(31, 31);
        }

        //======================= Panel Para Editar Usuario =============================//

        bool actulizado = false;
        string nombre;
        string apellido;
        string texitura;
        int claveInicioSeccion;
        int clave;
        int claveNueva;
        int claveNuevaC;
        int edad;
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {           

            int id = code;


            nombre = txtNombreEd.Text;
            apellido = txtApellidoEd.Text;
            texitura = txtTexituraEd.Text;
            claveInicioSeccion = c;
            clave = Convert.ToInt32(txtClaveEd.Text);
            claveNueva = Convert.ToInt32(txtNuevaClaveEd.Text);
            claveNuevaC = Convert.ToInt32(txtNuevaClaveEd2.Text);
            edad = Convert.ToInt32(txtEdadEd.Text);


            if (claveNueva != 1234 )
                {
                    if (claveInicioSeccion == Convert.ToInt32(txtClaveEd.Text))
                    {
                    /*MessageBox.Show(claveInicioSeccion+txtClaveEd.Text+edad);
                    //if(claveNueva == 0000 & clave)*/
                    if (claveNueva == 0000 & claveNueva == claveNuevaC)
                        {
                            claveNueva = clave;
                            actulizado = AllSingers.singers.editarUsuario(id, nombre, apellido, claveNueva, texitura, edad);
                        }
                        else
                        {
                            if (claveNueva == claveNuevaC)
                            {
                                actulizado = AllSingers.singers.editarUsuario(id, nombre, apellido, claveNueva, texitura, edad);

                            }
                            else
                            {
                                MessageBox.Show("Las claves no coiciden");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave Incorrecta. ");
                    }
                }
                else
                {
                    MessageBox.Show("Tu nueva clave es 1234, intenta de nuevo. ");
                }
        



            if (actulizado == true)
            {

                MessageBox.Show("Actualizado");
               
                pnEditarUsuario.Visible = false;
                componentesVisibles();

                btnIniciarSeccion.Text = "         Iniciar Seccion";
                btnIniciarSeccion.BorderStyle = BorderStyle.None;
                btnIniciarSeccion.BackColor = Color.Turquoise;
                btnIniciarSeccion.BackColor = Color.Turquoise;
                //btnIniciarSeccion.Size = new Size(167, 35);

                btnIniciarSeccion.Font = new Font(btnIniciarSeccion.Font, FontStyle.Regular);


            }
            else
            {
                MessageBox.Show("No Actualizado");
            }

            
        }
        private void btnCerrarEditarUsuario_Click(object sender, EventArgs e)
        {

            labTituloCanciones.Visible = true;
            pnEditarUsuario.Visible = false;            
            dt.Columns.Clear();
            dt = AllSingers.singers.newe(dt);
            vistaGeneralCanciones.DataSource = dt;
        }

        //++++++++++++++++++++ TextBox para editar ++++++++++++++++++++++++++++++++++++++//

        //-------------------------------------------------------------------------------//
        private void txtNombreEd_MouseHover(object sender, EventArgs e)
        {
            
            //MessageBox.Show(nombre);
            if (txtNombreEd.Text == nombre)
            {
                txtNombreEd.Text = "";
            }
        }

        private void txtNombreEd_MouseLeave(object sender, EventArgs e)
        {
            if (txtNombreEd.Text == "")
            {
                txtNombreEd.Text = nombre;
            }
        }

        private void txtNombreEd_Enter(object sender, EventArgs e)
        {
            if(txtNombreEd.Text == "")
            {
                txtNombreEd.Text = nombre;
            }
           
        }

        private void txtNombreEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombreEd.Text == nombre)
            {
                txtNombreEd.Text = "";
            }
        }
        //------------------------------------------------------------------------------------//





        //------------------------------------------------------------------------------------//
        private void txtTexituraEd_Enter(object sender, EventArgs e)
        {

            if (txtTexituraEd.Text == "")
            {
                txtTexituraEd.Text = texitura;
            }
            
           
        }

        private void txtTexituraEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTexituraEd.Text == texitura)
            {
                txtTexituraEd.Text = "";
            }
        }

        private void txtTexituraEd_MouseLeave(object sender, EventArgs e)
        {
            if (txtTexituraEd.Text == "")
            {
                txtTexituraEd.Text = texitura;
            }

            
        }

        private void txtTexituraEd_MouseHover(object sender, EventArgs e)
        {
            if (txtTexituraEd.Text == texitura)
            {
                txtTexituraEd.Text = "";
            }
        }
        //------------------------------------------------------------------------------------//





        //------------------------------------------------------------------------------------//
        private void txtApellidoEd_Enter(object sender, EventArgs e)
        {
            if (txtApellidoEd.Text == "")
            {
                txtApellidoEd.Text = apellido;
            }
           
        }

        private void txtApellidoEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellidoEd.Text == apellido)
            {
                txtApellidoEd.Text = "";
            }
        }

        private void txtApellidoEd_MouseHover(object sender, EventArgs e)
        {

            if (txtApellidoEd.Text == apellido)
            {
                txtApellidoEd.Text = "";
            }
        }

        private void txtApellidoEd_MouseLeave(object sender, EventArgs e)
        {
            if (txtApellidoEd.Text == "")
            {
                txtApellidoEd.Text = apellido;
            }
        }
        //------------------------------------------------------------------------------------//








        //------------------------------------------------------------------------------------//
        private void txtEdadEd_Enter(object sender, EventArgs e)
        {

            //Enter
            if (txtEdadEd.Text == "")
            {
                txtEdadEd.Text = Convert.ToString(edad);
            }
           
                        
        }

        private void txtEdadEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtEdadEd.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora la entrada si ya hay 4 dígitos
            }          
            

            if (txtEdadEd.Text == Convert.ToString(edad))
            {
                txtEdadEd.Text = "";
            }
        }

        private void txtEdadEd_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover
            if (txtEdadEd.Text == Convert.ToString(edad))
            {
                txtEdadEd.Text = "";
            }
        }

        private void txtEdadEd_MouseLeave(object sender, EventArgs e)
        {
            //Mouse Leave
            if (txtEdadEd.Text == "")
            {
                txtEdadEd.Text = Convert.ToString(edad);
            }
        }
        //------------------------------------------------------------------------------------//








        //------------------------------------------------------------------------------------//
        private void txtClaveEd_Enter(object sender, EventArgs e)
        {
            //Enter
            if (txtClaveEd.Text == "")
            {
                txtClaveEd.Text = "0000";
            }
            if (txtClaveEd.Text == "0000")
            {
                txtClaveEd.Text = "";
            }
            


        }

        private void txtClaveEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtClaveEd.Text.Length >= 4 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora la entrada si ya hay 4 dígitos
            }
            if (txtClaveEd.Text == "0000")
            {
                txtClaveEd.Text = "";
            }
        }

        private void txtClaveEd_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover
            if (txtClaveEd.Text == "0000")
            {
                txtClaveEd.Text = "";
            }
        }

        private void txtClaveEd_MouseLeave(object sender, EventArgs e)
        {
            //Mouse Leave
            if (txtClaveEd.Text == "")
            {
                txtClaveEd.Text = "0000";
            }
        }
        //------------------------------------------------------------------------------------//







        //------------------------------------------------------------------------------------//
        private void txtNuevaClaveEd_Enter(object sender, EventArgs e)
        {
            //Enter
            if (txtNuevaClaveEd.Text == "")
            {
                txtNuevaClaveEd.Text = "0000";
            }
            


            
        }

        private void txtNuevaClaveEd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtNuevaClaveEd.Text.Length >= 4 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora la entrada si ya hay 4 dígitos
            }
            
            if (txtNuevaClaveEd.Text == "0000")
            {
                txtNuevaClaveEd.Text = "";
            }
        }

        private void txtNuevaClaveEd_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover
            if (txtNuevaClaveEd.Text == "0000")
            {
                txtNuevaClaveEd.Text = "";
            }
        }

        private void txtNuevaClaveEd_MouseLeave(object sender, EventArgs e)
        {
            //Mouse Leave
            if (txtNuevaClaveEd.Text == "")
            {
                txtNuevaClaveEd.Text = "0000";
            }
        }
        //------------------------------------------------------------------------------------//









        //------------------------------------------------------------------------------------//
        private void txtNuevaClaveEd2_Enter(object sender, EventArgs e)
        {
            //Enter
            if (txtNuevaClaveEd2.Text == "")
            {
                txtNuevaClaveEd2.Text = "0000";
            }
            


            /*//KeyPress
            if (txtNuevaClaveEd.Text == claveNueva.ToString())
            {
                txtNuevaClaveEd.Text = "";
            }

            //Mouse Hover
            if (txtNuevaClaveEd.Text == claveNueva.ToString())
            {
                txtNuevaClaveEd.Text = "";
            }

            //Mouse Leave
            if (txtNuevaClaveEd.Text == "")
            {
                txtNuevaClaveEd.Text = claveNueva.ToString();
            }*/
        }

        private void txtNuevaClaveEd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress

            //KeyPress
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtNuevaClaveEd2.Text.Length >= 4 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora la entrada si ya hay 4 dígitos
            }

            if (txtNuevaClaveEd2.Text == "0000")
            {
                txtNuevaClaveEd2.Text = "";
            }
        }

        private void txtNuevaClaveEd2_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover
            if (txtNuevaClaveEd2.Text == "0000")
            {
                txtNuevaClaveEd2.Text = "";
            }
        }

        private void txtNuevaClaveEd2_MouseLeave(object sender, EventArgs e)
        {
            //Mouse Leave
            if (txtNuevaClaveEd2.Text == "")
            {
                txtNuevaClaveEd2.Text = "0000";
            }
        }
        //------------------------------------------------------------------------------------//








        //+++++++++ Boton Para Actualizar ++++++++++++++++++++++++++++++++++++++++//
        private void btnActualizarUsuario_MouseHover(object sender, EventArgs e)
        {
            btnActualizarUsuario.BackColor = Color.LightPink;
          //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
           // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 */
            btnActualizarUsuario.Size = new Size(258, 50);

            btnActualizarUsuario.Font = new Font(btnActualizarUsuario.Font.FontFamily, 20, FontStyle.Bold);

            
        }
              
        private void btnActualizarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnActualizarUsuario.BackColor = Color.Turquoise;
            //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
            // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 */
            btnActualizarUsuario.Size = new Size(250, 46);


            btnActualizarUsuario.Font = new Font(btnActualizarUsuario.Font.FontFamily, 16, FontStyle.Bold);
        }
    

        /*-------------------------------------------------------------------------------*/
        private void labVerClave_MouseHover(object sender, EventArgs e)
        {
            if (txtClaveEd.Text == "0000")
            {
                txtClaveEd.Text = "";
               
            }
            txtClaveEd.UseSystemPasswordChar = false;
            
            
           
        }

        private void labVerClave_MouseLeave(object sender, EventArgs e)
        {
            if (txtClaveEd.Text == "")
            {
                txtClaveEd.Text = "0000";
            }
            txtClaveEd.UseSystemPasswordChar = true;
        }
        /*-------------------------------------------------------------------------------*/



        /*-------------------------------------------------------------------------------*/
        private void labVerNuevaClave_MouseHover(object sender, EventArgs e)
        {
            if (txtNuevaClaveEd.Text == "0000")
            {
                txtNuevaClaveEd.Text = "";
            }
            txtNuevaClaveEd.UseSystemPasswordChar = false;
        }

        private void labVerNuevaClave_MouseLeave(object sender, EventArgs e)
        {
            if (txtNuevaClaveEd.Text == "")
            {
                txtNuevaClaveEd.Text = "0000";
            }
            txtNuevaClaveEd.UseSystemPasswordChar = true;
        }
        /*-------------------------------------------------------------------------------*/




        /*-------------------------------------------------------------------------------*/
        private void labVerNuevaClave2_MouseHover(object sender, EventArgs e)
        {
            if (txtNuevaClaveEd2.Text == "0000")
            {
                txtNuevaClaveEd2.Text = "";
            }
            txtNuevaClaveEd2.UseSystemPasswordChar = false;
        }

        private void labVerNuevaClave2_MouseLeave(object sender, EventArgs e)
        {
            if (txtNuevaClaveEd2.Text == "")
            {
                txtNuevaClaveEd2.Text = "0000";
            }
            txtNuevaClaveEd2.UseSystemPasswordChar = true;
        }
        /*-------------------------------------------------------------------------------*/


        //===============================================================================//
        //*******************************************************************************//






        //********************   Timer  **************************************************//
        private void timerBtn_Tick(object sender, EventArgs e)
        {

            btnBuscar.BorderStyle = BorderStyle.None;
            btnBuscar.BackColor = Color.Turquoise;
            btnBuscar.Cursor = Cursors.Arrow;

            btnHome.BorderStyle = BorderStyle.None;
            btnHome.BackColor = Color.Turquoise;
            btnHome.Cursor = Cursors.Arrow;

            opciones.BorderStyle = BorderStyle.None;
            opciones.BackColor = Color.Turquoise;
            opciones.Cursor = Cursors.Arrow;

            timerBtn.Stop();
        }
        //*********************************************************************************//






        //******************************* Boton Ver Propuestas ******************************//

        private void btnVerPropuestas_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
            labTodasLasPropuestas.Visible = true;
            labTituloCanciones.Visible = false;


        }

        private void btnVerPropuestas_MouseHover(object sender, EventArgs e)
        {
            btnVerPropuestas.BorderStyle = BorderStyle.Fixed3D;
            btnVerPropuestas.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnVerPropuestas.Size = new Size(183, 38);


            btnVerPropuestas.Font = new Font(btnVerPropuestas.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnVerPropuestas_MouseLeave(object sender, EventArgs e)
        {
            //178; 35
            btnVerPropuestas.BorderStyle = BorderStyle.FixedSingle;
            btnVerPropuestas.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnVerPropuestas.Size = new Size(178, 35);


            btnVerPropuestas.Font = new Font(btnVerPropuestas.Font.FontFamily, 11, FontStyle.Regular);

        }
        //**********************************************************************************//






        //***************** Boton Agregar Propuesta ***************************************//
        private void btnAgregarPropuestas_Click(object sender, EventArgs e)
        {
            pnAgregarPropuesta.Visible = true;
        }
        private void btnAgregarPropuestas_MouseHover(object sender, EventArgs e)
        {
            //Leave 178; 35   Hover 183,38
            btnAgregarPropuestas.BorderStyle = BorderStyle.Fixed3D;
            btnAgregarPropuestas.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnAgregarPropuestas.Size = new Size(190,38);


            btnAgregarPropuestas.Font = new Font(btnAgregarPropuestas.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnAgregarPropuestas_MouseLeave(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnAgregarPropuestas.BorderStyle = BorderStyle.FixedSingle;
            btnAgregarPropuestas.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnAgregarPropuestas.Size = new Size(178, 35);


            btnAgregarPropuestas.Font = new Font(btnAgregarPropuestas.Font.FontFamily, 11, FontStyle.Regular);
        }



        //====================== Panel para agregar Propuesta =============================//

        private void btnAgregarPropuesta_MouseHover(object sender, EventArgs e)
        {
            btnAgregarPropuesta.BackColor = Color.LightPink;
            //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
            // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 *///141; 38
            btnAgregarPropuesta.Size = new Size(149, 42);

            btnAgregarPropuesta.Font = new Font(btnActualizarUsuario.Font.FontFamily, 20, FontStyle.Bold);
        }

        private void btnAgregarPropuesta_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarPropuesta.BackColor = Color.Turquoise;
            //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
            // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 */
            btnAgregarPropuesta.Size = new Size(141, 38);

            btnAgregarPropuesta.Font = new Font(btnAgregarPropuesta.Font.FontFamily, 16, FontStyle.Regular);
        }
        private void btnAgregarPropuesta_Click(object sender, EventArgs e)
        {
            int code = AllSingers.singers.idCantante(c);

            bool agregado = AllSingers.singers.agregarPropuesta(txtNombrePropuesta.Text, txtEscalaPropuesta.Text, code);

            if (agregado == true)
            {
                MessageBox.Show("Agregada");
                dt.Clear();
                vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                txtNombrePropuesta.Text = " Nombre de la propuesta";
                txtEscalaPropuesta.Text = "  Escala Musical";
            }
            else
            {
                MessageBox.Show("No Agregada");
            }
        }
        private void btnCerrarPropuesta_Click(object sender, EventArgs e)
        {
            pnAgregarPropuesta.Visible = false;
            dt.Clear();

        }

        private void btnCerrarPropuesta_MouseHover(object sender, EventArgs e)
        {
            btnCerrarPropuesta.BackColor = Color.LightPink;
            btnCerrarPropuesta.BorderStyle = BorderStyle.Fixed3D;
            btnCerrarPropuesta.Size = new Size(36, 36);
        }

        private void btnCerrarPropuesta_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarPropuesta.BackColor = Color.Turquoise;
            btnCerrarPropuesta.BorderStyle = BorderStyle.None;
            btnCerrarPropuesta.Size = new Size(31, 31);
        }
        //-----------------------------------------------------------------------------------//
        private void txtNombrePropuesta_MouseHover(object sender, EventArgs e)
        {
           

            if (txtNombrePropuesta.Text == " Nombre de la propuesta")
            {
                txtNombrePropuesta.Text = "";
            }

         
        }

        private void txtNombrePropuesta_MouseLeave(object sender, EventArgs e)
        {
            if (txtNombrePropuesta.Text == "")
            {
                txtNombrePropuesta.Text = " Nombre de la propuesta";
            }
        }

        private void txtNombrePropuesta_Enter(object sender, EventArgs e)
        {
            if (txtNombrePropuesta.Text == "")
            {
                txtNombrePropuesta.Text = " Nombre de la propuesta";
            }
        }

        private void txtNombrePropuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombrePropuesta.Text == " Nombre de la propuesta")
            {
                txtNombrePropuesta.Text = "";
            }
        }
        //------------------------------------------------------------------------------------//


        //------------------------------------------------------------------------------------//
        private void txtEscalaPropuesta_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover

           if (txtEscalaPropuesta.Text == "  Escala Musical")
            {
                txtEscalaPropuesta.Text = "";
            }

            /*  //Enter
           if (txtNombrePropuesta.Text == "")
           {
               txtNombrePropuesta.Text = " Nombre de la propuesta";
           }
           *//*//KeyPress
           if (txtNombrePropuesta.Text == " Nombre de la propuesta")
           {
               txtNombrePropuesta.Text = "";
           }

           //Mouse Hover
           if (txtNombrePropuesta.Text == " Nombre de la propuesta")
           {
               txtNombrePropuesta.Text = "";
           }

           //Mouse Leave
           if (txtNombrePropuesta.Text == "")
           {
               txtNombrePropuesta.Text = " Nombre de la propuesta";
           }*/
        }

        private void txtEscalaPropuesta_MouseLeave(object sender, EventArgs e)
        {
            if (txtEscalaPropuesta.Text == "")
            {
                txtEscalaPropuesta.Text = "  Escala Musical";
            }
        }

        private void txtEscalaPropuesta_Enter(object sender, EventArgs e)
        {
            if (txtEscalaPropuesta.Text == "")
            {
                txtEscalaPropuesta.Text = "  Escala Musical";
            }
        }

        private void txtEscalaPropuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEscalaPropuesta.Text == "  Escala Musical")
            {
                txtEscalaPropuesta.Text = "";
            }
        }

        //----------------------------------------------------------------------------------------//
        //=================================================================================//
        //*********************************************************************************//





        //****************** Boton Editar Propuesta ***************************************//
        int idValue = 0;

        private void BtnEditarPropuesta_Click(object sender, EventArgs e)
        {
            if (labTodasLasPropuestas.Visible == true)
            {
                pnEditarPropuesta.Visible = true;
                if (vistaGeneralCanciones.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = vistaGeneralCanciones.SelectedRows[0];

                    // Reemplaza "nombreDeLaColumna" con el nombre real de la columna "id" en tu DataGridView
                    string nameSong = selectedRow.Cells["nameSong"].Value.ToString();
                    string nameScale = selectedRow.Cells["musicalScale"].Value.ToString();
                    idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    txtEditarNombrePropuesta.Text = nameSong;
                    txtEditarEscalaPropuesta.Text = nameScale;

                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);

                    // Ahora puedes usar el valor de "idValue"

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna fila este es el que sale.");
                    pnEditarPropuesta.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado la tabla de propuestas.");
            }
        }

        private void BtnEditarPropuesta_MouseHover(object sender, EventArgs e)
        {
            //178; 35  183,38
            BtnEditarPropuesta.BorderStyle = BorderStyle.Fixed3D;
            BtnEditarPropuesta.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            BtnEditarPropuesta.Size = new Size(183, 38);


            BtnEditarPropuesta.Font = new Font(BtnEditarPropuesta.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void BtnEditarPropuesta_MouseLeave(object sender, EventArgs e)
        {

            //178; 35  183,38
            BtnEditarPropuesta.BorderStyle = BorderStyle.FixedSingle;
            BtnEditarPropuesta.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            BtnEditarPropuesta.Size = new Size(178, 35);


            BtnEditarPropuesta.Font = new Font(BtnEditarPropuesta.Font.FontFamily, 11, FontStyle.Regular);
        }

        //==================== Panel Para Editar Propuestas ==============================//
        private void btnEditarPropuestas_Click(object sender, EventArgs e)
        {

            bool actulizado = false;

            actulizado = AllSingers.singers.editarPropuesta(idValue, txtEditarNombrePropuesta.Text, txtEditarEscalaPropuesta.Text);


            if (actulizado == true)
            {

                MessageBox.Show("Actualizado");
                dt.Clear();
                vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
            }
            else
            {
                MessageBox.Show("No Actualizado");
            }
        }
        private void btnEditarPropuestas_MouseHover(object sender, EventArgs e)
        {
            btnEditarPropuestas.BackColor = Color.LightPink;
            //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
            // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 */
           // 141; 38
            btnEditarPropuestas.Size = new Size(149, 42);

            btnEditarPropuestas.Font = new Font(btnEditarPropuestas.Font.FontFamily, 20, FontStyle.Bold);
        }

        private void btnEditarPropuestas_MouseLeave(object sender, EventArgs e)
        {
            btnEditarPropuestas.BackColor = Color.LightPink;
            //  btnActualizarUsuario.BorderStyle = BorderStyle.Fixed3D;
            // btnEditarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            /*250; 46   F = 15.75 */
            // 141; 38
            btnEditarPropuestas.Size = new Size(141, 38);

            btnEditarPropuestas.Font = new Font(btnEditarPropuestas.Font.FontFamily, 16, FontStyle.Regular);
        }
        private void btnCerrarEditarPropuesta_Click(object sender, EventArgs e)
        {
            pnEditarPropuesta.Visible = false;
        }
        private void btnCerrarEditarPropuesta_MouseHover(object sender, EventArgs e)
        {
            btnCerrarEditarPropuesta.BackColor = Color.LightPink;
            btnCerrarEditarPropuesta.BorderStyle = BorderStyle.Fixed3D;
            btnCerrarEditarPropuesta.Size = new Size(36, 36);
        }

        private void btnCerrarEditarPropuesta_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarEditarPropuesta.BackColor = Color.Turquoise;
            btnCerrarEditarPropuesta.BorderStyle = BorderStyle.None;
            btnCerrarEditarPropuesta.Size = new Size(31, 31);
        }
        //================================================================================//
        //********************************************************************************//



        //***************** Boton Eliminar Propuesta *************************************//
        private void btnEliminarPropuesta_Click(object sender, EventArgs e)
        {
            if (vistaGeneralCanciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = vistaGeneralCanciones.SelectedRows[0];

                // Reemplaza "nombreDeLaColumna" con el nombre real de la columna "id" en tu DataGridView
                int idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);

                AllSingers.singers.eliminarPropuesta(idValue);
                DataTable dt = new DataTable();
                vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                // Ahora puedes usar el valor de "idValue"

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.es te es el");
            }

        }
        private void btnEliminarPropuesta_MouseHover(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnEliminarPropuesta.BorderStyle = BorderStyle.Fixed3D;
            btnEliminarPropuesta.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnEliminarPropuesta.Size = new Size(183, 38);


            btnEliminarPropuesta.Font = new Font(btnEliminarPropuesta.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnEliminarPropuesta_MouseLeave(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnEliminarPropuesta.BorderStyle = BorderStyle.FixedSingle;
            btnEliminarPropuesta.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnEliminarPropuesta.Size = new Size(178, 35);


            btnEliminarPropuesta.Font = new Font(btnEliminarPropuesta.Font.FontFamily, 11, FontStyle.Regular);
        }
        //********************************************************************************//




        //***************** Boton Aprobar Propuesta *************************************//
        private void btnAprobarPropuesta_Click(object sender, EventArgs e)
        {
            if (vistaGeneralCanciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = vistaGeneralCanciones.SelectedRows[0];

                // Reemplaza "nombreDeLaColumna" con el nombre real de la columna "id" en tu DataGridView
                int idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);


                if (AllSingers.singers.aprobarPropuesta(idValue) == true)
                {
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.todasLasPropuestas(dt);
                    MessageBox.Show("Propuesta agregada al baul de canciones.");
                    dt.Clear();
                    vistaGeneralCanciones.DataSource = AllSingers.singers.newe(dt);

                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void btnAprobarPropuesta_MouseHover(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnAprobarPropuesta.BorderStyle = BorderStyle.Fixed3D;
            btnAprobarPropuesta.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnAprobarPropuesta.Size = new Size(190, 38);


            btnAprobarPropuesta.Font = new Font(btnAprobarPropuesta.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnAprobarPropuesta_MouseLeave(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnAprobarPropuesta.BorderStyle = BorderStyle.FixedSingle;
            btnAprobarPropuesta.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnAprobarPropuesta.Size = new Size(178, 35);


            btnAprobarPropuesta.Font = new Font(btnAprobarPropuesta.Font.FontFamily, 11, FontStyle.Regular);
        }
        //*******************************************************************************//



        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label10_Click(object sender, EventArgs e)
        {

        }




        /*---------------------------------------------------------------*/







        private void pnUsuariosActivos_Paint(object sender, PaintEventArgs e)
        {

        }

        //******************** boton Agregar Usuario **************************************//
        DataTable dataTableUs = new DataTable();
        private void btnCerrarAgregarUsuario_Click(object sender, EventArgs e)
        {

            txtNuevaClave.Visible = true;
            verClaveNuevoUsuario.Visible = true;
            verConfirmacionNuevaClave.Visible = true;
            txtConfirmarNuevaClave.Visible = true;
            panel17.Visible = true;
            panel16.Visible = true;


            btnCrearNuevoUsuario.Text = "Crear Usuario";


            txtNuevaEdad.Text = "Edad";
            labAgregarUsuario.Text = "Agregar Usuario";
            btnHome.Visible = true;
            labNombreUsuario.Visible = true;
            labTodasLasPropuestas.Visible = true;
            labTituloCanciones.Visible = true;
            controlOpciones.Visible = true;
            opciones.Visible = true;
            pnUsuariosActivos.Visible = true;

            pnUsuariosActivos.Visible = false;
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {


            dataTableUs.Clear();
            todosLosUsuariosRegistrados.DataSource = AllSingers.singers.todosLosUsuarios(dataTableUs);
            labAgregarUsuario.Text = "Agregar Usuario";
            btnHome.Visible = false;
            labNombreUsuario.Visible = false;
            labTodasLasPropuestas.Visible = false;
            labTituloCanciones.Visible = false;
            controlOpciones.Visible = false;
            opciones.Visible = false;
            pnUsuariosActivos.Visible = true;
            pnUsuariosActivos.Location = new Point(12, 55);

        }
        private void btnAgregarUsuario_MouseHover(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnAgregarUsuario.BorderStyle = BorderStyle.Fixed3D;
            btnAgregarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnAgregarUsuario.Size = new Size(183, 38);


            btnAgregarUsuario.Font = new Font(btnAgregarUsuario.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnAgregarUsuario_MouseLeave(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnAgregarUsuario.BorderStyle = BorderStyle.FixedSingle;
            btnAgregarUsuario.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnAgregarUsuario.Size = new Size(178, 35);


            btnAgregarUsuario.Font = new Font(btnAgregarUsuario.Font.FontFamily, 11, FontStyle.Regular);
        }


        //==================== Panel Para Crear Un Usuario ================================//
        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNuevoUsuario.Text;
            string apellido = txtNuevoApellido.Text;
            string texitura = txtNuevaTexitura.Text;
            int clave = Convert.ToInt32(txtNuevaClave.Text);
            int confirmacionClave = Convert.ToInt32(txtConfirmarNuevaClave.Text);
            int edad = Convert.ToInt32(txtNuevaEdad.Text);

            if (labAgregarUsuario.Text == "Eliminar Usuario") 
            {
                if (todosLosUsuariosRegistrados.Rows.Count > 0)
                {
                 /*linea 1108*/   DataGridViewRow selectedRow = todosLosUsuariosRegistrados.SelectedRows[0];
                    int idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);
                  
                    bool trFal = AllSingers.singers.eliminarUsuario(idValue);
                    if (trFal == true)
                    {
                        MessageBox.Show("Usuario Eliminado Exitosamente !!!!");
                    }
                    else
                    {
                        MessageBox.Show("El usuario no puede ser eliminado!!" + idValue);
                    }
                  
                    dataTableUs.Clear();
                    todosLosUsuariosRegistrados.DataSource = AllSingers.singers.todosLosUsuarios(dataTableUs);
                }
                else
                {
                    MessageBox.Show("Usuario selecciona un usuario.");
                }

            }
            else 
            {
                if (clave != 1234)
                {
                    if (clave == confirmacionClave)
                    {
                        AllSingers.singers.agregarUsuario(nombre, apellido, clave, texitura, edad);
                        MessageBox.Show("Usuario Creado Exitosamente !!!!");
                        dataTableUs.Clear();
                        todosLosUsuariosRegistrados.DataSource = AllSingers.singers.todosLosUsuarios(dataTableUs);
                    }
                    else
                    {
                        MessageBox.Show("Las claves no coiciden, intenta de nuevo. ");
                    }
                }
                else
                {
                    MessageBox.Show("Tu clave es 1234 intenta una mas segura.");
                }

            }
           
        }


        /*---------------------------------------------------------------------------------*/
        private void verClaveNuevoUsuario_MouseHover(object sender, EventArgs e)
        {
            if (txtNuevaClave.Text == "1234")
            {
                txtNuevaClave.Text = "";
            }
            txtNuevaClave.UseSystemPasswordChar = false;
        }

        private void verClaveNuevoUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (txtNuevaClave.Text == "")
            {
                txtNuevaClave.Text = "1234";
            }
            txtNuevaClave.UseSystemPasswordChar = true;
        }
        /*---------------------------------------------------------------------------------*/



        /*---------------------------------------------------------------------------------*/
        private void verConfirmacionNuevaClave_MouseHover(object sender, EventArgs e)
        {

            if (txtConfirmarNuevaClave.Text == "1234")
            {
                txtConfirmarNuevaClave.Text = "";
            }
            txtConfirmarNuevaClave.UseSystemPasswordChar = false;
        }

        private void verConfirmacionNuevaClave_MouseLeave(object sender, EventArgs e)
        {
            if (txtConfirmarNuevaClave.Text == "")
            {
                txtConfirmarNuevaClave.Text = "1234";
            }
            txtConfirmarNuevaClave.UseSystemPasswordChar = true;
        }
        /*---------------------------------------------------------------------------------*/



        //=================================================================================//
        //*********************************************************************************//






        //******************** Boton Eliminar Usuario **************************************//
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            txtNuevaClave.Visible = false;
            verClaveNuevoUsuario.Visible = false;
            verConfirmacionNuevaClave.Visible = false;
            txtConfirmarNuevaClave.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;


            dataTableUs.Clear();
            todosLosUsuariosRegistrados.DataSource = AllSingers.singers.todosLosUsuarios(dataTableUs);

            //btnHome.Visible = false; 
            labNombreUsuario.Visible = false;
            labTodasLasPropuestas.Visible = false;
            labTituloCanciones.Visible = false;
            controlOpciones.Visible = false;
            opciones.Visible = false;

            pnUsuariosActivos.Location = new Point(12, 55);
            btnCrearNuevoUsuario.Text = "Eliminar Usuario";

            int x = (pnUsuariosActivos.Width - labAgregarUsuario.Width) / 2;
            labAgregarUsuario.Location = new Point(x, 50);
            pnUsuariosActivos.Visible = true;
            txtNuevaEdad.Text = "id";
            labAgregarUsuario.Text = "Eliminar Usuario";

            
               
            

        }

        private void btnEliminarUsuario_MouseHover(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnEliminarUsuario.BorderStyle = BorderStyle.FixedSingle;
            btnEliminarUsuario.BackColor = Color.LightPink;
            // btnEditarUsuario.Font = new
            btnEliminarUsuario.Size = new Size(183, 38);


            btnEliminarUsuario.Font = new Font(btnEliminarUsuario.Font.FontFamily, 12, FontStyle.Bold);
        }
        private void btnEliminarUsuario_MouseLeave(object sender, EventArgs e)
        {
            //178; 35  183,38
            btnEliminarUsuario.BorderStyle = BorderStyle.FixedSingle;
            btnEliminarUsuario.BackColor = Color.Turquoise;
            // btnEditarUsuario.Font = new
            btnEliminarUsuario.Size = new Size(178, 35);


            btnEliminarUsuario.Font = new Font(btnEliminarUsuario.Font.FontFamily, 11, FontStyle.Regular);
        }
        //***********************************************************************************//






        //******************** Todos Los Usuarios Del DataGridView *************************//
        private void todosLosUsuariosRegistrados_SelectionChanged(object sender, EventArgs e)
        {
            /*dataTableUs.Clear();
            todosLosUsuariosRegistrados.DataSource = AllSingers.singers.todosLosUsuarios(dataTableUs);*/
            if (labAgregarUsuario.Text == "Eliminar Usuario")
            {
                if (todosLosUsuariosRegistrados.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = todosLosUsuariosRegistrados.SelectedRows[0];

                    // Reemplaza "nombreDeLaColumna" con el nombre real de la columna "id" en tu DataGridView
                    int idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    txtNuevoUsuario.Text = selectedRow.Cells["nombre"].Value.ToString();
                    txtNuevoApellido.Text = selectedRow.Cells["apellido"].Value.ToString();

                    txtNuevaEdad.Text = idValue + "";
                    txtNuevaTexitura.Text = selectedRow.Cells["texituraVocal"].Value.ToString();

                }
                
            }


        }
        //**********************************************************************************//





        private void todosLosUsuariosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //****************** Opcion para mover formulario ***************************************************//
        
        private bool moverForm = false;
        private int ladoX, ladoY;

        private void VistaGeneral_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverForm)
            {
                this.Left += e.X - ladoX;
                this.Top += e.Y - ladoY;
            }
                
        }

        private void VistaGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm = true;
            ladoX = e.X;
            ladoY = e.Y;
        }

        private void labVerClave_Click(object sender, EventArgs e)
        {

        }

       

        private void VistaGeneral_MouseUp(object sender, MouseEventArgs e)
        {
            moverForm = false;
        }
        //*************************************************************************************************//

        //--------------------------------------------------------------------------------------------------//










    }
        /**********************************************************************************************/

    
}

