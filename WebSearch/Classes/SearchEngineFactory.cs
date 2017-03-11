using System.Collections.Generic;
using WebSearch.Interfaces;

namespace WebSearch.Classes
{
    public static class SearchEngineFactory
    {
        public static IEnumerable<ISearchEngine> GetAllSearchEngines()
        {
            return new List<ISearchEngine>
            {
                new GoogleSearchEngine(),
                new BingSearchEngine()
            };
        }
    }
}
