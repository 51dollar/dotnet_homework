namespace Tesla_showroom.Car
{
	abstract class ModelS
	{
		public ModelS(string name)
		{
			this.Name = name;
		}
		public string Name { get; protected set; }
		public abstract int GetCost();
	}
}
