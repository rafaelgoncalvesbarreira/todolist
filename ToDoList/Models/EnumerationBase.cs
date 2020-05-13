using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ToDoList.Mvc.Models
{
    public abstract class EnumerationBase : IComparable
    {
        public int Id { get; set; }
        public string Description { get; set; }

        protected EnumerationBase(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString() => Description;

        public override bool Equals(object obj)
        {
            var otherValue = obj as EnumerationBase;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public static IEnumerable<T> GetAll<T>() where T : EnumerationBase
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }
        public int CompareTo(object obj)
        {
            return Id.CompareTo(((EnumerationBase)obj).Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
