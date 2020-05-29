using HP.LFT.Report;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AmericanasCompraCarrinho
{
    [TestClass]
    public class UI001_Adiciona_Compra_Carrinho
    {
        [TestMethod]
        public void UI01_Adiciona_Compra_Carrinho()
        {
            SDK.Init(new SdkConfiguration());
            Reporter.Init(new ReportConfiguration());
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

            // CLASSES A SEREM UTILIZADAS
           // var basePage = new BasePage(browser);
            var loginPage = new LoginPage(browser);          
            var pesquisaBuscaPage = new PesquisaBuscaPage(browser);
            var dados = new Dados();
            var basePage = new BasePage(browser);

            // VARIAVEIS DE APOIO
            string produto = "celulares";
            string produtoSelecionado;

            //INICIO DO FLUXO DO CASO DE TESTE

            browser.Navigate(dados.UrlAmericanasPageInicial);
            basePage.gerarEvidencias("UI001");
            loginPage.loginSisAmil(dados.Username, dados.Senha);


            //VALIDAR SUSGESTÃO REFERENTE À BUSCA
            pesquisaBuscaPage.caixaSugestaoDeBusca(produto);

            //SELECIONA PRODUTO E ARMAZENA REFERENCIA
            produtoSelecionado = pesquisaBuscaPage.armazenaReferenciaProduto(); //armazena a descrição do produto para comparar replicação correta em "Cesto de compras"
            pesquisaBuscaPage.clicarProduto();

            //SELECIONA GARANTIA EXTENDIDA 
            pesquisaBuscaPage.selecionaGarantia();

            //ACESSAR CESTO DE COMPRAS
            pesquisaBuscaPage.acessaCestoCompras();

            //FIM DO FLUXO DO CASO DE TESTE
            browser.Close();
            Reporter.GenerateReport();
            SDK.Cleanup();
        }
    }
}
