using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationsBuilder.Models
{
    class LanguageSynonymousItems 
    {
        static public string SynonymousTagLanguage(string taglanguage)
        {
            List<LanguageSynonymous> _synonymous;
            string path = Path.Combine(Environment.CurrentDirectory, "laguageSyn.json");
            _synonymous = JsonConvert.DeserializeObject<List<LanguageSynonymous>>(File.ReadAllText(path));

            string _result = taglanguage;
            LanguageSynonymous _synonymous_la =
                _synonymous.Find(
                        delegate (LanguageSynonymous _languagesynonymous)
                        {
                            return _languagesynonymous.LanguageTag == taglanguage;
                        }
                    );
            if (_synonymous_la != null ) { _result = _synonymous_la.LanguageTagDefault; }
            return _result;
        }
    }
}
