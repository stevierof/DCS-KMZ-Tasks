using SB = SandBox.KMZ.Models;
using Tasks = SandBox.KMZ.Tasks;

SB.TaskBuilder builder = new SB.TaskBuilder();

var exampleTask = new Tasks.ActiveTarget("STRIKE Shayrat Runway", new SB.Coordinates
{
    Latitude = 34.4918046,
    Longitude = 36.9115455
});


var exampleTaskCompleted = new Tasks.ActiveTarget("SEAD Shayrat Airfield", new SB.Coordinates
{
    Latitude = 34.4918046,
    Longitude = 36.9115455
});

exampleTaskCompleted.SetCompleted();


var exampleFactoryTask = new Tasks.PrimaryTarget("Factory", new SB.Coordinates
{
    Latitude = 33.4918046,
    Longitude = 35.9115455
});


builder.AddTask(exampleTask);
builder.AddTask(exampleTaskCompleted);
builder.AddTask(exampleFactoryTask);


builder.SaveKMZ("test");
Console.WriteLine("Done");