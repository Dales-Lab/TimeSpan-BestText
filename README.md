# TimeSpan-BestText
![Master Build](https://github.com/Dales-Lab/TimeSpan-BestText/workflows/Master%20Build/badge.svg) [![codecov](https://codecov.io/gh/Dales-Lab/TimeSpan-BestText/branch/master/graph/badge.svg)](https://codecov.io/gh/Dales-Lab/TimeSpan-BestText) [![nuget](https://img.shields.io/nuget/v/Timespan.BestText)](https://www.nuget.org/packages/Timespan.BestText/)

Simple extension designed to provide you the best text output for a given TimeSpan in either milliseconds, seconds, minutes, hours or days.

## Usage
```
using DalesLab.Timespan.BestText;

...
TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddSeconds(-30));

return testSpan.BestText() // "30 seconds"
```
