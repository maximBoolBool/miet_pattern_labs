using PatternsLab_2.Impl.Builders;
using PatternsLab_2.Impl.Director;

var taxiBuilder = new TaxiBuilder();
var busBuilder = new BusBuilder();

var busDirector = new BusDirector(busBuilder);
var taxiDirector = new TaxiDirector(taxiBuilder);

taxiBuilder.Create();
busBuilder.Create();

var taxi = taxiDirector.Build();
var bus = busDirector.Build();