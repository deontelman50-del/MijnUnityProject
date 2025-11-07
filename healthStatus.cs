using JetBrains.Annotations;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    public int score = 100;
    public int health = 75;
    public string playerName = "deon";
    public bool hasKey = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (health > 80)
        {
            Debug.Log("exelent health");
        }
        else if (health > 50)
        {
            Debug.Log("good health");
        }
        else if (health > 20)
        {
            Debug.Log("verry low health");
        }
        else if (health > 0)
        {
            Debug.Log("game over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
