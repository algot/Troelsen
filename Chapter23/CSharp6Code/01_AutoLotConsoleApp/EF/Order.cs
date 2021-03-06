namespace _01_AutoLotConsoleApp.EF
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  public partial class Order
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int OrderId { get; set; }

    public int CustId { get; set; }

    public int CarId { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual Car Car { get; set; }
  }
}
