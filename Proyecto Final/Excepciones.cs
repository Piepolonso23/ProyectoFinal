using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public class Excepciones
    {
        string nombre, cod, correoElectronico, contrasena, mensajeTotal = "";
        public string nombreCompleto(TextBox textBox)
        {
            try
            {
                nombre = textBox.Text;
                string mensaje = "";
                if (nombre.Length == 0 || nombre.StartsWith(" ") || !nombre.Contains(" ") || nombre.Contains("  "))
                    mensaje = "Ingrese su nombre correctamente" + "\n";
                foreach (char n in nombre)
                {
                    if (Char.IsDigit(n))
                        mensaje = "Ingrese su nombre correctamente" + "\n";
                    if (!Char.IsLetter(n) && n != ' ')
                        mensaje = "Ingrese su nombre correctamente" + "\n";
                }
                if (mensaje.Length > 0)
                {
                    mensajeTotal += mensaje + "\n";
                    textBox.Clear();
                    nombre = "";
                }
            }
            catch (Exception)
            {
                mensajeTotal += "Ingrese su nombre correctamente" + "\n";
                textBox.Clear();
                nombre = "";
                textBox.Focus();
            }
            return nombre.ToUpper();
        }

        public string codigo(TextBox textBox)
        {
            try
            {
                cod = textBox.Text;
                string mensaje = "";
                if (cod.Length == 0 || cod.Length != 9)
                    mensaje = "Ingrese su código correctamente" + "\n";
                foreach (char d in cod)
                {
                    if (Char.IsLetter(d))
                        mensaje = "Ingrese su código correctamente" + "\n";
                }
                if (mensaje.Length > 0)
                {
                    mensajeTotal += mensaje + "\n";
                    textBox.Clear();
                    cod = "";
                }
            }
            catch (Exception)
            {
                mensajeTotal += "Ingrese su código correctamente" + "\n";
                textBox.Clear();
                cod = "";
                textBox.Focus();
            }
            return cod;
        }

        public bool isEmail(string correo)
        {
            string emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, emailFormato))
            {
                if (Regex.Replace(correo, emailFormato, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public string correo(TextBox textBox)
        {
            try
            {
                correoElectronico = textBox.Text;
                string mensaje = "";
                if (correoElectronico.Length == 0 || isEmail(correoElectronico) == false)
                    mensaje = "Ingrese su correo electrónico correctamente" + "\n";
                if (mensaje.Length > 0)
                {
                    mensajeTotal += mensaje + "\n";
                    textBox.Clear();
                    correoElectronico = "";
                }
            }
            catch (Exception)
            {
                mensajeTotal += "Ingrese su correo electrónico correctamente" + "\n";
                textBox.Clear();
                correoElectronico = "";
                textBox.Focus();
            }
            return correoElectronico;
        }

        public string contra(TextBox textBox)
        {
            try
            {
                contrasena = textBox.Text;
                string mensaje = "";
                if (contrasena.Length == 0 || contrasena.Length > 8)
                    mensaje = "Ingrese su contraseña de máximo 8 dígitos correctamente" + "\n";
                if (mensaje.Length > 0)
                {
                    mensajeTotal += mensaje + "\n";
                    textBox.Clear();
                    contrasena = "";
                }
            }
            catch (Exception)
            {
                mensajeTotal += "Ingrese su contraseña de máximo 8 dígitos correctamente" + "\n";
                textBox.Clear();
                contrasena = "";
                textBox.Focus();
            }
            return contrasena;
        }

        public int notas(TextBox textBox)
        {
            int nota = 0;
            try
            {
                if (Convert.ToInt32(textBox.Text) > 20 || Convert.ToInt32(textBox.Text) < 0)
                {
                    throw new Exception("Ingrese la nota correctamente");
                }
                else
                {
                    nota = Convert.ToInt32(textBox.Text);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, e.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox.Text = "0";
                textBox.Focus();
            }
            return nota;
        }

        public void showMensaje()
        {
            if (mensajeTotal.Length > 0)
            {
                MessageBox.Show(null, mensajeTotal, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
