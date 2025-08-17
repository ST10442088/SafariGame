using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    
    int scoreIncrement = 5;
    int startScore = 0;
    public static Score currentInstance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        if(currentInstance == null)
        {
            currentInstance = this;
        }

        else
        {
            Destroy(currentInstance );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void AddScore(int scoreIncrement) 
  {
        scoreIncrement = this.scoreIncrement;
            startScore = startScore + scoreIncrement;
            scoreText.text = "Score: " + startScore;
        
  }


}
