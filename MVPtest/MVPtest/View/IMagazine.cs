using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPtest.View
{
    public interface IMagazine
    {
        string nameText1 { get; set; }
        string priblText1 { get; set; }
        string nameProd { get; set; }

        string nameText2 { get; set; }
        string priblText2 { get; set; }
        string kolSotr { get; set; }

        string nameText3 { get; set; }
        string priblText3 { get; set; }
        string kolPav { get; set; }

        string areaText { get; set; }
    }
}
