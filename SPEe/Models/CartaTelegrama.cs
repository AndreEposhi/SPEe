using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEe.Models
{
    public class CartaTelegrama
    {
        /// <summary>
        /// Tipo de Registro: 0 (zero). Identificação do Arquivo
        /// </summary>
        public IdentificacaoRegistro IdentificacaoRegistro { get; set; }

        /// <summary>
        /// Tipo de Registro: 1 (um). Dados do Telegrama e do Remetente
        /// </summary>
        public TelegramaRemetente TelegramaRemetente { get; set; }

        /// <summary>
        /// Tipo de Registro: 2 (dois). Texto do Telegrama
        /// </summary>
        public TelegramaTexto TelegramaTexto { get; set; }

        /// <summary>
        /// Coleção do Tipo de Registro: 3 (três). Dados do(s) Destinatário(s) do Telegrama
        /// </summary>
        public IList<TelegramaDestinatario> TelegramaDestinatarios { get; set; }
    }
}
