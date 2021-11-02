using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    #region SCOPE
    private string GameVersion;
    private int PlayerHealth;
    private List<Wolrd> Worlds;
    #endregion

    #region CONSTRUCT
    public SaveData(string GameVersion, int PlayerHealth, List<Wolrd> Worlds)
    {
        this.GameVersion = GameVersion;
        this.PlayerHealth = PlayerHealth;
        this.Worlds = Worlds;
    }

    public SaveData()
    {
        this.GameVersion = Application.version;
        this.PlayerHealth = 3;
        this.Worlds = new List<Wolrd>();
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

    public List<Wolrd> GetWorlds()
    {
        return this.Worlds;
    }
    public void SetWorlds(List<Wolrd> Worlds)
    {
        this.Worlds = Worlds;
    }
    #endregion

    #region ADD & REMOVE
    public void AddWolrd(Wolrd WolrdAdd)
    {
        this.Worlds.Add(WolrdAdd);
    }

    public void RemoveWolrd(Wolrd WolrdRemove)
    {
        this.Worlds.Remove(WolrdRemove);
    }
    #endregion
}