namespace Tesla_showroom.Car
{
	class ModelSBasic : ModelS
	{
		public ModelSBasic() : base("Tesla Model S")
		{ }
		public override int GetCost()
		{
			return 78490;
		}
	}
}