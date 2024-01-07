using Tesla_showroom.CarNoSOLID;

namespace Tesla_showroom.Car
{
	class ModelSPlaidNoSOLID : ModelSNoSOLID
	{
		public ModelSPlaidNoSOLID()
			: base("Tesla Model S Plaid")
		{ }
		public override int GetCost() => 89990;

		public override void UseThirdEngine() =>
            Console.WriteLine("Используем 3-й двигатель");
	}
}
