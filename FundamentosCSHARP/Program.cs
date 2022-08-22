using System;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();

            //insertamos nuevos datos
            /*{
                Cerveza cerveza = new Cerveza(15, "Red Ipa");
                cerveza.Marca = "Lupita";
                cerveza.Alcohol = 5;
                cervezaBD.Add(cerveza);

            }*/
            {

                cervezaBD.Delete(3);
            }
                //obtenemos las cervezas de la BD
                var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }

        }
    }

}