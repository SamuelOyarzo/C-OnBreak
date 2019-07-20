using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public enum ActividadEmpresa
    {
        Agropecuaria = 1,
        Mineria = 2,
        Manufactura = 3,
        Comercio = 4,
        Hoteleria = 5,
        Alimentos = 6,
        Transporte = 7,
        Servicios = 8
    }
    public enum TipoEmpresa
    {
        SPA = 1,
        EIRL = 2,
        Limitada = 3,
        Sociedad_Anonima = 4
    }

    public enum TipoEvento
    { CoffeeBreak = 1, Cocktail = 2, Cenas = 3 }

    public enum CoffeeBreak
    { LightBreak, JournalBreak, DayBreak }

    public enum Cocktail
    { QuickCocktail, AmbientCocktail }

    public enum Cenas
    { ejecutiva, celebracion }


}