using ScholarshipApplicationProject.Console.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipApplicationProject.Desktop.ViewModel
{
    public class ControlPanelViewModel
    {
        private ScholarshipRepo _repo;

        public ControlPanelViewModel(ScholarshipRepo repo)
        {
            _repo = repo;
        }

    }
}
