using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    #region SCOPE
    private int Id;
    private string Name;
    private bool Status;
    private int PlayerScore;
    #endregion

    #region CONSTRUCT
    public Level(int Id, string Name, bool Status, int PlayerScore)
    {
        this.Id = Id;
        this.Name = Name;
        this.Status = Status;
        this.PlayerScore = PlayerScore;
    }

    public Level()
    {
        this.Id = 0;
        this.Name = "";
        this.Status = false;
        this.PlayerScore = 0;
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

    public int GetPlayerScore()
    {
        return this.PlayerScore;
    }
    public void SetPlayerScore(int PlayerScore)
    {
        this.PlayerScore = PlayerScore;
    }
    #endregion
}
