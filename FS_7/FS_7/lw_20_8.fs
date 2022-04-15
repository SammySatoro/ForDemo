module lw_20_8

let rateInAlp = [|8.17; 1.49; 2.78; 4.25; 12.7; 2.23; 2.02; 6.09; 6.97; 0.15; 0.77; 4.03; 2.41;                                           
                          6.75; 7.51; 1.93; 0.1; 5.99; 6.33; 9.06; 2.76; 0.98; 2.36; 0.15; 1.97; 0.07|] 

let lines = [|"    ";
                   "zzz"|]

let rateOfMostRatedLetter = 
    (((String.filter (fun c -> c = 'a') "abcd").Length |> System.Convert.ToDouble)  / ( "abcd".Length |> System.Convert.ToDouble)) * 100.0

let rateInAlpOfMostRatedLetter = 
    if (System.Char.IsLower 'A') 
    then rateInAlp.[(System.Convert.ToInt32('A') - 97)]
    else rateInAlp.[(System.Convert.ToInt32('A') - 65)]

let ForDemo20_8 =
    printfn "%A" (rateInAlp)



//В порядке увеличения квадратического отклонения
//(частоты встречаемости самого часто всречаемого в строке символа) – mostRatedInString
//от (частоты его встречаемости в текстах на этом алфавите) – rateInAlphabet
