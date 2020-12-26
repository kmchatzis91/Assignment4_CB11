using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4CB11.Enums;

namespace Assignment4CB11
{
	class Shirt
	{
		public Color Color { get; set; }
		public Size Size { get; set; }
		public Fabric Fabric { get; set; }

		public Shirt(Color color, Size size, Fabric fabric)
		{
			Color = color;
			Size = size;
			Fabric = fabric;
		}

		public void Output()
		{
			Console.WriteLine("{0,10} | {1,10} | {2,10}", Color, Size, Fabric);
		}
	}
}
