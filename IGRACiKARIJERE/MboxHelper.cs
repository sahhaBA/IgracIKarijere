using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGRACiKARIJERE
{
    public class MboxHelper
    {
        public static void PrikaziGresku(Exception ex) 
        {
            MessageBox.Show(ex.Message + ex.InnerException?.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
