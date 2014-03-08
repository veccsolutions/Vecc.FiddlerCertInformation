using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vecc.FiddlerCertInformation
{
    public class CertInfoInspector : Inspector2, IResponseInspector2
    {
        #region Private Members

        private readonly CertInfoInspectorTab _informationTab;
        private TabPage _fiddlerTab;

        #endregion Private Members

        #region Constructors

        public CertInfoInspector()
        {
            _informationTab = new CertInfoInspectorTab();
        }

        #endregion Constructors

        #region IResponseInspector2 Members

        public override void AddToTab(TabPage o)
        {
            o.Controls.Add(_informationTab);
            o.Controls[0].Dock = DockStyle.Fill;
            o.Text = "Cert information";

            _fiddlerTab = o;
        }

        public override void AssignSession(Session oS)
        {
            base.AssignSession(oS);
            var dataItems = new List<DataItem>();
            dataItems.Add(new DataItem("Is Https", oS.isHTTPS));

            if (oS.isHTTPS && oS.oFlags.ContainsKey(CertificateStorage.CeritifcateRequestPropertyName))
            {
                try
                {
                    var serialNumber = oS.oFlags[CertificateStorage.CeritifcateRequestPropertyName];
                    FiddlerApplication.Log.LogString(serialNumber);

                    if (CertificateStorage.Certificates.ContainsKey(serialNumber))
                    {
                        var certificate = CertificateStorage.Certificates[serialNumber];
                        var cert = new X509Certificate2(certificate);

                        _informationTab.Certificate = cert;
                        //most commonly desired information up top.
                        dataItems.InsertRange(0, new[] { new DataItem("FriendlyName", cert.FriendlyName),
                                                         new DataItem("Subject", cert.Subject),
                                                         new DataItem("Issuer", cert.Issuer),
                                                         new DataItem("Effective Date", cert.GetEffectiveDateString()),
                                                         new DataItem("Expiration Date", cert.GetExpirationDateString()),
                                                         new DataItem("------------------------", "------------------------")});

                        //alphabatized data properties below
                        dataItems.Add(new DataItem("Archived", cert.Archived));
                        dataItems.Add(new DataItem("FriendlyName", cert.FriendlyName));
                        dataItems.Add(new DataItem("Certficate Hash", cert.GetCertHashString()));
                        dataItems.Add(new DataItem("Certificate Format", cert.GetFormat()));
                        dataItems.Add(new DataItem("Effective Date", cert.GetEffectiveDateString()));
                        dataItems.Add(new DataItem("Expiration Date", cert.GetExpirationDateString()));
                        dataItems.Add(new DataItem("Full Issuer Name", cert.IssuerName.Format(true)));
                        dataItems.Add(new DataItem("Full Subject Name", cert.SubjectName.Format(true)));
                        dataItems.Add(new DataItem("Has Private Key", cert.HasPrivateKey));
                        dataItems.Add(new DataItem("Issuer", cert.Issuer));
                        dataItems.Add(new DataItem("Key Algorithm", cert.GetKeyAlgorithm()));
                        dataItems.Add(new DataItem("Key Algorithm Parameters", cert.GetKeyAlgorithmParametersString()));
                        dataItems.Add(new DataItem("Public Key", cert.GetPublicKeyString()));
                        dataItems.Add(new DataItem("Raw Certificate Data", cert.GetRawCertDataString()));
                        dataItems.Add(new DataItem("SerialNumberString", cert.GetSerialNumberString()));
                        dataItems.Add(new DataItem("Subject", cert.Subject));
                        dataItems.Add(new DataItem("Thumbprint", cert.Thumbprint));
                        dataItems.Add(new DataItem("Version", cert.Version));

                        dataItems.Add(new DataItem("------------------------", "------------------------"));
                        dataItems.Add(new DataItem("Extensions", string.Empty));
                        dataItems.Add(new DataItem("------------------------", "------------------------"));
                        foreach (var extension in cert.Extensions)
                        {
                            dataItems.Add(new DataItem(extension.Oid.FriendlyName, extension.Format(true)));
                        }
                    }
                }
                catch (Exception ex)
                {
                    FiddlerApplication.Log.LogString("Unexpected error loading the assigned certificate." + ex.Message);
                }
            }

            _informationTab.DataGrid.DataSource = dataItems;
        }

        public override int GetOrder()
        {
            return 0;
        }

        public HTTPResponseHeaders headers
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public void Clear()
        {
        }

        public bool bDirty
        {
            get { return false; }
        }

        public bool bReadOnly
        {
            get
            {
                return true;
            }
            set
            {
            }
        }

        public byte[] body
        {
            get;
            set;
        }

        #endregion IResponseInspector2 Members
    }
}
