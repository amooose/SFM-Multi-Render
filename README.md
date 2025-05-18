SFM Multi-Render
=============

A simple but hacky way to speed up SFM's render time by 4-5x 
This program splits your project up into multiple SFM sessions/processes, giving us a "multi-core" rendering experience from a single-core limited program.
Your PC should be decent enough if you plan on running 4-10 copies, but I imagine lower end PCs may benefit from 2-3.

**This will only work if you have enough VRAM, RAM, and CPU power to render multiple copies of your project.**  
If you have 10gb VRAM, and rendering one session only uses 2gb, this will work.  
If you have 10gb VRAM, and rendering one session uses > 5gb, this will not work.  

# Instructions
You likely need to run this program as administrator (more info in the notes section)
1. Patch your launcher to enable multirun [here](https://steamcommunity.com/sharedfiles/filedetails/?id=3481598701&searchtext=).  
2. Set the launch options via the "SFM Launch Options", just copy your launch options set already in Steam.
3. Create the amount of sessions you desire via the blue + button.
4. Fill out Session 1's project file .dmx and output directory+image name (quotes or no quotes, doesnt matter)  
   Click "All use Session 1 Path" button to duplicate it to all other sessions..
6. In the duplication area, fill out the Start and End range. If I want to render frame 0-3000, type in 0 for start, then 3000 for end. Click Distribute All Frames to evenly spread the frames between the sessions.
7. Optionally click the "Auto-hide SFM sessions", this will minimize every render window once it starts (Fake minimize, it moves it off screen).
8. Launch your sessions. You can observe the progress all from the main window without needing to check SFM.

![launch args](/mdAsset/s3xiblvoed.png)

# Notes
- This is in beta, I have not extensively tested this on a large amounts of projects.
- The auto-hide option modifies a registry key `Computer\HKEY_CURRENT_USER\SOFTWARE\Valve\SourceFilmmaker\Layouts_9\1\WindowPercentageGeometry`  
  This key is set by SFM every time is closes. So in our case, we "minimize" by hiding off screen, it will save that position, which we dont want.  
  The key is backed up, and restored every time you shut the program down or a render batch ends. In the odd event it didnt work, and you launch SFM normally and it is invisible, go to the Multi-Render settings via the gear, and click the button "Reset SFM window postion registry to default".
- We need to run as admin to avoid issues spawning/closing processes, as well as avoid issues reading SFM's memory (We read the memory to get the layoff % complete number). You can try to run normally, but I can't say for sure it will work.
