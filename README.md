Program for a cricket team I built for my business software development class! Instructions are as follows:
Cricket Player Scores - Independent Project Instructions
Processing Cricket Player Scores
This week you are going to perform some simple processing on the scores produced by a team after a cricket match. 
For each batsman the following information will be entered:
name of batsman
score achieved in runs
Every member of the team must bat, so 11 scores will be entered into the program, along with 11 names. The customer is insisting that the program does not accept invalid inputs. You have been told:
The scores will be entered at the start of the program. There are eleven scores.
The batsmen will be referred to by name.  No batsman may have an empty name. If an empty name is entered, the prgram will display the message "Invalid name. Please enter a name."
The lowest score which can be achieved by a batsman is 0. This is also called a "duck'.
The highest score which the program should accept is 500, i.e. if the user tries to enter a score which is greater than this value it must be rejected.
The invalid score message is "Invalid score. Please enter a score between 0 and 500"
If there are any other errors you can think of, your program should handle them too.
First write a line wecoming the user to the program. Welcome to the Cricket Score Program!
Next prompt the user to enter the names and scores:
    Welcome to the Cricket Score Program!
    Player 1 - Enter Name: Jim
    Enter Score: 150
    Player 2 - Enter Name: Dan
    Enter Score: 2500
    Invalid score. Please enter a score between 0 and 500
    Enter Score: 25
.......

This means that Jim scored 150 runs and Dan scored 25 runs. One invalid score was rejected. You should use the number reading methods you have created in earlier weeks to read the numbers in and reject invalid ones.

Creating a Player structure 
  struct Player { 
      public string Name; 
      public int Score; 
  }

You should create a structure to store the score information about each player and then create an array which will hold all 11 score values.

Sorting Cricket Scores
Once all the information has been entered the program should print out a list of the cricket scores, sorted by the score value with the largest score first. Use the Bubble Sort to perform the sort. Bubble Sort works by comparing adjacent elements in the array and swapping them around if they are in the wrong order. Refer to the guided project for more details on how to do this.

Selecting the Sorting option
Once you have completed the sorting by score, you must now modify the program so that it can also sort by the names of the players. After the scores have been entered the program should ask the following question:
Do you want to sort by name or by scores? (enter N or S): N
If the user enters 'S" the program will display the message "Sorted by score:" and then sort the scores in descending (500-->0) order.
If the user enters 'N' the program will display the message "Sorted by name:" and then sort the names of the players in ascending (A-->Z) order. The greater than (>) and less than (<) operators don’t work between strings, but you can use the CompareTo method to compare one string with another:
  string a = "Fred";
  string b = "Jim";
  if (a.CompareTo(b) < 0) {
      Console.WriteLine("Fred is before Jim");
  }


In the code above the string a is comparing itself with b using the CompareTo method. The CompareTo method compares the string with another and returns -1, 0 or +1. It returns -1 if the string doing the comparing (in the above example a) is before the other (in the above example b) in alphabetical ordering. If the two strings are equal CompareTo returns zero. If the string doing the comparing is after the target string the CompareTo method returns +1. The above code snippet would print the message because Fred is before Jim in the alphabet.

Completing the Solution
Modify your program so that it prints out a list of players sorted by name or score.
The program will be used like this:
  Welcome to the Cricket Score Program!
  Player 1 - Enter Name: Doc
  Enter Score: 25
  Player 2 - Enter Name: Grumpy
  Enter Score: 7
  Player 3 - Enter Name: Happy
  Enter Score: 12
  Player 4 - Enter Name: Sleepy
  Enter Score: 43
  Player 5 - Enter Name: Bashful
  Enter Score: 0
  Player 6 - Enter Name: Sneezy
  Enter Score: 5
  Player 7 - Enter Name: Dopey
  Enter Score: 6
  Player 8 - Enter Name: Jumpy
  Enter Score: 9
  Player 9 - Enter Name: Burpy
  Enter Score: 12
  Player 10 - Enter Name: Lazy
  Enter Score: 8
  Player 11 - Enter Name: Crabby
  Enter Score: 88
  Do you want to sort by name or by scores? (enter N or S): N
  Sorted by name:
  Name: Bashful, Score: 0
  Name: Burpy, Score: 12
  Name: Crabby, Score: 88
  Name: Doc, Score: 25
  Name: Dopey, Score: 6
  Name: Grumpy, Score: 7
  Name: Happy, Score: 12
  Name: Jumpy, Score: 9
  Name: Lazy, Score: 8
  Name: Sleepy, Score: 43
  Name: Sneezy, Score: 5
