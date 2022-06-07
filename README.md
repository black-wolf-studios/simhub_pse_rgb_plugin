Download this Plugin at RaceDepartment: https://www.racedepartment.com/downloads/simhub-headlight-flasher-plugin.40824/  
  
This Plugin uses SimHub: https://www.simhubdash.com/  
  
**Important:** v2.0 requires SimHub v7.4.7 and beyond. This is due to a change to the Keyboard emulator libary. Plugin v1.1 and prior are not compatible with SimHub v7.4.7. 
  
This Plugin adds a Headlight Flasher. This allows you to simply press a button once to trigger a set of flashes (configurable in length and number) by toggling the Headlight button, useful for Sims without a Flasher (Rfactor 2, AMS1, etc.). It allways makes an on and off toggle, so when headlights are on at Night they will remain on afterwards.  
The Headlight Flasher is available by mapping in SimHub in Controlls a Button to the Action "FlashHeadlights"  

rFactor 2 new Auto Headlights are supported by turning rf2 Auto-Mode in the Setting on.  
Calling your opponents names by flashing Morse code is now available too.  
  
To install the Plugin:  
1. Place the HeadlightFlashPlugin.dll into your SimHub install  
2. Upon starting SimHub you will be asked to enable the Plugin  
  
Configuration:  
1. Open Additional Plugins (The Three dots in one row)  
2. Select Headlight Flasher at the Top  
3. Map your Headlight Key (this has to be a Keyboard key, you can use the "ToggleHeadlights" Action to toggle them via a gamepad). The Default L should work for most users  
4. Set your Flash Length (Length of individual on/off periode, not total), Number of Flashes, or disable it  
5. Press Apply  
6. Go to Controls and Events (The Keyboard icon)  
7. It opens on the Controls Tab, press New Mapping  
8. Press the button that you want to map the Flasher to, and it should appear in the left column and be selected  
(Controllers input plugin is required to be turned on to map to a controller, the plugin ships with SimHub, but make sure you have it turned on)  
9. Select on the Right Side the "FlashHeadlights" Action  
10. It is strongly recommended to change the Games selection, per default it is All.  
I would recommend to deselect all and then select Rfactor 2, RF1, AMS, GTR, etc. This is so you can use this button in Sims that have Flashers such as iRacing and ACC.  
11. Press OK  
12. Go ingame and map the headlights to the key selected in step 3  
13. (Optional) Repeat steps 7 to 11 for "TurnHeadlight" if you want to have this mapped to some button instead of just having a keyboard key  
  
Actions added to SimHub:  
-FlashHeadlights: Flashes the Headlights at a user defined frequency and number.  
-TurnHeadlights: Included for turning the headlights on. Not necessary, you could as well use keyboard emulation to achieve the same, but keyboard emulation can not be configured to work only in certain games, and this can be setup this way.  
-FlashMessage: This allows you to send a configured message in Morse Code via the Headlights. This is a meme feature  
