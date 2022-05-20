NOTE - DM me on discord CONSCIENTIOUS GAMES#1113 to ask for modified version of AudioTrigger.cs (Only for students of Full Time game Dev)

AnimatorFunctions (Contains audio mangager and other stuff)
AudioManager tweaks by looking up at Brackeys videos.

Many different clips for one sound referenced from Thomas Brush.
Took Random range from Thomas Brush.

Check at https://www.conscientiousgames.com/ for news related to my 2D games

 WARNING :- Make Sure To Download All Scripts (GameManger.cs is optional)
 
(Recommended to do both)
---------------------------------------------------------
For Every gameobject using events in animator

Step1 : Add AnimatorFunctions.cs on Player.

Step2 : Now Just Add audio and particles using this neat arrangement.

Step3 : Copy paste string names on events in animator.
---------------------------------------------------------

For using it in script universally

Step1 : Add the animatorfunctions code in game manager. 

OR

If there is not one then create an empty with tag GM
Apply the GameManager.cs on it

Step2: Now in any script type this

GameManger.Instance.PlaySound("[Sound name]"); GameManger.Instance.EmitParticles("[Particle name]");
---------------------------------------------------------

Images for reference here at https://imgur.com/a/MA9m95y

GL!
