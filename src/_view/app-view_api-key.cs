using mApiKey;
namespace view{
    public partial class app : Form{
        private initApiKeyMethods mApiKey = new initApiKeyMethods();
        public void vApiAsync(){
            this.ClientSize = new System.Drawing.Size(500,200);
            foreach(System.Windows.Forms.Control? method in mApiKey.initApiKey())this.Controls.Add(method);
        }
    }
}