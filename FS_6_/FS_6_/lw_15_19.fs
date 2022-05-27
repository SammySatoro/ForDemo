module lw_15_19

let len list = 
    let rec loop list length =
        match list with
        |head::tail ->
            let nextLength = length + 1
            loop tail nextLength
        |[] -> length
    loop list 0
    
let reverseList list = 
    let rec loop list revList = 
        match list with
        |head::tail ->
            let nextRevList = head::revList
            loop tail nextRevList
        |[] -> revList
    loop list []

let shiftNRight list n = 
    let rec loop list n shiftedList (reversedList:list<int>) len =
        match list with 
        |head::tail ->
            let nextList = if len > n then (shiftedList @ [head]) else reversedList.Head::shiftedList
            let nextRevList = if len > n then reversedList else reversedList.Tail
            let nextLen = len - 1
            loop tail n nextList nextRevList nextLen
        |[] -> shiftedList
    let rl = reverseList list
    loop list n [] rl (len list)
           
let ForDemo15_19 = 
    let list = [0;1;2;3]
    printfn "%A" (shiftNRight list 2)