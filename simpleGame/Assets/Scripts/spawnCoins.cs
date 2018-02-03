using UnityEngine;
using System.Collections;

public class spawnCoins : MonoBehaviour {

	public GameObject light;
	public GameObject enemy;
	public float[] lightHorizontalDis = new float[5] ;
	public float[] cubeHorizontalDis = new float[5] ;
	public float[] lightVerticalDis = new float[5] ;
	public float[] cubeVerticalDis = new float[5] ;
	public float[] vertical = new float[2];
	public bool down = true;


	private Vector2 originPosition;


	void Start () {
		lightHorizontalDis [0] = 6f;
		lightHorizontalDis [1] = 6f;
		lightHorizontalDis [2] = 20f;
		lightHorizontalDis [3] = 6f;
		lightHorizontalDis [4] = 6f;
		cubeHorizontalDis [0] = 6f;
		cubeHorizontalDis [1] = 12f;
		cubeHorizontalDis [2] = 6f;
		cubeHorizontalDis [3] = 6f;
		cubeHorizontalDis [4] = 6f;

		lightVerticalDis [0] = 3f;
		lightVerticalDis [1] = 2f;
		lightVerticalDis [2] = -7f;
		lightVerticalDis [3] = 3f;
		lightVerticalDis [4] = 3f;
		cubeVerticalDis [0] = -3f;
		cubeVerticalDis [1] = -6f;
		cubeVerticalDis [2] = -1.5f;
		cubeVerticalDis [3] = -8f;
		cubeVerticalDis [4] = -4f;

		originPosition = transform.position;
		Spawn ();
	}

	void Spawn()
	{
		for (int i = 0; i < lightHorizontalDis.Length; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (lightHorizontalDis [i], lightVerticalDis[i]);
			Instantiate (light, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
			randomPosition = originPosition + new Vector2 (cubeHorizontalDis[i], cubeVerticalDis[i]);
			Instantiate (enemy, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
		originPosition = originPosition + new Vector2 (40f, -20f);
		/*
		for (int i = 0; i < cubeHorizontalDis.Length; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (cubeHorizontalDis[i], 0f);
			Instantiate (enemy, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
		*/
	}

}