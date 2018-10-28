﻿namespace TypeLitePlus.TsModels
{
    /// <summary>
    /// Represents a type of the TsType
    /// </summary>
    internal enum TsTypeFamily
    {
        /// <summary>
        /// System type
        /// </summary>
        /// <remarks>
        /// e.g. string, int, ...
        /// </remarks>
        System,

        /// <summary>
        /// Collection
        /// </summary>
        Collection,

        /// <summary>
        /// Class
        /// </summary>
        Class,

        /// <summary>
        /// Enum
        /// </summary>
        Enum,

        /// <summary>
        /// Other type
        /// </summary>
        Type
    }
}
