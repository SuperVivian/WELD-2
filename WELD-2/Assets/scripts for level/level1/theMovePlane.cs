using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theMovePlane : MonoBehaviour {


	int NowJump;
	bool Nowback;
	Vector3 PositionOfMy;

	public float upTranslate;
	public float leftTranslate;
	public float downTranslate;

	public float moveSpeed;





	// Use this for initialization
	void Start () {

		NowJump = 0;

		PositionOfMy = this.transform.position;

		Nowback = false;
		
	}
	
	// Update is called once per frame
	void Update () {



		NowMove();
		
	}


	private void NowMove()
	{



		if (NowJump == 0)
		{
			if (Nowback)
			{
				if (this.transform.position.y <= PositionOfMy.y)
				{
					this.transform.position = PositionOfMy;
					NowJump++;
					Nowback = false;
				}
				else
				{
					this.transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
				}


			}
			else
			{
				if (this.transform.position.y >= PositionOfMy.y + upTranslate)
				{
					Nowback = true;

				}
				else
				{
					this.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
				}

			}
		}
		else if (NowJump == 1)
		{
			if (Nowback)
			{
				if (this.transform.position.x >= PositionOfMy.x)
				{
					this.transform.position = PositionOfMy;
					NowJump++;
					Nowback = false;
				}
				else
				{
					this.transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
				}


			}
			else
			{
				if (this.transform.position.x <= PositionOfMy.x - leftTranslate)
				{
					Nowback = true;

				}
				else
				{
					this.transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
				}

			}
		}
		else if (NowJump == 2)
		{

				if (Nowback)
				{
					if (this.transform.position.y >= PositionOfMy.y)
					{
						this.transform.position = PositionOfMy;
						NowJump = 0;
						Nowback = false;
					}
					else
					{
						this.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
					}


				}
				else
				{
					if (this.transform.position.y <= PositionOfMy.y - downTranslate)
					{
						Nowback = true;

					}
					else
					{
						this.transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
					}

				}
			

		}
	}
}
