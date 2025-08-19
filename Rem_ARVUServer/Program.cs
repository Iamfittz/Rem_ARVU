using RemObjects.SDK.Server;

namespace Rem_ARVU {
    static class Program {
        public static int Main(string[] args) {
            ApplicationServer server = new ApplicationServer("Rem_ARVU");

            //
            // Some optional setup for your server:
            //

            // TLS
            // Create a certificate on first run
            // Self-signed certificates are rejected by default so additional code
            // might be needed client-side to properly handle them. Please refer to
            // https://docs.remotingsdk.com/Clients/Tasks/HandlingSelfSignedCertificates/
            // for more details
            //server.AutoCreateSelfSignedCertificate = true;

            // Enable traffic encryption
            //server.NetworkServer.UseTLS = true;
            //server.NetworkServer.TlsProtocols = "Tls,Tls11,Tls12,Tls13";

            // Optionally, load certificate from file
            // or load certificate with provided thumbprint from the system certificate store
            // or load certificate from elsewhere and provide it directly
            //server.NetworkServer.CertificateFileName = "</path/to/certificate>";
            //server.NetworkServer.CertificateThumbprint = "XX XX XX ...";
            //server.NetworkServer.Certificate = <certificate instance>

            server.NetworkServer.ServerChannel = new RemObjects.SDK.Server.IpHttpServerChannel();
            //server.NetworkServer.ServerChannel.SecurityOptions.MaxRequestSize = 10 * 1024 * 1024;
            server.NetworkServer.Port = 8099;

            server.Run(args);
            return 0;
        }
    }
}
