using mAsteroid;
namespace view{
    public partial class app : Form{
        private initAsteroidMethod masteroid = new initAsteroidMethod();
        public void vAsteroidAsync(){
            this.Tabs();
            foreach(System.Windows.Forms.Control? method in this.masteroid.initAsteroid())this.pAsteroid.Controls.Add(method);
            this.dynamicTabControl.TabPages.Add(this.pAsteroid);
            this.dynamicTabControl.TabPages.Add(this.pApod);
            
            this.Controls.Add(this.dynamicTabControl);
        }
    }
}