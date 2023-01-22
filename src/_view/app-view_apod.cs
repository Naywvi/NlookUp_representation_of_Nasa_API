using mApod;
namespace view{
    public partial class app : Form{
        private initApodMethod mapod = new initApodMethod();
        public void vApodAsync(){
            this.Tabs();
            foreach(System.Windows.Forms.Control? method in this.mapod.initApod())this.pApod.Controls.Add(method);
            this.dynamicTabControl.TabPages.Add(this.pApod);
            this.dynamicTabControl.TabPages.Add(this.pAsteroid);
        
            this.Controls.Add(this.dynamicTabControl);
        }
    }
}