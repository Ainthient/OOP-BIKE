using System;
using System.Collections.Generic;
using System.Net;
using BIKESobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BIKESobj.ApplicationServices.Synchronization
{
    public class BIKESobj_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public BIKESobj_inf Cells { get; set; }
    }

    public class BIKESobj_inf
    {
        public string Name { get; set; }

        public string DepartamentalAffiliation { get; set; }

        public string Width { get; set; }

        public string Location { get; set; }
        public string ObjectOperOrgPhone { get; set; }
    }


    public class UseCaseBIKESobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/897/rows?api_key=91707b77a1c75f740bddcfb96443b307";

        List<BIKESobj_Cell> bikesobj_cells;

        public List<bikesobj> bikesobjs = new List<bikesobj>();

        public UseCaseBIKESobj()
        {
            
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();

            
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();

            JArray jsonArray = JArray.Parse(line);

            bikesobj_cells = JsonConvert.DeserializeObject<List<BIKESobj_Cell>>(jsonArray.ToString());


            for (int i = 0; i < bikesobj_cells.Count; i++)
            {
                bikesobjs.Add(new bikesobj()
                {
                    Name = bikesobj_cells[i].Cells.Name,
                    Id = bikesobj_cells[i].Number,
                    DepartamentalAffiliation = bikesobj_cells[i].Cells.DepartamentalAffiliation,
                    Width = bikesobj_cells[i].Cells.Width,
                    Location = bikesobj_cells[i].Cells.Location,
                    ObjectOperOrgPhone = bikesobj_cells[i].Cells.ObjectOperOrgPhone
                });
                
            }
        }

    }
}