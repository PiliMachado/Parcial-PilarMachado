using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
        public string AsText()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"La fecha es {this.EndDate}");
            foreach (PublicationItem publication in this.Items)
            {
                result.Append($"{publication.Quantity}, {publication.Price}, {publication.Material}");
            }
            return result.ToString();

        }
    }
}