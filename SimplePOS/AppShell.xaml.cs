


using SimplePOS.Pages;
using SimplePOS.Views;

namespace SimplePOS;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();


        Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
        Routing.RegisterRoute(nameof(BodyLotion), typeof(BodyLotion));
        Routing.RegisterRoute(nameof(WISBook), typeof(WISBook));
        Routing.RegisterRoute(nameof(ShoePolish), typeof(ShoePolish));
        Routing.RegisterRoute(nameof(SortPopup), typeof(SortPopup));
    }
}
