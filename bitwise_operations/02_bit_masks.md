# Working with Bit Masking

Bit masking is the process of getting the processor to ignore all the bits that we don't want to work on and only process the digits we want to process.

attributes = 0011001, test for 0010000 (has Magic?)

```C#
// bool hasMagic = (this.Attributes & MAGIC) != 0;
bool hasMagic = (this.Attributes & MAGIC) == MAGIC;

if (hasMagic) {
    // allow through the door
}

1011 0101 Data
0011 0000 Mask (only set the digits you are interested in to 1, others 0)
--11 ---- Result
```
