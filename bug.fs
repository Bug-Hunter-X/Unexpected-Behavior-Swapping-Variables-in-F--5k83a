let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // This will print 20 10

//However, if x and y are not mutable
let x = 10
let y = 20

let swap x y = 
    let temp = x
    //x <- y //Error: This will not work
    //y <- temp //Error: This will not work

let x1,y1 = swap x y //This will print the original values, 10 and 20. The swap does not modify the values, only the local copies. 
printf "%d %d" x1 y1