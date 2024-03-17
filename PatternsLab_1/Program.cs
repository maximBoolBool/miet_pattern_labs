using PatternsLab_1.AbstractFabric.Classes.Fabrics;
using PatternsLab_1.AbstractFabric.Classes.Inspectors;
using PatternsLab_1.SInglton;

#region First Task

var god = God.Create();
Console.WriteLine("");

#endregion


#region Second Task

var busInspector = new BusTransportInspector(new BusDriverFabric(), new PassangerFabric());
var taxiInspector = new TaxiInspector(new TaxiDriverFabric(), new PassangerFabric());


taxiInspector.AddDriver();
taxiInspector.AddDriver();
taxiInspector.AddPassanger();
taxiInspector.AddPassanger();
taxiInspector.AddPassanger();
taxiInspector.AddPassanger();
taxiInspector.AddPassanger();

Console.WriteLine(taxiInspector.IsReady());

#endregion