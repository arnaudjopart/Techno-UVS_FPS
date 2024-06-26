using System;
using System.IO;
using System.Linq;
using UnityEngine;

public class DataReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Debug.Log(Application.dataPath);
            var reader = new StreamReader(Application.dataPath+"/Data/data.txt");
            var line = reader.ReadLine();
            double result = 0;
            while (line!=null) 
            {
                var collection = line.ToCharArray();

                var first = collection.First(item => char.IsDigit(item));
                var last = collection.Last(item => char.IsDigit(item));

                var combine = char.GetNumericValue(first) * 10 + char.GetNumericValue(last);
        
                result += combine;



                line = reader.ReadLine();
            }

            reader.ReadLine();
            reader.Close();
            Debug.Log(result);

        }
        catch(FileNotFoundException _e)
        {
            Debug.Log("No file found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
