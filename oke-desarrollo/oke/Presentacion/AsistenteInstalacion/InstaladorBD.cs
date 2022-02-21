﻿using oke.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace oke.Presentacion.AsistenteInstalacion
{
    public partial class InstaladorBD : Form
    {
        public InstaladorBD()
        {
            InitializeComponent();
        }
        private AES aes = new AES();
        string ruta;
        public static int milisegundo1;
        public static int segundos1;
        public static int minutos1;
        public static int milisegundo;
        public static int segundos;
        string nombre_del_equipo_usuario;

        private void InstaladorBD_Load(object sender, EventArgs e)
        {
            centrarPaneles();
            Reemplazar();
            comprobar_si_ya_hay_servidor_instalado_SQL_EXPRESS();
            Conectar();
        }

        private void centrarPaneles()
        {
            panelInstalandoServidor.Location = new Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2);
            Cursor = Cursors.WaitCursor;
            //Panel4.Visible = false;
            //Panel4.Dock = DockStyle.None;
        }
        private void Reemplazar()
        {
            //Solo modificar este campo
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("oke", TXTbasededatos.Text);
            //********

            txtEliminarBase.Text = txtEliminarBase.Text.Replace("oke", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("oke", txtusuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("oke", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("oke369", lblcontraseña.Text);
            //Adjuntando al texbox que contiene los procedimientos almacenados
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;

        }
        private void comprobar_si_ya_hay_servidor_instalado_SQL_EXPRESS()
        {
            txtservidor.Text = @".\" + lblnombredeservicio.Text;
            ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio();
            ejecutar_scryt_crearBase_comprobacion_De_inicio();


        }
        private void ejecutar_scryt_crearBase_comprobacion_De_inicio()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + TXTbasededatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + TXTbasededatos.Text + ";Integrated Security=True", Logica.Desencryptacion.appPwdUnique, int.Parse("256")));
                EjecutarScript();
                //Panel4.Visible = true;
                //Panel4.Dock = DockStyle.Fill;
            //    Label1.Text = @"Instancia Encontrada...
            //No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo";
                //Panel6.Visible = false;
                timer4.Start();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Panel6.Visible = true;
                btnInstalarServidor.Visible = true;
                Panel4.Visible = false;
                Panel4.Dock = DockStyle.None;
                lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor ";
            }


            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        private void ejecutar_scryt_ELIMINARBase_comprobacion_de_inicio()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }
        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        private void EjecutarScript()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtnombre_scrypt.Text + ".txt");
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;

            try
            {
                if (File.Exists(ruta) == false)
                {

                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                Process Pross = new Process();

                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + txtservidor.Text + " -i " + txtnombre_scrypt.Text + ".txt";
                Pross.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            milisegundo1 += 1;
            milise.Text = Convert.ToString(milisegundo1);
            if (milisegundo1 == 60)
            {
                segundos1 += 1;
                seg.Text = Convert.ToString(segundos1);

                milisegundo1 = 0;

            }

            if (segundos1 == 60)
            {
                minutos1 += 1;

                min.Text = Convert.ToString(minutos1);
                segundos1 = 0;
            }

            if (minutos1 == 6)
            {
                timer2.Enabled = false;

                ejecutar_scryt_ELIMINARBase();
                ejecutar_scryt_crearBase();

                timer3.Start();
            }
        }
        private void ejecutar_scryt_crearBase()
        {
            var cnn = new SqlConnection("Server=" + txtservidor.Text + "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + TXTbasededatos.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source=" + txtservidor.Text + ";Initial Catalog=" + TXTbasededatos.Text + ";Integrated Security=True", Logica.Desencryptacion.appPwdUnique, int.Parse("256")));
                EjecutarScript();
                timer4.Start();
            }
            catch (Exception ex)
            {
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        private void ejecutar_scryt_ELIMINARBase()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data Source=" + txtservidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if ((myConn.State == ConnectionState.Open))
                {
                    myConn.Close();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            milisegundo1 += 1;
            milise.Text = Convert.ToString(milisegundo1);
            if (milisegundo1 == 60)
            {
                segundos1 += 1;
                seg.Text = Convert.ToString(segundos1);

                milisegundo1 = 0;

            }

            if (segundos1 == 60)
            {
                minutos1 += 1;

                min.Text = Convert.ToString(minutos1);
                segundos1 = 0;
            }

            if (minutos1 == 1)
            {

                ejecutar_scryt_ELIMINARBase();
                ejecutar_scryt_crearBase();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            milisegundo += 1;
            mil3.Text = Convert.ToString(milisegundo);

            if (milisegundo == 60)
            {
                segundos += 1;
                seg3.Text = Convert.ToString(segundos);
                milisegundo = 0;
            }

            if (segundos == 15)
            {
                timer4.Stop();

                try
                {
                    File.Delete(ruta);
                }
                catch (Exception ex)
                {

                }
                MessageBox.Show("!Listo. Inicia la aplicacion de nuevo!");
                Dispose();

            }
        }

        private void TimerCRARINI_Tick(object sender, EventArgs e)
        {
            string rutaPREPARAR;
            StreamWriter sw;
            rutaPREPARAR = Path.Combine(Directory.GetCurrentDirectory(), "ConfigurationFile.ini");
            rutaPREPARAR = rutaPREPARAR.Replace("ConfigurationFile.ini", @"SQLEXPR_x86_ESN\ConfigurationFile.ini");


            if (File.Exists(rutaPREPARAR) == true)
            {
                TimerCRARINI.Stop();
            }

            try
            {
                sw = File.CreateText(rutaPREPARAR);
                sw.WriteLine(txtArgumentosini.Text);
                sw.Flush();
                sw.Close();
                TimerCRARINI.Stop();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInstalarServidor_Click(object sender, EventArgs e)
        {

            try
            {
                txtArgumentosini.Text = txtArgumentosini.Text.Replace("PRUEBAFINAL22", lblnombredeservicio.Text);
                TimerCRARINI.Start();
                executa();
                timer2.Start();
                //Panel4.Visible = true;
                //Panel4.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void executa()
        {
            try
            {
                Process Pross = new Process();
                Pross.StartInfo.FileName = "SQL2019-SSEI-Expr.exe";
                Pross.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini /ACTION=Install /IACCEPTSQLSERVERLICENSETERMS /SECURITYMODE=SQL /SAPWD=" + lblcontraseña.Text + " /SQLSYSADMINACCOUNTS=" + nombre_del_equipo_usuario;
                Pross.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                Pross.Start();
                //Panel4.Visible = true;
                //Panel4.Dock = DockStyle.Fill;
            }
            catch (Exception)
            {


            }
        }
    }
}
