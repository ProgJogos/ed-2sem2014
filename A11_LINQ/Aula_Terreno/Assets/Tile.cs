using UnityEngine;
using System.Collections;

public enum EBioma
{
	AGUA,
	DESERTO,
	SAVANA,
	FLORESTA
}

[System.Serializable]
public class Tile 
{
	public int x;
	public int z;
	public EBioma bioma;
	public int temperatura;

	public Tile (int x, int z)
	{
		this.x = x;
		this.z = z;
		bioma = (EBioma) Random.Range (0, 4);
		temperatura = Random.Range(-10, 40);
	}
}
