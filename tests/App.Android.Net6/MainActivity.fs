namespace App.Android.Net6

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

[<Activity (Label = "App.Android.Net6", MainLauncher = true, Icon = "@mipmap/icon")>]
type MainActivity () =
    inherit Activity ()

    let mutable count:int = 1

    do Resource.UpdateIdValues()

    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        // Set our view from the "main" layout resource
        this.SetContentView (Resource.Layout.Main)

        // Get our button from the layout resource, and attach an event to it
        let button = this.FindViewById<Button>(Resource.Id.myButton)
        button.Click.Add (fun args -> 
            button.Text <- $"%d{count} clicks! NET6"
            count <- count + 1
        )

