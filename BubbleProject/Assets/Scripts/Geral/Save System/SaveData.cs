using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    #region SCOPE
    [SerializeField] private string GameVersion;
    [SerializeField] private int PlayerHealth;
    [SerializeField] private int NumberWorlds;
    [SerializeField] private int UnlockedWorlds;
    [SerializeField] private List<World> Worlds;
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
    public World GetWorlds(int ID)
    {
        World ReturnWorld = new World();

        foreach (World SpecificWorld in this.Worlds)
        {
            if (SpecificWorld.GetId() == ID)
            {
                ReturnWorld = SpecificWorld;
            }
        }

        return ReturnWorld;
    }
    public World GetWorlds(string Name)
    {
        World ReturnWorld = new World();

        foreach (World SpecificWorld in this.Worlds)
        {
            if (SpecificWorld.GetName() == Name)
            {
                ReturnWorld = SpecificWorld;
            }
        }

        return ReturnWorld;
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