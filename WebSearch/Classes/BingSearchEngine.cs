using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Json;
using WebSearch.Interfaces;

namespace WebSearch.Classes
{
    internal class BingSearchEngine : ISearchEngine
    {
        private class BingSearchResult
        {
            public string id;
            public string name;
            public string url;
            public string displayUrl;
            public string snippet;
            public string dateLastCrawled;
        }

        private class BingWebPages
        {
            public string webSearchUrl;
            public ulong totalEstimatedMatches;
            public BingSearchResult[] value;
        }

        private class BingSearchResponse
        {
            public string _type;
            public BingWebPages webPages;
        }

        private BingSettingsControl m_control;

        public string ApiKey { get; set; } = Properties.Settings.Default.BingApiKey;

        public string Name => "Bing";

        public BingSearchEngine()
        {
            m_control = new BingSettingsControl(this);
        }

        public async Task<IEnumerable<SearchResult>> Search(string query)
        {
            var uriBuilder = new UriBuilder
            {
                Host = "api.cognitive.microsoft.com",
                Path = "bing/v5.0/search",
                Scheme = "https",
                Query = "q=" + query
            };

            var httpClient = new HttpClient {Timeout = new TimeSpan(0, 0, 0, 10)};
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ApiKey);

            var response = await httpClient.GetAsync(uriBuilder.Uri);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Error: " + response.StatusCode);
            string result = await response.Content.ReadAsStringAsync();
            var info = NewtonsoftJsonSerializer.Instance.Deserialize<BingSearchResponse>(result);
            return info.webPages.value.Select(value => new SearchResult(value.name, value.displayUrl)).ToList();
        }

        public UserControl SettingsControl => m_control;

        public override string ToString()
        {
            return Name;
        }
    }
}
