using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Vecc.FiddlerCertInformation
{
    public partial class CertInfoInspectorTab : UserControl
    {
        #region Private Members

        private X509Certificate2 _certificate;

        #endregion Private Members

        #region Constructors

        public CertInfoInspectorTab()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Properties

        public X509Certificate2 Certificate
        {
            get
            {
                return this._certificate;
            }
            set
            {
                if (value == null)
                {
                    this.btnOpenCertificateDialog.Enabled = false;
                }
                else
                {
                    this.btnOpenCertificateDialog.Enabled = true;
                }

                this._certificate = value;
            }
        }

        public DataGridView DataGrid
        {
            get
            {
                return this.dgProperties;
            }
        }

        #endregion Properties

        #region Event Handlers

        private void btnOpenCertificateDialog_Click(object sender, EventArgs e)
        {
            if (this.Certificate != null)
            {
                X509Certificate2UI.DisplayCertificate(this.Certificate);
            }
        }

        #endregion Event Handlers
    }
}
