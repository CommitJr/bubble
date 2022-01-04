using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomeAtirador : MonoBehaviour
{
    #region SCOPE
    private string shooterName;
    #endregion

    #region GETTERS & SETTERS
    public void SetShooterName(string shooterName)
    {
        this.shooterName = shooterName;
    }

    public string GetShooterName()
    {
        return shooterName;
    }
    #endregion
}
