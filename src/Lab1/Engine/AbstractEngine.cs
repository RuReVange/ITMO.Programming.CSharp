// using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;
namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public abstract class AbstractEngine
{
    // protected IReadOnlyCollection<int> fuelConsamptionList = new List<int>() { 20, 50 };
    public int Speed { get; init; } = 1;
    public int FuelConsumption { get; init; }
    public int FuelTank { get; set; }

    public virtual int Movement(int distance)
    {
        int possibleTime = FuelTank / FuelConsumption; // время, которое теоретически корабль может провести в космосе
        int possibleRelocation = Speed * possibleTime; // максималльное расстояние, которое может покрыть корабль при полном использовании топлива под 0

        if (possibleRelocation > distance)
        {
            int tmpTime = distance / Speed; // время которое корабль провел в пути до конечной точки
            int spentFuel = tmpTime * FuelConsumption; // сколько всего топлива потрачено на нужный маршрут
            int remainingFuel = FuelTank - spentFuel; // остаток топлива
            FuelTank = remainingFuel;

            return spentFuel;
        }
        else
        {
            throw new FuelShortageException("Fuel shortage. The spaceship is lost.");
        }
    }
}