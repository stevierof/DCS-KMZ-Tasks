using SB = SandBox.KML.Models;
using Tasks = SandBox.KML.Tasks;

SB.TaskBuilder builder = new SB.TaskBuilder();

builder.AddTask(new Tasks.ActiveTarget("STRIKE Shayrat Runway", new SB.Coordinates {
    Latitude = 34.4918046,
    Longitude = 36.9115455
}));

builder.AddTask(new Tasks.ActiveTarget("SEAD Shayrat Airfield", new SB.Coordinates
{
    Latitude = 34.4918046,
    Longitude = 36.9115455
}));

builder.AddTask(new Tasks.PrimaryTarget("Factory", new SB.Coordinates
{
    Latitude = 33.4918046,
    Longitude = 35.9115455
}));



builder.SaveKMZ("test");
Console.WriteLine("Done");