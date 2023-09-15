using System;
using System.Windows.Forms;

namespace CatiaApi
{
    public partial class CentralCatiaControl : Form
    {
        INFITF.Application catiaApp;

        public CentralCatiaControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            catiaApp = CatiaUtils.Connect(true);
        }

        private void btnCreatePartDoc_Click(object sender, EventArgs e)
        {
            CatiaUtils.CreateDocument(catiaApp, "Part");
        }

        private void btnGetActiveDocType_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CatiaUtils.GetActiveDocumentType(catiaApp));
        }

        private void btnCreateDwgDoc_Click(object sender, EventArgs e)
        {
            CatiaUtils.CreateDocument(catiaApp, "Drawing");
        }

        private void btnCreateProductDoc_Click(object sender, EventArgs e)
        {
            CatiaUtils.CreateDocument(catiaApp, "Product");
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            CatiaUtils.CloseAllDocuments(catiaApp);
        }

        private void btnStartCatia_Click(object sender, EventArgs e)
        {
            catiaApp = CatiaUtils.Connect(true);
        }

        private void btnCloseCatia_Click(object sender, EventArgs e)
        {
            CatiaUtils.CloseCatiaApp(catiaApp);
        }

        private void btnCloseActiveDoc_Click(object sender, EventArgs e)
        {
            CatiaUtils.CloseDocument(catiaApp);
        }

        private void btnSaveActiveDoc_Click(object sender, EventArgs e)
        {
            CatiaUtils.SaveDocument(catiaApp);
        }

        private void btnSaveActiveDocAs_Click(object sender, EventArgs e)
        {
            CatiaUtils.SaveDocument(catiaApp, string.Empty);
        }
    }
}
