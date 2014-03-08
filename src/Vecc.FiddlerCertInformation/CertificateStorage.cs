using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Vecc.FiddlerCertInformation
{
    internal static class CertificateStorage
    {
        #region Constants

        internal const string CeritificateRequestPropertyName = "vecc.certinformation.serialnumber";

        #endregion Constants

        #region Properties

        internal static IDictionary<string, X509Certificate> Certificates = new Dictionary<string, X509Certificate>();

        #endregion Properties
    }
}
