﻿using System;

namespace InventoryManager.WebMVC.Models
{
    public class ElementViewModel
    {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public DateTime ExpirationDate { get; set; }

            public DateTime EntryDate { get; set; }

            public string Type { get; set; }

    }
}