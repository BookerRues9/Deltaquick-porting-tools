# Deltaquick Porting Tools

## Important Notice

**WARNING:**  
This document is intended **only for advanced users** who know how to use **Undertale Mod Tool** and how to modify **Deltarune for Windows**.

- **Undertale Mod Tool** is a program used to modify Undertale / Deltarune on **Windows and Linux**.
- It is **100% required** in order to follow this guide and port modifications to **Deltaquick (Android)**.

---

## Deltaquick File System

Before adapting your modifications to Deltaquick, you must understand how its file system works.

> **IMPORTANT:**  
> You can only access these files **through the Save Manager built into Deltaquick**.

### File paths used by Deltaquick

```
/data/user/0/com.bookerpuzzle.deltaquick/files/game.droid
    → Chapter Select

/data/user/0/com.bookerpuzzle.deltaquick/files/chapter1_windows/game.droid
    → Chapter 1

/data/user/0/com.bookerpuzzle.deltaquick/files/chapter2_windows/game.droid
    → Chapter 2

/data/user/0/com.bookerpuzzle.deltaquick/files/chapter3_windows/game.droid
    → Chapter 3

/data/user/0/com.bookerpuzzle.deltaquick/files/chapter4_windows/game.droid
    → Chapter 4

/data/user/0/com.bookerpuzzle.deltaquick/files/mus/
    → Deltarune music files
```

### Loading a modified `data.win`

1. Rename your modified `data.win` to **`game.droid`**
2. Open **Deltaquick → Save Manager**
3. Replace the file inside the corresponding chapter folder

### Compatibility Warning

Deltaquick is **only compatible with the latest official version of Deltarune**.  
The **2018 and 2021 Demo versions are NOT supported**.

---

## Undertale Mod Tool Scripts

Deltaquick includes a script called **`tools.csx`**.

### Installing `tools.csx`

1. Open **Undertale Mod Tool**
2. Go to `Scripts → Run Other Script`
3. Select `tools.csx`
4. Run the script

After running it, two new functions will be available:

- `game_change_android()`
- `init_external_dir()`

> **ALL OF THIS MUST BE DONE INSIDE UNDERTALE MOD TOOL**

---

## `game_change_android()`

This function allows switching between different `game.droid` files.

### Limitations

- You can only switch between folders named `chapterX_windows`
- Using any other name **will not work**

### Change chapter

```gml
game_change_android("chapter" + chapstring + "_windows");
```

### Return to Chapter Select

```gml
game_change_android("");
```

---

##  `init_external_dir()`

This function grants `game.droid` access to the app’s internal storage, removing Android file access limitations.

It returns the following path as a string:

```
/data/user/0/com.bookerpuzzle.deltaquick/files/
```

### Recommended usage

```gml
// obj_time_Create_0
global.savepath = init_external_dir();
```

This global variable is **mandatory** to avoid breaking the save system.

---

## Save System Fix (MANDATORY)

To properly adapt the save system for Deltaquick, you **must modify the following functions in ALL `game.droid` files**:

```gml
ossafe_file_delete         = return file_delete(global.savepath + arg0);
ossafe_file_exists         = return file_exists(global.savepath + arg0);
ossafe_file_text_open_read = return file_text_open_read(global.savepath + arg0);
ossafe_file_text_open_write= return file_text_open_write(global.savepath + arg0);
ossafe_ini_open            = ini_open(global.savepath + arg0);
```

> **THIS STEP IS REQUIRED**  
> Skipping it will cause save data corruption.

---

## Special Case: Deltarune Chapter 3 Video Fix

Chapter 3 loads a video from the following path:

```
/data/user/0/com.bookerpuzzle.deltaquick/files/chapter3_windows/vid/
```

### How to fix

1. Open **Undertale Mod Tool**
2. Navigate to object: `obj_ch3_couch_video_Create_0`
3. Find this line:

```gml
video_open("vid/" + file_name + ".mp4");
```

4. Replace it (or add an Android case) with:

```gml
video_open(global.savepath + "chapter3_windows/vid/" + file_name + ".mp4");
```

---

## FIX_AUDIO.csx

This script fixes **sound effects (SFX)** for each chapter.

- **Does NOT fix music**
- Must be executed **only once**
- Apply it to all chapters **EXCEPT Chapter Select**

---

## Fixing Music Playback

After completing the previous steps, you may notice that music does not play.

### How to fix

1. Open **Undertale Mod Tool**
2. Locate the script: `snd_init`
3. Replace the music directory logic with:

```gml
if (global.launcher)
{
    if (os_type == os_android)
        dir = global.savepath + "mus/";
    else
        dir = working_directory + "../mus/";
}

if (os_type == os_android)
    dir = global.savepath + "mus/";
else
    dir = working_directory + "../mus/";
```

> This must be done in **every chapter from Chapter 1 to Chapter 4**.

---

## Loading `game.droid / data.win` into Deltaquick

1. Rename your modified `data.win` to **`game.droid`**
2. Open **Deltaquick → Save Manager**
3. Enter the desired chapter folder (e.g. `chapter4_windows`)
4. Press **Load Files**
5. Select your `game.droid`

The existing file will be replaced.  
Repeat this process for each chapter.

---

## Chapter 1 Language Fix

> **THIS MUST ALSO BE DONE IN UNDERTALE MOD TOOL**

Chapter 1 loads its strings from `lang_en.json`.

### Script to edit
`scr_84_lang_load`

### Replace this code

```gml
var name = "lang_" + global.lang + ".json";
var orig_filename = working_directory + "lang/" + name;
var new_filename = working_directory + "lang-new/" + name;
var filename = orig_filename;
var type = "orig";
var orig_map = scr_84_load_map_json(orig_filename);
```

### With this

```gml
var name = "lang_" + global.lang + ".json";

var orig_filename = global.savepath + "chapter1_windows/lang/" + name;
var new_filename  = global.savepath + "chapter1_windows/lang-new/" + name;

if (!file_exists(orig_filename)) {
    show_message_async("LANG NOT FOUND IN: " + orig_filename);
    exit;
}

var filename = orig_filename;
var type = "orig";

var orig_map = scr_84_load_map_json(orig_filename);
```

---


##  Touch Controls

Deltaquick includes built-in **touch controls**.

To enable or disable them:

1. Swipe **to the right** on the screen while the game is running.
2. A menu will appear.
3. From this menu, you can **enable or disable touch controls** at any time.

---
## Fix Black Screen in All Chapters

`THIS MUST BE DONE IN UNDERTALE MOD TOOL`

To fix the black screen issue that can occur in all chapters when running on Deltaquick:
Open Undertale Mod Tool
Navigate to the following object:

```gml 
obj_initializer2_Step_0```
Locate this line:
```gml 
if (audio_group_is_loaded(1))```
Replace it with:
```gml 
if (os_type == os_android || os_type == os_windows)```


This modification ensures proper initialization on Android (and keeps compatibility with Windows), preventing the game from getting stuck on a black screen during startup.

---
##  Credits

- **McArthur** — Deltaquick
- **AngelinePuzzle** — Scripts

