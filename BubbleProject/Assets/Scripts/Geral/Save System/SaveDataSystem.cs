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

            World WolrdAdd = new World();
            WolrdAdd.SetId(5);
            WolrdAdd.SetName("Camada 5");
            WolrdAdd.SetStatus(true);
            WolrdAdd.SetNumberLevels(10);
            WolrdAdd.SetUnlockedLevels(1);
            WolrdAdd.AddLevel(LevelAdd);

            GameData.AddWorld(WolrdAdd);

            Save(GameData);

            return GameData;
        }

        XElement Reader = XElement.Load(Path);

        GameData.SetGameVersion(Reader.Element("Game").Attribute("Version").Value);
        GameData.SetPlayerHealth(int.Parse(Reader.Element("Player").Attribute("Health").Value));
        GameData.SetNumberWorlds(int.Parse(Reader.Element("Worlds").Attribute("NumberWorlds").Value));
        GameData.SetUnlockedWorlds(int.Parse(Reader.Element("Worlds").Attribute("UnlockedWorlds").Value));

        foreach (var Worlds in Reader.Descendants("Worlds"))
        {
            World WorldData = new World();

            WorldData.SetId(int.Parse(Worlds.Attribute("Id").Value));
            WorldData.SetName(Worlds.Attribute("Name").Value);
            WorldData.SetStatus(bool.Parse(Worlds.Attribute("Status").Value));
            WorldData.SetNumberLevels(int.Parse(Worlds.Element("Levels").Attribute("NumberLevels").Value));
            WorldData.SetUnlockedLevels(int.Parse(Worlds.Element("Levels").Attribute("UnlockedLevels").Value));

            foreach (var Levels in Worlds.Descendants("Levels"))
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

        Debug.Log("GameData Carregado com Sucesso.");
        return GameData;
    }
}
