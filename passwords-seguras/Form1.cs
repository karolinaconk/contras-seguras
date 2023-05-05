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

namespace passwords_seguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor_username = text_username.Text;
            string valor_email = text_email.Text;
            string valor_password = text_password.Text;
            string valor_confirm_password = text_confirm_password.Text;

            if (valor_password != valor_confirm_password)
            {
                MessageBox.Show("Las contraseñas no coinciden intenta de nuevo");
            }
            else
            {
                if (valor_password.Length >= 12)
                {
                    MessageBox.Show("Bienvenido :)");
                }

            }
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {
            bool hasInvalidChars = false;
            string invalidChars = " !#$%&/()=?¡¿'°|¬\"\\,.-_{}[]´+*¨~`^@"; // Reemplaza esto con las letras no permitidas que desees

            foreach (char c in text_username.Text)
            {
                if (invalidChars.Contains(c.ToString()))
                {
                    hasInvalidChars = true;
                    break;
                }
            }

            if (hasInvalidChars || (text_username.Text.Length > 0 && char.IsDigit(text_username.Text[0])) || text_username.Text.Length < 12)
            {
                error_username.Image = Properties.Resources.error_warning_fill; // Cambia el icono a rojo
                error_username.Visible = true; // Muestra el icono
            }
            else
            {
                error_username.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_username.Visible = true; // Oculta el icono
            }
        }
        
        private void text_email_TextChanged(object sender, EventArgs e)
        {
            bool hasInvalidChars = false;
            string invalidChars = " !#$%&/()=?¡¿'°|¬\"\\,-_{}[]´+*¨~`^"; // Reemplaza esto con las letras no permitidas que desees

            foreach (char c in text_email.Text)
            {
                if (invalidChars.Contains(c.ToString()))
                {
                    hasInvalidChars = true;
                    break;
                }
            }
            int indiceArroba = text_email.Text.IndexOf('@');
            int indicePunto = text_email.Text.IndexOf('.');
            if (hasInvalidChars || (text_email.Text.Length > 0 && char.IsDigit(text_email.Text[0]) && text_email.Text[0] == '@' && text_email.Text[0] == '.') || !text_email.Text.Contains("@") || text_email.Text.Length < 6 || indiceArroba > indicePunto)
            {
                error_email.Image = Properties.Resources.error_warning_fill; // Cambia el icono a rojo
                error_email.Visible = true; // Muestra el icono
            }
            else
            {
                error_email.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_email.Visible = true; // Oculta el icono
            }
        }
    }
}
