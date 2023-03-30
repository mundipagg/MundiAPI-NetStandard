// <copyright file="ListDateTimeConverter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Utilities
{
    using System;
    using APIMatic.Core.Utilities.Date;
    
    /// <summary>
    /// Extends from JsonConverter, allows the use of a custom converter.
    /// </summary>
    public class ListDateTimeConverter : CoreListDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        public ListDateTimeConverter() 
            : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        public ListDateTimeConverter(Type converter)
            : base(converter) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        /// <param name="format">format.</param>
        public ListDateTimeConverter(Type converter, string format)
            : base(converter, format) { }
    }
}