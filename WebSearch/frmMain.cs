using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WebSearch.Classes;
using WebSearch.Interfaces;
using WebSearch.Properties;

namespace WebSearch
{
    public partial class frmMain : Form
    {
        private ISearchEngine m_engine;

        public frmMain()
        {
            InitializeComponent();

            cmbSearchEngine.DataSource = SearchEngineFactory.GetAllSearchEngines();
            cmbSearchEngine.SelectedIndex = 0;
        }

        private void RefreshInterface()
        {
            lblTitle.Text = string.Empty;
            lblLink.Text = string.Empty;
        }

        private void FillInterface(SearchResult info)
        {
            lblTitle.Text = info.Title;
            lblLink.Text = info.Url;
            btnSearch.Enabled = true;
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrEmpty(txtQuery.Text);
        }

        private void cmbSearchEngine_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshInterface();
            if (m_engine?.SettingsControl != null)
                m_engine.SettingsControl.Parent = null;
            m_engine = (ISearchEngine) cmbSearchEngine.SelectedValue;
            var settings = m_engine.SettingsControl;
            grbSettings.Visible = settings != null;
            if (settings == null)
                return;
            settings.Parent = grbSettings;
            settings.Dock = DockStyle.Fill;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshInterface();
            btnSearch.Enabled = false;
            try
            {
                var result = await m_engine.Search(txtQuery.Text);
                FillInterface(result.FirstOrDefault());
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.SearchException + exception.Message);
            }
            finally
            {
                btnSearch.Enabled = true;
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lblLink.Text);
        }
    }
}
