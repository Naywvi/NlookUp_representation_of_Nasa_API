using masteroidResult;
namespace vRAsteroid{
    public partial class asteroidResult : Form{
        private initAsteroidRMethods mAsteroidR = new initAsteroidRMethods();
        public void vAsteroidResultAsync(){
            this.Tabs();
            foreach(System.Windows.Forms.Control? method in this.mAsteroidR.initAsteroidR())pResult.Controls.Add(method);
            this.dynamicTabControl.TabPages.Add(this.pResult); //<-- Asteroid if result exist
            this.dynamicTabControl.TabPages.Add(this.pAsteroid);
            this.dynamicTabControl.TabPages.Add(this.pApod);
            
            this.Controls.Add(this.dynamicTabControl);
        }
    }
}