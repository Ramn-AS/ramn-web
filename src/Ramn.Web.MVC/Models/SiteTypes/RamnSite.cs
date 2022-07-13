namespace Ramn.Web.MVC.Models.SiteTypes
{
    using Piranha.AttributeBuilder;
    using Piranha.Extend;
    using Piranha.Models;
    using Piranha.Extend.Fields;

    [SiteType(Title = "Ramn Site")]
    public class RamnSite : SiteContent<RamnSite>
    {
        [Region(Title = "Footer Left", Display = RegionDisplayMode.Setting)]
        public HtmlField FooterLeft { get; set; }

        [Region(Title = "Footer Middle", Display = RegionDisplayMode.Setting)]
        public HtmlField FooterMiddle { get; set; }

        [Region(Title = "Footer Right", Display = RegionDisplayMode.Setting)]
        public HtmlField FooterRight { get; set; }
    }
}
