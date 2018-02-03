using UnityEngine;
using System.Collections;

public class spawnCoins : MonoBehaviour {

	public GameObject light;
	public GameObject enemy;
	public float[] lightHorizontalDis = new float[5] ;
	public float[] cubeHorizontalDis = new float[5] ;
	public bool down = true;


	private Vector2 originPosition;


	void Start () {
		lightHorizontalDis [0] = 12f;
		lightHorizontalDis [1] = 12f;
		lightHorizontalDis [2] = 12f;
		lightHorizontalDis [3] = 12f;
		lightHorizontalDis [4] = 12f;
		cubeHorizontalDis [0] = 12f;
		cubeHorizontalDis [1] = 12f;
		cubeHorizontalDis [2] = 12f;
		cubeHorizontalDis [3] = 12f;
		cubeHorizontalDis [4] = 12f;

		originPosition = transform.position;
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < lightHorizontalDis.Length; i++) {
			/*
			int coinFlip = Random.Range (0, 2);
			int change = Random.Range (0, 2);
			verticalDis [0] = 0f;
			if (down) {
				verticalDis [1] = 6f;
			}
			else {
				verticalDis [1] = -6f;
			}
			*/
			Vector2 randomPosition = originPosition + new Vector2 (lightHorizontalDis [i], 6f);
			//if (coinFlip > 0) {
			Instantiate (light, randomPosition, Quaternion.identity);
			originPosition = randomPosition + new Vector2 (0, -6f);
			/*
			if (change == 1) {
				down = !down;
			}
			*/
			/*
			}
			else {
				originPosition = originPosition + new Vector2(horizontalDis[i], 0f);
			}
		*/
		}
		for (int i = 0; i < cubeHorizontalDis.Length; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (cubeHorizontalDis[i], 0f);
			Instantiate (enemy, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}

}