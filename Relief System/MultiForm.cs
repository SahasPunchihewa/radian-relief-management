using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Relief_System
{
    class MultiForm:ApplicationContext
    {
        private int OpenForms;

        public MultiForm(params Form[] forms)
        {
            OpenForms = forms.Length;
            foreach(var form in forms)
            {
                form.FormClosed += (s, args) =>
                  {
                      if (Interlocked.Decrement(ref OpenForms) == 0)
                          ExitThread();
                  };
                form.Show();
            }
        }
    }
}
