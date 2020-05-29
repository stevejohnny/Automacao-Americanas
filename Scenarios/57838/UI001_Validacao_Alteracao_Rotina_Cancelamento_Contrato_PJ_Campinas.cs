using HP.LFT.Report;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPSCampinasFrontEnd
{
    [TestClass]
    public class UI001_Validacao_Alteracao_Rotina_Cancelamento_Contrato_PJ_Campinas
    {
        [TestMethod]
        public void UI01_Validacao_Alteracao_Rotina_Cancelamento_Contrato_PJ_Campinas()
        {
            SDK.Init(new SdkConfiguration());
            Reporter.Init(new ReportConfiguration());
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

            // CLASSES A SEREM UTILIZADAS
            var basePage = new BasePage(browser);
            var loginPage = new LoginPage(browser);
            var menuPage = new MenuPage(browser);
            var atendimentoContratoPage = new AtendimentoContratoPage(browser);
            var processaFaturamentoPage = new ProcessaFaturamentoPage(browser);
            var gerarArquivoRpsPage = new GerarArquivoRpsPage(browser);
            var cadastroFilialFiscalPage = new CadastroFilialFiscalPage(browser);
            var dados = new US57839();
            var dadosQueryBD = new DadosQuerysBD();
            var executaOperacoesBD = new ExecutaOperacoesBD();
            var connectionDataBase = new ConnectionDataBase(dadosQueryBD.HostStringConnectionQA4, dadosQueryBD.PortStringConnection,
                dadosQueryBD.ServiceQA8StringConnectionQA4, dadosQueryBD.UserStringConnectionHumberto, dadosQueryBD.PasswordStringConnectionHumberto);
            string DataFatura;
            string valueInputUltimoNumero;

            //INICIO DO FLUXO DO CASO DE TESTE
            browser.Navigate(dados.UrlQA4);
            basePage.gerarEvidencias("UI002");
            loginPage.loginSisAmil(dados.Username, dados.Senha);

            // ACESSAR SUBMENU FILIAL FISCAL - ESTRUTURA ORGANIZACIONAL / CADASTRO FILIAL FISCAL
            menuPage.acessarCadastroFilialFiscal();

            //PREENCHER SELECTS TELA CADASTRO FILIAL FISCAL
            cadastroFilialFiscalPage.preencherSelectsOperadoraFilialFiscal(dados.OperadoraAmil, dados.FilialFiscalCampinas);

            //MUDA CAMPOS "TIPO LAYOUT DE ARQUIVO NFE" -> "PREFEITURA"  //  "TIPO DE CONTRATO NFE" -> "PESSOA JURÍDICA"  //  "TIPO NUMERAÇÃO RPS(PF / PJ)" -> "PROPRIA"  //  PEGA O TEXT DO IMPUT "ÚLTIMO NÚMERO"
            cadastroFilialFiscalPage.selecionaRadioCampoTipoLayoutArquivoNFE("Prefeitura");
            cadastroFilialFiscalPage.selecionaRadioTipoContratoNFEPJ();
            cadastroFilialFiscalPage.selecionaRadioNumeracaoRPSCNPJPFPropria();
            valueInputUltimoNumero = cadastroFilialFiscalPage.getTextInputUltimoNumero();

            // FLUXO MENU ATENDIMENTO CONTRATO/ATENDIMENTO PARA PEGAR OS DADOS DE MES/ANO
            menuPage.acessarAtendimentoContrato();
            menuPage.subMenuAtendimento2();

            atendimentoContratoPage.preencherNumeroContrato(dados.Contrato7);
            atendimentoContratoPage.clicarIconeContinuar();
            atendimentoContratoPage.acessarSubMenuCadeiaPgEso();
            DataFatura = atendimentoContratoPage.getTextPrimeiroLinkMens();

            //FLUXO MENU FATURAMENTO/ITENS DE COBRANÇA/PROCESSAR
            menuPage.acessarMenuProcessarFaturamento();
            processaFaturamentoPage.preencheContratoParaProcessar(dados.Contrato7);
            processaFaturamentoPage.preencheCamposAdicionais(DataFatura);
            processaFaturamentoPage.verificaFaturamentoSucesso();

            //FLUXO MENU FATURAMENTO/NOTA FISCAL ELETRONICA/GERAR ARQUIVO RPS
            menuPage.acessarSubMenuGerarArquivoRPS();
            gerarArquivoRpsPage.preencheContratoParaProcessar(dados.Contrato7);
            gerarArquivoRpsPage.clicaBotaoExecutar();
            gerarArquivoRpsPage.verificaFaturamentoSucesso();

            //FLUXO MENU FATURAMENTO/NOTA FISCAL ELETRONICA/CONSULTA LOTE RPS
            menuPage.acessarSubMenuConsultaLotaRPS();
            gerarArquivoRpsPage.preencherSelectsTelaConsultaLoteRPS();
            gerarArquivoRpsPage.verificaUltimaLinhaInserida();
            gerarArquivoRpsPage.getUltimoCodLoteRPSInserido();

            //REPRESA O LOTE / EXECUTA SCRIPT PASSANDO O LOTE GERADO
            executaOperacoesBD.represaLote(gerarArquivoRpsPage.CodRPS);

            //CONTINUAR

            //FIM DO FLUXO DO CASO DE TESTE
            browser.Close();
            Reporter.GenerateReport();
            SDK.Cleanup();

        }
    }
}
