using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullNameProject
{
    public class PersonConfig
    {

        public static Window FrmEditPerson { get; set; }

        //view model
        public static PersonViewModel VueModel { get; set; }

        static PersonConfig()
        {
            VueModel = new PersonViewModel();
            FrmEditPerson = new FrmEditWindow();

        }
    }

}
}
