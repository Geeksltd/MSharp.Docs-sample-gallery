using MSharp;

namespace App
{
    public class Project : MSharp.Project
    {
        public Project()
        {
            Name("MSharp.Sample").SolutionFile("MSharp.Sample.sln");            

            Role("Local.Request");
            Role("Anonymous");
            Role("Admin").SkipQueryStringSecurity();

            Layout("Admin default").AjaxRedirect().Default().VirtualPath("~/Views/Layouts/AdminDefault.cshtml");
            Layout("Admin default Modal").Modal().VirtualPath("~/Views/Layouts/AdminDefault.Modal.cshtml");
            Layout("Login").AjaxRedirect().VirtualPath("~/Views/Layouts/Login.cshtml");
            Layout("Default").AjaxRedirect().VirtualPath("~/Views/Layouts/Default.cshtml");

            PageSetting("AdminLeftMenu");
            PageSetting("AdminSubMenu");

            PageSetting("MainNav");
            PageSetting("MainFooter");

            AutoTask("Clean old temp uploads").Every(10, TimeUnit.Minute)
                .Run("await Olive.Mvc.FileUploadService.DeleteTempFiles(olderThan: 1.Hours());");
        }
    }
}