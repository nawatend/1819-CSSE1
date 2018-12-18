# Deel 1
## Verslag omtrent Dataformaten

Er zijn twee soorten van data types in C#, namelijk 'value type' en 'reference type'. Variabelen van 'value type' krijgt direct de waarde en variabelen van 'reference type' sla reference op. 
Met 'reference type' kan je twee variabelen naar een zelfde object verwijzen. Dus er zijn gevolgen als je een variable aanpast. Met 'value type', variabelen hebben eigen kopie van data.

### C# Value Types: Onderdeling
1. Simple Types
   * Signed integral: sbyte, short, int, long
   * Unsigned integral: byte, ushort, uint, ulong
   * Unicode characters: char
   * IEEE floating point: float, double
   * High-precision decimal: decimal
   * Boolean: bool
2. Enum types
   * User-defined types of the form enum E {...}
3. Struct types
   * User-defined types of the form struct S {...}
4. Nullable value types
   * Extensions of all other value types with a null value


### C# Reference Types: Onderdeling
1. Class types
   * Ultimate base class of all other types: object
   * Unicode strings: string
   * User-defined types of the form class C {...}
2. Interface types
   * User-defined types of the form interface I {...}
3. Array types
   * Single- and multi-dimensional, for example, int[] and int[,]
4. Delegate types
   * User-defined types of the form delegate int D(...)


De 8 integral types heeft ondersteuning voor 8, 16, 32 en 64-bit value in signed or unsigned vorm. 
Twee floating-point types: *float* and *double* heeft ondersteuning van 32-bit single-precision and 64-bit double-precision.
*Decimal* type is een 128-bit data type. 

*Bool* is een type waar je waard *true of  false* toekennen.





### - Wat is een dataformaat?
### - Welke dataformaten zijn er?
### - Wat zijn de verschillen?