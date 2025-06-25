using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EF
{
    private class Context : DbContext
    {
        public DbSet<Lotto> Lottos { get; set; }
        public DbSet<Numero> Numeros { get; set; }
    }

    public class Lotto
    { 
        public int LottoId { get; set; }
        public DateTime FechaHora { get; set; }

        public virtual List<Numero> Numeros { get; set; }
}

    public class Numero
    {
        public int NumeroId { get; set; }
        public int Orden { get; set; }
        public int Num { get; set; }

        public int LottoId { get; set; }
        public virtual Lotto Lotto { get; set; }
    }
}
