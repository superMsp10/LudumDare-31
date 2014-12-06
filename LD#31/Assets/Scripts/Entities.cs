using UnityEngine;
using System.Collections;

using UnityEngine.Serialization;

[System.Serializable]
public class DestroyDetails
{
	
		public bool destroyOnAwake;			// Whether or not this gameobject should destroyed after a delay, on Awake.
		public float awakeDestroyDelay;		// The delay for destroying it on Awake.
	
	
}

public class Entities : MonoBehaviour
{
		
		
		public Levels thisL;
		public GameManeger thisM;
		public DestroyDetails demD;
		// Use this for initialization
		void Start ()
		{
				thisL.addEntity (this);
				
		}
		
		void Awake ()
		{


				if (demD.destroyOnAwake) {
						Destroy (this.gameObject,demD.awakeDestroyDelay);
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
		
		void OnDestroy ()
		{
				thisL.deleteEntity (this);
		}
}

