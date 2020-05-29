using HP.LFT.Common;
using HP.LFT.SDK.Web;



namespace AmericanasCompraCarrinho
{
    public class LoginMap
    {
        private IBrowser browser;
        public LoginMap(IBrowser browser)
        {
            this.browser = browser;
        }
        /// <summary>
        /// Mapeamento referente ao campo "Logar"
        /// </summary>
        /// <returns></returns>
        public ILink campoLogin()
        {
            return browser.Describe<ILink>(new LinkDescription
            {
                InnerText = @"Acesse sua conta ou cadastre-se ",
                TagName = @"A"
            });
        }
        /// <summary>
        /// Mapeamento referente ao campo "Entrar"
        /// </summary>
        /// <returns></returns>
        public ILink campoEntrar()
        {
            return browser.Describe<ILink>(new LinkDescription
            {
                InnerText = @"Entrar",
                TagName = @"A"
            });

        }
        /// <summary>
        /// Mapeamento referente ao campo "Usuario"
        /// </summary>
        /// <returns></returns>
        public IEditField campoUsuario()
        {
            return browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"email",
                TagName = @"INPUT",
                Type = @"email",
                XPath = @"//INPUT[@id=""email-input""]"
            });

        }

        /// <summary>
        /// Mapeamento referente ao campo "Senha"
        /// </summary>
        /// <returns></returns>
        public IEditField campoSenha()
        {
            return browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"password",
                TagName = @"INPUT",
                Type = @"password",
                XPath = @"//INPUT[@id=""password-input""]"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão "Entrar"
        /// </summary>
        /// <returns></returns>
        public IButton botaoEntrar()
        {
            return browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"submit",
                Name = @"Continuar",
                TagName = @"BUTTON",
                XPath = @"//BUTTON[@id=""login-button""]"
            });

        }
    } 
}
