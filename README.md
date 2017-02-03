# docker-fishing-trip

##Using npm behind a proxy
If you're attempting to use npm behind a proxy you may encounter a `407` proxy authentication error when attempting to install packages. To circumvent this, npm has to be configured for your proxy settings. To configure npm, open a command terminal and execute the following commands *(N.B. If using Visual Studio, open the command terminal at the npm executable directory - `C:\Program Files (x86)\Microsoft Visual Studio 14.0\Web\External`)*

````bash
npm config set proxy http://[your.proxy.address]:[your.proxy.port]
npm config set https-proxy://[your.proxy.address]:[your.proxy.port]
````
The above settings will work for the majority of proxy scenarios. However, npm does not currently support the Windows-based [NTLM authentication](https://msdn.microsoft.com/en-gb/library/windows/desktop/aa378749(v=vs.85).aspx) protocol, and therefore it is necessary to route npm calls through a local proxy first that does support NTLM authentication. If you are behind an NTLM proxy, perform the following steps:

1. Install [Fiddler](http://www.telerik.com/fiddler) - a web proxy tool that supports NTLM authentication.
2. Open Fiddler and turn on Automatic Authentication (`Rules > Automatic Authentication`).
3. Open a command terminal and execute the following npm configuration commands to route calls via Fiddler

    ````bash
    npm config set registry http://registry.npmjs.org
    npm config set proxy http://127.0.0.1:8888
    npm config set https-proxy http://127.0.0.1:8888
    npm config set http-proxy http://127.0.0.1:8888
    ````
NOTE: This solution requires that you have Fiddler runnning in the background whilst attempting to install packages.
 
