Hello and thank you for purchasing DMReality 2D Radar

The 2D Radar system is quite easy to set up, please follow the steps below in order to set up and start using free 2D Raar Builder.

NOTE. you are LIMITED to creating 10 blip types in this free version.
Please see the "Compare Systems.pdf" for info on the Free version as compared to the Advanced version.


(1) Click 'Tools, in the menu dropdown, then 'DaiMangou' > '2D Radar Builder'. The editor window will be displayed.

(2) You will notice a message stating 'There is no Radar selected, you will need to add one or select an existing radar'. This is because no radar has been CREATED yet.

(3) To create a new Radar, Click the '2D Radar' button. You may also create up to 5 radars at once by  using the slider locate above the '2D Radar' burton and name your radar from the text box above the slider.

(4) Your radar has now been created. Now you will see three tabs, 'Design','Blips' and 'Create'. Design is automatically selected. 

(5) In the design tab you are required to add art to your radar and set your radar behavior.
Ypi will notice that thi area is devided into two regions "UI Design" and "Radar Behavior". in the "UI Design" area  below 'Radar Image' , you must click the little circle next to the box, it will open up a window ,
From that window , you must select from one of the sprites . Select 'Radar'. You do not need to place any sprite texture in the 'Rotating Image' area , however for the sake of learning, place the a sprite  in it :: Note : 2D Radar only uses sprites.

(6) 'Radar Zoom' control the distance that the blips on the radar will appear from the player or whatever you set to be the center of the radar. Set it to 6.0

(7) 'Radar Size' dictates the size your radar will be in game. so that you get a preview of your actual radar size.

(8) In the "RadarBehavior" section You will notice a dropdown named 'Radar Animation' it is set to 'None'. 'Zoom' and 'Fade' 'Bounce' and 'None' are the options that you will find in the dropdown. you may select either one .
'These allow you to control the way your radar appears in game .Zooom' will make the radar shrinking when disabled and grow when enabled, 'Fade' will make your radar fade in when enabled or fade out when disabled ,'Bounce' will be triggered only when the radar is 
set to active , the radar will expand and contract into view. 
The 2D Radar script is open for edition , so you can freely change the way the radar behaves and is displayed.

(9) In the "Radar Positioning" area you are able to set the position of the radar by selecting from a list of preset positions in the dropdown. you can snap the radar to 9 positions on the screen.


(10) Moving to the 'Blips' Tab. Click 'Blips'. Each blip has several components to it, by Default there is a Blip with the tag 'Player' set on it . You must set
- blip texture: from a sprite.
- blip size : with the slider.
- blip tag: from a list of tags.
- activate: inactive - button below 'Blip Size' slider.

(11) 'Number of blip types' represents the amount of object types in the scene that will be represented on radar by a blip. You can toggle the active state and size of each blip.

(12) It is not necessary to create multiple radars in any one scene, however you can do this but you must handle the after effects through your own code, Why? We do not know how you will access the object with your radar
script on it .

(Once you have done that .... you now know how to create a great 2D radar) Head on over to the demo scene and hit the play button and try it out. 