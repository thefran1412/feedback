<%@ Application Language="C#" %>

<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);

    }
    // AQUI SE PONEN LAS RUTAS
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.MapPageRoute("", "", "~/index.aspx");
        
        // forgot
        routes.MapPageRoute("", "forgot", "~/forgot.aspx");

        //login
        routes.MapPageRoute("login", "login", "~/auth/login.aspx");

        //register
        routes.MapPageRoute("register", "register", "~/auth/register.aspx");

        // folder
        routes.MapPageRoute("", "folder/index", "~/folders/index.aspx");

        // folder view
        routes.MapPageRoute("", "folder/view", "~/folders/view.aspx");
        routes.MapPageRoute("", "folder/view/{hash}", "~/folders/view.aspx");

        // form
        routes.MapPageRoute("", "form/index", "~/form/index.aspx");
        routes.MapPageRoute("", "form/index/{id}", "~/form/index.aspx");

        // form view
        routes.MapPageRoute("", "form/view", "~/form/view.aspx");
        routes.MapPageRoute("", "form/view/{hash}", "~/form/view.aspx");

        // form add
        routes.MapPageRoute("", "form/add", "~/form/add.aspx");
        routes.MapPageRoute("", "form/add/{id}", "~/form/add.aspx");

        // form edit
        routes.MapPageRoute("", "form/edit", "~/form/edit.aspx");
        routes.MapPageRoute("", "form/edit/{id}", "~/form/edit.aspx");

        // configuration
        routes.MapPageRoute("", "configuration", "~/config.aspx");


        routes.MapPageRoute("", "form", "~/form/index.aspx");
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Código que se ejecuta al cerrarse la aplicación

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Código que se ejecuta cuando se produce un error sin procesar

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Código que se ejecuta al iniciarse una nueva sesión

    }

    void Session_End(object sender, EventArgs e)
    {
        // Código que se ejecuta cuando finaliza una sesión. 
        // Nota: el evento Session_End se produce solamente con el modo sessionstate
        // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer
        // o SQLServer, el evento no se produce.

    }

</script>
