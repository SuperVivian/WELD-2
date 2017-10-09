using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineControl : MonoBehaviour {

	Vector3 rotation;
	Vector3 lineDir;
	float changeToRotate;



	public float rotationMax;//这是发射器旋转的最大角度，初始发射方向向下；
	public Echange echange;//用户可以更改的值，挂载Echange脚本的物体。转动控制器机关。


	public int norSenceLayer;//需要建立一个碰撞后消失的场景层。
	public int mirrorLayer;//需要建立一个碰撞后反射的镜子层。
	public Target target;//目标靶



	Ray ray;


	 Vector3[] lineRander;
	 int lengthOfRender;

	LineRenderer lineShoot;

	private LayerMask mask;


	// Use this for initialization
	void Start () {

		this.transform.localEulerAngles += new Vector3(0, 0, 180);

		lineRander = new Vector3[100];

		changeToRotate = rotationMax / echange.changeMax;

		lineShoot = GetComponent<LineRenderer>();


		mask = (1 << norSenceLayer) | (1 << mirrorLayer);





	}
	
	// Update is called once per frame
	void Update () {


		this.transform.localEulerAngles = new Vector3(0, 0, echange.changeX * changeToRotate + 180);

		lineDir = this.transform.up;


		lengthOfRender = 0;
		lineRander[lengthOfRender] = this.transform.position;
		lengthOfRender++;


		rayLine();
		drawline();




	}


	private void rayLine()
	{
		ray.origin = this.transform.position;
		ray.direction = lineDir;
		RaycastHit hit;

		int nuber = 0;


		Physics.Raycast(ray, out hit, 1000f, mask);
		while(hit.transform.gameObject.layer==mirrorLayer&&nuber<7)
		{
			ray.origin = hit.point;

			if (Vector3.Angle(ray.direction, -hit.normal) > 3f)
			{
				
				//ray.direction = ray.direction + Mathf.Cos(Vector3.Angle(-ray.direction.normalized, hit.normal.normalized)) * hit.normal.normalized*2 ;

				ray.direction = Vector3.Dot(-ray.direction.normalized, hit.normal.normalized) * hit.normal.normalized * 2 + ray.direction;


			}
			else
			{
				ray.direction = -ray.direction;
			}
			lineRander[lengthOfRender] = hit.point;
			lengthOfRender++;
			Physics.Raycast(ray, out hit, 1000f, mask);

			nuber++;

		}



		if(hit.transform.gameObject.name == target.transform.gameObject.name)
		{

			target.open = true;

		}
		else
		{
			target.open = false;
		}


		

		lineRander[lengthOfRender] = hit.point;

		



	



	}




	private void drawline()
	{

		lineShoot.positionCount = lengthOfRender+1;
		for (int length = 0; length <= lengthOfRender; length++)
		{
			lineShoot.SetPosition(length, lineRander[length]);
		}


		lengthOfRender = 0;



	}






}

//射线发射器与射线绘制；挂在发射器上。镜子物体为一个很薄的盒子碰撞器，up方向为反射法线。
