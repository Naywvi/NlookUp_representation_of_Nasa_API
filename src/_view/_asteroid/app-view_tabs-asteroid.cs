using mTab;
namespace vAsteroid{
    public partial class asteroid : Form{
        private tab mtab = new tab();
        private TabControl dynamicTabControl = new TabControl();
        private TabPage pAsteroid = new TabPage();
        private TabPage pApod = new TabPage();
        private TabPage pResult = new TabPage();
        private void Tabs(){
            this.dynamicTabControl = this.mtab.generateTabControl();
            this.pAsteroid = this.mtab.generateTabPIndex();
            this.pApod = this.mtab.generateTabPApod();
            this.pResult = this.mtab.generateTabPAsteroid();
        }
    }
}