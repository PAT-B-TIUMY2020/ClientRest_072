﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_20180140072_Nuraini.Program;

namespace ClientRest_20180140072_Nuraini
{
    class ClassData

    { 
        public void getData()
    {
        //var type data yang tidak peduli pada bentuk, tapi isinya
        var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
        var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

        /*for (int i = 0; i < data.Count; i++)
       {
       Console.WriteLine(data[i].nim);
       Console.WriteLine(data[i].nama);
       Console.WriteLine(data[i].prodi);
       Console.WriteLine(data[i].angkatan);
       }*/

        foreach (var mhs in data)
        {
            Console.WriteLine("Nama: " + mhs.nama);
            Console.WriteLine("NIM: " + mhs.nim);
            Console.WriteLine("Prodi: " + mhs.prodi);
            Console.WriteLine("Angkatan: " + mhs.angkatan);
        }
        Console.ReadLine();
    }
}
}