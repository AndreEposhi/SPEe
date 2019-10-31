using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SPEe.Test.CartaTelegrama
{
    /// <summary>
    /// Teste unitário para carta ou telegrama
    /// </summary>
    [TestClass]
    public class CartaTelegramaTest
    {
        /// <summary>
        /// Gerando um telegrama
        /// </summary>
        [TestMethod]
        public void TelegramaTest()
        {
            var telegrama = new Models.CartaTelegrama();
            var identificador = Models.IdentificacaoRegistro.Create(new Models.IdentificacaoRegistro());

            telegrama.IdentificacaoRegistro = identificador;

            var telegramaRemetente = Models.TelegramaRemetente.Create(new Models.TelegramaRemetente
            {
                Assunto = "Assunto telegrama",
                OIDRemetente = new Random().Next(),
                Nominal = ValueObjects.Nominal.Create(new ValueObjects.Nominal
                {
                    Apelido = "Apelido Telegrama",
                    Titulo = "Título Telegrama",
                    Nome = "Nome Telegrama"
                }),
                Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                {
                    CEP = 87707070,
                    Logradouro = "Rua Altino da Silva Azeredo",
                    Numero = "482",
                    Complemento = "Próximo Igreja São Paulo",
                    Bairro = "Alvorada do Sul",
                    Cidade = "Paranavaí",
                    UF = "PR"
                }),
                Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                {
                    DDD = "(44)",
                    Numero = "99937-1976"
                }),
                Email = "teste@teste.com.br",
                DataEnvio = DateTime.Now,
                DataCadastro = DateTime.Now,
                SRVCC = "S",
                SRVPC = "S",
                SRVPD = "S",
                SRVDH = "S",
                DataPredatado = DateTime.Now,
                RetornoServico = "E",
                Usuario = "Andre",
                Internacional = false,

                Texto = new Models.TelegramaTexto
                {
                    Texto = "Texto do telegrama linha 1" + Environment.NewLine +
                    "Texto do telegrama linha 2" + Environment.NewLine +
                    "Texto do telegrama linha 3" + Environment.NewLine +
                    "Texto do telegrama linha 4" + Environment.NewLine +
                    "Texto do telegrama linha 5"
                },

                Destinatarios = new List<Models.TelegramaDestinatario>
                {
                    Models.TelegramaDestinatario.Create(new Models.TelegramaDestinatario
                    {
                        OIDContato = new Random().Next(),
                        Nominal = ValueObjects.Nominal.Create( new ValueObjects.Nominal
                        {
                            Apelido = "Apelido Registro 3",
                            Titulo = "Título Registro 3",
                            Nome = "Nome Registro 3"
                        }),
                        Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                        {
                            CEP = 87707040,
                            Logradouro = "Rua José Fracarolli",
                            Numero = "111",
                            Bairro = "Monções II",
                            Cidade = "Paranavaí",
                            UF = "PR",
                            Pais = "BR"
                        }),
                        Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                        {
                            DDD = "(44)",
                            Numero = "99999-4578",
                        }),
                        Email = "teste1@teste.com.br",
                        TipoDestino = 0
                    })
                }
            });

            telegrama.TelegramaRemetentes.Add(telegramaRemetente);
            telegrama.Gerar();
        }

        [TestMethod]
        public void CartaTest()
        {
            var carta = new Models.CartaTelegrama();
            var identificador = Models.IdentificacaoRegistro.Create(new Models.IdentificacaoRegistro());

            carta.IdentificacaoRegistro = identificador;

            var cartaRemetente = Models.CartaRemetente.Create(new Models.CartaRemetente
            {
                Assunto = "Assunto carta",
                OIDRemetente = new Random().Next(),
                Nominal = ValueObjects.Nominal.Create(new ValueObjects.Nominal
                {
                    Apelido = "Apelido carta",
                    Titulo = "Título carta",
                    Nome = "Nome carta"
                }),
                Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                {
                    CEP = 87707070,
                    Logradouro = "Rua Altino da Silva Azeredo",
                    Numero = "482",
                    Complemento = "Próximo Igreja São Paulo",
                    Bairro = "Alvorada do Sul",
                    Cidade = "Paranavaí",
                    UF = "PR"
                }),
                Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                {
                    DDD = "(44)",
                    Numero = "99937-1976"
                }),
                Email = "teste@teste.com.br",
                DataEnvio = DateTime.Now,
                DataCadastro = DateTime.Now,
                SVRAR = "S",
                Usuario = "Joana",
                Internacional = false,

                Texto = new Models.CartaTexto
                {
                    Texto = "Texto da carta linha 1" + Environment.NewLine +
                    "Texto da carta linha 2" + Environment.NewLine +
                    "Texto da carta linha 3" + Environment.NewLine +
                    "Texto da carta linha 4" + Environment.NewLine +
                    "Texto da carta linha 5"
                },

                Destinatarios = new List<Models.CartaDestinatario>
                {
                    Models.CartaDestinatario.Create(new Models.CartaDestinatario
                    {
                        OIDContato = new Random().Next(),
                        Nominal = ValueObjects.Nominal.Create( new ValueObjects.Nominal
                        {
                            Apelido = "Apelido Registro 3",
                            Titulo = "Título Registro 3",
                            Nome = "Nome Registro 3"
                        }),
                        Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                        {
                            CEP = 87707040,
                            Logradouro = "Rua José Fracarolli",
                            Numero = "111",
                            Bairro = "Monções II",
                            Cidade = "Paranavaí",
                            UF = "PR",
                            Pais = "BR"
                        }),
                        Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                        {
                            DDD = "(44)",
                            Numero = "99999-4578",
                        }),
                        Email = "teste1@teste.com.br",
                        TipoDestino = 0
                    })
                }
            });

            carta.CartaRemetentes.Add(cartaRemetente);
            carta.Gerar();
        }

        [TestMethod]
        public void TelegramaBloquetoTest()
        {
            var telegrama = new Models.CartaTelegrama();
            var identificador = Models.IdentificacaoRegistro.Create(new Models.IdentificacaoRegistro());

            telegrama.IdentificacaoRegistro = identificador;

            var telegramaRemetente = Models.TelegramaRemetente.Create(new Models.TelegramaRemetente
            {
                Assunto = "Assunto telegrama",
                OIDRemetente = new Random().Next(),
                Nominal = ValueObjects.Nominal.Create(new ValueObjects.Nominal
                {
                    Apelido = "Apelido Telegrama",
                    Titulo = "Título Telegrama",
                    Nome = "Nome Telegrama"
                }),
                Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                {
                    CEP = 87707070,
                    Logradouro = "Rua Altino da Silva Azeredo",
                    Numero = "482",
                    Complemento = "Próximo Igreja São Paulo",
                    Bairro = "Alvorada do Sul",
                    Cidade = "Paranavaí",
                    UF = "PR"
                }),
                Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                {
                    DDD = "(44)",
                    Numero = "99937-1976"
                }),
                Email = "teste@teste.com.br",
                DataEnvio = DateTime.Now,
                DataCadastro = DateTime.Now,
                SRVCC = "S",
                SRVPC = "S",
                SRVPD = "S",
                SRVDH = "S",
                DataPredatado = DateTime.Now,
                RetornoServico = "E",
                Usuario = "Andre",
                Internacional = false,

                Texto = new Models.TelegramaTexto
                {
                    Texto = "Texto do telegrama linha 1" + Environment.NewLine +
                    "Texto do telegrama linha 2" + Environment.NewLine +
                    "Texto do telegrama linha 3" + Environment.NewLine +
                    "Texto do telegrama linha 4" + Environment.NewLine +
                    "Texto do telegrama linha 5"
                },

                Cedente = Models.BloquetoCedente.Create(new Models.BloquetoCedente
                {
                    CodigoBanco = 123,
                    CodigoCarteira = 123456,
                    TextoLocalPagamento = "Local de pagamento",
                    CodigoAgenciaCedente = 789456,
                    CodigoAgenciaCedenteDV = 2,
                    CodigoCedente = 147258369,
                    CodigoCedenteDV = 1
                }),

                Pagamento = Models.BloquetoPagamento.Create(new Models.BloquetoPagamento
                {
                    Instrucao = "Texto livre linha 1" + Environment.NewLine +
                    "Texto livre linha 2"
                }),

                Destinatarios = new List<Models.TelegramaDestinatario>
                {
                    Models.TelegramaDestinatario.Create(new Models.TelegramaDestinatario
                    {
                        OIDContato = new Random().Next(),
                        Nominal = ValueObjects.Nominal.Create( new ValueObjects.Nominal
                        {
                            Apelido = "Apelido Registro 3",
                            Titulo = "Título Registro 3",
                            Nome = "Nome Registro 3"
                        }),
                        Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                        {
                            CEP = 87707040,
                            Logradouro = "Rua José Fracarolli",
                            Numero = "111",
                            Bairro = "Monções II",
                            Cidade = "Paranavaí",
                            UF = "PR",
                            Pais = "BR"
                        }),
                        Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                        {
                            DDD = "(44)",
                            Numero = "99999-4578",
                        }),
                        Email = "teste1@teste.com.br",
                        TipoDestino = 0
                    })
                },

                Sacados = new List<Models.BloquetoSacado>
                {
                    Models.BloquetoSacado.Create(new Models.BloquetoSacado
                    {
                        CodigoLinhaDigitavel = "01234567890123456789012345678901234567890123456",
                        NumeroDocumento = 01234567890123456,
                        DataDocumento = DateTime.Today,
                        ValorDocumento = 10.52,
                        EspecieDocumento = "132131313",
                        Aceite = "N",
                        NossoNumero = "012345678901234567",
                        NossoNumeroDV = 1,
                        DataProcessamento = DateTime.Today,
                        DataVencimento = DateTime.Today
                    })
                }
            });  

            telegrama.TelegramaRemetentes.Add(telegramaRemetente);
            telegrama.Gerar();
        }

        [TestMethod]
        public void CartaBloquetoTest()
        {
            var carta = new Models.CartaTelegrama();
            var identificador = Models.IdentificacaoRegistro.Create(new Models.IdentificacaoRegistro());

            carta.IdentificacaoRegistro = identificador;

            var cartaRemetente = Models.CartaRemetente.Create(new Models.CartaRemetente
            {
                Assunto = "Assunto carta",
                OIDRemetente = new Random().Next(),
                Nominal = ValueObjects.Nominal.Create(new ValueObjects.Nominal
                {
                    Apelido = "Apelido carta",
                    Titulo = "Título carta",
                    Nome = "Nome carta"
                }),
                Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                {
                    CEP = 87707070,
                    Logradouro = "Rua Altino da Silva Azeredo",
                    Numero = "482",
                    Complemento = "Próximo Igreja São Paulo",
                    Bairro = "Alvorada do Sul",
                    Cidade = "Paranavaí",
                    UF = "PR"
                }),
                Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                {
                    DDD = "(44)",
                    Numero = "99937-1976"
                }),
                Email = "teste@teste.com.br",
                DataEnvio = DateTime.Now,
                DataCadastro = DateTime.Now,
                SVRAR = "S",
                Usuario = "Joana",
                Internacional = false,

                Texto = new Models.CartaTexto
                {
                    Texto = "Texto da carta linha 1" + Environment.NewLine +
                    "Texto da carta linha 2" + Environment.NewLine +
                    "Texto da carta linha 3" + Environment.NewLine +
                    "Texto da carta linha 4" + Environment.NewLine +
                    "Texto da carta linha 5"
                },

                Cedente = Models.BloquetoCedente.Create(new Models.BloquetoCedente
                {
                    CodigoBanco = 123,
                    CodigoCarteira = 123456,
                    TextoLocalPagamento = "Local de pagamento",
                    CodigoAgenciaCedente = 789456,
                    CodigoAgenciaCedenteDV = 2,
                    CodigoCedente = 147258369,
                    CodigoCedenteDV = 1
                }),

                Pagamento = Models.BloquetoPagamento.Create(new Models.BloquetoPagamento
                {
                    Instrucao = "Texto livre linha 1" + Environment.NewLine +
                    "Texto livre linha 2"
                }),

                Destinatarios = new List<Models.CartaDestinatario>
                {
                    Models.CartaDestinatario.Create(new Models.CartaDestinatario
                    {
                        OIDContato = new Random().Next(),
                        Nominal = ValueObjects.Nominal.Create( new ValueObjects.Nominal
                        {
                            Apelido = "Apelido Registro 3",
                            Titulo = "Título Registro 3",
                            Nome = "Nome Registro 3"
                        }),
                        Endereco = ValueObjects.Endereco.Create(new ValueObjects.Endereco
                        {
                            CEP = 87707040,
                            Logradouro = "Rua José Fracarolli",
                            Numero = "111",
                            Bairro = "Monções II",
                            Cidade = "Paranavaí",
                            UF = "PR",
                            Pais = "BR"
                        }),
                        Telefone = ValueObjects.Telefone.Create(new ValueObjects.Telefone
                        {
                            DDD = "(44)",
                            Numero = "99999-4578",
                        }),
                        Email = "teste1@teste.com.br",
                        TipoDestino = 0
                    })
                },

                Sacados = new List<Models.BloquetoSacado>
                {
                    Models.BloquetoSacado.Create(new Models.BloquetoSacado
                    {
                        CodigoLinhaDigitavel = "01234567890123456789012345678901234567890123456",
                        NumeroDocumento = 01234567890123456,
                        DataDocumento = DateTime.Today,
                        ValorDocumento = 10.52,
                        EspecieDocumento = "132131313",
                        Aceite = "N",
                        NossoNumero = "012345678901234567",
                        NossoNumeroDV = 1,
                        DataProcessamento = DateTime.Today,
                        DataVencimento = DateTime.Today
                    })
                }
            });

            carta.CartaRemetentes.Add(cartaRemetente);
            carta.Gerar();
        }
    }
}
