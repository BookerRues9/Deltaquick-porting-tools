using System.Windows.Forms;
using UndertaleModLib;
using UndertaleModLib.Models;
using static UndertaleModLib.Models.UndertaleSound;
using static UndertaleModLib.UndertaleData;
using System.Threading.Tasks;
using System.Text;
using System;
using System.IO;
using System.Threading;

async Task regroupSfx()
{
    EnsureDataLoaded();

    string GetFolder(string path)
    {
        return Path.GetDirectoryName(path) + Path.DirectorySeparatorChar;
    }

    string winFolder = GetFolder(FilePath);

    List<string> audionames = [];

    StreamWriter outputFile = new StreamWriter(Path.Combine(winFolder, "AudioNames.txt"));

    byte[] EMPTY_WAV_FILE_BYTES = System.Convert.FromBase64String("UklGRiQAAABXQVZFZm10IBAAAAABAAIAQB8AAAB9AAAEABAAZGF0YQAAAAA=");
    string DEFAULT_AUDIOGROUP_NAME = "audiogroup_default";

    //This seems to load all the audiogroups, ofc we need this lol
    Dictionary<string, IList<UndertaleEmbeddedAudio>> loadedAudioGroups;
    loadedAudioGroups = new Dictionary<string, IList<UndertaleEmbeddedAudio>>();

    //Progress bar
    int maxCount = Data.Sounds.Count;
    SetProgressBar(null, "Sound", 0, maxCount);
    StartProgressBarUpdater();

    SyncBinding("AudioGroups, EmbeddedAudio, Sounds, Strings", true);
    await Task.Run(RegroupSounds); // This runs sync, because it has to load audio groups.

    //Once we finish everything
    await StopProgressBarUpdater();

    foreach (string name in audionames)
        outputFile.WriteLine(name + ",");
    outputFile.Close();

    await StopProgressBarUpdater();
    HideProgressBar();
    ScriptMessage("Sounds regrouped succesfully.");

    DisableAllSyncBindings();

    void IncProgressLocal()
    {
        if (GetProgress() < maxCount)
            IncrementProgress();
    }

    IList<UndertaleEmbeddedAudio> GetAudioGroupData(UndertaleSound sound)
    {
        string audioGroupName = sound.AudioGroup is not null ? sound.AudioGroup.Name.Content : DEFAULT_AUDIOGROUP_NAME;
        if (loadedAudioGroups.ContainsKey(audioGroupName))
            return loadedAudioGroups[audioGroupName];

        string groupFilePath = Path.Combine(winFolder, "audiogroup" + sound.GroupID + ".dat");
        if (!File.Exists(groupFilePath))
            return null; // Doesn't exist.

        try
        {
            UndertaleData data = null;
            using (var stream = new FileStream(groupFilePath, FileMode.Open, FileAccess.Read))
                data = UndertaleIO.Read(stream, (warning, _) => ScriptMessage("A warning occured while trying to load " + audioGroupName + ":\n" + warning));

            loadedAudioGroups[audioGroupName] = data.EmbeddedAudio;
            return data.EmbeddedAudio;
        }
        catch (Exception e)
        {
            ScriptMessage("An error occured while trying to load " + audioGroupName + ":\n" + e.Message);
            return null;
        }
    }

    byte[] GetSoundData(UndertaleSound sound)
    {
        if (sound.AudioFile is not null)
            return sound.AudioFile.Data;

        if (sound.GroupID > Data.GetBuiltinSoundGroupID())
        {
            IList<UndertaleEmbeddedAudio> audioGroup = GetAudioGroupData(sound);
            if (audioGroup is not null)
                return audioGroup[sound.AudioID].Data;
        }
        return EMPTY_WAV_FILE_BYTES;
    }

    void RegroupSounds()
    {
        foreach (UndertaleSound sound in Data.Sounds)
        {
            if ((sound is not null) && (sound.AudioGroup.Name.Content == "audio_sfx"))
            {
                RegroupSound(sound);
            }
            else
            {
                IncProgressLocal();
            }
        }
    }

    async Task RegroupSound(UndertaleSound sound)
    {
        string soundName = sound.Name.Content;
        UndertaleEmbeddedAudio soundData = new UndertaleEmbeddedAudio() { Data = GetSoundData(sound) };
        Data.EmbeddedAudio.Add(soundData);
        Data.EmbeddedAudio.Remove(sound.AudioFile);
        int embAudioID = Data.EmbeddedAudio.Count - 1;
        UndertaleEmbeddedAudio RaudioFile = Data.EmbeddedAudio[embAudioID];

        //We have to set all this things manually
        UndertaleSound.AudioEntryFlags flags = UndertaleSound.AudioEntryFlags.IsEmbedded | UndertaleSound.AudioEntryFlags.Regular;

        sound.Flags = flags;
        sound.Type = Data.Strings.MakeString(".wav");
        sound.File = Data.Strings.MakeString(sound.Name.Content + ".wav");
        sound.AudioID = -1;
        sound.AudioFile = RaudioFile;
        sound.AudioGroup = null;
        sound.GroupID = Data.GetBuiltinSoundGroupID();

        audionames.Add(soundName);

        IncProgressLocal();
    }

}
// We start here.
if (!ScriptQuestion("reagrupar archivos sfx")) return;
regroupSfx();
ScriptMessage("Hecho");