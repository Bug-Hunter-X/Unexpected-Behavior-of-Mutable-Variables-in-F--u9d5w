let x = ref 10
let y = ref 20

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y // This will print 20 10

//Another example
let list1 = [1;2;3;4;5]
let list2 = [6;7;8;9;10]

let combine list1 list2 =
    list1 @ list2

let combinedList = combine list1 list2
printf "%A" combinedList //This gives the correct result