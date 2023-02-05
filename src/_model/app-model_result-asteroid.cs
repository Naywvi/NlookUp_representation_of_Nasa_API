/**************************************************************************************************************************
* Here we will find all the properties containing the visual of the result of the asteroid search as well as their orbits *
**************************************************************************************************************************/
using config;
namespace masteroidResult{
    public class initAsteroidRMethods{
        private ARborders mARborders = new ARborders();
        private ARNameAsteroide mARNameAsteroide = new ARNameAsteroide();
        private ARDescriptionAsteroide mARInformationAboutUs = new ARDescriptionAsteroide();
        private ARDescriptionDistanceAsteroide mARInformationAboutUsDistances = new ARDescriptionDistanceAsteroide();
        private ARRecapAsteroide mARRecap = new ARRecapAsteroide();
        private ARDescAsteroide mADesc = new ARDescAsteroide();
        private AROrbitList mARList = new AROrbitList();
        private AROrbitVelocity mARVelocity = new AROrbitVelocity();
        private AROrbitMiss mARMiss = new AROrbitMiss();
        public List<Control?> initAsteroidR(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(mARNameAsteroide.ARName());

            list.Add(mARInformationAboutUs.ARSuspicious());
            list.Add(mARInformationAboutUs.ARMagnitude());
            list.Add(mARInformationAboutUs.ARUncertain());
            list.Add(mARInformationAboutUs.AREquinox());

            list.Add(mARInformationAboutUsDistances.ARkm());
            list.Add(mARInformationAboutUsDistances.ARml());
            list.Add(mARInformationAboutUsDistances.AestimHmax());
            list.Add(mARInformationAboutUsDistances.AestimHmin());
            list.Add(mARInformationAboutUsDistances.AestimSmax());
            list.Add(mARInformationAboutUsDistances.AestimSmin());

            list.Add(mARRecap.ARFirstOrbit());
            list.Add(mARRecap.ARLastOrbit());
            list.Add(mARRecap.ARFuturOrbit());
            list.Add(mARRecap.ARNumberOrbit());

            list.Add(mADesc.ARDescription());

            list.Add(mARList.AROrbitL());

            list.Add(mARVelocity.AROrbitV());
            list.Add(mARVelocity.AROrbitV2());
            list.Add(mARVelocity.AROrbitV3());
            list.Add(mARVelocity.AROrbitV4());

            list.Add(mARMiss.AROrbitM());
            list.Add(mARMiss.AROrbitM2());
            list.Add(mARMiss.AROrbitM3());
            list.Add(mARMiss.AROrbitM4());
            list.Add(mARMiss.AROrbitM5());

            list.Add(mARborders.ARborderTitle());
            list.Add(mARborders.ARborderInformationAboutUs());
            list.Add(mARborders.ARborderInformationAboutUsDistances());
            list.Add(mARborders.ARborderOrbits());
            list.Add(mARborders.ARborderDescription());
            list.Add(mARborders.ARborderInformationVelocity());
            list.Add(mARborders.ARborderInformationMiss());
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
            func.ARNameAsteroide.Location = new System.Drawing.Point(10,10);
            func.ARNameAsteroide.Size = new System.Drawing.Size(480,50);
            func.ARNameAsteroide.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            func.ARNameAsteroide.TextAlign = ContentAlignment.MiddleCenter;
            return func.ARNameAsteroide;
        }
    }
    // Label for asteroide description _model
    public class ARDescriptionAsteroide{
        public Label ARSuspicious(){
            func.ARSuspicious.Location = new System.Drawing.Point(20,80);
            func.ARSuspicious.Font = new System.Drawing.Font("Georgia", 8);
            func.ARSuspicious.Size = new System.Drawing.Size(450,20);
            return func.ARSuspicious;
        }
        public Label ARMagnitude(){
            func.ARMagnitude.Location = new System.Drawing.Point(20,100);
            func.ARMagnitude.Font = new System.Drawing.Font("Georgia", 8);
            func.ARMagnitude.Size = new System.Drawing.Size(450,20);
            return func.ARMagnitude;
        }
        public Label ARUncertain(){
            func.ARUncertain.Location = new System.Drawing.Point(20,120);
            func.ARUncertain.Font = new System.Drawing.Font("Georgia", 8);
            func.ARUncertain.Size = new System.Drawing.Size(450,20);
            return func.ARUncertain;
        }
        public Label AREquinox(){
            func.AREquinox.Location = new System.Drawing.Point(20,140);
            func.AREquinox.Font = new System.Drawing.Font("Georgia", 8);
            func.AREquinox.Size = new System.Drawing.Size(450,20);
            return func.AREquinox;
        }
    }
    // Label for asteroide description _model
    public class ARDescriptionDistanceAsteroide{
        
