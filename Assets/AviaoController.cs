using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AviaoController : MonoBehaviour {

    //Vetor de força aplicada no avião
	public Vector2 movimento = new Vector2(0.0f,1.0f);

    //Tecla de pulo
	public KeyCode jumpKey = KeyCode.Space;

    //Referência para o canvas de gameover
	public GameObject gameover;

    //Referência para o UI Text de pontos
	public Text pontuacaoTexto;
	int pontuacao = 0;

    //Jogador pode controlar?
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
        gameOver();
	}

    public void OnBecameInvisible()
    {
        gameOver();
    }

    void gameOver()
    {
        gameover.SetActive(true);
        canControl = false;	
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
