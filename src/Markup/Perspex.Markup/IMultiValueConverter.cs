﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Perspex.Markup
{
    /// <summary>
    /// Converts multi-binding inputs to a final value.
    /// </summary>
    public interface IMultiValueConverter
    {
        /// <summary>
        /// Converts multi-binding inputs to a final value.
        /// </summary>
        /// <param name="values">The values to convert.</param>
        /// <param name="targetType">The type of the target.</param>
        /// <param name="parameter">A user-defined parameter.</param>
        /// <param name="culture">The culture to use.</param>
        /// <returns>The converted value.</returns>
        /// <remarks>
        /// This method should not throw exceptions. If the value is not convertible, return
        /// <see cref="PerspexProperty.UnsetValue"/>. Any exception thrown will be treated as
        /// an application exception.
        /// </remarks>
        object Convert(IList<object> values, Type targetType, object parameter, CultureInfo culture);
    }
}
