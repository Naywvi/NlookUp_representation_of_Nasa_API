using mapodResult;
namespace vRApod{
    public partial class apodResult : Form{
        private initApodRMehods mApodR = new initApodRMehods();
        public void vApodResult(){
            this.Tabs();
            foreach(System.Windows.Forms.Control? method in this.mApodR.initApodR())pResult.Controls.Add(method);
            this.dynamicTabControl.TabPages.Add(this.pResult); //<-- Asteroid if result exist
            this.dynamicTabControl.TabPages.Add(this.pAsteroid);
            this.dynamicTabControl.TabPages.Add(this.pApod);
            
            this.Controls.Add(this.dynamicTabControl);
        }
    }
}