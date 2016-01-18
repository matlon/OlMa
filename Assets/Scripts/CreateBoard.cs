using UnityEngine;
using System.Collections;

public class CreateBoard : MonoBehaviour {

	private const int WATER = 0, GROUNDCUBE = 1;

	public GameObject[] Prefabs;
	public PieceHandler ph;

	private int[,] matrixTemplate;
	private Block[,] groundMatrix;

	// Use this for initialization
	void Start () {
		matrixTemplate = new int[,]
		{
			{1,1,1,2,2,2,2,2},
			{1,1,1,0,0,2,2,1},
			{1,1,1,0,0,1,1,1},
			{1,1,1,1,1,1,1,1},
			{1,1,1,1,1,1,1,1},
			{1,1,1,0,0,1,1,1},
			{1,1,1,0,0,2,1,1},
			{1,1,1,1,1,2,1,1}
		};

		groundMatrix = new Block[matrixTemplate.GetUpperBound(0)+1,matrixTemplate.GetUpperBound(1)+1];
		ph = GameObject.Find("GlobalManager").GetComponent<PieceHandler>();


		CreateGround(matrixTemplate);

		ph.SaveBoard(groundMatrix, matrixTemplate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateGround(int[,] m)
	{
		for (int i = 0; i <= m.GetUpperBound(0); i++)
		{
			for (int j = 0; j <= m.GetUpperBound(1); j++)
			{
				CreateAtLocation(matrixTemplate[i, j], i, j);
			}
		}
	}

	void CreateAtLocation(int groundType, int posX, int posZ)
	{
		GameObject temp = (GameObject) Instantiate(Prefabs[groundType], new Vector3(posX, 0, posZ), Quaternion.identity);
		groundMatrix[posX,posZ] = temp.GetComponent<Block>();
	}
}
