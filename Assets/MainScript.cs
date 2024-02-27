using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    public int score = 0;
    public float highscore = 0;
    public float played = 0;

    float[] array = new float[18];
 


    void Awake()
    {

       

    }


    void Start()
    {
        float HighestScore = 0;
        //float GamePlayed = 0;

        if (PlayerPrefs.HasKey("High") == true)
        {
            
            HighestScore = PlayerPrefs.GetFloat("High");
        }
        else
        {
          
            PlayerPrefs.SetFloat("High", 0f);
        }

        highscore = HighestScore;

        //----------------------------------------------
        if (PlayerPrefs.HasKey("Play") == true)
        {
            played = PlayerPrefs.GetFloat("Play") + 1;
            PlayerPrefs.SetFloat("Play", played);
        }
        else
        {
            print("false");
            PlayerPrefs.SetFloat("Play", 1f);
        }
        //--------------------------------------------------
        /*
        if (PlayerPrefs.HasKey("Array1") == true)
        {
            array[1] = PlayerPrefs.GetFloat("Array1");
        }
        else
        {
            print("false");
            PlayerPrefs.SetFloat("Array1", 0f);
        }
        */

        array[0] = PlayerPrefs.GetFloat("Array0");
        array[1] = PlayerPrefs.GetFloat("Array1");
        array[2] = PlayerPrefs.GetFloat("Array2");
        array[3] = PlayerPrefs.GetFloat("Array3");
        array[4] = PlayerPrefs.GetFloat("Array4");
        array[5] = PlayerPrefs.GetFloat("Array5");
        array[6] = PlayerPrefs.GetFloat("Array6");
        array[7] = PlayerPrefs.GetFloat("Array7");
        array[8] = PlayerPrefs.GetFloat("Array8");
        array[9] = PlayerPrefs.GetFloat("Array9");
        array[10] = PlayerPrefs.GetFloat("Array10");
        array[11] = PlayerPrefs.GetFloat("Array11");
        array[12] = PlayerPrefs.GetFloat("Array12");
        array[13] = PlayerPrefs.GetFloat("Array13");
        array[14] = PlayerPrefs.GetFloat("Array14");
        array[15] = PlayerPrefs.GetFloat("Array15");
        array[16] = PlayerPrefs.GetFloat("Array16");
        array[17] = PlayerPrefs.GetFloat("Array17");

    }


    void Update()
    {


        if (Input.GetKey("2"))
        {
            score = score + 10;
        }

        if (Input.GetKey("1"))
        {
            score = score - 10;
        }

        if (Input.GetKey("0"))
        {
            score = 0;
            highscore = 0;
            PlayerPrefs.SetFloat("High", 0f);
        }

        if (Input.GetKey("9"))
        {
            PlayerPrefs.SetFloat("Array0", 0);
            PlayerPrefs.SetFloat("Array1", 0);
            PlayerPrefs.SetFloat("Array2", 0);
            PlayerPrefs.SetFloat("Array3", 0);
            PlayerPrefs.SetFloat("Array4", 0);
            PlayerPrefs.SetFloat("Array5", 0);
            PlayerPrefs.SetFloat("Array6", 0);
            PlayerPrefs.SetFloat("Array7", 0);
            PlayerPrefs.SetFloat("Array8", 0);
            PlayerPrefs.SetFloat("Array9", 0);
            PlayerPrefs.SetFloat("Array10", 0);
            PlayerPrefs.SetFloat("Array11", 0);
            PlayerPrefs.SetFloat("Array12", 0);
            PlayerPrefs.SetFloat("Array13", 0);
            PlayerPrefs.SetFloat("Array14", 0);
            PlayerPrefs.SetFloat("Array15", 0);
            PlayerPrefs.SetFloat("Array16", 0);
            PlayerPrefs.SetFloat("Array17", 0);
        }

        // -------------- NEW HIGHSCORE ----------------
        if (score >= highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("High", highscore);

            array[17] = highscore;
            Array.Sort(array);
            Array.Reverse(array);
            PlayerPrefs.SetFloat("Array0", array[0]);
            PlayerPrefs.SetFloat("Array1", array[1]);
            PlayerPrefs.SetFloat("Array2", array[2]);
            PlayerPrefs.SetFloat("Array3", array[3]);
            PlayerPrefs.SetFloat("Array4", array[4]);
            PlayerPrefs.SetFloat("Array5", array[5]);
            PlayerPrefs.SetFloat("Array6", array[6]);
            PlayerPrefs.SetFloat("Array7", array[7]);
            PlayerPrefs.SetFloat("Array8", array[8]);
            PlayerPrefs.SetFloat("Array9", array[9]);
            PlayerPrefs.SetFloat("Array10", array[10]);
            PlayerPrefs.SetFloat("Array11", array[11]);
            PlayerPrefs.SetFloat("Array12", array[12]);
            PlayerPrefs.SetFloat("Array13", array[13]);
            PlayerPrefs.SetFloat("Array14", array[14]);
            PlayerPrefs.SetFloat("Array15", array[15]);
            PlayerPrefs.SetFloat("Array16", array[16]);
            PlayerPrefs.SetFloat("Array17", array[17]);

        }
    }

    //debug text output
    private void OnGUI()
    {
        
     

        string text = "Score: " + score;
        string text2 = "Highscore: " + highscore;

        string text3 = "Played " + played + " times";

        string arraytext = "Highscores: <br " + array[0] + "<br " + array[1] + "<br " + array[2] + "<br " + array[3] + "<br " + array[4] + "<br " + array[5] + "<br " + array[6] + "<br " + array[7] + "<br " + array[8] + "<br " + array[9] + "<br " + array[10] + "<br " + array[11] + "<br " + array[12] + "<br " + array[13] + "<br " + array[14] + "<br " + array[15] + "<br " + array[16] + "<br " + array[17];
        //print(arraytext);
     

        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(650f, 50f, 1600f, 1600f));
        GUILayout.Label($"<size=50>{text}</size>    <size=50>{text2}</size>         <size=50>{text3}</size> ");
        GUILayout.EndArea();

        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(650f, 150f, 1600f, 1600f));
        GUILayout.Label($"<size=40>{arraytext}</size>");
        GUILayout.EndArea();
    }



}
