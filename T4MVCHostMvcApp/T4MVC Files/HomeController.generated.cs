// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVCHostMvcApp.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Blah()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Blah);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ActionWithArrayParam()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithArrayParam);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ActionWithSomeOptionalParams()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithSomeOptionalParams);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ActionWithParamUsingAtSyntax()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithParamUsingAtSyntax);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ActionThatRequiresHttps()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionThatRequiresHttps, "https");
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SomeTaskBasedActionWithParams()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SomeTaskBasedActionWithParams);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string AsyncTask = "AsyncTask";
            public readonly string Index = "Index";
            public readonly string About = firstConst + " " + secondConst;
            public readonly string Blah = "New-Name for Blah";
            public readonly string SomeViewResultAction = "SomeViewResultAction";
            public readonly string SomeJsonResultAction = "SomeJsonResultAction";
            public readonly string SomeFileContentResultAction = "SomeFileContentResultAction";
            public readonly string SomeFileStreamResultAction = "SomeFileStreamResultAction";
            public readonly string SomeFileResultAction = "SomeFileResultAction";
            public readonly string SomeCustomResultAction = "SomeCustomResultAction";
            public readonly string ActionWithArrayParam = "ActionWithArrayParam";
            public readonly string ActionWithAllOptionalParams = "ActionWithAllOptionalParams";
            public readonly string ActionWithSomeOptionalParams = "ActionWithSomeOptionalParams";
            public readonly string ActionWithOptionalParamDefaultingToNull = "ActionWithOptionalParamDefaultingToNull";
            public readonly string ActionWithParamUsingAtSyntax = "ActionWithParamUsingAtSyntax";
            public readonly string ActionThatUsesActionNameConstantInAttribute = "ActionThatUsesActionNameConstantInAttribute";
            public readonly string ActionThatRequiresHttps = "ActionThatRequiresHttps";
            public readonly string OverloadedActionWithDifferentParams = "OverloadedActionWithDifferentParams";
            public readonly string ActionReturningGenericResultString = "ActionReturningGenericResultString";
            public readonly string ActionReturningGenericResultInt = "ActionReturningGenericResultInt";
            public readonly string ActionReturningGenericResultNested = "ActionReturningGenericResultNested";
            public readonly string SomeTaskBasedAction = "SomeTaskBasedAction";
            public readonly string SomeTaskBasedActionWithParams = "SomeTaskBasedActionWithParams";
            public readonly string SomeAbstractResult = "SomeAbstractResult";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string AsyncTask = "AsyncTask";
            public const string Index = "Index";
            public const string About = firstConst + " " + secondConst;
            public const string Blah = "New-Name for Blah";
            public const string SomeViewResultAction = "SomeViewResultAction";
            public const string SomeJsonResultAction = "SomeJsonResultAction";
            public const string SomeFileContentResultAction = "SomeFileContentResultAction";
            public const string SomeFileStreamResultAction = "SomeFileStreamResultAction";
            public const string SomeFileResultAction = "SomeFileResultAction";
            public const string SomeCustomResultAction = "SomeCustomResultAction";
            public const string ActionWithArrayParam = "ActionWithArrayParam";
            public const string ActionWithAllOptionalParams = "ActionWithAllOptionalParams";
            public const string ActionWithSomeOptionalParams = "ActionWithSomeOptionalParams";
            public const string ActionWithOptionalParamDefaultingToNull = "ActionWithOptionalParamDefaultingToNull";
            public const string ActionWithParamUsingAtSyntax = "ActionWithParamUsingAtSyntax";
            public const string ActionThatUsesActionNameConstantInAttribute = "ActionThatUsesActionNameConstantInAttribute";
            public const string ActionThatRequiresHttps = "ActionThatRequiresHttps";
            public const string OverloadedActionWithDifferentParams = "OverloadedActionWithDifferentParams";
            public const string ActionReturningGenericResultString = "ActionReturningGenericResultString";
            public const string ActionReturningGenericResultInt = "ActionReturningGenericResultInt";
            public const string ActionReturningGenericResultNested = "ActionReturningGenericResultNested";
            public const string SomeTaskBasedAction = "SomeTaskBasedAction";
            public const string SomeTaskBasedActionWithParams = "SomeTaskBasedActionWithParams";
            public const string SomeAbstractResult = "SomeAbstractResult";
        }


        static readonly ActionParamsClass_Blah s_params_Blah = new ActionParamsClass_Blah();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Blah BlahParams { get { return s_params_Blah; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Blah
        {
            public readonly string name = "name";
            public readonly string age = "age";
        }
        static readonly ActionParamsClass_ActionWithArrayParam s_params_ActionWithArrayParam = new ActionParamsClass_ActionWithArrayParam();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithArrayParam ActionWithArrayParamParams { get { return s_params_ActionWithArrayParam; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithArrayParam
        {
            public readonly string someStrings = "someStrings";
        }
        static readonly ActionParamsClass_ActionWithAllOptionalParams s_params_ActionWithAllOptionalParams = new ActionParamsClass_ActionWithAllOptionalParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithAllOptionalParams ActionWithAllOptionalParamsParams { get { return s_params_ActionWithAllOptionalParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithAllOptionalParams
        {
            public readonly string someString = "someString";
            public readonly string n = "n";
        }
        static readonly ActionParamsClass_ActionWithSomeOptionalParams s_params_ActionWithSomeOptionalParams = new ActionParamsClass_ActionWithSomeOptionalParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithSomeOptionalParams ActionWithSomeOptionalParamsParams { get { return s_params_ActionWithSomeOptionalParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithSomeOptionalParams
        {
            public readonly string someString = "someString";
            public readonly string n = "n";
        }
        static readonly ActionParamsClass_ActionWithOptionalParamDefaultingToNull s_params_ActionWithOptionalParamDefaultingToNull = new ActionParamsClass_ActionWithOptionalParamDefaultingToNull();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithOptionalParamDefaultingToNull ActionWithOptionalParamDefaultingToNullParams { get { return s_params_ActionWithOptionalParamDefaultingToNull; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithOptionalParamDefaultingToNull
        {
            public readonly string n = "n";
        }
        static readonly ActionParamsClass_ActionWithParamUsingAtSyntax s_params_ActionWithParamUsingAtSyntax = new ActionParamsClass_ActionWithParamUsingAtSyntax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionWithParamUsingAtSyntax ActionWithParamUsingAtSyntaxParams { get { return s_params_ActionWithParamUsingAtSyntax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionWithParamUsingAtSyntax
        {
            public readonly string @event = "event";
        }
        static readonly ActionParamsClass_ActionThatRequiresHttps s_params_ActionThatRequiresHttps = new ActionParamsClass_ActionThatRequiresHttps();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionThatRequiresHttps ActionThatRequiresHttpsParams { get { return s_params_ActionThatRequiresHttps; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionThatRequiresHttps
        {
            public readonly string someString = "someString";
        }
        static readonly ActionParamsClass_OverloadedActionWithDifferentParams s_params_OverloadedActionWithDifferentParams = new ActionParamsClass_OverloadedActionWithDifferentParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_OverloadedActionWithDifferentParams OverloadedActionWithDifferentParamsParams { get { return s_params_OverloadedActionWithDifferentParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_OverloadedActionWithDifferentParams
        {
            public readonly string someString = "someString";
            public readonly string someNumber = "someNumber";
        }
        static readonly ActionParamsClass_SomeTaskBasedActionWithParams s_params_SomeTaskBasedActionWithParams = new ActionParamsClass_SomeTaskBasedActionWithParams();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SomeTaskBasedActionWithParams SomeTaskBasedActionWithParamsParams { get { return s_params_SomeTaskBasedActionWithParams; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SomeTaskBasedActionWithParams
        {
            public readonly string id = "id";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _7_Some_Home_View_Hello = "7 Some Home.View-Hello";
                public readonly string About = "About";
                public readonly string DuplicateControl = "DuplicateControl";
                public readonly string Index = "Index";
                public readonly string Qqq = "Qqq";
                public readonly string QqQ = "QqQ";
                public readonly string Qqq_txt3 = "Qqq_txt3";
                public readonly string SomeLinkedFile = "SomeLinkedFile";
            }
            public readonly string _7_Some_Home_View_Hello = "~/Views/Home/7 Some Home.View-Hello.txt";
            public readonly string About = "~/Views/Home/About.aspx";
            public readonly string DuplicateControl = "~/Views/Home/DuplicateControl.ascx";
            public readonly string Index = "~/Views/Home/Index.aspx";
            public readonly string Qqq = "~/Views/Home/Qqq.txt";
            public readonly string QqQ = "~/Views/Home/QqQ.txt2";
            public readonly string Qqq_txt3 = "~/Views/Home/Qqq.txt3";
            public readonly string SomeLinkedFile = "~/Views/Home/SomeLinkedFile.txt";
            static readonly _defaultClass s_default = new _defaultClass();
            public _defaultClass @default { get { return s_default; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _defaultClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                }
            }
            static readonly _DisplayTemplatesClass s_DisplayTemplates = new _DisplayTemplatesClass();
            public _DisplayTemplatesClass DisplayTemplates { get { return s_DisplayTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _DisplayTemplatesClass
            {
                public readonly string SomeDisplayTemplate = "SomeDisplayTemplate";
            }
            static readonly _EditorTemplatesClass s_EditorTemplates = new _EditorTemplatesClass();
            public _EditorTemplatesClass EditorTemplates { get { return s_EditorTemplates; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _EditorTemplatesClass
            {
                public readonly string SomeEditorTemplate = "SomeEditorTemplate";
            }
            static readonly _SomeNameClass s_SomeName = new _SomeNameClass();
            public _SomeNameClass SomeName { get { return s_SomeName; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _SomeNameClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                }
                static readonly _SomeName_Class s_SomeName = new _SomeName_Class();
                public _SomeName_Class SomeName { get { return s_SomeName; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _SomeName_Class
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string SomeName = "SomeName";
                    }
                    public readonly string SomeName = "~/Views/Home/SomeName/SomeName/SomeName.txt";
                }
            }
            static readonly _Sub_HomeClass s_Sub_Home = new _Sub_HomeClass();
            public _Sub_HomeClass Sub_Home { get { return s_Sub_Home; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _Sub_HomeClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string Qqq = "Qqq";
                    public readonly string @string = "string";
                    public readonly string T4View = "T4View";
                }
                public readonly string Qqq = "~/Views/Home/Sub Home/Qqq.txt";
                public readonly string @string = "~/Views/Home/Sub Home/string.txt";
                public readonly string T4View = "~/Views/Home/Sub Home/T4View.tt";
                static readonly _Nested_SubClass s_Nested_Sub = new _Nested_SubClass();
                public _Nested_SubClass Nested_Sub { get { return s_Nested_Sub; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _Nested_SubClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string _99_Super_Nested_View = "99 Super~Nested-View";
                    }
                    public readonly string _99_Super_Nested_View = "~/Views/Home/Sub Home/Nested-Sub/99 Super~Nested-View.txt";
                }
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : T4MVCHostMvcApp.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void AsyncTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> AsyncTask()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AsyncTask);
            AsyncTaskOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AboutOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult About()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.About);
            AboutOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void BlahOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string name, int age);

        [NonAction]
        public override System.Web.Mvc.ActionResult Blah(string name, int age)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Blah);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "age", age);
            BlahOverride(callInfo, name, age);
            return callInfo;
        }

        [NonAction]
        partial void SomeViewResultActionOverride(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult SomeViewResultAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.SomeViewResultAction);
            SomeViewResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeJsonResultActionOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Web.Mvc.JsonResult SomeJsonResultAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SomeJsonResultAction);
            SomeJsonResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeFileContentResultActionOverride(T4MVC_System_Web_Mvc_FileContentResult callInfo);

        [NonAction]
        public override System.Web.Mvc.FileContentResult SomeFileContentResultAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileContentResult(Area, Name, ActionNames.SomeFileContentResultAction);
            SomeFileContentResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeFileStreamResultActionOverride(T4MVC_System_Web_Mvc_FileStreamResult callInfo);

        [NonAction]
        public override System.Web.Mvc.FileStreamResult SomeFileStreamResultAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileStreamResult(Area, Name, ActionNames.SomeFileStreamResultAction);
            SomeFileStreamResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeFileResultActionOverride(T4MVC_System_Web_Mvc_FileResult callInfo);

        [NonAction]
        public override System.Web.Mvc.FileResult SomeFileResultAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.SomeFileResultAction);
            SomeFileResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeCustomResultActionOverride(T4MVC_T4MVCHostMvcApp_Misc_MyCustomResult callInfo);

        [NonAction]
        public override T4MVCHostMvcApp.Misc.MyCustomResult SomeCustomResultAction()
        {
            var callInfo = new T4MVC_T4MVCHostMvcApp_Misc_MyCustomResult(Area, Name, ActionNames.SomeCustomResultAction);
            SomeCustomResultActionOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionWithArrayParamOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string[] someStrings);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionWithArrayParam(string[] someStrings)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithArrayParam);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someStrings", someStrings);
            ActionWithArrayParamOverride(callInfo, someStrings);
            return callInfo;
        }

        [NonAction]
        partial void ActionWithAllOptionalParamsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string someString, int n);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionWithAllOptionalParams(string someString, int n)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithAllOptionalParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "n", n);
            ActionWithAllOptionalParamsOverride(callInfo, someString, n);
            return callInfo;
        }

        [NonAction]
        partial void ActionWithSomeOptionalParamsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string someString, int n);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionWithSomeOptionalParams(string someString, int n)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithSomeOptionalParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "n", n);
            ActionWithSomeOptionalParamsOverride(callInfo, someString, n);
            return callInfo;
        }

        [NonAction]
        partial void ActionWithOptionalParamDefaultingToNullOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? n);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionWithOptionalParamDefaultingToNull(int? n)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithOptionalParamDefaultingToNull);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "n", n);
            ActionWithOptionalParamDefaultingToNullOverride(callInfo, n);
            return callInfo;
        }

        [NonAction]
        partial void ActionWithParamUsingAtSyntaxOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int @event);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionWithParamUsingAtSyntax(int @event)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionWithParamUsingAtSyntax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "event", @event);
            ActionWithParamUsingAtSyntaxOverride(callInfo, @event);
            return callInfo;
        }

        [NonAction]
        partial void ActionThatUsesActionNameConstantInAttributeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionThatUsesActionNameConstantInAttribute()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionThatUsesActionNameConstantInAttribute);
            ActionThatUsesActionNameConstantInAttributeOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionThatRequiresHttpsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string someString);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionThatRequiresHttps(string someString)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionThatRequiresHttps, "https");
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            ActionThatRequiresHttpsOverride(callInfo, someString);
            return callInfo;
        }

        [NonAction]
        partial void OverloadedActionWithDifferentParamsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string someString);

        [NonAction]
        public override System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams(string someString)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someString", someString);
            OverloadedActionWithDifferentParamsOverride(callInfo, someString);
            return callInfo;
        }

        [NonAction]
        partial void OverloadedActionWithDifferentParamsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int someNumber);

        [NonAction]
        public override System.Web.Mvc.ActionResult OverloadedActionWithDifferentParams(int someNumber)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.OverloadedActionWithDifferentParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "someNumber", someNumber);
            OverloadedActionWithDifferentParamsOverride(callInfo, someNumber);
            return callInfo;
        }

        [NonAction]
        partial void ActionReturningGenericResultStringOverride(T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_String callInfo);

        [NonAction]
        public override T4MVCHostMvcApp.Controllers.SomeGenericResult<System.String> ActionReturningGenericResultString()
        {
            var callInfo = new T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_String(Area, Name, ActionNames.ActionReturningGenericResultString);
            ActionReturningGenericResultStringOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionReturningGenericResultIntOverride(T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Int32 callInfo);

        [NonAction]
        public override T4MVCHostMvcApp.Controllers.SomeGenericResult<System.Int32> ActionReturningGenericResultInt()
        {
            var callInfo = new T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Int32(Area, Name, ActionNames.ActionReturningGenericResultInt);
            ActionReturningGenericResultIntOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionReturningGenericResultNestedOverride(T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Collections_Generic_List_System_Tuple_System_String_System_String_System_Int32 callInfo);

        [NonAction]
        public override T4MVCHostMvcApp.Controllers.SomeGenericResult<System.Collections.Generic.List<System.Tuple<System.String,System.String,System.Int32>>> ActionReturningGenericResultNested()
        {
            var callInfo = new T4MVC_T4MVCHostMvcApp_Controllers_SomeGenericResult_System_Collections_Generic_List_System_Tuple_System_String_System_String_System_Int32(Area, Name, ActionNames.ActionReturningGenericResultNested);
            ActionReturningGenericResultNestedOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SomeTaskBasedActionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SomeTaskBasedAction()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SomeTaskBasedAction);
            SomeTaskBasedActionOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void SomeTaskBasedActionWithParamsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SomeTaskBasedActionWithParams(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SomeTaskBasedActionWithParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SomeTaskBasedActionWithParamsOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void SomeAbstractResultOverride(T4MVC_System_Web_Mvc_ViewResultBase callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResultBase SomeAbstractResult()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResultBase(Area, Name, ActionNames.SomeAbstractResult);
            SomeAbstractResultOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
