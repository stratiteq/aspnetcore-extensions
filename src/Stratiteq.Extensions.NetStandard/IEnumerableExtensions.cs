// Copyright (c) Stratiteq Sweden AB. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace Stratiteq.Extensions.NetStandard
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Apply an action to each element.
        /// </summary>
        /// <typeparam name="T">Type of elements.</typeparam>
        /// <param name="enumerable">Collection to iterate.</param>
        /// <param name="action">Action to apply on each element.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable)
            {
                action(item);
            }
        }
    }
}
