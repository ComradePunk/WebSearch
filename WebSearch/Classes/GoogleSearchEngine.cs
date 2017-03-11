using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using WebSearch.Interfaces;

namespace WebSearch.Classes
{
    internal class GoogleSearchEngine : ISearchEngine
    {
        private GoogleSettingsControl m_control;

        public GoogleSearchEngine()
        {
            m_control = new GoogleSettingsControl(this);
        }

        public string ApiKey { get; set; } = Properties.Settings.Default.GoogleApiKey;
        public string SearchEngineId { get; set; } = Properties.Settings.Default.GoogleSearchEngineId;

        public string Name => "Google";

        public async Task<IEnumerable<SearchResult>> Search(string query)
        {
            var customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = ApiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = SearchEngineId;
            listRequest.Start = 1;
            var search = await listRequest.ExecuteAsync();
            IList<Result> paging = search.Items;
            if (paging == null)
                return new List<SearchResult>();
            return paging.Select(item => new SearchResult(item.Title, item.Link)).ToList();
        }

        public UserControl SettingsControl => m_control;

        public override string ToString()
        {
            return Name;
        }
    }
}
