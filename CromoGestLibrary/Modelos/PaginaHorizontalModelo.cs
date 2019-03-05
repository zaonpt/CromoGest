using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CromoGestLibrary.Modelos
{
    public class PaginaHorizontalModelo: ICustomTypeDescriptor
    {
        class MyDescriptor : PropertyDescriptor
        {
            public MyDescriptor(string name) : base(name, null) { }
            public override bool CanResetValue(object component) => true;
            public override Type ComponentType => typeof(PaginaHorizontalModelo);
            public override object GetValue(object component) => (component as PaginaHorizontalModelo)[Name];
            public override bool IsReadOnly => false;
            public override Type PropertyType => typeof(object);
            public override void ResetValue(object component) => (component as PaginaHorizontalModelo).properties.Remove(Name);
            public override void SetValue(object component, object value) => (component as PaginaHorizontalModelo)[Name] = value;
            public override bool ShouldSerializeValue(object component) => (component as PaginaHorizontalModelo).properties.ContainsKey(Name);
        }

        Dictionary<string, object> properties = new Dictionary<string, object>();

        public object this[string name]
        {
            get { if (properties.ContainsKey(name)) { return properties[name]; } return null; }
            set { properties[name] = value; }
        }

        #region ICustomTypeDescriptor Membres
        public AttributeCollection GetAttributes() => AttributeCollection.Empty;
        public string GetClassName() => null;
        public string GetComponentName() => null;
        public TypeConverter GetConverter() => null;
        public EventDescriptor GetDefaultEvent() => null;
        public PropertyDescriptor GetDefaultProperty() => null;
        public object GetEditor(Type editorBaseType) => null;
        public EventDescriptorCollection GetEvents(Attribute[] attributes) => EventDescriptorCollection.Empty;
        public EventDescriptorCollection GetEvents() => EventDescriptorCollection.Empty;
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => new PropertyDescriptorCollection(properties.Keys.Select(key => new MyDescriptor(key)).ToArray());
        public PropertyDescriptorCollection GetProperties() => GetProperties(null);
        public object GetPropertyOwner(PropertyDescriptor pd) => this;
        #endregion
               
    }
}
