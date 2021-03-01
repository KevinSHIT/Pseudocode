// ReSharper disable RedundantUsingDirective

using Kevin.Pseudocode;
using static Kevin.Pseudocode.Basic;
using static Kevin.Pseudocode.IO;
using static Kevin.Pseudocode.Env;
using static Kevin.Pseudocode.Array;
using static Kevin.Pseudocode.Type;

var j = 0;
FOR_LOOP_IN_RANGE(1, 10, (m) =>
{
    IF(m % 2 == 0,
        () => PRINTLINE("HELLO!"),
        () => PRINTLINE("WORLD!"));
});
PRINT(j);
int i = 10;
WHILE(() => i < 100, () =>
{
    i = i * 2;
    PRINTLN(i);
    PRINTLN(i < 100);
});
PRINT(true.TO_INT());
PRINTLINE("-----");
LET l = (LET) 1;
LET m = l + 22;
PRINT(l);