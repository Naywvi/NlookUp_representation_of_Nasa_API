namespace view{
    partial class app{
        private int _height = 1000;
        public int height{
            get => _height;
        }
        private int _width = 700;
        public int width{
            get => _width;
        }
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        private void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(this.height, this.width);

            //<< Disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Text = "nlook up";
            this.viewLoad("api");
        }
        #endregion
    }
}