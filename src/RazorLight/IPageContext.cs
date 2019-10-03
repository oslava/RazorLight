﻿using System.IO;

namespace RazorLight
{
    public interface IPageContext
    {
        /// <summary>
		/// Gets the current writer.
		/// </summary>
		/// <value>The writer.</value>
		TextWriter Writer { get; set; }


		System.Dynamic.ExpandoObject ViewBag { get; }
    }
}