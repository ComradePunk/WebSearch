using System;
using System.Windows.Forms;

namespace WebSearch.Classes
{
    internal partial class BingSettingsControl : UserControl
    {
        private BingSearchEngine m_engine;

        public BingSettingsControl(BingSearchEngine engine)
        {
            InitializeComponent();

            m_engine = engine;
            txtApiKey.Text = engine.ApiKey;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            m_engine.ApiKey = txtApiKey.Text = Properties.Settings.Default.BingApiKey;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BingApiKey = txtApiKey.Text;
            m_engine.ApiKey = txtApiKey.Text;
            Properties.Settings.Default.Save();
        }
    }
}
