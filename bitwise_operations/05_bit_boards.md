# Bit Boards

[Bitboard methods for games](http://eprints.qut.edu.au/85005/1/__staffhome.qut.edu.au_staffgroupm$_meaton_Desktop_bits-7.pdf) 

[Bitboards in chess programming](https://www.chessprogramming.org/Bitboards)

-   Encode state more efficiently
-   Read & Write with Bitwise Operations
-   Bitwise Operations Act in Parallel

Imagine Board as 2 dimensional but as a single line long integer. 8x8 board = int64

```
index = row*width + column
number[row][column]
number[row*8 + column]

public long SetCellState(long bitboard, int row, int col)
{
    long newBit = 1L << (row * 8 + col);
    return (bitboard |= newBit);
}

public bool GetCellState(long bitboard, int row, int col)
{
    long mask = 1L << (row * 8 + col);
    return ((bitboard & mask) != 0);
}


public int CellCount(long bitboard)
{
    int count = 0;
    long bb = bitboard;
    while(bb != 0)
    {
        bb &= bb - 1;
        count++;
    }
    return 0;
}
```
