# switch-and-paste-to-matlab

A simple program written in C-Sharp to switch to the Matlab command window and paste a command into it. The command should be prealably put in the clipboard. 
This was implemented to be able to use [vim-matlab-behave](https://github.com/elmanuelito/vim-matlab-behave) on Windows.


## Binaries
The latest binary is available [here](https://github.com/elmanuelito/swith-and-paster-to-matlab/raw/master/SwitchAndPasteToMatlab.exe)

## Features/ usage
        
usage: wmctrl [WindowName] [PasteShortcut]

options:
  WindowName    : Name of Matlab window (default MATLAB. See wmctrl -l)
  PasteShortcut : Shortcut to paste (default Ctrl-V)


## Compilation
Compile (using Mono or Miscrosoft Visual Studio tools).
You can use the Makefile provided in this repository. 
(You need csc.exe or mcs.exe in your system path)

## Installation
Put the exe file somewhere in your system path.
