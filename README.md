# msconfig.exe, but with a little scambaiting twist..
We're all aware of the classic "msconfig" strat, aren't we? You know, the scammer will pull up msconfig, and act like all the stopped services are indicitive of some "antivirus" against "le hacker" or something?
Yeah, I've heard of that too. And, unfortunately, there wasn't much stuff I could find regarding replacing msconfig with something that doesn't allow that nonsense to occur.
So, as all programmers do, I realized that because no solution is likely in sight, I'd have to take matters into my own hands. Which is exactly what I did. This entire github repository is msconfig ENTIRELY REMADE in C#! Pretty cool, eh?

## Here's what it comes with, so far..
* All services being marked as "running" regardless of what the scammer tries to do
* The "apply" button constantly being visible as if to signal new changes to be applied, but will become completely greyed out once the person moves their mouse over it
* Something, mostly completely identical to the original msconfig, so as to be as discrete as possible in order to ensure complete awkwardness from the now ruined plan of the scammer

Hopefully you like it. *crosses fingers*