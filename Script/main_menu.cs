using Godot;
using System;

public partial class main_menu : Control
{
    private void _on_start_pressed()
    {
        
        GD.Print("Start button");
        GetTree().ChangeSceneToFile("res://Entities/main_game.tscn");
    }
    private void _on_exit_pressed()
    {
        
        GD.Print("Exit button");
        GetTree().Quit();
    }
}
