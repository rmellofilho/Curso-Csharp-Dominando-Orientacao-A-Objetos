using System;

#if CALCULADORA
using Calculando;
#endif

#if OFICINA
using OficinaAutomobilistica;
#endif

class Program
{
    static void Main(string[] args)
    {
#if CALCULADORA
        ProgramCalculadora.Main(args);
#endif

#if OFICINA
        ProgramOficina.Main(args);
#endif
    }
}
