# TimeSpan-BestText

Simple extension designed to provide you the best output for a given TimeSpan. This is something we mostly use in logging and was a highly repeditive action.

## Usage
```
using DalesLab.Timespan.BestText;

...
TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddSeconds(-30));

return testSpan.BestText() // "30 seconds"
```
