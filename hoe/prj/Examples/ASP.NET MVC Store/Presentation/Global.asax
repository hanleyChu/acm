<%@ Application Language="C#" %>
<%@ Import Namespace="MVCSharp.Core.Tasks" %>
<%@ Import Namespace="MVCSharp.Webforms" %>
<%@ Import Namespace="MVCSharp.Webforms.Configuration" %>
<%@ Import Namespace="ASPNET_MVC_Store.ApplicationLogic" %>
<%@ Import Namespace="ASPNET_MVC_Store.Model" %>

<script runat="server">

    [WebformsView(typeof(MainTask), MainTask.Welcome, "Default.aspx")]
    [WebformsView(typeof(MainTask), MainTask.ProductCategories,
                                            "ProductCategories.aspx")]
    [WebformsView(typeof(MainTask), MainTask.Products, "Products.aspx")]
    [WebformsView(typeof(MainTask), MainTask.EditProduct, "EditProduct.aspx")]
    class ViewDescriptions { }

    public void Session_Start(object sender, EventArgs e)
    {
        TasksManager tm = new TasksManager(WebformsViewsManager.
                                           GetDefaultConfig());
        tm.StartTask(typeof(MainTask));
    }

</script>
