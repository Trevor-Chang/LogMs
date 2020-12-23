using Microsoft.Extensions.Configuration;

public static class ConfigHelper
{
    public static IConfiguration Current { get; set; }

    private static IConfiguration smtp;

    public static IConfiguration Smtp
    {
        get
        {
            if (smtp == null)
            {
                smtp = Current.GetSection("Smtp");
            }

            return smtp;
        }
        set
        {
            smtp = value;
        }
    }

    private static IConfiguration login;

    public static IConfiguration Login
    {
        get
        {
            if (login == null)
            {
                login = Current.GetSection("Login");
            }

            return login;
        }
        set
        {
            login = value;
        }
    }

    private static IConfiguration appsettings;

    public static IConfiguration AppSettings
    {
        get
        {
            if (appsettings == null)
            {
                appsettings = Current.GetSection("AppSettings");
            }

            return appsettings;
        }
        set
        {
            appsettings = value;
        }
    }

    private static IConfiguration staticfiles;

    public static IConfiguration StaticFiles
    {
        get
        {
            if (staticfiles == null)
            {
                staticfiles = Current.GetSection("StaticFiles");
            }

            return staticfiles;
        }
        set
        {
            staticfiles = value;
        }
    }

    private static IConfiguration sharedviews;

    public static IConfiguration SharedViews
    {
        get
        {
            if (sharedviews == null)
            {
                sharedviews = Current.GetSection("SharedViews");
            }

            return sharedviews;
        }
        set
        {
            sharedviews = value;
        }
    }

    private static IConfiguration pagination;

    public static IConfiguration Pagination
    {
        get
        {
            if (pagination == null)
            {
                pagination = Current.GetSection("Pagination");
            }

            return pagination;
        }
        set
        {
            pagination = value;
        }
    }

    private static IConfiguration connectionstrings;

    public static IConfiguration ConnectionStrings
    {
        get
        {
            if (connectionstrings == null)
            {
                connectionstrings = Current.GetSection("ConnectionStrings");
            }

            return connectionstrings;
        }
        set
        {
            connectionstrings = value;
        }
    }

    public static void Configure(IConfiguration configurations)
    {
        Current = configurations;
    }

}
