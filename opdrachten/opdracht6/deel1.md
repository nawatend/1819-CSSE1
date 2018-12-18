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

### Numeriek Data Types: 

| Benaming | .NET Type | Type                                                                                              | Size (bits) | Bereik (values)                                         |
| -------- | --------- | ------------------------------------------------------------------------------------------------- | ----------- | ------------------------------------------------------- |
| byte     | Byte      | Unsigned integer                                                                                  | 8           | 0 to 255                                                |
| sbyte    | SByte     | Signed integer                                                                                    | 8           | -128 to 127                                             |
| short    | Int16     | Signed integer                                                                                    | 16          | -32,768 to 32,767                                       |
| ushort   | UInt16    | Unsigned integer                                                                                  | 16          | 0 to 65,535                                             |
| int      | Int32     | Signed integer                                                                                    | 32          | -2,147,483,648 to 2,147,483,647                         |
| uint     | UInt32    | Unsigned integer                                                                                  | 32          | 0 to 4294967295                                         |
| long     | Int64     | Signed integer                                                                                    | 64          | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| ulong    | UInt64    | Unsigned integer                                                                                  | 64          | 0 to 18,446,744,073,709,551,615                         |
| float    | Single    | Single-precision floating point type                                                              | 32          | -3.402823e38 to 3.402823e38                             |
| double   | Double    | Double-precision floating point type                                                              | 64          | -1.79769313486232e308 to 1.79769313486232e308           |
| decimal  | Decimal   | Precise fractional or integral type that can represent decimal numbers with 29 significant digits | 128         | (+ or -)1.0 x 10e-28 to 7.9 x 10e28                     |





### - Wat is een dataformaat?
### - Welke dataformaten zijn er?
### - Wat zijn de verschillen?