using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorPickerButtonManager : MonoBehaviour {

    [SerializeField]
    private Text buttonText;

    [SerializeField]
    private Image bunnyPicture;

    private Color brownColor;
    private Color whiteColor;
    private Color yellowColor;
    private Color orangeColor;
    private Color grayColor;

    public static Color realBunnyColor;

    private bool buttonWasClicked;

    // Use this for initialization
    void Start ()
    {
        brownColor = new Color32(180, 101, 65, 255);
        whiteColor = new Color32(221, 225, 225, 225);
        yellowColor = new Color32(203, 147, 27, 255);
        orangeColor = new Color32(240, 125, 37, 255);
        grayColor = new Color32(0, 202, 135, 255);

        buttonWasClicked = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnBrownButtonClick()
    {
        buttonText.text = "Just a regular old brown bunny. I'm just kidding, this bunny's dope.";
        bunnyPicture.color = brownColor;
        buttonWasClicked = true;
        //make var to save color
    }

    public void OnWhiteButtonClick()
    {
        buttonText.text = "Do white bunnies get grass stains? Let's find out!";
        bunnyPicture.color = whiteColor;
        buttonWasClicked = true;
    }

    public void OnYellowButtonClick()
    {
        buttonText.text = "Are bunnies even yellow? Why not!";
        bunnyPicture.color = yellowColor;
        buttonWasClicked = true;
    }

    public void OnOrangeButtonClick()
    {
        buttonText.text = "This bunny is a little too orange. But we're not judging you.";
        bunnyPicture.color = orangeColor;
        buttonWasClicked = true;
    }

    public void OnGreyButtonClick()
    {
        buttonText.text = "This bunny got bit by a radioactive bug.";
        bunnyPicture.color = grayColor;
        buttonWasClicked = true;
    }

    public void OnConfirmButtonClick()
    {
        if (!buttonWasClicked)//if you haven't chosen a color
        {
            buttonText.text = "Please choose a color.";
        }
        else
        {
            realBunnyColor = bunnyPicture.color;//save the color that was picked
            SceneManager.LoadScene("LoadingScene");//load scene while real scene is being prepared
        }
    }
}
