using Tesla_showroom.Car;

namespace Tesla_showroom.CarDecorator
{
	class FullAutopilot : ModelSDecorator
	{
		public FullAutopilot(ModelS modelS)
			: base(modelS.Name + ", Полный автопилот", modelS)
		{ }

		public override int GetCost()
		{
			return modelS.GetCost() + 12000;
		}
	}
}
