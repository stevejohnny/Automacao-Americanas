using HP.LFT.SDK;
using HP.LFT.SDK.Web;


namespace AmericanasCompraCarrinho
{
    public class LoginPage
    {
        private IBrowser browser;
        LoginMap loginMap;

        public LoginPage(IBrowser browser)
        {
            this.browser = browser;
            loginMap = new LoginMap(browser);
        }

        /// <summary>
        /// Metodo responsavel por realizar o login no SisAmil
        /// </summary>
        /// <param name="usuario">Nome do usuario</param>
        /// <param name="senha">Senha para login</param>
        public void loginSisAmil(string usuario, string senha)
        {
            loginMap.campoLogin().WaitUntilExists();
            loginMap.campoLogin().Click();
            loginMap.campoEntrar().Click();

            loginMap.campoUsuario().SetValue(usuario);
            loginMap.campoSenha().SetValue(senha);
            loginMap.botaoEntrar().Click();
        }
    }
}
