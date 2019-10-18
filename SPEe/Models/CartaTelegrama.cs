using System.Collections.Generic;

namespace SPEe.Models
{
    public class CartaTelegrama
    {
        /// <summary>
        /// Tipo de Registro: 0 (zero). Identificação do Arquivo
        /// </summary>
        public IdentificacaoRegistro IdentificacaoRegistro { get; set; }

        /// <summary>
        ///  Coleção do Tipo de Registro: 1 (um). Dados do Telegrama e do Remetente
        /// </summary>
        public IList<TelegramaRemetente> TelegramaRemetentes { get; set; }

        public void Gerar()
        {
        }
    }
}