using System.Reflection;

namespace Factory
{ 
    class Program
    {
        static string[] ArgumentParser(string arg)
        {
            char separator = ';';
            string[] elements = arg.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] result = new string[elements.Length];
            Array.Copy(elements, result, elements.Length);

            return result;
        }

        static string GetDllFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public static string GetClassName(string input)
        {
            char firstLetter = input[0];
            string result;

            if (char.ToUpper(firstLetter) == 'S')
            {
                result = "SandwichOrder";
            }
            else
            {
                result = "BeerOrder";
            }

            return result;
        }

        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                var argList = ArgumentParser(arg);

                FileInfo fileInfo = new FileInfo(argList[0]);
                Assembly assembly = Assembly.LoadFrom(fileInfo.FullName);

                string dllName = GetDllFileName(argList[0]);
                Type type = assembly.GetType(dllName + "." + GetClassName(dllName));

                MethodInfo method = type.GetMethod("Process");
                PropertyInfo property = type.GetProperty("Title");

                object o = Activator.CreateInstance(type);
                property.SetValue(o, argList[1], null);

                method.Invoke(o, null);
                Console.WriteLine();
            }
        }
    }
}
