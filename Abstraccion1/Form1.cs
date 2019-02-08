using Abstraccion1.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Abstraccion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var alumno = new Alumno();
            {
                alumno.Nombre = "Lorena Gregorio";
                alumno.Carne = "140405001";
            

            };



            var carrera = new Carrera();
            {
                carrera.Nombre = "Ingenieria";
                carrera.Estado = true;
                carrera.Codigo = 01021;


            };

            var catedraticos = new Catedraticos();
            {
                catedraticos.Nombre = "Wergner Morales";
                catedraticos.Telefono = "54125812";
                catedraticos.Estado = true;
            };

            var curso = new Curso();
            {
                curso.Codigo = 123;
                curso.Nombre = "Programacion 2";
                curso.Estado = true;
            };

            var extension = new Extension();
            {
                extension.Nombre = "Montesquieu";
                extension.NIT = "819415-7";
                extension.Telefono = 24859667;
                extension.FAX = 25415818;
                extension.Email = "montesquieu@hotmail.com";


            };

            var facultad = new Facultad();

            {
                facultad.Nombre = "Ingenieria";
                facultad.Estado = true;
            };

            var pensum = new Pensum();

            {
                pensum.Anio = 2;
                pensum.Estado = true;

            };

            var salon = new Salon();

            {
                salon.Numero = 5;
                salon.Capacidad = 20;
                salon.Nombre = "Manuel Ayau";
                salon.Estado = true;

            };

            var seccion = new Seccion();

            {
                seccion.Numero = 1;
                seccion.Capacidad = 25;

            };

            var tiposalon = new TipoSalon();
            {
                tiposalon.Nombre = "Laboratorio";
                tiposalon.Descripcion = "Con Maquinas";
                tiposalon.Estado = true;
            };

            var universidad = new Universidad();
            {

                universidad.Nombre = "Universidad de Occidente";
                universidad.NIT = "181664-0";
                universidad.Telefono = 24526987;
                universidad.FAX = 24526987;
                universidad.Email = "montesquieu@hotmail.com";

            };

            label1.Text = "Alumno: " + alumno.Nombre + "\n" +
                          "Carne: " + alumno.Carne + "\n";

            label2.Text= "Carrera: "  +carrera.Nombre + "\n" +
                          "Estado: "+ carrera.Estado;

            label3.Text= "Nombre: " + catedraticos.Nombre + "\n" +
                          "Telefono; " + catedraticos.Telefono + "\n"+
                          "Estado: " + catedraticos.Estado;

            label4.Text = "Codigo: " + curso.Codigo + "\n" +
                           "Nombre: " + curso.Nombre + "\n" +
                           "Estado: " + curso.Estado;

            label5.Text = "Nombre: " + extension.Nombre + "\n" +
                            "NIT: " + extension.NIT + "\n" +
                            "Telefono: " + extension.Telefono + "\n" +
                            "Fax: " + extension.FAX + "\n" +
                            "Email: " + extension.Email;

            label6.Text = "Nombre: " + facultad.Nombre + "\n" +
                            "Estado: " + facultad.Estado;

            label7.Text = "Año: " + pensum.Anio + "\n"+
                           "Estado: " + pensum.Estado;

            label8.Text = "Numero: " + salon.Numero + "\n" +
                            "Capacidad: " + salon.Capacidad + "\n" +
                            "Nombre: " + salon.Nombre + "\n" +
                            "Estado: " + salon.Estado;

            label9.Text = "Numero: " + seccion.Numero + "\n" +
                            "Capacidad: " + seccion.Capacidad;

            label10.Text = "Nombre: " + tiposalon.Nombre + "\n" +
                            "Descripcion: " + tiposalon.Descripcion + "\n" +
                            "Estado: " + tiposalon.Estado;

            label11.Text = "Nombre: " + universidad.Nombre + "\n" +
                            "NIT: " + universidad.NIT + "\n" +
                            "Telefono: " + universidad.Telefono + "\n" +
                            "Fax: " + universidad.FAX + "\n" +
                            "Email: " + universidad.Email;







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




    }
}
