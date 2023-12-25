namespace iCalc
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char op;
        public Form1()
        {
            this.BackColor = Color.Black;
            InitializeComponent();
        }
        private void agregar_numero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (tbResult.Text == "0")
            {
                tbResult.Text = boton.Text;
            }
            else
            {
                tbResult.Text += boton.Text;
            }
        }
        private void Operador_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(tbResult.Text);
            op = Convert.ToChar(boton.Tag);

            tbResult.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tbResult.Text);
            if (op == '+')
            {
                tbResult.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(tbResult.Text);
            }
            else if (op == '-')
            {
                tbResult.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(tbResult.Text);
            }
            else if (op == 'X')
            {
                tbResult.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(tbResult.Text);
            }
            else if (op == '/')
            {
                if (tbResult.Text != "0")
                {
                    tbResult.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(tbResult.Text);
                }
                else
                {
                    MessageBox.Show("No es posible dividir por 0.");
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Length > 1)
            {
                tbResult.Text = tbResult.Text.Substring(0, tbResult.Text.Length - 1);
            }
            else
            {
                tbResult.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = '\0';
            tbResult.Text = "0";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!tbResult.Text.Contains(','))
            {
                tbResult.Text += ",";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbResult.Text);
            num1 *= -1;
            tbResult.Text = num1.ToString();
        }
    }
}
