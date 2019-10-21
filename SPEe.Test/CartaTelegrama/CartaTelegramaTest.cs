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
                    new Models.TelegramaDestinatario
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
                    }
                }
            });

            telegrama.TelegramaRemetentes.Add(telegramaRemetente);
            telegrama.Gerar();
        }
    }
}
