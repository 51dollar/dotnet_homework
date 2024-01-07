using Tesla_showroom.CarNoSOLID;

namespace Tesla_showroom.Car
{
	class ModelSPLongRangeNoSOLID : ModelSNoSOLID
	{
		public ModelSPLongRangeNoSOLID()
			: base("Tesla Model S Long Range")
		{ }
		public override int GetCost()
		{
			return 89990;
		}

		public override void UseThirdEngine()
		{
			throw new NotImplementedException();
		}
	}
}
