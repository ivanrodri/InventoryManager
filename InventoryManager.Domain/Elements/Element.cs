﻿using System;

namespace InventoryManager.Domain.Elements
{
    /// <summary>Esta es la clase elemento.</summary>
    public class Element : IAggregateRoot
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public DateTime ExpirationDate { get; protected set; }

        public DateTime EntryDate { get; protected set; }

        public DateTime? DeleteDate { get; protected set; }

        public string Type { get; protected set; }

        /// <summary>Este método permite la creación de un nuevo elemento.</summary>
        /// <param name="name">el nombre del elemtento</param>
        /// <param name="expirationDate">el nuevo elemtento</param>
        /// <param name="entryDate">el nuevo elemtento</param>
        /// <param name="type">el nuevo elemtento</param>
        public static Element Create(string name, DateTime expirationDate, DateTime entryDate, string type )
        {
             Element element = new Element()
            {
                Id = Guid.NewGuid(),
                Name = name,
                ExpirationDate = expirationDate,
                EntryDate = DateTime.Now,
                Type = type,
                 DeleteDate = null,
             };

            return element;
        }
    }
}
