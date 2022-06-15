using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GooglePlayGames;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi;

public class GameControl : MonoBehaviour
{
    //Public, static reference to itself.
    public static GameControl control;
    private const string MY_KEY = "put_key_aqui";

    private SaveData saveData;    

    //Play Service fields
    public DateTime loadedTime;
    public TimeSpan playingTime;

    public string autoSaveName;
    public bool doSave;
    public byte[] cloudData;
    public TimeSpan timePlayed;

    //Save code on enable and disable if you want auto saving.

    // Use this for initialization
    void Awake()
    {
        //Ensures there the singleton design pattern.
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
            loadedTime = DateTime.Now;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }

        //Create the Play Games Client and configure it to enable saved game.
        
        PlayGamesPlatform.Activate();

        //Authenticate the player's Google account.
        Social.localUser.Authenticate((bool success) =>
        {
        });
    }

    /*
     * If the user is authenticated do cloud save.
     * */
    public void SaveToCloud()
    {
        if (Social.localUser.authenticated)
        {
            doSave = true;
            CloudSync();
        }
    }

    /*
     * Do cloud load.
     * */
    public void DoLoadFromCloud()
    {
        doSave = false;
        CloudSync();
    }

    /*
     * Open the saved game. Conflict resolution is longest play time. Saved game file name is "SavedGame".
     * */
    public void CloudSync()
    {
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.OpenWithAutomaticConflictResolution("SavedGame", DataSource.ReadCacheOrNetwork, ConflictResolutionStrategy.UseLongestPlaytime, OpenCloudSave);
    }


    /*
     * Checks to see if the saved file from the cloud has been successfully opened. Then does the cloud save and load depending on
     * the operation boolean "doSave". 
     * */
    public void OpenCloudSave(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            if (doSave)
            {
                CloudSave(status, game);
            }
            else
            {
                CloudLoad(game);
            }
        }
        else
        {

        }
    }

    /*
     * Does the cloud save.
     * Converts PlayerData into a byte array. Updates play time and saved file description. Then commits.
     * */
    public void CloudSave(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        Save();

        byte[] data = ToBytes(this.saveData);
        //Calculate play time and total playtime.
        TimeSpan delta = DateTime.Now.Subtract(loadedTime);
        playingTime += delta;
        this.timePlayed = playingTime;

        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
        builder = builder.WithUpdatedPlayedTime(this.timePlayed).WithUpdatedDescription("Current Level: " + saveData.GetUnlockedWorlds() +
                                                                                        " Current Player Level: " + saveData.GetNumberWorlds());

        SavedGameMetadataUpdate updatedMetadata = builder.Build();
        savedGameClient.CommitUpdate(game, updatedMetadata, data, OnSaveWritten);
    }

    /*
     * Reads the saved game file.
     * */
    public void CloudLoad(ISavedGameMetadata game)
    {
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.ReadBinaryData(game, OnCloudLoad);
    }

    public void OnSaveWritten(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {

        }
        else
        {

        }
    }

    /*
     * Converts the byte array from the cloud save and converts it to a PlayerData object.
     * Loads attributes from that object.
     * */
    public void OnCloudLoad(SavedGameRequestStatus status, byte[] data)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            SaveData thePlayerData = FromBytes(data);
            this.saveData = thePlayerData;
            Load();
        }
        else
        {
        }
    }

    /*
     * Updates the PlayerData object with current attributes.
     * */
    public void Save(SaveData saved)
    {
        saveData = saved;
    }

    /*
     * Convert byte array to a PlayerData object.
     * */
    public SaveData FromBytes(byte[] data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream ms = new MemoryStream();
        ms.Write(data, 0, data.Length);
        ms.Seek(0, SeekOrigin.Begin);
        saveData = (SaveData)bf.Deserialize(ms);

        ms.Close();

        return saveData;
    }

    /*
     * Convert a PlayerData object to a byte array.
     * */
    public byte[] ToBytes(SaveData thePlayerData)
    {
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream ms = new MemoryStream();

        //Serialise playerData.
        bf.Serialize(ms, thePlayerData);
        byte[] cloudData = ms.ToArray();

        ms.Close();

        return cloudData;
    }

    public void Load()
    {
        
    }

    public void Save()
    {

    }
}

