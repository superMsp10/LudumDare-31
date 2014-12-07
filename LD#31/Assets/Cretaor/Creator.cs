using UnityEngine;
using System.Collections;

public class Creator : Entities
{
		public int spawnSpeed;
		public int miss = 10;
		public int objectV;
		public float time = 10;
		public GameObject[] ins;
		public int spawnAmount;
		public GameObject target;

		void Start ()
		{
				thisL.addC (this);

		}

		public void UpdateEntity ()
		{
				time -= Time.deltaTime;
		

				if (time < 1) {

						time = (int)spawnSpeed;
						spwnR ();
				}

		
		}

		void spwnR ()
		{

				GameObject thig = ins [Random.Range (0, ins.Length)];
				spawn (objectV, thig);
				


		}

		public void spawn (int sa, GameObject wat)
		{
			
				for (int i = 0; i < spawnAmount; i++) {
						Vector3 targetOri = target.transform.position;
						Vector3 targetPos = new Vector3 (targetOri.x + i + (Random.Range (-miss, miss)),
			                                 targetOri.y + i + (Random.Range (-miss, miss))
			                                 , targetOri.z + i + (Random.Range (-miss, miss)));
						Vector3 pos = new Vector3 (transform.position.x + i, transform.position.y + i, transform.position.z + i);
						GameObject g = (GameObject)Instantiate (wat, pos, Quaternion.identity);
						g.rigidbody.velocity = (Vector3.Normalize (targetPos - pos) * sa);
						Entities en = g.GetComponent<Entities> ();
						en.thisL = thisL;
						en.thisM = thisM;
				}

		}


}
