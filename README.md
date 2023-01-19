# msconfig.exe, just with a tiny anti-scammer twist..
So, hello, fellow scambaiter! Fancy seeing you here. I'm sure you've probably heard of the classic "msconfig" strat, haven't you? You know, you'll be messing with some greedy little grease-shirt, until all of a sudden they start typing those familiar words into the run dialog/command prompt. Only for them to disappointingly show you all your stopped services, that they probably stopped themselves, acting as if "Microsoft" did it to "protect you from the hackers". No good.
&nbsp;
That's where I come in! You see, I unfortunately couldn't find much online regarding a replacement for msconfig so that it's still present but not functional as intended. It can be a viable solution to delete a critical scammerbin like that, but when it comes to scambaiting, it's all about the fun and humor of the scammer's annoyance and suffering as opposed to them simply lacking a tool for them to lie to you over. It's just so...*sooo* much funnier when they have a tool do the exact *opposite* of what they expect, versus it just...anticlimactically not being there at all.
&nbsp;
Here, you'll find an entire rewrite of the msconfig.exe binary (in C#.NET). It's not *exactly* like the original thing, but pretty close, and so close it'd probably be basically the same to a scammer who can't or is unwilling to compare it with the real thing. You're free to build it yourself, and once you're done, you can simply just place it on some hidden directory on your virtual machine, delete the original msconfig.exe binary, and replace it with a shortcut to this new piece of absolute treasure. You could maybe even place this in the actual system32 directory, assuming that works for you.

## Here's what it comes with, so far..
* All services being marked as "running" regardless of what the scammer tries to do
* The "apply" button constantly being visible as if to signal new changes to be applied, but will become completely greyed out once the person moves their mouse over it
* Something, mostly completely identical to the original msconfig, so as to be as discrete as possible in order to ensure complete awkwardness from the now ruined plan of the scammer

Hopefully you like it. *crosses fingers*
Good luck; and hopefully this makes your scambaiting just a *tad* bit more enjoyable ;)
