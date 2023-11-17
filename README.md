# Anagram Finder
A simple command line utility for finding anagrams in a specified file

## Software required to run this
* .NET
* Visual Studio Code
* Visual Studio Code C# Dev Kit Extension

## Building and Running the tests

- Open a command prompt
- Navigate to the folder where this code test has been deployed or cloned
- in the command prompt open Visual Studio Code by:
```
> code src
```
- Click on the Extensions icon (or [CTRL] + [SHIFT] + [X])
- In the search box enter:
```
C# Dev Kit
```
- Click the Install button
- Once this extension has installed, you will need to close and reopen Visual Studio Code
- On restart, you should now see a conical flask icon. Click this Icon (Testing)
- On the dialog, click the double play button (Run Tests). You will see 4 tests run, 3 pass and 1 fails. 

Part of your task to write a solution so that this last test passes!


# Editing Test Cases

- Select the Explorer icon on the left (or [CTRL] + [SHIFT] + [E])
- Under 'tests' are two files 'ProgramIntegrationTests.cs' and 'AnagramFinderTests.cs'
- These are the unit tests for this solution.
- You can run all or individual tests, together with debugging tests by either (a) clicking the right mouse button and selecting an option from the context menu, or (b) using the test explorer and selecting one of the icons next to the test you wish to run or debug.

## Running the program
```
dotnet src\codingtest\bin\Debug\net6.0\codingtest.dll example2.txt
```
where example2.txt is the text file that we want to search for anagrams

