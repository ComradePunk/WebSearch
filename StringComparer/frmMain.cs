using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringComparator.Classes;
using StringComparator.Interfaces;
using StringComparator.Properties;

namespace StringComparator
{
    public partial class frmMain : Form
    {
        private IComparator m_selectedComparator;
        private string m_path = Application.ExecutablePath;

        public frmMain()
        {
            InitializeComponent();

            cmbCompareMethods.DataSource = ComparatorFactory.GetAllComparators();
            cmbCompareMethods.SelectedIndex = 0;
        }

        private bool TryGetPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                SelectedPath = Path.GetDirectoryName(m_path)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_path = dialog.SelectedPath;
                return true;
            }
            return false;
        }

        private async Task<string> ReadFile(string fileName)
        {
            var outStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            StringBuilder result = new StringBuilder();
            int n = 4096;
            byte[] buffer = new byte[n];
            int offset = 0;
            int reallyRead;
            while ((reallyRead = await outStream.ReadAsync(buffer, offset, n)) > 0)
            {
                offset += reallyRead;
                result.Append(Encoding.Default.GetString(buffer, 0, reallyRead));
                if (reallyRead < n)
                    break;
            }
            outStream.Close();
            return result.ToString();
        }

        private async void WriteFile(string fileName, string content)
        {
            try
            {
                var instream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                byte[] array = Encoding.Default.GetBytes(content);
                await instream.WriteAsync(array, 0, array.Length);
                instream.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.WriteFileException + exception.Message);
            }
        }

        private async void mnuLoad_Click(object sender, EventArgs e)
        {
            if (!TryGetPath())
                return;
            try
            {
                txtInput.Text = await ReadFile(Path.Combine(m_path, "input.txt"));
                txtPatterns.Text = await ReadFile(Path.Combine(m_path, "patterns.txt"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.FileReadException + exception.Message);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!TryGetPath())
                return;
            WriteFile(Path.Combine(m_path, "input.txt"), txtInput.Text);
            WriteFile(Path.Combine(m_path, "patterns.txt"), txtPatterns.Text);
        }

        private void cmbCompareMethods_SelectedValueChanged(object sender, EventArgs e)
        {
            m_selectedComparator = (IComparator)cmbCompareMethods.SelectedValue;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var patterns = txtPatterns.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var output = m_selectedComparator.Compare(input, patterns);
            StringBuilder result = new StringBuilder();
            foreach (var str in output)
                result.AppendLine(str);
            txtOutput.Text = result.ToString();
        }
    }
}
