using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class Serialization {

    public static int  level;
    public static int[] maxScores = new int[20];

    public static void Save() {
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.dat");

        PlayerData data = new PlayerData();
        data.level = level;
        data.maxScores = maxScores;

		bf.Serialize(file, data);
		file.Close();
	}   
	
	public static void Load() {
		if(File.Exists(Application.persistentDataPath + "/savedGames.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.dat", FileMode.Open);
			PlayerData data = (PlayerData) bf.Deserialize(file);
			file.Close();
            level = data.level;
            maxScores = data.maxScores;
		}

        else
            level = 0;
	}
}

[System.Serializable]
class PlayerData
{
    public int level;
    public int[] maxScores = new int[20];
}