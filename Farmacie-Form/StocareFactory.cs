﻿using NivelAccesDate;
using System.Configuration;

namespace Farmacie_Form
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMedicamente_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMedicamente_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
