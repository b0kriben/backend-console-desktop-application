using ScholarshipApplicationProject.Console.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipApplicationProject.Desktop.ViewModel
{
    public class ScholarshipApplicationManagementViewModel
    {
        private ScholarshipRepo _repo;

        public ScholarshipApplicationManagementViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
        }

    }
}
