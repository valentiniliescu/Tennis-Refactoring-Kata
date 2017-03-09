# Assignment 2

## Thoughts on pair programming
Today me and Valentin did a remote pair programming session to work on the Tennis Refactoring Kata, and it happened to be the first time I've done real pair programming.

I've worked remotely with other developers using Skype or Skype Teams a lot but have never used the driver/navigator technique.

We started off working informally then transitioned into using the driver/navigator technique with Valentin navigating and me driving.

#### The good
1. While I was driving, it freed me up to think about the changes he was proposing
2. We identified when changes felt like it made the API worse and avoid those changes
3. I'm not sure what the pace of work should be when I'm experienced with pairing. For a first session I was pleasantly surprised with how quickly we got a few things done. 

#### My concerns
1. I didn't navigate but I don't know if I'll be able to come up with changes/improvements for the driver quickly enough to keep him busy
2. That's it for now, I need to pair program more before drawing any additional conclusions

#### Overall
I had a good time pairing, and will 100% do it again.

## Tennis refactoring kata
1. Moved the player data into class instead of passing primatives around
2. Changed WonPoint(string name) call to live on the player class. That reinforced the previous change because moved player functionality into the class.
3. Talked about how we can improve the ITennisGame interface. We had to create a method for each player to win a point and that feels clunky.
4. The existing test coverage made it simple to refactor and I made changes without fear of causing bugs.