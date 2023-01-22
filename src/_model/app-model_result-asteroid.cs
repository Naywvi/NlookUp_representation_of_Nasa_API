namespace asteroidResult{
    
    public class initAsteroidRMethods{
        private ARborders mARborders = new ARborders();
        private ARNameAsteroide mARNameAsteroide = new ARNameAsteroide();
        private ARDescriptionAsteroide mARInformationAboutUs = new ARDescriptionAsteroide();
        private ARRecapAsteroide mARInformationAboutUsDistances = new ARRecapAsteroide();
        private ARDescAsteroide mAROrbits = new ARDescAsteroide();
        private AROrbitList mAROrbitList = new AROrbitList();
        private AROrbitVelocity mARInformationVelocity = new AROrbitVelocity();
        private AROrbitMiss mARInformationMiss = new AROrbitMiss();

        public List<Control?> initAsteroidR(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(this.mARNameAsteroide.ARName());

            list.Add(this.mARborders.ARborderTitle());
            list.Add(this.mARborders.ARborderInformationAboutUs());
            list.Add(this.mARborders.ARborderInformationAboutUsDistances());
            list.Add(this.mARborders.ARborderOrbits());
            list.Add(this.mARborders.ARborderDescription());
            list.Add(this.mARborders.ARborderOrbitList());
            list.Add(this.mARborders.ARborderInformationVelocity());
            list.Add(this.mARborders.ARborderInformationMiss());
            return list;
        }
    }

    //class ARborders for all borders _model
    public class ARborders{
        public Label ARborderTitle(){
            Label ARborderTitle = new Label();
            ARborderTitle.Location = new System.Drawing.Point(10,10);
            ARborderTitle.Size = new System.Drawing.Size(480,50);
            ARborderTitle.BorderStyle = BorderStyle.Fixed3D;
            return ARborderTitle;
        }
        public Label ARborderInformationAboutUs(){
            Label ARborderInformation = new Label();
            ARborderInformation.Location = new System.Drawing.Point(10,70);
            ARborderInformation.Size = new System.Drawing.Size(480,100);
            ARborderInformation.BorderStyle = BorderStyle.Fixed3D;
            return ARborderInformation;
        }
        public Label ARborderInformationAboutUsDistances(){
            Label ARborderAboutUs = new Label();
            ARborderAboutUs.Location = new System.Drawing.Point(500,10);
            ARborderAboutUs.Size = new System.Drawing.Size(480,160);
            ARborderAboutUs.BorderStyle = BorderStyle.Fixed3D;
            return ARborderAboutUs;
        }
        public Label ARborderOrbits(){
            Label ARborderOrbits = new Label();
            ARborderOrbits.Location = new System.Drawing.Point(10,180);
            ARborderOrbits.Size = new System.Drawing.Size(970,100);
            ARborderOrbits.BorderStyle = BorderStyle.Fixed3D;
            return ARborderOrbits;
        }
        public Label ARborderDescription(){
            Label ARborderDescription = new Label();
            ARborderDescription.Location = new System.Drawing.Point(10,290);
            ARborderDescription.Size = new System.Drawing.Size(970,100);
            ARborderDescription.BorderStyle = BorderStyle.Fixed3D;
            return ARborderDescription;
        }
        public Label ARborderOrbitList(){
            Label ARborderList = new Label();
            ARborderList.Location = new System.Drawing.Point(10,400);
            ARborderList.Size = new System.Drawing.Size(480,260); 
            ARborderList.BorderStyle = BorderStyle.Fixed3D;
            return ARborderList;
        }
        public Label ARborderInformationVelocity(){
            Label ARborderVelocity = new Label();
            ARborderVelocity.Location = new System.Drawing.Point(500,400);
            ARborderVelocity.Size = new System.Drawing.Size(480,125);
            ARborderVelocity.BorderStyle = BorderStyle.Fixed3D;
            return ARborderVelocity;
        }
        public Label ARborderInformationMiss(){
            Label ARborderMiss = new Label();
            ARborderMiss.Location = new System.Drawing.Point(500,535);
            ARborderMiss.Size = new System.Drawing.Size(480,125);
            ARborderMiss.BorderStyle = BorderStyle.Fixed3D;
            return ARborderMiss;
        }
    }
    // Label for asteroide name _model
    public class ARNameAsteroide{
        public Label ARName(){
            Label ARNameAsteroide = new Label();
            ARNameAsteroide.Location = new System.Drawing.Point(10,10);
            ARNameAsteroide.Size = new System.Drawing.Size(480,50);
            ARNameAsteroide.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            ARNameAsteroide.Text = "Asteroid Name";
            ARNameAsteroide.TextAlign = ContentAlignment.MiddleCenter;
            ARNameAsteroide.BorderStyle = BorderStyle.Fixed3D;
            return ARNameAsteroide;
        }
    }
    public class ARDescriptionAsteroide{

    }
    public class ARDescriptionDistanceAsteroide{

    }
    public class ARRecapAsteroide{

    }
    public class ARDescAsteroide{

    }
    public class AROrbitList{

    }
    public class AROrbitVelocity{

    }
    public class AROrbitMiss{

    }
}