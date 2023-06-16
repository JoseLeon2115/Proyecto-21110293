using System.Reflection.Metadata;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double limInferior, limSuperior;
        int numTrapecios, cont=0;
        double h;
        double xIntermedias = 0;
        double xFinal = 0;
        double resFinal = 0;
        double xInicial = 0;
        static class Constans
        {
            public const double PI = 3.1416;
        }

        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            xInicial = 0;
            resFinal = 0;
            comboBox1.SelectedIndex = -1;
            xIntermedias = 0;
            xFinal = 0;
            limInferior = 0;
            limSuperior = 0;
            numTrapecios = 0;
            cont = 0;
            h = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label13.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;

            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;

            button1.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            comboBox1.Visible = false;
            label17.Visible = false;
            textBox25.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            limpiar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que s�lo se introduzcan n�meros
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                e.Handled = false;
            else
            {
                //Permitir puntos
                if (e.KeyChar == '.')
                    e.Handled = false;
                else
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que s�lo se introduzcan n�meros
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                e.Handled = false;
            else
            {
                //Permitir puntos
                if (e.KeyChar == '.')
                    e.Handled = false;
                else
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que s�lo se introduzcan n�meros
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                e.Handled = false;
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int item = comboBox1.SelectedIndex;
            if(item == -1)
            {
                MessageBox.Show("Favor de seleccionar primero una funci�n.");
                return;
            }

            double inicio = limInferior;
            label16.Visible = true;

            switch (item)
            {
                case 0:
                    for (int i = 0; i < cont; i++)
                    {
                        double res = Math.Round(Math.Cos(inicio), 4, MidpointRounding.ToEven);
                        res = Math.Round(Math.Sqrt(1 - res), 4, MidpointRounding.ToEven);

                        switch (i)
                        {
                            case 0:
                                textBox15.Visible = true;
                                textBox15.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                xInicial = Math.Round(res, 4, MidpointRounding.ToEven);
                                break;
                            case 1:
                                textBox16.Visible = true;
                                textBox16.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 2:
                                textBox17.Visible = true;
                                textBox17.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 3:
                                textBox18.Visible = true;
                                textBox18.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 4:
                                textBox19.Visible = true;
                                textBox19.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 5:
                                textBox20.Visible = true;
                                textBox20.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 6:
                                textBox21.Visible = true;
                                textBox21.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 7:
                                textBox22.Visible = true;
                                textBox22.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 8:
                                textBox23.Visible = true;
                                textBox23.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 9:
                                textBox24.Visible = true;
                                textBox24.Text = Math.Round(res, 4, MidpointRounding.ToEven).ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                        }
                        inicio += h;
                    }
                    break;
                case 1:
                    for (int i = 0; i < cont; i++)
                    {
                        //Se eleva a la potencia 3
                        double res = Math.Pow(inicio, 3);
                        //Se hace la operacion del denominador
                        double inf = 4 + inicio;
                        //Se dividen
                        res = res / inf;
                        //Se le saca raiz cuadrada
                        res = Math.Sqrt(res);
                        //Se redondea a 4 digitos
                        res = Math.Round(res, 4, MidpointRounding.ToEven);

                        switch (i)
                        {
                            case 0:
                                textBox15.Visible = true;
                                textBox15.Text = res.ToString();
                                xInicial = Math.Round(res, 4, MidpointRounding.ToEven);
                                break;
                            case 1:
                                textBox16.Visible = true;
                                textBox16.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 2:
                                textBox17.Visible = true;
                                textBox17.Text = res.ToString();
                                if (i < cont -1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 3:
                                textBox18.Visible = true;
                                textBox18.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 4:
                                textBox19.Visible = true;
                                textBox19.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 5:
                                textBox20.Visible = true;
                                textBox20.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 6:
                                textBox21.Visible = true;
                                textBox21.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 7:
                                textBox22.Visible = true;
                                textBox22.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 8:
                                textBox23.Visible = true;
                                textBox23.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 9:
                                textBox24.Visible = true;
                                textBox24.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                        }

                        inicio += h;
                    }
                    break;
                case 2:
                    for (int i = 0; i < cont; i++)
                    {
                        //Se eleva a la potencia 2 y se le suma 1
                        double inf = 1 + Math.Pow(inicio, 2);
                        //Se dividen
                        double res = 70 / inf;
                        //Se redondea a 4 digitos
                        res = Math.Round(res, 4, MidpointRounding.ToEven);

                        switch (i)
                        {
                            case 0: 
                                textBox15.Visible = true;
                                textBox15.Text = res.ToString();
                                xInicial = Math.Round(res, 4, MidpointRounding.ToEven);
                                break;
                            case 1:
                                textBox16.Visible = true;
                                textBox16.Text = res.ToString();
                                if(i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 2:
                                textBox17.Visible = true;
                                textBox17.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 3:
                                textBox18.Visible = true;
                                textBox18.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 4:
                                textBox19.Visible = true;
                                textBox19.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 5:
                                textBox20.Visible = true;
                                textBox20.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 6:
                                textBox21.Visible = true;
                                textBox21.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 7:
                                textBox22.Visible = true;
                                textBox22.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 8:
                                textBox23.Visible = true;
                                textBox23.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                            case 9:
                                textBox24.Visible = true;
                                textBox24.Text = res.ToString();
                                if (i < cont - 1)
                                {
                                    xIntermedias += Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                else
                                {
                                    xFinal = Math.Round(res, 4, MidpointRounding.ToEven);
                                }
                                break;
                        }

                        inicio += h;
                    }
                    break;
            }
            //C�lculo final
            label17.Visible = true;
            textBox25.Visible = true;
            //Se multiplica la suma de las x internas por 2
            resFinal = 2 * xIntermedias;
            //Se suman al resultado la Xinicial y la Xfinal
            resFinal += xInicial + xFinal;
            //Se multiplica por h/2
            resFinal = Math.Round((h / 2) * resFinal, 4, MidpointRounding.ToEven);
            //Se pinta el resultado final
            textBox25.Text = resFinal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool res;
            res = double.TryParse(textBox1.Text, out limInferior);
            if(!res)
            {
                MessageBox.Show("No s� puede continuar por que el l�mite inferior no es un n�mero.");
                return;
            }

            res = double.TryParse(textBox2.Text, out limSuperior);
            if(!res)
            {
                MessageBox.Show("No s� puede continuar por que el l�mite superior no es un n�mero.");
                return;
            }

            res = int.TryParse(textBox3.Text, out numTrapecios);
            if (!res)
            {
                MessageBox.Show("No s� puede continuar por que 'n' no es un entero.");
                return;
            }

            if (limSuperior <= limInferior)
            {
                MessageBox.Show("No s� puede continuar por que el l�mite inferior es mayor al l�mite superior.");
                return;
            }

            //Calculando h
            h = (limSuperior - limInferior);
            h = h / numTrapecios;
            label14.Visible = true;
            textBox14.Visible = true;
            textBox14.Text = h.ToString();

            //Calculando x's
            double vActual = limInferior;
            do
            {
                switch (cont)
                {
                    case 0:
                        label4.Visible = true;
                        textBox4.Visible = true;
                        textBox4.Text = vActual.ToString();
                        break;
                    case 1:
                        label5.Visible = true;
                        textBox5.Visible = true;
                        textBox5.Text = vActual.ToString();
                        break;
                    case 2:
                        label6.Visible = true;
                        textBox6.Visible = true;
                        textBox6.Text = vActual.ToString();
                        break;
                    case 3:
                        label7.Visible = true;
                        textBox7.Visible = true;
                        textBox7.Text = vActual.ToString();
                        break;
                    case 4:
                        label8.Visible = true;
                        textBox8.Visible = true;
                        textBox8.Text = vActual.ToString();
                        break;
                    case 5:
                        label9.Visible = true;
                        textBox9.Visible = true;
                        textBox9.Text = vActual.ToString();
                        break;
                    case 6:
                        label10.Visible = true;
                        textBox10.Visible = true;
                        textBox10.Text = vActual.ToString();
                        break;
                    case 7:
                        label11.Visible = true;
                        textBox11.Visible = true;
                        textBox11.Text = vActual.ToString();
                        break;
                    case 8:
                        label12.Visible = true;
                        textBox12.Visible = true;
                        textBox12.Text = vActual.ToString();
                        break;
                    case 9:
                        label13.Visible = true;
                        textBox13.Visible = true;
                        textBox13.Text = vActual.ToString();
                        break;
                }

                cont++;
                vActual = Math.Round(vActual + h, 4, MidpointRounding.ToEven);
                if(cont == 10)
                {
                    MessageBox.Show("No puedo con tantas 'X's' toi chiquito.");
                    return;
                }
            } while (vActual <= limSuperior);
            button1.Visible = true;
            label15.Visible = true;
            comboBox1.Visible = true;
        }
    }
}