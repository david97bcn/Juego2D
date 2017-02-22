using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterMenu : MonoBehaviour {

    public Button achievementButton;
    public Button characterButton;
    public Button rankingButton;
    public Button infoButton;
    public Button retryButton;

    public Button configButton;

    public GameObject characterSelector;

	// Use this for initialization
	void Start () {
        Button achievementbtn = achievementButton.GetComponent<Button>();
        achievementbtn.onClick.AddListener(achievementClick);
        Button characterbtn = characterButton.GetComponent<Button>();
        characterbtn.onClick.AddListener(characterClick);
        Button rankingbtn = rankingButton.GetComponent<Button>();
        rankingbtn.onClick.AddListener(rankingClick);
        Button infobtn = infoButton.GetComponent<Button>();
        infobtn.onClick.AddListener(infoClick);
        Button configbtn = configButton.GetComponent<Button>();
        configbtn.onClick.AddListener(configClick);
        Button retrybtn = retryButton.GetComponent<Button>();
        retrybtn.onClick.AddListener(retryClick);

	}
	
    void achievementClick()
    {
        Debug.Log("Achievement Click");
    }

    void characterClick()
    {
        Debug.Log("Character Click");
        characterSelector.SetActive(true);
    }

    void rankingClick()
    {
        Debug.Log("Ranking Click");
    }

    void infoClick()
    {
        Debug.Log("Info Click");
    }

    void configClick()
    {
        Debug.Log("Config Click");
    }

    void retryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
