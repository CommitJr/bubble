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
            switch (i)
            {
                case 1:
                    WolrdAdds.SetNumberLevels(1);

                    for (int j = 0; j < 1; j++)
                    {
                        Level LevelAdds = new Level();

                        LevelAdds.SetId(j);

                        LevelAdds.SetName("Fase " + i + "_" + (j + 1));

                        if (j == 0)
                        {
                            LevelAdds.SetStatus(true);
                        }
                        else
                        {
                            LevelAdds.SetStatus(false);
                        }
                        
                        LevelAdds.SetPlayerScore(0);

                        WolrdAdds.AddLevel(LevelAdds);
                    }
                    break;
                case 2:
                    WolrdAdds.SetNumberLevels(4);

                    for (int j = 0; j < 4; j++)
                    {
                        Level LevelAdds = new Level();

                        LevelAdds.SetId(j);

                        LevelAdds.SetName("Fase " + i + "_" + (j + 1));

                        if (j == 0)
                        {
                            LevelAdds.SetStatus(true);
                        }
                        else
                        {
                            LevelAdds.SetStatus(false);
                        }

                        LevelAdds.SetPlayerScore(0);

                        WolrdAdds.AddLevel(LevelAdds);
                    }
                    break;
                case 3:
                    WolrdAdds.SetNumberLevels(4);

                    for (int j = 0; j < 4; j++)
                    {
                        Level LevelAdds = new Level();

                        LevelAdds.SetId(j);

                        LevelAdds.SetName("Fase " + i + "_" + (j + 1));

                        if (j == 0)
                        {
                            LevelAdds.SetStatus(true);
                        }
                        else
                        {
                            LevelAdds.SetStatus(false);
                        }

                        LevelAdds.SetPlayerScore(0);

                        WolrdAdds.AddLevel(LevelAdds);
                    }
                    break;
                case 4:
                    WolrdAdds.SetNumberLevels(4);

                    for (int j = 0; j < 4; j++)
                    {
                        Level LevelAdds = new Level();

                        LevelAdds.SetId(j);

                        LevelAdds.SetName("Fase " + i + "_" + (j + 1));

                        if (j == 0)
                        {
                            LevelAdds.SetStatus(true);
                        }
                        else
                        {
                            LevelAdds.SetStatus(false);
                        }

                        LevelAdds.SetPlayerScore(0);

                        WolrdAdds.AddLevel(LevelAdds);
                    }
                    break;
                case 5:
                    WolrdAdds.SetNumberLevels(5);

                    for (int j = 0; j < 5; j++)
                    {
                        Level LevelAdds = new Level();

                        LevelAdds.SetId(j);
                        if (j == 0)
                        {
                            LevelAdds.SetName("Tutorial");
                            LevelAdds.SetStatus(true);
                            LevelAdds.SetPlayerScore(3);
                        }
                        else
                        {
                            LevelAdds.SetName("Fase " + i + "_" + (j));
                            LevelAdds.SetStatus(false);
                            LevelAdds.SetPlayerScore(0);
                        }

                        WolrdAdds.AddLevel(LevelAdds);
                    }
                    break;
            }
            
            WolrdAdds.SetUnlockedLevels(1);

            

            GameData.AddWorld(WolrdAdds);
        }

        this.GameData = GameData;
    }

    public SaveData GetGameData()
    {
        return this.GameData;
    }
}
