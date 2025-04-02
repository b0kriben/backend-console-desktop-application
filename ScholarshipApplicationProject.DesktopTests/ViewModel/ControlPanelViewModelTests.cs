using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScholarshipApplicationProject.Console.Repo;
using ScholarshipApplicationProject.Desktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipApplicationProject.Desktop.ViewModel.Tests
{
    [TestClass()]
    public class ControlPanelViewModelTests
    {
        [TestMethod()]
        public void ControlPanelViewModelTesNumberOfScholarshipt()
        {
            // arrange
            ScholarshipRepo repo = new ScholarshipRepo();
            ControlPanelViewModel viewModel = new ControlPanelViewModel(repo);

            // act
            string expected = "20 fő";
            string actual = viewModel.NumberOfScholarship;

            // assert
            Assert.AreEqual(expected, actual, "Az ösztöndíjasok szám nem megfelelő!");
        }
    }
}