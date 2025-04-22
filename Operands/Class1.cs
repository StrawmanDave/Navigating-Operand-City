namespace Operands;

public class Class1
{

}

public record BlockCorrdinate(int Row, int Column)
{
    public static BlockCorrdinate operator +(BlockCorrdinate orignalCord, BlockOffset offset)
    {
        return new BlockCorrdinate(orignalCord.Row + offset.RowOffset, orignalCord.Column + offset.ColumnOffset);
    }

    public static BlockCorrdinate operator +(BlockCorrdinate starting, Direction direction)
    {
        switch (direction)
        {
            case Direction.North:
            return new BlockCorrdinate(starting.Row -1, starting.Column);
            case Direction.South:
            return new BlockCorrdinate(starting.Row + 1, starting.Column);
            case Direction.East:
            return new BlockCorrdinate(starting.Row, starting.Column + 1);
            case Direction.West:
            return new BlockCorrdinate(starting.Row, starting.Column - 1);
        }
        return starting; // for safe guard if no direction is added also just so the code works and doesn't yell at me.
    }
}
public record BlockOffset(int RowOffset, int ColumnOffset);

public enum Direction {North, East, South, West}