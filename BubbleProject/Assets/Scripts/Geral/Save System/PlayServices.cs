using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi;
using GooglePlayGames;
using UnityEngine.UI;

public class PlayServices : MonoBehaviour
{
    private bool is_saving = false;
    private string SAVE_NAME;
    [SerializeField] InputField data_cloud;

    public void Start()
    {
        Initialize();
    }

    private string GetData2Store() // setando valores que serão storados, PEGAR DO ARQUIVO
    {
        string Data = "";
        Data += data_cloud.text;
        Data += " | ";
        return Data;
    }

    private void SaveUpdate(SavedGameRequestStatus status, ISavedGameMetadata meta)
    {
        // DEBUGS AQUI
        Debug.Log("deu bom");
    }

    private void LoadDataFromCloud(string save_data)
    {
        string[] data = save_data.Split(" | ");
        Debug.Log(data[0]);
    }

    private void ReadDataFromCloud(SavedGameRequestStatus status, byte[] data)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            string save_data = System.Text.ASCIIEncoding.ASCII.GetString(data);
            LoadDataFromCloud(save_data);
        }
    }

    private void SavedGameOpen(SavedGameRequestStatus status, ISavedGameMetadata meta)
    {
        if(status == SavedGameRequestStatus.Success)
        {
            if(is_saving) // tá salvando beleziha na nuvem
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(GetData2Store());
                SavedGameMetadataUpdate update = new SavedGameMetadataUpdate.Builder().Build();
                ((PlayGamesPlatform)Social.Active).SavedGame.CommitUpdate(meta, update, data, SaveUpdate);
            }
        }
        else // abrir da cloud
        {
            ((PlayGamesPlatform)Social.Active).SavedGame.ReadBinaryData(meta, ReadDataFromCloud);
        }

    }

    public void Initialize()
    {
        PlayGamesPlatform.Activate();
    }

    public void OpenSave2Cloud(bool save_game)
    {
        if (Social.localUser.authenticated)
        {
            is_saving = save_game;
            ((PlayGamesPlatform)Social.Active).SavedGame.OpenWithAutomaticConflictResolution(
                    SAVE_NAME, 
                    GooglePlayGames.BasicApi.DataSource.ReadCacheOrNetwork,
                    ConflictResolutionStrategy.UseLongestPlaytime, SavedGameOpen);
        }
    }

}
