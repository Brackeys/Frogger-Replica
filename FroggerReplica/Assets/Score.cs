using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;

	public Text scoreText;

	void Start ()
	{
		scoreText.text = CurrentScore.ToString();
	}

}
