# FunkinNeue

[INSTAGRAM](https://www.instagram.com/p/CHoJvRDnqDK/?utm_source=ig_web_copy_link)

[YouTube](https://www.youtube.com/watch?v=VHcZMNqLWe4)

## CLEANUP/publish

[ ] Create entry on birdhouseparty.com
	-- update readme.
	-- publish files.
	
## Description 

Funkineue - First complete test of my M4L Step sequencer driving ISF visuals realtime in Live.  Seizure inducing I know.  Just testing the limits with the entire kitchen sink.

	#generativeart
	#maxmsp
	#jitter74
	#madewithjitter
	#newmediaart
	#audioreactivevisuals
	#visualmusic
	#madewithjitter
	#vidvox
	#maxmspjitter
	#creativecoding
	#cycling74
	#ableton
	#max4live
	#steadfastcharlie



## Files
	
	VIDEO:
	20200811_funkineue_01-trim.mp4
	
	CURRENT PROJECT:
	20200811_funkineue_09.als
	/M4L/ADSR-ISF_1.368.amxd
	/M4L/ADSR-sound_v0.18.amxd
	/M4L/ADSR-world-out_0.1.amxd
	/M4L/ADSR-automation_v0.03.amxd
	/M4L/json/9_track4-8n.json
	/M4L/json/9_track3-8n.json
	/M4L/json/9_track2-8n.json
	/M4L/json/9_track1-8n.json
	/ISF-files/funkineue03.fs
	/Finale/032011_funkineue_score.musx
	/Finale/032011_funkineue_score_FINAL.pdf
	
	
## Runtime Instructions

### Session View (Grid)

I started this project in the Grid view.  I was able to fine tune the colors and automation. However I could have easily done this in the Arrangement view too.

1. 	Open Project
2. 	Load json files
	-buttons: import 4x, Load 4x - you should see the grid update
	-close window if you want better performance.
	-make sure "metro" button is active.
3.	Load "funkineue03.fs" ISF shader
4.	Activate "qmetro and mode" buttons
5.	Reenable the "Automation" orange button on transport.  
	-I think the "ADSR-ISF_1.368 > adsrScene" automation is messing this up. 
	-Perhaps scene 1 is trying to load
5.	(Optional) Turn on record window and move to 2nd screen
	a. turn on "visible" button
	b. move to 2nd screen and turn on "enable" button
6. 	Play scene.

### Arrangement View (DAW)

1.	Click ADSR button
2. 	Load json files
	-buttons: import 4x, Load 4x - you should see the grid update
	-close window if you want better performance.
	-In arrangement view most often you want to use the "step" setting. 
3.	Load "funkineue03.fs" ISF shader
4.	Activate "qmetro and mode" buttons

### Record Midi from ADSR-sound.amxd

1.	Create new midi track
2.	Midi from ADSR-sound track. Post FX.
3.	Play the scene and record on the new midi track.
4.	Quantize and copy the notes back into each track containing ADSR-sound devices.

## Edit animation

1.	Click "ADSR" button
2.	select scene
3.	Click scene view "0-63" to refresh view
4.	edit animation blocks
5.	Click "save" or else the changes wont be committed dict object.
6.	Click "export" (only after you hit "save"). Save each track file the same # as the project. 


## Tips 2 Remember

1. Assuming the grid is in 16th, you want to draw the step in the automation. This allows you to scrub in a clip(sort of). 
1. Leave a measure at the beginning to reset automation. 
2. Tool slows down when in focus.  close the adsr-gridwindow for better performance.


## Enhancements

	[ ]	PITA to load the json every time.  Need to have this load automatically
	[ ] Also sucks to have to load a shader and click qmetro and mode.  This operation should be consolidated.
	[ ]	When you playback cold in arangement view the automation doesn't trigger till values change. I have to let it play through to the next scene to see the correct automation.
	[ ] Separate the ADSR grid from the ISF.  This way you can use different rendering (ISF, JXS, VMM).
	[ ] Master track viewer should default to 720x405 automatically.  Activating this should be a one button process.  However if I have to move this to a second screen maybe I do need 2 buttons.


## Bugs

	[ ]	adsr-gridwindow too big,  Consolidate all the save/load buttons.
	[ ] shader sometimes doesn't display when you mess with the device(on|off|fileManagement)
	[ ] When you change the tempo in girdwindow it messes with the sample tempo. 
		- Changed the tempo to 160 in gridwindow.  Sample shows as 160 in edit view on track.  Must be connected somehow.
	[ ] Noticed that if you run a song in arrangement view a long time, over and over, CPU resources get consumed.  Especially if you are doing a lot of automation work. Not sure why this is happening but eventually it causes the audio to stutter.  Simply closing the project and reloading frees up CPU resources
	[ ] After "load" button background doesn't match grid width.
	[ ]	I think the "ADSR-ISF_1.368 > adsrScene" automation is messing this up. Perhaps scene 1 is trying to load






