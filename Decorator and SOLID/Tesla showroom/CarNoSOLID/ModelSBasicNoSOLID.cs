using Tesla_showroom.CarNoSOLID;

namespace Tesla_showroom.Car
{
	class ModelSBasicNoSOLID : ModelSNoSOLID
	{
		public ModelSBasicNoSOLID() : base("Tesla Model S")
		{ }
		public override int GetCost()
		{
			return 78490;
		}

		public override void UseThirdEngine()
		{
			throw new NotImplementedException();
		}
	}
}