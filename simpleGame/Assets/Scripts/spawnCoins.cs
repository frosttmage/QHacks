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
		lightHorizontalDis [0] = 6f;
		lightHorizontalDis [1] = 6f;
		lightHorizontalDis [2] = 6f;
		lightHorizontalDis [3] = 6f;
		lightHorizontalDis [4] = 6f;
		cubeHorizontalDis [0] = 6f;
		cubeHorizontalDis [1] = 6f;
		cubeHorizontalDis [2] = 6f;
		cubeHorizontalDis [3] = 6f;
		cubeHorizontalDis [4] = 6f;

		originPosition = transform.position;
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < lightHorizontalDis.Length; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (lightHorizontalDis [i], 6f);
			Instantiate (light, randomPosition, Quaternion.identity);
			originPosition = randomPosition + new Vector2 (0, -6f);
			Vector2 randomPosition2 = originPosition + new Vector2 (cubeHorizontalDis[i], 0f);
			Instantiate (enemy, randomPosition2, Quaternion.identity);
			originPosition = randomPosition2;
		}
		/*
		for (int i = 0; i < cubeHorizontalDis.Length; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (cubeHorizontalDis[i], 0f);
			Instantiate (enemy, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
		*/
	}

}