using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public static float fallSpeed = 1f;
    public static int value = 1;
    public static int gottem = 0;
    public static int missed = 0;
    public int count = 0;
    public static int highscore = 0;

    public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
        value = PlayerPrefs.GetInt("value");
		text.text = text.text.Remove(0, 1);
        if(value == 1)
        {
            text.color = Color.red;
        }
        if (value == 2)
        {
            text.color = Color.blue;
        }


    }

	public void RemoveWord ()
	{
        gottem = PlayerPrefs.GetInt("gottem");
        Destroy(gameObject);
        gottem++;
        PlayerPrefs.SetInt("gottem", gottem);
	}

	private void Update()
	{

        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        gottem = PlayerPrefs.GetInt("gottem");
        count = PlayerPrefs.GetInt("count");
        missed = count - gottem;
        PlayerPrefs.SetInt("missed", missed);
        if (gottem > highscore)
        {
            highscore = gottem;
        }
        PlayerPrefs.SetInt("highscore", highscore);

	}

}
