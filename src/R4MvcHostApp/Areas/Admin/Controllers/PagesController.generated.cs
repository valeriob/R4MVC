// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

namespace R4MvcHostApp.Areas.Admin.Controllers
{
    public partial class PagesController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public PagesController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected PagesController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public PagesController Actions => MVC.AdminArea.Pages;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Pages";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Pages";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
            }
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_PagesController : R4MvcHostApp.Areas.Admin.Controllers.PagesController
    {
        public R4MVC_PagesController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void IndexOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
