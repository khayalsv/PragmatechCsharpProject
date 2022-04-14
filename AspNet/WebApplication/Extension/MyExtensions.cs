using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Library
{
    public static class MyExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id="", string typ="button", string text="")
        {
            string html = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>", id, typ.ToString(), text);

            return MvcHtmlString.Create(html);
        }

        public static MvcHtmlString Button(this HtmlHelper helper, string id="", ButtonType typ = ButtonType.button, string text="")
        {
            string html = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>", id, typ.ToString(), text);

            return MvcHtmlString.Create(html);
        }
    }

    public enum ButtonType
    {
        button = 0,
        submit = 1,
        reset = 2
    }
}