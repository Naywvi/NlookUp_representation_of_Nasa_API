using mApod;
using mIndex;
using mTab;
using mApiKey;
using asteroidResult;
using apodResult;
namespace nlook_up{
    public partial class app : Form{
        //<< tab
        private tab mtab = new tab();

        //<< initialisator
        private initAsteroidMethod masteroid = new initAsteroidMethod();
        private initApodMethod mapod = new initApodMethod();
        private initApiKeyMethods mApiKey = new initApiKeyMethods();
        private initApodRMehods mApodR = new initApodRMehods();
        private initAsteroidRMethods mAsteroidR = new initAsteroidRMethods();
        public app(){
            InitializeComponent();
        }
        
        private void viewLoad(string view){
            var dynamicTabControl = this.mtab.generateTabControl();
            var index = this.mtab.generateTabPIndex();
            var apod = this.mtab.generateTabPApod();
            var result = this.mtab.generateTabPAsteroid();
            var list = new List<System.Windows.Forms.Control?>();

            switch (view){
                case "api":
                    this.ClientSize = new System.Drawing.Size(500,200);
                    list = mApiKey.initApiKey();
                    foreach(System.Windows.Forms.Control? method in list)this.Controls.Add(method);
                    return;
                case "asteroid":
                    list = this.masteroid.initAsteroid();
                    foreach(System.Windows.Forms.Control? method in list)index.Controls.Add(method);
                    dynamicTabControl.TabPages.Add(index);
                    dynamicTabControl.TabPages.Add(apod);
                    break;
                case "apod":
                    list = this.mapod.initApod();
                    foreach(System.Windows.Forms.Control? method in list)apod.Controls.Add(method);
                    dynamicTabControl.TabPages.Add(apod);
                    dynamicTabControl.TabPages.Add(index);
                    break;
                case "result-asteroid":
                    list = this.mAsteroidR.initAsteroidR();
                    foreach(System.Windows.Forms.Control? method in list)result.Controls.Add(method);
                    dynamicTabControl.TabPages.Add(result); //<-- Asteroid if result exist
                    dynamicTabControl.TabPages.Add(index);
                    dynamicTabControl.TabPages.Add(apod);
                    break;
                case "result-apod":
                    list = this.mApodR.initApodR();
                    foreach(System.Windows.Forms.Control? method in list)result.Controls.Add(method);
                    dynamicTabControl.TabPages.Add(result); //<-- Apod if result exist
                    dynamicTabControl.TabPages.Add(index);
                    dynamicTabControl.TabPages.Add(apod);
                    break;
            }

            this.Controls.Add(dynamicTabControl);
        }
    }
}