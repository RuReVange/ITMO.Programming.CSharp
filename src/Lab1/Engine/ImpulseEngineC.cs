using Itmo.ObjectOrientedProgramming.Lab1.Result;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class ImpulseEngineC : AbstractImpulseEngine
{
    public ImpulseEngineC()
    {
        Speed = 50;
        FuelConsumption = 20;
        FuelTank = 510;
    }

    public override IResult Movement(int distance)
    {
        int possibleTime = (FuelTank - StartConsumption) / FuelConsumption; // время, которое теоретически корабль может провести в космосе
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