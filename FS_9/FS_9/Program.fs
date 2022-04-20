open System.Windows.Forms
open System.Windows.Markup
open System


let main = new Form(Text = "Parent form" ,Width = 480, Height = 360)

let button5 = new Button(Dock = DockStyle.Top, Text = "Seasons (lw_5)")
let openForm5 _ = lw_5.form.ShowDialog() |> ignore
button5.Click.Add(openForm5)

let button6 = new Button(Dock = DockStyle.Top, Text = "Seasons (lw_6)")
let openForm6 _ = lw_6.openWin|> ignore
button6.Click.Add(openForm6)

let button7 = new Button(Dock = DockStyle.Top, Text = "Check Boxes (lw_7)")
let openForm7 _ =  lw_7.form.ShowDialog() |> ignore
button7.Click.Add(openForm7)

main.Controls.Add(button7)
main.Controls.Add(button6)
main.Controls.Add(button5)

do Application.Run(main)

