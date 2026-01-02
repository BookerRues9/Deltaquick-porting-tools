Deltaquick Wiki
Welcome

Welcome to the Deltaquick Porting Tools Wiki.
This wiki explains how to properly port Deltarune (Windows) modifications to Deltaquick (Android) using Undertale Mod Tool.
!!!!!!!!Advanced users only
This documentation assumes you already know how to modify Deltarune using Undertale Mod Tool.

Table of Contents

Requirements

Deltaquick File System

Undertale Mod Tool Scripts

game_change_android()

init_external_dir()

Save System Fix (Mandatory)

Chapter 3 Video Fix

FIX_AUDIO.csx

Music Fix

Loading game.droid Files

Chapter 1 Language Fix

Requirements

Undertale Mod Tool (Windows or Linux)

Latest official version of Deltarune

Deltaquick (Android)

 Demo versions from 2018 and 2021 are NOT supported

Deltaquick File System

Before porting any mod, you must understand how Deltaquick stores and loads files.

 Files are accessible ONLY through the Save Manager inside Deltaquick.

File layout
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
    → Music files

Undertale Mod Tool Scripts

Deltaquick provides a script called tools.csx.

Installing tools.csx

Open Undertale Mod Tool

Go to Scripts → Run Other Script

Select tools.csx

Run the script

This adds two new functions:

game_change_android()

init_external_dir()

 All script modifications must be done inside Undertale Mod Tool

game_change_android()

Used to switch between different game.droid files.

Limitations

Only folders named chapterX_windows are supported

Any other name will not work

Change chapter
game_change_android("chapter" + chapstring + "_windows");

Return to Chapter Select
game_change_android("");

init_external_dir()

Grants access to Deltaquick’s internal storage.

Returned path
/data/user/0/com.bookerpuzzle.deltaquick/files/

Recommended usage
// obj_time_Create_0
global.savepath = init_external_dir();


This global variable is required for proper file access on Android.

Save System Fix (Mandatory)

To prevent save corruption, ALL game.droid files must be modified.

Replace the following functions:

ossafe_file_delete         = return file_delete(global.savepath + arg0);
ossafe_file_exists         = return file_exists(global.savepath + arg0);
ossafe_file_text_open_read = return file_text_open_read(global.savepath + arg0);
ossafe_file_text_open_write= return file_text_open_write(global.savepath + arg0);
ossafe_ini_open            = ini_open(global.savepath + arg0);


 Skipping this step WILL break saves

Chapter 3 Video Fix

Chapter 3 loads a video from:

/data/user/0/com.bookerpuzzle.deltaquick/files/chapter3_windows/vid/

Fix steps

Open object:

obj_ch3_couch_video_Create_0


Replace:

video_open("vid/" + file_name + ".mp4");


With:

video_open(global.savepath + "chapter3_windows/vid/" + file_name + ".mp4");

FIX_AUDIO.csx

This script fixes sound effects (SFX).

Applies to all chapters

Do NOT apply to Chapter Select

Must be executed only once

Music Fix

Music will not play unless this step is done.

Steps

Open script: snd_init

Replace music directory logic with:

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


 Must be done in Chapter 1 → Chapter 4

Loading game.droid Files
Steps

Rename modified data.win → game.droid

Open Deltaquick → Save Manager

Navigate to the target chapter folder

Press Load Files

Select your game.droid

Repeat for each chapter.

Chapter 1 Language Fix

Chapter 1 loads text from lang_en.json.

Script to edit

scr_84_lang_load

Replace this code
var name = "lang_" + global.lang + ".json";
var orig_filename = working_directory + "lang/" + name;
var new_filename = working_directory + "lang-new/" + name;
var filename = orig_filename;
var type = "orig";
var orig_map = scr_84_load_map_json(orig_filename);

With this
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
