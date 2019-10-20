using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Collections
{
    [XmlRoot("data")]
    public class Opinions
    {
        private List<Opinion> _opinions = new List<Opinion>();

        [XmlArray("opinions")]
        [XmlArrayItem("opinion")]
        public List<Opinion> Data
        {
            get => _opinions;
            set => _opinions = value;
        }

        public IEnumerable<Opinion> Take(int count) => _opinions.Take(count);
        public int Max(Func<Opinion, int> f) => _opinions.Max(f);

        public void Add(Opinion item) => _opinions.Add(item);

        public void Clear() => _opinions.Clear();

        public bool Contains(Opinion item) => _opinions.Contains(item);

        public void CopyTo(Opinion[] array, int arrayIndex) => _opinions.CopyTo(array, arrayIndex);

        public bool Remove(Opinion item) => _opinions.Remove(item);

        public int Count => _opinions.Count;
        public bool IsReadOnly => false;
    }
}