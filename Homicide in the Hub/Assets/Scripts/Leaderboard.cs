﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class Leaderboard : MonoBehaviour
{

    public Text scoreGUI;
    public Text nameGUI;

    private List<string> testNameList;
    private List<int> testScoreList;

    private string scoreText;
    private string nameText;

    // Use this for initialization
    void Start()
    {
        string scoreText = "";
        string nameText = "";

        List<string> nameList = new List<string>();
        List<int> scoreList = new List<int>();
        using (StreamReader sr = new StreamReader("leaderboard.txt"))
        {
            while (sr.EndOfStream == false)
            {
                nameList.Add(sr.ReadLine());
                scoreList.Add(int.Parse(sr.ReadLine()));
            }
            sr.Close();
        }


        Debug.Log(nameList.Count.ToString());
        testNameList = new List<string>(nameList);
        testScoreList = new List<int>(scoreList);
        List<int> sortedScores = new List<int>(scoreList);
        sortedScores.Sort();
        sortedScores.Reverse();
        //Debug.Log (sortedScores [0]);
        foreach (int score in sortedScores)
        {
            Debug.Log(score);
            int scorePos = scoreList.IndexOf(score);
            Debug.Log(scorePos);
            scoreText = scoreText + scoreList[scorePos] + "\r\n";
            Debug.Log(scoreText);
            nameText = nameText + nameList[scorePos] + "\r\n";
            Debug.Log(nameText);
            scoreList.RemoveAt(scorePos);
            nameList.RemoveAt(scorePos);
        }
        if (scoreGUI != null)
        {
            scoreGUI.text = scoreText;
        }
        if (nameGUI != null)
        {
            nameGUI.text = nameText;
        }
    }

    public int GetScoreCount()
        {
            if (testScoreList != null)
            {
                return testScoreList.Count;
            }
            return 0;
        }

    public List<string> GetScoreNames()
        {
            if (testNameList != null)
            {
                return testNameList;
            }
            return new List<string>();
        }


    public List<int> GetScores()
        {
            if (testScoreList != null)
            {
                return testScoreList;
            }
            return new List<int>();
        }
    }

