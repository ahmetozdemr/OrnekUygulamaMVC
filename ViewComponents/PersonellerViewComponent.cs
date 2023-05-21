using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulamaMVC.Models;

namespace OrnekUygulamaMVC.ViewComponents
{
    public class PersonellerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> datas = new List<Personel>
            {
                new Personel(){Name = "Şuaip",Surname = "Abi"},
                new Personel(){Name = "Şakip",Surname = "Bey"},
                new Personel(){Name = "Muhdin",Surname = "Yılmaz"},
            };

            return View(datas);
        }
    }
}
