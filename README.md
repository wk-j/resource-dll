## Dll

Load native library from assembly resource

## Compile Native Library (macOS)

```bash
mkdir .out
gcc -c -fPIC src/Native/Print.c -o .out/Print.o
gcc .out/Print.o -shared -o .out/Print.so
```

## Run C# App

```bash
dotnet run --project src/ResourceDll/ResourceDll.csproj
```