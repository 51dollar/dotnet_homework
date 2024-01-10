using Tesla_showroom.Car;

namespace Tesla_showroom.CarDecorator
{
	class Autopilot : ModelSDecorator
	{
		public Autopilot(ModelS modelS)
			: base(modelS.Name + ", Автопилот", modelS)
		{ }

		public override int GetCost()
		{
			return modelS.GetCost() + 6000;
		}
	}
}