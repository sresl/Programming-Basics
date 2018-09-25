using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour {

	int player = 1;
	string participant;
	//bool x;
	//bool y;
	bool x, y;
	float a, b;
	float c, d;
	float e, f;
	float g, h;
	float i, j;

	// Use this for initialization
	void Start ()
	{

	//variablen declarieren
	bool muede;
	float score;
	char category;
	byte none;
	long none1;
	short none2;
	double none3;

	addOne();
	setName();
	testBool();
	Multiply();
	Division();
	Restwert();
	Addition();
	Subtraction();
	int test = getNumber();
	Debug.Log(test);
	Debug.Log("-------------------------------");
	Debug.Log(getNumber());

	}

	void Multiply ()

	{
	a = 5;
	b = 2;
	
	Debug.Log("a*b = " + (a*b));

	}

	void Division ()

	{
	c = 10;
	d = 2;

	Debug.Log("c/d = " + (c/d));
	}

	void Restwert ()

	{
	e = 10;
	f = 5;

	Debug.Log("e%f = " + (e%f));
	}

	void Addition ()

	{
	g = 5;
	h = 10;

	Debug.Log("g+h = " + (g+h));
	}

	void Subtraction ()

	{
	i = 10;
	j = 8;

	Debug.Log("i-j = " + (i-j));
	}


	void testBool()

	{
	x = true;
	y = true;

	Debug.Log("T oder F " + (x&&y));
	Debug.Log("Bedingt T oder F " + (x && y));
	}
	
	void setName()
	{
	participant = "Max Mustermann";
	Debug.Log(participant);
	}

	void addOne() 
	{
	player = player + 1;
	Debug.Log("player = "+ player);
	}

	int getNumber ()
	{
	return 5;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
