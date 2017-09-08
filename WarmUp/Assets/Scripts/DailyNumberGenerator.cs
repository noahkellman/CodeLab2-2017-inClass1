using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyNumberGenerator : NumberGenerator {

//you get random numbers, but you always get the same random numbers


	void Start () {
		Random.InitState(System.DateTime.Now.DayOfYear + 1);
	}
}
