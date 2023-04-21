using Mapsui.Providers;
using Microsoft.Maui.Controls;
using SharpMap;
using System.Xml;


namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;
	Task<string> GPS;

    public MainPage()
    {
        InitializeComponent();

        var mapControl = new Mapsui.UI.Maui.MapControl();
        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        Content=mapControl;
        mapControl.Map.CRS = "EPSG:4326";
        var gemoetric = SharpMap.Data.Providers.GeometryFeatureProvider.ReferenceEquals(mapControl.Map, null);

        nawigacja nawigacja = new nawigacja();
      
       
        Mapsui.MPoint mPoint = new Mapsui.MPoint(18.60213880000, 53.01664210000);

        mapControl.Navigator.FlyTo(mPoint, 1000);


        GPS = nawigacja.getlocation();
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{

		count++;

        CounterBtn.Text=count.ToString();

        SemanticScreenReader.Default.Announce("działa");
	}
}

