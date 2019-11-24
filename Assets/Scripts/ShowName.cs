using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayername;
    public Text wordsTyped;
    public Text cubeSpeed;
    public Text missedWords;
    public static int gottem;
    public static int missed;
    public static int count;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayername.text = PlayerName;
        cubeSpeed.text = "Speed: " + PlayerPrefs.GetFloat("SliderValue");        
        gottem = 0;
        PlayerPrefs.SetInt("gottem", gottem);
        missed = 0;
        PlayerPrefs.SetInt("missed", missed);
    }
    void Update()
    {
        wordsTyped.text = "Words Typed: " + PlayerPrefs.GetInt("gottem");
        missedWords.text = "Words Missed: " + PlayerPrefs.GetInt("missed");
    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        showPlayername.text = PlayerName;
    }
    public void ShowNameFun()
    {
        showPlayername.text = PlayerName;
    }
}
