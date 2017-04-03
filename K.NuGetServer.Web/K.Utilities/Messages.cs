// <copyright file="Messages.cs" company="K&amp;T">
// Copyright (c) K&amp;T. All rights reserved.
// </copyright>

namespace K.Utilities
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// provide message processing
    /// </summary>
    public class Messages
    {
        /// <summary>
        /// get a test message
        /// </summary>
        /// <returns>
        /// return a test message, type is
        /// <see cref="string"/>
        /// </returns>
        [ExcludeFromCodeCoverage]
        public virtual string GetTestMessage()
        {
            return $"this is a test message from ${typeof(Messages).FullName}";
        }
    }
}
