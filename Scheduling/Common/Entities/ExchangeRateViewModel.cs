﻿using Microsoft.EntityFrameworkCore.Metadata;

namespace Scheduling.Common.Entities
{
    public class ExchangeRateViewModel
    {
        public string broj_tecajnice { get; set; }

        public string datum_primjene { get; set; }

        public string drzava { get; set; }

        public string drzava_iso { get; set; }

        public string sifra_valuta { get; set; }

        public string valuta { get; set; }

        public string kupovni_tecaj { get; set; }

        public string srednji_tecaj { get; set; }

        public string prodajni_tecaj { get; set; }


    }
}
