using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGitTest
{
    internal class PdfButton : Button
    {
        
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show(this.Text);
        }
    }
}
