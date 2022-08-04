using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace JobsArgeya.Business
{

    public interface ILocalizer
    {
        public string Get(string key);
        public string Get(string key, string cultureCode);
        public void Reset();
    }

    public class Localizer : ILocalizer
    {
        public const string CACHE_KEY = "DICTIONARY";

        private readonly DatabaseContext _databaseContext;
        private readonly IMemoryCache _memoryCache;

        public Localizer(DatabaseContext databaseContext, IMemoryCache memoryCache)
        {
            _databaseContext = databaseContext;
            _memoryCache = memoryCache;
        }


        public string Get(string key)
        {
            Dictionary entry = GetLocalizations().Where(x => x.Key == key && x.LangCode == CultureInfo.CurrentCulture.TwoLetterISOLanguageName).FirstOrDefault();
            if (entry == null) return "Not Exists In Dictionary";
            return entry.Value;
        }
        public string Get(string key, string cultureCode)
        {
            Dictionary entry = GetLocalizations().Where(x => x.Key == key && x.LangCode == cultureCode).FirstOrDefault();
            if (entry == null) return "Not Exists In Dictionary";
            return entry.Value;
        }

        /// <summary>
        /// Tüm Dictionary nesneleri gelir. Önce Cache e bakar, yoksa db den alır
        /// </summary>
        /// <returns>LocalizationDto.</returns>
        private List<Dictionary> GetLocalizations()
        {
            var result = _memoryCache.Get<List<Dictionary>>(CACHE_KEY);

            if (result == null)
            {
                var localizations = _databaseContext.Dictionaries.ToList();

                if (localizations == null)
                {
                    return null;
                }

                result = _memoryCache.Set(CACHE_KEY, localizations);
            }

            return result;
        }

        /// <summary>
        /// tüm localization datasını cache temizler
        /// </summary>
        /// <returns>.</returns>
        public void Reset()
        {
            _memoryCache.Remove(CACHE_KEY);
        }


    }
}
