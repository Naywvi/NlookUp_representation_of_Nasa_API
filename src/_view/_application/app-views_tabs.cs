using mTab;
namespace application{
    public partial class appnn : Form{
        private tab mtab = new tab();
        private TabControl dynamicTabControl = new TabControl();
        private TabPage pAsteroid = new TabPage();
        private TabPage pApod = new TabPage();
        private TabPage pRAsteroid = new TabPage();
        private TabPage pRApod = new TabPage();
        private void Tabs(){
            dynamicTabControl = mtab.generateTabControl();
            pAsteroid = mtab.generateTabAsteroid();
            pApod = mtab.generateTabApod();
            pRAsteroid = mtab.generateTabRAsteroid();
            pRApod = mtab.generateTabRApod();
        }
    }
}