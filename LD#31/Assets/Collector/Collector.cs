using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collector : Entities
{
		public float timerD = 10;
		public float time = 10;
		public LayerMask whatMoney;
		public float radius;
		public int currentObjects;
		public bool destroyOnCollect;
		public Text collecterUI;
		// Use this for initialization
		void Start ()
		{
				thisL.addCol (this);

				
		}
	
		// Update is called once per frame

		
		public void UpdateEntity ()
		{

				time -= Time.deltaTime;
				collecterUI.text = "Time Left : " + ((int)time).ToString ();
				if (time < 1) {
						Collider[] c = Physics.OverlapSphere (transform.position, radius, whatMoney);
						currentObjects = c.Length;
					
						foreach (Collider ca in c) {
								if (destroyOnCollect)
										Destroy (ca.gameObject);
								thisM.thisPlay.cash += ca.GetComponent<Boxes> ().value;
								
				
						}
						time = (int)timerD;
				}


		
		}


}