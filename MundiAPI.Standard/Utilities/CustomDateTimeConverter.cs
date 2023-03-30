// <copyright file="CustomDateTimeConverter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Utilities
{
    using APIMatic.Core.Utilities.Date;

    /// <summary>
    /// Extends from IsoDateTimeConverter to allow a custom DateTime format.
    /// </summary>
    public class CustomDateTimeConverter : CoreCustomDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="format">format.</param>
        public CustomDateTimeConverter(string format)
            : base(format) { }
    }
}