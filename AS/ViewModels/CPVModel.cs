using AS.Context;
using AS.Models;
using AS.View;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Windows.Input;

namespace AS.ViewModels
{
    class CPVModel 
    {
        public Configerationpanel Model { get; set; } = new Configerationpanel();
        public ICommand GenCommand { get; set; }

        public void  GetIdNames()
        {
          
            //DataTable Dats = new DataTable();

            using (var context = new CPContext())
            {
                context.Nomenclaturas.Load();

                var fff = context.Nomenclaturas.Local;

            }

        }
    }
}
