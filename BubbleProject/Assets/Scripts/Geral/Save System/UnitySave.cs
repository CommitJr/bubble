using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.Core;
using UnityEngine;

public class UnitySave : MonoBehaviour
{
    #region SCOPO
    public static UnitySave Instance { get; private set; }
    public string PlayerID { get; private set; }
    public bool isOnline { get; private set; }

    Dictionary<ECloudKeyData, string> Keys = new Dictionary<ECloudKeyData, string>();
    public Action<ECloudKeyData, string> OnCloudDataRetrieved;
    public Action OnCloudServiceOnline;

    public DateTime loadedTime;
    public TimeSpan playingTime;
    public TimeSpan timePlayed;
    
    int TotalKey = 0;

    /// Keys to obtain the string cloud keys
    public enum ECloudKeyData
    {
        TotalKey = 0
    }

    #endregion

    private async void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("Instancia já existe, deletando para evitar cópias...");
            Destroy(this);
        }
        else
        {
            Instance = this;
            Debug.Log("Instanciando...");
        }

        await UnityServices.InitializeAsync();
        Debug.Log(UnityServices.State);

        await SignInAnonymouslyAsync();
    }
    void Start()
    {
        SetupEvents();
        CreateKeys();

    }

    #region Autenticação
    void SetupEvents()
    {
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log($"PlayerID: {AuthenticationService.Instance.PlayerId}");
            Debug.Log($"Access Token: {AuthenticationService.Instance.AccessToken}");
        };

        AuthenticationService.Instance.SignInFailed += (err) =>
        {
            Debug.LogError(err);
        };

        AuthenticationService.Instance.SignedOut += () =>
        {
            Debug.Log("Player signed out.");
        };
    }

    private async Task SignInAnonymouslyAsync()
    {
        AuthenticationService.Instance.SignedIn += () =>
        {
            PlayerID = AuthenticationService.Instance.PlayerId;
            Debug.Log("Signed in as PlayerID: " + PlayerID);

            isOnline = true;
            OnCloudServiceOnline?.Invoke();
        };
        AuthenticationService.Instance.SignInFailed += s =>
        {
            // Take some action here...
            Debug.Log(s);
        };

        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    #endregion

    #region [Internal Logic]
    private void CreateKeys()
    {
        Keys.Add(ECloudKeyData.TotalKey, "TotalKey");
    }
    #endregion

    #region SAVE e LOAD
    public async void SaveCloudData(object _data)
    {
        if (isOnline)
            await ForceSaveSingleData(_data);
        else
            Debug.LogWarning("Cannot save data! Cloud Service is offline");
    }

    public async void GetCloudData(ECloudKeyData _key)
    {
        if (isOnline)
        {
            Debug.Log("Getting data");
            var Data = await GetSingleData(Keys[_key]);
            Debug.Log("data: " + Data);
            Debug.Log("KEY[key]: " + Keys[_key]);
            Debug.Log("[key]: " + _key);
            OnCloudDataRetrieved?.Invoke(_key, Data);

        }
        else
        {
            Debug.LogWarning("Cannot load data! Cloud Service is offline");
        }
    }
    #endregion

    #region TASKS
    private async Task ForceSaveSingleData(object _value)
    {
        TimeSpan delta = DateTime.Now.Subtract(loadedTime);
        playingTime += delta;
        this.timePlayed = playingTime;

        Debug.Log("CHAMOU O SAVE");
        try
        {
            Dictionary<string, object> jsonFile = new Dictionary<string, object>();
            jsonFile.Add(this.timePlayed.ToString(), _value);
            
            await CloudSaveService.Instance.Data.ForceSaveAsync(jsonFile);

            Debug.Log($"Successfully saved {this.timePlayed}:{_value}");
        }
        catch (CloudSaveValidationException e)
        {
            Debug.LogError(e);
        }
        catch (CloudSaveException e)
        {
            Debug.LogError(e);
        }
    }

    private async Task<string> GetSingleData(string _key)
    {
        try
        {
            Dictionary<string, string> savedData = await CloudSaveService.Instance.Data.LoadAsync(new HashSet<string> { _key });
            if (savedData.Count > 0)
            {
                Debug.Log("SAVED DATA: " + savedData[_key]);
                Debug.Log("KEY: " +_key);
                return savedData[_key];
            }
                
            else
                Debug.LogWarning("Cannot fetch data from the key: " + _key);
        }
        catch (CloudSaveValidationException e)
        {
            Debug.LogError(e);
        }
        catch (CloudSaveException e)
        {
            Debug.LogError(e);
        }

        return null;
    }
    #endregion

    public void OnCloudDataRetrievedHandler(ECloudKeyData _key, string _value)
    {
        Debug.Log("I I I ");
        Debug.Log(_value);
        switch (_key)
        {
            case ECloudKeyData.TotalKey:

                if (_value == null)
                {
                    Debug.Log("Data is not found in the cloud (first time)");
                    TotalKey = 0;
                }
                else if (Int32.TryParse(_value, out int _wholeNumber))
                {
                    Debug.Log("Data is found in the cloud ");
                    TotalKey = _wholeNumber;
                }
                break;
            default:
                Debug.Log("Algo deu errado");
                break;
        }
    }
}


