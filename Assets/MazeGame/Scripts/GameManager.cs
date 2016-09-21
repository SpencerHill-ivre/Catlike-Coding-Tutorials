using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Maze mazePrefab;

    private Maze mazeInstance;

	void Start ()
    {
        BeginGame();
	}
	
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
	}

    void BeginGame()
    {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate());
    }

    void RestartGame()
    {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}
