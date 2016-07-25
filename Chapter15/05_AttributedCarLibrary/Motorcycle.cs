using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributedCarLibrary
{
	[Serializable]
	[VehicleDescription(Description = "My rocking Harley")]
	public class Motorcycle
	{
	}

	[Serializable]
	[Obsolete("Use another vehicle!")]
	[VehicleDescription("The old grey")]
	public class HorseAndBuggy
	{
	}

	[VehicleDescription("A very long auto")]
	public class Winnebago
	{
	}
}
