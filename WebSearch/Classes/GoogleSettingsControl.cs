using System.Windows.Forms;

namespace WebSearch.Classes
{
    public partial class GoogleSettingsControl : UserControl
    {
        private GoogleSearchEngine m_searchEngine;

        internal GoogleSettingsControl(GoogleSearchEngine engine)
        {
            InitializeComponent();

            m_searchEngine = engine;
            txtApiKey.Text = engine.ApiKey;
            txtSearchEngineId.Text = engine.SearchEngineId;
        }

        private void ApplySettings()
        {
            m_searchEngine.ApiKey = txtApiKey.Text;
            m_searchEngine.SearchEngineId = txtSearchEngineId.Text;
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            txtApiKey.Text = Properties.Settings.Default.GoogleApiKey;
            txtSearchEngineId.Text = Properties.Settings.Default.GoogleSearchEngineId;
            ApplySettings();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.GoogleApiKey = txtApiKey.Text;
            Properties.Settings.Default.GoogleSearchEngineId = txtSearchEngineId.Text;
            Properties.Settings.Default.Save();
            ApplySettings();
        }
    }
}
