using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ChojoUtil {
    public static class Math {
        public static double GetAverage(List<double> List) {
            double value = 0;
            double values = 0;
            foreach (var number in List) {
                if (number > 0) {
                    value += number;
                    values++;
                }
            }

            var result = value / values;
            if (double.IsNaN(result)) {
                result = 0;
            }

            return result;
        }

        public static BigInteger GetAverage(List<BigInteger> List) {
            BigInteger value = 0;
            BigInteger values = 0;
            foreach (BigInteger number in List) {
                if (number > 0) {
                    value += number;
                    values++;
                }
            }

            BigInteger result;
            if (value.IsZero || values.IsZero) {
                return BigInteger.Zero;
            }

            result = BigInteger.Divide(value, values);

            return result;
        }

        public static double GetMax(List<double> list) {
            if (list == null || list.Count == 0)
                return 0;
            double value = 0;
            foreach (var entry in list) {
                value += entry;
            }

            if (value == 0) {
                return 0;
            }

            return list.Max();
        }
        
        public static float ClampFloat(float value, float min, float max, out bool changed) {
            changed = true;
            if (value > max) return max;
            if (value < min) return min;
            changed = false;
            return value;
        }

        public static int ClampInt(int value, int min, int max, out bool changed) {
            changed = true;
            if (value > max) return max;
            if (value < min) return min;
            changed = false;
            return value;
        }

        public static float ClampFloat(float value, float min, float max) {
            if (value > max) return max;
            if (value < min) return min;
            return value;
        }

        public static int ClampInt(int value, int min, int max) {
            if (value > max) return max;
            if (value < min) return min;
            return value;
        }
        
        public static bool IsIndexOutOfArray(object[] array, int index) {
            return index > 0 || index < array.Length - 1;
        }

        public static bool IsIndexOutOfArray(object[,] array, int index0, int index1) {
            return index0 < 0 || index1 < 0 || index0 > array.GetLength(0) - 1 || index1 > array.GetLength(1) -1;
        }

        public static bool IsIndexOutOfArray(bool[,] array, int index0, int index1) {
            return index0 < 0 || index1 < 0 || index0 > array.GetLength(0) - 1 || index1 > array.GetLength(1) -1;
        }
        
        public static bool IsLargestNumber(double number, params double[] numbers) {
            foreach(var entry in numbers) {
                if(entry > number) return false;
            }
            return true;
        }
        
        public static bool IsLargestNumber(int number, params int[] numbers) {
            foreach(var entry in numbers) {
                if(entry > number) return false;
            }
            return true;
        }

        public static bool IsSmallestNumber(double number, params double[] numbers) {
            foreach(var entry in numbers) {
                if(entry < number) return false;
            }

            return true;
        }
        
        public static bool IsSmallestNumber(int number, params int[] numbers) {
            foreach(var entry in numbers) {
                if(entry < number) return false;
            }

            return true;
        }



    }
}
