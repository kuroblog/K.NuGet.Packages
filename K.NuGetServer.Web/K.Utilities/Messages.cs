// <copyright file="Messages.cs" company="K&amp;T">
// Copyright (c) K&amp;T. All rights reserved.
// </copyright>

namespace K.Utilities
{
    /// <summary>
    /// Messages
    /// </summary>
    public class Messages
    {
        /// <summary>
        /// messages
        /// </summary>
        /// <returns>sssss</returns>
        public virtual string GetTestMessage()
        {
            return $"this is a test message from ${typeof(Messages).FullName}";
        }
    }
}
