using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolrd
{
    #region SCOPE
    public int Id;
    public string Name;
    public bool Status;
    public List<Level> Levels;
    #endregion

    #region CONSTRUCT
    public Wolrd(int Id, string Name, bool Status, List<Level> Levels)
    {
        this.Id = Id;
        this.Name = Name;
        this.Status = Status;
        this.Levels = Levels;
    }

    public Wolrd()
    {
        this.Id = 0;
        this.Name = "";
        this.Status = false;
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

    public List<Level> GetLevels()
    {
        return this.Levels;
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
