# F# Mutable Variable Swap Bug
This example demonstrates a common issue when working with mutable variables and function parameters in F#.  The initial code attempts to swap two mutable variables using a function.  However, the corrected version uses `ref` cells to achieve the desired swapping behavior with immutable variables. 

**Key Concepts:**
* Mutable vs. Immutable Variables
* Reference Cells (`ref`)
* Function Parameters and Scope