using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSearch.Classes;

namespace WebSearch.Interfaces
{
    public interface ISearchEngine
    {
        string Name { get; }
        Task<IEnumerable<SearchResult>> Search(string query);
        UserControl SettingsControl { get; }
    }
}
