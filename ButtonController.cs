using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public static ButtonController instance;
    public Animator anim;
    public Button lockButton;
    public Button unlockButton;
    public bool locked;

    public GameObject helpPanel;
    public GameObject compass;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Size1()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size1");
    }
    public void Size2()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size2");
    }
    public void Size3()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size3");
    }
    public void Size4()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size4");
    }
    public void Size5()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size5");
    }
    public void Size6()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size6");
    }
    public void Size7()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size7");
    }
    public void Size8()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size8");
    }
    public void Size9()
    {
        WoodMove.instance.line.emitting = false;
        anim.Play("size9");
    }

    public void LockButton()
    {
        lockButton.gameObject.SetActive(false);
        unlockButton.gameObject.SetActive(true);
        locked = false;
    }

    public void UnlockButton()
    {
        unlockButton.gameObject.SetActive(false);
        lockButton.gameObject.SetActive(true);
        locked = true;
    }

    public void HelpButton()
    {
        helpPanel.gameObject.SetActive(true);
        compass.gameObject.SetActive(false);
    }
    public void BackMenu()
    {
        compass.gameObject.SetActive(true);
        helpPanel.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DrawLine()
    {
        SceneManager.LoadScene("DrawLine");
    }

    public void Compass()
    {
        SceneManager.LoadScene("Compass");
    }
    

}
