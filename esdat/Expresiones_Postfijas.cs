using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdat
{
    public partial class Expresiones_Postfijas : Form
    {
        private Stack<int> pilaInt = new Stack<int>();
        int op1;
        int op2;
        bool val = false;
        public Expresiones_Postfijas()
        {
            InitializeComponent();
        }
        private void ImprimirPila()
        {
            dgvOPERANDOS.Rows.Clear();
            foreach (int item in pilaInt)
            {
                dgvOPERANDOS.Rows.Add(item.ToString());
            }
        }
        private void PasoAPaso()
        {
            dgvOPERANDOS.Rows.Clear();
            pilaInt.Clear();
            lblRESULTADO.Text = "Resultado: ";
            string[] expresion = txtEXPRESIONES.Text.Split(' ');
            for (int i = 0; i < expresion.Length; i++)
            {
                try
                {
                    int operando = int.Parse(expresion[i]);
                    pilaInt.Push(operando);
                    MessageBox.Show(expresion[i] + " Soy un operando feliz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    switch (expresion[i])
                    {
                        case "+":

                            if (pilaInt.Count >= 2)
                            {
                                op1 = pilaInt.Pop();
                                op2 = pilaInt.Pop();
                                int suma = op1 + op2;
                                MessageBox.Show("Push(" + op2 + " + " + op1 + ")");
                                pilaInt.Push(suma);
                                MessageBox.Show("El resultado de la suma: " + suma + " se agrega a la pila", "Aviso");
                            }
                            else
                            {
                                val = true;
                            }
                            break;
                        case "-":
                            if (pilaInt.Count >= 2)
                            {
                                op1 = pilaInt.Pop();
                                op2 = pilaInt.Pop();
                                int resta = op1 - op2;
                                MessageBox.Show("Push(" + op2 + " - " + op1 + ")");
                                pilaInt.Push(resta);
                                MessageBox.Show("El resultado de la resta es: " + resta + " se agrega a la pila", "Aviso");
                            }
                            else
                            {
                                val = true;
                            }
                            break;
                        case "*":
                            if (pilaInt.Count >= 2)
                            {
                                op1 = pilaInt.Pop();
                                op2 = pilaInt.Pop();
                                int mult = op1 * op2;
                                MessageBox.Show("Push(" + op2 + " * " + op1 + ")");
                                pilaInt.Push(mult);
                                MessageBox.Show("El resultado de la multiplicación es: " + mult + " se agrega a la pila", "Aviso");
                            }
                            else
                            {
                                val = true;
                            }
                            break;
                        case "/":
                            if (pilaInt.Count >= 2)
                            {
                                op1 = pilaInt.Pop();
                                op2 = pilaInt.Pop();
                                int div = op1 / op2;
                                MessageBox.Show("Push(" + op2 + " / " + op1 + ")");
                                pilaInt.Push(div);
                                MessageBox.Show("El resultado de la división es: " + div + " se agrega a la pila", "Aviso");
                            }
                            else
                            {
                                val = true;
                            }
                            break;
                        default:
                            MessageBox.Show("Caracter incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                ImprimirPila();
                if (val) break;
            }
            if (val == true)
            {
                MessageBox.Show("Error en la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pilaInt.Count == 0)
                {
                    MessageBox.Show("Error en la expresión");
                }
                else
                {
                    MessageBox.Show("El resultado es exitoso" + pilaInt.Peek());
                    lblRESULTADO.Text = "Resultado: " + pilaInt.Peek().ToString();
                }
        }
        }
        private void Limpiar()
        {
            txtEXPRESIONES.Clear();
            dgvOPERANDOS.Rows.Clear();
            txtEXPRESIONES.Focus();
        }
        private void Evaluar()
        {

                dgvOPERANDOS.Rows.Clear();
                pilaInt.Clear();
                lblRESULTADO.Text = "Resultado: ";
                string[] expresion = txtEXPRESIONES.Text.Split(' ');
                for (int i = 0; i < expresion.Length; i++)
                {
                    try
                    {
                        int operando = int.Parse(expresion[i]);
                        pilaInt.Push(operando);
                       // MessageBox.Show(expresion[i] + " Soy un operando feliz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        switch (expresion[i])
                        {
                            case "+":

                                if (pilaInt.Count >= 2)
                                {
                                    op1 = pilaInt.Pop();
                                    op2 = pilaInt.Pop();
                                    int suma = op1 + op2;
                                   // MessageBox.Show("Push(" + op2 + " + " + op1 + ")");
                                    pilaInt.Push(suma);
                                  //  MessageBox.Show("El resultado de la suma: " + suma + " se agrega a la pila", "Aviso");
                                }
                                else
                                {
                                    val = true;
                                }
                                break;
                            case "-":
                                if (pilaInt.Count >= 2)
                                {
                                    op1 = pilaInt.Pop();
                                    op2 = pilaInt.Pop();
                                    int resta = op1 - op2;
                                   // MessageBox.Show("Push(" + op2 + " - " + op1 + ")");
                                    pilaInt.Push(resta);
                                   // MessageBox.Show("El resultado de la resta es: " + resta + " se agrega a la pila", "Aviso");
                                }
                                else
                                {
                                    val = true;
                                }
                                break;
                            case "*":
                                if (pilaInt.Count >= 2)
                                {
                                    op1 = pilaInt.Pop();
                                    op2 = pilaInt.Pop();
                                    int mult = op1 * op2;
                                //    MessageBox.Show("Push(" + op2 + " * " + op1 + ")");
                                    pilaInt.Push(mult);
                                   // MessageBox.Show("El resultado de la multiplicación es: " + mult + " se agrega a la pila", "Aviso");
                                }
                                else
                                {
                                    val = true;
                                }
                                break;
                            case "/":
                                if (pilaInt.Count >= 2)
                                {
                                    op1 = pilaInt.Pop();
                                    op2 = pilaInt.Pop();
                                    int div = op1 / op2;
                                 //   MessageBox.Show("Push(" + op2 + " / " + op1 + ")");
                                    pilaInt.Push(div);
                                 //   MessageBox.Show("El resultado de la división es: " + div + " se agrega a la pila", "Aviso");
                                }
                                else
                                {
                                    val = true;
                                }
                                break;
                            default:
                                MessageBox.Show("Caracter incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    ImprimirPila();
                    if (val) break;
                }
                if (val == true)
                {
                    MessageBox.Show("Error en la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pilaInt.Count == 0)
                    {
                    MessageBox.Show("Error en la expresión");
                    }
                    else
                    {
                    MessageBox.Show("El resultado es exitoso" + pilaInt.Peek());
                    lblRESULTADO.Text = "Resultado: " + pilaInt.Peek().ToString();
                }
                }
        }
        private void btnEVALUAR_Click(object sender, EventArgs e)
        {
            Evaluar();
        }

        private void btnEJEMPLO1_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtEXPRESIONES.Text = "1 2 + 4 6 6 7 - + + +";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void EJEMPLO2_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtEXPRESIONES.Text = "1 3 - 4 6 + * 2 4 - 5 6 7 - + - + /";
        }
        private void btnPASOAPASO_Click(object sender, EventArgs e)
        {
            PasoAPaso();
        }
    }
}
