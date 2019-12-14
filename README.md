# TypeCsv

Windows console program to displays a CSV with each column in a different color.
```
    typecsv <filepath>
```
Displays the file specified in filepath. If no file is specified then input is read from the console. This allows you to pipe the output of other commands into this command.

Example
```
    type log.csv | typecsv
```
Here is an example of the output:

![example](docs/img/example.png)

The example data is from the [Protein Secondary Structure](https://www.kaggle.com/alfrandom/protein-secondary-structure) public database on [Kaggle](https://www.kaggle.com/). 

The colors are based on the [Rainbow CSV VSCode Extension](https://marketplace.visualstudio.com/items?itemName=mechatroner.rainbow-csv).

## Download

You can down the latest version of the TypeCsv.exe program from [the releases tab](https://github.com/patleahy/TypeCsv/releases).

[![Build status](https://ci.appveyor.com/api/projects/status/3mun20ox0o01p1iu?svg=true)](https://ci.appveyor.com/project/patleahy/typecsv)
[![MIT License](https://badgen.net/github/license/patleahy/typecsv)](https://github.com/patleahy/TypeCsv/blob/master/LICENSE.md)
