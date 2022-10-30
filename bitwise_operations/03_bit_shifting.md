# Bit Shifting

```
<< left shift
>> right shift

00011 << 3 = 11000
00001 >> 1 = 00000

1 << 5 = 32;
5 << 3 = 5 * 8 = 40;
```

```
// Dynamic Programming Solution
public string ConvertToBinary(int i, string s = "")
{
    if (i < 1)
        return s;

    if (i % 2 == 0)
        s = "0" + s;
    else
        s = "1" + s;

    return ConvertToBinary(i / 2, s);
}
```

## Bit Packing

Bit shifting is useful for `Bit Packing` which allows us to send less data over network protocols.

```
A = 1001111 (7)
B = 10110 (5)
C = 0011 (4)
7+5+4 = 16 (int16)

X = 0000000,00000,0000 (16)
  = A,B,C

A << 9 (16-7=9)
X = X | A

B << 4 (16 -7(A) -5 = 4)
X = X | B
X = X | C
```

NOTE: Generally we will work with int values not strings. So for example when we have an int between 0-255 we know their significant bits are maximum length 8. We will use this and pack our int values.

```C#
public void BitPackingExample1()
{
    string A = "110111";
    string B = "10001";
    string C = "1101";
    int aBits = Convert.ToInt32(A, 2);
    int bBits = Convert.ToInt32(B, 2);
    int cBits = Convert.ToInt32(C, 2);
    int packed = 0;
    packed = packed | aBits << 26 | bBits << 21 | cBits << 17;
    Console.WriteLine(Convert.ToString(packed, 2).PadLeft(32, '0'));
}

public void BitPackingExample2()
{
    string A = "1111";
    string B = "101";
    string C = "11011";
    int aBits = Convert.ToInt32(A, 2);
    int bBits = Convert.ToInt32(B, 2);
    int cBits = Convert.ToInt32(C, 2);
    int packed = 0;
    // 32-4 = 28
    // 32-4-3=25
    // 32-7-5=20
    packed = packed | aBits << 28 | bBits << 25 | cBits << 20;
    Console.WriteLine(Convert.ToString(packed, 2).PadLeft(32, '0'));

    //string result = "11111011101100000000000000000000";
}
```

## Bit Unpacking

```
A = 0011001
B = 11000
C = 0101

Mask = 1111111000000000 (7x1, 9x0)
X & Mask = 0011001000000000

A = (X & MaskA) >> 9
B = (X & MaskB) >> 4
C = (X & MaskC)
```

