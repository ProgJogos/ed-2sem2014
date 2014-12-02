using UnityEngine;
using System.Collections;

public interface IEstado
{
	void Update();
	IEstado TratarInputs();
	void Entrar();
	void Sair();
}

[System.Serializable]
public class Parado : IEstado
{
	public void Update(){}
	public void Entrar() {}
	public void Sair() {}
	
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

	public void Entrar() {}
	public void Sair() {}

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

	public void Entrar() {
		this.velocidade = 5f;
	}
	public void Sair() {}

	public void Update()
	{
		Vector2 direcao = new Vector2(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical"));
		if(direcao.magnitude > 0)
			GameObject.Find("Jogador").transform.right = direcao;
		GameObject.Find("Jogador").
			transform.Translate(
				direcao * velocidade * Time.deltaTime, Space.World);
	}
	
	public virtual IEstado TratarInputs()
	{
		if (Input.GetAxis("Horizontal") == 0 &&
			Input.GetAxis("Vertical") == 0)
		{
			return new Parado();
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			return new Correr();
		}

		return this;
	}
}

public class Correr : Andar 
{

	public void Entrar() {
		this.velocidade = 15f;
	}

	public void Sair() {}

	override public IEstado TratarInputs() 
	{
		if (Input.GetAxis("Horizontal") == 0 &&
		    Input.GetAxis("Vertical") == 0 && 
		    !Input.GetKey(KeyCode.C))
		{
			return new Parado();
		}


		if (Input.GetKeyUp(KeyCode.C))
		{
			return new Andar();
		}

		return this;
	}
}
