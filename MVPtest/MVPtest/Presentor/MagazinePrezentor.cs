using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPtest.View;
using MVPtest.Models;

namespace MVPtest.Presentor
{
    public class MagazinePrezentor
    {
        IMagazine magazView;
        public MagazinePrezentor(IMagazine view)
        {
            magazView = view;
        }
        public void Deistvie()
        {
            Magazine magaz = new Magazine();
            magaz.name = magazView.nameText;
            magaz.pribl = int.Parse(magazView.priblText);

            magazView.areaText = magaz.gdebolshezarabativaut().ToString();
        }

    }
}
