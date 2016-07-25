using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InventoryEDMConsoleApp
{
  public partial class Car
  {
    public override string ToString()
    {
      return string.Format("{0} is a {1} {2} with Id {3}.", this.CarNickName ?? "**No Name**",
        this.Color, this.Make, this.CarId);
    }
  }
}
