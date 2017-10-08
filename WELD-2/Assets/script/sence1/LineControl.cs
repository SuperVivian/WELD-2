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



	 Vector3[] lineRander;
	 int lengthOfRender;

	LineRenderer lineShoot;


	// Use this for initialization
	void Start () {

		this.transform.localEulerAngles += new Vector3(0, 0, 180);



		changeToRotate = -rotationMax / echange.changeMax;

		lineShoot = GetComponent<LineRenderer>();

		lengthOfRender = 0;

	}
	
	// Update is called once per frame
	void Update () {
		changeFirstCube();
		drawline();

	}


	private void changeFirstCube()
	{


		lineDir = new Vector3(0, 0, echange.changeX * changeToRotate) + new Vector3(0, 0, 180);
		this.transform.localEulerAngles = lineDir;






	}

	private void drawline()
	{
		for (int length = 0; length < lengthOfRender; length++)
			lineShoot.SetPosition(length, lineRander[length]);
	}


}

//射线发射器与射线绘制；挂在发射器上。镜子物体为一个很薄的盒子碰撞器，up方向为反射法线。
