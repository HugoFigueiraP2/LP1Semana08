using System;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        public int CompareTo(Loot other)
        {
            if (other == null)
            {
                return 1;
            }

            int comp_Type = Kind.CompareTo(other.Kind);
            if (comp_Type != 0)
            {
               return comp_Type;
            }

            int comp_Value = Kind.CompareTo(other.Kind);
            if (comp_Value != 0)
            {
                return comp_Value;
            }

            
            return Description.CompareTo(other.Description);
            
        
        }
    }
}
