# Navigating-Operand-City
This is for the challenge Navigation Operand City in the C# Players guid fifth edition.

public record BlockCorrdinate(int Row, int Column);
public record BlockOffset(int RowOffset, int ColumnOffset);
public enum Direction {North, East, South, West}

BlockCoordinate refers to a specific block's location, BlockOffset is for relative distances between blocks, and Direction specifies directions. Rows start at zero and get bigger as you go south. Columns start at zero and get bigger as you go east.

Objectives
Use the code above as a starting point.
Add an addition (+) operator to BlockCoordinate that takes BlockCoordinate and a BlockOffset as arguments and produces a new BlockCoordinate that refers to the one
you would arrive at by starting at the origninal coordinate and moving by the offset. That is, if we starteed at (4,3) and had an offset of(2,0) we would end up at (6,3).
Add another addtion (+) operator to BlockCoordinate that takes a BlockCoordinate and a Direction as arguments and produces a new BlockCoordinate that is a block in the direction indicated. If we started at (4,3) and went east, we should end up at (4,4).
Write code to ensure that both operators work correctly. 