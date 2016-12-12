﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class CSV {
	static CSV csv;
	public List<string[]> m_ArrayData;

	public static CSV GetInstance() {
		if (csv == null) {
			csv = new CSV();
		}
		return csv;
	}

	private CSV() {
		m_ArrayData = new List<string[]> ();
	}

	public string getString (int row, int col) {
		return m_ArrayData [row] [col];
	}

	public int getInt (int row, int col) {
		return int.Parse (m_ArrayData [row] [col]);
	}

	public void LoadFile (string path, string fileName) {
		m_ArrayData.Clear ();
		StreamReader sr = null;
		try{
			sr = File.OpenText(path + "//" + fileName);
			Debug.Log("file found!");
		} catch {
			Debug.Log ("cannot find file!");
			return;
		}
		string line;
		while ((line = sr.ReadLine ())!=null) {
			m_ArrayData.Add (line.Split(','));
		}
		sr.Close ();
		sr.Dispose ();
	}
}
