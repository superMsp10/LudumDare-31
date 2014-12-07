using UnityEngine;
using System.Collections;

public class Collector : Entities
{
		public float timerD = 10;
		public float time = 10;
		public LayerMask whatMoney;
		public float radius;
		public int currentObjects;
		public bool destroyOnCollect;
		// Use this for initialization
		void Start ()
		{
				thisL.addEntity (this);
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				time -= Time.deltaTime;

				if (time < 1) {
						Collider[] c = Physics.OverlapSphere (transform.position, radius, whatMoney);
						currentObjects = c.Length;
					
						foreach (Collider ca in c) {
								if (destroyOnCollect)
										Destroy (ca.gameObject);
								thisM.cash += ca.GetComponent<Boxes> ().value;
								
				
						}
						time = (int)timerD;
				}
		}

		
}
