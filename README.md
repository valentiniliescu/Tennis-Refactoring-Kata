# Code movement

* Used NCrunch and ReSharper.
* Tried to use automated refactorings in ReSharper as much as possible, prefixed the automated check-ins with "R#".
* Started the sessions with no focus, in the end I did a "code movement": replaced WonPoint method with Player1WonPoint and Player2WonPoint
  * The code movement starts at "R#: Extracted Player1WonPoint and Player2WonPoint in the test class".
  * Its check-ins are very granular, I checked-in after each refactoring, to show how I did it.
  * I was not able to automate one of the steps (the one not prefixed with "R#").
* The solution already has pinning tests. It's nice, but it usually does not happen in the real world. It would be more interesting if you would have to create them.
* Did an automated full code cleanup in ReSharper, I like my projects green.
* Deleted the TennisGame2 and TennisGame3, since they are not the focus of this assigment.
