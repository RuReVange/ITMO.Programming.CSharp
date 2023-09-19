namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonicDeflector
{
    public PhotonicDeflector()
    {
        HealthPoint = 3;
    }

    protected int HealthPoint { get; set; }

    public void Destruction(int quantityAntimatter) // Attackuation // В параметрах поставить класс Obstacle
    {
        for (int i = 0; i < quantityAntimatter; ++i)
        {
            if (HealthPoint > 0)--HealthPoint;
            else return; // return exeption "людишки погибли"
        }
    }
}