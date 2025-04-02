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
    public partial class ScholarshipApplicationManagementViewModel : ObservableObject
    {
        private ScholarshipRepo _repo;

        [ObservableProperty]
        private ObservableCollection<ScholarshipApplicant> _scholarships;

        public ScholarshipApplicationManagementViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
            //Scholarships = new ObservableCollection<ScholarshipApplicant>(_repo.GetAll());
        }

    }
}
