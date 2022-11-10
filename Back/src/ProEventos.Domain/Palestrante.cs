using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MinCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Email { get; set; }
        public int MyProperty { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}