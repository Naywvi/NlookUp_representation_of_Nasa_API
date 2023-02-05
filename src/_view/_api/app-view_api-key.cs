/*************************************************************************************************
* Here we will find the launch of the application allowing the verification of the NASA API code *
**************************************************************************************************/
using mApiKey;
namespace vApi{
    public partial class api : Form{
        private initApiKeyMethods mApiKey = new initApiKeyMethods();
        public void vApiAsync(){
            foreach(System.Windows.Forms.Control? method in mApiKey.initApiKey())Controls.Add(method);
        }
    }
}