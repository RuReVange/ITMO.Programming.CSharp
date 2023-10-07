using System;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class ImpulseEngineE : AbstractImpulseEngine
{
    public ImpulseEngineE()
    {
        FuelConsumption = 50;
        FuelTank = 1010;
    }

    public override IResult Movement(int distance)
    {
        int possibleTime = (FuelTank - StartConsumption) / FuelConsumption; // время, которое теоретически корабль может провести в космосе
        int possibleRelocation = (int)Math.Round(Math.Exp(possibleTime)); // максималльное расстояние, которое может покрыть корабль при полном использовании топлива под 0

        if (possibleRelocation > distance)
        {
            int spentTime = (int)Math.Round(Math.Log(distance)); // время которое корабль провел в пути до конечной точки
            int spentFuel = spentTime * FuelConsumption; // сколько всего топливо потрачено на нужный маршрут
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