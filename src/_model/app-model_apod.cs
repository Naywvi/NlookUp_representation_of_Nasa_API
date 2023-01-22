namespace mApod{
    // Callback of apod _model
    public class initApodMethod{
        //apod callbacks
        private Afilters apodFilters = new Afilters();
        private Apresentation apodPresentation = new Apresentation();
        private Alist apodList = new Alist();
        private Aloading apodLoading = new Aloading();

        //List all methods to init apod view
        public List<System.Windows.Forms.Control?> initApod(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(this.apodPresentation.generatePresentation());
            list.Add(this.apodFilters.filtersTitle());
            list.Add(this.apodFilters.filtersSelectionDefault());
            list.Add(this.apodFilters.filtersSelectionCustom());
            list.Add(this.apodFilters.filtersBorders());
            list.Add(this.apodFilters.filtersCustomLabelStartDate());
            list.Add(this.apodFilters.filtersCustomStartDate());
            list.Add(this.apodFilters.filtersCustomLabelEndDate());
            list.Add(this.apodFilters.filtersCustomEndDate());
            list.Add(this.apodFilters.filtersButton());
            list.Add(this.apodFilters.filtersCustomBorders());
            list.Add(this.apodList.generatedList());
            list.Add(this.apodLoading.generateLoading());
            return list;
        }
    }
    // Loading apod _model
    public class Aloading{
        public ProgressBar generateLoading(){
            ProgressBar loading = new ProgressBar();
            loading.Location = new Point(10, 630);
            loading.Width = 970;
            loading.Minimum = 0;
            loading.Maximum = 100;
            loading.Value = 40;
            return loading;
        }
    }

    // List apod _model
    public class Alist{
        public ListBox generatedList(){
            ListBox list = new ListBox();
            list.Location = new Point(10 , 180);
            list.Size = new Size(10,440);
            list.Width = 970;
            list.BorderStyle = BorderStyle.Fixed3D;
            //generateItem(); //<---- depuis l'api
            list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");
            return list;
        }
    }
    // Presentation apod _model
    public class Apresentation{
        private string headerPresentation = "bla bla bla";
        public Label generatePresentation(){
            Label presentation = new Label();
            presentation.Text = this.headerPresentation;
            presentation.Location = new Point(10, 10);
            presentation.Size = new Size(10, 100);
            presentation.Width = 970;
            presentation.TextAlign = ContentAlignment.MiddleCenter;
            presentation.BorderStyle = BorderStyle.Fixed3D;
            return presentation;
        }
    }
    // Filters apod _model
    public class Afilters{
        public Button filtersButton(){
            Button btnSubmit = new Button();
            btnSubmit.Location = new Point(810,124);
            btnSubmit.Text = "Submit";
            btnSubmit.Size = new Size(160,30);
            return btnSubmit;
        }
        public TextBox filtersCustomEndDate(){
            TextBox endDateT = new TextBox();
            endDateT.Location = new Point(670,126);
            endDateT.PlaceholderText = "YYYY-MM-DD";
            endDateT.Width = 130;
            return endDateT;
        }
        public Label filtersCustomLabelEndDate(){
            Label endDateL = new Label();
            endDateL.Location = new Point(580,130);
            endDateL.Text = "End date: ";
            endDateL.Size = new Size(80,20);
            return endDateL;
        }
         public TextBox filtersCustomStartDate(){
            TextBox startDateT = new TextBox();
            startDateT.Location = new Point(430,127);
            startDateT.PlaceholderText = "YYYY-MM-DD";
            startDateT.Width = 130;
            return startDateT;
        }
        public Label filtersCustomLabelStartDate(){
            Label startDateL = new Label();
            startDateL.Location = new Point(330,130);
            startDateL.Text = "Start date: ";
            return startDateL;
        }
        public Label filtersCustomBorders(){
            Label bordersCFilters = new Label();
            bordersCFilters.Location = new Point(325,120);
            bordersCFilters.Size = new Size(40,40);
            bordersCFilters.Width = 655;
            bordersCFilters.BorderStyle = BorderStyle.Fixed3D;
            return bordersCFilters;
        }
        public RadioButton filtersSelectionCustom(){
            RadioButton selectionCustom = new RadioButton();
            selectionCustom.Location = new Point(205,127);
            selectionCustom.Text = "Custom";
            return selectionCustom;
        }
        public RadioButton filtersSelectionDefault(){
            RadioButton selectionDefault = new RadioButton();
            selectionDefault.Location = new Point(100,127);
            selectionDefault.Text = "default";
            return selectionDefault;
        }
        public Label filtersTitle(){
            Label filters = new Label();
            filters.Location = new Point(15,130);
            filters.Size = new Size(60,20);
            filters.Text = "Filters:";
            return filters;
        }
        public Label filtersBorders(){
            Label borders = new Label();
            borders.BorderStyle = BorderStyle.Fixed3D;
            borders.Location = new Point(10 , 120);
            borders.Size = new Size(40,40);
            borders.Width = 300;
            return borders;
        }
    }
}