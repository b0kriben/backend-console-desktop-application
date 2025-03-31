using ScholarshipApplicationProject.Console.Repo;

namespace ScholarshipApplicationProject.Desktop.ViewModel
{
    public class MainViewModel
    {
        private ScholarshipRepo _repo = new ScholarshipRepo();

        public ControlPanelViewModel ControlPanelViewModel { get; set; }
        public ScholarshipApplicationManagementViewModel ScholarshipApplicantManagmentViewModel { get; set; }

        public MainViewModel()
        {
            ControlPanelViewModel = new ControlPanelViewModel(_repo);
            ScholarshipApplicantManagmentViewModel = new ScholarshipApplicationManagementViewModel(_repo);
        }
    }
}
