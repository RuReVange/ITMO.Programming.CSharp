using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public abstract class AbstractEngine
{
    // protected IReadOnlyCollection<int> fuelConsamptionList = new List<int>() { 20, 50 };
    protected int Speed { get; init; } = 1;
    protected int FuelConsumption { get; init; }
    protected int FuelTank { get; set; }

    public virtual IResult Movement(int distance)
    {
        int possibleTime = FuelTank / FuelConsumption; // максимальное время, которое теоретически корабль может провести в космосе
        int possibleRelocation = Speed * possibleTime; // максималльное расстояние, которое может покрыть корабль при полном использовании топлива под 0

        if (possibleRelocation > distance)
        {
            int spentTime = distance / Speed; // время которое корабль провел в пути до конечной точки
            int spentFuel = spentTime * FuelConsumption; // сколько всего топлива потрачено на нужный маршрут
            int remainingFuel = FuelTank - spentFuel; // остаток топлива
            FuelTank = remainingFuel < 0 ? 0 : remainingFuel;

            return new RouteSuccess(spentTime, spentFuel);
        }
        else
        {
            return new ShipLoss();
        }
    }
}