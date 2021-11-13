using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    #region SCOPE
    private int Id;
    private string Name;
    private bool Status;
    private int NumberLevels;
    private int UnlockedLevels;
    private List<Level> Levels;
    #endregion

    #region CONSTRUCT
    public World(int Id, string Name, bool Status, int NumberLevels, int UnlockedLevels, List<Level> Levels)
    {
        this.Id = Id;
        this.Name = Name;
        this.Status = Status;
        this.NumberLevels = NumberLevels;
        this.UnlockedLevels = UnlockedLevels;
        this.Levels = Levels;
    }

    public World()
    {
        this.Id = 0;
        this.Name = "";
        this.Status = false;
        this.NumberLevels = 0;
        this.UnlockedLevels = 0;
        this.Levels = new List<Level>();
    }
    #endregion

    #region GETTERS & SETTERS
    public int GetId()
    {
        return this.Id;
    }
    public void SetId(int Id)
    {
        this.Id = Id;
    }

    public string GetName()
    {
        return this.Name;
    }
    public void SetName(string Name)
    {
        this.Name = Name;
    }

    public bool GetStatus()
    {
        return this.Status;
    }
    public void SetStatus(bool Status)
    {
        this.Status = Status;
    }

    public int GetNumberLevels()
    {
        return this.NumberLevels;
    }
    public void SetNumberLevels(int NumberLevels)
    {
        this.NumberLevels = NumberLevels;
    }

    public int GetUnlockedLevels()
    {
        return this.UnlockedLevels;
    }
    public void SetUnlockedLevels(int UnlockedLevels)
    {
        this.UnlockedLevels = UnlockedLevels;
    }

    public List<Level> GetLevels()
    {
        return this.Levels;
    }
    public Level GetLevels(int ID)
    {
        Level ReturnLevel = new Level();

        foreach (Level SpecificLevel in this.Levels)
        {
            if (SpecificLevel.GetId() == ID)
            {
                ReturnLevel = SpecificLevel;
            }
        }

        return ReturnLevel;
    }
    public Level GetLevels(string Name)
    {
        Level ReturnLevel = new Level();

        foreach (Level SpecificLevel in this.Levels)
        {
            if (SpecificLevel.GetName() == Name)
            {
                ReturnLevel = SpecificLevel;
            }
        }

        return ReturnLevel;
    }
    public void SetLevels(List<Level> Levels)
    {
        this.Levels = Levels;
    }
    #endregion

    #region ADD & REMOVE
    public void AddLevel(Level LevelAdd)
    {
        this.Levels.Add(LevelAdd);
    }

    public void RemoveLevel(Level LevelRemove)
    {
        this.Levels.Remove(LevelRemove);
    }
    #endregion
}
