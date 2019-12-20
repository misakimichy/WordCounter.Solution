# WordCounter

#### _C#, .NET: WordCounter, 12/20/2019_

## Description
Write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only, for example, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

## Application should have:
- Backend logic belongs to the class called `RepeatCounter`.
- Plain English specs are committed in README before coding.
- Specs include specific input and output and a descriptive sentence.
- All specs have been written up correctly as test methods.
- All test are passing, and described functionality is present.

## Spec
| User input | User input | Expected output |
| :------------- | :------------- | :------------- |
| User input a word and a sentence. The word only appears once in the sentence. | big, I want to eat a big donut. | 1 |
| User input a word and a sentence. The word appears multiple times in the sentence. | big, I want to eat a big donut and a big cookie at a big cafe. | 3 |
| User input a word and a sentence. But the word doesn't fully match. | big, Her donut is bigger than mine. | 0 |
| User input a number instead of a word and a sentence. | 10, I want to eat a big donut. | Invalid input! |
| User input a word and a number instead of a sentence. | big,  123456789. | Invalid input! |


## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/WordCounter.Solution.git
```

2. Use the following codes:

a) Command to build the WordCounter. Run this in WordCounter directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in WordCounter.Tests directory:
```
$ dotnet restore && dotnet test
```


## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and MS Test


## License
Copyright © 2019 under the MIT License