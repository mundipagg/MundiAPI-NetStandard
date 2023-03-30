// <copyright file="MapDateTimeConverter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Utilities
{
    using System;
    using APIMatic.Core.Utilities.Date;

    /// <summary>
    /// Extends from JsonConverter, allows the use of a custom converter.
    /// </summary>
    public class MapDateTimeConverter : CoreMapDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        public MapDateTimeConverter()
            : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        public MapDateTimeConverter(Type converter)
            : base(converter) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        /// <param name="format">format.</param>
        public MapDateTimeConverter(Type converter, string format)
            : base(converter, format) { }
    }
}