﻿using System;
using System.Collections.Generic;

namespace Mh
{
    public static partial class PrimitiveExtensions
    {
        public static bool IsNullOrEmpty<T>(this T[] array)
        {
            return array == null || array.Length == 0;
        }

        public static int BinarySearch<T>(this T[] array, T value)
        {
            return Array.BinarySearch(array, value);
        }

        public static int BinarySearch<T>(this T[] array, int index, int length, T value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        public static int BinarySearch<T>(this T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }

        public static void ClearAll(this Array array)
        {
            Clear(array, 0, array.Length);
        }

        public static void Clear(this Array array, int index, int length)
        {
            Array.Clear(array, index, length);
        }

        public static void ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        public static void Copy(this Array sourceArray, Array destinationArray, int length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        public static void Copy(this Array sourceArray, Array destinationArray, long length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        public static void Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        public static void Copy(this Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        public static bool Exists<T>(this T[] array, Predicate<T> match)
        {
            return Array.Exists(array, match);
        }

        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }

        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }

        public static int FindIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindIndex(array, match);
        }

        public static int FindIndex<T>(this T[] array, int startIndex, Predicate<T> match)
        {
            return Array.FindIndex(array, startIndex, match);
        }

        public static int FindIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
        {
            return Array.FindIndex(array, startIndex, count, match);
        }

        public static T FindLast<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLast(array, match);
        }

        public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLastIndex(array, match);
        }

        public static int FindLastIndex<T>(this T[] array, int startIndex, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, match);
        }

        public static int FindLastIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, count, match);
        }

        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }

        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }

        public static int IndexOf<T>(this T[] array, T value, int startIndex)
        {
            return Array.IndexOf(array, value, startIndex);
        }

        public static int IndexOf<T>(this T[] array, T value, int startIndex, int count)
        {
            return Array.IndexOf(array, value, startIndex, count);
        }

        public static int LastIndexOf<T>(this T[] array, T value)
        {
            return Array.LastIndexOf(array, value);
        }

        public static int LastIndexOf<T>(this T[] array, T value, int startIndex)
        {
            return Array.LastIndexOf(array, value, startIndex);
        }

        public static int LastIndexOf<T>(this T[] array, T value, int startIndex, int count)
        {
            return Array.LastIndexOf(array, value, startIndex, count);
        }

        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        public static void Reverse(this Array array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }

        public static void Sort<T>(this T[] array)
        {
            Array.Sort(array);
        }

        public static void Sort<T>(this T[] array, IComparer<T> comparer)
        {
            Array.Sort(array, comparer);
        }

        public static void Sort<T>(this T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }

        public static void Sort<T>(this T[] array, int index, int length)
        {
            Array.Sort(array, index, length);
        }

        public static void Sort<T>(this T[] array, int index, int length, IComparer<T> comparer)
        {
            Array.Sort(array, index, length, comparer);
        }

        public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }
    }
}
