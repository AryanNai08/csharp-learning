

# C# Basics - Complete Theory & Practice Guide

---


# Introduction

C# (C-Sharp) is a modern, object-oriented, type-safe programming language developed by Microsoft as part of the .NET ecosystem. It is widely used for building desktop applications, web applications, APIs, enterprise systems, cloud services, and games.

This document is designed as a single, complete learning book for C# basics, combining theory + practice in a professional, internship-ready, and interview-oriented manner.
The content strictly follows the provided video syllabus order and focuses on clarity, correctness, and real-world relevance.

---

# Learning Resources

- Primary Video Tutorial: [YouTube C# Full Course](https://youtu.be/YrtFtdTTfv0?si=jf2kSHMG0RuLtrCL)

- W3Schools – [C# Tutorial](https://www.w3schools.com/cs/index.php)

- GeeksforGeeks – [C# Programming](https://www.geeksforgeeks.org/c-sharp/csharp-programming-language/)


---

# 🎯 What is C#?
C# (pronounced "C Sharp") is a modern, object-oriented programming language developed by Microsoft in 2000 as part of the .NET initiative. It was designed by Anders Hejlsberg and his team with the goal of creating a language that combines the power of C++ with the simplicity of Visual Basic.
Key Characteristics:

- Type-Safe: Prevents many common programming errors at compile-time
- Object-Oriented: Everything is an object, supporting encapsulation, inheritance, and polymorphism
- Managed Code: Runs on the Common Language Runtime (CLR) with automatic memory management
- Cross-Platform: Works on Windows, Linux, and macOS through .NET Core/.NET 5+
- Strongly Typed: Variables must have a defined type
- Modern Features: Supports async/await, LINQ, pattern matching, and more

---

## 💪 Why C#? Advantages Over Other Languages

| Feature | C# | Java |
|--------|----|------|
| Properties | Built-in support using `get` / `set` | Requires explicit getter and setter methods |
| LINQ (Querying) | Native LINQ syntax integrated into the language | Uses Stream API, which is more verbose |
| Events | First-class support using the `event` keyword | Implemented via listener interfaces |
| Async / Await | Native async/await support, clean and readable | Uses `CompletableFuture`, more complex |
| Platform Model | Single, unified .NET platform | JVM with multiple frameworks |
| Modern Features | Faster adoption of modern language features | More conservative update cycle |

---


## 1. C# Program Structure

### Theory
Every C# program needs a starting point. The `Main` method is the entry point where program execution begins. C# is a strongly-typed, object-oriented programming language developed by Microsoft as part of the .NET framework.

**Key Points:**
- `class` defines a blueprint for objects
- `Main` method is the entry point (execution starts here)
- `static` means the method belongs to the class, not an instance
- `void` means the method doesn't return any value
- `String[] args` - array of command-line arguments

### Why We Need Structure
- **Organization**: Keeps code organized and maintainable
- **Entry Point**: Computer needs to know where to start
- **Readability**: Standard structure makes code understandable

### Code Example
```csharp
class MainProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

---

## 2. Numeric Data Types

### Theory
Data types specify what kind of data a variable can hold. Numeric types store numbers with different ranges and precision. Choosing the right type saves memory and prevents overflow errors.

**Key Points:**
- `int` - 32-bit integer (-2,147,483,648 to 2,147,483,647)
- `long` - 64-bit integer (very large numbers, suffix `L`)
- `double` - 64-bit floating-point (decimal numbers, suffix `D`)
- `float` - 32-bit floating-point (less precision, suffix `F`)
- `decimal` - 128-bit high precision (money calculations, suffix `M`)

### Why Different Types?
- **Memory Efficiency**: Smaller types use less memory
- **Precision**: Decimal for money (no rounding errors)
- **Range**: Long for very large numbers
- **Performance**: Smaller types are faster

### When to Use
- `int` - Age, counts, small numbers
- `long` - Population, large IDs
- `double` - Scientific calculations, coordinates
- `float` - Graphics, gaming (when precision isn't critical)
- `decimal` - Money, finance (exact precision needed)

---

## 3. Text-Based Data Types

### Theory
Text data types store characters and strings. A `char` holds a single character, while a `string` holds multiple characters (text).

**Key Points:**
- `string` - sequence of characters (text), use double quotes `""`
- `char` - single character, use single quotes `''`
- Strings are immutable (cannot be changed after creation)
- Strings are reference types, chars are value types

### Why We Need Them
- **User Input**: Store names, addresses, messages
- **Display**: Show information to users
- **Data Processing**: Manipulate text data

### When to Use
- `string` - Names, messages, sentences, paragraphs
- `char` - Single letters, grades (A, B, C), yes/no (Y/N)

---

## 4. Type Conversion - String to Number

### Theory
Type conversion (casting) is the process of converting one data type to another. `Convert` class provides methods to safely convert between types.

**Key Points:**
- `Convert.ToInt32()` - string to int
- `Convert.ToInt64()` - string to long
- `Convert.ToDouble()` - string to double
- `Convert.ToSingle()` - string to float
- `Convert.ToDecimal()` - string to decimal
- Throws exception if conversion fails

### Why We Need Conversion
- **User Input**: Console.ReadLine() returns string
- **File Data**: Data from files is usually text
- **Calculations**: Need numbers to do math

### When to Use
- Converting user input for calculations
- Reading data from files/databases
- Processing form data

---

## 5. Boolean Data Type

### Theory
Boolean is a logical data type that can only have two values: `true` or `false`. Used for decision-making and conditions.

**Key Points:**
- Only two possible values: `true` or `false`
- Used in conditional statements (if, while, for)
- Result of comparison operations (==, !=, <, >)
- 1 bit of information (but stored in 1 byte)

### Why We Need Booleans
- **Decisions**: Control program flow
- **Flags**: Track states (isLoggedIn, isActive)
- **Validation**: Check conditions (isValid, hasPermission)

### When to Use
- Checking conditions (if user is logged in)
- Toggle states (on/off, enabled/disabled)
- Validation results (valid/invalid)

---

## 6. Operators (+ - * / % ++ --)

### Theory
Operators are symbols that perform operations on variables and values. Arithmetic operators perform mathematical calculations.

**Key Points:**
- `+` Addition (also string concatenation)
- `-` Subtraction
- `*` Multiplication
- `/` Division
- `%` Remainder (modulus)
- `++` Increment by 1
- `--` Decrement by 1
- `+=`, `-=`, `*=`, `/=` Compound assignment

### Why We Need Operators
- **Calculations**: Perform mathematical operations
- **String Building**: Concatenate strings
- **Counters**: Increment/decrement values

### When to Use
- Mathematical calculations
- Building strings from parts
- Loop counters
- Updating values

---

## 7. Remainder Operator (%)

### Theory
The modulus operator `%` returns the remainder after division. It's extremely useful for checking divisibility and cycling through values.

**Key Points:**
- Returns remainder of division
- `10 % 3` = 1 (10 ÷ 3 = 3 remainder 1)
- `10 % 2` = 0 (even number)
- `11 % 2` = 1 (odd number)

### Why We Need Modulus
- **Even/Odd Check**: `num % 2 == 0` means even
- **Cycling**: Array indices, circular buffers
- **Divisibility**: Check if number divides evenly
- **Pattern Creation**: Every nth item

### When to Use
- Checking even/odd numbers
- Finding last digit of number
- Cycling through array indices
- Creating patterns (every 3rd, 5th item)

### Real-World Examples
- Pagination (show 10 items per page)
- Time calculations (60 seconds = 1 minute)
- Grid layouts (items per row)

---

## 8. Var Keyword

### Theory
The `var` keyword tells the compiler to infer (figure out) the type from the assigned value. It's not dynamic typing - the type is determined at compile time and cannot change.

**Key Points:**
- Type inference (compiler determines type)
- Must be initialized when declared
- Type cannot change after initialization
- Still strongly typed
- Makes code cleaner, less repetitive

### Why Use Var
- **Less Typing**: Shorter code
- **Readability**: Obvious types don't need explicit declaration
- **Refactoring**: Easier to change types

### When to Use
- When type is obvious from assignment
- Complex type names (generics)
- Anonymous types (LINQ)

### When NOT to Use
- When type isn't obvious
- Public APIs (be explicit)
- When clarity is more important than brevity

---

## 9. Const Keyword

### Theory
The `const` keyword creates constants - values that cannot be changed after declaration. Constants are compile-time values that are replaced with their actual values during compilation.

**Key Points:**
- Value cannot be changed (immutable)
- Must be initialized at declaration
- Value must be known at compile time
- Implicitly static (shared across all instances)
- Named in UPPERCASE or PascalCase

### Why Use Constants
- **Safety**: Prevent accidental value changes
- **Readability**: Named values instead of magic numbers
- **Maintainability**: Change in one place
- **Performance**: Compiler optimizes

### When to Use
- Mathematical constants (PI, E)
- Configuration values that never change
- Fixed rates (TAX_RATE, MAX_ATTEMPTS)
- Application version numbers

---

## 10. Console Input/Output

### Theory
Console I/O allows interaction with users through the terminal. `Console.WriteLine()` outputs text with a newline, `Console.Write()` outputs without newline, and `Console.ReadLine()` reads user input.

**Key Points:**
- `Console.WriteLine()` - output with newline
- `Console.Write()` - output without newline
- `Console.ReadLine()` - reads input as string
- Always returns string (need conversion for numbers)

### Why We Need Console I/O
- **User Interaction**: Get input from users
- **Feedback**: Display results and messages
- **Debugging**: Print values during development

### When to Use
- Creating interactive console applications
- Getting user input
- Displaying results and messages
- Quick testing and debugging


---

## 11. If Statements

### Theory
If statements control program flow based on conditions. They execute code blocks only when specified conditions are true.

**Key Points:**
- `if` - executes if condition is true
- `else if` - additional conditions
- `else` - executes when all conditions are false
- Comparison operators: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Logical operators: `&&` (AND), `||` (OR), `!` (NOT)

### Why We Need Conditionals
- **Decision Making**: Different actions for different situations
- **Validation**: Check if data is valid
- **Flow Control**: Direct program execution

### When to Use
- Validating user input
- Checking conditions before proceeding
- Different behavior based on state
- Error handling

---

## 12. Switch Statements

### Theory
Switch statements provide a cleaner way to check a variable against multiple values. Better than multiple if-else statements when checking one variable against many constant values.

**Key Points:**
- Cleaner than multiple if-else for one variable
- Each case must end with `break`
- `default` case handles unmatched values
- Can only compare equality (not ranges)
- Works with: int, string, char, enum

### Why Use Switch
- **Readability**: Cleaner than multiple if-else
- **Performance**: Can be faster for many cases
- **Maintainability**: Easy to add new cases

### When to Use
- Menu selections
- Day of week, month selection
- Status codes
- Multiple fixed options

### When NOT to Use
- Range comparisons (use if-else)
- Complex conditions (use if-else)
- Less than 3 options (if-else is simpler)


---

## 13. For Loops

### Theory
For loops repeat a block of code a specific number of times. Best when you know exactly how many iterations you need.

**Key Points:**
- Three parts: initialization, condition, increment
- `for (int i = 0; i < 10; i++)`
- Initialization runs once at start
- Condition checked before each iteration
- Increment runs after each iteration

### Why We Need Loops
- **Repetition**: Avoid repeating code
- **Iteration**: Process arrays/collections
- **Efficiency**: Do same task multiple times

### When to Use
- Known number of iterations
- Iterating through arrays
- Creating patterns
- Countdown/countup

---

## 14. While Loops

### Theory
While loops repeat code as long as a condition is true. Use when you don't know how many iterations are needed. `do-while` guarantees at least one execution.

**Key Points:**
- `while` - checks condition first
- `do-while` - executes once, then checks condition
- Condition must eventually become false (avoid infinite loops)
- Used when iteration count is unknown

### Difference: While vs Do-While
- **while**: May never execute (if condition false initially)
- **do-while**: Always executes at least once

### When to Use
- Unknown number of iterations
- Reading until end of file
- User input validation (retry until correct)
- Game loops

---

## 15. Conditional (Ternary) Operator (?)

### Theory
The ternary operator is a shorthand for if-else statements. It's a compact way to assign values based on a condition.

**Key Points:**
- Syntax: `condition ? trueValue : falseValue`
- Returns one of two values based on condition
- More concise than if-else
- Can be nested (but avoid for readability)

### Why Use Ternary Operator
- **Conciseness**: One line instead of 4-5 lines
- **Assignment**: Directly assign based on condition
- **Readability**: Simple conditions are clearer

### When to Use
- Simple conditional assignments
- Quick value selection
- Short conditions

### When NOT to Use
- Complex conditions (use if-else)
- Multiple statements (use if-else)
- Nested ternary (hard to read)


---

## 16. Numeric Formatting

### Theory
String formatting controls how numbers are displayed. You can specify decimal places, currency symbols, and culture-specific formats.

**Key Points:**
- `string.Format()` - formats values into strings
- `ToString()` - converts to string with formatting
- `{0:0.00}` - format specifiers
- `C` - currency format
- `CultureInfo` - locale-specific formatting

### Why Format Numbers
- **Readability**: Display numbers in user-friendly way
- **Currency**: Show money with symbols
- **Precision**: Control decimal places
- **Localization**: Format for different countries

### When to Use
- Displaying prices
- Financial reports
- Percentages
- Scientific notation


---

## 17. TryParse Function

### Theory
TryParse safely converts strings to numbers without throwing exceptions. Returns `true` if successful, `false` if failed. Much safer than Convert methods.

**Key Points:**
- Returns bool (true/false)
- Uses `out` parameter for result
- No exception if conversion fails
- Better than Convert for user input
- Available for all numeric types

### Why Use TryParse
- **Safety**: No exceptions thrown
- **Validation**: Know if conversion succeeded
- **User Input**: Handle invalid input gracefully
- **Performance**: Faster than try-catch

### When to Use
- Converting user input
- Parsing file data
- Any untrusted string data
- When validation is important



---

## 18. Verbatim String Literal (@)

### Theory
The `@` symbol creates verbatim strings that ignore escape sequences. Useful for file paths, regex patterns, and multi-line strings.

**Key Points:**
- Prefix string with `@`
- Backslashes treated literally (no escaping)
- Can span multiple lines
- Double quotes escaped by doubling: `""`

### Escape Sequences (Without @)
- `\n` - newline
- `\t` - tab
- `\\` - backslash
- `\"` - quote

### Why Use Verbatim Strings
- **File Paths**: No need to double backslashes
- **Readability**: Easier to read paths and patterns
- **Multi-line**: SQL queries, JSON, XML

### When to Use
- Windows file paths
- Regular expressions
- SQL queries
- Multi-line strings


---

## 19. String Formatting ({0})

### Theory
String formatting with placeholders allows inserting values into strings at specific positions. More readable than concatenation for multiple values.

**Key Points:**
- `{0}`, `{1}`, `{2}` - placeholders (0-indexed)
- `string.Format()` or directly in methods
- Can reuse placeholders: `{0} + {0} = {1}`
- Can include format specifiers: `{0:C}`

### Why Use Formatting
- **Readability**: Clearer than multiple + operators
- **Reusability**: Use same value multiple times
- **Flexibility**: Easy to rearrange

### When to Use
- Multiple values in one string
- Template strings
- Localization (different languages)


---

## 20. String Interpolation ($)

### Theory
String interpolation (C# 6.0+) embeds expressions directly in strings using `$` prefix. Modern, readable alternative to `string.Format()`.

**Key Points:**
- Prefix string with `$`
- Embed expressions in `{}`
- Can include method calls
- More readable than concatenation or formatting
- Compiled to `string.Format()` internally

### Why Use Interpolation
- **Readability**: Most readable option
- **IntelliSense**: IDE supports expressions
- **Modern**: Current C# best practice
- **Flexibility**: Can include any expression

### When to Use
- Any string with variables (modern C#)
- Complex expressions
- Readability is priority

---

## 21. String Concatenation (+)

### Theory
String concatenation joins multiple strings into one. Can use `+` operator or `string.Concat()` method.

**Key Points:**
- `+` operator joins strings
- `string.Concat()` - method for concatenation
- Works with string arrays
- Creates new string (strings are immutable)

### Why Multiple Methods
- `+` - simple, readable
- `string.Concat()` - explicit, works with arrays
- `StringBuilder` - efficient for many operations

### When to Use
- Simple string joining
- Few concatenations
- Readability is priority

### When NOT to Use
- Many concatenations in loop (use StringBuilder)
- Complex formatting (use interpolation)


---

## 22. Empty String

### Theory
Empty string check validates if a string has no content. Important for input validation.

**Key Points:**
- `string.Empty` - represents empty string `""`
- Better than `""` (more explicit)
- Not the same as `null`
- Empty vs Null: empty has memory allocated, null doesn't

### Why Check Empty
- **Validation**: Ensure user provided input
- **Error Prevention**: Avoid processing empty data
- **User Feedback**: Tell user what's wrong

### When to Use
- Validating user input
- Checking form fields
- Data validation


---

## 23. String Equals Function

### Theory
`.Equals()` method compares string values, while `==` compares both values and references. Always use `.Equals()` for reliable string comparison.

**Key Points:**
- `.Equals()` - compares values only
- `==` - can compare references
- `.Equals()` is safer for strings
- Case-sensitive by default

### Why Use Equals
- **Reliability**: Always compares values correctly
- **Consistency**: Works same way every time
- **Safety**: Avoids reference comparison issues

### When to Use
- Comparing user input
- Validating passwords
- String matching

---

## 24. String Iteration (Looping)

### Theory
Strings are character arrays, so you can loop through them. Each character can be accessed by index.

**Key Points:**
- Strings are character arrays
- Access characters by index: `str[0]`
- `.Length` property gives string length
- `.Contains()` checks if substring exists
- Zero-indexed (starts at 0)

### Why Iterate Strings
- **Character Processing**: Analyze each character
- **Validation**: Check format, allowed characters
- **Transformation**: Modify each character
- **Search**: Find specific characters

### When to Use
- Character-by-character processing
- Creating animations (typing effect)
- Character validation
- Custom string operations


---

## 25. String IsNullOrEmpty Function

### Theory
`string.IsNullOrEmpty()` checks both null and empty in one call. More efficient and safer than checking separately.

**Key Points:**
- Checks both `null` and empty `""`
- Returns true if either condition met
- One call instead of two checks
- Best practice for validation

### Null vs Empty
- **Null**: No memory allocated, no object
- **Empty**: Object exists but contains no characters

### Why Use IsNullOrEmpty
- **Safety**: Prevents null reference errors
- **Convenience**: One check instead of two
- **Readability**: Clear intention

### When to Use
- All string validation
- User input checking
- Data validation

---

## 26. Arrays []

### Theory
Arrays store multiple values of the same type in a single variable. Fixed size, zero-indexed, and accessed by position.

**Key Points:**
- Fixed size (cannot change after creation)
- Zero-indexed (starts at 0)
- Same data type for all elements
- `.Length` property gives size
- Stored contiguously in memory

### Why Use Arrays
- **Organization**: Group related data
- **Efficiency**: Better than individual variables
- **Iteration**: Easy to process with loops
- **Memory**: Efficient storage

### When to Use
- Known size collection
- Fixed number of elements
- Performance is critical
- Simple list of items

### When NOT to Use
- Unknown size (use List)
- Frequent add/remove (use List)
- Different data types (use object array or List<object>)

---

## 27. Array Sorting

### Theory
`Array.Sort()` arranges array elements in ascending order. Modifies the original array in-place.

**Key Points:**
- Sorts array in ascending order
- Modifies original array (not a copy)
- Works with numbers, strings, chars
- O(n log n) time complexity
- Static method from Array class

### Why Sort Arrays
- **Organization**: Easier to read/find items
- **Search**: Binary search requires sorted data
- **Display**: Show items in order

### When to Use
- Displaying ordered data
- Preparing for binary search
- Finding min/max values
- Data analysis

---

## 28. Array Reverse

### Theory
`Array.Reverse()` reverses the order of elements in an array. Modifies the original array.

**Key Points:**
- Reverses element order
- Modifies original array
- Works with any type
- Can reverse partial array
- O(n) time complexity

### Why Reverse Arrays
- **Display**: Show in descending order
- **Processing**: Reverse order iteration
- **Algorithms**: Stack, queue operations

### When to Use
- Descending order display
- LIFO processing (Last In First Out)
- Reverse chronological order

---

## 29. Array Clear

### Theory
`Array.Clear()` sets array elements to their default values (0 for numbers, null for objects, false for booleans).

**Key Points:**
- Sets elements to default value
- Doesn't delete array or change size
- Specify start index and count
- 0 for numeric types
- null for reference types

### Why Clear Arrays
- **Reset**: Start fresh without recreating
- **Memory**: Free object references
- **Security**: Clear sensitive data

### When to Use
- Resetting array contents
- Clearing sensitive data (passwords)
- Preparing array for reuse


---

## 30. Array IndexOf

### Theory
`Array.IndexOf()` finds the first occurrence of a value and returns its index. Returns -1 if not found.

**Key Points:**
- Returns index of first match
- Returns -1 if not found
- Can specify start position
- Can specify search range
- Case-sensitive for strings

### Why Search Arrays
- **Validation**: Check if item exists
- **Location**: Find position for removal/update
- **Availability**: Check inventory/stock

### When to Use
- Finding item position
- Checking if item exists
- Locating data for update
- Inventory checks

---

## 31. Lists <>

### Theory
`List<T>` is a dynamic array that can grow and shrink. More flexible than arrays but slightly less performant.

**Key Points:**
- Dynamic size (grows/shrinks automatically)
- Generic type `<T>` (specify data type)
- `.Add()` - add element
- `.Remove()` - remove element
- `.Count` - number of elements
- Many built-in methods

### List vs Array
| Feature | Array | List |
|---------|-------|------|
| Size | Fixed | Dynamic |
| Performance | Faster | Slightly slower |
| Methods | Limited | Many built-in |
| Memory | Pre-allocated | Grows as needed |

### Why Use Lists
- **Flexibility**: Size changes automatically
- **Methods**: Built-in operations
- **Common**: Most common collection type

### When to Use
- Unknown number of elements
- Frequent add/remove operations
- Need built-in methods
- Most scenarios (Lists are default choice)

---

## 32. Dictionary<TKey, TValue>

### Theory
Dictionary stores key-value pairs. Fast lookup by key (like a real dictionary: word→definition).

**Key Points:**
- Stores pairs: key → value
- Keys must be unique
- Fast lookup O(1)
- Unordered collection
- `.Add()`, `.Remove()`, `.ContainsKey()`

### Why Use Dictionary
- **Fast Lookup**: Find value by key instantly
- **Association**: Connect related data
- **Unique Keys**: Prevent duplicates

### When to Use
- Mapping relationships (student ID → name)
- Configuration settings (key → value)
- Caching (key → cached data)
- Phone book (name → number)

### Real-World Examples
- User sessions (sessionID → user data)
- Product catalog (productID → product)
- Settings (settingName → value)
- Translation (english → hindi)

---

## 33. Functions (Methods)

### Theory
Functions (methods) are reusable blocks of code that perform specific tasks. They help organize code, reduce repetition, and improve maintainability.

**Key Points:**
- Reusable code blocks
- Can take parameters (input)
- Can return values (output)
- Improves code organization
- Makes testing easier

### Why Use Functions
- **Reusability**: Write once, use many times
- **Organization**: Break complex tasks into smaller pieces
- **Maintainability**: Fix bugs in one place
- **Readability**: Named functions explain what code does
- **Testing**: Test individual functions

### When to Use
- Code used multiple times
- Complex operations that need names
- Breaking down large problems
- Making code modular

---

## 34. Void Functions

### Theory
`void` functions perform actions but don't return any value. They execute code and finish.

**Key Points:**
- `void` means no return value
- Performs action, returns nothing
- Use when no output needed
- Common for display, printing, logging

### Why Use Void Functions
- **Side Effects**: Change state, display output
- **Organization**: Group related actions
- **Clarity**: Function name describes action

### When to Use
- Displaying information
- Modifying global state
- Logging operations
- Actions without results

---

## 35. Return Type Functions

### Theory
Functions can return values using return types. The return type specifies what type of data the function gives back.

**Key Points:**
- Return type before function name
- Must return value of specified type
- `return` keyword sends value back
- Can return any type (int, string, array, object)
- Calling code receives the returned value

### Why Return Values
- **Calculation Results**: Return computed values
- **Data Retrieval**: Get data from functions
- **Composition**: Use output as input for other functions
- **Flexibility**: Caller decides what to do with result

### When to Use
- Calculations (return result)
- Data retrieval (return data)
- Validation (return bool)
- Processing (return transformed data)


---

## 36. Function Parameters

### Theory
Parameters (arguments) allow passing data into functions. Functions can accept multiple parameters of different types.

**Key Points:**
- Define what data function needs
- Can have multiple parameters
- Parameters are local to function
- Must match types when calling
- Order matters

### Why Use Parameters
- **Flexibility**: Same function, different data
- **Reusability**: Function works with any values
- **Abstraction**: Caller provides data

### When to Use
- Function needs external data
- Different inputs produce different outputs
- Making functions reusable


---

## 37. Optional Parameters

### Theory
Optional parameters have default values and can be omitted when calling functions.

**Key Points:**
- Must have default value
- Must be at end of parameter list
- Caller can omit them
- Uses `= value` syntax
- `default` keyword for type's default value

### Why Use Optional Parameters
- **Flexibility**: Parameters that aren't always needed
- **Convenience**: Fewer overloads needed
- **Defaults**: Common values built-in

### When to Use
- Parameters rarely change
- Backward compatibility
- Reducing function overloads

---

## 38. Named Parameters

### Theory
Named parameters specify parameter names when calling functions. Allows passing arguments in any order.

**Key Points:**
- Specify parameter name: `name: value`
- Can pass in any order
- Improves readability
- Mix with positional parameters
- All named must come after positional

### Why Use Named Parameters
- **Clarity**: Clear what each value represents
- **Order**: Don't need to remember parameter order
- **Optional Parameters**: Skip middle parameters

### When to Use
- Many parameters
- Parameters with similar types
- Calling with optional parameters
- Improving readability

---

## 39. Out Parameters

### Theory
`out` parameters return multiple values from a function. The function must assign a value before returning.

**Key Points:**
- Function must assign value
- Caller doesn't need to initialize
- Can return multiple values
- Common in Try* methods
- Must use `out` keyword in both definition and call

### Why Use Out Parameters
- **Multiple Returns**: Return more than one value
- **Pattern**: Try* pattern (TryParse)
- **Status + Value**: Return success/failure plus result

### When to Use
- Need to return multiple values
- Try* pattern (operation + success status)
- Avoiding exceptions


---

## 40. Reference Parameters (ref)

### Theory
`ref` parameters pass variables by reference, allowing functions to modify the original variable.

**Key Points:**
- Must initialize before passing
- Function can modify original
- Changes affect original variable
- Must use `ref` in both definition and call
- Two-way communication

### ref vs out
| Feature | ref | out |
|---------|-----|-----|
| Initialize before | Yes | No |
| Assign in function | Optional | Required |
| Use case | Modify existing | Return values |

### Why Use ref
- **Modify Original**: Change caller's variable
- **Performance**: Avoid copying large objects
- **In-out**: Read and write same variable

### When to Use
- Modifying caller's variable
- Large struct parameters (avoid copying)
- Swap operations


---

## 41. Exception Handling (Try-Catch)

### Theory
Exceptions are runtime errors that stop normal program flow. Try-catch blocks handle errors gracefully instead of crashing.

**Key Points:**
- `try` - code that might fail
- `catch` - handle specific errors
- Multiple catch blocks for different errors
- `Exception` catches all errors
- Specific exceptions should come before general

### Why Handle Exceptions
- **Stability**: Program doesn't crash
- **User Experience**: Show friendly error messages
- **Recovery**: Try alternative approaches
- **Logging**: Record errors for debugging

### Common Exceptions
- `FormatException` - invalid format conversion
- `OverflowException` - number too large/small
- `NullReferenceException` - accessing null object
- `IndexOutOfRangeException` - invalid array index
- `DivideByZeroException` - division by zero

### When to Use
- User input conversion
- File operations
- Network operations
- Database access
- Any operation that might fail


---

## 42. Object-Oriented Programming - Structures

### Theory
Structures (`struct`) are value types that group related data. Lightweight alternative to classes for simple data containers.

**Key Points:**
- Value type (stored on stack)
- Can have fields, properties, methods, constructors
- Cannot inherit from other structs
- Copied by value (not reference)
- Cannot have parameterless constructor
- Good for small data structures

### struct vs class
| Feature | struct | class |
|---------|--------|-------|
| Type | Value | Reference |
| Storage | Stack | Heap |
| Inheritance | No | Yes |
| Default constructor | Can't remove | Can have |
| Null | Can't be null | Can be null |

### When to Use struct
- Small data structures (Point, Color, Date)
- Immutable data
- Performance critical code
- Logically represents single value

### When to Use class
- Large objects
- Need inheritance
- Need reference semantics
- Most scenarios

---

## 43. Object-Oriented Programming - Classes

### Theory
Classes are blueprints for creating objects. They encapsulate data (fields) and behavior (methods) into a single unit.

**Key Points:**
- Reference type (stored on heap)
- Can have multiple constructors
- Supports inheritance
- Can be null
- Most common way to organize code in C#

### Why Use Classes
- **Encapsulation**: Group related data and behavior
- **Reusability**: Create multiple objects from one class
- **Inheritance**: Build on existing classes
- **Organization**: Structure complex programs

### Class Components
- **Fields**: Data storage
- **Properties**: Controlled access to data
- **Constructors**: Initialize objects
- **Methods**: Define behavior
- **Events**: Notification system

---

## 44. Class Methods

### Theory
Methods define what objects can do. They are functions that belong to a class and operate on class data.

**Key Points:**
- Define object behavior
- Can access class fields and properties
- Can be public, private, protected
- `this` keyword refers to current object
- Can be static or instance methods

### Why Use Methods
- **Encapsulation**: Keep behavior with related data
- **Organization**: Actions belong to objects
- **Abstraction**: Hide implementation details


---

## 45. Class Fields (Encapsulation)

### Theory
Encapsulation hides internal data and provides controlled access through getter/setter methods. Protects data integrity.

**Key Points:**
- `private` fields - hidden from outside
- Getter methods - retrieve values
- Setter methods - modify values with validation
- Protects data integrity
- Fundamental OOP principle

### Why Encapsulate
- **Data Protection**: Prevent invalid values
- **Validation**: Check values before setting
- **Flexibility**: Change internal implementation
- **Debugging**: Control when data changes


---

## 46. Class Properties

### Theory
Properties are modern way to implement getters/setters. They look like fields but have get/set logic behind them.

**Key Points:**
- Cleaner than Get/Set methods
- `get` accessor retrieves value
- `set` accessor assigns value (`value` keyword)
- Auto-implemented properties (no backing field needed)
- Can have different access levels (public get, private set)

### Why Use Properties
- **Cleaner Syntax**: Looks like field access
- **Validation**: Control how values are set
- **Flexibility**: Can add logic later
- **Modern C#**: Standard practice

### Property Types
- **Auto-implemented**: `{ get; set; }`
- **With backing field**: Custom get/set logic
- **Read-only**: Only `{ get; }`
- **Write-only**: Only `{ set; }` (rare)


---

## 47. ToString() Override

### Theory
`ToString()` method converts objects to string representation. Every class inherits it from `Object` class and can override it.

**Key Points:**
- Inherited from `Object` class
- Default returns class name
- Override to provide meaningful string
- Called automatically by `Console.WriteLine()`
- `override` keyword required

### Why Override ToString
- **Debugging**: See object contents easily
- **Display**: Show object in readable format
- **Logging**: Better log messages







## Good luck with learning C# basics! 🚀

---

