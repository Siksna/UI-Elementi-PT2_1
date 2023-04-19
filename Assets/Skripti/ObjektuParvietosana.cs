using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler,IDragHandler,IEndDragHandler {

	public Canvas kanva;
	private RectTransform transformacijaslogs;
	// Use this for initialization
	void Start () {
		transformacijaslogs = GetComponent<RectTransform> ();

	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Izdarits kreisais klikskis uz velkama objekta");
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta vilksana");
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek objektu vilksana");
		transformacijaslogs.anchoredPosition+=notikums.delta/kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigas objekta vilksanai");
	}
	// Update is called once per frame

}
