using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject plateDialog;
    public GameObject plateDialog2;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        HideDialogPlate2();
    }

    public void ShowDialogPlate()
    {
        plateDialog.SetActive(true);
    }

    public void HideDialogPlate()
    {
        plateDialog.SetActive(false);
    }

    public void ShowDialogPlate2()
    {
        plateDialog2.SetActive(true);
    }

    public void HideDialogPlate2()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            plateDialog2.SetActive(false);
        } 
    }

    public void LoadScene(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