        public RadioButton ARkm(){
            func.ARkm.Location = new System.Drawing.Point(510,20);
            func.ARkm.Checked = true;
            func.ARkm.Size = new System.Drawing.Size(150,20);
            func.ARkm.Font = new System.Drawing.Font("Georgia", 8);
            func.ARkm.Text = "Scales in km";
            return func.ARkm;
        }
        public RadioButton ARml(){
            func.ARml.Location = new System.Drawing.Point(670,20);
            func.ARml.Size = new System.Drawing.Size(150,20);
            func.ARml.Font = new System.Drawing.Font("Georgia", 8);
            func.ARml.Text = "Scales in Miles";
            return func.ARml;
        }
        public Label AestimHmax(){
            func.estimHmax.Location = new System.Drawing.Point(510,80);
            func.estimHmax.Size = new System.Drawing.Size(460,20);
            func.estimHmax.Font = new System.Drawing.Font("Georgia", 8);
            return func.estimHmax;
        }
        public Label AestimHmin(){
            func.estimHmin.Location = new System.Drawing.Point(510,100);
            func.estimHmin.Size = new System.Drawing.Size(460,20);
            func.estimHmin.Font = new System.Drawing.Font("Georgia", 8);
            return func.estimHmin;
        }
        public Label AestimSmax(){
            func.estimSmax.Location = new System.Drawing.Point(510,120);
            func.estimSmax.Size = new System.Drawing.Size(460,20);
            func.estimSmax.Font = new System.Drawing.Font("Georgia", 8);
            return func.estimSmax;
        }
        public Label AestimSmin(){
            func.estimSmin.Location = new System.Drawing.Point(510,140);
            func.estimSmin.Size = new System.Drawing.Size(460,20);
            func.estimSmin.Font = new System.Drawing.Font("Georgia", 8);
            return func.estimSmin;
        }

    }
    // Label for Recap asteroide Orbit _model
    public class ARRecapAsteroide{
        public Label ARFirstOrbit(){
            func.ARFirst.Location = new System.Drawing.Point(20,190);
            func.ARFirst.Size = new System.Drawing.Size(800,20);
            func.ARFirst.Font = new System.Drawing.Font("Georgia", 8);
            return func.ARFirst;
        }
        public Label ARLastOrbit(){
            func.ARLast.Location = new System.Drawing.Point(20,210);
            func.ARLast.Size = new System.Drawing.Size(800,20);
            func.ARLast.Font = new System.Drawing.Font("Georgia", 8);
            return func.ARLast;
        }
        public Label ARFuturOrbit(){
            func.ARFutur.Location = new System.Drawing.Point(20,230);
            func.ARFutur.Font = new System.Drawing.Font("Georgia", 8);
            func.ARFutur.Size = new System.Drawing.Size(800,20);
            return func.ARFutur;
        }
        public Label ARNumberOrbit(){
            func.ARNumber.Location = new System.Drawing.Point(20,250);
            func.ARNumber.Size = new System.Drawing.Size(800,20);
            func.ARNumber.Font = new System.Drawing.Font("Georgia", 8);
            return func.ARNumber;
        }
    }
    // Label for Description asteroide _model
    public class ARDescAsteroide{
        public Label ARDescription(){
            func.ARDescriptionA.Location = new System.Drawing.Point(20,300);
            func.ARDescriptionA.Size = new System.Drawing.Size(950,80);
            func.ARDescriptionA.Font = new System.Drawing.Font("Georgia", 10);
            func.ARDescriptionA.TextAlign = ContentAlignment.MiddleCenter;
            return func.ARDescriptionA;
        }
    }
    // List for Orbit asteroide _model
    public class AROrbitList{
        public ListBox AROrbitL(){
            func.listOrbit.Location = new Point(10 , 400);
            func.listOrbit.Size = new Size(480,260);
            func.listOrbit.BorderStyle = BorderStyle.Fixed3D;
            func.listOrbit.Font = new System.Drawing.Font("Georgia", 8);
            
            func.listOrbit.DoubleClick += new EventHandler((sender, e) => {
                
                if (func.listOrbit.SelectedItem != null){
                    var id = func.listOrbit.SelectedItem.ToString().Split(' ');
                    func.getResultAsteroidOrbit(id[0]);
                }
            });
            return func.listOrbit;
        }
    }
    // Label for Orbit asteroide _model
    public class AROrbitVelocity{
        public Label AROrbitV(){
            func.AROrbitV.Location = new System.Drawing.Point(510,410);
            func.AROrbitV.Size = new System.Drawing.Size(460,20);
            func.AROrbitV.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitV;
        }
        public Label AROrbitV2(){
            func.AROrbitV2.Location = new System.Drawing.Point(510,450);
            func.AROrbitV2.Size = new System.Drawing.Size(460,20);
            func.AROrbitV2.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitV2;
        }
        public Label AROrbitV3(){
            func.AROrbitV3.Location = new System.Drawing.Point(510,470);
            func.AROrbitV3.Size = new System.Drawing.Size(460,20);
            func.AROrbitV3.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitV3;
        }
        public Label AROrbitV4(){
            func.AROrbitV4.Location = new System.Drawing.Point(510,490);
            func.AROrbitV4.Size = new System.Drawing.Size(460,20);
            func.AROrbitV4.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitV4;
        }
    }
    public class AROrbitMiss{
        public Label AROrbitM(){
            func.AROrbitM.Location = new System.Drawing.Point(510,545);
            func.AROrbitM.Size = new System.Drawing.Size(460,20);
            func.AROrbitM.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitM;
        }
        public Label AROrbitM2(){
            func.AROrbitM2.Location = new System.Drawing.Point(510,570);
            func.AROrbitM2.Size = new System.Drawing.Size(460,20);
            func.AROrbitM2.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitM2;
        }
        public Label AROrbitM3(){
            func.AROrbitM3.Location = new System.Drawing.Point(510,590);
            func.AROrbitM3.Size = new System.Drawing.Size(460,20);
            func.AROrbitM3.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitM3;
        }
        public Label AROrbitM4(){
            func.AROrbitM4.Location = new System.Drawing.Point(510,610);
            func.AROrbitM4.Size = new System.Drawing.Size(460,20);
            func.AROrbitM4.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitM4;
        }
        public Label AROrbitM5(){
            func.AROrbitM5.Location = new System.Drawing.Point(510,630);
            func.AROrbitM5.Size = new System.Drawing.Size(460,20);
            func.AROrbitM5.Font = new System.Drawing.Font("Georgia", 8);
            return func.AROrbitM5;
        }
    }
}