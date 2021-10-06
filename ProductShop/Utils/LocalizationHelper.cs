using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductShop.Utils
{
    // клас дає можливість отримати список мов 
    public static class LocalizationHelper
    {
        // список мов, які підтримуються
      private static IList<LocalizationVM> Languages { get; set; } = new List<LocalizationVM> { 
            new LocalizationVM{
                locCode = "uk",
                locName = "Українська"
            },
            new LocalizationVM{
                locCode = "en",
                locName = "English"
            }
        };
        public static List<LocalizationVM> GetLanguages() 
        {
            //  Повернення колеції мов
            return Languages.ToList();
        }
    }
}
