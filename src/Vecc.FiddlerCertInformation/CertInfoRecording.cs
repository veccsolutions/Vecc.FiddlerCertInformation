using Fiddler;
using System.Security.Cryptography.X509Certificates;

namespace Vecc.FiddlerCertInformation
{
    public class CertInfoRecording : IAutoTamper
    {
        #region IAutoTamper Members

        public void AutoTamperRequestAfter(Session oSession)
        {
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            if (oSession.isHTTPS)
            {
                var pipe = oSession.oResponse.pipeServer;
                if (pipe != null)
                {
                    var wrapper = new BasePipeWrapper(oSession.oResponse.pipeServer);
                    var certificate = wrapper.HttpsStream.RemoteCertificate;
                    var cert = new X509Certificate2(certificate);
                    var thumbprint = cert.Thumbprint;

                    CertificateStorage.Certificates[thumbprint] = certificate;
                    oSession.oFlags.Add(CertificateStorage.CeritificateRequestPropertyName, thumbprint);
                }
            }
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnBeforeUnload()
        {
        }

        public void OnLoad()
        {
        }

        #endregion IAutoTamper Members
    }
}
