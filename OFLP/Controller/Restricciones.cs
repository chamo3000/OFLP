using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Controlador
{
   static class Restricciones
    {
        

        public static void Solo_Numero_Press(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {

                        if (e.KeyChar == (char)(Keys.Back))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la validacion de ingresar solo números");
            }
        }

        public static bool Tiene_Letras(string Texto)
        {
            bool Resultado = false;
            try
            {
                foreach (char letra in Texto)
                {
                    if (Char.IsNumber(letra))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la validacion de ingresar solo letras");
            }
            return Resultado;


        }


        public static bool Tiene_Numeros(string Texto)
        {
            bool Resultado = false;
            try
            {
                foreach (char letra in Texto)
                {
                    if (!Char.IsNumber(letra))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la validacion de ingresar solo numeros");
            }
            return Resultado;


        }


        public static void BloqueoTxt(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) || char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Fallo la validación de bloqueo");

            }

         
        }
    }
}
