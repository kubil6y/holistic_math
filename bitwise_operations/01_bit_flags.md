# Working with Bit Flags

```c#
bool hasMagic = true;
bool hasIntelligence = false;
bool hasCharisma = true;
bool canFly = false;
bool isInvisible = false;

static public int MAGIC = 16;
static public int INTELLIGENCE = 8;
static public int CHARISMA = 4;
static public int FLY = 2;
static public int INVISIBLE = 1;

int attributes = 20;
int attributes = (MAGIC + CHARISMA); (MAGIC | CHARISMA) (16 + 4)
int attributes = MAGIC | CHARISMA;
```

IMPORTANT NOTES: 
    - Attributes need to be power of 2!
    - Adding a field multiple times only adds it once.

To Add Single:
attributes |= MAGIC

To Remove Single:
attributes &= ~MAGIC

To Add Multiple:
attributes |= (INTELLIGENCE | MAGIC | CHARISMA)

To Remove Multiple:
attributes &= ~(MAGIC | CHARISMA)

To Reset All Attributes:
attributes = 0

## Operator Examples

```
Bitwise Operators:
AND &
OR  |
XOR ^
NOT ~

1011 &
0011 =
0011

1000 |
1110 =
1110

1011 ^
1001 =
0010

1010 ^
1101 =
0111

~1010 =
 0101
```
