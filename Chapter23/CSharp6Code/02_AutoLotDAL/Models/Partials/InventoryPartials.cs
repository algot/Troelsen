using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AutoLotDAL.Models
{
  public partial class Inventory
  {
    public override string ToString()
    {
      return string.Format("{0} is a {1} {2} with Id {3}.", PetName ?? "**No Name**", Color, Make, CarId);
    }
  }
  
}
