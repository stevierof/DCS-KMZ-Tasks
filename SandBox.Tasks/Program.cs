#pragma warning disable CS8602

using SandBox.Tasks;
using SandBox.Tasks.Data;

using SB = SandBox.KMZ.Models;
using Tasks = SandBox.KMZ.Tasks;


Factory factory = new Factory(new SandBoxContext());
SB.TaskBuilder activeTaskBuilder = new SB.TaskBuilder("Tasks", "The following units have been detected by friendly flights and are now valid targets to attack.");
SB.TaskBuilder completedTaskBuilder = new SB.TaskBuilder("Completed Tasks", "These units have been destroyed succesfully after detection by allied recon.");

var config = new Config();

var reconnedUnits = await factory.ReconnedUnitService.Fetch(config.MissionId);
var destroyedUnits = factory.DestroyedUnitService.Fetch(config.MissionId);


foreach (var unit in reconnedUnits)
{
    var target = new Tasks.ActiveTarget(unit.Description ?? "Unknown unit", new SB.Coordinates
    {
        Latitude = double.Parse(unit.Latitude ?? "0"),
        Longitude = double.Parse(unit.Longitude ?? "0"),
        Altitude = double.Parse(unit.Altitude ?? "0")
    });

    // check if the target has been destroyed
    var destroyedUnit = destroyedUnits?.FirstOrDefault(x => x.UnitId == unit.UnitId);
    if (destroyedUnit != null)
    {
        target.SetCompleted();
        completedTaskBuilder.AddTask(target);
    } 
    else
    {
        activeTaskBuilder.AddTask(target);
    }

    
}

activeTaskBuilder.SaveKMZ(Path.Combine(config.SavePath, "ReconLayer"));
completedTaskBuilder.SaveKMZ(Path.Combine(config.SavePath, "CompletedTaskLayer"));

Console.WriteLine("Done");