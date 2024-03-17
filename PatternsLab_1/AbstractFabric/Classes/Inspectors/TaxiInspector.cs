using PatternsLab_1.AbstractFabric.BaseClasses;
using PatternsLab_1.AbstractFabric.Classes.Fabrics;
using PatternsLab_1.AbstractFabric.Classes.Models;

namespace PatternsLab_1.AbstractFabric.Classes.Inspectors;

public class TaxiInspector: BaseTransportInspector<TaxiDriver, Passanger>
{
    #region Overrides

    protected override int PassangersMaxCount { get; set; } = 4;
    
    #endregion
    
    public TaxiInspector(
        TaxiDriverFabric driverFabric,
        IFabric<Passanger> passangerFabric)
        : base(driverFabric, passangerFabric) { }
}