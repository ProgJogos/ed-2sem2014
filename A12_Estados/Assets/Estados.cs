using UnityEngine;
using System.Collections;

public interface IEstado
{
	void Update();
	IEstado TratarInputs();
}

[System.Serializable]
public class Parado : IEstado
{
	public void Update()
	{
		
	}
	
	public IEstado TratarInputs()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			return new Atirar();
		}
		
		if (Input.GetAxis("Horizontal") != 0 ||
			Input.GetAxis("Vertical") != 0)
		{
			return new Andar();
		}
		
		return this;
	}
}

[System.Serializable]
public class Atirar : IEstado
{
	public Transform origem;
	public Transform bala;
	public float velBala = 100f;
	public float frequencia = 0.5f;
	private float timer = 1f;
	
	public void Update()
	{
		timer += Time.deltaTime;
		if (timer > frequencia)
		{
			GameObject bala = GameObject.Instantiate(
				Resources.Load("Bala"),
				GameObject.Find("Jogador").transform.position,
				GameObject.Find("Jogador").transform.rotation) 
				as GameObject;
			bala.rigidbody2D.AddForce(
				bala.transform.right * velBala);
			Debug.Log("Atirou");
			timer = 0;
		}
	}
	
	public IEstado TratarInputs()
	{
		if (Input.GetKeyUp(KeyCode.X))
		{
			return new Parado();
		}
		return this;
	}
}

public class Andar : IEstado
{
	public float velocidade = 5f;

	public void Update()
	{
		Vector2 direcao = new Vector2(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"));
		GameObject.Find("Jogador").
			transform.Translate(direcao * velocidade * Time.deltaTime);
	}
	
	public IEstado TratarInputs()
	{
		if (Input.GetAxis("Horizontal") == 0 &&
			Input.GetAxis("Vertical") == 0)
		{
			return new Parado();
		}
		return this;
	}
}
