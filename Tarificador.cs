using System;
using System.Collections.Generic;
using System.Text;

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

namespace Ejemplo4
{
    internal class Tarificador
    {
       public float CalcularCostoEnvioNacional (float peso)
        {
            float envio = 0;

            if (peso <= 1) {
                envio = 50.00f;
            }
            else if (peso <= 5)
            {
                envio = peso * 40.00f;
            }
            else
            {
                envio = peso * 30.00f;
            }
            return envio;
        }

        public float CalcularCostoEnvioInternacional(float peso)
        {
            float envio = 0;
            if (peso <= 1)
            {
                envio = 100.00f;
            }
            else if (peso <= 5)
            {
                envio = peso * 90.00f;
            }
            else if (peso <= 10)
            {
                envio = peso * 80.00f;
            }
            else
            {
                envio = peso * 150.00f;
            }
            return envio;
        }

        public float CalcularIVA(float costo)
        {
            const float IVA = 0.16f;
            return costo * IVA;
        } 
    }
}
