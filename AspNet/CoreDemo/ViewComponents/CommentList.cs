using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    Username="Khayal"
                },
                 new UserComment
                {
                    Id=2,
                    Username="Sadiq"
                },
            };
            return View(values);
        }
    }
}
