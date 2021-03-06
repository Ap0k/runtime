// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace System.ComponentModel
{
    public interface IBindingListView : IBindingList
    {
        void ApplySort(ListSortDescriptionCollection sorts);

        string? Filter { get; set; }

        ListSortDescriptionCollection SortDescriptions { get; }

        void RemoveFilter();

        bool SupportsAdvancedSorting { get; }
        bool SupportsFiltering { get; }
    }
}
