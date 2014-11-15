using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AviaoController : MonoBehaviour {


	public Vector2 movimento = new Vector2(0.0f,1.0f);

	public KeyCode jumpKey = KeyCode.Space;

	public GameObject gameover;

	public Text pontuacaoTexto;
	int pontuacao = 0;

	bool canControl = true;

	void FixedUpdate () {

		pontuacaoTexto.text = pontuacao.ToString();

		if(Input.GetKeyDown(jumpKey) && canControl)
		{
			rigidbody2D.velocity = movimento;
		}
	}

	void OnCollisionEnter2D(Collision2D colisao)
	{
		gameover.SetActive(true);
		canControl = false;
		//Time.timeScale = 0.0f; 	
	}

	public void tryAgain()
	{
		Application.LoadLevel(0);
	}

	public void OnTriggerExit2D(Collider2D col)
	{
		pontuacao++;
	}

}
