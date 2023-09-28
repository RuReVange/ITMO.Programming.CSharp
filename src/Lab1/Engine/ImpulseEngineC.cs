using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engine;

public class ImpulseEngineC : AbstractImpulseEngine
{
    public ImpulseEngineC()
    {
        Speed = 50;
        FuelConsumption = 20;
        FuelTank = 510;
    }

    public override int Movement(int distance)
    {
        int possibleTime = (FuelTank - StartConsumption) / FuelConsumption; // время, которое теоретически корабль может провести в космосе
        int possibleRelocation = Speed * possibleTime; // максималльное расстояние, которое может покрыть корабль при полном использовании топлива под 0

        if (possibleRelocation > distance)
        {
            int difference = possibleRelocation - distance; // разница между потенциальным перемещением, и дистанцией маршрута, который нужно пройти
            int tmpTime = difference / Speed; // время которое корабль провел в пути, после того как прошел нужный маршрут
            int remainingFuel = FuelConsumption * tmpTime; // остаток топлива
            int spentFuel = FuelTank - remainingFuel; // сколько всего топливо потрачено на нужный маршрут
            FuelTank = remainingFuel;

            return spentFuel;
        }
        else
        {
            throw new FuelShortageException("Fuel shortage. The spaceship is lost.");
        }
    }
}