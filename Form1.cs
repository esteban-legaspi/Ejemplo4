namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        /* Una empresa de paqueteria desea realizar un programa que le permita calcular el costo de envio de un paquete.
          Las tarifas de envio son las siguientes:
          Envios nacionales: 
            Paquetes de hasta 1 kg: 50.
            Paquetes de hasta 5 kg: 40/kg.
            Paquetes de mas de 5 kg: 30/kg.
           
          
         Envios internacionales: 
               paquetes de hasta 1 kg: 100
                paquetes de hasta 5 kg: 90/kg
                paquetes de hasta 10 kg: 80/kg
                paquetes de mas de 10 kg: 150/kg
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Tarificador tarificador = new Tarificador();
            float peso = float.Parse(txtPesoPaquete.Text);
            String? tipoEnvio = "";
            float costoEnvio = 0.0f;
            float impuestos = 0.0f;
            float costoTotal = 0.0f;
            if (cmboxTipoDestino.SelectedItem != null) 
            {
                tipoEnvio = cmboxTipoDestino.SelectedItem.ToString();
                if (tipoEnvio == "Nacional")
                {
                    costoEnvio = tarificador.CalcularCostoEnvioNacional(peso);
                }
                else if (tipoEnvio == "Internacional")
                {
                    costoEnvio = tarificador.CalcularCostoEnvioInternacional(peso);
                }
                impuestos = tarificador.CalcularIVA(costoEnvio);
                costoTotal = costoEnvio + impuestos;
                lblCostoFlete.Text = costoEnvio.ToString("C");
                lblIVA.Text = impuestos.ToString("C");
                lblTotal.Text = costoTotal.ToString("C");
            }


        }
    }
}
