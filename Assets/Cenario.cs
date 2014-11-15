using UnityEngine;
using System.Collections;

public class Cenario : MonoBehaviour {

    //Prefab do obstaculo
	public GameObject prefab;

    //Intervalo entre novos obstaculos
	public float intervalo = 2.0f;

    //Valores mínimos e máximos para a posição no Eixo Y do obstaculo
	public float min = -3;
	public float max = 3;

	void Start () {
        //Inicia repetição da criação de obstaculos
		InvokeRepeating("criarObstaculo", 1.0f, intervalo);
	}
	
    //Instancia novo objeto
	void criarObstaculo()
	{
		GameObject obj = Instantiate(prefab) as GameObject;

        //Randomiza a posicao Y do obstaculo
		obj.transform.position = new Vector2(obj.transform.position.x,Random.Range(min,max));
	}
}
