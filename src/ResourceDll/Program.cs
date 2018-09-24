using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ResourceDll {

    class Program {

        [DllImport("Print.so", EntryPoint = "print")]
        private static extern void Print(string message);

        private static Stream ReadResource() {
            var assembly = Assembly.GetExecutingAssembly();
            var location = assembly.Location;
            var resourceStream = assembly.GetManifestResourceStream("ResourceDll.Print.so");
            return resourceStream;
        }

        static void Main(string[] args) {
            var stream = ReadResource();
            using (var file = new FileStream("Print.so", FileMode.OpenOrCreate)) {
                stream.CopyTo(file);
            }

            Print("Hello, world!");
        }
    }
}
