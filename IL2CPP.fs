namespace MyFSharpMod

open MelonLoader

[<assembly: MelonInfo(typeof<MyMod>, "MyFSharpMod", "1.0.0", "unreliablecode", "Description of your mod.")>]
[<assembly: MelonGame("GameName", "DeveloperName")>]

type MyMod() =
    inherit MelonMod()

    override _.OnApplicationStart () =
        UnityEngine.Debug.Log("My F# Mod: ApplicationStart")

    override _.OnUpdate () =
        UnityEngine.Debug.Log("My F# Mod: Update")
