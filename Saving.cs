using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[System.Serializable]
public class PlayerPosition{
    public float x;
    public float y;
    public float z;
}

public class SaveLoad
{
    private readonly static string path = "W:\\Unity\\God_please\\Assets\\PlayerPosition.json";
    public static void Save(PlayerPosition playerPosition){
        string json = JsonUtility.ToJson(playerPosition);
        File.WriteAllText(path, json);
        Debug.Log(json);
    }
    public static PlayerPosition Load(){
        string json = File.ReadAllText(path);
        PlayerPosition playerPosition = JsonUtility.FromJson<PlayerPosition>(json);
        return playerPosition;
    }
}

public class Saving : MonoBehaviour
{
    private InputHandler inputHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
        if (inputHandler == null){
            inputHandler = FindAnyObjectByType<InputHandler>();
        }
    }


    public void Save()
    {
        PlayerPosition playerPosition = new()
        {
            x = transform.position.x,
            y = transform.position.y,
            z = transform.position.z,
        };

        // string json = JsonUtility.ToJson(playerPosition);
        SaveLoad.Save(playerPosition);
    }

    public void Load(){
        PlayerPosition playerPosition = SaveLoad.Load();
        transform.position = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (inputHandler.saveState){
            Save();
        }
        if (inputHandler.loadState){
            Load();
        }
    }
}
