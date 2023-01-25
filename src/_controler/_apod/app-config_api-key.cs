using config;
namespace vApod{
    partial class apod{
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing){
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(conf.height, conf.width);

            //<< Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Text = "nlook up";
            this.viewLoad();
        }
    }
}