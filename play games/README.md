# Add Google Play Games Support to Your DeltaQuick Mod

This guide explains how to enable **Google Play Games achievements** in your DeltaQuick modification for **Chapters 1–4**.

> **Note**
> Chapter 5 does **not** require these changes because it does not include achievements.

---

## 1. Download the UndertaleModTool Script

First, download the provided UndertaleModTool script.

**Download:** [Here](./DELTAQUICK.csx)


---

## 2. Run the Script

Open **UndertaleModTool** and follow these steps:

```
Scripts
    └── Run Other Script...
```

Select the downloaded script and let it finish processing your game data.

---

# Chapter 1–4 Changes

The following modifications must be applied to every chapter (1–4).

---

## 3. Edit `obj_initializer2_Create_0`

Locate the Android initialization section and make sure it contains the following code:

```gml
if (!instance_exists(obj_event_manager))
{
    var event_manager = instance_create(0, 0, obj_event_manager);

    with (event_manager)
        init();

    if (os_type == os_ps4 || os_type == os_ps5 || os_type == os_android)
    {
        with (event_manager)
            enable_trophies();
    }
}
```

---

## 4. Edit `obj_event_manager_Create_0`

Add the following variables near the beginning of the event:

```gml
newScore = irandom_range(1, 100000);

leaderboard_prech5 = "CgkIrbKIzq0DEAIQIQ";

gp_achievement_ids = [];

gp_achievement_ids[0] = "CgkIrbKIzq0DEAIQHw";
gp_achievement_ids[1] = "CgkIrbKIzq0DEAIQAg";
gp_achievement_ids[2] = "CgkIrbKIzq0DEAIQAw";
gp_achievement_ids[3] = "CgkIrbKIzq0DEAIQBA";
gp_achievement_ids[4] = "CgkIrbKIzq0DEAIQBQ";
gp_achievement_ids[5] = "CgkIrbKIzq0DEAIQBg";
gp_achievement_ids[6] = "CgkIrbKIzq0DEAIQBw";
gp_achievement_ids[7] = "CgkIrbKIzq0DEAIQCA";
gp_achievement_ids[8] = "CgkIrbKIzq0DEAIQCQ";
gp_achievement_ids[9] = "CgkIrbKIzq0DEAIQCg";
gp_achievement_ids[10] = "CgkIrbKIzq0DEAIQCw";
gp_achievement_ids[11] = "CgkIrbKIzq0DEAIQDA";
gp_achievement_ids[12] = "CgkIrbKIzq0DEAIQDQ";
gp_achievement_ids[13] = "CgkIrbKIzq0DEAIQDg";
gp_achievement_ids[14] = "CgkIrbKIzq0DEAIQDw";
gp_achievement_ids[15] = "CgkIrbKIzq0DEAIQEA";
gp_achievement_ids[16] = "CgkIrbKIzq0DEAIQEQ";
gp_achievement_ids[17] = "CgkIrbKIzq0DEAIQEg";
gp_achievement_ids[18] = "CgkIrbKIzq0DEAIQEw";
gp_achievement_ids[19] = "CgkIrbKIzq0DEAIQFA";
gp_achievement_ids[20] = "CgkIrbKIzq0DEAIQFQ";
gp_achievement_ids[21] = "CgkIrbKIzq0DEAIQFg";
gp_achievement_ids[22] = "CgkIrbKIzq0DEAIQFw";
gp_achievement_ids[23] = "CgkIrbKIzq0DEAIQGA";
gp_achievement_ids[24] = "CgkIrbKIzq0DEAIQGQ";
gp_achievement_ids[25] = "CgkIrbKIzq0DEAIQGg";
gp_achievement_ids[26] = "CgkIrbKIzq0DEAIQGw";
gp_achievement_ids[27] = "CgkIrbKIzq0DEAIQHA";
gp_achievement_ids[28] = "CgkIrbKIzq0DEAIQHQ";
gp_achievement_ids[29] = "CgkIrbKIzq0DEAIQHg";

Achievement_STATE_HIDDEN = 0;
Achievement_STATE_REVEALED = 1;
Achievement_STATE_UNLOCKED = 2;

Achievement_TYPE_STANDARD = 0;
Achievement_TYPE_INCREMENTAL = 1;
```

---

## 5. Replace `load_trophies()`

Replace the entire function with the following implementation:

```gml
load_trophies = function(arg0)
{
    if (os_type == os_android)
    {
        if (googlePlayServices_IsAvailable())
        {
            show_debug_message("*** Checking Google Play Services Authentication...");
            googlePlayServices_IsAuthenticated();
        }
        else
        {
            show_debug_message("*** Google Play Services are NOT available on this device.");
        }
    }
    else if (os_type == os_ps4 || os_type == os_ps5)
    {
        if (pad_index == arg0)
            exit;

        pad_index = arg0;

        psn_init_trophy(pad_index);
        psn_get_trophy_unlock_state(pad_index);
    }
};
```

---

## 6. Replace `unlock_trophy()`

Replace the existing function with:

```gml
unlock_trophy = function(arg0)
{
    global.trophies[array_length(global.trophies)] = arg0;

    if (os_type == os_ps4 || os_type == os_ps5)
        psn_unlock_trophy(pad_index, arg0);

    if (os_type == os_android)
    {
        var _gp_id = gp_get_achievement_id(arg0);

        if (_gp_id != "")
        {
            var _trophy = get_trophy_by_id(arg0);

            if (array_length(_trophy.flags) > 0 && _trophy.threshold > 0)
            {
                googleplayservices_achievements_SetSteps(_gp_id, _trophy.threshold);
            }
            else
            {
                googleplayservices_achievements_Unlock(_gp_id);
                googleplayservices_leaderboard_SubmitScore(
                    leaderboard_prech5,
                    newScore,
                    "prechapter-5update"
                );
            }
        }
    }

    event_show_debug_message("*** trophy unlocked: ~1", arg0, false);

    if (scr_debug() && !global.is_console)
        scr_debug_save_trophies();
};
```

---

## 7. Edit `obj_event_manager_Other_70`

Append the following code **at the end of the event**:

```gml
// Paste the entire async Google Play Games code here
```

> **Copy the complete code provided in this guide without modifications.**
>
> (The block is intentionally omitted here because it is very large.)

---

## 8. Edit `obj_gamecontroller_Create_0`

At the **end** of the Create event, add:

```gml
with (obj_event_manager)
    load_trophies(1);
```

This automatically loads the player's Google Play Games achievements when the game starts.

---

## 9. Remove the Old Trophy Initialization

Finally, remove the call to:

```gml
load_trophies(...)
```

from:

```
obj_gamecontroller_Other_75
```

This prevents achievements from being initialized multiple times.

---

# Finished

After completing all of these steps, your DeltaQuick modification for **Chapters 1–4** will support:

- ✅ Automatic Google Play Games sign-in
- ✅ Achievement synchronization
- ✅ Achievement unlocking
- ✅ Achievement progress updates
- ✅ Leaderboard score submission
- ✅ Trophy synchronization between sessions
