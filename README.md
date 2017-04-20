# Intro to F#

## Functional vs OO

* OO combines data and the operations on that data
* Functional separates the data from the functions performed on it
* Everything is immutable by default
* Functions are pure - they don't alter state, they only accept inputs and return outputs
* Instead of modifying state stored in classes in an OO language, functional programming is a collection of transformations that when composed together convert input to output
* Uses:
    * Originally regarded as only useful for deeply mathematical problems, F# combines several other paradigms to make it a good fit for web projects, enterprise apps, etc.

## C# vs F#

* Both created by Microsoft
* Both are multi paradigm (also include imperative, procedural)
* C# is C style (shares similar flow control, style)
* C# is primarily object-oriented with some functional capabilities (lamda expressions, tuples in 6+)
* F# is functional first, but has a lot of OO concepts (classes, inheritance, interfaces) - other examples are Scheme/Haskell
* F# has great type safety - forcing you to account for all possibilities with exceptions and match conditions
* Both can be share libraries through .NET interoperability

## F#

* File order matters - show examples
* Use `open` instead of `using`
* Define application entry point using the `[<EntryPoint>]` attribute
* Code is organised into namespaces and modules
* Whitespace sensitive! Space, not tabs
* `let` is used to declare values (similar to `var`, but they chose to avoid `var` as it implied variability, which is not the case with immutable values)
* Values can be declared as mutable, but should only be used in exceptional circumstances
* Returned value is the last line in a method - no need for explicit return