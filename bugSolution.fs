let x = ref 10
let y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y // This will print 20 10

//Alternative solution using tuples
let swap (x,y) = (y,x)
let x1 = 10
let y1 = 20
let x2, y2 = swap (x1, y1)
printf "%d %d" x2 y2