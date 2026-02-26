namespace ExamenU1_ISR
{
    public partial class frmIsr : Form
    {
        //variables globales para almacenar los valores necesarios para el calculo del ISR
        double cuotaFija, limiteInferior, porcentajeExcedente, isr, sueldoNeto;

        public frmIsr()
        {
            //inicializar variables
            InitializeComponent();
            cuotaFija = 0;
            limiteInferior = 0;
            porcentajeExcedente = 0;
            isr = 0;
            sueldoNeto = 0;
        }


        //la peor funcion que he escrito en mi vida, pero es la unica forma que se me ocurrio para definir el rango del sueldo y calcular el ISR
        //hasta el autocompletado subo lo que iba a decir
        public void calcular(double sueldo)
        {
            if (sueldo < 746.04)
            {
                limiteInferior = 0.01;
                cuotaFija = 0.00;
                porcentajeExcedente = 0.0192;
            }
            else if (sueldo >= 746.05 && sueldo <= 6332.05)
            {
                limiteInferior = 746.05;
                cuotaFija = 14.32;
                porcentajeExcedente = 0.064;
            }
            else if (sueldo >= 6332.06 && sueldo <= 11128.01)
            {
                limiteInferior = 6332.06;
                cuotaFija = 371.83;
                porcentajeExcedente = 0.1088;
            }
            else if (sueldo >= 11128.02 && sueldo <= 12935.82)
            {
                limiteInferior = 11128.02;
                cuotaFija = 893.63;
                porcentajeExcedente = 0.16;
            }
            else if (sueldo >= 12935.83 && sueldo <= 15487.71)
            {
                limiteInferior = 12935.83;
                cuotaFija = 1318.26;
                porcentajeExcedente = 0.1792;
            }
            else if (sueldo >= 15487.72 && sueldo <= 31236.49)
            {
                limiteInferior = 15487.72;
                cuotaFija = 1972.12;
                porcentajeExcedente = 0.2136;
            }
            else if (sueldo >= 31236.50 && sueldo <= 49233.00)
            {
                limiteInferior = 31236.50;
                cuotaFija = 5850.76;
                porcentajeExcedente = 0.2352;
            }
            else if (sueldo >= 49233.01 && sueldo <= 93993.90)
            {
                limiteInferior = 49233.01;
                cuotaFija = 10837.02;
                porcentajeExcedente = 0.3;
            }
            else if (sueldo >= 93993.91 && sueldo <= 125325.20)
            {
                limiteInferior = 93993.91;
                cuotaFija = 26177.04;
                porcentajeExcedente = 0.32;
            }
            else if (sueldo >= 125325.21 && sueldo <= 375975.61)
            {
                limiteInferior = 125325.21;
                cuotaFija = 38243.68;
                porcentajeExcedente = 0.34;
            }
            else
            {
                limiteInferior = 375975.62;
                cuotaFija = 142119.38;
                porcentajeExcedente = 0.35;
            }
            //calculos
            isr = cuotaFija + ((sueldo - limiteInferior) * porcentajeExcedente);
            sueldoNeto = sueldo - isr;
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //try-catch para validar que ingrese un valor numerico
            try
            {
                //recibir el sueldo mensual mediante el TextBox y convertirlo a double
                double sueldoMensual = Convert.ToDouble(this.txtSueldo.Text);
                //verificar si el sueldo es menor a 0 y menor al rango maximo de Double
                if (sueldoMensual < 0 || sueldoMensual > Double.MaxValue)
                    MessageBox.Show("El sueldo debe ser  mayor a 0 y estar dentro de los limites numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mandar a llamar a la peor funcion de la historia para calcular el ISR y el sueldo neto, y mostrar los resultados en los TextBox correspondientes
                else
                {
                    calcular(sueldoMensual);
                    //mostrar los resultados redondeando los decimales
                    this.txtIsrCalc.Text = Double.Round(isr, 2).ToString();
                    this.txtSueldoNeto.Text = Double.Round(sueldoNeto, 2).ToString();

                }
                //mensaje de error
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un valor numerico valido para el sueldo mensual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Habilitar el boton de calcular cuando se ingrese un valor en el TextBox del sueldo
        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            this.btnCalcular.Enabled = true;
            reiniciar();
        }

        //salir del programa 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void reiniciar()
        {
            this.txtSueldoNeto.Text = "";
            this.txtIsrCalc.Text = "";

        }

        //reiniciar los TextBox y deshabilitar el boton de calcular
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
            this.btnCalcular.Enabled = false;
            this.txtSueldo.Text = "";
        }
    }
}
