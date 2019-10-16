namespace SPEe.ValueObjects
{
    /// <summary>
    /// Nome, apelido e título
    /// </summary>
    public class Nominal
    {
        /// <summary>
        /// Forma mais fácil e rápida de identificar
        /// </summary>
        public string Apelido { get; set; }

        /// <summary>
        /// Método formal para tratamento por escrito
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Nome completo
        /// </summary>
        public string Nome { get; set; }
    }
}