using Tesla_showroom.Car;

namespace Tesla_showroom.CarDecorator
{
	abstract class ModelSDecorator : ModelS
	{
		protected ModelS modelS;
		public ModelSDecorator(string name, ModelS modelS) : base(name)
		{
			this.modelS = modelS;
		}
	}
}