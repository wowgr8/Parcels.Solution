using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(int height, int length, int width, int weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public int Volume()
    {
      return Height * Length * Width;
    }

    public int CostToShip()
    {
      return Weight * 2;
    }
  }
}