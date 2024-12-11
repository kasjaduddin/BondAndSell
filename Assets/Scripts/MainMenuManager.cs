using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject chooseChapterPage;
    public GameObject achievementPage;
    public GameObject creditPage;
    public GameObject quitButton;
    public GameObject backButton;
    public TextMeshProUGUI title;
    
    // Start is called before the first frame update
    void Start()
    {
        OpenMainMenu();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FontSizeDown()
    {
        title.fontSize = 96;
    }

    private void FontSizeUp()
    {
        title.fontSize = 128;
    }

    public void OpenMainMenu()
    {
        
        FontSizeUp();
        mainPage.SetActive(true);
        chooseChapterPage.SetActive(false);
        achievementPage.SetActive(false);
        creditPage.SetActive(false);
        backButton.SetActive(false);
    }

    public void OpenChooseChapter()
    {
        FontSizeDown();
        mainPage.SetActive(false);
        chooseChapterPage.SetActive(true);
    }

    public void OpenAchievement()
    {
        FontSizeDown();
        mainPage.SetActive(false);
        achievementPage.SetActive(true);
    }

    public void OpenCredit()
    {
        FontSizeDown();
        mainPage.SetActive(false);
        creditPage.SetActive(true);
    }

    public void HoverChapterOne()
    {
        title.text = "Chapter 1: First Impressions Matter";
    }

    public void HoverChapterTwo()
    {
        title.text = "Coming Soon...";
    }
}
