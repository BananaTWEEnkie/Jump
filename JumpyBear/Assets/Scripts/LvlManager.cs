using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LvlManager : MonoBehaviour
{
	
    public static LvlManager Instance;
    public int score;
	public int saveScore;
    public Text TextObject, Winner, GameOver;
    private float m_timer = 0.0f;
    private List<Color> colors = new List<Color>();

    void Awake()
    {

        Instance = this;
    }

    void OnDestroy()
    {
        Instance = null;
    }
	
	// Use this for initialization
	void Start () {
        colors.Clear();
        SetColorList();
	}
	
	// Update is called once per frame
	void Update () {
		saveScore = score;
		PlayerPrefs.SetInt("PlayerScore",saveScore);
		
        m_timer += Time.deltaTime;
        if(TextObject != null)
        {
            TextObject.text = "Total score: " + score;
            if (m_timer >= 0.25f)
            {
                TextObject.color = grabColor();
                m_timer = 0.0f;
            }
        }
        
        
	}
    void SetColorList()
    {
        colors.Add(Color.gray);
        colors.Add(Color.green);
        colors.Add(Color.blue);
        colors.Add(Color.red);
        colors.Add(Color.cyan);
        colors.Add(Color.magenta);
        colors.Add(Color.white);
        colors.Add(Color.yellow);
    }
    Color grabColor()
    {
        int i = Random.Range(0, 8);
        return colors[i];
    }

    public void AddPoints(int points)
    {
        score += points;

        m_timer += Time.deltaTime;
        if (TextObject != null)
        {
            if (score >= 25)
            {
                Application.LoadLevel("GameOver");
                //Winner.text = "WINNER!";
            }
        }
    }

    public void BadMama(int points)
    {
        points = 10;

        score -= points;

        m_timer += Time.deltaTime;
        if (TextObject != null)
        {
            if (score < 0)
            {
                Application.LoadLevel("GameOver");
                //GameOver.text = "GAME OVER";
            }
        }


    }
}
