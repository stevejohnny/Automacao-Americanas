using System;
using HP.LFT.Common;
using HP.LFT.SDK.Web;



namespace AmericanasCompraCarrinho
{
    public class PesquisaBuscaMap
    {
        private IBrowser browser;
        public PesquisaBuscaMap(IBrowser browser)
        {
            this.browser = browser;
        }


        /// <summary>
        /// Mapeamento referente ao campo "Logar"
        /// </summary>
        /// <returns></returns>
        public IEditField campoBusca()
        {
            return browser.Describe<IEditField>(new EditFieldDescription
            {
                CSSSelector = @"input#h_search-input",
                Name = @"conteudo",
                TagName = @"INPUT",
                Type = @"text"
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
        //public IButton botaoEntrar()
        //{
        //    return browser.Describe<IButton>(new ButtonDescription
        //    {
        //        ButtonType = @"submit",
        //        Name = @"Continuar",
        //        TagName = @"BUTTON",
        //        XPath = @"//BUTTON[@id=""login-button""]"
        //    });

        //}

        /// <summary>
        /// Mapeamento referente ao botão "Continuar"
        /// </summary>
        /// <returns></returns>
        public IWebElement botaoContinuar()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                ClassName = @"Wrapper-sc-1i9za0i-3 eNRfkt ViewUI-sc-1ijittn-6 iXIDWU",
                InnerText = @"Continuar",
                TagName = @"DIV"
            });

        }


        /// <summary>
        /// Mapeamento referente ao botão "Buscar"
        /// </summary>
        /// <returns></returns>
        public IButton botaoBuscar()
        {
            return browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"submit",
                Name = @"Buscar",
                TagName = @"BUTTON",
                XPath = @"//BUTTON[@id=""h_search-btn""]"
            });
        }
   
        
        /// <summary>
        /// Mapeamento referente ao botão "Comprar"
        /// </summary>
        /// <returns></returns>
        public IWebElement botaoComprar()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                ClassName = @"Wrapper-sc-1i9za0i-3 hyuQAM ViewUI-sc-1ijittn-6 iXIDWU",
                InnerText = @"Comprar",
                TagName = @"DIV"
            });
        }


        /// <summary>
        /// Mapeamento referente à caixa de sujestão de produtos
        /// </summary>
        /// <returns></returns>
        public IWebElement elementSugestaoBusca()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                //InnerText = @"Você quis dizer:celulares celulares samsung celulares motorola celulares xiaomi celulares usados celulares lg celulares da samsung ",
                TagName = @"DIV",
                XPath = @"//DIV[@id=""h_search""]/DIV[1]/DIV[1]"
            });
        }


        /// <summary>
        /// Mapeamento referente ao campo nome do produto
        /// </summary>
        /// <returns></returns>
        public IWebElement campoNomeProduto()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                AccessibilityName = string.Empty,
                ClassName = @"TitleUI-bwhjk3-15 khKJTM TitleH2-sc-1wh9e1x-1 gYIWNc",
                Index = 0,
                TagName = @"H2",
                XPath = @"//DIV[@id=""content-middle""]/DIV[6]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/DIV[2]/A[1]/SECTION[1]/DIV[2]/DIV[1]/H2[1]"
            });
        }


        /// <summary>
        /// Mapeamento referente ao campo garantia extendida
        /// </summary>
        /// <returns></returns>
        public IWebElement campoGarantiaEstendida()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"+ 12 mesespor 12x de R$ 8,77sem juros",
                TagName = @"LABEL",
                XPath = @"//DIV[@id=""content""]/DIV[1]/DIV[1]/MAIN[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/DIV[1]/DIV[2]/DIV[1]/DIV[2]/DIV[1]/DIV[2]/DIV[1]/DIV[1]/DIV[1]/LABEL[1]"
            });
        }


        /// <summary>
        /// Mapeamento referente ao campo Home page
        /// </summary>
        /// <returns></returns>
        public IWebElement botaoHome()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                ClassName = @"brd-logo logo",
                InnerText = @"Americanas",
                TagName = @"svg"
            });
        }


        /// <summary>
        /// Mapeamento referente ao campo "Cesto de compras"
        /// </summary>
        /// <returns></returns>
        public IWebElement bostaoCestoCompras()
        {
            return browser.Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"acesse sua cesta",
                TagName = @"svg"
            });
        }
        public ILink bostaoVerMinhaCesta()
        {
            return browser.Describe<ILink>(new LinkDescription
            {
                InnerText = @"ver minha cesta",
                TagName = @"A"
            });
        }
    }
}
