## Commands

```bash
gcc -c -fPIC src/Native/Print.c -o .out/Print.o
gcc .out/Print.o -shared -o .out/Print.so
```