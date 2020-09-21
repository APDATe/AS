using AS.Commands;
using AS.Models;
using System;
using System.Windows.Input;

namespace AS.ViewModels
{
    public class MainViewModel
    {
        public ICommand TestCommand { get; set; }

        public MainViewModel()
        {

            TestCommand = new Command(x => Test());
        }

        private void Test()
        {
            CPVModel model = new CPVModel();
            model.GetIdNames();
                
        }
    }
}
