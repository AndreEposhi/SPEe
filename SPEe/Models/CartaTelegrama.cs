using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPEe.Models
{
    public class CartaTelegrama
    {
        #region Propriedades

        /// <summary>
        /// Tipo de Registro: 0 (zero). Identificação do Arquivo
        /// </summary>
        public IdentificacaoRegistro IdentificacaoRegistro { get; set; }

        /// <summary>
        ///  Coleção do Tipo de Registro: 1 (um). Dados do Telegrama e do Remetente
        /// </summary>
        public IList<TelegramaRemetente> TelegramaRemetentes { get; set; }

        /// <summary>
        /// Coleção do Tipo de Registro: 4 (quatro). Dados da Carta e do Remetente
        /// </summary>
        public IList<CartaRemetente> CartaRemetentes { get; set; }

        #endregion Propriedades

        #region Construtor

        /// <summary>
        /// Instancia a classe e inicialoza as variáveis
        /// </summary>
        public CartaTelegrama()
        {
            TelegramaRemetentes = new List<TelegramaRemetente>();
            CartaRemetentes = new List<CartaRemetente>();
        }

        #endregion Construtor

        #region Métodos

        /// <summary>
        /// Gera o arquivo texto de telegrama ou carta
        /// </summary>
        public void Gerar()
        {
            try
            {
                if (!Directory.Exists(@"C:\Temp"))
                    Directory.CreateDirectory(@"C:\Temp");

                using (var file = new StreamWriter($@"C:\Temp\Arq{DateTime.Now.ToString("ddMMyyyyHHmmss")}.txt"))
                {
                    file.WriteLine(IdentificacaoRegistro.VersaoLayout == null ?
                        IdentificacaoRegistro.Tipo + ";" + IdentificacaoRegistro.DadoGeracaoArquivo :
                        IdentificacaoRegistro.Tipo + ";" + IdentificacaoRegistro.DadoGeracaoArquivo + ";" +
                        IdentificacaoRegistro.VersaoLayout);

                    foreach (var telegramaRemente in TelegramaRemetentes)
                        file.WriteLine(GerarRegistroTipo1(telegramaRemente));

                    foreach (var cartaRementente in CartaRemetentes)
                        file.WriteLine(GerarRegistroTipo4(cartaRementente));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu o seguinte erro ao gerar o arquivo: {ex.Message}");
            }
        }

        /// <summary>
        /// Gera o registro do tipo 1
        /// </summary>
        /// <param name="value">Informações do remetente do telegrama</param>
        /// <returns></returns>
        private StringBuilder GerarRegistroTipo1(TelegramaRemetente value)
        {
            var result = new StringBuilder();

            result.Append(value.Tipo + ";");
            result.Append(value.OID + ";");
            result.Append(value.Assunto == null ? " " + ";" : value.Assunto + ";");
            result.Append(value.OIDRemetente + ";");
            result.Append(value.Nominal.Apelido == null ? " " + ";" : value.Nominal.Apelido + ";");
            result.Append(value.Nominal.Titulo == null ? " " + ";" : value.Nominal.Titulo + ";");
            result.Append(value.Nominal.Nome + ";");
            result.Append(value.Endereco.CEP + ";");
            result.Append(value.Endereco.Logradouro + ";");
            result.Append(value.Endereco.Numero + ";");
            result.Append(value.Endereco.Complemento == null ? " " + ";" : value.Endereco.Complemento + ";");
            result.Append(value.Endereco.Bairro == null ? " " : value.Endereco.Bairro + ";");
            result.Append(value.Endereco.Cidade + ";");
            result.Append(value.Endereco.UF + ";");
            result.Append(value.Telefone.DDD == null ? " " + ";" : value.Telefone.DDD + ";");
            result.Append(value.Telefone.Numero == null ? " " + ";" : value.Telefone.Numero + ";");
            result.Append(value.Email == null ? " " + ";" : value.Email + ";");
            result.Append(value.NumeralZero + ";");
            result.Append(value.Telefone.DDDFax == null ? " " + ";" : value.Telefone.DDDFax + ";");
            result.Append(value.Telefone.NumeroFax == null ? " " + ";" : value.Telefone.NumeroFax + ";");
            result.Append(value.Endereco.CEPCxPostal == null ? " " + ";" : value.Endereco.CEPCxPostal + ";");
            result.Append(value.Endereco.CaixaPostal == null ? " " + ";" : value.Endereco.CaixaPostal + ";");
            result.Append(value.LiteralN + ";");
            result.Append(value.DataEnvio == null ? " " + ";" : value.DataEnvio?.ToString("dd/MM/yyyy") + ";");
            result.Append(value.DataCadastro.ToString("dd/MM/yyyy") + ";");
            result.Append(value.NumeralZero + ";");
            result.Append(value.NumeralUm + ";");
            result.Append(value.SRVCC == null ? " " + ";" : value.SRVCC + ";");
            result.Append(value.SRVPC == null ? " " + ";" : value.SRVPC + ";");
            result.Append(value.SRVPD == null ? " " + ";" : value.SRVPD + ";");
            result.Append(value.SRVPH == null ? " " + ";" : value.SRVPH + ";");
            result.Append(value.SRVDH == null ? " " + ";" : value.SRVDH + ";");
            result.Append(value.DataPredatado == null ? " " + ";" : value.DataPredatado?.ToString("dd/MM/yyyy HH:mm:ss") + ";");
            result.Append(value.ImgemCabecalho == null ? " " + ";" : value.ImgemCabecalho + ";");
            result.Append(value.ImagemRodape == null ? " " + ";" : value.ImagemRodape + ";");
            result.Append(value.RetornoServico == null ? " " + ";" : value.RetornoServico + ";");
            result.Append(value.NumeralZero + ";");
            result.Append(value.Usuario == null ? " " + ";" : value.Usuario + ";");
            result.Append(" ;");
            result.Append(value.LiteralBR + ";");
            result.Append(" ;");
            result.Append(" ;");
            result.Append(value.LiteralN + ";");
            result.Append(" ;");
            result.Append(" ;");
            result.Append(value.Internacional == true ? 1 : 0);

            result.AppendLine();
            result.Append(value.Texto.Tipo + ";");
            result.Append(value.Texto.Texto);
            result.AppendLine();

            if (value.Cedente != null)
            {
                result.Append(value.Cedente.Tipo + ";");
                result.Append(value.Cedente.OID + ";");
                result.Append(value.Cedente.CodigoBanco + ";");
                result.Append(value.Cedente.CodigoCarteira + ";");
                result.Append(value.Cedente.TextoLocalPagamento + ";");
                result.Append(value.Cedente.CodigoAgenciaCedente + ";");
                result.Append(value.Cedente.CodigoAgenciaCedenteDV + ";");
                result.Append(value.Cedente.CodigoCedente + ";");
                result.Append(value.Cedente.CodigoCedenteDV + ";");

                result.AppendLine();
                result.Append(value.Pagamento.Tipo + ";");
                result.Append(value.Pagamento.Instrucao);
                result.AppendLine();

                foreach (var tuple in value.Destinatarios.Zip(value.Sacados, (x, y) => (destinatario: x, sacado: y)))
                {
                    result.Append(tuple.destinatario.Tipo + ";");
                    result.Append(tuple.destinatario.OID + ";");
                    result.Append(tuple.destinatario.OIDContato + ";");
                    result.Append(tuple.destinatario.LiteralT + ";");
                    result.Append(tuple.destinatario.LiteralD + ";");
                    result.Append(tuple.destinatario.Nominal.Apelido == null ? " " + ";" : tuple.destinatario.Nominal.Apelido + ";");
                    result.Append(tuple.destinatario.Nominal.Titulo == null ? " " + ";" : tuple.destinatario.Nominal.Titulo + ";");
                    result.Append(tuple.destinatario.Nominal.Nome + ";");
                    result.Append(tuple.destinatario.Endereco.CEP + ";");
                    result.Append(tuple.destinatario.Endereco.Logradouro + ";");
                    result.Append(tuple.destinatario.Endereco.Numero + ";");
                    result.Append(tuple.destinatario.Endereco.Complemento == null ? " " + ";" : tuple.destinatario.Endereco.Complemento + ";");
                    result.Append(tuple.destinatario.Endereco.Bairro == null ? " " + ";" : tuple.destinatario.Endereco.Bairro + ";");
                    result.Append(tuple.destinatario.Endereco.Cidade + ";");
                    result.Append(tuple.destinatario.Endereco.UF + ";");
                    result.Append(tuple.destinatario.Endereco.Pais + ";");
                    result.Append(tuple.destinatario.Endereco.Provincia == null ? " " + ";" : tuple.destinatario.Endereco.Provincia + ";");
                    result.Append(tuple.destinatario.Telefone.DDD == null ? " " + ";" : tuple.destinatario.Telefone.DDD + ";");
                    result.Append(tuple.destinatario.Telefone.Numero == null ? " " + ";" : tuple.destinatario.Telefone.Numero + ";");
                    result.Append(tuple.destinatario.Email == null ? " " + ";" : tuple.destinatario.Email + ";");
                    result.Append(tuple.destinatario.NumeralUm + ";");
                    result.Append(tuple.destinatario.Telefone.DDDFax == null ? " " + ";" : tuple.destinatario.Telefone.DDDFax + ";");
                    result.Append(tuple.destinatario.Telefone.NumeroFax == null ? " " + ";" : tuple.destinatario.Telefone.NumeroFax + ";");
                    result.Append(tuple.destinatario.Endereco.CEPCxPostal == null ? " " + ";" : tuple.destinatario.Endereco.CEPCxPostal + ";");
                    result.Append(tuple.destinatario.Endereco.CaixaPostal == null ? " " + ";" : tuple.destinatario.Endereco.CaixaPostal + ";");
                    result.Append(tuple.destinatario.TipoDestino + ";");
                    result.Append(tuple.destinatario.LiteralN);

                    if (tuple.sacado != null)
                    {
                        result.AppendLine();
                        result.Append(tuple.sacado.Tipo + ";");
                        result.Append(tuple.sacado.CodigoLinhaDigitavel + ";");
                        result.Append(tuple.sacado.NumeroDocumento == null ? " " + ";" : tuple.sacado.NumeroDocumento + ";");
                        result.Append(tuple.sacado.DataDocumento == null ? " " + ";" : tuple.sacado.DataDocumento?.ToString("dd/MM/yyyy") + ";");
                        result.Append(tuple.sacado.ValorDocumento + ";");
                        result.Append(tuple.sacado.EspecieDocumento == null ? " " + ";" : tuple.sacado.EspecieDocumento);
                        result.Append(tuple.sacado.Aceite + ";");
                        result.Append(tuple.sacado.NossoNumero + ";");
                        result.Append(tuple.sacado.NossoNumeroDV + ";");
                        result.Append(tuple.sacado.DataProcessamento.ToString("dd/MM/yyyy") + ";");
                        result.Append(tuple.sacado.DataVencimento.ToString("dd/MM/yyyy") + ";");
                        result.Append(" " + ";");
                        result.AppendLine();
                    }
                }
            }
            else
            {
                foreach (var destinatario in value.Destinatarios)
                {
                    result.Append(destinatario.Tipo + ";");
                    result.Append(destinatario.OID + ";");
                    result.Append(destinatario.OIDContato + ";");
                    result.Append(destinatario.LiteralT + ";");
                    result.Append(destinatario.LiteralD + ";");
                    result.Append(destinatario.Nominal.Apelido == null ? " " + ";" : destinatario.Nominal.Apelido + ";");
                    result.Append(destinatario.Nominal.Titulo == null ? " " + ";" : destinatario.Nominal.Titulo + ";");
                    result.Append(destinatario.Nominal.Nome + ";");
                    result.Append(destinatario.Endereco.CEP + ";");
                    result.Append(destinatario.Endereco.Logradouro + ";");
                    result.Append(destinatario.Endereco.Numero + ";");
                    result.Append(destinatario.Endereco.Complemento == null ? " " + ";" : destinatario.Endereco.Complemento + ";");
                    result.Append(destinatario.Endereco.Bairro == null ? " " + ";" : destinatario.Endereco.Bairro + ";");
                    result.Append(destinatario.Endereco.Cidade + ";");
                    result.Append(destinatario.Endereco.UF + ";");
                    result.Append(destinatario.Endereco.Pais + ";");
                    result.Append(destinatario.Endereco.Provincia == null ? " " + ";" : destinatario.Endereco.Provincia + ";");
                    result.Append(destinatario.Telefone.DDD == null ? " " + ";" : destinatario.Telefone.DDD + ";");
                    result.Append(destinatario.Telefone.Numero == null ? " " + ";" : destinatario.Telefone.Numero + ";");
                    result.Append(destinatario.Email == null ? " " + ";" : destinatario.Email + ";");
                    result.Append(destinatario.NumeralUm + ";");
                    result.Append(destinatario.Telefone.DDDFax == null ? " " + ";" : destinatario.Telefone.DDDFax + ";");
                    result.Append(destinatario.Telefone.NumeroFax == null ? " " + ";" : destinatario.Telefone.NumeroFax + ";");
                    result.Append(destinatario.Endereco.CEPCxPostal == null ? " " + ";" : destinatario.Endereco.CEPCxPostal + ";");
                    result.Append(destinatario.Endereco.CaixaPostal == null ? " " + ";" : destinatario.Endereco.CaixaPostal + ";");
                    result.Append(destinatario.TipoDestino + ";");
                    result.Append(destinatario.LiteralN);
                }
            }

            return result;
        }

        /// <summary>
        /// Gera o registro do tipo 4
        /// </summary>
        /// <param name="value">Informações do remetente da carta</param>
        /// <returns></returns>
        private StringBuilder GerarRegistroTipo4(CartaRemetente value)
        {
            var result = new StringBuilder();

            result.Append(value.Tipo + ";");
            result.Append(value.OID + ";");
            result.Append(value.Assunto == null ? " " + ";" : value.Assunto + ";");
            result.Append(value.OIDRemetente + ";");
            result.Append(value.Nominal.Apelido == null ? " " + ";" : value.Nominal.Apelido + ";");
            result.Append(value.Nominal.Titulo == null ? " " + ";" : value.Nominal.Titulo + ";");
            result.Append(value.Nominal.Nome + ";");
            result.Append(value.Endereco.CEP + ";");
            result.Append(value.Endereco.Logradouro + ";");
            result.Append(value.Endereco.Numero + ";");
            result.Append(value.Endereco.Complemento == null ? " " + ";" : value.Endereco.Complemento + ";");
            result.Append(value.Endereco.Bairro == null ? " " : value.Endereco.Bairro + ";");
            result.Append(value.Endereco.Cidade + ";");
            result.Append(value.Endereco.UF + ";");
            result.Append(value.Telefone.DDD == null ? " " + ";" : value.Telefone.DDD + ";");
            result.Append(value.Telefone.Numero == null ? " " + ";" : value.Telefone.Numero + ";");
            result.Append(value.Email == null ? " " + ";" : value.Email + ";");
            result.Append(value.NumeralZero + ";");
            result.Append(value.Telefone.DDDFax == null ? " " + ";" : value.Telefone.DDDFax + ";");
            result.Append(value.Telefone.NumeroFax == null ? " " + ";" : value.Telefone.NumeroFax + ";");
            result.Append(value.Endereco.CEPCxPostal == null ? " " + ";" : value.Endereco.CEPCxPostal + ";");
            result.Append(value.Endereco.CaixaPostal == null ? " " + ";" : value.Endereco.CaixaPostal + ";");
            result.Append(value.LiteralN + ";");
            result.Append(value.DataEnvio == null ? " " + ";" : value.DataEnvio?.ToString("dd/MM/yyyy") + ";");
            result.Append(value.DataCadastro.ToString("dd/MM/yyyy") + ";");
            result.Append(value.NumeralZero + ";");
            result.Append(value.IndicadorNomeFonte + ";");
            result.Append(value.IndicadorEntreLinhas + ";");
            result.Append(value.IndicadorEstiloFonte + ";");
            result.Append(value.IndicadorTamnhoFonte + ";");
            result.Append(value.SVRAR == null ? " " + ";" : value.SVRAR + ";");
            result.Append(value.Usuario == null ? " " + ";" : value.Usuario + ";");
            result.Append(value.LiteralBR + ";");
            result.Append(value.LiteralN + ";");
            result.Append(value.Internacional == true ? 1 : 0);
            result.Append(value.ImgemCabecalho == null ? " " + ";" : value.ImgemCabecalho + ";");
            result.Append(value.ImagemRodape == null ? " " + ";" : value.ImagemRodape + ";");

            result.AppendLine();
            result.Append(value.Texto.Tipo + ";");
            result.Append(value.Texto.Texto);

            result.AppendLine();

            if (value.Cedente != null)
            {
                result.Append(value.Cedente.Tipo + ";");
                result.Append(value.Cedente.OID + ";");
                result.Append(value.Cedente.CodigoBanco + ";");
                result.Append(value.Cedente.CodigoCarteira + ";");
                result.Append(value.Cedente.TextoLocalPagamento + ";");
                result.Append(value.Cedente.CodigoAgenciaCedente + ";");
                result.Append(value.Cedente.CodigoAgenciaCedenteDV + ";");
                result.Append(value.Cedente.CodigoCedente + ";");
                result.Append(value.Cedente.CodigoCedenteDV + ";");

                result.AppendLine();
                result.Append(value.Pagamento.Tipo + ";");
                result.Append(value.Pagamento.Instrucao);
                result.AppendLine();

                foreach (var tuple in value.Destinatarios.Zip(value.Sacados, (x, y) => (destinatario: x, sacado: y)))
                {
                    result.Append(tuple.destinatario.Tipo + ";");
                    result.Append(tuple.destinatario.OID + ";");
                    result.Append(tuple.destinatario.OIDContato + ";");
                    result.Append(tuple.destinatario.LiteralC + ";");
                    result.Append(tuple.destinatario.LiteralD + ";");
                    result.Append(tuple.destinatario.Nominal.Apelido == null ? " " + ";" : tuple.destinatario.Nominal.Apelido + ";");
                    result.Append(tuple.destinatario.Nominal.Titulo == null ? " " + ";" : tuple.destinatario.Nominal.Titulo + ";");
                    result.Append(tuple.destinatario.Nominal.Nome + ";");
                    result.Append(tuple.destinatario.Endereco.CEP + ";");
                    result.Append(tuple.destinatario.Endereco.Logradouro + ";");
                    result.Append(tuple.destinatario.Endereco.Numero + ";");
                    result.Append(tuple.destinatario.Endereco.Complemento == null ? " " + ";" : tuple.destinatario.Endereco.Complemento + ";");
                    result.Append(tuple.destinatario.Endereco.Bairro == null ? " " + ";" : tuple.destinatario.Endereco.Bairro + ";");
                    result.Append(tuple.destinatario.Endereco.Cidade + ";");
                    result.Append(tuple.destinatario.Endereco.UF + ";");
                    result.Append(tuple.destinatario.Endereco.Pais + ";");
                    result.Append(tuple.destinatario.Endereco.Provincia == null ? " " + ";" : tuple.destinatario.Endereco.Provincia + ";");//Analisar
                    result.Append(tuple.destinatario.Telefone.DDD == null ? " " + ";" : tuple.destinatario.Telefone.DDD + ";");
                    result.Append(tuple.destinatario.Telefone.Numero == null ? " " + ";" : tuple.destinatario.Telefone.Numero + ";");
                    result.Append(tuple.destinatario.Email == null ? " " + ";" : tuple.destinatario.Email + ";");
                    result.Append(tuple.destinatario.NumeralUm + ";");
                    result.Append(tuple.destinatario.Telefone.DDDFax == null ? " " + ";" : tuple.destinatario.Telefone.DDDFax + ";");
                    result.Append(tuple.destinatario.Telefone.NumeroFax == null ? " " + ";" : tuple.destinatario.Telefone.NumeroFax + ";");
                    result.Append(tuple.destinatario.Endereco.CEPCxPostal == null ? " " + ";" : tuple.destinatario.Endereco.CEPCxPostal + ";");
                    result.Append(tuple.destinatario.Endereco.CaixaPostal == null ? " " + ";" : tuple.destinatario.Endereco.CaixaPostal + ";");
                    result.Append(tuple.destinatario.TipoDestino + ";");
                    result.Append(tuple.destinatario.LiteralN);

                    if (tuple.sacado != null)
                    {
                        result.AppendLine();
                        result.Append(tuple.sacado.Tipo + ";");
                        result.Append(tuple.sacado.CodigoLinhaDigitavel + ";");
                        result.Append(tuple.sacado.NumeroDocumento == null ? " " + ";" : tuple.sacado.NumeroDocumento + ";");
                        result.Append(tuple.sacado.DataDocumento == null ? " " + ";" : tuple.sacado.DataDocumento?.ToString("dd/MM/YYYY") + ";");
                        result.Append(tuple.sacado.ValorDocumento + ";");
                        result.Append(tuple.sacado.EspecieDocumento == null ? " " + ";" : tuple.sacado.EspecieDocumento);
                        result.Append(tuple.sacado.Aceite + ";");
                        result.Append(tuple.sacado.NossoNumero + ";");
                        result.Append(tuple.sacado.NossoNumeroDV + ";");
                        result.Append(tuple.sacado.DataProcessamento + ";");
                        result.Append(tuple.sacado.DataVencimento + ";");
                        result.Append(" " + ";");
                        result.AppendLine();
                    }
                }
            }
            else
            {
                foreach (var destinatario in value.Destinatarios)
                {
                    result.Append(destinatario.Tipo + ";");
                    result.Append(destinatario.OID + ";");
                    result.Append(destinatario.OIDContato + ";");
                    result.Append(destinatario.LiteralC + ";");
                    result.Append(destinatario.LiteralD + ";");
                    result.Append(destinatario.Nominal.Apelido == null ? " " + ";" : destinatario.Nominal.Apelido + ";");
                    result.Append(destinatario.Nominal.Titulo == null ? " " + ";" : destinatario.Nominal.Titulo + ";");
                    result.Append(destinatario.Nominal.Nome + ";");
                    result.Append(destinatario.Endereco.CEP + ";");
                    result.Append(destinatario.Endereco.Logradouro + ";");
                    result.Append(destinatario.Endereco.Numero + ";");
                    result.Append(destinatario.Endereco.Complemento == null ? " " + ";" : destinatario.Endereco.Complemento + ";");
                    result.Append(destinatario.Endereco.Bairro == null ? " " + ";" : destinatario.Endereco.Bairro + ";");
                    result.Append(destinatario.Endereco.Cidade + ";");
                    result.Append(destinatario.Endereco.UF + ";");
                    result.Append(destinatario.Endereco.Pais + ";");
                    result.Append(destinatario.Endereco.Provincia == null ? " " + ";" : destinatario.Endereco.Provincia + ";");//Analisar
                    result.Append(destinatario.Telefone.DDD == null ? " " + ";" : destinatario.Telefone.DDD + ";");
                    result.Append(destinatario.Telefone.Numero == null ? " " + ";" : destinatario.Telefone.Numero + ";");
                    result.Append(destinatario.Email == null ? " " + ";" : destinatario.Email + ";");
                    result.Append(destinatario.NumeralUm + ";");
                    result.Append(destinatario.Telefone.DDDFax == null ? " " + ";" : destinatario.Telefone.DDDFax + ";");
                    result.Append(destinatario.Telefone.NumeroFax == null ? " " + ";" : destinatario.Telefone.NumeroFax + ";");
                    result.Append(destinatario.Endereco.CEPCxPostal == null ? " " + ";" : destinatario.Endereco.CEPCxPostal + ";");
                    result.Append(destinatario.Endereco.CaixaPostal == null ? " " + ";" : destinatario.Endereco.CaixaPostal + ";");
                    result.Append(destinatario.TipoDestino + ";");
                    result.Append(destinatario.LiteralN);
                }
            }

            return result;
        }

        #endregion Métodos
    }
}