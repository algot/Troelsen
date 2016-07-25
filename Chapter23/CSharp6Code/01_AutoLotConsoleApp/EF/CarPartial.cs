namespace _01_AutoLotConsoleApp.EF
{
  public partial class Car
  {
    public override string ToString()
    {
      // Поскольку столбец PetName может быть пустым, 
      // указать в качестве стандартного имени **No Name**.
      return string.Format("{0} is a {1} {2} with Id {3}.",
        this.CarNickName ?? "**No Name**",
        this.Color, this.Make, this.CarId);
    }
  }
}