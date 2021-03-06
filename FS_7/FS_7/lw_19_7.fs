module lw_19_7

let filterUppercase str = str |> String.filter (fun i -> i >= 'A' && i <= 'Z')
   
let isPalindrome (str:string) =
    let charArray = str.ToCharArray() 
    printfn "%A" charArray
    let reversedCharArray = Array.rev charArray  
    printfn "%A" reversedCharArray
    ((charArray , reversedCharArray) ||> Array.fold2 (fun is c r -> if c = r then is + 0 else is + 1) 0) = 0
    

let ForDemo19_7 = 
    printfn "%A" (isPalindrome (filterUppercase "HagdAfdgdfHgdfg")) //HAH true