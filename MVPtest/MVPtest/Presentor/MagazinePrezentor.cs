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
        public Larec lar = new Larec();
        public Gipermarc gip = new Gipermarc();
        public Universam uni = new Universam();

        IMagazine magazView;
        public MagazinePrezentor(IMagazine view)
        {
            magazView = view;
        }
        public void Deistvie()
        {
            
            lar.name = magazView.nameText1;
            lar.pribl = int.Parse(magazView.priblText1);
            lar.nameProdovec = magazView.nameProd;

            
            gip.name = magazView.nameText3;
            gip.pribl = int.Parse(magazView.priblText3);
            gip.kolpavelion = int.Parse(magazView.kolPav);

            
            uni.name = magazView.nameText2;
            uni.pribl = int.Parse(magazView.priblText2);
            uni.kolSotrud = int.Parse(magazView.kolSotr);
            
            //magazView.areaText = lar.gdebolshezarabativaut().ToString();

           
        }

        public string whoBolshe()
        {
            int g = gip.pribl / gip.kolpavelion;
            int u = uni.pribl / uni.kolSotrud;

            if (lar.pribl > (g))
                return lar.name;
            else if ((g) > (u))
                return gip.name;
            else return uni.name;
        }
       

    }
}
