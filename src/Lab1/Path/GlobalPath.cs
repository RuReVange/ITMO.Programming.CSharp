using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Outcomes;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Path;

public class GlobalPath
{
    public GlobalPath(IList<(IEnvironment Environment, int Distance)> pathList, IList<AbstractSpaceship> spaceshipList)
    {
        PathList = pathList;
        SpaceshipList = spaceshipList;
    }

    public IList<AbstractSpaceship> SpaceshipList { get; init; } // список кораблей
    public IList<(IEnvironment Environment, int Distance)> PathList { get; init; } // маршрут
    public IList<GlobalPathResult> GlobalMovement()
    {
        IList<GlobalPathResult> results = new List<GlobalPathResult>();

        for (int i = 0; i < PathList.Count; ++i)
        {
            // Создание буфера для обстаклов, ниже описана причина такого решения
            IList<int> tmpObstacleQtyList = new List<int>();
            foreach (AbstractObstacle tmpObstacle in PathList[i].Environment.ObstacleList)
            {
                tmpObstacleQtyList.Add(tmpObstacle.Quantity);
            }

            for (int j = 0; j < SpaceshipList.Count; ++j)
            {
                int k = 0;
                foreach (AbstractObstacle tmpObstacle in PathList[i].Environment.ObstacleList)
                {
                    tmpObstacle.Quantity = tmpObstacleQtyList[k];
                    ++k;
                }

                // моя логика была заточена под идею, что при столкновении препятствия с кораблем, в случае выживания корабля, препятствие уничтожается
                // но судя по тесткейсам корабли не существуют в одной и той же среде, а перемещаются в неких "параллельных однотипных средах"
                //  а значит каждый корабль должен встретить одинаковое исходное кол-во препятствий
                // именно по этой причине, у меня создается буферный список препятствий tmpObstacleQtyList, который хранит исходное кол-во препятствий для каждого нового корабля
                results.Add(new GlobalPathResult(SpaceshipList[j], PathList[i].Environment.EnvironmentMovement(PathList[i].Distance, SpaceshipList[j])));
            }
        }

        return results;
    }
}