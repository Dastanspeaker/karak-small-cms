using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.WebPages;

/// <summary>
/// Summary description for cmsExtensions
/// </summary>
public class cmsExtensions:System.Web.WebPages.WebPage
{
    public cmsExtensions()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    protected HelperResult RenderPane(string panename)
    {
        return base.RenderPage("~/_render_pane.cshtml", new { Pane = panename });
    }

    public override void Execute()
    {
        //throw new NotImplementedException();
    }
}