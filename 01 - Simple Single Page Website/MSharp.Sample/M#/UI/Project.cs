// ********************************************************************
// WARNING: This file is auto-generated from Model\\Project.cs
// and may be overwritten at any time. Do not change it manually.
// ********************************************************************

namespace MSharp
{
    partial class AppRole
    {
        internal static ProjectRole Local_Request => ProjectRole.Of("Local.Request");
        internal static ProjectRole Anonymous => ProjectRole.Of("Anonymous");
        internal static ProjectRole Admin => ProjectRole.Of("Admin");
    }
    
    partial class Layouts
    {
        internal static MasterPage AdminDefault => MasterPage.Of("Admin default");
        internal static MasterPage AdminDefaultModal => MasterPage.Of("Admin default Modal");
        internal static MasterPage Default => MasterPage.Of("Default");
        internal static MasterPage Login => MasterPage.Of("Login");
    }
    
    partial class PageSettings
    {
        internal static PageSettingKey AdminLeftMenu => PageSettingKey.Of("AdminLeftMenu");
        internal static PageSettingKey AdminSubMenu => PageSettingKey.Of("AdminSubMenu");
        internal static PageSettingKey MainFooter => PageSettingKey.Of("MainFooter");
        internal static PageSettingKey MainNav => PageSettingKey.Of("MainNav");
    }
}