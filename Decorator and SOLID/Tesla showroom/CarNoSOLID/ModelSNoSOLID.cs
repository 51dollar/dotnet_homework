using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_showroom.CarNoSOLID
{
	abstract class ModelSNoSOLID
	{
		public ModelSNoSOLID(string name)
		{
			this.Name = name;
		}
		public string Name { get; protected set; }
		public abstract int GetCost();
		public abstract void UseThirdEngine();
	}
}
