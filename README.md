# Sparta-Bowling-Game

A C# console application for a 1-player bowling Game.

## Rules of play
A game of bowling consists of ten frames. In each frame, the bowler will have two chances to knock down as many pins as possible with their bowling ball. If a bowler is able to knock down all ten pins with their first ball, he is awarded a strike. If the bowler is able to knock down all 10 pins with the two balls of a frame, it is known as a spare. Bonus points are awarded for both of these, depending on what is scored in the next 2 balls (for a strike) or 1 ball (for a spare). If the bowler knocks down all 10 pins in the tenth frame, the bowler is allowed to throw 3 balls for that frame. This allows for a potential of 12 strikes in a single game, and a maximum score of 300 points, a perfect game.

## Scoring
**Strike**: When all ten pins are knocked down with the first ball (called a strike and typically rendered as an “X” on a score sheet), a player is awarded ten points, plus a bonus of whatever is scored with the next two balls. In this way, the points scored for the two balls after the strike are counted twice.
<br><br>
Frame 1, ball 1: 10 pins (strike) <br>
Frame 2, ball 1: 3 pins <br>
Frame 2, ball 2: 6 pins <br>
<br>
The total score from these throws is:<br>
<br>
Frame one: 10 + (3 + 6) = 19<br>
Frame two: 3 + 6 = 9<br>
TOTAL = 28<br>
<br>
A player who scores multiple strikes in succession would score like so:<br>
<br>
Frame 1, ball 1: 10 pins (strike)<br>
Frame 2, ball 1: 10 pins (strike)<br>
Frame 3, ball 1: 4 pins<br>
Frame 3, ball 2: 2 pins<br>
<br>
The score from these throws are:<br>
<br>
Frame one: 10 + (10 + 4) = 24<br>
Frame two: 10 + (4 + 2) = 16<br>
Frame three: 4 + 2 = 6<br>
TOTAL = 46<br>
<br>
The most points that can be scored in a single frame are 30 points (10 for the original strike, plus strikes in the two subsequent frames).
<br><br>
A player who bowls a strike in the tenth (final) frame is awarded two extra balls so as to allow the awarding of bonus points. If both these balls also result in strikes, a total of 30 points (10 + 10 + 10) is awarded for the frame. These bonus points do not count on their own; they only count as the bonus for the strike.
<br><br>
**Spare**: A “spare” is awarded when no pins are left standing after the second ball of a frame; i.e., a player uses both balls of a frame to clear all ten pins. A player achieving a spare is awarded ten points, plus a bonus of whatever is scored with the next ball (only the first ball is counted). It is typically rendered as a slash on score sheets in place of the second pin count for a frame.
<br><br>
Example:<br>
Frame 1, ball 1: 7 pins<br>
Frame 1, ball 2: 3 pins (spare)<br>
Frame 2, ball 1: 4 pins<br>
Frame 2, ball 2: 2 pins<br>
<br>
The total score from these throws is:<br>
<br>
Frame one: 7 + 3 + 4 (bonus) = 14<br>
Frame two: 4 + 2 = 6<br>
TOTAL = 20<br>
<br>
A player who bowls a spare in the tenth (final) frame is awarded one extra ball to allow for the bonus points.  The maximum score in a game of ten-pin is 300.<br>
