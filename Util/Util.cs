using HP.LFT.SDK.Web;
using System;

namespace AmericanasCompraCarrinho
{
    public class Util
    {
        public Util() { }

            public string calculaProximoMesAno(string atualMesAno) {
                int mes = Int16.Parse(atualMesAno.Substring(0, 2));
                int ano = Int16.Parse(atualMesAno.Substring(3, 4));
                mes++;
                if (mes == 13) {
                    mes = 01;
                    ano++;
                }
                string mesString = mes.ToString();
                if (mesString.Length == 1) {
                    mesString = "0" + mesString;
                }
                return mesString + "/" + ano.ToString();
            }

            public string manipulaDatasFaturamentoTeste(string ultimaDataFatura)
            {
                DateTime dataAntiga = Convert.ToDateTime(ultimaDataFatura);
                DateTime dataNova = dataAntiga.AddMonths(1);
                return dataNova.ToString("MM/yyyy");
            } 
    }
}
