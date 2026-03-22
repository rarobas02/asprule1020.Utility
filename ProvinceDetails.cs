using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.Utility
{
    public static class ProvinceDetails
    {
        public static ProvinceContactInfo GetProvinceInfo(string? province)
        {
            if (string.IsNullOrWhiteSpace(province))
            {
                return new ProvinceContactInfo(
                    "N/A",
                    "Provincial Office",
                    "N/A",
                    "N/A",
                    "N/A",
                    "N/A",
                    "N/A");
            }

            return province.Trim() switch
            {
                "Cavite" => new ProvinceContactInfo(
                    "Trece Martires City, Cavite",
                    "Cavite Provincial Office",
                    "One FS Industrial Bldg., Hugo Perez, Trece Martires City, Cavite",
                    "(046) 423-3223 / (046) 419-0830 / (046) 419-1996",
                    "dole_cavite@yahoo.com / cpo.dole4a@gmail.com",
                    "MARIVIC B. MARTINEZ",
                    "Cavite Provincial Director"),

                "Laguna" => new ProvinceContactInfo(
                    "Calamba City, Laguna",
                    "Laguna Provincial Office",
                    "2F Puregold Jr. Bldg. Parian City of Calamba, Laguna",
                    "(049) 545-7361 / (049) 545-7358",
                    "lpo_dole4a@yahoo.com / lpo.dole4a@gmail.com",
                    "GUIDO R. RECIO",
                    "Laguna Provincial Director"),

                "Batangas" => new ProvinceContactInfo(
                    "Lipa City, Batangas",
                    "Batangas Provincial Office",
                    "Unit L The Olan Business Center, Brgy. Marawoy, Lipa City, Batangas",
                    "(043) 726-9972",
                    "ro4a_batangas@dole.gov.ph",
                    "PREDELMA M. TAN",
                    "Batangas Provincial Director"),

                "Rizal" => new ProvinceContactInfo(
                    "Cainta, Rizal",
                    "Rizal Provincial Office",
                    "3rd Floor, Ortigas Avenue Extension corner Sampaguita Street, Bayanihan Village, San Isidro, Cainta, Rizal",
                    "(02) 212-1648",
                    "dole4a_rpo@yahoo.com / rpo.dole4a@gmail.com",
                    "CELIA G. ARIOLA",
                    "Head, Rizal Provincial Office"),

                "Quezon" => new ProvinceContactInfo(
                    "Lucena City, Quezon",
                    "Quezon Provincial Office",
                    "2F Grand Central Terminal, Lucena City, Quezon",
                    "(042) 785-0894",
                    "dole4a.quezon@gmail.com",
                    "CRISTINA H. BARAYANG",
                    "OIC Head, Quezon Provincial Office"),

                _ => new ProvinceContactInfo(
                    "N/A",
                    $"{province} Provincial Office",
                    "N/A",
                    "N/A",
                    "N/A",
                    "N/A",
                    "N/A")
            };
        }
    }

    public sealed record ProvinceContactInfo(
        string OfficeAddress,
        string ProvincialOffice,
        string ProvinceAddress,
        string ProvinceTelNo,
        string ProvinceEmail,
        string PdName,
        string ProDir);
}
