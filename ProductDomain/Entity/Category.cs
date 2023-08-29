using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Entity
{
    public class Category
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string Url { get; private set; }
        public bool Visiable { get; private set; }
        public bool Deleted { get; private set; }

        private Category() { }

        public Category(string name, string url, bool visiable = true, bool deleted = false)
        {
            Id = Guid.NewGuid();
            Name = name;
            Url = url;
            Visiable = visiable;
            Deleted = deleted;
        }
    }
}
