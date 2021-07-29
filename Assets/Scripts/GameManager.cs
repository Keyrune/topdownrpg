using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {      
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }
    
    // Resources
    public List<Sprite> playerSprite;
    public List<Sprite> weaponSprite;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player player;
    // public Weapon weapon
    public FloatingTextManager floatingTextManager;

    // Logic
    public int gold;
    public int experience;

    // Floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    // Save state
    public void SaveState()
    /*
    INT skin
    INT gold
    INT experience
    INT weapon
    */
    {
        string s = "";

        s += "0" + "|";
        s += gold.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0" + "|";

        PlayerPrefs.SetString("SaveState", s);
        Debug.Log("SaveScene");
    }
    public void LoadState(Scene s, LoadSceneMode mode)
    {   
        SceneManager.sceneLoaded -= LoadState;

        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        // Change skin
        gold = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        // Change weapon

        Debug.Log("LoadScene");
    }
}
