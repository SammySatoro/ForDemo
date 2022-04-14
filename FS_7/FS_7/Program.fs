let foo2 list pred func =
    let rec loop list pred func modList = 
        match list with
        |head::tail ->
            let nextModList = modList @ [(func head)]
            if pred head then loop tail pred func nextModList
            else loop tail pred func modList  
        |[] -> modList
    loop list pred func []

let culcNum n =
    let rec loop n sum = 
        match n with
        |n when n <> 0 ->
            let nextSum = sum + (n % 10)
            let nextN = n / 10
            loop nextN nextSum
        |n -> sum
    loop n 0


let foo3 list = 
    let rec loop list modList =
        match list with 
        |head::tail -> 
            let rec subLoop value count subList =
                if count <= 0 then subList
                else 
                    let nextSubList = subList @ [value]
                    let nextCount = count - 1
                    subLoop value nextCount nextSubList
            let nextModList = modList @ subLoop (fst head) (snd head) []            
            loop tail nextModList
        |[] -> modList
    loop ((list |> List.countBy id) |> List.sortByDescending snd) []


let foo12 list = 
    let rec loop list product = 
        match list with
        |head::tail ->
            let nextProduct = product * head
            if head % 2 = 0 then loop tail nextProduct
            else loop tail product
        |[] -> product
    loop list 1

let foo22 n pred acc =
    let rec loop n pred acc =
        match n with
        |n when n<>0 ->
            let nextAcc = [n % 10] @ acc  
            let nextN = n / 10
            if pred (n % 10) then loop nextN pred nextAcc
            else loop nextN pred acc
        |n -> acc
    loop n pred acc
        

[<EntryPoint>]
let main argv =
    //printfn "%A" (foo2 [123;-234;345;-4;567] (fun x -> x > 0) culcNum)
    //printfn "%A" (foo12 (foo22 123456 (fun x -> x % 2 = 0) []))
    //printfn "%A" (foo22 123456 (fun x -> x % 2 = 0) [])

    //lw_11_5.ForDemo11

    //lw_12_15.ForDemo12 

    //lw_13_25.ForDemo13

    //lw_14_35.ForDemo14

    //lw_15_45.ForDemo15

    //lw_16_55.ForDemo16

    //lw_17_5.ForDemo17

    //lw_18_5.ForDemo18

    //lw_19_5.ForDemo19_5
    //lw_19_7.ForDemo19_7
    //lw_19_14.ForDemo19_14
    //lw_19.ForDemo19
    
    lw_20_5.ForDemo
    0