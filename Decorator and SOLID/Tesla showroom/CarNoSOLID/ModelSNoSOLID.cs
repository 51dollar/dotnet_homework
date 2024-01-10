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