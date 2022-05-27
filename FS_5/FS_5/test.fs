module test

//21
let findMax list = 
    let rec loop list curMax  = 
        match list with
        |head::tail ->
            let nextCurMax = if head > curMax then head else curMax
            loop tail nextCurMax
        |[] -> curMax
    if list <> [] then  loop list list.Head else 0

let findItems list =
    let rec loop list resultList maxItem flag=
        match list with
        |head::tail ->
            let flag1 = if head = maxItem then 1 else flag
            let nextResultList = if flag = 1 then resultList @ [head] else resultList
            loop tail nextResultList maxItem flag1
        |[] -> resultList
    loop list [] (findMax list) 0

//23
let findMin list = 
    let rec loop list curMax  = 
        match list with
        |head::tail ->
            let nextCurMax = if head < curMax then head else curMax
            loop tail nextCurMax
        |[] -> curMax
    loop list list.Head

let findTwoMins list = 
    let rec loop list firstMin secondMin =
        match list with
        |head::tail ->             
            let nextSecondMin = if head = firstMin then (if tail <> [] then findMin tail else secondMin)  else secondMin
            let nextTail = if head = firstMin then [] else tail
            loop nextTail firstMin nextSecondMin
        |[] -> (firstMin,secondMin)
    loop list (findMin list) list.Head

//33
let areAlternated list =
    let rec loop list flag=
        match list with
        |head::tail ->
            let nextFlag = if tail <> [] then (if head * tail.Head >= 0 then false else flag) else flag
            loop tail nextFlag
        |[] -> flag
    loop list true

//36
let findMaxOdd list = 
    let rec loop list curMax  = 
        match list with
        |head::tail ->
            let nextCurMax = if head > curMax && head %  2 = 1 then head else curMax
            loop tail nextCurMax
        |[] -> curMax
    if list <> [] then  loop list list.Head else 0

//39
let rec printList list =
    match list with
    |head::tail ->
        printf "%A  " head
        printList tail
    |[] -> ()

let printEvensOdds (list:List<int>) =
    let rec getEvens list evens index= 
        match list with
        |head::tail ->
            let nextEvens = if index % 2 = 0 then evens @ [head] else evens
            getEvens tail nextEvens (index + 1)
        |[] -> evens 
    let evens = getEvens list [] 0

    let rec getOdds list evens index= 
        match list with
        |head::tail ->
            let nextEvens = if index % 2 = 1 then evens @ [head] else evens
            getOdds tail nextEvens (index + 1)
        |[] -> evens 
    let odds = getOdds list [] 0

    printList evens
    printfn ""
    printList odds
  
  //45
let sumBetween list a b =
    let rec loop list a b sum = 
        match list with
        |head::tail ->
            let nextSum = sum + (if head > a && head < b then head else 0)
            loop tail a b nextSum
        |[] -> sum
    loop list a b 0

//57
let countItemsGreaterThanSumOfPrevious (list:List<int>) =
    let rec loop list sum count =
        match list with
        |head::tail ->
            let nextCount = count + if head > sum then 1 else 0
            let nextSum = sum + head
            loop tail nextSum nextCount
        |[] -> count
    loop list.Tail list.Head 0

let Demo = 
    printfn "%A" (countItemsGreaterThanSumOfPrevious [1;2;4;8;16;32;64;128;256])
    0