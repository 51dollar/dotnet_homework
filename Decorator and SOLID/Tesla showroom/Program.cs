using Tesla_showroom.Car;
using Tesla_showroom.CarDecorator;
using Tesla_showroom.CarNoSOLID;

namespace Tesla_showroom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ModelS car1 = new ModelSBasic();
			Console.WriteLine("Название: {0}", car1.Name);
			Console.WriteLine("Цена: {0}$", car1.GetCost());

			ModelS car2 = new ModelSBasic();
			car2 = new Autopilot(car2);
			Console.WriteLine("Название: {0}", car2.Name);
			Console.WriteLine("Цена: {0}$", car2.GetCost());

			ModelS car3 = new ModelSPLongRange();
			car3 = new Autopilot(car3);
			Console.WriteLine("Название: {0}", car3.Name);
			Console.WriteLine("Цена: {0}$", car3.GetCost());

			ModelS car4 = new ModelSPlaid();
			car4 = new Autopilot(car4);
			car4 = new FullAutopilot(car4);
			Console.WriteLine("Название: {0}", car4.Name);
			Console.WriteLine("Цена: {0}$", car4.GetCost());

			ModelSPlaid modelSPlaid = new ModelSPlaid();
			modelSPlaid.UseThirdEngine();

			ModelSNoSOLID carNoSOLID1 = new ModelSPlaidNoSOLID();
			carNoSOLID1.UseThirdEngine();

			ModelSNoSOLID carNoSOLID2 = new ModelSBasicNoSOLID();
			carNoSOLID2.UseThirdEngine();
		}
	}
}
