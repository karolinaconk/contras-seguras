using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace passwords_seguras
{
    public partial class Form1 : Form
    {
        private bool valid_username = false;
        private bool valid_email = false;
        private bool valid_password = false;
        private bool valid_confirm_password = false;
        public Form1()
        {
            InitializeComponent();
            text_email.Text = "Ingresa tu email aquí";
            text_email.ForeColor = Color.Gray;

            text_email.Enter += text_email_Enter;
            text_email.Leave += text_email_Leave;

            text_username.Text = "Ingresa tu username aquí";
            text_username.ForeColor = Color.Gray;

            text_username.Enter += text_username_Enter;
            text_username.Leave += text_username_Leave;
            button1.Enabled = false;

  
            /**
            else
            {
                button1.Enabled = true;
            }
            
            else if (valid_username == true && valid_password == true && valid_email == true && valid_confirm_password == true)
            {
                button1.Enabled = true;
            }
            **/
        }
        private void text_username_Enter(object sender, EventArgs e)
        {
            if (text_username.Text == "Ingresa tu username aquí")
            {
                text_username.Text = "";
                text_username.ForeColor = Color.Black;
            }
        }

        private void text_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_username.Text))
            {
                text_username.Text = "Ingresa tu username aquí";
                text_username.ForeColor = Color.Gray;
            }
        }

        private void text_email_Enter(object sender, EventArgs e)
        {
            if (text_email.Text == "Ingresa tu email aquí")
            {
                text_email.Text = "";
                text_email.ForeColor = Color.Black;
            }
        }

        private void text_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_email.Text))
            {
                text_email.Text = "Ingresa tu email aquí";
                text_email.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string password = text_password.Text;

            if (text_confirm_password.Text == password)
            {
                error_confirm_password.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_confirm_password.Visible = true; // Oculta el icono
                label_confirm_password.Text = " ";
                valid_confirm_password = true;
            }
            else
            {
                label_confirm_password.Text = "Las passwords no coinciden";
                error_confirm_password.Image = Properties.Resources.error_warning_fill; // Cambia el icono a rojo
                error_confirm_password.Visible = true; // Muestra el icono
                valid_confirm_password = false;
            }

            if (valid_username == true && valid_password == true && valid_email == true && valid_confirm_password == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
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

            if (hasInvalidChars || (text_username.Text.Length > 0 && char.IsDigit(text_username.Text[0])) || text_username.Text.Length < 3)
            {
                error_username.Image = Properties.Resources.error_warning_fill; // Cambia el icono a rojo
                error_username.Visible = true; // Muestra el icono
                valid_username = false;
                if (hasInvalidChars)
                {
                    label_username.Text = "No se permiten caracteres especiales";
                } 
                else if ((text_username.Text.Length > 0 && char.IsDigit(text_username.Text[0])))
                {
                    label_username.Text = "No se permite el primer dígito sea número";
                }
            }
            else
            {
                label_username.Text = " ";
                error_username.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_username.Visible = true; // Oculta el icono
                valid_username = true;
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
                valid_email = false;
                if (hasInvalidChars)
                {
                    label_email.Text = "No se permiten caracteres especiales";
                }
                else if ((text_email.Text.Length > 0 && char.IsDigit(text_email.Text[0])))
                {
                    label_email.Text = "No se permite el primer dígito sea número";
                }
                else if (indiceArroba > indicePunto) {
                    label_email.Text = "No es correcto este formato de email";
                }
            }
            else
            {
                label_email.Text = " ";
                error_email.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_email.Visible = true; // Oculta el icono
                valid_email = true;
            }
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            string password = text_password.Text;
            bool isValid = Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[@$!%*?&])(?!.*\s).{12,}$");

            
            if (isValid)
            {
                error_password.Image = Properties.Resources.checkbox_fill; // Cambia el icono a verde
                error_password.Visible = true; // Oculta el icono
                label_password.Text = " ";
                valid_password = true;
            }
            else
            {
                label_password.Text = "Por lo menos una mayúscula, un número, un símbolo y 12 caracteres";
                error_password.Image = Properties.Resources.error_warning_fill; // Cambia el icono a rojo
                error_password.Visible = true; // Muestra el icono
                valid_password = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido :)" + valid_username + valid_email + valid_password + valid_confirm_password);
        }
    }
}
