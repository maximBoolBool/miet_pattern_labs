using PatternsLab_3.Impl;
using PatternsLab_3.Impl.Enums;

const int firstClassMaxSize = 10;
const int buisnessClassMaxSize = 20;
const int economyClassMaxSize = 150;
const int pilotsMaxSize = 2;
const int stewardessMaxSize = 6;

var pilots = new Group(new(), PlaceLandType.Pilots, pilotsMaxSize);
var stewardess = new Group(new(), PlaceLandType.Steardes, stewardessMaxSize);
var first = new Group(new(), PlaceLandType.First, firstClassMaxSize);
var buisnes = new Group(new(), PlaceLandType.Buisnes, buisnessClassMaxSize);
var economy = new Group(new(), PlaceLandType.Economy, economyClassMaxSize);

pilots.AddElement(new Pilot(){Name = "1", Female = "1", Age = 1});
pilots.AddElement(new Pilot(){Name = "2", Female = "2", Age = 2});

stewardess.AddElement(new Stewardess(){Name = "1", Female = "1", Age = 1});
stewardess.AddElement(new Stewardess(){Name = "2", Female = "2", Age = 2});
stewardess.AddElement(new Stewardess(){Name = "3", Female = "3", Age = 3});
stewardess.AddElement(new Stewardess(){Name = "4", Female = "4", Age = 4});
stewardess.AddElement(new Stewardess(){Name = "5", Female = "5", Age = 5});
stewardess.AddElement(new Stewardess(){Name = "6", Female = "6", Age = 6});

first.AddElement(new PlaceLand(){CargoWeight = 1});
first.AddElement(new PlaceLand(){CargoWeight = 2});
first.AddElement(new PlaceLand(){CargoWeight = 3});
first.AddElement(new PlaceLand(){CargoWeight = 4});
first.AddElement(new PlaceLand(){CargoWeight = 5});

buisnes.AddElement(new PlaceLand(){CargoWeight = 1});
buisnes.AddElement(new PlaceLand(){CargoWeight = 2});
buisnes.AddElement(new PlaceLand(){CargoWeight = 3});
buisnes.AddElement(new PlaceLand(){CargoWeight = 4});
buisnes.AddElement(new PlaceLand(){CargoWeight = 5});

economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand(){CargoWeight = 1});
economy.AddElement(new PlaceLand{CargoWeight = 1});
economy.AddElement(new PlaceLand{CargoWeight = 1});

var airPlane = new Airplane();
airPlane.AddElement(pilots);
airPlane.AddElement(stewardess);
airPlane.AddElement(first);
airPlane.AddElement(buisnes);
airPlane.AddElement(economy);

airPlane.Display();