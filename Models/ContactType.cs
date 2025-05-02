﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

/// <summary>
/// Lookup table containing the types of business entity contacts.
/// </summary>
public partial class ContactType
{
    /// <summary>
    /// Primary key for ContactType records.
    /// </summary>
    public int ContactTypeID { get; set; }

    /// <summary>
    /// Contact type description.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; } = new List<BusinessEntityContact>();
}
