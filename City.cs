using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TanUppg3
{
    //deklarera om properties är private/public ect 
    class City
    {
            string Namn { get; set; }
            int AntalInvanare { get; set; }
            int Medelinkomst { get; set; }
            int AntalTuristerPerAr { get; set; }
            List<Accommodation> Accommodations { get; set; }
            int AntalAccomodations { get; set; }
            double Medelkostnaden { get; set; }

            public City(string namn, int antalinvanare, int medelinkomst, int antalturisterperar, int antalaccomodations, double medelkostnaden)
            {
                this.Namn = namn;
                this.AntalInvanare = antalinvanare;
                this.Medelinkomst = medelinkomst;
                this.AntalTuristerPerAr = antalturisterperar;
                Accommodations = new List<Accommodation>();
                this.AntalAccomodations = Accommodations.Count;
                this.Medelkostnaden = 0;

            {
                //  Denna del av koden (datakonverteringen) ska inte vara i Classen City.   Kan inte testköra din kod, så jag vet inte om detta funkar, men du bör flytta denna del till "Form1.Designer.cs". 
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "server=(local);Integrated Security=True; initial catalog=uppg3";
                conn.Open();

                SqlCommand myQuery = new SqlCommand("SELECT * FROM " + Namn + ";", conn);
                SqlDataReader myReader = myQuery.ExecuteReader();

                int parsedResult;
                int x = 0;
                while (myReader.Read())
                {
                    int.TryParse(myReader[14].ToString(), out parsedResult);
                    Accommodations.Add(
                        new Accommodation(
                            int.Parse(myReader[0].ToString() ?? "0"),//int 
                            int.Parse(myReader[2].ToString() ?? "0"),//int
                            myReader[3].ToString() ?? "null",
                            myReader[6].ToString() ?? "null",
                            myReader[7].ToString() ?? "null",
                            int.Parse(myReader[8].ToString() ?? "0"),//int
                            double.Parse(myReader[9].ToString() ?? "0.0"),
                            int.Parse(myReader[10].ToString() ?? "0"),//int
                            int.Parse(myReader[11].ToString() ?? "0"), //int
                            int.Parse(myReader[13].ToString() ?? "0"),//int
                            parsedResult,//int
                            double.Parse(myReader[17].ToString() ?? "0.0"),
                            double.Parse(myReader[18].ToString() ?? "0.0"),
                            myReader[16].ToString() ?? "null"
                        )
                    );
                    Medelkostnaden = Medelkostnaden + int.Parse(myReader[13].ToString() ?? "0");
                    x++;
                }
                Accommodations = Accommodations;
                Medelkostnaden = Medelkostnaden / Accommodations.Count;
                conn.Close();
            }
        }
    }

