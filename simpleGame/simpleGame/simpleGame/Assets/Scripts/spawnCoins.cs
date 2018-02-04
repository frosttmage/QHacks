using UnityEngine;
using System.Collections;

public class spawnCoins : MonoBehaviour {

	public int maxCoins = 5000;
	public GameObject coinSprite;
	public float horizontalDis = 10f;
	public float[] verticalDis = new float[2];
	public bool down = true;


	private Vector2 originPosition;


	void Start () {

		originPosition = transform.position;
		Spawn ();

	}

	void Spawn()
	{
		for (int i = 0; i < maxCoins; i++)
		{
			int coinFlip = Random.Range (0, 2);
			int change = Random.Range (0, 2);
			verticalDis [0] = 0f;
			if (down) {
				verticalDis [1] = 6f;
			}
			else {
				verticalDis [1] = -6f;
			}
			Vector2 randomPosition = originPosition + new Vector2 (horizontalDis, verticalDis[change]);
			if (coinFlip > 0) {
				Instantiate (coinSprite, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
				if (change == 1) {
					down = !down;
				}
			}
			else {
				originPosition = originPosition + new Vector2(horizontalDis, 0f);
			}
		}
	}

}