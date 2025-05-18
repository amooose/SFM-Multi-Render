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
- This is in beta, I have not extensively tested this on a large amounts of projects. Again, if your project is massive and you blasted your settings with stuff like shadowmapres 8192, this program cant do much for you since your VRAM might be maxed.
- The frame between sessions will produce a ghost frame most of the time. This is just SFM being SFM. Go back into SFM and just re-render that frame, and replace it in your output folder.
- You can choose to manually assign each session to a different core, or let the Winows OS Scheduler automatically handle it, via the "Sequentially distribute cores" option in the settings. Which is faster? I don't know yet (let me know if anyone does a comparsion please)
- If you use the DXVK .dll for SFM and have issues, try disabling it, it may save you some VRAM.  
I'm able to render 4k projects with DXVK however (6 sessions 90% max my VRAM)
- If you use custom layouts and not "default/layout 1" in SFM, the autohide option will work, but it wont restore your SFM window position on re-launch. If your SFM is invisible, click it on the taskbar and press ALT+Space, then maximize.
- The auto-hide option modifies a registry key `Computer\HKEY_CURRENT_USER\SOFTWARE\Valve\SourceFilmmaker\Layouts_9\1\WindowPercentageGeometry`  
This key is set by SFM every time is closes. So in our case, we "minimize" by hiding off screen, it will save that position, which we dont want (we fake minimize because actual minimizing messes up the render).
The key is backed up, and restored every time you shut the program down or a render batch ends. In the odd event it didnt work, and you launch SFM normally and it is invisible, go to the Multi-Render settings via the gear, and click the button "Reset SFM window postion registry to default".
- We need to run as admin to avoid issues spawning/closing processes, as well as avoid issues reading SFM's memory (We read the memory to get the layoff % complete number). You can try to run normally, but I can't say for sure it will work.

