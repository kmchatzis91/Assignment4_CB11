using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4CB11.Enums;
using Assignment4CB11.SortingAlgorithms;

namespace Assignment4CB11
{
	class Program
	{
		static void Main(string[] args)
		{
			SyntheticData db = new SyntheticData();
			var shirtList = new List<Shirt>(db.Shirts);

			Console.WriteLine("Not Sorted! \n");
			Printer(shirtList);
			Seperator();

			// Quick Sort //
			AllQuickSorts(shirtList);

			// Bubble Sort //
			AllBubbleSorts(shirtList);

			// Bucket Sort //
			AllBucketSorts(shirtList);

		} // static void Main(string[] args) END //

		public static void Printer(List<Shirt> shirtList)
		{
			foreach (var shirt in shirtList)
			{
				shirt.Output();
			}

			Console.WriteLine();

		} //  public static void Printer(List<Shirt> shirtList) END //

		public static void Seperator()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n");
			Console.ForegroundColor = ConsoleColor.White;

		} //  public static void Seperator() END //

		public static void AllBucketSorts(List<Shirt> shirtList)
		{
			var sortedListBucketSize = BucketSort.SortShirtsBySize(shirtList);
			Console.WriteLine("List ascending sorted(by size) with Bucket sort! \n");
			Printer(sortedListBucketSize);
			Seperator();

			sortedListBucketSize.Reverse();
			Console.WriteLine("List descending sorted(by size) with Bucket sort! \n");
			Printer(sortedListBucketSize);
			Seperator();

			var sortedListBucketColor = BucketSort.SortShirtsByColor(shirtList);
			Console.WriteLine("List ascending sorted(by color) with Bucket sort! \n");
			Printer(sortedListBucketColor);
			Seperator();

			sortedListBucketColor.Reverse();
			Console.WriteLine("List descending sorted(by color) with Bucket sort! \n");
			Printer(sortedListBucketColor);
			Seperator();

			var sortedListBucketFabric = BucketSort.SortShirtsByFabric(shirtList);
			Console.WriteLine("List ascending sorted(by fabric) with Bucket sort! \n");
			Printer(sortedListBucketFabric);
			Seperator();

			sortedListBucketFabric.Reverse();
			Console.WriteLine("List descending sorted(by fabric) with Bucket sort! \n");
			Printer(sortedListBucketFabric);
			Seperator();

			var orderedBucket = shirtList.OrderBy(x => x.Size).ThenBy(x => x.Color).ThenBy(x => x.Fabric);
			Console.WriteLine("List ascending sorted(by size and color and fabric) with Bucket sort! \n");
			foreach (var shirt in orderedBucket)
			{
				shirt.Output();
			}
			Seperator();

			IEnumerable<Shirt> ReversedDataBucket = orderedBucket.Reverse();
			Console.WriteLine("List descending sorted(by size and color and fabric) with Bucket sort! \n");
			foreach (var shirt in ReversedDataBucket)
			{
				shirt.Output();
			}
			Seperator();

		} // public static void AllBucketSorts(List<Shirt> shirtList) END //

		public static void AllBubbleSorts(List<Shirt> shirtList)
		{
			BubbleSort.SortShirtsBySize(shirtList);
			Console.WriteLine("List ascending sorted(by size) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by size) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			BubbleSort.SortShirtsByColor(shirtList);
			Console.WriteLine("List ascending sorted(by color) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by color) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			BubbleSort.SortShirtsByFabric(shirtList);
			Console.WriteLine("List ascending sorted(by fabric) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by fabric) with Bubble sort! \n");
			Printer(shirtList);
			Seperator();

			var orderedSize = shirtList.OrderBy(x => x.Size).ThenBy(x => x.Color).ThenBy(x => x.Fabric);
			Console.WriteLine("List ascending sorted(by size and color and fabric) with Bubble sort! \n");
			foreach (var shirt in orderedSize)
			{
				shirt.Output();
			}
			Console.WriteLine();
			Seperator();

			IEnumerable<Shirt> ReversedDataBubble = orderedSize.Reverse();
			Console.WriteLine("List descending sorted(by size and color and fabric) with Bubble sort! \n");
			foreach (var shirt in ReversedDataBubble)
			{
				shirt.Output();
			}
			Console.WriteLine();
			Seperator();

		} //  public static void AllBubbleSorts(List<Shirt> shirtList) END //

		public static void AllQuickSorts(List<Shirt> shirtList)
		{
			QuickSort.SortShirtsBySize(shirtList);
			Console.WriteLine("List ascending sorted(by size) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by size) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			QuickSort.SortShirtsByColor(shirtList);
			Console.WriteLine("List ascending sorted(by color) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by color) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			QuickSort.SortShirtsByFabric(shirtList);
			Console.WriteLine("List ascending sorted(by fabric) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			shirtList.Reverse();
			Console.WriteLine("List descending sorted(by fabric) with Quick sort! \n");
			Printer(shirtList);
			Seperator();

			var orderedQuick = shirtList.OrderBy(x => x.Size).ThenBy(x => x.Color).ThenBy(x => x.Fabric);
			Console.WriteLine("List ascending sorted(by size and color and fabric) with Quick sort! \n");
			foreach (var shirt in orderedQuick)
			{
				shirt.Output();
			}
			Console.WriteLine();
			Seperator();

			IEnumerable<Shirt> ReversedDataQuick = orderedQuick.Reverse();
			Console.WriteLine("List descending sorted(by size and color and fabric) with Quick sort! \n");
			foreach (var shirt in ReversedDataQuick)
			{
				shirt.Output();
			}
			Console.WriteLine();
			Seperator();

		} //  public static void AllQuickSorts(List<Shirt> shirtList) END //

	} // class Program END //

} // namespace Assignment4CB11 END //
