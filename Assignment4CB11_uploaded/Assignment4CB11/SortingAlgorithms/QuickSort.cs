using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4CB11.SortingAlgorithms
{
    class QuickSort
    {
        public static void SortShirtsBySize(List<Shirt> shirts)
        {
            QuicksortBySize(shirts, 0, shirts.Count - 1);
        }

        public static void SortShirtsByColor(List<Shirt> shirts)
        {
            QuicksortByColor(shirts, 0, shirts.Count - 1);
        }

        public static void SortShirtsByFabric(List<Shirt> shirts)
        {
            QuicksortByFabric(shirts, 0, shirts.Count - 1);
        }

        private static void QuicksortBySize(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (shirts[i].Size < pivot)
                    i++;
                while (shirts[j].Size > pivot)
                    j--;

                if (i <= j)
                {
                    //swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortBySize(shirts, left, j);
            if (i < right)
                QuicksortBySize(shirts, i, right);
        }

        private static void QuicksortByColor(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Color;

            while (i <= j)
            {
                while (shirts[i].Color < pivot)
                    i++;
                while (shirts[j].Color > pivot)
                    j--;

                if (i <= j)
                {
                    //swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortByColor(shirts, left, j);
            if (i < right)
                QuicksortByColor(shirts, i, right);
        }

        private static void QuicksortByFabric(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Fabric;

            while (i <= j)
            {
                while (shirts[i].Fabric < pivot)
                    i++;
                while (shirts[j].Fabric > pivot)
                    j--;

                if (i <= j)
                {
                    //swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortByFabric(shirts, left, j);
            if (i < right)
                QuicksortByFabric(shirts, i, right);
        }
    }
}
