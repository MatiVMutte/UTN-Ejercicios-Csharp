using Billetes;
using System.Drawing;

namespace C01CotizadorDesktop
{
    public partial class Form1 : Form
    {
        Dolar dolar;
        Peso peso;
        Euro euro;
        bool actBotonCotizacion;
        public Form1() {
            InitializeComponent();
            actBotonCotizacion = false;
        }

        private bool ConvertDoubleFromString(string cadena, out double valor) {
            cadena = cadena.Replace('.', ',');
            return double.TryParse(cadena.Trim(), out valor);
        }

        private void BloquearBtnCotizacion() {
            txtCotizaEuroDolar.ReadOnly = true;
            txtCotizaPesoDolar.ReadOnly = true;
            txtCotizaEuroDolar.TextAlign = HorizontalAlignment.Center;
            txtCotizaPesoDolar.TextAlign = HorizontalAlignment.Center;
            btnEuroA.Enabled = true;
            btnDolarA.Enabled = true;
            btnPesoA.Enabled = true;
            btnBlockCotizacion.BackgroundImage = Resources.Imagenes.candado_cerrado;
            btnBlockCotizacion.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void DesbloquearBtnCotizacion() {
            txtCotizaEuroDolar.ReadOnly = false;
            txtCotizaPesoDolar.ReadOnly = false;
            txtCotizaEuroDolar.TextAlign = HorizontalAlignment.Left;
            txtCotizaPesoDolar.TextAlign = HorizontalAlignment.Left;
            btnEuroA.Enabled = false;
            btnDolarA.Enabled = false;
            btnPesoA.Enabled = false;
            btnBlockCotizacion.BackgroundImage = Resources.Imagenes.candado_abierto;
            btnBlockCotizacion.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnBlockCotizacion_Click(object sender, EventArgs e) {
            bool todoOK = false;
            bool sePudoConvertirEuro;
            bool sePudoConvertirPeso;
            double cotizacionEuro;
            double cotizacionPeso;
            String mensaje = "Faltan llenar campos";

            actBotonCotizacion = !actBotonCotizacion;
            if (actBotonCotizacion) {
                if (txtCotizaEuroDolar.Text != "" && txtCotizaPesoDolar.Text != "") {
                    mensaje = "Tiene que ser un numero mayor a 0";
                    sePudoConvertirEuro = ConvertDoubleFromString(txtCotizaEuroDolar.Text, out cotizacionEuro);
                    sePudoConvertirPeso = ConvertDoubleFromString(txtCotizaPesoDolar.Text, out cotizacionPeso);
                    if (sePudoConvertirEuro && sePudoConvertirPeso && cotizacionEuro > 0 && cotizacionPeso > 0) {
                        BloquearBtnCotizacion();
                        euro = new Euro(0, cotizacionEuro);
                        peso = new Peso(0, cotizacionPeso);
                        todoOK = true;
                    }
                }

                if (!todoOK) {
                    actBotonCotizacion = !actBotonCotizacion;
                    MessageBox.Show(mensaje);
                }
            } else {
                DesbloquearBtnCotizacion();
            }
        }

        private void btnEuroA_Click(object sender, EventArgs e) {
            double euroIngresado;
            if (txtConvertEuroA.Text != "") {
                if (ConvertDoubleFromString(txtConvertEuroA.Text, out euroIngresado)) {
                    euro = euroIngresado;

                    txtEuroConvertEuro.Text = euro.Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtEuroConvertDolar.Text = ((Dolar)euro).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtEuroConvertPeso.Text = ((Peso)euro).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                }

            }
        }

        private void btnDolarA_Click(object sender, EventArgs e) {
            double dolarIngresado;
            if (txtConvertDolarA.Text != "") {
                if (ConvertDoubleFromString(txtConvertDolarA.Text, out dolarIngresado)) {
                    dolar = dolarIngresado;

                    txtDolarConvertEuro.Text = ((Euro)dolar).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtDolarConvertDolar.Text = dolar.Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtDolarConvertPeso.Text = ((Peso)dolar).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                }

            }
        }

        private void btnPesoA_Click(object sender, EventArgs e) {
            double pesoIngresado;
            if (txtConvertPesoA.Text != "") {
                if (ConvertDoubleFromString(txtConvertPesoA.Text, out pesoIngresado)) {
                    peso = pesoIngresado;

                    txtPesoConvertEuro.Text = ((Euro)peso).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtPesoConvertDolar.Text = ((Dolar)peso).Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                    txtPesoConvertPeso.Text = peso.Cantidad.ToString("N4").TrimEnd('0').TrimEnd(',').Replace(',', '.');
                }

            }
        }
    }
}