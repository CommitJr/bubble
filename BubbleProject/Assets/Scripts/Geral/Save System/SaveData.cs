using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    #region SCOPE
    private string GameVersion;
    private int PlayerHealth;
    private int NumberWorlds;
    private int UnlockedWorlds;
    private List<World> Worlds;
    #endregion

    #region CONSTRUCT
    public SaveData(string GameVersion, int PlayerHealth, int NumberWorlds, int UnlockedWorlds, List<World> Worlds)
    {
        this.GameVersion = GameVersion;
        this.PlayerHealth = PlayerHealth;
        this.NumberWorlds = NumberWorlds;
        this.UnlockedWorlds = UnlockedWorlds;
        this.Worlds = Worlds;
    }

    public SaveData()
    {
        this.GameVersion = Application.version;
        this.PlayerHealth = 3;
        this.NumberWorlds = 5;
        this.UnlockedWorlds = 1;
        this.Worlds = new List<World>();
    }
    #endregion

    #region GETTERS & SETTERS
    public string GetGameVersion()
    {
        return this.GameVersion;
    }
    public void SetGameVersion(string GameVersion)
    {
        this.GameVersion = GameVersion;
    }

    public int GetPlayerHealth()
    {
        return this.PlayerHealth;
    }
    public void SetPlayerHealth(int PlayerHealth)
    {
        this.PlayerHealth = PlayerHealth;
    }

    public int GetNumberWorlds()
    {
        return this.NumberWorlds;
    }
    public void SetNumberWorlds(int NumberWorlds)
    {
        this.NumberWorlds = NumberWorlds;
    }

    public int GetUnlockedWorlds()
    {
        return this.UnlockedWorlds;
    }
    public void SetUnlockedWorlds(int UnlockedWorlds)
    {
        this.UnlockedWorlds = UnlockedWorlds;
    }

    public List<World> GetWorlds()
    {
        return this.Worlds;
    }
    public void SetWorlds(List<World> Worlds)
    {
        this.Worlds = Worlds;
    }
    #endregion

    #region ADD & REMOVE
    public void AddWorld(World WolrdAdd)
    {
        this.Worlds.Add(WolrdAdd);
    }

    public void RemoveWorld(World WolrdRemove)
    {
        this.Worlds.Remove(WolrdRemove);
    }
    #endregion
}