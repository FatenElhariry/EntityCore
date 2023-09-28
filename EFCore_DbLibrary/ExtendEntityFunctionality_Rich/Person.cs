
namespace EFCore_DbLibrary
{
    public partial class Person
    {
        public override string ToString()
        {
            var values = GetType().GetProperties()
                      .Where(x => x.PropertyType.IsAssignableTo(typeof(string)) || x.PropertyType.IsAssignableTo(typeof(ValueType))) 
                     .Select(x => $"{x.Name}:\t {x.GetValue(this)}").ToArray();
            return string.Join ("\n", values) ;
        }
    }
}
