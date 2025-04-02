using CommunityToolkit.Mvvm.ComponentModel;
using ScholarshipApplicationProject.Console.Models;
using ScholarshipApplicationProject.Console.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipApplicationProject.Desktop.ViewModel
{
    public partial class ControlPanelViewModel : ObservableObject
    {
        private ScholarshipRepo _repo;

        [ObservableProperty]
        private string _numberOfScholarship = string.Empty;

        [ObservableProperty]
        private string _numberOfStudentWithScholarship = string.Empty;

        [ObservableProperty]
        private string _numberOfStudentWithoutScholarship = string.Empty;

        public ControlPanelViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
            NumberOfScholarship = $"Összes diák: {_repo.GetNumberOfScholarship()} fő";
            NumberOfStudentWithScholarship = $"Ösztöndíjat kapó diákok: {_repo.GetNumberOfStudentWithScholarship()} fő";
            NumberOfStudentWithoutScholarship = $"Ösztöndíjat nem kapó diákok: {_repo.GetNumberOfStudentWithoutScholarship()} fő";
        }
    }
}
