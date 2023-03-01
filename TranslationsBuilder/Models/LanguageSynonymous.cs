using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationsBuilder.Models
{
    class LanguageSynonymous
    {
        public string LanguageTag { get; set; }
        public string LanguageTagDefault { get; set; }
        public string FullName
        {
            get
            {
                return " [" + LanguageTag + "] is same to [" + LanguageTagDefault + "]";
            }
        }
        public override string ToString()
        {
            return " [" + LanguageTag + "] is same to [" + LanguageTagDefault + "]";
        }
    }
}
