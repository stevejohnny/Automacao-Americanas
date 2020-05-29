using HP.LFT.SDK.Web;
using HP.LFT.SDK;
using System;

namespace AmericanasCompraCarrinho
{
    public class PesquisaBuscaPage
    {
        private IBrowser browser;
        PesquisaBuscaMap pesquisaBuscaMap;

        public PesquisaBuscaPage(IBrowser browser)
        {
            this.browser = browser;
            pesquisaBuscaMap = new PesquisaBuscaMap(browser);
        }

        /// <summary>
        /// Metodo responsavel por fazer busca do produto 
        /// </summary>
        public void buscaProduto(string produto)
        {
            pesquisaBuscaMap.campoBusca().SetValue(produto);
            pesquisaBuscaMap.botaoBuscar().Click();
        }

        
        /// <summary>
        /// Metodo responsavel por am
        /// </summary>
        public void armazanaProduto(string produto)
        {
            pesquisaBuscaMap.campoBusca().SetValue(produto);
            pesquisaBuscaMap.botaoBuscar().Click();
        }

        /// <summary>
        /// Metodo responsavel por validar se as sugestões são referentes ao produto pesquisado e faz busca
        /// </summary>
        public void caixaSugestaoDeBusca(string produto)
        {
            pesquisaBuscaMap.campoBusca().SetValue(produto);
            pesquisaBuscaMap.elementSugestaoBusca().WaitUntilExists();
            pesquisaBuscaMap.campoBusca().Click();

            // string textoSugestao = pesquisaBuscaMaps.elementSugestaoBusca().InnerText();
            // if (!textoSugestao.Contains(produto))
            if (!pesquisaBuscaMap.elementSugestaoBusca().InnerText.Contains(produto))        
            {
                throw new Exception("As sujestões NÃO se referenciam ao produto pesquisado");
            }
            pesquisaBuscaMap.botaoBuscar().Click();
        }

        /// <summary>
        /// Metodo responsavel por armazena referencia do produto e seleciona-lo
        /// </summary>
        public string armazenaReferenciaProduto()
        {
            pesquisaBuscaMap.campoNomeProduto().WaitUntilVisible();
            return pesquisaBuscaMap.campoNomeProduto().InnerText;
        }

        /// <summary>
        /// Metodo responsavel por clicar no produto selecionado
        /// </summary>
        public void clicarProduto()
        {
            pesquisaBuscaMap.campoNomeProduto().Click();
            pesquisaBuscaMap.botaoComprar().WaitUntilExists();
            pesquisaBuscaMap.botaoComprar().Click();
        }
       

        /// <summary>
        /// Metodo responsavel por selecionar garantia extendida
        /// </summary>
        public void selecionaGarantia()
        {          
            pesquisaBuscaMap.campoGarantiaEstendida().WaitUntilVisible();
            pesquisaBuscaMap.campoGarantiaEstendida().Click();
            pesquisaBuscaMap.botaoContinuar().Click();
            pesquisaBuscaMap.botaoHome().WaitUntilVisible();
            pesquisaBuscaMap.botaoHome().Click();
        }

        /// <summary>
        /// Metodo responsavel por acessar "Cesto de compras"
        /// </summary>
        public void acessaCestoCompras()
        {        
            pesquisaBuscaMap.bostaoCestoCompras().WaitUntilVisible();
            pesquisaBuscaMap.bostaoCestoCompras().Click();
            pesquisaBuscaMap.bostaoVerMinhaCesta().WaitUntilExists();
            pesquisaBuscaMap.bostaoVerMinhaCesta().Click();
        }

        /// <summary>
        /// Metodo responsavel por armazena referencia do produto e seleciona-lo
        /// </summary>
        public void armazenaReferenduto(string produto)
        {
            string textoSugestao = pesquisaBuscaMap.campoNomeProduto().InnerText;
            pesquisaBuscaMap.campoNomeProduto().Click();


            if (!textoSugestao.Contains(produto))
            {
                throw new Exception("As sujestões NÃO se referenciam ao produto pesquisado");
            }

            pesquisaBuscaMap.campoBusca().SetValue(produto);
            pesquisaBuscaMap.elementSugestaoBusca().WaitUntilExists();
            pesquisaBuscaMap.elementSugestaoBusca().InnerText.Contains(produto).Equals(true);
            pesquisaBuscaMap.botaoBuscar().Click();        
        }

   }
}
