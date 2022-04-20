open System.Windows.Forms

let mainForm = 
    let main = new Form(Text = "Parent form" ,Width = 480, Height = 360)
    let button5 = new Button(Dock = DockStyle.Top, Text = "lw_5")

    let openForm5  =  lw_5.form.ShowDialog() |> ignore

    button5.Click.Add(fun e -> openForm5)


    main.Controls.Add(button5)

    do Application.Run(main)

