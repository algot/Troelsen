using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
	public class MiniVan : Car
	{
		public MiniVan() { }
		public MiniVan(string name, int maxSpd, int currSpd) : base(name, maxSpd, currSpd) { }

		public override void TurboBoost()
		{
			EngState = EngineState.engineDead;
			MessageBox.Show("Eek!", "Your engine block exploded!");
		}
	}
}
