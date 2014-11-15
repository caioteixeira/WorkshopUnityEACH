using UnityEngine;
using System.Collections;

public class Cenario : MonoBehaviour {


	public GameObject prefab;
	public float intervalo = 2.0f;

	public float min = -3;
	public float max = 3;

	void Start () {
		InvokeRepeating("criarObstaculo", 1.0f, intervalo);
	}
	
	void criarObstaculo()
	{
		GameObject obj = Instantiate(prefab) as GameObject;
		obj.transform.position = new Vector2(obj.transform.position.x,Random.Range(min,max));
	}
}
