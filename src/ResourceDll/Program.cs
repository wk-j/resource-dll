using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ResourceDll {

    class Program {

        [DllImport("Print.so", EntryPoint = "print")]
        private static extern void Print(string message);

        private static Stream ReadResource(string fileName) =>
            Assembly.GetExecutingAssembly().GetManifestResourceStream($"ResourceDll.{fileName}");

        static void Main(string[] args) {
            var stream = ReadResource("Print.so");
            using (var file = new FileStream("Print.so", FileMode.OpenOrCreate)) {
                stream.CopyTo(file);
            }

            Print("Hello, world!");
        }
    }
}
