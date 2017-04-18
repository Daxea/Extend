# Extend
C# Extension Methods for fun and experimentation

Extend is just a collection of little helper methods added as extension methods to common types in the .NET Framework. I hope to grow the collection to demonstrate the power of extension methods, as well as build the habit of using source control.

## Use

To include all extension methods in the core Extend library in your class, write the following statement at the top of your class file.
    
    using Extend;

To include extension methods only for specific types, write a using statement with the name of the type (pluralized). For example:
    
    using Extend.Strings;
    using Extend.Randoms;

## Naming Conventions

All Extension classes in the Extend namespace should be pluralized forms of the types that they modify. For example, if you want to "extend strings", your class should be called "Strings". Following this convention, it should be clear which types you are modifying with your using statements.

    // Most types will simply have an 's' added to the end.
    using Extend.Strings;
    using Extend.Randoms;
    using Extend.Arrays;
    using Extend.Ints;
    using Extend.Enumerables;
    // Some types, such as a MyCustomProperty, will need the 'ies' ending.
    using Extend.MyCustomProperties;
    // Just use what makes sense in English when pluralizing.
