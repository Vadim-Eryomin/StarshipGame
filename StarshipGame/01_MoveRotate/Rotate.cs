namespace StarshipGame;

public class RotateCommand : ICommand
{
    private IRotatable Obj;

    public RotateCommand(IRotatable obj)
    {
        this.Obj = obj;
    }

    public void Execute()
    {
        Obj.Angle += Obj.AngleVelocity;
        Obj.Angle = (Obj.Angle) % 360;
    }
}