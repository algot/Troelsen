using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_CloneablePoint
{
  public class PointDescription
  {
    public string PetName { get; set; }
    public Guid PointId { get; set; }

    public PointDescription()
    {
      PetName = "No-Name";
      PointId = Guid.NewGuid();
    }
  }
}
