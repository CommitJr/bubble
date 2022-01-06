using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataFile
{
    private SaveData GameData;
    public SaveDataFile()
    {
        SaveData GameData = new SaveData();

        for (int i = 5; i > 0; i--)
        {
            World WolrdAdds = new World();
            WolrdAdds.SetId(i);
            WolrdAdds.SetName("Camada " + i);
            if (i == 5)
            {
                WolrdAdds.SetStatus(true);
            }
            else
            {
                WolrdAdds.SetStatus(false);
            }          
            WolrdAdds.SetNumberLevels(10);
            WolrdAdds.SetUnlockedLevels(1);

            for (int j = 0; j < 10; j++)
            {
                Level LevelAdds = new Level();
                               
                LevelAdds.SetId(j);
                if (i == 5 && j == 0)
                {
                    LevelAdds.SetName("Tutorial");
                    LevelAdds.SetStatus(true);
                    LevelAdds.SetPlayerScore(3);
                }
                else
                {
                    if (i == 5)
                    {
                        LevelAdds.SetName("Fase " + i + "_" + (j));
                        LevelAdds.SetStatus(false);
                        LevelAdds.SetPlayerScore(0);
                    }
                    else {
                        LevelAdds.SetName("Fase " + i + "_" + (j + 1));
                        LevelAdds.SetStatus(false);
                        LevelAdds.SetPlayerScore(0);
                    }
                    
                }

                WolrdAdds.AddLevel(LevelAdds);
            }

            GameData.AddWorld(WolrdAdds);
        }

        this.GameData = GameData;
    }

    public SaveData GetGameData()
    {
        return this.GameData;
    }
}
