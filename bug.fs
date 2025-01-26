let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // This will print 20 20, not 20 10 as expected in other languages like C++ or Java

//Another example
let list1 = [1;2;3;4;5]
let list2 = [6;7;8;9;10]
let mutable templist = []

let combine list1 list2 =
    templist <- list1 @ list2

combine list1 list2
printf "%A" templist //This may give unexpected results depending on the context of how templist is used.