using System.Reflection;

namespace LAB_06
{
    class Program
    {
        static void Main()
        {
            var info = typeof(Customer);

            Console.WriteLine("Fields: ");

            var fields = info.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            var groupedFields = fields.GroupBy(f => f.IsPublic ? "Public" : f.IsPrivate ? "Private" : "Protected");

            foreach (var group in groupedFields)
            {
                Console.WriteLine($"Access Modifier: {group.Key}");

                foreach (var field in group)
                {
                    Console.WriteLine($"Field Name: {field.Name}, Type: {field.FieldType}");
                }
            }

            Console.WriteLine("Methods: ");

            var methods = info.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            var groupedMethods = methods.GroupBy(m => m.IsPublic ? "Public" : m.IsPrivate ? "Private" : "Protected");

            foreach (var group in groupedMethods)
            {
                Console.WriteLine($"Access Modifier: {group.Key}");

                foreach (var method in group)
                {
                    Console.WriteLine($"Method Name: {method.Name}");
                }
            }

            Console.WriteLine("Nested types: ");

            var nestedTypes = info.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var nestedType in nestedTypes)
            {
                Console.WriteLine($"Nested Type: {nestedType.Name}");
            }

            Console.WriteLine("Properties: ");

            var properties = info.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            foreach (var property in properties)
            {
                Console.WriteLine($"Property Name: {property.Name}");
            }

            Console.WriteLine("Members: ");

            var members = info.GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach(var member in members)
            {
                Console.WriteLine($"Member Name: {member.Name}");
            }

            var customer = new Customer("Adrian");

            info.GetProperty("Address").SetValue(customer, "Zalno 5");
            info.GetProperty("SomeValue").SetValue(customer, 1234);

            Console.WriteLine("Customer Properties:");
            Console.WriteLine("Adress: " + info.GetProperty("Address").GetValue(customer));
            Console.WriteLine("SomeValue: " + info.GetProperty("SomeValue").GetValue(customer));

            Console.ReadKey();
        }
    }
}
