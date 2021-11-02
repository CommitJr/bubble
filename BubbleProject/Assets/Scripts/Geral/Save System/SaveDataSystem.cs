using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Xml.Linq;

public static class SaveDataSystem
{
    public static void Save(SaveData GameData)
    {
        string Path = Application.persistentDataPath + "/GameData.xml";

        XElement Writer = new XElement("DataSave");

        Writer.Add(new XElement("Game", new XAttribute("Version", GameData.GetGameVersion())));
        Writer.Add(new XElement("Player", new XAttribute("Health", GameData.GetPlayerHealth())));

        int WolrdIndice = 5;
        foreach (Wolrd WolrdData in GameData.GetWorlds())
        {
            XElement WolrdAdd = new XElement("Wolrd" + WolrdIndice);
            WolrdAdd.Add(new XAttribute("Id", WolrdData.GetId()));
            WolrdAdd.Add(new XAttribute("Name", WolrdData.GetName()));
            WolrdAdd.Add(new XAttribute("Status", WolrdData.GetStatus()));

            int LevelIndice = 0;
            foreach (Level LevelData in WolrdData.GetLevels())
            {
                XElement LevelAdd = new XElement("Level"+LevelIndice);
                LevelAdd.Add(new XAttribute("Id", LevelData.GetId()));
                LevelAdd.Add(new XAttribute("Name", LevelData.GetName()));
                LevelAdd.Add(new XAttribute("Status", LevelData.GetStatus()));
                LevelAdd.Add(new XAttribute("PlayerScore", LevelData.GetPlayerScore()));

                WolrdAdd.Add(new XElement("Levels", LevelAdd));

                LevelIndice++;
            }

            Writer.Add(new XElement("Wolrds",WolrdAdd));

            WolrdIndice--;
        }

        Writer.Save(Path);
    }

    public static SaveData Load()
    {
        string Path = Application.persistentDataPath + "/GameData.xml";

        SaveData GameData = new SaveData();

        if (!File.Exists(Path))
        {
            Debug.LogWarning("GameData não Existe em: " + Path + " | Gerando um Novo GameData.");

            Level LevelAdd = new Level();
            LevelAdd.SetId(0);
            LevelAdd.SetName("Tutorial");
            LevelAdd.SetStatus(true);
            LevelAdd.SetPlayerScore(3);

            Wolrd WolrdAdd = new Wolrd();
            WolrdAdd.SetId(5);
            WolrdAdd.SetName("Camada 5");
            WolrdAdd.SetStatus(true);
            WolrdAdd.AddLevel(LevelAdd);

            GameData.AddWolrd(WolrdAdd);

            Save(GameData);

            return GameData;
        }

        XElement Reader = XElement.Load(Path);

        GameData.SetGameVersion(Reader.Element("Game").Attribute("Version").Value);
        GameData.SetPlayerHealth(int.Parse(Reader.Element("Player").Attribute("Health").Value));

        foreach (var Wolrds in Reader.Descendants("Wolrds"))
        {
            Wolrd WolrdData = new Wolrd();

            WolrdData.SetId(int.Parse(Wolrds.Attribute("Id").Value));
            WolrdData.SetName(Wolrds.Attribute("Name").Value);
            WolrdData.SetStatus(bool.Parse(Wolrds.Attribute("Status").Value));

            foreach (var Levels in Wolrds.Descendants("Levels"))
            {
                Level LevelData = new Level();

                LevelData.SetId(int.Parse(Levels.Attribute("Id").Value));
                LevelData.SetName(Levels.Attribute("Name").Value);
                LevelData.SetStatus(bool.Parse(Levels.Attribute("Status").Value));
                LevelData.SetPlayerScore(int.Parse(Levels.Attribute("PlayerScore").Value));

                WolrdData.AddLevel(LevelData);
            }

            GameData.AddWolrd(WolrdData);
        }

        Debug.Log("GameData Carregado com Sucesso.");
        return GameData;
    }
}
