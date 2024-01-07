namespace Tesla_showroom.Car
{
	class ModelSPlaid : ModelS
	{
		public ModelSPlaid()
			: base("Tesla Model S Plaid")
		{ }
		public override int GetCost() => 89990;

		public void UseThirdEngine() =>
            Console.WriteLine("Используем 3-й двигатель");
	}
}
