﻿
//===============================================================================
//
//  IMPORTANT NOTICE, PLEASE READ CAREFULLY:
//
//  => This code is licensed under the GNU General Public License (GPL v3). A copy of the license is available at:
//        https://www.gnu.org/licenses/gpl.txt
//
//  => As stated in the license text linked above, "The GNU General Public License does not permit incorporating your program into proprietary programs". It also does not permit incorporating this code into non-GPL-licensed code (such as MIT-licensed code) in such a way that results in a non-GPL-licensed work (please refer to the license text for the precise terms).
//
//  => Licenses that permit proprietary use are available at:
//        http://www.cshtml5.com
//
//  => Copyright 2019 Userware/CSHTML5. This code is part of the CSHTML5 product (cshtml5.com).
//
//===============================================================================



using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Markup;

#if MIGRATION
namespace System.Windows.Documents
#else
namespace Windows.UI.Xaml.Documents
#endif
{
    /// <summary>
    /// Represents a collection of Inline elements.
    /// </summary>
    [ContentWrapper(typeof(Run))] // Note: this attribute prevents the XAML Designer error that says that it is not possible to put a String inside an InlineCollection.
    //[ContentWrapper(typeof(InlineUIContainer))]
    public sealed class InlineCollection : List<Inline> //IEnumerable, IList
    {
        /// <summary>
        /// Adds a string to the collection.
        /// </summary>
        /// <param name="text">The text to add.</param>
        public void Add(string text)
        {
            base.Add(new Run() { Text = text });
        }
    }
}