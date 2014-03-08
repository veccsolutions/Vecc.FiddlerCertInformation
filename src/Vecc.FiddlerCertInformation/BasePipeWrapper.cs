using Fiddler;
using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;

namespace Vecc.FiddlerCertInformation
{
    public class BasePipeWrapper
    {
        #region Private Members

        private readonly BasePipe _pipe;

        private static FieldInfo _httpsStreamField;
        private static FieldInfo _socketField;
        private static FieldInfo _pipeNameField;
        private static FieldInfo _useCountField;

        #endregion Private Members

        #region Constructors

        static BasePipeWrapper()
        {
            var basePipeType = Type.GetType("Fiddler.BasePipe,Fiddler");

            _socketField = basePipeType.GetField("_baseSocket", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            _httpsStreamField = basePipeType.GetField("_httpsStream", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            _pipeNameField = basePipeType.GetField("_sPipeName", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            _useCountField = basePipeType.GetField("iUseCount", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        }

        public BasePipeWrapper(BasePipe pipe)
        {
            _pipe = pipe;
        }

        #endregion Constructors

        #region Properties

        public Socket Socket
        {
            get { return _socketField.GetValue(_pipe) as Socket; }
        }

        public SslStream HttpsStream
        {
            get { return _httpsStreamField.GetValue(_pipe) as SslStream; }
        }

        public string PipeNameField
        {
            get { return _pipeNameField.GetValue(_pipe) as string; }
        }

        public int UseCount
        {
            get { return (int)_useCountField.GetValue(_pipe); }
        }

        #endregion Properties
    }
}
