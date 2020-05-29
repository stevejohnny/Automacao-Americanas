//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace AmericanasCompraCarrinho
//{
//    public class ReadNFeRepresadasCSV
//    {
//        string pathCSV;
//        public ReadNFeRepresadasCSV(string PathCSV)
//        {
//            this.pathCSV = PathCSV;
//            readCSVNFeRepresadas();
//        }

//        public List<string> LoteRPSAnterior { get; set; }
//        public List<string> LoteRPSNovo { get; set; }
//        public List<string> RPS { get; set; }
//        public List<string> Vencimento { get; set; }
//        public List<string> Fatura { get; set; }
//        public List<string> Valor { get; set; }
//        public List<string> Contrato { get; set; }
//        public List<string> MarcaOptica { get; set; }
//        public List<string> Status { get; set; }
//        public List<string> Emissao { get; set; }
//        public List<string> Represada { get; set; }
//        public List<string> Liberacao { get; set; }
//        public List<string> FilialFiscal { get; set; }
//        public List<string> TipoLote { get; set; }
//        public List<string> UsuarioLiberacao { get; set; }
//        public List<string> CodigoDoErro { get; set; }
//        public List<string> DescricaoDoErro { get; set; }

//        /// <summary>
//        /// Método responsável por ler o arquivo Excel baixado (Menu Faturamento/Relatorios/Relatorio NFeRepresadas -> Inserir Filtros/Botao Executar/Baixar Arquivo).
//        /// </summary>
//        public void readCSVNFeRepresadas()
//        {
//            DirectoryInfo di = new DirectoryInfo(pathCSV);
//            List<string> csvFiles = di.GetFiles("*.CSV").Where(file => file.Name.EndsWith(".CSV") &&
//                                                         file.Name.Contains("REPRESADAS"))
//                                                        .Select(file => file.Name).ToList();
//            using (var reader = new StreamReader(pathCSV+Path.DirectorySeparatorChar+csvFiles[0], Encoding.GetEncoding(28591), true))
//            {
//                List<string> LoteRPSAnterior = new List<string>();
//                List<string> LoteRPSNovo = new List<string>();
//                List<string> RPS = new List<string>();
//                List<string> Vencimento = new List<string>();
//                List<string> Fatura = new List<string>();
//                List<string> Valor = new List<string>();
//                List<string> Contrato = new List<string>();
//                List<string> MarcaOptica = new List<string>();
//                List<string> Status = new List<string>();
//                List<string> Emissao = new List<string>();
//                List<string> Represada = new List<string>();
//                List<string> Liberacao = new List<string>();
//                List<string> FilialFiscal = new List<string>();
//                List<string> TipoLote = new List<string>();
//                List<string> UsuarioLiberacao = new List<string>();
//                List<string> CodigoDoErro = new List<string>();
//                List<string> DescricaoDoErro = new List<string>();

//                while (!reader.EndOfStream)
//                {
//                    var line = reader.ReadLine();
//                    string[] values = line.Split(';');

//                    LoteRPSAnterior.Add(values[0]);
//                    LoteRPSNovo.Add(values[1]);
//                    RPS.Add(values[2]);
//                    Vencimento.Add(values[3]);
//                    Fatura.Add(values[4]);
//                    Valor.Add(values[5]);
//                    Contrato.Add(values[6]);
//                    MarcaOptica.Add(values[7]);
//                    Status.Add(values[8]);
//                    Emissao.Add(values[9]);
//                    Represada.Add(values[10]);
//                    Liberacao.Add(values[11]);
//                    FilialFiscal.Add(values[12]);
//                    TipoLote.Add(values[13]);
//                    UsuarioLiberacao.Add(values[14]);
//                    CodigoDoErro.Add(values[15]);
//                    DescricaoDoErro.Add(values[16]);
//                }

//                this.LoteRPSAnterior = LoteRPSAnterior;
//                this.LoteRPSNovo = LoteRPSNovo;
//                this.RPS = RPS;
//                this.Vencimento = Vencimento;
//                this.Fatura = Fatura;
//                this.Valor = Valor;
//                this.Contrato = Contrato;
//                this.MarcaOptica = MarcaOptica;
//                this.Status = Status;
//                this.Emissao = Emissao;
//                this.Represada = Represada;
//                this.Liberacao = Liberacao;
//                this.FilialFiscal = FilialFiscal;
//                this.TipoLote = TipoLote;
//                this.UsuarioLiberacao = UsuarioLiberacao;
//                this.CodigoDoErro = CodigoDoErro;
//                this.DescricaoDoErro = DescricaoDoErro;
//                reader.Close();
//            }
//        }

//        /// <summary>
//        /// Método responsável por excluir o arquivo Excel baixado (Menu Faturamento/Relatorios/Relatorio NFeRepresadas -> Inserir Filtros/Botao Executar/Baixar Arquivo).
//        /// Admite que o arquivo estará no mesmo diretório do projeto.
//        /// </summary>
//        public void apagaCSV()
//        {
//            DirectoryInfo di = new DirectoryInfo(pathCSV);
//            List<string> csvFiles = di.GetFiles("*.CSV").Where(file => file.Name.EndsWith(".CSV") &&
//                                             file.Name.Contains("REPRESADAS"))
//                                            .Select(file => file.Name).ToList();
//            File.Delete(pathCSV + Path.DirectorySeparatorChar + csvFiles[0]);
//        }
//    }
//}
