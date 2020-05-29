using HP.LFT.SDK.Web;
using HP.LFT.Report;

namespace AmericanasCompraCarrinho
{
    public class BasePage
    {
        private IBrowser browser;
        BaseMap baseMap;

        public BasePage(IBrowser browser)
        {
            this.browser = browser;
            baseMap = new BaseMap(browser);
        }

        public const int MIN_WAIT = 5;

        /// <summary>
        /// Metodo responsavel por fazer a geração de evidências dos testes que forem executados 
        /// </summary>
        /// <param name="title"></param>
        public void gerarEvidencias(string title)
        {
            ReportConfiguration r = new ReportConfiguration();
            r.IsOverrideExisting = true;
            r.Title = title;
            Reporter.Init(r);
        }
    }
}