using HP.LFT.SDK.Web;

namespace AmericanasCompraCarrinho
{
    public class Dados
    {
        private string username = "yavoxab530@ximtyl.com";
        public string Username { get { return username; } }

        private string senha = "senhaAmericanas";
        public string Senha { get { return senha; } }

        public string UrlAmericanasPageInicial { get { return urlAmericanasPageInicial; } }

        private string urlAmericanasPageInicial = "https://www.americanas.com.br/";             
       
        public Dados() { } 
    }
}
