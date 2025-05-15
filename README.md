SFM Multi-Render
=============

A simple but hacky way to speed up SFM's render time by 4-5x 
This program splits your project up into multiple SFM sessions/processes, giving us a "multi-core" rendering experience from a single-core limited program.
Your PC should be decent enough if you plan on running 4-10 copies, but I imagine lower end PCs may benefit from 2-3.

# Instructions
1. Patch your launcher to enable multirun [here](https://steamcommunity.com/sharedfiles/filedetails/?id=3481598701&searchtext=).  
2. Set the launch options via the "SFM Launch Options", these are your launch options set in Steam.
3. Create the amount of sessions you desire via the blue + button.
4. Fill out Session 1's project file .dmx and output directory+image name (quotes or no quotes, doesnt matter)  
   Click "All use Session 1 Path" button to duplicate it to all other sessions..
6. In the duplication session, fill out the Start and end range. If I want to render frame 0-3000, type in 0 for start, then 3000 for end. Click Distribute All Frames to evenly spread the frames between the sessions.
7. Optionally click the "Auto-hide SFM sessions", this will minimize every render window once it starts (Fake minimize, it moves it off screen).
8. Launch your sessions. You can observe the progress all from the main window without needing to check SFM.

![launch args](/mdAsset/s3xiblvoed.png)

# Notes
- This is in beta, I have not extensively tested this on a large amounts of projects.
- The auto-hide option modifies a registry key `Computer\HKEY_CURRENT_USER\SOFTWARE\Valve\SourceFilmmaker\Layouts_9\1\WindowPercentageGeometry`  
  This key is set by SFM every time is closes. So in our case, we "minimize" by hiding off screen, it will save that position, which we dont want.  
  The key is backed up, and restored every time you shut the program down or a render batch ends. In the odd event it didnt work, and you launch SFM normally and it is invisible, go to the Multi-Render settings via the gear, and click the button "Reset SFM window postion registry to default".
