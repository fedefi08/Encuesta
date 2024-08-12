using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class Encuesta : Form
    {

        /*Ejercicio 5: Encuesta Simple
            Objetivo: Crear una aplicación que permita realizar una encuesta simple.

            Interfaz:

            Varios RadioButton para las opciones de la encuesta.
            Botón "Enviar".
            Label para mostrar el resultado.
            Funcionalidad:

            Al presionar el botón "Enviar", se debe mostrar la opción seleccionada en el Label.
        */

      
        public Encuesta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string edad;
            if (rbtMenor.Checked)
                edad = "Entre 8 a 20";
            else if (rbtMediano.Checked)
                edad = "Entre 21 a 45";
            else
                edad = "Entre 45 a Mayor";

            string sexo;
            if (rbtMasculino.Checked)
                sexo = "Masculino";
            else
                sexo = "Femenino";

            string estudios;
            if (rbtPrimaria.Checked)
                estudios = "Primaria";
            else if (rbtSecundaria.Checked)
                estudios = "Secundaria";
            else
                estudios = "Universidad";


            MessageBox.Show("La informacion cargada es: \n" + edad +"\n"+ sexo+"\n"+ estudios,"Atencion!");
        }
    }
}
