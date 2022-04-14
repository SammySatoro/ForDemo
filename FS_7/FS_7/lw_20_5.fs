module lw_20_5

let ratingOfLetters = [|("a", 8.17); ("b", 1.49); ("c", 2.78); ("d", 4.25); ("e", 12.68); ("f", 2.23); 
                        ("g", 2.02); ("h", 6.09); ("i", 6.97); ("j", 0.15); ("k", 0.77); ("l", 4.03); ("m", 2.41); ("n", 6.75); 
                        ("o", 7.51); ("p", 1.93); ("q", 0.1); ("r", 5.99);("s", 6.33); ("t", 9.06); ("u", 2.76); ("v", 0.98); 
                        ("w", 2.36); ("x", 0.15); ("y", 1.97); ("z", 0.07)|]  

let lines = [|"qwedgdhfg hh fgh fdjhdfhfh fa";
            "gdfgfs fadgdfg dshg fghf hf";
            "hfghsfghfghh fghsfh fsghfgh";
            "hfgshfjf jgdhjgj gdhj hgjj "|]
   
let quantifyTheMostFrequent (linesArray:array<string>) =
    let arraysWithoutSpaces = linesArray |> Array.map (fun line -> String.filter (fun c -> c <> ' ') line)
    let numbersOfChars = arraysWithoutSpaces |> Array.map (fun (line:string) -> line.Length)
    let arrayOfArraysOfChars = arraysWithoutSpaces |> Array.map (fun line -> line.ToCharArray())
    let arratOfArraysOfRates = arrayOfArraysOfChars |> Array.map (fun line -> line |> Array.countBy (fun i -> i) |> Array.sortByDescending snd)
    let pairsOfMostRated = arratOfArraysOfRates |> Array.map (fun arr -> arr.[0])
    pairsOfMostRated, numbersOfChars

let quantifyEntryPercentage (pairs:array<char * int>) (entryNumbers:array<int>) =
    let freqs = (pairs, entryNumbers) ||> Array.map2 (fun (pair:char * int) number -> (fst pair ,((float)(snd pair) / (float)number) * 100.0))
    freqs
 

let ForDemo =
    printfn "%A" (quantifyTheMostFrequent lines)
    printfn "%A" (quantifyEntryPercentage (fst (quantifyTheMostFrequent lines)) (snd (quantifyTheMostFrequent lines)))