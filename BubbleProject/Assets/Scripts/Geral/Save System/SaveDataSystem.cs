using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System;

public static class SaveDataSystem
{
    private static string PathJson = Application.persistentDataPath + "/GameData.json";
    private static string PathXml = Application.persistentDataPath + "/GameData.xml";
    public static void SaveXml(SaveData GameData)
    {
        XElement Writer = new XElement("DataSave");

        Writer.Add(new XElement("Game", new XAttribute("Version", GameData.GetGameVersion())));
        Writer.Add(new XElement("Player", new XAttribute("Health", GameData.GetPlayerHealth())));
        Writer.Add(new XElement("Worlds", new XAttribute("NumberWorlds", GameData.GetNumberWorlds())));
        Writer.Element("Worlds").Add(new XAttribute("UnlockedWorlds", GameData.GetUnlockedWorlds()));

        int WolrdIndice = 5;
        foreach (World WorldData in GameData.GetWorlds())
        {
            XElement WorldAdd = new XElement("Wolrd" + WolrdIndice);
            WorldAdd.Add(new XAttribute("Id", WorldData.GetId()));
            WorldAdd.Add(new XAttribute("Name", WorldData.GetName()));
            WorldAdd.Add(new XAttribute("Status", WorldData.GetStatus()));
            WorldAdd.Add(new XElement("Levels", new XAttribute("NumberLevels", WorldData.GetNumberLevels())));
            WorldAdd.Element("Levels").Add(new XAttribute("UnlockedLevels", WorldData.GetUnlockedLevels()));

            int LevelIndice = 0;
            foreach (Level LevelData in WorldData.GetLevels())
            {
                XElement LevelAdd = new XElement("Level"+LevelIndice);
                LevelAdd.Add(new XAttribute("Id", LevelData.GetId()));
                LevelAdd.Add(new XAttribute("Name", LevelData.GetName()));
                LevelAdd.Add(new XAttribute("Status", LevelData.GetStatus()));
                LevelAdd.Add(new XAttribute("PlayerScore", LevelData.GetPlayerScore()));

                WorldAdd.Element("Levels").Add(new XElement(LevelAdd));

                LevelIndice++;
            }

            Writer.Element("Worlds").Add(new XElement(WorldAdd));

            WolrdIndice--;
        }

        Writer.Save(PathXml);
    }

    public static void SaveJson(SaveData saveData)
    {
        string json = JsonUtility.ToJson(saveData);

        using (StreamWriter streamWriter = new StreamWriter(PathJson))
        {
            streamWriter.Write(json);
        }

        if (UnitySave.Instance.isOnline)
            UnitySave.Instance.SaveCloudData(json);
    }

    public static SaveData LoadXml()
    {
        try
        {
            SaveData GameData = new SaveData();

            if (!File.Exists(PathXml))
            {
                //Debug.LogWarning("GameData não Existe em: " + Path + " | Gerando um Novo GameData.");

                SaveDataFile GameDataFile = new SaveDataFile();
                SaveXml(GameDataFile.GetGameData());

                return GameDataFile.GetGameData();
            }

            XElement Reader = XElement.Load(PathXml);

            GameData.SetGameVersion(Reader.Element("Game").Attribute("Version").Value);
            GameData.SetPlayerHealth(int.Parse(Reader.Element("Player").Attribute("Health").Value));
            GameData.SetNumberWorlds(int.Parse(Reader.Element("Worlds").Attribute("NumberWorlds").Value));
            GameData.SetUnlockedWorlds(int.Parse(Reader.Element("Worlds").Attribute("UnlockedWorlds").Value));

            XElement WorldReader = Reader.Element("Worlds");
            foreach (var Worlds in WorldReader.Elements())
            {
                World WorldData = new World();

                WorldData.SetId(int.Parse(Worlds.Attribute("Id").Value));
                WorldData.SetName(Worlds.Attribute("Name").Value);
                WorldData.SetStatus(bool.Parse(Worlds.Attribute("Status").Value));
                WorldData.SetNumberLevels(int.Parse(Worlds.Element("Levels").Attribute("NumberLevels").Value));
                WorldData.SetUnlockedLevels(int.Parse(Worlds.Element("Levels").Attribute("UnlockedLevels").Value));

                XElement LevelReader = Worlds.Element("Levels");
                foreach (var Levels in LevelReader.Elements())
                {
                    Level LevelData = new Level();

                    LevelData.SetId(int.Parse(Levels.Attribute("Id").Value));
                    LevelData.SetName(Levels.Attribute("Name").Value);
                    LevelData.SetStatus(bool.Parse(Levels.Attribute("Status").Value));
                    LevelData.SetPlayerScore(int.Parse(Levels.Attribute("PlayerScore").Value));

                    WorldData.AddLevel(LevelData);
                }

                GameData.AddWorld(WorldData);
            }

            //Debug.Log("GameData Carregado com Sucesso.");

            return GameData;
        }
        catch(Exception e)
        {
            Debug.Log(e);
            return null;
        }
    }
    public static SaveData LoadJson()
    {
        string json;
        SaveData saveData;

        if (!File.Exists(PathJson))
        {
            //Debug.LogWarning("GameData não Existe em: " + Path + " | Gerando um Novo GameData.");

            SaveDataFile GameDataFile = new SaveDataFile();
            SaveJson(GameDataFile.GetGameData());

            return GameDataFile.GetGameData();
        }

        using (StreamReader streamReader = new StreamReader(Application.persistentDataPath + "/GameData.json"))
        {
            json = streamReader.ReadToEnd();
        }
        
        saveData = JsonUtility.FromJson<SaveData>(json);

        return saveData;
    }
}
