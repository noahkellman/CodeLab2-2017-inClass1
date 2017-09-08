using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour {

	//the word "virtual" here means it can be overwritten by a subclass
	public virtual int Next(){
		return Random.Range(0, 4);

	}
}
